Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1_RunSub.Click
        Call dothings()
    End Sub

    Private Sub Button2_RunFunc_Click(sender As Object, e As EventArgs) Handles Button2_RunFunc.Click
        MsgBox(GetDate(), vbOKOnly, "hello!")
    End Sub

    Private Sub dothings()
        Me.TextBox1_Output.Text = "Hello world"
        Me.TextBox1_Output.BackColor = Color.Black
        Me.TextBox1_Output.ForeColor = Color.Yellow

        Call updateTextbox()
    End Sub

    Private Function GetDate() As String
        Return Date.Now.ToString
    End Function

    Private Function GetWknum() As String
        Dim tmp As String = DatePart("ww", Date.Today.Date, vbMonday).ToString
        Return String.Format("{0}{1}", Date.Today.Year - 2000, tmp)
    End Function
    Private Sub updateTextbox()
        Dim tmp As String = Me.TextBox1_Output.Text
        Dim fmt As String = "{0},{3}Today is {1},{3}Weeknum is {2}"
        Me.TextBox1_Output.Text = String.Format(fmt, tmp, GetDate(), GetWknum(), vbCrLf)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1_operator.SelectedIndex = 0
        Me.Text = "dumb vb application @ZL, 202007"
    End Sub

    Private Enum operators
        Add
        Subt
        Mul
        Div
        Exp
    End Enum

    Private Function GetOperator() As operators
        Select Case Me.ComboBox1_operator.Text
            Case "+" : Return operators.Add
            Case "-" : Return operators.Subt
            Case "*" : Return operators.Mul
            Case "/" : Return operators.Div
            Case "^" : Return operators.Exp
            Case Else : Return operators.Add
        End Select
    End Function

    Private Function Calculate(a As Double, b As Double, op As operators) As Double
        If op = operators.Add Then Return a + b
        If op = operators.Subt Then Return a - b
        If op = operators.Mul Then Return a * b
        If op = operators.Div Then Return a / b
        If op = operators.Exp Then Return a ^ b
        Return 0
    End Function

    Private Sub SolveProblem()
        Try
            Me.TextBox3_Result.Text = Calculate(Me.TextBox1_A.Text, Me.TextBox2_B.Text, GetOperator())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_A_TextChanged(sender As Object, e As EventArgs) Handles TextBox1_A.TextChanged
        Call SolveProblem()
    End Sub

    Private Sub TextBox2_B_TextChanged(sender As Object, e As EventArgs) Handles TextBox2_B.TextChanged
        Call SolveProblem()
    End Sub

    Private Sub ComboBox1_operator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1_operator.SelectedIndexChanged
        Call SolveProblem()
    End Sub
End Class
