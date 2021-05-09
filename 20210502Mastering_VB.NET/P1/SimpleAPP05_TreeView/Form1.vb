Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Label1.Text = "FORM1"
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = 0 To 10
            With Me
                .ListBox1.Items.Add(i * i)
                Threading.Thread.Sleep(500)
            End With
        Next

        While (i > 0)
            MessageBox.Show(i)
            i = i - 1
        End While
    End Sub
End Class
