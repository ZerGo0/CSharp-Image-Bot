using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace BotTemplate.EmulatorClasses
{
    internal class ADB
    {
        public string RunADB(string arguments)
        {
            var noxHostKey = Nox.NoxInstances.FirstOrDefault(x => x.Key == DebugForm.SelectedEmuInstance.Text).Value;

            var adbProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ADBPath(),
                    Arguments = "-s " + noxHostKey + " " + arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            adbProcess.Start();
            adbProcess.WaitForExit();
            
            return adbProcess.StandardOutput.ReadToEnd();
        } 
        
        private string ADBPath()
        {
             return new Nox().GetNoxPath() + "\\nox_adb.exe";
        }
        
        public Bitmap ADBScreenshot()
        {
            var timer = new Stopwatch();
            timer.Start();
            var debug = RunADB("shell screencap -p /mnt/shared/Image/ADBCapture_" + DebugForm.SelectedEmuInstance.Text + ".png");
            DebugForm.Log(debug);

            timer.Stop();
            DebugForm.WarningLog("ADB Screencap done after " + timer.ElapsedMilliseconds + "ms!");
            
            Bitmap tempBitmap;
            using(var image = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Nox_share\Image\ADBCapture_" + DebugForm.SelectedEmuInstance.Text + ".png"))
            {
                tempBitmap = new Bitmap(image);
            }
            
            return tempBitmap;
        }

        public void ADBClick(int x, int y, int amount)
        {
            RunADB("shell input tap " + x + " " + y );
        }

        public string ADBStartApp(string packageName, string activityName)
        {
            return RunADB("shell \"am start -n " + packageName + "/" + activityName + "\"");
        }

        public string ADBAppInstalled(string packageName)
        {
            return RunADB("shell pm list packages " + packageName);
        }
        
        public string ADBStopApp(string packageName)
        {
            return RunADB("shell am force-stop " + packageName);
        }
        
        public string ADBCurActiveApp()
        {
            return RunADB("shell \"dumpsys window windows | grep -E 'mCurrentFocus|mFocusedApp'\"");
        }
        
        
    }
}