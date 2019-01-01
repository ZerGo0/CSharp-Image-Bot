using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;

namespace BotTemplate.EmulatorClasses
{
    internal class Nox
    {
        public static string NoxDirectory;
        public static Dictionary<string, string> NoxInstances;
        
        public bool IsNoxInstalled()
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

        public void StartNox()
        {
            if (!IsNoxInstalled()) return;
            
            if (InstanceAlreadyRunning(DebugForm.SelectedEmuInstance.Text)) return;

            var noxExePath = NoxDirectory + @"\Nox.exe";
            
            DebugForm.AddBotLog("Found the path for NOX: " + noxExePath);

            var noxProcess = new Process();
            noxProcess = DebugForm.SelectedEmuInstance.Items.Count > 0 ? Process.Start(noxExePath, "-clone:" + DebugForm.SelectedEmuInstance.SelectedItem) : Process.Start(noxExePath);

            WaitForEmulator();

            DebugForm.WindowHandle = noxProcess.Handle;
        }

        private bool InstanceAlreadyRunning(string instanceName)
        {
            foreach (var process in Process.GetProcessesByName("Nox"))
            {
                DebugForm.AddBotLog("Opened Nox Instance: \n" + GetCommandLine(process));
                return GetCommandLine(process).Contains(instanceName);
            }

            return false;
        }

        private void WaitForEmulator()
        {
            while (true)
            {
                var adbProcessOutput = new ADB().RunADB("shell getprop dev.bootcomplete");
                
                if (adbProcessOutput.Equals("1\r\r\n"))
                {
                    DebugForm.AddBotLog(adbProcessOutput);
                    break;
                }
                
                Thread.Sleep(500);
            }
        }

        public string GetNoxPath()
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

        public IEnumerable<string> ListNoxInstances()
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
        
        private string GetCommandLine(Process process)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
            using (ManagementObjectCollection objects = searcher.Get())
            {
                return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
            }

        }
    }
}