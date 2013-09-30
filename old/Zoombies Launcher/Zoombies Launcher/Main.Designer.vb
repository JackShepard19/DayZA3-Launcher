<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.launchGame = New System.Windows.Forms.Button()
        Me.launcherVersionLabel = New System.Windows.Forms.Label()
        Me.ms_main = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallationCheckToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchOptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LauncherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_rv = New System.Windows.Forms.Label()
        Me.remoteVersionVersion = New System.Windows.Forms.Label()
        Me.lbl_iv = New System.Windows.Forms.Label()
        Me.installedVersionVersion = New System.Windows.Forms.Label()
        Me.downloadButton = New System.Windows.Forms.Button()
        Me.loadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.motdLabel = New System.Windows.Forms.Label()
        Me.llbl_zoombieslogo = New System.Windows.Forms.LinkLabel()
        Me.pb_zoombieslogo = New System.Windows.Forms.PictureBox()
        Me.pb_hfbservers = New System.Windows.Forms.PictureBox()
        Me.cb_modselect = New System.Windows.Forms.ComboBox()
        Me.llbl_hfbservers = New System.Windows.Forms.LinkLabel()
        Me.lbl_modselection = New System.Windows.Forms.Label()
        Me.checkvertimer = New System.Windows.Forms.Timer(Me.components)
        Me.ms_main.SuspendLayout()
        CType(Me.pb_zoombieslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_hfbservers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'launchGame
        '
        Me.launchGame.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.launchGame.Location = New System.Drawing.Point(513, 276)
        Me.launchGame.Name = "launchGame"
        Me.launchGame.Size = New System.Drawing.Size(120, 37)
        Me.launchGame.TabIndex = 0
        Me.launchGame.Text = "Launch"
        Me.launchGame.UseVisualStyleBackColor = True
        '
        'launcherVersionLabel
        '
        Me.launcherVersionLabel.AutoSize = True
        Me.launcherVersionLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.launcherVersionLabel.Location = New System.Drawing.Point(7, 316)
        Me.launcherVersionLabel.Name = "launcherVersionLabel"
        Me.launcherVersionLabel.Size = New System.Drawing.Size(34, 15)
        Me.launcherVersionLabel.TabIndex = 2
        Me.launcherVersionLabel.Text = "1.5.3"
        '
        'ms_main
        '
        Me.ms_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ServerBrowserToolStripMenuItem, Me.ReportBugToolStripMenuItem, Me.CleanupToolStripMenuItem})
        Me.ms_main.Location = New System.Drawing.Point(0, 0)
        Me.ms_main.Name = "ms_main"
        Me.ms_main.Size = New System.Drawing.Size(640, 24)
        Me.ms_main.TabIndex = 3
        Me.ms_main.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallationCheckToolStripMenuItem1, Me.LaunchOptionsToolStripMenuItem1, Me.ChangelogToolStripMenuItem1, Me.IRCToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'InstallationCheckToolStripMenuItem1
        '
        Me.InstallationCheckToolStripMenuItem1.Name = "InstallationCheckToolStripMenuItem1"
        Me.InstallationCheckToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.InstallationCheckToolStripMenuItem1.Text = "Installation Check"
        '
        'LaunchOptionsToolStripMenuItem1
        '
        Me.LaunchOptionsToolStripMenuItem1.Name = "LaunchOptionsToolStripMenuItem1"
        Me.LaunchOptionsToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.LaunchOptionsToolStripMenuItem1.Text = "Launch Options"
        '
        'ChangelogToolStripMenuItem1
        '
        Me.ChangelogToolStripMenuItem1.Name = "ChangelogToolStripMenuItem1"
        Me.ChangelogToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ChangelogToolStripMenuItem1.Text = "Changelog"
        '
        'IRCToolStripMenuItem
        '
        Me.IRCToolStripMenuItem.Name = "IRCToolStripMenuItem"
        Me.IRCToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.IRCToolStripMenuItem.Text = "IRC"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ServerBrowserToolStripMenuItem
        '
        Me.ServerBrowserToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerBrowserToolStripMenuItem.Name = "ServerBrowserToolStripMenuItem"
        Me.ServerBrowserToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ServerBrowserToolStripMenuItem.Text = "Server Browser"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModToolStripMenuItem, Me.LauncherToolStripMenuItem})
        Me.ReportBugToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ReportBugToolStripMenuItem.Text = "Report Bug"
        '
        'ModToolStripMenuItem
        '
        Me.ModToolStripMenuItem.Name = "ModToolStripMenuItem"
        Me.ModToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ModToolStripMenuItem.Text = "Mod"
        '
        'LauncherToolStripMenuItem
        '
        Me.LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem"
        Me.LauncherToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.LauncherToolStripMenuItem.Text = "Launcher"
        '
        'CleanupToolStripMenuItem
        '
        Me.CleanupToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanupToolStripMenuItem.Name = "CleanupToolStripMenuItem"
        Me.CleanupToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.CleanupToolStripMenuItem.Text = "Cleanup"
        '
        'lbl_rv
        '
        Me.lbl_rv.AutoSize = True
        Me.lbl_rv.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rv.Location = New System.Drawing.Point(7, 264)
        Me.lbl_rv.Name = "lbl_rv"
        Me.lbl_rv.Size = New System.Drawing.Size(111, 16)
        Me.lbl_rv.TabIndex = 4
        Me.lbl_rv.Text = "Remote Version:"
        '
        'remoteVersionVersion
        '
        Me.remoteVersionVersion.AutoSize = True
        Me.remoteVersionVersion.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remoteVersionVersion.ForeColor = System.Drawing.Color.LimeGreen
        Me.remoteVersionVersion.Location = New System.Drawing.Point(124, 264)
        Me.remoteVersionVersion.Name = "remoteVersionVersion"
        Me.remoteVersionVersion.Size = New System.Drawing.Size(72, 16)
        Me.remoteVersionVersion.TabIndex = 5
        Me.remoteVersionVersion.Text = "-Version-"
        '
        'lbl_iv
        '
        Me.lbl_iv.AutoSize = True
        Me.lbl_iv.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iv.Location = New System.Drawing.Point(7, 287)
        Me.lbl_iv.Name = "lbl_iv"
        Me.lbl_iv.Size = New System.Drawing.Size(118, 16)
        Me.lbl_iv.TabIndex = 6
        Me.lbl_iv.Text = "Installed Version:"
        '
        'installedVersionVersion
        '
        Me.installedVersionVersion.AutoSize = True
        Me.installedVersionVersion.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installedVersionVersion.Location = New System.Drawing.Point(124, 287)
        Me.installedVersionVersion.Name = "installedVersionVersion"
        Me.installedVersionVersion.Size = New System.Drawing.Size(92, 16)
        Me.installedVersionVersion.TabIndex = 7
        Me.installedVersionVersion.Text = "Select a mod!"
        '
        'downloadButton
        '
        Me.downloadButton.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downloadButton.Location = New System.Drawing.Point(513, 233)
        Me.downloadButton.Name = "downloadButton"
        Me.downloadButton.Size = New System.Drawing.Size(120, 37)
        Me.downloadButton.TabIndex = 8
        Me.downloadButton.Text = "Download"
        Me.downloadButton.UseVisualStyleBackColor = True
        Me.downloadButton.Visible = False
        '
        'motdLabel
        '
        Me.motdLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motdLabel.Location = New System.Drawing.Point(10, 25)
        Me.motdLabel.Name = "motdLabel"
        Me.motdLabel.Size = New System.Drawing.Size(497, 236)
        Me.motdLabel.TabIndex = 11
        Me.motdLabel.Text = "MOTD"
        '
        'llbl_zoombieslogo
        '
        Me.llbl_zoombieslogo.AutoSize = True
        Me.llbl_zoombieslogo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_zoombieslogo.LinkColor = System.Drawing.Color.Black
        Me.llbl_zoombieslogo.Location = New System.Drawing.Point(246, 316)
        Me.llbl_zoombieslogo.Name = "llbl_zoombieslogo"
        Me.llbl_zoombieslogo.Size = New System.Drawing.Size(174, 15)
        Me.llbl_zoombieslogo.TabIndex = 13
        Me.llbl_zoombieslogo.TabStop = True
        Me.llbl_zoombieslogo.Text = "Logo created by: blabaalzaurus"
        Me.llbl_zoombieslogo.VisitedLinkColor = System.Drawing.Color.Black
        '
        'pb_zoombieslogo
        '
        Me.pb_zoombieslogo.Image = Global.Zoombies_Launcher.My.Resources.Resources.ZOOMBIES_LOGO1
        Me.pb_zoombieslogo.Location = New System.Drawing.Point(229, 264)
        Me.pb_zoombieslogo.Name = "pb_zoombieslogo"
        Me.pb_zoombieslogo.Size = New System.Drawing.Size(278, 49)
        Me.pb_zoombieslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_zoombieslogo.TabIndex = 12
        Me.pb_zoombieslogo.TabStop = False
        '
        'pb_hfbservers
        '
        Me.pb_hfbservers.Image = CType(resources.GetObject("pb_hfbservers.Image"), System.Drawing.Image)
        Me.pb_hfbservers.Location = New System.Drawing.Point(513, 25)
        Me.pb_hfbservers.Name = "pb_hfbservers"
        Me.pb_hfbservers.Size = New System.Drawing.Size(120, 134)
        Me.pb_hfbservers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_hfbservers.TabIndex = 1
        Me.pb_hfbservers.TabStop = False
        '
        'cb_modselect
        '
        Me.cb_modselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_modselect.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_modselect.FormattingEnabled = True
        Me.cb_modselect.Items.AddRange(New Object() {"Chernarus", "Taviana"})
        Me.cb_modselect.Location = New System.Drawing.Point(513, 203)
        Me.cb_modselect.Name = "cb_modselect"
        Me.cb_modselect.Size = New System.Drawing.Size(120, 24)
        Me.cb_modselect.TabIndex = 14
        '
        'llbl_hfbservers
        '
        Me.llbl_hfbservers.AutoSize = True
        Me.llbl_hfbservers.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_hfbservers.LinkColor = System.Drawing.Color.Black
        Me.llbl_hfbservers.Location = New System.Drawing.Point(553, 316)
        Me.llbl_hfbservers.Name = "llbl_hfbservers"
        Me.llbl_hfbservers.Size = New System.Drawing.Size(80, 15)
        Me.llbl_hfbservers.TabIndex = 15
        Me.llbl_hfbservers.TabStop = True
        Me.llbl_hfbservers.Text = "Rent a server!"
        Me.llbl_hfbservers.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lbl_modselection
        '
        Me.lbl_modselection.AutoSize = True
        Me.lbl_modselection.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modselection.Location = New System.Drawing.Point(510, 184)
        Me.lbl_modselection.Name = "lbl_modselection"
        Me.lbl_modselection.Size = New System.Drawing.Size(100, 16)
        Me.lbl_modselection.TabIndex = 16
        Me.lbl_modselection.Text = "Mod Selection:"
        '
        'checkvertimer
        '
        Me.checkvertimer.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 335)
        Me.Controls.Add(Me.lbl_modselection)
        Me.Controls.Add(Me.llbl_hfbservers)
        Me.Controls.Add(Me.cb_modselect)
        Me.Controls.Add(Me.llbl_zoombieslogo)
        Me.Controls.Add(Me.pb_zoombieslogo)
        Me.Controls.Add(Me.motdLabel)
        Me.Controls.Add(Me.downloadButton)
        Me.Controls.Add(Me.installedVersionVersion)
        Me.Controls.Add(Me.lbl_iv)
        Me.Controls.Add(Me.remoteVersionVersion)
        Me.Controls.Add(Me.lbl_rv)
        Me.Controls.Add(Me.launcherVersionLabel)
        Me.Controls.Add(Me.pb_hfbservers)
        Me.Controls.Add(Me.launchGame)
        Me.Controls.Add(Me.ms_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ms_main
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Zoombies Universal Launcher"
        Me.ms_main.ResumeLayout(False)
        Me.ms_main.PerformLayout()
        CType(Me.pb_zoombieslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_hfbservers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents launchGame As System.Windows.Forms.Button
    Friend WithEvents pb_hfbservers As System.Windows.Forms.PictureBox
    Friend WithEvents launcherVersionLabel As System.Windows.Forms.Label
    Friend WithEvents ms_main As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_rv As System.Windows.Forms.Label
    Friend WithEvents remoteVersionVersion As System.Windows.Forms.Label
    Friend WithEvents lbl_iv As System.Windows.Forms.Label
    Friend WithEvents installedVersionVersion As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents downloadButton As System.Windows.Forms.Button
    Friend WithEvents loadTimer As System.Windows.Forms.Timer
    Friend WithEvents motdLabel As System.Windows.Forms.Label
    Friend WithEvents llbl_zoombieslogo As System.Windows.Forms.LinkLabel
    Friend WithEvents pb_zoombieslogo As System.Windows.Forms.PictureBox
    Friend WithEvents ReportBugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LauncherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cb_modselect As System.Windows.Forms.ComboBox
    Friend WithEvents llbl_hfbservers As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_modselection As System.Windows.Forms.Label
    Friend WithEvents InstallationCheckToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaunchOptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CleanupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents checkvertimer As System.Windows.Forms.Timer

End Class
