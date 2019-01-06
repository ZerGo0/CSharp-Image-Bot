using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Management;
using System.Text;
using AutoIt;
using BotTemplate.EmulatorClasses;
using BotTemplate.Helpers;
using Timer = System.Threading.Timer;

namespace BotTemplate
{
    public partial class DebugForm : Form
    {
        private const string WindowTitle = "Application Title";
        private const string ControlTitle = "Controlname";

        public static IntPtr WindowHandle;
        public static IntPtr ControlHandle;
        public static Rectangle WindowRect;
        public static PictureBox DebugPictureBox;
        private static RichTextBox BotLogTextbox;
        public static ComboBox SelectedEmuInstance;
        private bool BotStarted;

        private ADB Adb;
        private Clicks Clicks;
        private ImageSearchClass ImageSearch;
        private CaptureImage CaptureImage;
        private Nox Nox;

        public DebugForm()
        {
            InitializeComponent();
        }

        private void MainBotForm_Load(object sender, EventArgs e)
        {
            DebugPictureBox = DebugImageBox;
            BotLogTextbox = BotLog;
            SelectedEmuInstance = EmulatorInstComboBox;
            
            Adb = new ADB();
            Clicks = new Clicks();
            ImageSearch = new ImageSearchClass();
            CaptureImage = new CaptureImage();
            Nox = new Nox();
            
            foreach (var item in Nox.ListNoxInstances())
            {
                Log(item);
                SelectedEmuInstance.Items.Add(item);
                SelectedEmuInstance.SelectedIndex = 0;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Log("Bot started!");
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                BotStarted = true;

                while (BotStarted)
                {
                    DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugPictureBox.Image = null; }));

                    var adbScreenCap = Adb.ADBScreenshot();
                    Log("Test1");
                    Test1(adbScreenCap);
                    Log("Test2");
                    Test2(adbScreenCap);
                    Log("Test3");
                    Test3(adbScreenCap);
                }

            }).Start();
        }

        private void Test1(Bitmap screenCap)
        {
            var timer = new Stopwatch();
            timer.Start();

            var test = ImageSearch.ImageSearchEmgu(new[] {@"G:\SourceCodes\StressTest1.bmp"}, 0.99, screenCap);
            
            timer.Stop();

            if (test)
            {
                Log($"Found Image in {timer.ElapsedMilliseconds}ms!");
            }
            else
            {
                ErrorLog($"Image not found in {timer.ElapsedMilliseconds}ms!");
            }
        }

        private void Test2(Bitmap screenCap)
        {
            var timer = new Stopwatch();
            timer.Start();
            var test = ImageSearch.ImageSearchEmgu(new[] { @"G:\SourceCodes\StressTest2.bmp" }, 0.99, screenCap);

            timer.Stop();

            if (test)
            {
                Log($"Found Image in {timer.ElapsedMilliseconds}ms!");
            }
            else
            {
                ErrorLog($"Image not found in {timer.ElapsedMilliseconds}ms!");
            }
        }

        private void Test3(Bitmap screenCap)
        {
            var timer = new Stopwatch();
            timer.Start();
            var test = ImageSearch.ImageSearchEmgu(new[] { @"G:\SourceCodes\StressTest3.bmp" }, 0.99, screenCap);

            timer.Stop();

            if (test)
            {
                Log($"Found Image in {timer.ElapsedMilliseconds}ms!");
            }
            else
            {
                ErrorLog($"Image not found in {timer.ElapsedMilliseconds}ms!");
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            BotStarted = false;
            ErrorLog("Bot stopped!");
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
                    ErrorLog("Application not started, stopping the bot!");
                    return false;
                }

                GetWindowRect(ControlHandle, out WindowRect);
            }
            else
            {
                if (!IsWindow(WindowHandle))
                {
                    BotStarted = false;
                    ErrorLog("Application not started, stopping the bot!");
                    return false;
                }

                GetWindowRect(WindowHandle, out WindowRect);
            }

            return true;
        }

        public static void Log(string text)
        {
            BotLogTextbox.Invoke(new MethodInvoker(delegate
            {
                BotLogTextbox.SelectionStart = BotLogTextbox.TextLength;
                BotLogTextbox.SelectionLength = 0;
                BotLogTextbox.SelectionColor = Color.Black;
                BotLogTextbox.AppendText((!BotLogTextbox.Lines.Any() ? "" : Environment.NewLine) + "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + text);
                BotLogTextbox.SelectionColor = Color.Black;
                ScrollToBottom(BotLogTextbox);
            }));
        }

        public static void WarningLog(string text)
        {
            BotLogTextbox.Invoke(new MethodInvoker(delegate
            {
                BotLogTextbox.SelectionStart = BotLogTextbox.TextLength;
                BotLogTextbox.SelectionLength = 0;
                BotLogTextbox.SelectionColor = Color.DarkOrange;
                BotLogTextbox.AppendText((!BotLogTextbox.Lines.Any() ? "" : Environment.NewLine) + "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + text);
                BotLogTextbox.SelectionColor = Color.Black;
                ScrollToBottom(BotLogTextbox);
            }));
        }

        public static void ErrorLog(string text)
        {
            BotLogTextbox.Invoke(new MethodInvoker(delegate
            {
                BotLogTextbox.SelectionStart = BotLogTextbox.TextLength;
                BotLogTextbox.SelectionLength = 0;
                BotLogTextbox.SelectionColor = Color.Red;
                BotLogTextbox.AppendText((!BotLogTextbox.Lines.Any() ? "" : Environment.NewLine) + "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + text);
                BotLogTextbox.SelectionColor = Color.Black;
                ScrollToBottom(BotLogTextbox);
            }));
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        private const int WM_VSCROLL = 277;
        private const int SB_PAGEBOTTOM = 7;

        private static void ScrollToBottom(RichTextBox richTextBox)
        {
            SendMessage(richTextBox.Handle, WM_VSCROLL, (IntPtr)SB_PAGEBOTTOM, IntPtr.Zero);
            richTextBox.SelectionStart = richTextBox.Text.Length;
        }

        private bool GetWindow()
        {
            if (string.IsNullOrWhiteSpace(WindowNameBox.Text) && string.IsNullOrWhiteSpace(ControlNameBox.Text))
            {
                ErrorLog("Please enter a window- and/or a controlname!");
                return false;
            }

            WindowHandle = FindWindow(null, WindowNameBox.Text);

            if (!string.IsNullOrWhiteSpace(ControlNameBox.Text))
            {
                ControlHandle = AutoItX.ControlGetHandle(WindowHandle, ControlNameBox.Text);
                if (!IsWindow(WindowHandle) && !IsWindow(ControlHandle))
                {
                    BotStarted = false;
                    ErrorLog("Application not found, stopping!");
                    return false;
                }

                GetWindowRect(ControlHandle, out WindowRect);
            }
            else
            {
                if (!IsWindow(WindowHandle))
                {
                    BotStarted = false;
                    ErrorLog("Application not found, stopping!");
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
            
            var debugEMGUIS = ImageSearch.ImageSearchEmgu(new[] { ImagePathBox.Text });
            
            timer.Stop();

            if (debugEMGUIS)
            {
                Log($"Found the image! It took {timer.ElapsedMilliseconds}ms to find it!");
            }
            else
            {
                ErrorLog("Couldn't find the image!");
            }
        }

        private void AutoItISButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;
            
            var timer = new Stopwatch();
            timer.Start();

            var debugAutoItIS = ImageSearch.ImageSearchAutoIt(ImagePathBox.Text, WindowRect, "45");
            
            timer.Stop();

            if (debugAutoItIS != null)
            {
                Log($"Found the image! It took {timer.ElapsedMilliseconds}ms to find it!");
            }
            else
            {
                ErrorLog("Couldn't find the image!");
            }
        }

        private void CSharpISButton_Click(object sender, EventArgs e)
        {
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;

            ErrorLog("Not implementet yet!");
        }

        private void ClickPostMSGButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;
            
            var x = 100;
            var y = 100;
            var amount = 1;
            
            if (ClickXCoord.Text.Length > 0) x = int.Parse(ClickXCoord.Text);
            if (ClickYCoord.Text.Length > 0) y = int.Parse(ClickYCoord.Text);
            if (ClickAmount.Text.Length > 0) amount = int.Parse(ClickAmount.Text);

            Clicks.ClickUsingPost(ControlHandle != (IntPtr) 0x0 ? ControlHandle : WindowHandle, x, y, amount);
        }

        private void ClickMouseButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            var x = 100;
            var y = 100;
            var amount = 1;
            
            if (ClickXCoord.Text.Length > 0) x = int.Parse(ClickXCoord.Text);
            if (ClickYCoord.Text.Length > 0) y = int.Parse(ClickYCoord.Text);
            if (ClickAmount.Text.Length > 0) amount = int.Parse(ClickAmount.Text);
            
            Clicks.ClickUsingMouse(ControlHandle != (IntPtr) 0x0 ? ControlHandle : WindowHandle, new Point(x, y));
        }
        
        private void ClickSendMSGButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            var x = 100;
            var y = 100;
            var amount = 1;
            
            if (ClickXCoord.Text.Length > 0) x = int.Parse(ClickXCoord.Text);
            if (ClickYCoord.Text.Length > 0) y = int.Parse(ClickYCoord.Text);
            if (ClickAmount.Text.Length > 0) amount = int.Parse(ClickAmount.Text);
            
            Clicks.ClickUsingSend(ControlHandle != (IntPtr) 0x0 ? ControlHandle : WindowHandle, x, y, amount);
        }

        private void CheckEmulatorButton_Click(object sender, EventArgs e)
        {
            var isInstalled = Nox.IsNoxInstalled();

            if (isInstalled)
            {
                Log("Emulator installed!");
            }
            else
            {
                ErrorLog("Emulator not installed!");
            }
        }

        private void StartEmuButton_Click(object sender, EventArgs e)
        {
            if (!Nox.IsNoxInstalled()) return;

            Nox.StartNox();
        }

        private void EmuListInstanButton_Click(object sender, EventArgs e)
        {
            if (!Nox.IsNoxInstalled()) return;
            
            SelectedEmuInstance.Items.Clear();
            
            foreach (var item in Nox.ListNoxInstances())
            {
                Log(item);
                SelectedEmuInstance.Items.Add(item);
                SelectedEmuInstance.SelectedIndex = 0;
            }
        }

        private void ADBScreenshotButton_Click(object sender, EventArgs e)
        {
            if (!Nox.InstanceAlreadyRunning(SelectedEmuInstance.Text)) return;
            
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugForm.DebugPictureBox.Image = null; }));
            
            var timer = new Stopwatch();
            timer.Start();
            
            DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugPictureBox.Image = Adb.ADBScreenshot(); }));
            
            timer.Stop();
            Log("ADB Screenshot done, it took " + timer.ElapsedMilliseconds + "ms!");
        }

        private void ADBClickButton_Click(object sender, EventArgs e)
        {
            if (!Nox.InstanceAlreadyRunning(SelectedEmuInstance.Text)) return;
            
            var x = 100;
            var y = 100;
            var amount = 1;
            
            if (ADBClickXTextBox.Text.Length > 0) x = int.Parse(ADBClickXTextBox.Text);
            if (ADBClickYTextBox.Text.Length > 0) y = int.Parse(ADBClickYTextBox.Text);
            if (ADBClickAmountTextBox.Text.Length > 0) amount = int.Parse(ADBClickAmountTextBox.Text);
            
            Adb.ADBClick(x, y , amount);
        }

        private void ADBClickDragButton_Click(object sender, EventArgs e)
        {

        }

        private void ADBStartAppButton_Click(object sender, EventArgs e)
        {
            if (!Nox.InstanceAlreadyRunning(SelectedEmuInstance.Text)) return;
            
            Log(Adb.ADBStartApp(ADBPackageNameTextBox.Text, ADBActivityNameTextBox.Text));
        }

        private void ADBInstalledButton_Click(object sender, EventArgs e)
        {
            if (!Nox.InstanceAlreadyRunning(SelectedEmuInstance.Text)) return;

            Log(Adb.ADBAppInstalled(ADBPackageNameTextBox.Text));
        }

        private void ADBStopAppButton_Click(object sender, EventArgs e)
        {
            if (!Nox.InstanceAlreadyRunning(SelectedEmuInstance.Text)) return;

            Log(Adb.ADBStopApp(ADBPackageNameTextBox.Text));
        }

        private void ADBAppActiveButton_Click(object sender, EventArgs e)
        {
            if (!Nox.InstanceAlreadyRunning(SelectedEmuInstance.Text)) return;

            Log(Adb.ADBCurActiveApp().Contains(ADBPackageNameTextBox.Text).ToString());
        }

        private void ADBCurActiveAppButton_Click(object sender, EventArgs e)
        {
            if (!Nox.InstanceAlreadyRunning(SelectedEmuInstance.Text)) return;

            Log(Adb.ADBCurActiveApp());
        }
    }
}