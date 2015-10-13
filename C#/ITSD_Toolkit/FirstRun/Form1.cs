using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FirstRun
{
    public partial class Form1 : Form
    {
        GeneralMethods gm = new GeneralMethods();
        MakeItSo mis = new MakeItSo();
        CleanUp cu = new CleanUp();

        public static ListBox LogBox;
        public Form1()
        {
            InitializeComponent();
            LogBox = logBox;
            
            try
            {
                if (Registry.CurrentUser.OpenSubKey(@"ITSD", true) == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"ITSD");
                    Registry.CurrentUser.OpenSubKey(@"ITSD", true).SetValue("LocalWSUSLocation", "Microsoft", RegistryValueKind.String);
                    Registry.CurrentUser.OpenSubKey(@"ITSD", true).SetValue("FirstRunDone", "No", RegistryValueKind.String);
                    Registry.CurrentUser.OpenSubKey(@"ITSD", true).SetValue("LastRunDone", "No", RegistryValueKind.String);

                }
                wsusLocationLabel.Text = Registry.CurrentUser.OpenSubKey(@"ITSD").GetValue("LocalWSUSLocation").ToString();
                runFirstDoneLabel.Text = Registry.CurrentUser.OpenSubKey(@"ITSD").GetValue("FirstRunDone").ToString();
                runLastDoneLabel.Text = Registry.CurrentUser.OpenSubKey(@"ITSD").GetValue("LastRunDone").ToString();
            }
            catch (Exception e)
            {
                gm.updateLog("Couldn't set program local registry settings, probably permissions", " ");
                Console.WriteLine(e);
            }
        }

        private void locationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("locations.csv");
                while ((line = file.ReadLine()) != null)
                {
                    string[] locationInfo = line.Split(new[] { ',' });
                    if (locationInfo[0] == locationSelect.Text)
                    {
                        backupLocation.Text = locationInfo[1];
                        softwareLocation.Text = locationInfo[2];
                        usernameBox.Text = locationInfo[3];
                        passwordBox.Text = locationInfo[4];
                        wsusServerLocation.Text = locationInfo[5];
                        wsusPort.Text = locationInfo[6];
                    }
                }
            }
            catch (Exception)
            {
                gm.updateLog("Couldn't open locations.csv", " ");
            }
        }

        private void runFirstBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\ITSDTemp") != true)
            {
                DialogResult yesno = MessageBox.Show("It doesn't look like the temp installation files have been copied. Would you like to copy these now?", "No install files", MessageBoxButtons.YesNo);
                if (yesno == DialogResult.Yes)
                {
                    gm.updateLog("----------- Copying Files ------------", " ");
                    gm.copyFiles();
                }
            }
            if (locationSelect.SelectedIndex != -1)
            {
                gm.updateLog("--------- Making it so! ----------", " ");
                if (setTimeCheckbox.Checked == true)
                {
                    gm.updateLog("Checking internet connection", mis.pingGoogle());
                    if (mis.pingGoogle() == "Success")
                        gm.updateLog("Updating computer time", mis.updateTime());
                }

                if (backupCheckbox.Checked == true)
                {
                    if (backupLocation.Text != "" && softwareLocation.Text != "")
                        gm.updateLog("Attempting to map network drives", mis.mapNetworkDrives(backupLocation.Text, softwareLocation.Text, usernameBox.Text, passwordBox.Text));
                    else
                        MessageBox.Show("There is not enough server information for the drives to be mapped");
                }
                if (softpackCheckbox.Checked == true)
                    gm.updateLog("Launching SoftPack installer", mis.installSoftPack());

                if (poweroptionsCheckbox.Checked == true)
                    gm.updateLog("Disabling Power Options", mis.disablePowerOptions());

                if (installESETCheckbox.Checked == true)
                    gm.updateLog("Launching ESET Installer", mis.installESET());

                if (wsusCheckbox.Checked == true)
                {
                    gm.updateLog("Setting local WSUS Server", mis.addWSUS(wsusServerLocation.Text, wsusPort.Text));
                    Registry.CurrentUser.OpenSubKey(@"ITSD", true).SetValue("LocalWSUSLocation", "Local Server", RegistryValueKind.String);
                    wsusLocationLabel.Text = "Local Server";
                }

                if (updateWindowsCheckbox.Checked == true && wsusCheckbox.Checked == false)
                    gm.updateLog("Enabling and launching windows Update", mis.windowsUpdate());

                Registry.CurrentUser.OpenSubKey(@"ITSD", true).SetValue("FirstRunDone", "Yes", RegistryValueKind.String);
                runFirstDoneLabel.Text = "Yes";
            }
            else
            {
                MessageBox.Show("You must select a location");
            }
        }

        private void runLastBtn_Click(object sender, EventArgs e)
        {
            gm.updateLog("----------- Cleaning up -------------", " ");
            cu.cleanUp(backupLocation.Text, softwareLocation.Text, usernameBox.Text, passwordBox.Text);
            wsusLocationLabel.Text = "Microsoft";
            runLastDoneLabel.Text = "Yes";
            
        }

    }
}
