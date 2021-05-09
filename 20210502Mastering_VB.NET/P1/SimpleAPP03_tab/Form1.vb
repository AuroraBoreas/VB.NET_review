Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Button1.Text = "Start"
            .Button2.Text = "Stop"
            .Button3.Text = "Clear"

            .Label1.Text = "Increament"
            .Label2.Text = "Interval(ms)"
            .Label3.Text = "Intimate"

            .TextBox1.Text = 10
            .TextBox2.Text = 1_000

            .Text = "Simple APP03, v0.01 @ZL, 20210509"
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Timer1.Start()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            .Timer1.Stop()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Me
            .Timer1.Stop()
            .ProgressBar1.Value = 0
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With Me
            If Not Integer.TryParse(.TextBox2.Text, .Timer1.Interval) Then
                MessageBox.Show("input error")
            End If
            .ProgressBar1.Increment(.TextBox1.Text)
        End With
    End Sub
End Class
