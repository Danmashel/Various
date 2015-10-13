using aejw.Network;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;


namespace FirstRun
{
    class MakeItSo
    {
        GeneralMethods gm = new GeneralMethods();
        public string mapNetworkDrives(string softwareLocation, string backupLocation, string username, string password)
        {
            NetworkDrive NDT = new aejw.Network.NetworkDrive();
            NetworkDrive NDS = new aejw.Network.NetworkDrive();
            try
            {
                NDT.LocalDrive = "t:";
                NDT.ShareName = backupLocation;
                NDT.Persistent = true;
                NDT.SaveCredentials = true;
                NDT.MapDrive(username, password);

                NDS.LocalDrive = "s:";
                NDS.ShareName = softwareLocation;
                NDS.Persistent = true;
                NDS.SaveCredentials = true;
                NDS.MapDrive(username, password);

                return "...Success";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "...Failed. Check your paths, username, and password.";
            }
        }

        public string pingGoogle()
        {
            Ping p = new Ping();
            PingReply r = p.Send("8.8.8.8");
            if (r.Status == IPStatus.Success)
                return "...Success";
            else
                return "Failed. Could not reach the internet";
        }

        public string updateTime()
        {
            Process.Start(@"CMD.exe", "win32tm /resync");
            return "...Success";
        }

        public string installSoftPack()
        {
            if (File.Exists(@"C:\ITSDTemp\SoftPack.exe"))
            {
                Process.Start(@"C:\ITSDTemp\SoftPack.exe");
                return "...Success";
            }
            else
                return @"Failed. C:\ITSDTemp\SoftPack.exe does not exist or has been renamed";
        }

        public string disablePowerOptions()
        {
            Process.Start(@"powercfg", "-x -standby-timeout-ac 0");
            Process.Start(@"powercfg", "-x -monitor-timeout-ac 0");
            return "...Success";
        }

        public string installESET()
        {
            if (File.Exists(@"C:\ITSDTemp\Eset64.msi"))
            {
                Process.Start(@"C:\ITSDTemp\Eset64.msi", "/qn");
                return "...Success";
            }
            else
                return @"Failed. C:\ITSDTemp\Eset64.msi does not exist or has been renamed";
        }

        public string windowsUpdate()
        {
            if (File.Exists(@"C:\ITSDTemp\WinUpdate.vbs"))
            {
                Process.Start(@"cscript /B /Nologo C:\ITSDTemp\WinUpdate.vbs");
                return "...Success";
            }
            else
                return @"Failed. C:\ITSDTemp\WinUpdate.vbs does not exist or has been renamed";
        }

        public string addWSUS(string location, string port)
        {
            if (Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true) == null)
            {
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate");
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU");
                }
                catch (Exception e)
                {
                    gm.updateLog("Could not create WSUS registry key", " ");
                    Console.WriteLine(e);
                }
            }

            try
            {
                RegistryKey WUServer = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true);
                RegistryKey WUStatusServer = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true);
                RegistryKey AUOptions = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true);
                RegistryKey NoAutoUpdate = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true);
                RegistryKey ScheduledInstallDay = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true);
                RegistryKey ScheduledInstallTime = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true);
                RegistryKey UseWUServer = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true);

                WUServer.SetValue("WUServer", @"http://" + location + ":" + port, RegistryValueKind.String);
                WUStatusServer.SetValue("WUStatusServer", @"http://" + location + ":" + port, RegistryValueKind.String);
                AUOptions.SetValue("AUOptions", "3", RegistryValueKind.DWord);
                NoAutoUpdate.SetValue("NoAutoUpdate", "0", RegistryValueKind.DWord);
                ScheduledInstallDay.SetValue("ScheduledInstallDay", "0", RegistryValueKind.DWord);
                ScheduledInstallTime.SetValue("ScheduledInstallTime", "3", RegistryValueKind.DWord);
                UseWUServer.SetValue("UseWUServer", "1", RegistryValueKind.DWord);

                WUServer.Close();
                WUStatusServer.Close();
                AUOptions.Close();
                NoAutoUpdate.Close();
                ScheduledInstallDay.Close();
                ScheduledInstallTime.Close();
                UseWUServer.Close();

                gm.updateLog("Since you are using a local WSUS server you will have to update manually", ".");
                return "...Success";
            }
            catch (Exception e)
            {
                gm.updateLog("Error occured while setting WSUS registry keys. Please make sure you're running as Admin", " ");
                Console.WriteLine(e);
                return "...Failed";
            }
        }
    }
}
