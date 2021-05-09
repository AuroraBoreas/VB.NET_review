Public Class Form1
    Dim register As New Hashtable()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            ' tab1
            .TabPage1.Text = "Progress"
            .TabPage2.Text = "Login"
            .TabPage3.Text = "Beauty"
            .TabPage4.Text = "Groupbox"
            .TabPage5.Text = "Blank"

            .Label1.Text = "Intimate"
            .Button1.Text = "Start"
            .Button2.Text = "Stop"
            .Button3.Text = "Clear"

            .Label2.Text = "Increment"
            .Label3.Text = "Interval"

            .TextBox1.Text = 10
            .TextBox2.Text = 1_000

            ' tab2
            .Label4.Text = "User Name :"
            .Label5.Text = "Password  :"
            .TextBox4.PasswordChar = "*"
            .Button4.Text = "Sign In"
            .Button5.Text = "Sign Up"


            register.Add("ZL", "123")
            register.Add("TS", "123")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            .Timer1.Start()
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
                MessageBox.Show("input error!")
            End If
            .ProgressBar1.Increment(.TextBox1.Text)
        End With

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With Me
            If register.ContainsKey(.TextBox3.Text) Then
                If register(.TextBox3.Text).Equals(.TextBox4.Text) Then
                    .TextBox3.Text = vbNullString
                    .TextBox4.Text = vbNullString
                    MessageBox.Show("Success!")
                Else
                    MessageBox.Show("password is not correct!")
                End If
            Else
                MessageBox.Show("User name is not correct!")
            End If
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Me
            If Not register.ContainsKey(.TextBox3.Text) Then
                register.Add(.TextBox3.Text, .TextBox4.Text)
                .TextBox3.Text = vbNullString
                .TextBox4.Text = vbNullString
            Else
                MessageBox.Show("User name exists already!")
            End If
        End With
        MessageBox.Show("Success!")
    End Sub
End Class
