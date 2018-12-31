using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DebugPlugin.EmulatorClasses
{
    public static class Nox
    {
        public static string NoxDirectory;
        
        public static bool IsNoxInstalled()
        {
            const string keyName = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Nox";
            const string valueName = "DisplayName";
            
            using (var key = Registry.LocalMachine.OpenSubKey(keyName))
            {
                if (key == null) return false;
                
                var value = key.GetValue(valueName);
                return value != null;
            }
        }

        public static void StartNox()
        {
            if (!IsNoxInstalled()) return;
            
            var noxDir = GetNoxPath();
            if (noxDir == null) return;

            var noxExePath = noxDir + @"\Nox.exe";
            
            DebugForm.AddBotLog("Found the path for NOX: " + noxExePath);

            Process.Start(noxExePath);

            WaitForEmulator();
        }

        private static void WaitForEmulator()
        {
            var adbPath = NoxDirectory + @"\nox_adb.exe";

            new Process
            {
                StartInfo =
                {
                    FileName = adbPath,
                    Arguments = "kill-server",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            }.Start();

            while (true)
            {
                var adbProcess = new Process
                {
                    StartInfo =
                    {
                        FileName = adbPath,
                        Arguments = "shell getprop dev.bootcomplete",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                adbProcess.Start();
            
                var output = adbProcess.StandardOutput.ReadToEnd();
                
                if (output.Contains("1"))
                {
                    DebugForm.AddBotLog(output);
                    break;
                }

                adbProcess.WaitForExit();
                
                Thread.Sleep(500);
            }
        }

        private static string GetNoxPath()
        {
            const string keyName = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Nox";
            const string valueName = "UninstallString";
            
            using (var key = Registry.LocalMachine.OpenSubKey(keyName))
            {
                if (key == null) return null;
                
                var value = key.GetValue(valueName);

                if (value.ToString().Length <= 0) return null;
                
                var noxDirectoryInt = value.ToString().LastIndexOf('\\');
                
                NoxDirectory = value.ToString().Substring(0, noxDirectoryInt); 
                return value.ToString().Substring(0, noxDirectoryInt);
            }
        }
    }
}