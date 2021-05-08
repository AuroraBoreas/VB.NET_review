Public Class Form1

    Dim strLang = New String() {"Java", "C++", "C#", "Visual Basic", "Python"}
    Const strTitle = "Select your favorite programming languages"
    Const strEvaluate = "Evaluate My Choice"
    Const firstIndex = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .lable_title.Text = strTitle
            .lable_title.AutoSize = True

            .ComboBox_lang.Items.AddRange(strLang)
            .ComboBox_lang.SelectedIndex = firstIndex

            .Button_confirm.Text = strEvaluate
            .Button_confirm.AutoSize = True

            .Text = "Simple Application v.02 @ZL, 20210504"
        End With
    End Sub

    Private Sub Button_confirm_Click(sender As Object, e As EventArgs) Handles Button_confirm.Click
        With Me.ComboBox_lang.SelectedItem
            If .Equals("Visual Basic") Then
                MessageBox.Show("you choose a hard way, kid!")
            Else
                MessageBox.Show("we have a winner!")
            End If
        End With
    End Sub
End Class
