Public Class Form1
    Public WithEvents MO As New MyObject(Me.CreateGraphics,
                                         Color.Blue,
                                         New Rectangle(90, 120, 100, 100))

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MO.Draw()
    End Sub

    Private Sub MO_ColorChanged(e As Color) Handles MO.ColorChanged
        'MO.Draw()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MO.Color = Color.Red
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                'MO.Color = Color.FromName(TextBox1.Text)
                MO.Color = ColorTranslator.FromHtml(TextBox1.Text)
            Catch ex As Exception
                'do nothing
            End Try
        End If
    End Sub
End Class
