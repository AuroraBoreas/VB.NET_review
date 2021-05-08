Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.ListBox1
            .Items.AddRange({
                            "Python",
                            "C/C++",
                            "C#",
                            "VB",
                            "Java",
                            "JavaScript",
                            "HTML+CSS",
                            "SQL",
                            "Julia",
                            "Lua",
                            "R",
                            "pandas",
                            "numpy",
                            "django",
                            "flask",
                            "asp.net"
                            })

            .SelectedIndex = 0
            .Parent.Text = "Simple App01, v0.01 @ZL, 20210508"
        End With
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        With Me
            .Label1.Text = "I love *TS* more than "
            .Label1.AutoSize = True
            .TextBox1.Text = .ListBox1.SelectedItem.ToString()
            .TextBox1.TextAlign = HorizontalAlignment.Center
            Dim rnd As New Random
            .TextBox1.BackColor = Color.FromArgb(rnd.Next(125, 255),
                                                 rnd.Next(125, 255),
                                                 rnd.Next(125, 255))
            ' rnd = nothing '?
        End With
    End Sub
End Class
