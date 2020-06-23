Public Class Form1
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim mouse_point_x, mouse_point_y As Integer
        mouse_point_x = e.X
        mouse_point_y = e.Y

        With Me.TextBox1
            .BorderStyle = BorderStyle.FixedSingle
            .Text = String.Format("mouse position:{0} ({1},{2})", Environment.NewLine, mouse_point_x, mouse_point_y)
        End With

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        With Me.TextBox1
            .Text = vbNullString
        End With
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        With Me.TextBox2
            .Text = String.Format("clicks: {0}", e.Clicks)
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
        'Form2.ShowDialog()
    End Sub
End Class
