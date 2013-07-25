Imports Ionic.Zip
Public Class Form1
    Dim updateZIPloc = My.Computer.FileSystem.CurrentDirectory + "\" + "update.zip"
    Private Sub DownloadUpdate(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hides the form so the process runs flawlessly in the background.
        Me.Hide()
        'Gets the most up to date launcher files, remotely.
        Dim getLauncherRemoteVersion As String
        Try
            Using getRemoteVersion As New System.Net.WebClient()
                getLauncherRemoteVersion = getRemoteVersion.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/ziplauncher2.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavailable at this time. Please try again later. (ziplauncher.txt)")
        End Try

        'Checks to see if the "update.zip" is already available, and if it is found it will be removed to avoid conflict.
        Try
            If My.Computer.FileSystem.FileExists(updateZIPloc) Then
                My.Computer.FileSystem.DeleteFile(updateZIPloc)
            End If
            'Makes sure that the link (remotely) is working. And if the link is valid, continue the download.
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

        'Closes the updater after the process finishes.
        Me.Close()
    End Sub
    Private Sub ExtractUpdate()
        'Declaring varibles
        Dim UpdateZip = "update.zip"
        Dim UnpackLocation = My.Computer.FileSystem.CurrentDirectory + "\"

        'Starts the unzip operation.
        Using doZipExtract As ZipFile = ZipFile.Read(UpdateZip)
            Dim e As ZipEntry
            For Each e In doZipExtract
                e.Extract(UnpackLocation, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub
End Class