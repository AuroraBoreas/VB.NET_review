Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Label1.Text = "What to evaluate?"
            .Label2.Text = "Ouput"
            .Label3.Text = "="

            .ComboBox1.Items.AddRange({"AND", "OR", "Marriage"})
            .ListBox1.Items.AddRange({"True", "False"})
            .ListBox2.Items.AddRange({"True", "False"})

            .TextBox1.TextAlign = HorizontalAlignment.Center

            .ComboBox1.SelectedIndex = 0
            .ListBox1.SelectedIndex = 0
            .ListBox2.SelectedIndex = 0

            .Text = "Simple APP, v0.01 @ZL, 20210508"
            ChangeGroupName()
        End With
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ChangeBackColor(Me.ListBox1)
        Evaluate()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ChangeBackColor(Me.ListBox2)
        Evaluate()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ChangeGroupName()
        ChangeBackColor(Me.TextBox1)
        Evaluate()
    End Sub

    Private Sub ChangeBackColor(ByRef control As Control)
        Dim rnd As New Random
        Const llimit As Integer = 160
        Const ulimit As Integer = 255
        If (control Is Nothing) Then
            Throw New ArgumentException("control")
        Else
            control.BackColor = Color.FromArgb(rnd.Next(llimit, ulimit),
                                               rnd.Next(llimit, ulimit),
                                               rnd.Next(llimit, ulimit))
        End If
        Me.TextBox1.BackColor = Color.FromArgb(rnd.Next(llimit, ulimit),
                                               rnd.Next(llimit, ulimit),
                                               rnd.Next(llimit, ulimit))
    End Sub

    Private Sub ChangeGroupName()
        With Me
            Select Case ComboBox1.SelectedIndex
                Case = 0
                    GroupBox1.Text = "A"
                    GroupBox2.Text = "B"
                Case = 1
                    GroupBox1.Text = "A"
                    GroupBox2.Text = "B"
                Case = 2
                    GroupBox1.Text = "ZL"
                    GroupBox2.Text = "TS"
            End Select
        End With
    End Sub
    Private Sub Evaluate()
        With Me
            If ComboBox1.SelectedIndex = 0 Then
                Select Case .ListBox1.SelectedIndex
                    Case 0
                        If .ListBox2.SelectedIndex = 0 Then
                            TextBox1.Text = "True"
                        Else
                            TextBox1.Text = "False"
                        End If
                    Case 1
                        If .ListBox2.SelectedIndex = 0 Then
                            TextBox1.Text = "False"
                        Else
                            TextBox1.Text = "True"
                        End If
                End Select
            ElseIf ComboBox1.SelectedIndex = 1 Then
                Select Case .ListBox1.SelectedIndex
                    Case 0
                        If .ListBox2.SelectedIndex = 0 Then
                            TextBox1.Text = "True"
                        Else
                            TextBox1.Text = "True"
                        End If
                    Case 1
                        If .ListBox2.SelectedIndex = 0 Then
                            TextBox1.Text = "True"
                        Else
                            TextBox1.Text = "False"
                        End If
                End Select
            Else
                Select Case .ListBox1.SelectedIndex
                    Case 0
                        If .ListBox2.SelectedIndex = 0 Then
                            TextBox1.Text = "TS is right"
                        Else
                            TextBox1.Text = "TS is right"
                        End If
                    Case 1
                        If .ListBox2.SelectedIndex = 0 Then
                            TextBox1.Text = "TS is right"
                        Else
                            TextBox1.Text = "ZL is wrong"
                        End If
                End Select
            End If
        End With
    End Sub
End Class
