Public Class Form1

    Const strTitle As String = "Enter your favorite programming language"
    Const strBtn As String = "Evaluate My Choice"
    Const strLang As String = "Visual Basic"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "A Simple Application @ZL, 20210503"

            .label_lang.Text = strTitle
            .label_lang.AutoSize = True

            .Btn_Evaluate.Text = strBtn
            .Btn_Evaluate.AutoSize = True
        End With
    End Sub

    Private Sub Btn_Evaluate_Click(sender As Object, e As EventArgs) Handles Btn_Evaluate.Click
        With Me.RichTextBox1
            If .TextLength = 0 Then
                MessageBox.Show("Please enter your choice!")
            Else
                If .TextLength > strLang.Length Then
                    MessageBox.Show("We have a winner!")
                ElseIf .TextLength < strLang.Length Then
                    MessageBox.Show("We have a loser!")
                Else
                    MessageBox.Show("You choose a hard way!")
                End If
            End If

        End With
    End Sub
End Class
