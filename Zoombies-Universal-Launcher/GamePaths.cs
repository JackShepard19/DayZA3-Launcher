using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zoombies_Universal_Launcher
{
    public partial class GamePaths : Form
    {
        public GamePaths()
        {
            InitializeComponent();
        }

        private void GamePaths_Load(object sender, EventArgs e)
        {
            this.GetMainRegistries();
        }

        private void GetMainRegistries()
        {
            ZUL Form_ZUL = new ZUL();
            tb_ArmA2Path.Text = Form_ZUL.GlobalArmA2Location;
            tb_ArmA2OAPath.Text = Form_ZUL.GlobalArmA2OALocation;
            tb_ArmA2OABetaPath.Text = Form_ZUL.GlobalArmA2OABetaLocation;
            tb_ArmA3Path.Text = Form_ZUL.GlobalArmA3Location;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            ZUL Form_ZUL = new ZUL();
            Form_ZUL.Enabled = true;
            this.Close();
        }
    }
}