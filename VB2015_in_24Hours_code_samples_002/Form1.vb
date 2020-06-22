Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objGraphic As Graphics
        objGraphic = Me.CreateGraphics
        objGraphic.Clear(SystemColors.Control)
        Dim rnd_pen As Pen
        Dim rnd As New Random
        rnd_pen = Choose(rnd.Next(1, 11),
                         Pens.Black,
                         Pens.Cyan,
                         Pens.Red,
                         Pens.Blue,
                         Pens.AliceBlue,
                         Pens.Crimson,
                         Pens.Green,
                         Pens.Silver,
                         Pens.DarkKhaki,
                         Pens.Azure,
                         Pens.BlueViolet
                    )

        objGraphic.DrawRectangle(rnd_pen,
                                 Me.PictureBox1.Left - 1,
                                 Me.PictureBox1.Top - 1,
                                 Me.PictureBox1.Width + 1,
                                 Me.PictureBox1.Height + 1)
        objGraphic.Dispose()

    End Sub
End Class
