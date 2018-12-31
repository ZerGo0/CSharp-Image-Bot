using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BotTemplate.Helpers
{
    public class Clicks
    {
        #region Click WinApi
        
        public static void ClickUsingSend(IntPtr wndHandle, int x, int y, int numClicks = 1, int delay = 1, string button = "left")
        {
            for (var i = 0; i < numClicks; i++)
            {
                SendMessage(wndHandle, 0x201, 1, CreateLParam(x,y));
                SendMessage(wndHandle, 0x202, 0, CreateLParam(x,y));
                Thread.Sleep(delay);
            }
        }

        public static void ClickUsingPost(IntPtr wndHandle, int x, int y, int numClicks = 1, int delay = 1, string button = "left")
        {
            for (var i = 0; i < numClicks; i++)
            {
                PostMessage(wndHandle, 0x201, 1, CreateLParam(x,y));
                PostMessage(wndHandle, 0x202, 0, CreateLParam(x,y));
                Thread.Sleep(delay);
            }
        }
        
        private static IntPtr CreateLParam(int LoWord, int HiWord)
        {
            return (IntPtr)((HiWord << 16) | (LoWord & 0xffff));
        }
        
        [DllImport("user32.dll")]
        private static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        private static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray)] [In]
            INPUT[] pInputs, int cbSize);

        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();


        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr PostMessage(IntPtr hWnd, uint msg, int  wParam, IntPtr lParam);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, int  wParam, IntPtr lParam);
        
        #endregion

        #region ClickUsingMouse

        public static void ClickUsingMouse(IntPtr wndHandle, Point clientPoint)
        {
            var oldPos = Cursor.Position;
            var oldFocus = GetForegroundWindow();
            ClientToScreen(wndHandle, ref clientPoint);
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);
            
            var inputMouseDown = new INPUT { Type = 0 };
            inputMouseDown.Data.Mouse.Flags = 0x0002;
            
            var inputMouseUp = new INPUT { Type = 0 };
            inputMouseUp.Data.Mouse.Flags = 0x0004;

            var inputs = new[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            Cursor.Position = oldPos;
            //Please kill me 
            ShowWindow(oldFocus, 9);
            SetForegroundWindow(oldFocus);
        }
        
        private struct INPUT
        {
            public uint Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)] public MOUSEINPUT Mouse;
        }

        private struct MOUSEINPUT
        {
            public int X;
            public int Y;
            public uint MouseData;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        #endregion
    }
}
