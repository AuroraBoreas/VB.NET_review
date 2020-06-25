Public Class Form1
    Private Shared Sub draw_border_for_picbox1(ByRef objPicturebox As PictureBox)
        'draw a border for picturebox1 control on *Form1*
        Dim objGraphic As Graphics
        objGraphic = objPicturebox.Parent.CreateGraphics
        objGraphic.Clear(SystemColors.Control)
        objGraphic.DrawRectangle(Pens.Blue,
                                 objPicturebox.Left - 1,
                                 objPicturebox.Top - 1,
                                 objPicturebox.Width + 1,
                                 objPicturebox.Height + 1
        )
        objGraphic.Dispose()
    End Sub

    Private Shared Sub reset_border_for_picbox1(ByRef objPicturebox As PictureBox)
        objPicturebox.BorderStyle = BorderStyle.None
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.Text = TimeOfDay.ToString("h:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
        Dim objListItem As ListViewItem
        objListItem = Me.ListView1.Items.Add("SK", 1)
        objListItem.SubItems.Add("USA")
        objListItem = Me.ListView1.Items.Add("BB", 2)
        objListItem.SubItems.Add("JPN")
        objListItem = Me.ListView1.Items.Add("OI", 3)
        objListItem.SubItems.Add("DE")
        objListItem = Me.ListView1.Items.Add("TO", 4)
        objListItem.SubItems.Add("SPAIN")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub OpenPictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPictureToolStripMenuItem.Click

        With Me.OpenFileDialog1
            .Title = "Choose a picture"
            .RestoreDirectory = True
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Windows BMP|*.jpg;*.png;*.gif;*.BMP"

            If .ShowDialog = DialogResult.OK Then
                Me.PictureBox1.Image = Image.FromFile(.FileName)
            End If

        End With
    End Sub

    Private Sub ConfirmOnExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfirmOnExitToolStripMenuItem.Click
        Me.ConfirmOnExitToolStripMenuItem.Checked = Not (Me.ConfirmOnExitToolStripMenuItem.Checked)
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.PictureBox1.Image.Dispose()
        Me.Close()
    End Sub

    Private Sub DrawBorderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DrawBorderToolStripMenuItem1.Click
        Call draw_border_for_picbox1(Me.PictureBox1)
    End Sub

    Private Sub DrawBorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawBorderToolStripMenuItem.Click
        Call draw_border_for_picbox1(Me.PictureBox1)
    End Sub

    Private Sub ClearBorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearBorderToolStripMenuItem.Click
        Call reset_border_for_picbox1(Me.PictureBox1)
    End Sub
End Class
