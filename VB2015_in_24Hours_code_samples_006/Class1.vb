Public Class MyObject
    Private _color As Color
    Private _surface As Graphics
    Private _layout As Rectangle

    Public Event ColorChanged(e As Color)

    Public Property Color
        Set(value)
            _color = value
            RaiseEvent ColorChanged(_color)
        End Set
        Get
            Return _color
        End Get
    End Property

    Public Sub New(surface As Graphics, color As Color, layout As Rectangle)
        _surface = surface
        _color = color
        _layout = layout

        'AddHandler ColorChanged, AddressOf UpdatedColor
        'or
        'AddHandler ColorChanged, Sub()
        '                             Draw()
        '                         End Sub
        'or
        Dim reDraw = Sub()
                         Draw()
                     End Sub
        AddHandler ColorChanged, reDraw
    End Sub

    Private Sub UpdatedColor()
        Draw()
    End Sub
    Public Sub Draw()
        _surface.FillRectangle(New SolidBrush(_color), _layout)
    End Sub

End Class
