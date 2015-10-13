using aejw.Network;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRun
{
    class CleanUp
    {
        GeneralMethods gm = new GeneralMethods();
        public void cleanUp(string softwareLocation, string backupLocation, string username, string password)
        {
            //Remove WSUS
            gm.updateLog("Removing local WSUS server settings", " ");
            try
            {
                Registry.LocalMachine.DeleteSubKeyTree(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //Delete browser data and downloads
            gm.updateLog("Deleting Browser and downloads folder data", " ");
            string userProfile = Environment.ExpandEnvironmentVariables("%USERPROFILE%");
            try
            {
                Array.ForEach(Directory.GetFiles(userProfile + @"\Downloads\"), File.Delete);
            }
            catch (Exception e)
            {
                gm.updateLog("---Could not delete all Downloads", " ");
                Console.WriteLine(e);
            }

            try
            {
                Directory.Delete(userProfile + @"\AppData\Local\Google\Chrome", true);
            }
            catch (Exception e)
            {
                gm.updateLog("---Could not delete Google Chrome data folder. It may not exist", " ");
                Console.WriteLine(e);
            }

            try
            {
                Directory.Delete(userProfile + @"\AppData\Roaming\Mozilla\Firefox", true);
            }
            catch (Exception e)
            {
                gm.updateLog("---Could not delete Firefox data folder. It may not exist", " ");
                Console.WriteLine(e);
            }



            //Change power config back
            try
            {
                gm.updateLog("Setting power configuration options", " ");
                Process.Start("powercfg", @"-x -standby-timeout-ac 30");
                Process.Start("powercfg", @"-x -monitor-timout-ac 10");
            }
            catch (Exception e)
            {
                gm.updateLog("---There was an error updating power config", " ");
                Console.WriteLine(e);
            }
            //Remove mapped network drives
            try
            {
                gm.updateLog("Removing mapped network drives", " ");
                NetworkDrive NDT = new aejw.Network.NetworkDrive();
                NetworkDrive NDS = new aejw.Network.NetworkDrive();

                NDT.LocalDrive = "t:";
                NDT.ShareName = backupLocation;
                NDT.Force = true;
                NDT.UnMapDrive();

                NDS.LocalDrive = "s:";
                NDS.ShareName = softwareLocation;
                NDS.Force = true;
                NDS.UnMapDrive();

            }
            catch (Exception e)
            {
                gm.updateLog("---There was an error removing network drives", " ");
                Console.WriteLine(e);
            }
            //Remove SD install files
            gm.updateLog(@"Removing temporary installation files in C:\ITSDTemp", " ");
            try
            {
                Directory.Delete(@"C:\ITSDTemp", true);
            }
            catch (Exception e)
            {
                gm.updateLog("---Could not delete ITSDTemp. It may not exist", " ");
                Console.WriteLine(e);
            }

            //Set run last to Yes
            try
            {
                Registry.CurrentUser.OpenSubKey(@"ITSD", true).SetValue("LastRunDone", "Yes", RegistryValueKind.String);
                Registry.CurrentUser.OpenSubKey(@"ITSD", true).SetValue("LocalWSUSLocation", "Microsoft", RegistryValueKind.String);
                gm.updateLog("Done cleaning up", " ");
            }
            catch (Exception e)
            {
                gm.updateLog("---Could not set program local reg settings", " ");
                Console.WriteLine(e);
            }

        }
    }
}
