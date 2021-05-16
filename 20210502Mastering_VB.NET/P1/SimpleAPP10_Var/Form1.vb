Structure Employee
    Dim name As String
    Dim age As Integer
    Public Overrides Function ToString() As String
        Return $"name: {name}, age: {age}"
    End Function
End Structure

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Simple Application v0.01 @ZL, 20210515"
            .Label1.Text = "A"
            .Label2.Text = "B"

            .TextBox1.Text = 100
            .TextBox2.Text = 300

            .Button1.Text = "+"
            .Button1.AutoSize = True
            .Button2.Text = "-"
            .Button2.AutoSize = True
            .Button3.Text = "*"
            .Button3.AutoSize = True
            .Button4.Text = "/"
            .Button4.AutoSize = True

            .GroupBox1.Text = "Operands"
            .GroupBox2.Text = "Operators"
            .GroupBox3.Text = "Result"
            .GroupBox4.Text = "Analysis"

            .Label3.Text = "CHN"
            .Label4.Text = "JPN"
            .Label5.Text = "Result"
            .Button5.Text = "Evaluate"

            .TextBox10.Text = 10
            .Button6.Text = "calc"

            ListCultureInfo(.ListBox1)
            Colorize(.ListBox1)
            Colorize(.TextBox9)
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Calculate(.TextBox1, .TextBox2, .TextBox3, .Button1.Text)
            Colorize(.TextBox3)
            Analyze()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Calculate(.TextBox1, .TextBox2, .TextBox3, .Button2.Text)
            Colorize(.TextBox3)
            Analyze()
        End With
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Me
            Calculate(.TextBox1, .TextBox2, .TextBox3, .Button3.Text)
            Colorize(.TextBox3)
            Analyze()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With Me
            Calculate(.TextBox1, .TextBox2, .TextBox3, .Button4.Text)
            Colorize(.TextBox3)
            Analyze()
        End With
    End Sub

    Private Shared Sub Calculate(control1 As Control, control2 As Control, control3 As Control, operand As String)
        Dim a As Double, b As Double
        Dim rv As Double

        If Double.TryParse(control1.Text, a) And Double.TryParse(control2.Text, b) Then
            Select Case operand
                Case "+"
                    rv = a + b
                    control3.Text = rv.ToString()
                Case "-"
                    rv = a - b
                    control3.Text = rv.ToString()
                Case "*"
                    rv = a * b
                    control3.Text = rv.ToString()
                Case "/"
                    Try
                        rv = a / b
                        control3.Text = rv.ToString()
                    Catch ex As DivideByZeroException
                        control3.Text = "Inf"
                    End Try
            End Select
        Else
            MessageBox.Show("input error. can't parse")
        End If
    End Sub

    Private Shared Sub Colorize(control1 As Control)
        Dim r As Integer, g As Integer, b As Integer
        'Dim a As Double
        Dim rnd As New Random
        r = rnd.Next(125, 255)
        g = rnd.Next(150, 255)
        b = rnd.Next(150, 255)
        'a = rnd.NextDouble()
        control1.BackColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub Analyze()
        Dim input1 As String, input2 As String, input3 As String
        With Me
            input1 = .TextBox1.Text
            input2 = .TextBox2.Text
            input3 = .TextBox3.Text

            If IsDigitals(input1) Then
                .TextBox4.Text = TypeName(input1)
            Else
                .TextBox4.Text = vbNullString
            End If

            If IsDigitals(input2) Then
                .TextBox5.Text = input2.GetType().ToString()
            Else
                .TextBox5.Text = vbNullString
            End If

            If IsDigitals(input3) Then
                .TextBox6.Text = TypeName(input3)
            Else
                .TextBox6.Text = vbNullString
            End If

            Colorize(.TextBox4)
            Colorize(.TextBox5)
            Colorize(.TextBox6)
        End With
    End Sub

    Private Shared Function IsDigitals(s As String) As Boolean
        Dim valid As Boolean = True
        Dim ch As Char
        Dim i As Integer

        For i = 0 To s.Length - 1
            ch = s.Chars(i)
            If Not (Char.IsDigit(ch) Or Char.IsSymbol(ch)) Then
                valid = False
                Exit For
            End If
        Next

        Return valid
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim d1, d2 As Date
        Dim CHN As New System.Globalization.CultureInfo("zh-Hans")
        Dim JPN As New System.Globalization.CultureInfo("ja-JP")

        d1 = DateTime.Parse("2021/05/15", CHN)
        d2 = DateTime.Parse("2021/05/15", JPN)
        With Me
            .TextBox7.Text = d1.ToString()
            .TextBox8.Text = d2.ToString()
            .TextBox9.Text = d1.Equals(d2).ToString()
        End With
    End Sub

    Private Shared Sub ListCultureInfo(control As ListBox)
        For Each ci As System.Globalization.CultureInfo In System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.AllCultures)
            control.Items.Add(ci)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sum As Integer = 0
        Dim last As Integer
        Me.ListBox2.Items.Clear()
        If Integer.TryParse(Me.TextBox10.Text, last) Then
            For i As Integer = 0 To last Step 2
                sum += System.Math.Pow(i, 2)
                Me.ListBox2.Items.Add(sum)
            Next
        End If

        Dim emp1 As Employee, emp2 As Employee
        emp1.name = "ZL"
        emp1.age = 35

        emp2.name = "TS"
        emp2.age = 30

        Dim emps As Employee() = {emp1, emp2}

        For i As Integer = 0 To emps.Length - 1
            With Me
                .ListBox3.Items.Add(emps(i).ToString())
            End With
        Next

    End Sub
End Class
