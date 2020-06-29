Public Class Form1
    Private m_objDrawSurface As Bitmap
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        m_objDrawSurface = New Bitmap(Me.ClientRectangle.Width,
                                      Me.ClientRectangle.Height,
                                      Drawing.Imaging.PixelFormat.Format24bppRgb)
        InitializeSurface()

    End Sub

    Private Sub InitializeSurface()
        Dim objGraphics As Graphics
        Dim rectBounds As Rectangle
        objGraphics = Graphics.FromImage(m_objDrawSurface)
        objGraphics.Clear(SystemColors.Control)

        rectBounds = New Rectangle(0, 0, m_objDrawSurface.Width, m_objDrawSurface.Height)

        rectBounds.Inflate(-20, -20)

        objGraphics.DrawEllipse(Pens.Orange, rectBounds)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim objGraphics As Graphics
        objGraphics = e.Graphics
        objGraphics.DrawImage(m_objDrawSurface, 0, 0,
                              m_objDrawSurface.Width,
                              m_objDrawSurface.Height)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objGraphics As Graphics
        Dim objFont As Font
        Dim intFontSize As Integer
        Dim intTextX As Integer
        Dim intTextY As Integer
        Dim objRnd As Random

        If Me.TextBox1.Text = vbNullString Then
            Exit Sub
        End If

        objGraphics = Graphics.FromImage(m_objDrawSurface)

        objRnd = New Random(Now.Millisecond)

        intFontSize = objRnd.Next(8, 48)
        intTextX = objRnd.Next(0, Me.ClientRectangle.Width - 20)
        intTextY = objRnd.Next(0, Me.ClientRectangle.Height - 20)
        objFont = New Font("Arial", intFontSize, FontStyle.Bold Or FontStyle.Italic)

        objGraphics.DrawString(Me.TextBox1.Text, objFont,
                               Choose(objRnd.Next(1, 5), Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.Gray, Brushes.Azure),
                               intTextX, intTextY)
        objGraphics.Dispose()
        Me.Invalidate()
    End Sub
End Class
