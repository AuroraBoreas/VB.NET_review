Public Class Form1

    Dim oprand1 As Double
    Dim oprand2 As Double
    Dim op As String

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.TextBox1.Clear()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click,
                                                                        Button4.Click, Button5.Click, Button6.Click,
                                                                        Button7.Click, Button8.Click, Button9.Click,
                                                                        Button11.Click, Button12.Click

        Me.TextBox1.Text += sender.Text
    End Sub

    Private Sub OpClick(sender As Object, e As EventArgs) Handles op1.Click, op2.Click, op3.Click, op4.Click
        If Not Double.TryParse(Me.TextBox1.Text, oprand1) Then
            Exit Sub
        End If
        op = sender.Text
        ' MessageBox.Show(op)
        Me.TextBox1.Clear()
    End Sub

    Private Sub Op7Click(sender As Object, e As EventArgs) Handles op7.Click
        If Not Double.TryParse(Me.TextBox1.Text, oprand2) Then
            Exit Sub
        End If
        Me.TextBox1.Clear()
        ' ... calculation
        Me.TextBox1.Text = Calc(op).ToString("#,0.00")
    End Sub

    Private Function Calc(op As String) As Double
        Dim result As Double
        Select Case op
            Case "+"
                result = oprand1 + oprand2
            Case "-"
                result = oprand1 - oprand2
            Case "*"
                result = oprand1 * oprand2
            Case "/"
                result = oprand1 / oprand2
        End Select
        Return result
    End Function
End Class
