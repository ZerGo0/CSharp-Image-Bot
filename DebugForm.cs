using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AutoIt;
using BotTemplate.Helpers;

namespace DebugPlugin
{
    public partial class DebugForm : Form
    {
        private const string WindowTitle = "Application Title";
        private const string ControlTitle = "Controlname";

        public static IntPtr WindowHandle;
        public static IntPtr ControlHandle;
        public static Rectangle WindowRect;
        public static PictureBox DebugPictureBox;
        private bool BotStarted;

        public DebugForm()
        {
            InitializeComponent();
        }

        private void MainBotForm_Load(object sender, EventArgs e)
        {
            DebugPictureBox = DebugImageBox;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            AddBotLog("Bot started!");
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                BotStarted = true;
                
            }).Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            BotStarted = false;
            AddBotLog("Bot stopped!");
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindow(IntPtr hWnd);

        private bool CheckIfAppilcationExists()
        {
            WindowHandle = FindWindow(null, WindowTitle);

            if (!string.IsNullOrWhiteSpace(ControlTitle))
            {
                ControlHandle = FindWindow(WindowTitle, ControlTitle);
                if (!IsWindow(WindowHandle) || !IsWindow(ControlHandle))
                {
                    BotStarted = false;
                    AddBotLog("Application not started, stopping the bot!");
                    return false;
                }

                GetWindowRect(ControlHandle, out WindowRect);
            }
            else
            {
                if (!IsWindow(WindowHandle))
                {
                    BotStarted = false;
                    AddBotLog("Application not started, stopping the bot!");
                    return false;
                }

                GetWindowRect(WindowHandle, out WindowRect);
            }

            return true;
        }

        private void AddBotLog(string text)
        {
            BotLog.Invoke(new MethodInvoker(delegate
            {
                BotLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + text + "\r\n");
            }));
        }

        private bool GetWindow()
        {
            if (string.IsNullOrWhiteSpace(WindowNameBox.Text) && string.IsNullOrWhiteSpace(ControlNameBox.Text))
            {
                AddBotLog("Please enter a window- and/or a controlname!");
                return false;
            }

            WindowHandle = FindWindow(null, WindowNameBox.Text);

            if (!string.IsNullOrWhiteSpace(ControlNameBox.Text))
            {
                ControlHandle = AutoItX.ControlGetHandle(WindowHandle, ControlNameBox.Text);
                if (!IsWindow(WindowHandle) && !IsWindow(ControlHandle))
                {
                    BotStarted = false;
                    AddBotLog("Application not found, stopping!");
                    return false;
                }

                GetWindowRect(ControlHandle, out WindowRect);
            }
            else
            {
                if (!IsWindow(WindowHandle))
                {
                    BotStarted = false;
                    AddBotLog("Application not found, stopping!");
                    return false;
                }

                GetWindowRect(WindowHandle, out WindowRect);
            }

            return true;
        }

        #region Debug Capture

        private void ScreenCapButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;

            DebugImageBox.Image = CaptureImage.CaptureFromScreen(WindowRect);
        }

        private void GDICapButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;

            DebugImageBox.Image = CaptureImage.CaptureWindowGDI(WindowHandle);
        }

        private void DWMCapButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;
            
            CaptureImage.CaptureDWM();
        }

        #endregion

        private void EMGUISButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;

            var timer = new Stopwatch();
            timer.Start();
            
            var debugEMGUIS = ImageSearchClass.ImageSearchEmgu(new[] { ImagePathBox.Text });
            
            timer.Stop();
            AddBotLog(debugEMGUIS ? "Found the image! It took " + timer.ElapsedMilliseconds + "ms to find it!" : "Couldn't find the image!");
        }

        private void AutoItISButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;
            
            var timer = new Stopwatch();
            timer.Start();

            var debugAutoItIS = ImageSearchClass.ImageSearchAutoIt(ImagePathBox.Text, WindowRect, "45");
            
            timer.Stop();
            AddBotLog(debugAutoItIS != null ? "Found the image! It took " + timer.ElapsedMilliseconds + "ms to find it!" : "Couldn't find the image!");
        }

        private void CSharpISButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;


        }

        private void ClickPostMSGButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            Clicks.ClickInBackground(ControlHandle != (IntPtr) 0x0 ? ControlHandle : WindowHandle, 100, 100);
        }

        private void ClickMouseButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;
            
            Clicks.ClickUsingMouse(ControlHandle != (IntPtr) 0x0 ? ControlHandle : WindowHandle, new Point(100, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CaptureImage.DWMFunctions.StopDWM();
        }
    }
}