Structure Employee
    Dim id As Integer
    Dim name As String
    Dim age As Integer
    Public Sub New(id, name, age)
        Me.id = id
        Me.name = name
        Me.age = age
    End Sub
    Public Overrides Function ToString() As String
        Return $"id: {Me.id}, name: {Me.name}, age: {Me.age}"
    End Function
End Structure

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Simple Application, v0.01 @ZL, 20210516"

            .Label1.Text = "array"
            .Label2.Text = "list"
            .Label3.Text = "dict"
            .Label4.Text = "set"

            .Button1.Text = "populate array"
            .Button1.AutoSize = True
            .Button2.Text = "populate list"
            .Button2.AutoSize = True
            .Button3.Text = "populate dict"
            .Button3.AutoSize = True
            .Button4.Text = "populate set"
            .Button4.AutoSize = True

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emps(10) As Employee
        emps(0) = New Employee(1, "ZL", 35)
        emps(1) = New Employee(2, "TS", 30)
        emps(2) = New Employee(3, "SCY", 35)
        emps(3) = New Employee(1, "ZL", 35)
        emps(4) = New Employee(2, "TS", 30)
        emps(5) = New Employee(3, "SCY", 35)
        emps(6) = New Employee(1, "ZL", 35)
        emps(7) = New Employee(2, "TS", 30)
        emps(8) = New Employee(3, "SCY", 35)

        For Each emp As Employee In emps
            With Me
                .ListBox1.Items.Add(emp.ToString())
            End With
        Next
        Colorize(Me.ListBox1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emps As New List(Of Employee)
        emps.Add(New Employee(1, "ZL", 35))
        emps.Add(New Employee(2, "TS", 30))
        emps.Add(New Employee(3, "SCY", 35))
        emps.Add(New Employee(1, "ZL", 35))
        emps.Add(New Employee(2, "TS", 30))
        emps.Add(New Employee(3, "SCY", 35))
        emps.Add(New Employee(1, "ZL", 35))
        emps.Add(New Employee(2, "TS", 30))
        emps.Add(New Employee(3, "SCY", 35))

        With Me
            For Each emp As Employee In emps
                .ListBox2.Items.Add(emp.ToString())
            Next
        End With
        Colorize(Me.ListBox2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim emps As New Dictionary(Of Integer, Employee)
        emps.Add(0, New Employee(1, "ZL", 35))
        emps.Add(1, New Employee(2, "TS", 30))
        emps.Add(2, New Employee(3, "SCY", 35))

        With Me
            For Each kv As KeyValuePair(Of Integer, Employee) In emps
                .ListBox3.Items.Add(kv.Value.ToString())
            Next
        End With
        Colorize(Me.ListBox3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim emps As New HashSet(Of Employee) From {
            New Employee(1, "ZL", 35),
            New Employee(2, "TS", 30),
            New Employee(3, "SCY", 35),
            New Employee(1, "ZL", 35),
            New Employee(2, "TS", 30),
            New Employee(3, "SCY", 35)
        }

        With Me
            For Each emp As Employee In emps
                .ListBox4.Items.Add(emp.ToString())
            Next
        End With
        Colorize(Me.ListBox4)
    End Sub

    Private Shared Sub Colorize(control As ListBox)
        Dim rnd As New Random
        Dim R As Integer, G As Integer, B As Integer
        Dim lbound As Integer = 150
        Dim ubound As Integer = 255
        R = rnd.Next(lbound, ubound)
        G = rnd.Next(lbound, ubound)
        B = rnd.Next(lbound, ubound)
        control.BackColor = Color.FromArgb(R, G, B)
    End Sub
End Class
