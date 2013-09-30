Public Class Changelog
    Private Sub Changelogvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ChernarusLog As String
        Dim TavianaLog As String

        Try
            Using WC As New System.Net.WebClient()
                ChernarusLog = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/changelog.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later.")
        End Try

        Try
            Using WC As New System.Net.WebClient()
                TavianaLog = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/changelog-tavi.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later.")
        End Try

        RichTextBox1.ReadOnly = True
        RichTextBox1.Text = ChernarusLog.ToString

        RichTextBox2.ReadOnly = True
        RichTextBox2.Text = TavianaLog.ToString

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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