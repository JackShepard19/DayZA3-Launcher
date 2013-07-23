Imports Ionic.Zip
Public Class Form1
    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        'CheckForUpdates()

        Dim zoombiesRemoteVersion As String
        Dim downloadVer As String

        Try
            Using WC As New System.Net.WebClient()
                zoombiesRemoteVersion = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/version.txt")
            End Using
        Catch ex As Exception
            'Error downloading
        End Try

        If My.Computer.FileSystem.FileExists("Ionic.Zip.dll") = False Or My.Computer.FileSystem.FileExists("clientver.txt") = False Or My.Computer.FileSystem.FileExists("parameters.txt") = False Then
            MsgBox("Make sure you extract all the files inside of the zip file into this directory!")
            Me.Close()
        End If

        'MsgBox("IF YOU ARE GOING TO STREAM THIS MAKE SURE NOT TO SHOW THE LAUNCHER WHILE DOWNLOADING AN UPDATE!", MsgBoxStyle.Information)

        If My.Computer.Network.IsAvailable Then
            Try
                remoteVersionVersion.Text = zoombiesRemoteVersion.ToString
            Catch ex As Exception
                MsgBox("The servers are unavailable at this time. Please try again later.")
                Me.Close()
            End Try
        End If

        Dim a3value As String
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

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

        Dim installedModVersion As New System.IO.StreamReader(a3value + "\@DayZA3_Chernarus\addons\clientver.txt")

        Dim installedMod As String
        If My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Chernarus\addons\clientver.txt") = False Then
            installedVersionVersion.Text = "null"
            installedModVersion.Close()
        Else
            installedVersionVersion.Text = installedModVersion.ReadToEnd
            installedModVersion.Close()
        End If


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

        Dim getRemoteMOTD As String

        Try
            Using WC As New System.Net.WebClient()
                getRemoteMOTD = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/motd.txt")
            End Using
        Catch ex As Exception
            motdLabel.Text = "MOTD UNAVAILABLE!"
        End Try

        motdLabel.Text = getRemoteMOTD.ToString
    End Sub
    Private Sub launchButton(sender As Object, e As EventArgs) Handles launchGame.Click
        Dim a2value As String
        a2value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2", "main", Nothing)

        Dim a2oavalue As String
        a2oavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "main", Nothing)

        Dim a3value As String
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        Dim readText As New System.IO.StreamReader("parameters.txt")
        extraParams.extraBox.Text = readText.ReadToEnd
        readText.Close()

        'DEBUG LAUNCH OPTIONS
        'Dim launchParamsDebug As String
        'launchParamsDebug = a3value + "\" + "arma3.exe " & extraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & a2value & ";" & a2oavalue & ";" & a2oavalue & "\Expansion" & ";" & a3value & ";" & "@AllInArma\Core;@AllInArma\PostA3"""
        'My.Computer.FileSystem.WriteAllText("debug.txt", "", False)
        'My.Computer.FileSystem.WriteAllText("debug.txt", launchParamsDebug, True)

        System.Diagnostics.Process.Start(a3value + "\" + "arma3.exe ", extraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@CBA_A3;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & a2value & ";" & a2oavalue & ";" & a2oavalue & "\Expansion" & ";" & a3value & ";" & "@AllInArma\Core;@AllInArma\PostA3""")
        'MsgBox(launchParamsDebug)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim hfbRef As String
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
    Private Sub ZoombiesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim zoombiesRemoteVersion As String
        Try
            Using WC As New System.Net.WebClient()
                zoombiesRemoteVersion = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/version.txt")
            End Using
        Catch ex As Exception
            'Error downloading
        End Try

        If installedVersionVersion.Text < zoombiesRemoteVersion Then
            installedVersionVersion.ForeColor = Color.Red
        ElseIf installedVersionVersion.Text > zoombiesRemoteVersion Then
            installedVersionVersion.ForeColor = Color.Red
        End If
    End Sub
    Private Sub downloadButton_Click(sender As Object, e As EventArgs) Handles downloadButton.Click
        Dim remoteZIP As String
        Dim downloadVer As String

        Dim a3value As String
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        Try
            Using WC As New System.Net.WebClient()
                remoteZIP = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/zipver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later.")
        End Try

        Try
            Using WC As New System.Net.WebClient()
                downloadVer = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/downloadver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later.")
        End Try

        Dim getNull As New System.IO.StreamReader(a3value + "\@DayZA3_Chernarus\addons\clientver.txt")

        Try
            'If My.Computer.FileSystem.FileExists(a3value + "\@Zoombies_A3\addons/clientver.txt") = False Then
            If getNull.ReadToEnd = "null" Then
                My.Computer.Network.DownloadFile(remoteZIP.ToString, downloadVer.ToString, vbNullString, vbNullString, True, 5000, True)
                getNull.Close()
                'My.Computer.FileSystem.DeleteDirectory(a3value + "\@Zoombies_A3", True)
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
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub
    Private Sub ExtractFiles()
        Dim a3value As String
        Dim downloadVer As String

        Try
            Using WC As New System.Net.WebClient()
                downloadVer = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/downloadver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later.")
        End Try

        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

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
        Dim launcherRemoteVersion As String
        Try
            Using WC As New System.Net.WebClient()
                launcherRemoteVersion = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/launcherver.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later.")
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
        Changelogvb.Show()
    End Sub
End Class