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
        Me.lable_title = New System.Windows.Forms.Label()
        Me.ComboBox_lang = New System.Windows.Forms.ComboBox()
        Me.Button_confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lable_title
        '
        Me.lable_title.AutoSize = True
        Me.lable_title.Location = New System.Drawing.Point(34, 33)
        Me.lable_title.Name = "lable_title"
        Me.lable_title.Size = New System.Drawing.Size(41, 15)
        Me.lable_title.TabIndex = 0
        Me.lable_title.Text = "Label1"
        '
        'ComboBox_lang
        '
        Me.ComboBox_lang.FormattingEnabled = True
        Me.ComboBox_lang.Location = New System.Drawing.Point(34, 51)
        Me.ComboBox_lang.Name = "ComboBox_lang"
        Me.ComboBox_lang.Size = New System.Drawing.Size(240, 23)
        Me.ComboBox_lang.TabIndex = 2
        '
        'Button_confirm
        '
        Me.Button_confirm.Location = New System.Drawing.Point(70, 179)
        Me.Button_confirm.Name = "Button_confirm"
        Me.Button_confirm.Size = New System.Drawing.Size(75, 23)
        Me.Button_confirm.TabIndex = 3
        Me.Button_confirm.Text = "Button1"
        Me.Button_confirm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 244)
        Me.Controls.Add(Me.Button_confirm)
        Me.Controls.Add(Me.ComboBox_lang)
        Me.Controls.Add(Me.lable_title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lable_title As Label
    Friend WithEvents ComboBox_lang As ComboBox
    Friend WithEvents Button_confirm As Button
End Class
