namespace Zoombies_Universal_Launcher
{
    partial class ZUL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZUL));
            this.pb_logo_zoombies = new System.Windows.Forms.PictureBox();
            this.ms_zul = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_logo_hfb = new System.Windows.Forms.PictureBox();
            this.cb_modselect = new System.Windows.Forms.ComboBox();
            this.lbl_remoteVersion = new System.Windows.Forms.Label();
            this.lbl_installedVersion = new System.Windows.Forms.Label();
            this.lbl_getRemoteVersion = new System.Windows.Forms.Label();
            this.lbl_getInstalledVersion = new System.Windows.Forms.Label();
            this.lbl_launcherVersion = new System.Windows.Forms.Label();
            this.lbl_selectmod = new System.Windows.Forms.Label();
            this.rtb_motd = new System.Windows.Forms.RichTextBox();
            this.btn_launchgame = new System.Windows.Forms.Button();
            this.btn_DownloadMod = new System.Windows.Forms.Button();
            this.pb_DownloadMod = new System.Windows.Forms.ProgressBar();
            this.lbl_ProgressText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_zoombies)).BeginInit();
            this.ms_zul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo_hfb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_logo_zoombies
            // 
            this.pb_logo_zoombies.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo_zoombies.Image")));
            this.pb_logo_zoombies.Location = new System.Drawing.Point(215, 224);
            this.pb_logo_zoombies.Name = "pb_logo_zoombies";
            this.pb_logo_zoombies.Size = new System.Drawing.Size(212, 66);
            this.pb_logo_zoombies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo_zoombies.TabIndex = 0;
            this.pb_logo_zoombies.TabStop = false;
            // 
            // ms_zul
            // 
            this.ms_zul.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serverBrowserToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.cleanupToolStripMenuItem});
            this.ms_zul.Location = new System.Drawing.Point(0, 0);
            this.ms_zul.Name = "ms_zul";
            this.ms_zul.Size = new System.Drawing.Size(569, 24);
            this.ms_zul.TabIndex = 1;
            this.ms_zul.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamePathsToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // gamePathsToolStripMenuItem
            // 
            this.gamePathsToolStripMenuItem.Enabled = false;
            this.gamePathsToolStripMenuItem.Name = "gamePathsToolStripMenuItem";
            this.gamePathsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.gamePathsToolStripMenuItem.Text = "Game Paths";
            this.gamePathsToolStripMenuItem.Click += new System.EventHandler(this.gamePathsToolStripMenuItem_Click);
            // 
            // serverBrowserToolStripMenuItem
            // 
            this.serverBrowserToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverBrowserToolStripMenuItem.Name = "serverBrowserToolStripMenuItem";
            this.serverBrowserToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.serverBrowserToolStripMenuItem.Text = "Server Browser";
            this.serverBrowserToolStripMenuItem.Click += new System.EventHandler(this.serverBrowserToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launcherToolStripMenuItem,
            this.modToolStripMenuItem});
            this.reportBugToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.reportBugToolStripMenuItem.Text = "Bug Report";
            // 
            // launcherToolStripMenuItem
            // 
            this.launcherToolStripMenuItem.Name = "launcherToolStripMenuItem";
            this.launcherToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.launcherToolStripMenuItem.Text = "Launcher";
            this.launcherToolStripMenuItem.Click += new System.EventHandler(this.launcherToolStripMenuItem_Click);
            // 
            // modToolStripMenuItem
            // 
            this.modToolStripMenuItem.Name = "modToolStripMenuItem";
            this.modToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modToolStripMenuItem.Text = "Mod";
            this.modToolStripMenuItem.Click += new System.EventHandler(this.modToolStripMenuItem_Click);
            // 
            // cleanupToolStripMenuItem
            // 
            this.cleanupToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanupToolStripMenuItem.Name = "cleanupToolStripMenuItem";
            this.cleanupToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cleanupToolStripMenuItem.Text = "Cleanup";
            this.cleanupToolStripMenuItem.Click += new System.EventHandler(this.cleanupToolStripMenuItem_Click);
            // 
            // lb_logo_hfb
            // 
            this.lb_logo_hfb.Image = ((System.Drawing.Image)(resources.GetObject("lb_logo_hfb.Image")));
            this.lb_logo_hfb.Location = new System.Drawing.Point(437, 27);
            this.lb_logo_hfb.Name = "lb_logo_hfb";
            this.lb_logo_hfb.Size = new System.Drawing.Size(120, 105);
            this.lb_logo_hfb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lb_logo_hfb.TabIndex = 2;
            this.lb_logo_hfb.TabStop = false;
            // 
            // cb_modselect
            // 
            this.cb_modselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modselect.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_modselect.FormattingEnabled = true;
            this.cb_modselect.Items.AddRange(new object[] {
            "Altis",
            "Chernarus",
            "Taviana"});
            this.cb_modselect.Location = new System.Drawing.Point(437, 153);
            this.cb_modselect.Name = "cb_modselect";
            this.cb_modselect.Size = new System.Drawing.Size(120, 24);
            this.cb_modselect.TabIndex = 15;
            this.cb_modselect.SelectedIndexChanged += new System.EventHandler(this.cb_modselect_SelectedIndexChanged);
            // 
            // lbl_remoteVersion
            // 
            this.lbl_remoteVersion.AutoSize = true;
            this.lbl_remoteVersion.Location = new System.Drawing.Point(12, 239);
            this.lbl_remoteVersion.Name = "lbl_remoteVersion";
            this.lbl_remoteVersion.Size = new System.Drawing.Size(95, 15);
            this.lbl_remoteVersion.TabIndex = 16;
            this.lbl_remoteVersion.Text = "Remote Version:";
            this.lbl_remoteVersion.Visible = false;
            // 
            // lbl_installedVersion
            // 
            this.lbl_installedVersion.AutoSize = true;
            this.lbl_installedVersion.Location = new System.Drawing.Point(12, 254);
            this.lbl_installedVersion.Name = "lbl_installedVersion";
            this.lbl_installedVersion.Size = new System.Drawing.Size(99, 15);
            this.lbl_installedVersion.TabIndex = 17;
            this.lbl_installedVersion.Text = "Installed Version:";
            this.lbl_installedVersion.Visible = false;
            // 
            // lbl_getRemoteVersion
            // 
            this.lbl_getRemoteVersion.AutoSize = true;
            this.lbl_getRemoteVersion.Location = new System.Drawing.Point(117, 239);
            this.lbl_getRemoteVersion.Name = "lbl_getRemoteVersion";
            this.lbl_getRemoteVersion.Size = new System.Drawing.Size(77, 15);
            this.lbl_getRemoteVersion.TabIndex = 18;
            this.lbl_getRemoteVersion.Text = "REMOTE_VER";
            this.lbl_getRemoteVersion.Visible = false;
            // 
            // lbl_getInstalledVersion
            // 
            this.lbl_getInstalledVersion.AutoSize = true;
            this.lbl_getInstalledVersion.Location = new System.Drawing.Point(117, 254);
            this.lbl_getInstalledVersion.Name = "lbl_getInstalledVersion";
            this.lbl_getInstalledVersion.Size = new System.Drawing.Size(91, 15);
            this.lbl_getInstalledVersion.TabIndex = 19;
            this.lbl_getInstalledVersion.Text = "INSTALLED_VER";
            this.lbl_getInstalledVersion.Visible = false;
            // 
            // lbl_launcherVersion
            // 
            this.lbl_launcherVersion.AutoSize = true;
            this.lbl_launcherVersion.Location = new System.Drawing.Point(12, 278);
            this.lbl_launcherVersion.Name = "lbl_launcherVersion";
            this.lbl_launcherVersion.Size = new System.Drawing.Size(96, 15);
            this.lbl_launcherVersion.TabIndex = 20;
            this.lbl_launcherVersion.Text = "LOCAL_VERSION";
            // 
            // lbl_selectmod
            // 
            this.lbl_selectmod.AutoSize = true;
            this.lbl_selectmod.Location = new System.Drawing.Point(434, 135);
            this.lbl_selectmod.Name = "lbl_selectmod";
            this.lbl_selectmod.Size = new System.Drawing.Size(67, 15);
            this.lbl_selectmod.TabIndex = 21;
            this.lbl_selectmod.Text = "Select Mod:";
            // 
            // rtb_motd
            // 
            this.rtb_motd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_motd.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_motd.Location = new System.Drawing.Point(15, 28);
            this.rtb_motd.Name = "rtb_motd";
            this.rtb_motd.ReadOnly = true;
            this.rtb_motd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_motd.Size = new System.Drawing.Size(410, 190);
            this.rtb_motd.TabIndex = 22;
            this.rtb_motd.Text = "";
            // 
            // btn_launchgame
            // 
            this.btn_launchgame.Enabled = false;
            this.btn_launchgame.Location = new System.Drawing.Point(437, 249);
            this.btn_launchgame.Name = "btn_launchgame";
            this.btn_launchgame.Size = new System.Drawing.Size(120, 23);
            this.btn_launchgame.TabIndex = 23;
            this.btn_launchgame.Text = "Launch";
            this.btn_launchgame.UseVisualStyleBackColor = true;
            this.btn_launchgame.Click += new System.EventHandler(this.btn_launchgame_Click);
            // 
            // btn_DownloadMod
            // 
            this.btn_DownloadMod.Enabled = false;
            this.btn_DownloadMod.Location = new System.Drawing.Point(437, 224);
            this.btn_DownloadMod.Name = "btn_DownloadMod";
            this.btn_DownloadMod.Size = new System.Drawing.Size(120, 23);
            this.btn_DownloadMod.TabIndex = 24;
            this.btn_DownloadMod.Text = "Download";
            this.btn_DownloadMod.UseVisualStyleBackColor = true;
            this.btn_DownloadMod.Click += new System.EventHandler(this.btn_DownloadMod_Click);
            // 
            // pb_DownloadMod
            // 
            this.pb_DownloadMod.Location = new System.Drawing.Point(437, 278);
            this.pb_DownloadMod.Name = "pb_DownloadMod";
            this.pb_DownloadMod.Size = new System.Drawing.Size(120, 15);
            this.pb_DownloadMod.TabIndex = 25;
            this.pb_DownloadMod.Visible = false;
            // 
            // lbl_ProgressText
            // 
            this.lbl_ProgressText.AutoSize = true;
            this.lbl_ProgressText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProgressText.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProgressText.Location = new System.Drawing.Point(406, 278);
            this.lbl_ProgressText.Name = "lbl_ProgressText";
            this.lbl_ProgressText.Size = new System.Drawing.Size(14, 15);
            this.lbl_ProgressText.TabIndex = 26;
            this.lbl_ProgressText.Text = "%";
            // 
            // ZUL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 302);
            this.Controls.Add(this.lbl_ProgressText);
            this.Controls.Add(this.pb_DownloadMod);
            this.Controls.Add(this.btn_DownloadMod);
            this.Controls.Add(this.btn_launchgame);
            this.Controls.Add(this.rtb_motd);
            this.Controls.Add(this.lbl_selectmod);
            this.Controls.Add(this.lbl_launcherVersion);
            this.Controls.Add(this.lbl_getInstalledVersion);
            this.Controls.Add(this.lbl_getRemoteVersion);
            this.Controls.Add(this.lbl_installedVersion);
            this.Controls.Add(this.lbl_remoteVersion);
            this.Controls.Add(this.cb_modselect);
            this.Controls.Add(this.lb_logo_hfb);
            this.Controls.Add(this.pb_logo_zoombies);
            this.Controls.Add(this.ms_zul);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_zul;
            this.MaximizeBox = false;
            this.Name = "ZUL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoombies Universal Launcher :: PRODUCT_VERSION";
            this.Load += new System.EventHandler(this.ZUL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_zoombies)).EndInit();
            this.ms_zul.ResumeLayout(false);
            this.ms_zul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo_hfb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo_zoombies;
        private System.Windows.Forms.MenuStrip ms_zul;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox lb_logo_hfb;
        private System.Windows.Forms.ToolStripMenuItem serverBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanupToolStripMenuItem;
        internal System.Windows.Forms.ComboBox cb_modselect;
        private System.Windows.Forms.Label lbl_remoteVersion;
        private System.Windows.Forms.Label lbl_installedVersion;
        private System.Windows.Forms.Label lbl_getRemoteVersion;
        private System.Windows.Forms.Label lbl_getInstalledVersion;
        private System.Windows.Forms.Label lbl_launcherVersion;
        private System.Windows.Forms.Label lbl_selectmod;
        private System.Windows.Forms.RichTextBox rtb_motd;
        private System.Windows.Forms.Button btn_launchgame;
        private System.Windows.Forms.ToolStripMenuItem launcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePathsToolStripMenuItem;
        private System.Windows.Forms.Button btn_DownloadMod;
        private System.Windows.Forms.ProgressBar pb_DownloadMod;
        private System.Windows.Forms.Label lbl_ProgressText;
    }
}

