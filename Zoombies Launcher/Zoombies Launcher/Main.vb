Imports Ionic.Zip
Public Class Main
    'Declare some variables
    Dim a2value As String
    Dim a2oavalue As String
    Dim a3value As String
    Dim remoteZIP As String
    Dim downloadVer As String
    Dim zoombiesRemoteVersion As String
    Dim hfbRef As String
    Dim installedMod As String
    Dim getRemoteMOTD As String
    Dim launcherRemoteVersion As String
    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        'Immediately checks for updates as the application starts.
        CheckForUpdates()

        'Checks the mods version. Sadly I haven't figured out a proper hashing system yet. Possible will add one some time in the future.
        Try
            Using WC As New System.Net.WebClient()
                zoombiesRemoteVersion = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/version.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (version.txt, Init)")
        End Try

        'Checks of all files that are required to run the program were extracted properly. I could make this an array, but who the hell cares.
        If My.Computer.FileSystem.FileExists("Ionic.Zip.dll") = False Or My.Computer.FileSystem.FileExists("clientver.txt") = False Or My.Computer.FileSystem.FileExists("parameters.txt") = False Then
            MsgBox("Make sure you extract all the files inside of the zip file into this directory!")
            Me.Close()
        End If

        'If the network is good, check to make sure the versions are equal.
        If My.Computer.Network.IsAvailable Then
            Try
                remoteVersionVersion.Text = zoombiesRemoteVersion.ToString
            Catch ex As Exception
                MsgBox("The servers are unavailable at this time. Please try again later. (Checking for equal version, Init)")
                Me.Close()
            End Try
        End If

        'Gets the installation directory of ArmA3.
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        'Checks if the clientver.txt is available.
        If My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Chernarus\addons\clientver.txt") = False Then
            Try
                MsgBox("Since this is your first run, you will need to download the mod.")
                My.Computer.FileSystem.CopyFile("clientver.txt", a3value + "\@DayZA3_Chernarus\addons\clientver.txt")
                launchGame.Enabled = False
                downloadButton.Visible = True
            Catch ex As Exception
                MsgBox("Error: Failed to copy file. Run the program as an administrator and try again.")
            End Try
        End If

        'Makes "clientver.txt" readable by the system.
        Dim installedModVersion As New System.IO.StreamReader(a3value + "\@DayZA3_Chernarus\addons\clientver.txt")

        'Checks to see if "clientver.txt" actually exists and has a value.
        If My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Chernarus\addons\clientver.txt") = False Then
            installedVersionVersion.Text = "null"
            installedModVersion.Close()
        Else
            installedVersionVersion.Text = installedModVersion.ReadToEnd
            installedModVersion.Close()
        End If

        'Checking the versions and making them pretty colors.
        If installedVersionVersion.Text < zoombiesRemoteVersion Then
            installedVersionVersion.ForeColor = Color.Red
            launchGame.Enabled = False
            downloadButton.Visible = True
        ElseIf installedVersionVersion.Text > zoombiesRemoteVersion Then
            installedVersionVersion.ForeColor = Color.Red
            launchGame.Enabled = False
            downloadButton.Visible = True
        ElseIf installedVersionVersion.Text = "null" Then
            installedVersionVersion.ForeColor = Color.Red
            launchGame.Enabled = False
            downloadButton.Visible = True
        ElseIf installedVersionVersion.Text = zoombiesRemoteVersion Then
            installedVersionVersion.ForeColor = Color.LimeGreen
        End If

        'Checks if we are able to download "motd.txt" from a remote server.
        Try
            Using WC As New System.Net.WebClient()
                getRemoteMOTD = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/motd.txt")
                motdLabel.Text = getRemoteMOTD.ToString
            End Using
        Catch ex As Exception
            motdLabel.Text = "Unable to download the MOTD. Make sure your network connection is working."
        End Try
    End Sub
    Private Sub launchButton(sender As Object, e As EventArgs) Handles launchGame.Click
        'Gets the installation locations of ArmA2, ArmA2OA, and ArmA3
        a2value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2", "main", Nothing)
        a2oavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "main", Nothing)
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        'Makes "parameters.txt" readable by the system.
        Dim readText As New System.IO.StreamReader("parameters.txt")
        extraParams.extraBox.Text = readText.ReadToEnd
        readText.Close()

        'DEBUG LAUNCH OPTIONS
        'Dim launchParamsDebug As String
        'launchParamsDebug = a3value + "\" + "arma3.exe " & extraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & a2value & ";" & a2oavalue & ";" & a2oavalue & "\Expansion" & ";" & a3value & ";" & "@AllInArma\Core;@AllInArma\PostA3"""
        'My.Computer.FileSystem.WriteAllText("debug.txt", "", False)
        'My.Computer.FileSystem.WriteAllText("debug.txt", launchParamsDebug, True)
        'MsgBox(launchParamsDebug)

        'Once things are all set and ready to go, we can launch the game and play some DayZA3!
        System.Diagnostics.Process.Start(a3value + "\" + "arma3.exe ", extraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@CBA_A3;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & a2value & ";" & a2oavalue & ";" & a2oavalue & "\Expansion" & ";" & a3value & ";" & "@AllInArma\Core;@AllInArma\PostA3""")
    End Sub
    Private Sub ZoombiesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Checks if we are able to download "version.txt" from a remote server.
        Try
            Using WC As New System.Net.WebClient()
                zoombiesRemoteVersion = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/version.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (version.txt, ZoombiesToolStripMenuItem_Click)")
        End Try

        'Checking the versions and making them pretty colors.
        If installedVersionVersion.Text < zoombiesRemoteVersion Then
            installedVersionVersion.ForeColor = Color.Red
        ElseIf installedVersionVersion.Text > zoombiesRemoteVersion Then
            installedVersionVersion.ForeColor = Color.Red
        End If
    End Sub
    Private Sub downloadButton_Click(sender As Object, e As EventArgs) Handles downloadButton.Click
        'Gets the installation location of ArmA3.
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        'Checks if we are able to download "zipver.txt" from a remote server.
        Try
            Using WC As New System.Net.WebClient()
                remoteZIP = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/zipver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (zipver.txt, downloadButton_Click)")
        End Try

        'Checks if we are able to download "downloadver.txt" from a remote server.
        Try
            Using WC As New System.Net.WebClient()
                downloadVer = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/downloadver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (downloadver.txt, downloadButton_Click)")
        End Try

        'Makes "clientver.txt" readable by the system.
        Dim getNull As New System.IO.StreamReader(a3value + "\@DayZA3_Chernarus\addons\clientver.txt")

        'Checks the status of "clientver.txt".
        Try
            If getNull.ReadToEnd = "null" Then
                My.Computer.Network.DownloadFile(remoteZIP.ToString, downloadVer.ToString, vbNullString, vbNullString, True, 5000, True)
                getNull.Close()
                Call ExtractFiles()
                MsgBox("Please restart the launcher!")
                Me.Close()
            ElseIf My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Chernarus\addons\clientver.txt") = True Then
                My.Computer.Network.DownloadFile(remoteZIP.ToString, downloadVer.ToString, vbNullString, vbNullString, True, 5000, True)
                getNull.Close()
                Call ExtractFiles()
                MsgBox("Please restart the launcher!")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An error has occured. Please try again.")
            My.Computer.FileSystem.DeleteFile(downloadVer.ToString)
            Me.Close()
        End Try
    End Sub
    Private Sub ExtractFiles()
        'Gets the installation location of ArmA3.
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        'Checks if we are able to download "downloadver.txt" from a remote server.
        Try
            Using WC As New System.Net.WebClient()
                downloadVer = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/downloadver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (downloadver.txt, ExtractFiles)")
        End Try

        'Extracts the files using Ionic Zip
        Dim ZipToUnpack As String = downloadVer.ToString
        Dim UnpackDirectory As String = a3value + "\"
        Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using

        My.Computer.FileSystem.DeleteFile(downloadVer.ToString)
    End Sub
    Private Sub CheckForUpdates()
        'Checks if we are able to download "launcherver.txt" from a remote server.
        Try
            Using WC As New System.Net.WebClient()
                launcherRemoteVersion = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/launcherver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (launcherver.txt, CheckForUpdates)")
        End Try

        Dim launcher As String = launcherRemoteVersion
        Dim launcherVersion As String = launcherVersionLabel.Text

        If My.Computer.FileSystem.FileExists(launcher) Then
            My.Computer.FileSystem.DeleteFile(launcher)
        End If

        Dim oldLauncherVer As String = launcherRemoteVersion.ToString

        If Not launcherVersion = oldLauncherVer Then
            Try
                MsgBox("Launcher update available!")
                System.Diagnostics.Process.Start("ZB Updater.exe")
                Me.Close()
            Catch ex As Exception
                MsgBox("Updater not found. Please re-download the launcher and try again!")
                Me.Close()
            End Try
        Else
            'MsgBox("Program is up to date!")
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim zmRef As String
        zmRef = ("http://zoombiesmod.com")
        System.Diagnostics.Process.Start(zmRef)
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim zmImageRef As String
        zmImageRef = ("http://zoombiesmod.com/index.php?members/blabaalzaurus.66/")
        System.Diagnostics.Process.Start(zmImageRef)
    End Sub
    Private Sub InstallationCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallationCheckToolStripMenuItem.Click
        installationCheck.Show()
        Me.Hide()
    End Sub
    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        Me.Hide()
        Changelog.Show()
    End Sub
    Private Sub LauncherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LauncherToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Pwnoz0r/DayZA3-Launcher/issues/new")
    End Sub
    Private Sub ModToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Pwnoz0r/DayZA3/issues/new")
    End Sub
    Private Sub JoinOurIRCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JoinOurIRCToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://webchat.esper.net/?nick=&channels=DayZA3,%2CDayZA3Support")
    End Sub
    Private Sub ServerBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerBrowserToolStripMenuItem.Click
        Me.Hide()
        ServerBrowser.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        hfbRef = ("https://www.hfbservers.com/billing/aff.php?aff=057")
        System.Diagnostics.Process.Start(hfbRef)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub LaunchOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchOptionsToolStripMenuItem.Click
        extraParams.Show()
        Me.Hide()
    End Sub
End Class