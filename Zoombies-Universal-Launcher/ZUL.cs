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
using System.IO;

namespace Zoombies_Universal_Launcher
{
    public partial class ZUL : Form
    {

        public static string ApplicationName = "Zoombies-Universal-Launcher :: " + Application.ProductVersion;

        public ZUL()
        {
            InitializeComponent();
            this.Text = "Zoombies Universal Launcher :: " + Application.ProductVersion;
        }

        private void ZUL_Load(object sender, EventArgs e)
        {
            //Check for updates as soon as the server starts
            this.CheckForUpdates();
            this.ReadWriteConfigFile();
            this.LocalVersions();
            this.GetMOTD();
            btn_launchgame.Enabled = true;
        }

        private void CheckForUpdates()
        {
            WebClient GetUpdateURL = new WebClient();
            GetUpdateURL.Proxy = null;

            string GetUpdateURLAsString = GetUpdateURL.DownloadString("http://74.91.121.95:8080/ZUL/Configs/version.txt");
            string ProductVersionAsString = Application.ProductVersion;

            try
            {
                if (!(GetUpdateURLAsString == ProductVersionAsString))
                {
                    MessageBox.Show("Update available!", ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DoUpdate();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString(), ApplicationName);
                Application.Exit();
            }
        }

        private void DoUpdate()
        {
            try
            {
                Process.Start(Directory.GetCurrentDirectory() + @"\Zoombies-Universal-Launcher-Updater.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        //Global Variables
        static string ArmA2Location;
        static string ArmA2OALocation;
        static string ArmA2OABetaLocation;
        static string ArmA3Location;

        private void CheckRemoteVersions(int SelectVersion)
        {
            XmlDocument ZLConfig = new XmlDocument();
            try
            {
                ZLConfig.Load("http://74.91.121.95:8080/DayZA3/launcher/config.xml");
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString(), ApplicationName);
                Application.Exit();
            }
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

        #region Global Variable Registries
        public string GlobalArmA2Location
        {
            get
            {
                ArmA2Location = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2", "main", null);
                return ArmA2Location;
            }
            set
            {
                GlobalArmA2Location = ArmA2Location;
            }
        }

        public string GlobalArmA2OALocation
        {
            get
            {
                ArmA2OALocation = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", "main", null);
                return ArmA2OALocation;
            }
            set
            {
                GlobalArmA2OALocation = ArmA2OALocation;
            }
        }

        public string GlobalArmA2OABetaLocation
        {
            get
            {
                ArmA2OABetaLocation = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", "DATA", null);
                return ArmA2OABetaLocation;
            }
            set
            {
                GlobalArmA2OABetaLocation = ArmA2OABetaLocation;
            }
        }

        public string GlobalArmA3Location
        {
            get
            {
                ArmA3Location = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive\\Arma 3", "main", null);
                return ArmA3Location;
            }
            set
            {
                GlobalArmA3Location = ArmA3Location;
            }
        }
        #endregion

        /* Old Registry Getting.
        private void GetRegistry(string RequestRegistry)
        {
            switch (RequestRegistry)
            {
                case "ArmA2Location":
                    try
                    {
                        ArmA2Location = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2", "main", null);
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
                        ArmA2OALocation = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", "main", null);
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
                        ArmA2OABetaLocation = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive Studio\\ArmA 2 OA", "DATA", null);
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
                        ArmA3Location = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Bohemia Interactive\\Arma 3", "main", null);
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
        */

        public static string PathApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string PathConfigFolder = PathApplicationData + "\\Zoombies-Universal-Launcher";
        public static string PathConfigFile = PathConfigFolder + "\\ZUL.xml";

        private void ReadWriteConfigFile()
        {
            if (!(Directory.Exists(PathConfigFolder)))
            {
                try
                {
                    Directory.CreateDirectory(PathConfigFolder);
                    Console.WriteLine("Created Config Folder: " + PathConfigFolder);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ApplicationName);
                }
            }
            if (!(File.Exists(PathConfigFile)))
            {
                try
                {
                    File.Create(PathConfigFile);
                    Console.WriteLine("Created Config File: " + PathConfigFile);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ApplicationName);
                }
            }
        }

        private void WriteConfigFile()
        {

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
        private void GetMOTD()
        {
            WebClient WC_MOTD = new WebClient();
            WC_MOTD.Proxy = null;
            string MOTD;

            try
            {
                MOTD = WC_MOTD.DownloadString("http://74.91.121.95:8080/ZUL/Configs/motd.txt");
                rtb_motd.Text = MOTD;
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString(), ApplicationName);
                rtb_motd.Text = "UNABLE TO GET MOTD!";
            }

        }
        private void cb_modselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btn_launchgame.Enabled = true;

            if (cb_modselect.Text == "Altis")
            {
                btn_launchgame.Enabled = false;
                //this.CheckRemoteVersions(2);
                Console.WriteLine("You have selected: Altis");
            }
            else if (cb_modselect.Text == "Chernarus")
            {
                btn_launchgame.Enabled = true;
                this.CheckRemoteVersions(3);
                Console.WriteLine("You have selected: Chernarus");
            }
            else if (cb_modselect.Text == "Taviana")
            {
                btn_launchgame.Enabled = false;
                //this.CheckRemoteVersions(4);
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
            MessageBox.Show("The Server Browser is currently disabled.", ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gamePathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            GamePaths Form_GamePaths = new GamePaths();
            Form_GamePaths.Show();
        }

        private void btn_launchgame_Click(object sender, EventArgs e)
        {
            /*
            Console.WriteLine("ArmA2 Location: " + GlobalArmA2Location);
            Console.WriteLine("ArmA2OA Location: " + GlobalArmA2OALocation);
            Console.WriteLine("ArmA2OABeta Location: " + GlobalArmA2OABetaLocation);
            Console.WriteLine("ArmA3 Location: " + GlobalArmA3Location);
            */

            string Launch_A3 = GlobalArmA3Location + "\\arma3.exe";
            string Launch_Altis_Args = "-world=altis -noPause -noSplash" + " -mod=@DayZA3_Altis";
            string Launch_Chernarus_Args = "-world=chernarus -noPause -noSplash" + " \"" +
                    "-mod=@DayZA3_Chernarus;@CBA_A3;@AllInArma\\ProductDummies;C:\\Program Files (x86)\\Steam\\steamapps\\common\\Take On Helicopter;" +
                        GlobalArmA2Location + ";" + GlobalArmA2OALocation + ";" + GlobalArmA2OALocation + "\\Expansion" + ";" + GlobalArmA3Location + ";" + 
                        "@AllInArma\\Core;@AllInArma\\PostA3" + "\"";
            string Launch_Taviana_Args = "-world=tavi -noPause -noSplash" + " \"" +
                    "-mod=@DayZA3_Chernarus;@CBA_A3;@AllInArma\\ProductDummies;C:\\Program Files (x86)\\Steam\\steamapps\\common\\Take On Helicopter;" +
                        GlobalArmA2Location + ";" + GlobalArmA2OALocation + ";" + GlobalArmA2OALocation + "\\Expansion" + ";" + GlobalArmA3Location + ";" + 
                        "@AllInArma\\Core;@AllInArma\\PostA3" + "\"";

            if (cb_modselect.Text == "Altis")
            {
                //Process.Start(Launch_A3, Launch_Altis_Args);
            }

            if (cb_modselect.Text == "Chernarus")
            {
                Process.Start(Launch_A3, Launch_Chernarus_Args);
            }

            if (cb_modselect.Text == "Taviana")
            {
                //Process.Start(Launch_A3, Launch_Taviana_Args);   
            }
        }
        #endregion
    }
}