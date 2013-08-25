Imports System.Environment
Imports System.Xml
Imports System.Text.RegularExpressions

Public Class InstallationCheck
    Dim a2value As String
    Dim a2oavalue As String
    Dim a2oabetavalue As String
    Dim a3value As String
    Dim ZoombiesSettingsFile As String
    Private Sub installationCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ZoombiesSettingsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" + "ZoombiesUniversalLauncher.xml"

        If My.Computer.FileSystem.FileExists(ZoombiesSettingsFile) = True Then

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
                        tb_arma2.Text = ArmA2Path
                    End If
                    If getXMLData.Name = "ArmA2OAPath" Then
                        ArmA2OAPath = getXMLData.ReadInnerXml
                        tb_arma2oa.Text = ArmA2OAPath
                    End If
                    If getXMLData.Name = "ArmA2OABetaPath" Then
                        ArmA2OABetaPath = getXMLData.ReadInnerXml
                        tb_arma2oabeta.Text = ArmA2OABetaPath
                    End If
                    If getXMLData.Name = "ArmA3Path" Then
                        ArmA3Path = getXMLData.ReadInnerXml
                        tb_arma3.Text = ArmA3Path
                    End If
                End If
            End While
            getXMLData.Close()

            tb_arma2.Text = ArmA2Path
            tb_arma2oa.Text = ArmA2OAPath
            tb_arma3.Text = ArmA3Path
            tb_arma2oabeta.Text = ArmA2OABetaPath

            Console.WriteLine("ArmA2Path: " + ArmA2Path)
            Console.WriteLine("ArmA2OAPath: " + ArmA2OAPath)
            Console.WriteLine("ArmA3Path: " + ArmA3Path)
            Console.WriteLine("ArmA2OABetaPath: " + ArmA2OABetaPath)
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_Done.Click
        If tb_arma2oa.Text = Nothing Then
            MsgBox("Please choose a valid directory!")
            fbd_diag.ShowDialog()
            tb_arma2oa.Text = fbd_diag.SelectedPath
        ElseIf tb_arma3.Text = Nothing Then
            MsgBox("Please choose a valid directory!")
            fbd_diag.ShowDialog()
            tb_arma3.Text = fbd_diag.SelectedPath
        ElseIf tb_arma2oabeta.Text = Nothing Then
            MsgBox("Please choose a valid directory!")
            fbd_diag.ShowDialog()
            tb_arma2oabeta.Text = fbd_diag.SelectedPath
        ElseIf tb_arma2.Text = Nothing Then
            MsgBox("Please choose a valid directory!")
            fbd_diag.ShowDialog()
            tb_arma2.Text = fbd_diag.SelectedPath
        End If
        If tb_arma2.Text.Contains("\") And tb_arma2oa.Text.Contains("\") And tb_arma2oabeta.Text.Contains("\") And tb_arma3.Text.Contains("\") Then
            If MsgBox("Do you have all the game paths set to your desired destination?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

                Dim ZoombiesConfigWrt As New XmlWriterSettings()
                ZoombiesConfigWrt.Indent = True
                Dim ZoombiesConfigWriter As XmlWriter = XmlWriter.Create(ZoombiesSettingsFile, ZoombiesConfigWrt)

                With ZoombiesConfigWriter
                    .WriteStartDocument()
                    .WriteComment("Zoombies Universal Launcher Configuration")
                    .WriteStartElement("Configuration")
                    .WriteStartElement("ArmA2Path")
                    .WriteString(tb_arma2.Text)
                    .WriteEndElement()
                    .WriteStartElement("ArmA2OAPath")
                    .WriteString(tb_arma2oa.Text)
                    .WriteEndElement()
                    .WriteStartElement("ArmA2OABetaPath")
                    .WriteString(tb_arma2oabeta.Text)
                    .WriteEndElement()
                    .WriteStartElement("ArmA3Path")
                    .WriteString(tb_arma3.Text)
                    .WriteEndElement()
                    .WriteStartElement("Liability")
                    .WriteString(1)
                    .WriteEndElement()
                    .WriteStartElement("SetInstallation")
                    .WriteString(1)
                    .WriteEndElement()
                    .WriteStartElement("LaunchParameters")
                    .WriteString("")
                    .WriteEndElement()

                    .WriteEndDocument()
                    .Close()

                End With

                Main.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_getdira2oa_Click(sender As Object, e As EventArgs) Handles btn_getdira2oa.Click
        fbd_diag.ShowDialog()
        tb_arma2oa.Text = fbd_diag.SelectedPath
    End Sub

    Private Sub btn_getdira3_Click(sender As Object, e As EventArgs) Handles btn_getdira3.Click
        fbd_diag.ShowDialog()
        tb_arma3.Text = fbd_diag.SelectedPath
    End Sub

    Private Sub btn_getdira2oabeta_Click(sender As Object, e As EventArgs) Handles btn_getdira2oabeta.Click
        fbd_diag.ShowDialog()
        tb_arma2oabeta.Text = fbd_diag.SelectedPath
    End Sub

    Private Sub btn_getdir_a2_Click(sender As Object, e As EventArgs) Handles btn_getdir_a2.Click
        fbd_diag.ShowDialog()
        tb_arma2.Text = fbd_diag.SelectedPath
    End Sub

    Private Sub btn_restoredefault_Click(sender As Object, e As EventArgs) Handles btn_restoredefault.Click
        a2value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2", "main", Nothing)

        a2oavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "main", Nothing)

        a2oabetavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "DATA", Nothing)

        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        tb_arma2.Text = a2value
        tb_arma2oa.Text = a2oavalue
        tb_arma3.Text = a3value
        tb_arma2oabeta.Text = a2oabetavalue
    End Sub

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
End Class