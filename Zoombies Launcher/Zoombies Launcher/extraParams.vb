Public Class extraParams

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim extraparams As String
        extraparams = "http://community.bistudio.com/wiki/Arma2:_Startup_Parameters"
        System.Diagnostics.Process.Start(extraparams)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Computer.FileSystem.WriteAllText("parameters.txt", extraBox.Text, False)
        Catch ex As Exception
            MsgBox("File in use, try again!")
        End Try
        Main.Show()
        Me.Close()
    End Sub
    Private Sub extraParams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim readText As New System.IO.StreamReader("parameters.txt")
        extraBox.Text = readText.ReadToEnd
        readText.Close()
    End Sub
    Shared Function readParams() As String
        Dim readText As New System.IO.StreamReader("parameters.txt")
        readText.ReadToEnd()
        readText.Close()
    End Function
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
End Class