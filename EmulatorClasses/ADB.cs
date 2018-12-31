using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace DebugPlugin.EmulatorClasses
{
    public static class ADB
    {
        private static string ADBPath()
        {
             return Nox.GetNoxPath() + "\\nox_adb.exe";
        }
        
        public static Bitmap ADBScreenshot()
        {
            var adbProcess = new Process
            {
                StartInfo =
                {
                    FileName = "CMD.exe",
                    WorkingDirectory = Nox.GetNoxPath(),
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            adbProcess.Start();
            
            using (var sw = adbProcess.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(@"nox_adb.exe shell screencap -p /sdcard/screencap.png && " +
                                 "nox_adb.exe pull /sdcard/screencap.png " + Directory.GetCurrentDirectory() + 
                                 @"\ADBCapture.png");
                }
            }
            
            adbProcess.WaitForExit();
            
            return new Bitmap(Directory.GetCurrentDirectory() + @"\ADBCapture.png");
        }
    }
}