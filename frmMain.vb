Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Drawing.Imaging
Public Class frmMain

    Dim gameList As New XmlDocument
    Dim imageDownloader As WebClient = New WebClient

    Private Sub generateSizes(ByVal thumbnails As Integer)
        lstSizes.Items.Clear()
        For X As Integer = 0 To thumbnails
            For Y As Integer = 0 To thumbnails
                If X * Y = thumbnails Then
                    lstSizes.Items.Add(X & " Rows x " & Y & " Columns")
                End If
            Next
        Next
    End Sub

    Private Function downloadImage(ByVal URL As String)
        Dim downloadedImage As Bitmap = Bitmap.FromStream(New MemoryStream(imageDownloader.DownloadData(URL)))
        Return downloadedImage
    End Function

    Private Sub txtSteamID_TextChanged(sender As Object, e As EventArgs) Handles txtSteamID.TextChanged
        If txtSteamID.Text = "" Then
            btnFetch.Enabled = False
        Else
            btnFetch.Enabled = True
        End If
    End Sub

    Private Sub txtSteamID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSteamID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFetch.PerformClick()
        End If
    End Sub

    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Try
            gameList.Load("http://steamcommunity.com/id/" & txtSteamID.Text & "/games?tab=all&xml=1")

            If gameList.GetElementsByTagName("gamesList").Count > 0 Then
                If gameList.Item("gamesList").Item("games").GetElementsByTagName("game").Count = 0 Then
                    lstSizes.Enabled = False
                    btnSave.Enabled = False
                    lstSizes.Items.Clear()
                    MsgBox("This ID does not own any games.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Else
                    generateSizes(gameList.Item("gamesList").Item("games").GetElementsByTagName("game").Count)
                    lstSizes.Enabled = True
                    btnSave.Enabled = True
                End If
            Else
                lstSizes.Enabled = False
                btnSave.Enabled = False
                lstSizes.Items.Clear()
                If gameList.GetElementsByTagName("response").Count > 0 Then
                    MsgBox(gameList.Item("response").Item("error").InnerText, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                Else
                    MsgBox("Invalid ID", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End If
            End If
        Catch ex As Exception
            lstSizes.Enabled = False
            btnSave.Enabled = False
            lstSizes.Items.Clear()
            MsgBox("Invalid XML returned. The most common cause is the user's privacy settings.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lstSizes.SelectedIndex >= 0 Then
            sfdCollage.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png"
            sfdCollage.FilterIndex = 0
            If sfdCollage.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtSteamID.Enabled = False
                btnFetch.Enabled = False
                lstSizes.Enabled = False
                btnSave.Enabled = False

                Dim sizeExplosion As String() = lstSizes.SelectedItem.ToString.Split(" x ")
                Dim rows As Integer = sizeExplosion(0)
                Dim columns As Integer = sizeExplosion(3)

                Dim thumbnails As New ArrayList
                For Each game As XmlElement In gameList.Item("gamesList").Item("games").GetElementsByTagName("game")
                    thumbnails.Add(downloadImage(game.Item("logo").InnerText))
                Next

                Dim collage As New Bitmap((184 * columns), (69 * rows))
                Dim g As Graphics = Graphics.FromImage(collage)

                Dim currentRow As Integer = 0
                Dim imagesDone As Integer = 0
                Do Until currentRow = rows
                    Dim currentColumn As Integer = 0
                    Do Until currentColumn = columns
                        g.DrawImageUnscaled(DirectCast(thumbnails.Item(imagesDone), Bitmap), (184 * currentColumn), (69 * currentRow))
                        imagesDone += 1
                        currentColumn += 1
                    Loop
                    currentRow += 1
                Loop

                Dim imageExtension As String = Path.GetExtension(sfdCollage.FileName).ToLower
                If imageExtension = ".bmp" Then
                    collage.Save(sfdCollage.FileName, ImageFormat.Bmp)
                ElseIf imageExtension = ".jpg" Then
                    collage.Save(sfdCollage.FileName, ImageFormat.Jpeg)
                ElseIf imageExtension = ".png" Then
                    collage.Save(sfdCollage.FileName, ImageFormat.Png)
                End If

                txtSteamID.Enabled = True
                btnFetch.Enabled = True
                lstSizes.Enabled = True
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub lblCredits_Click(sender As Object, e As EventArgs) Handles lblCredits.Click
        Process.Start("http://www.itspatel.com/")
    End Sub
End Class
