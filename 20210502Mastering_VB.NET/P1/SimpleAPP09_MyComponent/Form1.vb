Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Simple Application, v0.01 @ZL"
            .Label1.Text = "Get Text/Data/Image From Clipboard!"
            .Label1.AutoSize = True
            .Button1.Text = "get info from clipboard"
            .Button1.AutoSize = True
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            If My.Computer.Clipboard.ContainsText() Then
                .TextBox1.Text = My.Computer.Clipboard.GetText()
            End If

            If My.Computer.Clipboard.ContainsImage() Then
                Dim pic As Image = My.Computer.Clipboard.GetImage()
                .PictureBox1.Image = New Bitmap(pic, New Drawing.Size(457, 324))
            End If

            If My.Computer.Clipboard.ContainsData(DataFormats.Html) Then
                .TextBox2.Text = My.Computer.Clipboard.GetData(DataFormats.Html)
            End If
        End With
    End Sub
End Class
