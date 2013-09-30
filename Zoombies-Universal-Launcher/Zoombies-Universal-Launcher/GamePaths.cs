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

        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            this.Close();
            ZUL MainForm = new ZUL();
            MainForm.Visible = true;
        }
    }
}