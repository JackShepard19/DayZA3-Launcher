Public Class installationCheck
    Dim a2value As String
    Dim a2oavalue As String
    Dim a2oabetavalue As String
    Dim a3value As String
    Private Sub installationCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a2value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2", "main", Nothing)

        a2oavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "main", Nothing)

        a2oabetavalue = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "DATA", Nothing)

        a3value = My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\Arma 3", "main", Nothing)

        'ArmA 2
        If My.Computer.FileSystem.FileExists(a2value + "\arma2.exe") Then
            installA2.ForeColor = Color.LimeGreen
            installA2.Text = "Installed"
        Else
            installA2.ForeColor = Color.Red
            installA2.Text = "Not Installed"
        End If
        'ArmA 2 OA
        If My.Computer.FileSystem.FileExists(a2oavalue + "\arma2oa.exe") Then
            installA2OA.ForeColor = Color.LimeGreen
            installA2OA.Text = "Installed"
        Else
            installA2OA.ForeColor = Color.Red
            installA2OA.Text = "Not Installed"
        End If
        'ArmA 2 OA Beta
        If My.Computer.FileSystem.FileExists(a2oabetavalue + "\beta\arma2oa.exe") Then
            installA2OABeta.ForeColor = Color.LimeGreen
            installA2OABeta.Text = "Installed"
        Else
            installA2OABeta.ForeColor = Color.Red
            installA2OABeta.Text = "Not Installed"
        End If
        'ArmA 3
        If My.Computer.FileSystem.FileExists(a3value + "\arma3.exe") Then
            installA3.ForeColor = Color.LimeGreen
            installA3.Text = "Installed"
        Else
            installA3.ForeColor = Color.Red
            installA3.Text = "Not Installed"
        End If
        'If the A2OA beta is installed, get the version
        If My.Computer.FileSystem.FileExists(a2oabetavalue + "\beta\arma2oa.exe") Then
            installBetaVersion.Visible = True
            CheckBeta()
        Else
            'do nothing... really
            installBetaVersion.Visible = False
        End If
    End Sub
    Private Sub CheckBeta()
        a2oavalue = My.Computer.Registry.GetValue _
       ("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA", "DATA", Nothing)

        Dim getA2OABeta As FileVersionInfo = FileVersionInfo.GetVersionInfo(a2oavalue + "\beta" + "\arma2oa.exe")

        If My.Computer.FileSystem.FileExists(a2oavalue + "\beta" + "\arma2oa.exe") Then
            Try
                installBetaVersion.Text = getA2OABeta.ProductVersion.Substring(7)
            Catch ex As Exception
                MsgBox("Please install the most recent version of the ArmA2OA beta.")
                Me.Close()
            End Try
        Else
            MsgBox("Please install the most recent version of the ArmA2OA beta.")
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_Done.Click
        Main.Show()
        Me.Close()
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