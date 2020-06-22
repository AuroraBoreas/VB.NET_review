Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Font = New Font("Tahoma", 11)
        Dim intIndex As Int16
        Dim strText As String = vbNullString

        For intIndex = 0 To Me.Controls.Count - 1
            strText &= String.Format("control #{0}, name is {1} " & vbCrLf, intIndex, Me.Controls(intIndex))
        Next
        Me.TextBox1.Text = strText
    End Sub

End Class
