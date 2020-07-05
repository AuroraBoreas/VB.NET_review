Imports System.Drawing.Drawing2D
Imports System.Drawing

Public Class Form1
    'I wanna manipulate GDI
    Dim backbuffer As New Bitmap(Me.Width, Me.Height)
    Dim g As Graphics = Graphics.FromImage(backbuffer)
    Dim gradientBrush As New LinearGradientBrush(New Point(100, 100), New Point(200, 200), Color.Blue, Color.Red)
    Dim x As Long = ClientSize.Width / 2
    Dim y As Long = ClientSize.Height / 2
    Dim imageMatrix As New Matrix()

    Dim isMouseDown As Boolean = False
    Dim mousePoint As Point

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        g.Clear(Color.Black)
        g.Transform = imageMatrix
        'do ann the drawing
        g.DrawRectangle(Pens.Blue, New Rectangle(New Point(x - 50, y - 50), New Size(100, 100)))
        g.FillEllipse(gradientBrush, New Rectangle(New Point(x - 50, y - 50), New Size(100, 100)))
        'end drawing

        Me.CreateGraphics.DrawImage(backbuffer, New Point(0, 0))
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                imageMatrix.RotateAt(-10, New Point(x, y))
            Case Keys.D
                imageMatrix.RotateAt(10, New Point(x, y))
            Case Keys.Space
                imageMatrix.Reset()
            Case Keys.W
                imageMatrix.Scale(1.01, 1.01)
            Case Keys.S
                imageMatrix.Scale(0.99, 0.99)
        End Select
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        isMouseDown = True
        mousePoint = e.Location
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown = True Then
            imageMatrix.Translate(e.X - mousePoint.X, e.Y - mousePoint.Y)
            mousePoint = e.Location
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        isMouseDown = False
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        backbuffer = New Bitmap(Me.Width, Me.Height)
    End Sub
End Class
