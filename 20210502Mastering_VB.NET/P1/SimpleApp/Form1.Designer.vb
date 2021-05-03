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
        Me.Btn_Evaluate = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.label_lang = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Evaluate
        '
        Me.Btn_Evaluate.Location = New System.Drawing.Point(164, 134)
        Me.Btn_Evaluate.Name = "Btn_Evaluate"
        Me.Btn_Evaluate.Size = New System.Drawing.Size(75, 25)
        Me.Btn_Evaluate.TabIndex = 0
        Me.Btn_Evaluate.Text = "Button1"
        Me.Btn_Evaluate.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(34, 44)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(387, 55)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'label_lang
        '
        Me.label_lang.AutoSize = True
        Me.label_lang.Location = New System.Drawing.Point(34, 26)
        Me.label_lang.Name = "label_lang"
        Me.label_lang.Size = New System.Drawing.Size(41, 15)
        Me.label_lang.TabIndex = 2
        Me.label_lang.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 191)
        Me.Controls.Add(Me.label_lang)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Btn_Evaluate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Evaluate As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents label_lang As Label
End Class
