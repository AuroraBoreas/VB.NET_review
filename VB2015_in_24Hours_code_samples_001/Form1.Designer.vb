<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Select = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button_ChangeFont = New System.Windows.Forms.Button()
        Me.TextBox_ShowFontSize = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(515, 418)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button_Select
        '
        Me.Button_Select.Location = New System.Drawing.Point(559, 23)
        Me.Button_Select.Name = "Button_Select"
        Me.Button_Select.Size = New System.Drawing.Size(125, 23)
        Me.Button_Select.TabIndex = 1
        Me.Button_Select.Text = "Select"
        Me.Button_Select.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(559, 63)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(125, 23)
        Me.Button_Close.TabIndex = 2
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button_ChangeFont
        '
        Me.Button_ChangeFont.Location = New System.Drawing.Point(559, 113)
        Me.Button_ChangeFont.Name = "Button_ChangeFont"
        Me.Button_ChangeFont.Size = New System.Drawing.Size(125, 23)
        Me.Button_ChangeFont.TabIndex = 3
        Me.Button_ChangeFont.Text = "ChangeFont"
        Me.Button_ChangeFont.UseVisualStyleBackColor = True
        '
        'TextBox_ShowFontSize
        '
        Me.TextBox_ShowFontSize.Location = New System.Drawing.Point(559, 162)
        Me.TextBox_ShowFontSize.Multiline = True
        Me.TextBox_ShowFontSize.Name = "TextBox_ShowFontSize"
        Me.TextBox_ShowFontSize.Size = New System.Drawing.Size(125, 42)
        Me.TextBox_ShowFontSize.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 450)
        Me.Controls.Add(Me.TextBox_ShowFontSize)
        Me.Controls.Add(Me.Button_ChangeFont)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Select)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_Select As Button
    Friend WithEvents Button_Close As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button_ChangeFont As Button
    Friend WithEvents TextBox_ShowFontSize As TextBox
End Class
