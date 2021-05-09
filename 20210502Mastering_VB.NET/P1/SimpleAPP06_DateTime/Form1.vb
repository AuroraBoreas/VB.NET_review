Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Label1.AutoSize = True
            .Timer1.Interval = 1_000
            .Timer1.Start()
            .Text = "SimpleAPP06, v0.01 @ZL, 20210509"
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With Me
            .Label1.Text = Date.Now.ToString("yyyy-MMM-dd hh:mm:ss")
        End With
    End Sub
End Class
