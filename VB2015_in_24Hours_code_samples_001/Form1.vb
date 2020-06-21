Public Class Form1

    Private Sub Button_Select_Click(sender As Object, e As EventArgs) Handles Button_Select.Click
        'change form's font in runtime. retrieve this form's FontFamily, then change font size via Font class
        Me.Font = New Font(Me.Font.FontFamily, 14, GraphicsUnit.Point)
        Dim BaseDir As String = Application.StartupPath

        With Me.OpenFileDialog1
            .Title = "Select a picture"
            .RestoreDirectory = True
            .Filter = "Windows Bitmaps}|*.jpg;*.png;*.gif"
            .CheckFileExists = True

            '.ShowDialog w/o () works as well
            If .ShowDialog() = DialogResult.OK Then
                'app title changes in runtime
                Me.Text = String.Format("Picture Viewer({0})", .FileName)
                'app icon changes in runtime
                Dim icon As New System.Drawing.Icon(String.Format("{0}\{1}", BaseDir, "robot.ico"))
                Me.Icon = icon
                'break image stream
                icon.Dispose()
                'picturebox1 backcolor changes in runtime
                Me.PictureBox1.BackColor = Color.FromArgb(25, 255, 125)
                'load picture
                Me.PictureBox1.Image = Image.FromFile(.FileName)
                'Me.PictureBox1.Image.Dispose()
            End If
        End With

        Dim rnd As New Random
        Dim r, g, b As Integer

        'get random r, g, b between 0, 255
        r = rnd.Next(0, 255)
        g = rnd.Next(0, 255)
        b = rnd.Next(0, 255)
        'change form's background color in runtime
        Me.BackColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub Button_ChangeFont_Click(sender As Object, e As EventArgs) Handles Button_ChangeFont.Click

        'get a random number btw 1 and 100
        Dim FontSize As Integer, r As Integer, g As Integer, b As Integer
        '.NET Random class must be initialized to get a new instance or it may replicate previous result 
        Dim rnd As New Random
        'get random font size between 8, 20
        FontSize = rnd.Next(8, 24)
        'get random r, g, b between 0, 255
        r = rnd.Next(0, 255)
        g = rnd.Next(0, 255)
        b = rnd.Next(0, 255)
        'change form's FontFamily to *Tahoma*, and change font size dynamically
        Me.Font = New Font("Tahoma", FontSize, GraphicsUnit.Point)
        'change textbox's background color in runtime
        With Me.TextBox_ShowFontSize
            .Text = Me.Font.FontFamily.Name & "," & FontSize
            .BorderStyle = BorderStyle.None
            .BackColor = Color.FromArgb(r, g, b)
        End With


    End Sub
End Class
