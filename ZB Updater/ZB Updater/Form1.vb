Imports Ionic.Zip
Public Class Form1
    Dim updateZIPloc = My.Computer.FileSystem.CurrentDirectory + "\" + "update.zip"
    Private Sub DownloadUpdate(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim getLauncherRemoteVersion As String
        Try
            Using getRemoteVersion As New System.Net.WebClient()
                getLauncherRemoteVersion = getRemoteVersion.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/ziplauncher2.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (ziplauncher.txt)")
        End Try

        Try
            If My.Computer.FileSystem.FileExists(updateZIPloc) Then
                My.Computer.FileSystem.DeleteFile(updateZIPloc)
            End If
            If Not String.IsNullOrEmpty(getLauncherRemoteVersion) Then
                My.Computer.Network.DownloadFile(getLauncherRemoteVersion, "update.zip")
                Try
                    ExtractUpdate()
                    MsgBox("Update Complete!", MsgBoxStyle.Information, "")
                    My.Computer.FileSystem.DeleteFile(updateZIPloc)
                    Process.Start("Zoombies Launcher.exe")
                Catch ex As Exception
                    MsgBox("An error occured when attempting to extract the update!")
                End Try
            Else
                MsgBox("An error occured when attempting to retrieve the download URL.")
            End If
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (update.zip)")
        End Try

        '"Everything is done master..." "You may rest your head now."
        Me.Close()
        'GOOBY PLS! DUNDUTIS!!! GOOBY PLS!
        'BE GOOD FOR GOOBY... huehuehue
    End Sub
    Private Sub ExtractUpdate()
        Dim UpdateZip = "update.zip"
        Dim UnpackLocation = My.Computer.FileSystem.CurrentDirectory + "\"

        Using doZipExtract As ZipFile = ZipFile.Read(UpdateZip)
            Dim e As ZipEntry
            For Each e In doZipExtract
                e.Extract(UnpackLocation, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub
End Class