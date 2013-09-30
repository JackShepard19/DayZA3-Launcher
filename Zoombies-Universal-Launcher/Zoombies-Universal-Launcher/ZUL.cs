using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Win32;

namespace Zoombies_Universal_Launcher
{
    public partial class ZUL : Form
    {

        public ZUL()
        {
            InitializeComponent();
        }

        private void ZUL_Load(object sender, EventArgs e)
        {
            //Check for updates as soon as the server starts
            this.LocalVersions();
        }

        private void CheckRemoteVersions(int SelectVersion)
        {
            XmlDocument ZLConfig = new XmlDocument();
            ZLConfig.Load("http://74.91.121.95:8080/DayZA3/launcher/config.xml");
            string LaunchString;
            this.ShowLabels();
            switch (SelectVersion)
            {
                case 1:
                    foreach (XmlNode minor in ZLConfig.SelectNodes("ZLConfig/LauncherVersion"))
                    {
                        Console.WriteLine("Launcher Version: " + minor.InnerText);
                    }
                    break;
                case 2:
                    foreach (XmlNode minor in ZLConfig.SelectNodes("ZLConfig/ModAltisVersion"))
                    {
                        Console.WriteLine("Altis Version: " + minor.InnerText);
                        lbl_getRemoteVersion.Text = minor.InnerText;
                    }
                    break;
                case 3:
                    foreach (XmlNode minor in ZLConfig.SelectNodes("ZLConfig/ModChernarusVersion"))
                    {
                        Console.WriteLine("Chernarus Version: " + minor.InnerText);
                        lbl_getRemoteVersion.Text = minor.InnerText;
                    }
                    break;
                case 4:
                    foreach (XmlNode minor in ZLConfig.SelectNodes("ZLConfig/ModTavianaVersion"))
                    {
                        Console.WriteLine("Taviana Version: " + minor.InnerText);
                        lbl_getRemoteVersion.Text = minor.InnerText;
                    }
                   break;

                default:
                    break;
            }
        }

        private void GetRegistry(string RequestRegistry)
        {
            switch(RequestRegistry)
            {
                case "ArmA2Location":
                    try
                    {
                        string ArmA2Location = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2", "main", null);
                        Console.WriteLine("ArmA2 Location: " + ArmA2Location);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case "ArmA2OALocation":
                    try
                    {
                        string ArmA2OALocation = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", "main", null);
                        Console.WriteLine("ArmA2OA Location: " + ArmA2OALocation);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case "ArmA2OABetaLocation":
                    try
                    {
                        string ArmA2OABetaLocation = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", "DATA", null);
                        Console.WriteLine("ArmA2OABeta Location: " + ArmA2OABetaLocation);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;

                case "ArmA3Location":
                    try
                    {
                        string ArmA3Location = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive\\Arma 3", "main", null);
                        Console.WriteLine("ArmA3 Location: " + ArmA3Location);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                default:
                    break;
            }
        }
  
        private void LocalVersions()
        {
            Assembly ZUL_LocalVersion_Assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo ZUL_LocalVersion = FileVersionInfo.GetVersionInfo(ZUL_LocalVersion_Assembly.Location);
            string ZUL_LocalVersion_String = ZUL_LocalVersion.FileVersion;

            lbl_launcherVersion.Text = ZUL_LocalVersion_String;
        }

        private void ShowLabels()
        {
            lbl_launcherVersion.Visible = true;
            lbl_installedVersion.Visible = true;
            lbl_getRemoteVersion.Visible = true;
            lbl_remoteVersion.Visible = true;
        }

        #region Buttons/Labels/etc
        private void cb_modselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_modselect.Text == "Altis")
            {
                this.CheckRemoteVersions(2);
                Console.WriteLine("You have selected: Altis");
            }
            else if (cb_modselect.Text == "Chernarus")
            {
                this.CheckRemoteVersions(3);
                Console.WriteLine("You have selected: Chernarus");
            }
            else if (cb_modselect.Text == "Taviana")
            {
                this.CheckRemoteVersions(4);
                Console.WriteLine("You have selected: Taviana");
            }
        }

        private void launcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Pwnoz0r/DayZA3-Launcher/issues/new");
        }

        private void modToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Pwnoz0r/DayZA3/issues/new");
        }

        private void serverBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Server Browser is currently disabled.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gamePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GamePaths gamepaths = new GamePaths();
            gamepaths.Show();
        }
        #endregion
    }
}