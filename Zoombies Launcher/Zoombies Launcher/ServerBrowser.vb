Imports System.Xml
Imports System.IO
Imports System.Text
Public Class ServerBrowser
    Private Sub ServerBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getRemoteServers()

        lbl_PlayHostName.Text = ""
    End Sub
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        'Main.Show()
        Me.Close()
    End Sub
    Private Sub bt_getList_Click(sender As Object, e As EventArgs) Handles bt_getList.Click
        getRemoteServers()
    End Sub
    Dim ipArray As New Dictionary(Of String, String)
    Dim portArray As New Dictionary(Of String, String)
    Dim subItemVal As New ListViewItem
    Sub getRemoteServers()
        lv_ServerBrowser.Items.Clear()

        Dim xmllist As String = "http://arma3.swec.se/server/list.xml?country=&mquery=DayZ&nquery=&state_playing=1"
        'Try
        '    Using WC As New System.Net.WebClient()
        '        xmllist = WC.DownloadString("http://arma3.swec.se/server/list.xml?country=&mquery=DayZ&nquery=&state_playing=1")
        '    End Using
        'Catch ex As Exception
        '    MsgBox("Error downloading server list. Try again later.")
        '    Main.Show()
        '    Me.Close()
        'End Try

        Dim host_name As XmlReader = XmlReader.Create(xmllist)
        Dim country As XmlReader = XmlReader.Create(xmllist)
        lv_ServerBrowser.BeginUpdate()

        Dim getXMLData As XmlReader = New XmlTextReader(xmllist)
        Dim countryVal As String = "?"
        Dim ipAddress As String = "?"
        Dim serverName As String = "?"
        Dim playerCount As String = "0"
        Dim port As String = "0"

        lv_ServerBrowser.View = View.Details
        ipArray.Clear()
        portArray.Clear()

        While (getXMLData.Read())
            Dim type = getXMLData.NodeType
            If (type = XmlNodeType.Element) Then
                If getXMLData.Name = "country" Then
                    countryVal = getXMLData.ReadInnerXml
                End If
                If getXMLData.Name = "host" Then
                    ipAddress = getXMLData.ReadInnerXml
                End If
                If getXMLData.Name = "players" Then
                    playerCount = getXMLData.ReadInnerXml
                End If
                If getXMLData.Name = "name" Then
                    serverName = getXMLData.ReadInnerXml
                    subItemVal = lv_ServerBrowser.Items.Add(serverName)
                    subItemVal.SubItems.Add(countryVal)
                    subItemVal.SubItems.Add(playerCount)
                    getPing(serverName, ipAddress, subItemVal)
                End If
                If getXMLData.Name = "port" Then
                    portArray.Add(serverName, getXMLData.ReadInnerXml.ToString)
                End If
                If Not ipArray.ContainsKey(serverName) Then
                    ipArray.Add(serverName, ipAddress)
                End If
            End If
        End While
        lv_ServerBrowser.EndUpdate()
    End Sub
    Private Sub lv_ServerBrowser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_ServerBrowser.SelectedIndexChanged
        If lv_ServerBrowser.SelectedIndices.Count > 0 Then
            Dim first As String = lv_ServerBrowser.SelectedItems(0).ToString.Substring(15)
            Dim second As String = first.Substring(0, first.Length() - 1)
            'Console.WriteLine(ipArray.Item(second) + ":" + portArray.Item(second))
        End If
    End Sub
    Private Sub getPing(serverName As String, ipAddress As String, subItemValLoc As ListViewItem)
        Dim timer As New Stopwatch
        Try
            timer.Start()
            My.Computer.Network.Ping(ipAddress, 999)
            timer.Stop()
            subItemValLoc.SubItems.Add(timer.ElapsedMilliseconds.ToString)
        Catch pingE As Net.NetworkInformation.PingException
            MsgBox("Taking too long to get server list...")
            Main.Show()
            Me.Close()
        End Try
    End Sub
    Private Sub bt_launch_Click(sender As Object, e As EventArgs) Handles bt_launch.Click
        LaunchGame()
        If lv_ServerBrowser.SelectedIndices.Count > 0 Then
            Dim first As String = lv_ServerBrowser.SelectedItems(0).ToString.Substring(15)
            Dim second As String = first.Substring(0, first.Length() - 1)
        End If
    End Sub
    Private Sub LaunchGame()
        Dim a2value As String
        a2value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2", "main", Nothing)

        Dim a2oavalue As String
        a2oavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "main", Nothing)

        Dim a3value As String
        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        Try
            If lv_ServerBrowser.SelectedIndices.Count > 0 Then
                Dim first As String = lv_ServerBrowser.SelectedItems(0).ToString.Substring(15)
                Dim second As String = first.Substring(0, first.Length() - 1)
                'Console.WriteLine(ipArray.Item(second) + ":" + portArray.Item(second))
                lbl_PlayHostName.Text = "Playing on: " + """" + second + """"
                Console.WriteLine(a3value + "\" + "arma3.exe " + "-connect=" + ipArray.Item(second) + " -port=" + portArray.Item(second) + ExtraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@CBA_A3;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & a2value & ";" & a2oavalue & ";" & a2oavalue & "\Expansion" & ";" & a3value & ";" & "@AllInArma\Core;@AllInArma\PostA3""")
                System.Diagnostics.Process.Start(a3value + "\" + "arma3.exe ", "-connect=" + ipArray.Item(second) + " -port=" + portArray.Item(second) + ExtraParams.extraBox.Text & " " & """-mod=@DayZA3_Chernarus;@CBA_A3;@AllInArma\ProductDummies;C:\Program Files (x86)\Steam\steamapps\common\Take On Helicopter;" & a2value & ";" & a2oavalue & ";" & a2oavalue & "\Expansion" & ";" & a3value & ";" & "@AllInArma\Core;@AllInArma\PostA3""")
            End If
        Catch ex As Exception
            MsgBox("Taking too long to get server information...")
            Main.Show()
            Me.Close()
        End Try
        btn_CloseGame.Visible = True
        bt_launch.Enabled = False
        Me.TopMost = False
    End Sub
    Private Sub btn_CloseGame_Click(sender As Object, e As EventArgs) Handles btn_CloseGame.Click
        For Each p As Process In Process.GetProcesses
            If p.ProcessName = "arma3" Then
                p.Kill()
            End If
        Next
        btn_CloseGame.Visible = False
        lbl_PlayHostName.Text = ""
        bt_launch.Enabled = True
        Me.TopMost = True
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