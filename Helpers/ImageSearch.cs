using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DebugPlugin;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace BotTemplate.Helpers
{
    public static class ImageSearchClass
    {
        #region ImageSearch C# (Slow, no tolerance)

        public static bool ImageSearchCSharp([MarshalAs(UnmanagedType.LPStr)] string imagePath, Rectangle window)
        {
            var screenCap = CaptureImage.CaptureFromScreen(window);

            var searchImage = new Bitmap(imagePath);

            var result = IsInCapture(searchImage, screenCap);
            return result;
        }

        private static bool IsInCapture(Bitmap searchFor, Bitmap searchIn)
        {
            for (var x = 0; x < searchIn.Width; x++)
                for (var y = 0; y < searchIn.Height; y++)
                {
                    var invalid = false;
                    int k = x, l = y;
                    for (var a = 0; a < searchFor.Width; a++)
                    {
                        l = y;
                        for (var b = 0; b < searchFor.Height; b++)
                        {
                            if (searchFor.GetPixel(a, b) != searchIn.GetPixel(k, l))
                            {
                                invalid = true;
                                break;
                            }

                            l++;
                        }

                        if (invalid)
                            break;
                        k++;
                    }

                    if (!invalid)
                        return true;
                }

            return false;
        }

        #endregion

        #region ImageSearch AutoIt (Fastest)

        [DllImport(@"G:\SourceCodes\ImageSearchDLL.dll")]
        private static extern IntPtr ImageSearch(int x, int y, int right, int bottom,
            [MarshalAs(UnmanagedType.LPStr)] string imagePath);

        public static string[] ImageSearchAutoIt([MarshalAs(UnmanagedType.LPStr)]string imgPath, Rectangle window, string tolerance = "20")
        {
            var autoitImagePath = "*" + tolerance + " " + imgPath;

            var result = ImageSearch(window.X, window.Y, window.Width, window.Height, autoitImagePath);
            var res = Marshal.PtrToStringAnsi(result);

            if (res[0] == '0') return null;

            var data = res.Split('|');
            int.TryParse(data[1], out var x);
            int.TryParse(data[2], out var y);


            //TODO: Add "if debug" here and in other IS functions
            var absWindowX = Math.Abs(window.X);
            var absWindowY = Math.Abs(window.Y);

            var resX = Math.Abs(x);
            var resY = Math.Abs(y);

            int testX;
            if (resX > absWindowX)
            {
                testX = resX - absWindowX;
            }
            else
            {
                testX = absWindowX - resX;
            }
            var testY = resY - absWindowY;

            var screenCap = CaptureImage.CaptureFromScreen(window);

            var source = new Image<Bgr, byte>(screenCap);
            var template = new Image<Bgr, byte>(imgPath);
            var imageToShow = source.Copy();
            
            var match = new Rectangle(new Point(testX, testY), template.Size);
            imageToShow.Draw(match, new Bgr(Color.Red), 2);
            
            DebugForm.DebugPictureBox.Invoke(
                new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = imageToShow.Bitmap; }));

            return data;
        }

        #endregion

        #region ImageSearch EmguCV (Fast, Accurate, easy)

        public static void WaitForImage([MarshalAs(UnmanagedType.LPStr)] string[] images, double tolerance = 0.9)
        {
            while (true)
            {
                foreach (var image in images)
                {
                    var result = ImageSearchEmgu(new[]
                    {
                        image
                    }, tolerance);
        
                    if (result) return;
                }
        
                Thread.Sleep(500);
            }
        }

        public static void WaitForImageAndClick([MarshalAs(UnmanagedType.LPStr)] string image, double tolerance = 0.9)
        {
            while (true)
            {
                var result = FindClickEmgu(image, tolerance);
        
                if (result) return;
        
                Thread.Sleep(500);
            }
        }

        public static bool FindClickEmgu([MarshalAs(UnmanagedType.LPStr)] string imagePath, double tolerance = 0.9)
        {
            //TODO: Make the capture method chooseable
            var screenCap = CaptureImage.CaptureFromScreen(DebugForm.WindowRect);
        
            var source = new Image<Bgr, byte>(screenCap);
            var imageToShow = source.Copy();
            var template = new Image<Bgr, byte>(imagePath);
        
            using (var result = source.MatchTemplate(template, TemplateMatchingType.CcorrNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
        
                if (!(maxValues[0] > tolerance)) return false;
        
                var match = new Rectangle(maxLocations[0], template.Size);
                imageToShow.Draw(match, new Bgr(Color.Red), 2);
        
                //Click location in the middle of the picture
                var clickX = maxLocations[0].X + template.Size.Width / 2;
                var clickY = maxLocations[0].Y + template.Size.Height / 2;
        
                //TODO: Switch based on selected click type
                ClickWindow.ClickUsingMouse(DebugForm.WindowHandle, new Point(clickX, clickY));
        
                DebugForm.DebugPictureBox.Invoke(new MethodInvoker(delegate
                {
                    DebugForm.DebugPictureBox.Image = imageToShow.Bitmap;
                }));
                return true;
            }
        }

        public static bool ImageSearchEmgu([MarshalAs(UnmanagedType.LPStr)] string[] imagePath, double tolerance = 0.9)
        {
            var screenCap = new Bitmap(DebugForm.WindowRect.Width - DebugForm.WindowRect.X,
                DebugForm.WindowRect.Height - DebugForm.WindowRect.Y);
        
            var g = Graphics.FromImage(screenCap);
        
            g.CopyFromScreen(DebugForm.WindowRect.X, DebugForm.WindowRect.Y, 0, 0, screenCap.Size, CopyPixelOperation.SourceCopy);
        
            var source = new Image<Bgr, byte>(screenCap);
            var imageToShow = source.Copy();
            foreach (var image in imagePath)
            {
                var template = new Image<Bgr, byte>(image);
        
                using (var result = source.MatchTemplate(template, TemplateMatchingType.CcorrNormed))
                {
                    double[] minValues, maxValues;
                    Point[] minLocations, maxLocations;
                    result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
        
                    if (!(maxValues[0] > tolerance)) return false;
        
                    var match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 2);
                }
            }
        
            DebugForm.DebugPictureBox.Invoke(
                new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = imageToShow.Bitmap; }));
        
            return true;
        }

        #endregion
    }

    public static class CaptureImage
    {
        #region Capture Screen

        public static Bitmap CaptureFromScreen(Rectangle rec)
        {
            var screenCap = new Bitmap(rec.Width - rec.X, rec.Height - rec.Y);

            var g = Graphics.FromImage(screenCap);

            g.CopyFromScreen(rec.X, rec.Y, 0, 0, screenCap.Size, CopyPixelOperation.SourceCopy);

            return screenCap;
        }

        #endregion

        #region GDI Capture Stuff

        public class Gdi32
        {
            [DllImport("gdi32.dll")]
            public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight,
                IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

            [DllImport("gdi32.dll")]
            public static extern bool DeleteDC(IntPtr hDC);

            [DllImport("gdi32.dll")]
            public static extern bool DeleteObject(IntPtr hObject);

            [DllImport("gdi32.dll")]
            public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        }

        public static class User32
        {
            [DllImport("user32.dll")]
            public static extern IntPtr GetDesktopWindow();

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

            [DllImport("user32.dll")]
            public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        public static class GDI
        {
            public static Image CaptureScreen()
            {
                return CaptureWindowGDI(User32.GetDesktopWindow());
            }

            public static Image CaptureWindowGDI(IntPtr handle)
            {
                var hdcSrc = User32.GetWindowDC(handle);

                var windowRect = new RECT();
                User32.GetWindowRect(handle, ref windowRect);

                var width = windowRect.right - windowRect.left;
                var height = windowRect.bottom - windowRect.top;

                var hdcDest = Gdi32.CreateCompatibleDC(hdcSrc);
                var hBitmap = Gdi32.CreateCompatibleBitmap(hdcSrc, width, height);

                var hOld = Gdi32.SelectObject(hdcDest, hBitmap);
                Gdi32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, 13369376);
                Gdi32.SelectObject(hdcDest, hOld);
                Gdi32.DeleteDC(hdcDest);
                User32.ReleaseDC(handle, hdcSrc);

                Image image = Image.FromHbitmap(hBitmap);
                Gdi32.DeleteObject(hBitmap);

                return image;
            }
        }

        #endregion

        #region DWM Capture Stuff

        private static readonly int GWL_STYLE = -16;

        private static readonly int DWM_TNP_VISIBLE = 0x8;
        private static readonly int DWM_TNP_OPACITY = 0x4;
        private static readonly int DWM_TNP_RECTDESTINATION = 0x1;

        private static readonly ulong WS_VISIBLE = 0x10000000L;
        private static readonly ulong WS_BORDER = 0x00800000L;
        private static readonly ulong TARGETWINDOW = WS_BORDER | WS_VISIBLE;

        [DllImport("dwmapi.dll")]
        private static extern int DwmRegisterThumbnail(IntPtr dest, IntPtr src, out IntPtr thumb);

        [DllImport("dwmapi.dll")]
        private static extern int DwmUnregisterThumbnail(IntPtr thumb);

        [DllImport("dwmapi.dll")]
        private static extern int DwmQueryThumbnailSourceSize(IntPtr thumb, out PSIZE size);

        [DllImport("dwmapi.dll")]
        private static extern int DwmUpdateThumbnailProperties(IntPtr hThumb, ref DWM_THUMBNAIL_PROPERTIES props);

        [DllImport("user32.dll")]
        private static extern ulong GetWindowLongA(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int EnumWindows(EnumWindowsCallback lpEnumFunc, int lParam);

        private delegate bool EnumWindowsCallback(IntPtr hwnd, int lParam);

        [DllImport("user32.dll")]
        public static extern void GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        private static IntPtr thumb;

        public class DWMFunctions
        {
            /*private void GetWindowDWM()
            {
                Window w = new Window() { Handle = WindowHandle, Title = WindowTitle };
    
                if (thumb != IntPtr.Zero)
                    DwmUnregisterThumbnail(thumb);
    
                int i = DwmRegisterThumbnail(Handle, w.Handle, out thumb);
    
                if (i == 0)
                    UpdateThumb();
            }
    
            private bool Callback(IntPtr hwnd, int lParam)
            {
                if (Handle != hwnd && (GetWindowLongA(hwnd, GWL_STYLE) & TARGETWINDOW) == TARGETWINDOW)
                {
                    StringBuilder sb = new StringBuilder(100);
                    GetWindowText(hwnd, sb, sb.Capacity);
    
                    if (sb.ToString().Contains("Dungeon Hunter Champions"))
                    {
                        WindowHandle = hwnd;
                        WindowTitle = sb.ToString();
                    }
                }
    
                return true; //continue enumeration
            }
    
            private void UpdateThumb()
            {
                if (thumb != IntPtr.Zero)
                {
                    PSIZE size;
                    DwmQueryThumbnailSourceSize(thumb, out size);
    
                    DWM_THUMBNAIL_PROPERTIES props = new DWM_THUMBNAIL_PROPERTIES
                    {
                        fVisible = true,
                        dwFlags = DWM_TNP_VISIBLE | DWM_TNP_RECTDESTINATION | DWM_TNP_OPACITY,
                        opacity = 255,
                        rcDestination = new Rectangle(0, 0, 500, 500)
                    };
    
                    //if (size.x < ResultBox.Width)
                    //    props.rcDestination.Right = props.rcDestination.Left + size.x;
                    //
                    //if (size.y < ResultBox.Height)
                    //    props.rcDestination.Bottom = props.rcDestination.Top + size.y;
    
                    DwmUpdateThumbnailProperties(thumb, ref props);
    
                    Bitmap b = new Bitmap(Width, Height);
                    DrawToBitmap(b, new Rectangle(0, 0, Width, Height));
    
                    DebugImageBox.Image = b;
                }
            }*/
        }

        internal class Window
        {
            public IntPtr Handle;
            public string Title;

            public override string ToString()
            {
                return Title;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct DWM_THUMBNAIL_PROPERTIES
        {
            public int dwFlags;
            public Rectangle rcDestination;
            public Rect rcSource;
            public byte opacity;
            public bool fVisible;
            public bool fSourceClientAreaOnly;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Rect
        {
            internal Rect(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct PSIZE
        {
            public int x;
            public int y;
        }

        #endregion
    }
}
