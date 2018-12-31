using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DebugPlugin.EmulatorClasses
{
    public static class Nox
    {
        public static string NoxDirectory;
        public static Dictionary<string, string> NoxInstances;
        
        public static bool IsNoxInstalled()
        {
            const string keyName = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Nox";
            const string valueName = "DisplayName";
            
            using (var key = Registry.LocalMachine.OpenSubKey(keyName))
            {
                var value = key?.GetValue(valueName);
                if (value == null) return false;
                
                GetNoxPath();
                return true;
            }
        }

        public static void StartNox()
        {
            if (!IsNoxInstalled()) return;

            var noxExePath = NoxDirectory + @"\Nox.exe";
            
            DebugForm.AddBotLog("Found the path for NOX: " + noxExePath);

            if (DebugForm.SelectedEmuInstance.Items.Count > 0)
            {
                Process.Start(noxExePath, "-clone:" + DebugForm.SelectedEmuInstance.SelectedItem);
            }
            else
            {
                Process.Start(noxExePath);
            }

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

        public static IEnumerable<string> ListNoxInstances()
        {
            if (!IsNoxInstalled()) return null;
            
            var matchingFiles = Directory.GetFiles(NoxDirectory + @"\BignoxVMS", "*.vbox", SearchOption.AllDirectories);

            
            NoxInstances = new Dictionary<string, string>();
            foreach (var file in matchingFiles)
            {
                var hostIp = "";
                var hostPort = "";
                foreach (var line in File.ReadLines(file))
                {
                    if (!line.Contains("guestport=\"5555\"/>")) continue;

                    var i = 0;
                    foreach (var value in Regex.Matches(line, "\\\"(.*?)\\\""))
                    {
                        switch (i)
                        {
                            case 2:
                                hostIp = value.ToString().Trim('"');
                                break;
                            case 3:
                                hostPort = value.ToString().Trim('"');
                                break;
                        }

                        i++;
                    }
                    break;
                }

                var instancePathInt = file.LastIndexOf('\\');
                var instanceFile = file.Substring(instancePathInt + 1);
                var instanceNameInt = instanceFile.LastIndexOf('.');
                var instanceName= instanceFile.Substring(0, instanceNameInt);
                
                DebugForm.AddBotLog(instanceName + " Host: " + hostIp + " Port: " + hostPort);
                
                NoxInstances.Add(instanceName, hostIp + ":" + hostPort);
            }
            
            var instances = (from item in matchingFiles let instancePathInt = item.LastIndexOf('\\') select item.Substring(instancePathInt + 1) into instanceFile let instanceFileInt = instanceFile.LastIndexOf('.') select instanceFile.Substring(0, instanceFileInt)).ToList();
            
            return instances;
        }
        
        /*
        
        public bool IsGameActive()
        {
            return this.Adb("shell dumpsys window windows | grep mCurrentFocus").Contains(BlueStacks.ACTIVITY_NAME);
        }

        public bool IsGameInstalled()
        {
            return this.Adb("shell pm list packages " + BlueStacks.PACKAGE_NAME).Contains(BlueStacks.PACKAGE_NAME);
        }
        
        public void LaunchGame()
        {
            this.Adb("shell am start -n " + BlueStacks.ACTIVITY_NAME);
        }
        
        public void TerminateGame()
        {
            this.Adb("shell am force-stop " + BlueStacks.PACKAGE_NAME);
        }
         */
    }
}