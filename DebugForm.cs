using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BotTemplate.Helpers;

namespace DebugPlugin
{
    public partial class DebugForm : Form
    {
        private const string WindowTitle = "LDPlayer";
        private const string ControlTitle = "TheRender";

        private const string ImagePath = @"G:\SourceCodes\DHC_Bot\DHC_Bot\Images";

        public static IntPtr WindowHandle;
        public static IntPtr ControlHandle;
        public static Rectangle WindowRect;
        public static PictureBox DebugPictureBox;
        private Button button1;
        private Button button2;
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
                MainLoop();
            }).Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            BotStarted = false;
            AddBotLog("Bot stopped!");
        }

        private void MainLoop()
        {
            DebugPictureBox = DebugImageBox;
            while (BotStarted)
            {
                //if (!CheckIfAppilcationExists()) return;

                //ClickNew(3100, 1000);
                /*GetWindowRect((IntPtr)0x000F125C, out WindowRect);
                DebugPictureBox = DebugImageBox;
                var mainSceen = ImageSearch.ImageSearchEmgu(new[]
                {
                    ImagePath + @"\Test.bmp"
                }, 0.95);
                if (mainSceen) ClickNew(240, 260);*/

                var test = CaptureImage.GDI.CaptureWindowGDI(FindWindow(null, "League of Legends"));
                DebugPictureBox.Invoke(new MethodInvoker(delegate { DebugPictureBox.Image = test; }));

                //if (CheckMainScreen())
                //{
                //    if (FarmAdvMan.Checked) FarmAdventure();
                //}
                //
                Thread.Sleep(500);
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);

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
                ControlHandle = FindWindow(WindowNameBox.Text, ControlNameBox.Text);
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

        #region Test Bot Routines

        //private bool CheckMainScreen()
        //{
        //    ImageSearchClass.FindClickEmgu(ImagePath + @"\MainScreen\Ad1.bmp", 0.97);
        //    ImageSearchClass.FindClickEmgu(ImagePath + @"\MainScreen\Ad2.bmp", 0.97);
        //
        //    var mainSceen = ImageSearchClass.ImageSearchEmgu(new[]
        //    {
        //        ImagePath + @"\MainScreen\MainScreen1.bmp",
        //        ImagePath + @"\MainScreen\MainScreen2.bmp",
        //        ImagePath + @"\MainScreen\MainScreen3.bmp",
        //        ImagePath + @"\MainScreen\MainScreen4.bmp"
        //    }, 0.98);
        //
        //    if (mainSceen) AddBotLog("MainScreen Located!");
        //
        //    return mainSceen;
        //}

        //private void FarmAdventure()
        //{
        //    if (CheckMainScreen())
        //    {
        //        ClickWindow.ClickUsingMouse(WindowHandle, new Point(760, 580));
        //        ImageSearchClass.WaitForImageAndClick(ImagePath + @"\Adventure\AdventurePic.bmp", 0.98);
        //        //ClickOnPoint(WindowHandle, new Point(170, 450));
        //        ImageSearchClass.WaitForImageAndClick(ImagePath + @"\Adventure\AdventureBattle1.bmp", 0.98);
        //        //ClickOnPoint(WindowHandle, new Point(650, 450));
        //        Thread.Sleep(500);
        //
        //        var skip = ImageSearchClass.ImageSearchEmgu(new[]
        //        {
        //            ImagePath + @"\Adventure\AdventureSkip.bmp"
        //        }, 0.98);
        //        if (skip) ClickWindow.ClickUsingMouse(WindowHandle, new Point(730, 525));
        //
        //        ImageSearchClass.WaitForImage(new[] { ImagePath + @"\Adventure\AdventureBattle2.bmp" }, 0.98);
        //        ClickWindow.ClickUsingMouse(WindowHandle, new Point(650, 510));
        //
        //        ImageSearchClass.WaitForImage(new[] { ImagePath + @"\Adventure\AdventureInBattle.bmp" }, 0.99);
        //        Thread.Sleep(2000);
        //        ImageSearchClass.FindClickEmgu(ImagePath + @"\Adventure\AdventureAutoOff.bmp", 0.85);
        //
        //        ImageSearchClass.WaitForImage(new[]
        //            {
        //                ImagePath + @"\Adventure\AdventureOK.bmp",
        //                ImagePath + @"\Adventure\AdventureSell.bmp",
        //                ImagePath + @"\Adventure\AdventureBattleLost.bmp"
        //            }
        //            , 0.98);
        //    }
        //}

        #endregion

        #region Debug Capture

        private void ScreenCapButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            DebugImageBox.Image = CaptureImage.CaptureFromScreen(WindowRect);
        }

        private void GDICapButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            DebugImageBox.Image = CaptureImage.GDI.CaptureWindowGDI(WindowHandle);
        }

        private void DWMCapButton_Click(object sender, EventArgs e)
        {
            AddBotLog("No function yet!");
        }

        #endregion

        private void EMGUISButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;

            //var debugEMGUIS = ImageSearchClass.ImageSearchEmgu(new[] { ImagePathBox.Text });
            //AddBotLog(debugEMGUIS ? "Found the image!" : "Couldn't find the image!");
        }

        private void AutoItISButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;

            var debugAutoItIS = ImageSearchClass.ImageSearchAutoIt(ImagePathBox.Text, WindowRect, "45");
            AddBotLog(debugAutoItIS != null ? "Found the image!" : "Couldn't find the image!");
        }

        private void CSharpISButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;

            if (string.IsNullOrWhiteSpace(ImagePathBox.Text)) return;


        }

        private void ClickPostMSGButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;
        }

        private void ClickMouseButton_Click(object sender, EventArgs e)
        {
            if (!GetWindow()) return;
        }
    }
}