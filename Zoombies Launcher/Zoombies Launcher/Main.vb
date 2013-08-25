Imports Ionic.Zip
Imports System.Xml

Public Class Main
    'Declare some variables
    Dim a2value As String
    Dim a2oavalue As String
    Dim a2oabetavalue As String
    Dim a3value As String
    Dim remoteZIP As String
    Dim remoteZIPTavi As String
    Dim downloadVer As String
    Dim downloadVerTavi As String
    Dim zoombiesRemoteVersion As String
    Dim hfbRef As String
    Dim installedMod As String
    Dim getRemoteMOTD As String
    Dim launcherRemoteVersion As String
    Dim ZoombiesSettingsFile As String
    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        'Immediately checks for updates as the application starts.
        CheckForUpdates()

        'Liability check and write configuration file
        ZoombiesSettingsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" + "ZoombiesUniversalLauncher.xml"

        If My.Computer.FileSystem.FileExists(ZoombiesSettingsFile) = False Then
            Dim ZoombiesConfigWrt As New XmlWriterSettings()
            ZoombiesConfigWrt.Indent = True
            Dim ZoombiesConfigWriter As XmlWriter = XmlWriter.Create(ZoombiesSettingsFile, ZoombiesConfigWrt)

            With ZoombiesConfigWriter
                .WriteStartDocument()
                .WriteComment("Zoombies Universal Launcher Configuration")
                .WriteStartElement("Configuration")
                .WriteStartElement("ArmA2Path")
                .WriteString(a2value)
                .WriteEndElement()
                .WriteStartElement("ArmA2OAPath")
                .WriteString(a2oavalue)
                .WriteEndElement()
                .WriteStartElement("ArmA2OABetaPath")
                .WriteString(a2oabetavalue)
                .WriteEndElement()
                .WriteStartElement("ArmA3Path")
                .WriteString(a3value)
                .WriteEndElement()
                .WriteStartElement("Liability")
                .WriteString(0)
                .WriteEndElement()

                .WriteEndDocument()
                .Close()

            End With
        End If

        If My.Computer.FileSystem.FileExists(ZoombiesSettingsFile) = True Then

            Dim getXMLData As XmlReader = New XmlTextReader(ZoombiesSettingsFile)
            Dim Liability As String = ""

            While (getXMLData.Read())
                Dim type = getXMLData.NodeType
                If (type = XmlNodeType.Element) Then
                    If getXMLData.Name = "Liability" Then
                        Liability = getXMLData.ReadInnerXml
                    End If
                End If
            End While
            getXMLData.Close()

            If Liability.Contains("0") Then
                If MsgBox("Did you LEGALLY obtain all (3) required ArmA games?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

                    ZoombiesSettingsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" + "ZoombiesUniversalLauncher.xml"
                    Dim ZoombiesConfigWrt As New XmlWriterSettings()
                    ZoombiesConfigWrt.Indent = True
                    Dim ZoombiesConfigWriter As XmlWriter = XmlWriter.Create(ZoombiesSettingsFile, ZoombiesConfigWrt)

                    With ZoombiesConfigWriter
                        .WriteStartDocument()
                        .WriteComment("Zoombies Universal Launcher Configuration")
                        .WriteStartElement("Configuration")
                        .WriteStartElement("ArmA2Path")
                        .WriteString(a2value)
                        .WriteEndElement()
                        .WriteStartElement("ArmA2OAPath")
                        .WriteString(a2oavalue)
                        .WriteEndElement()
                        .WriteStartElement("ArmA2OABetaPath")
                        .WriteString(a2oabetavalue)
                        .WriteEndElement()
                        .WriteStartElement("ArmA3Path")
                        .WriteString(a3value)
                        .WriteEndElement()
                        .WriteStartElement("Liability")
                        .WriteString(1)
                        .WriteEndElement()
                        .WriteStartElement("SetInstallation")
                        .WriteString(0)
                        .WriteEndElement()
                        .WriteStartElement("LaunchParameters")
                        .WriteString("")
                        .WriteEndElement()

                        .WriteEndDocument()
                        .Close()

                    End With
                Else
                    Me.Close()
                End If
            End If
        End If

        If My.Computer.FileSystem.FileExists(ZoombiesSettingsFile) = True Then

            Dim getXMLData As XmlReader = New XmlTextReader(ZoombiesSettingsFile)
            Dim SetInstallation As String = ""

            While (getXMLData.Read())
                Dim type = getXMLData.NodeType
                If (type = XmlNodeType.Element) Then
                    If getXMLData.Name = "SetInstallation" Then
                        SetInstallation = getXMLData.ReadInnerXml
                    End If
                End If
            End While
            getXMLData.Close()

            If SetInstallation.Contains("0") Then
                Me.Hide()
                InstallationCheck.Show()
            Else
                Me.Show()
            End If
        End If

        'Create configuration file.
        a2value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2", "main", Nothing)

        a2oavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "main", Nothing)

        a2oabetavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "DATA", Nothing)

        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)



        launchGame.Enabled = False

        'Checks the mods version. Sadly, I haven't decideed on a proper hashing system yet. Most likely I will add one some time in the future.
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

        'Checks if the clientver.txt is available for Chernarus.
        If My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Chernarus\addons\clientver.txt") = False Then
            Try
                My.Computer.FileSystem.CopyFile("clientver.txt", a3value + "\@DayZA3_Chernarus\addons\clientver.txt")
                launchGame.Enabled = False
                downloadButton.Visible = True
            Catch ex As Exception
                MsgBox("Error: Failed to copy file. Run the program as an administrator and try again.")
            End Try
        End If

        'Checks if the clientver.txt is available for Taviana.
        If My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Taviana\addons\clientver.txt") = False Then
            Try
                My.Computer.FileSystem.CopyFile("clientver.txt", a3value + "\@DayZA3_Taviana\addons\clientver.txt")
                launchGame.Enabled = False
                downloadButton.Visible = True
            Catch ex As Exception
                MsgBox("Error: Failed to copy file. Run the program as an administrator and try again.")
            End Try
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
        ExtraParams.extraBox.Text = readText.ReadToEnd
        readText.Close()

        Dim ZoombiesSettingsFile As String

        ZoombiesSettingsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" + "ZoombiesUniversalLauncher.xml"

        Dim getXMLData As XmlReader = New XmlTextReader(ZoombiesSettingsFile)
        Dim ArmA2Path As String = ""
        Dim ArmA2OAPath As String = ""
        Dim ArmA3Path As String = ""
        Dim ArmA2OABetaPath As String = ""

        While (getXMLData.Read())
            Dim type = getXMLData.NodeType
            If (type = XmlNodeType.Element) Then
                If getXMLData.Name = "ArmA2Path" Then
                    ArmA2Path = getXMLData.ReadInnerXml
                End If
                If getXMLData.Name = "ArmA2OAPath" Then
                    ArmA2OAPath = getXMLData.ReadInnerXml
                End If
                If getXMLData.Name = "ArmA2OABetaPath" Then
                    ArmA2OABetaPath = getXMLData.ReadInnerXml
                End If
                If getXMLData.Name = "ArmA3Path" Then
                    ArmA3Path = getXMLData.ReadInnerXml
                End If
            End If
        End While

        getXMLData.Close()

        'DEBUG LAUNCH OPTIONS
        'Dim launchParamsDebug As String
        'launchParamsDebug = ArmA3Path + "\" + "arma3.exe " & ExtraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & ArmA2Path & ";" & ArmA2OAPath & ";" & ArmA2OAPath & "\Expansion" & ";" & ArmA3Path & ";" & "@AllInArma\Core;@AllInArma\PostA3"""
        'My.Computer.FileSystem.WriteAllText("debug.txt", "", False)
        'My.Computer.FileSystem.WriteAllText("debug.txt", launchParamsDebug, True)
        'MsgBox(launchParamsDebug)

        'Once things are all set and ready to go, we can launch the game and play some DayZA3!
        If cb_modselect.Text = "Chernarus" Then
            System.Diagnostics.Process.Start(ArmA3Path + "\" + "arma3.exe ", ExtraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@CBA_A3;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & ArmA2Path & ";" & ArmA2OAPath & ";" & ArmA2OAPath & "\Expansion" & ";" & ArmA3Path & ";" & "@AllInArma\Core;@AllInArma\PostA3""")
        ElseIf cb_modselect.Text = "Taviana" Then
            System.Diagnostics.Process.Start(ArmA3Path + "\" + "arma3.exe ", ExtraParams.extraBox.Text & " " & """-mod=@DayZA3_Taviana;@CBA_A3;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & ArmA2Path & ";" & ArmA2OAPath & ";" & ArmA2OAPath & "\Expansion" & ";" & ArmA3Path & ";" & "@AllInArma\Core;@AllInArma\PostA3""")
        End If
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

        'Checks what mod the player wants to download.
        If cb_modselect.Text = "Chernarus" Then
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
                End If
            Catch ex As Exception
                MsgBox("An error has occured. Please try again.")
                My.Computer.FileSystem.DeleteFile(downloadVer.ToString)
                Me.Close()
            End Try
        ElseIf cb_modselect.Text = "Taviana" Then
            'Checks if we are able to download "zipver.txt" from a remote server.
            Try
                Using WC As New System.Net.WebClient()
                    remoteZIPTavi = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/zipver-tavi.txt")
                End Using
            Catch ex As Exception
                MsgBox("The servers are unavailable at this time. Please try again later. (zipver.txt, downloadButton_Click)")
            End Try

            'Checks if we are able to download "downloadver.txt" from a remote server.
            Try
                Using WC As New System.Net.WebClient()
                    downloadVerTavi = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/downloadver-tavi.txt")
                End Using
            Catch ex As Exception
                MsgBox("The servers are unavailable at this time. Please try again later. (downloadver.txt, downloadButton_Click)")
            End Try

            'Makes "clientver.txt" readable by the system.
            Dim getNullTavi As New System.IO.StreamReader(a3value + "\@DayZA3_Taviana\addons\clientver.txt")

            'Checks the status of "clientver.txt".
            Try
                If getNullTavi.ReadToEnd = "null" Then
                    My.Computer.Network.DownloadFile(remoteZIPTavi.ToString, downloadVerTavi.ToString, vbNullString, vbNullString, True, 5000, True)
                    getNullTavi.Close()
                    Call ExtractFilesTavi()
                    MsgBox("Please restart the launcher!")
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("An error has occured. Please try again.")
                My.Computer.FileSystem.DeleteFile(downloadVerTavi.ToString)
                Me.Close()
            End Try
        End If
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
    Private Sub ExtractFilesTavi()
        'Gets the installation location of ArmA3.
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        'Checks if we are able to download "downloadver.txt" from a remote server.
        Try
            Using WC As New System.Net.WebClient()
                downloadVerTavi = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/downloadver-tavi.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (downloadver-tavi.txt, ExtractFiles)")
        End Try

        'Extracts the files using Ionic Zip
        Dim ZipToUnpack As String = downloadVerTavi.ToString
        Dim UnpackDirectory As String = a3value + "\"
        Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using

        My.Computer.FileSystem.DeleteFile(downloadVerTavi.ToString)
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
    Private Sub cb_modselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_modselect.SelectedIndexChanged
        'Gets the installation directory of ArmA3.
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        'Makes "clientver.txt" readable by the system.
        Dim installedModVersion As New System.IO.StreamReader(a3value + "\@DayZA3_Chernarus\addons\clientver.txt")
        Dim installedModVersionTaviana As New System.IO.StreamReader(a3value + "\@DayZA3_Taviana\addons\clientver.txt")

        'Checks to see if "clientver.txt" actually exists and has a value.
        If cb_modselect.Text = "Chernarus" Then
            If My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Chernarus\addons\clientver.txt") = False Then
                installedVersionVersion.Text = "null"
                installedModVersion.Close()
                launchGame.Enabled = False
                downloadButton.Visible = True
            Else
                installedVersionVersion.Text = installedModVersion.ReadToEnd
                installedModVersion.Close()
            End If
        ElseIf cb_modselect.Text = "Taviana" Then
            If My.Computer.FileSystem.FileExists(a3value + "\@DayZA3_Taviana\addons\clientver.txt") = False Then
                installedVersionVersion.Text = "null"
                installedModVersionTaviana.Close()
                launchGame.Enabled = False
                downloadButton.Visible = True
            Else
                installedVersionVersion.Text = installedModVersionTaviana.ReadToEnd
                installedModVersionTaviana.Close()
            End If
        End If

        'Checking the versions and making them pretty colors.
        If cb_modselect.Text = "Chernarus" Then
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
                launchGame.Enabled = True
                downloadButton.Visible = False
            End If
        ElseIf cb_modselect.Text = "Taviana" Then
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
                launchGame.Enabled = True
                downloadButton.Visible = False
            End If
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pb_zoombieslogo.Click
        Dim zmRef As String
        zmRef = ("http://zoombiesmod.com")
        System.Diagnostics.Process.Start(zmRef)
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_zoombieslogo.LinkClicked
        Dim zmImageRef As String
        zmImageRef = ("http://zoombiesmod.com/index.php?members/blabaalzaurus.66/")
        System.Diagnostics.Process.Start(zmImageRef)
    End Sub
    Private Sub LauncherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LauncherToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Pwnoz0r/DayZA3-Launcher/issues/new")
    End Sub
    Private Sub ModToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Pwnoz0r/DayZA3/issues/new")
    End Sub
    Private Sub ServerBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerBrowserToolStripMenuItem.Click
        'Me.Hide()
        'ServerBrowser.Show()
        MsgBox("Server Browser is temporarily disabled!")
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb_hfbservers.Click
        hfbRef = ("https://www.hfbservers.com/billing/aff.php?aff=057")
        System.Diagnostics.Process.Start(hfbRef)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub llbl_hfbservers_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_hfbservers.LinkClicked
        Dim lblhfbservers As String
        lblhfbservers = ("https://www.hfbservers.com/billing/aff.php?aff=057")
        System.Diagnostics.Process.Start(lblhfbservers)
    End Sub
    Private Sub InstallationCheckToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InstallationCheckToolStripMenuItem1.Click
        InstallationCheck.Show()
        Me.Hide()
    End Sub
    Private Sub LaunchOptionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LaunchOptionsToolStripMenuItem1.Click
        ExtraParams.Show()
        Me.Hide()
    End Sub
    Private Sub IRCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRCToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://webchat.esper.net/?nick=&channels=DayZA3,%2CDayZA3Support")
    End Sub
    Private Sub ChangelogToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem1.Click
        Me.Hide()
        Changelog.Show()
    End Sub
    Private Sub CleanupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanupToolStripMenuItem.Click

        ZoombiesSettingsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" + "ZoombiesUniversalLauncher.xml"

        Dim getXMLData As XmlReader = New XmlTextReader(ZoombiesSettingsFile)
        Dim ArmA3Path As String = ""

        While (getXMLData.Read())
            Dim type = getXMLData.NodeType
            If (type = XmlNodeType.Element) Then
                If getXMLData.Name = "ArmA3Path" Then
                    ArmA3Path = getXMLData.ReadInnerXml
                End If
            End If
        End While

        getXMLData.Close()

        Dim N2K As Boolean = False

        If MsgBox("Are you sure you want to cleanup DayZA3 files?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Try
                If N2K = False Then
                    My.Computer.FileSystem.DeleteDirectory(ArmA3Path + "\@AllInArma", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.DeleteDirectory(ArmA3Path + "\@CBA_A3", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.DeleteDirectory(ArmA3Path + "\@DayZA3_Chernarus", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.DeleteDirectory(ArmA3Path + "\@DayZA3_Taviana", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    MsgBox("Completed cleanup! Please restart the launcher!")
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("You cannot perform a cleanup while not having the core mods installed.")
            End Try
        Else
            'Do nothing
        End If
    End Sub
End Class