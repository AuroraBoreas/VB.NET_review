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
        Me.Button1_RunSub = New System.Windows.Forms.Button()
        Me.Button2_RunFunc = New System.Windows.Forms.Button()
        Me.TextBox1_Output = New System.Windows.Forms.TextBox()
        Me.TextBox1_A = New System.Windows.Forms.TextBox()
        Me.TextBox2_B = New System.Windows.Forms.TextBox()
        Me.TextBox3_Result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1_operator = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1_RunSub
        '
        Me.Button1_RunSub.Location = New System.Drawing.Point(31, 21)
        Me.Button1_RunSub.Name = "Button1_RunSub"
        Me.Button1_RunSub.Size = New System.Drawing.Size(75, 23)
        Me.Button1_RunSub.TabIndex = 0
        Me.Button1_RunSub.Text = "Run Sub"
        Me.Button1_RunSub.UseVisualStyleBackColor = True
        '
        'Button2_RunFunc
        '
        Me.Button2_RunFunc.Location = New System.Drawing.Point(31, 108)
        Me.Button2_RunFunc.Name = "Button2_RunFunc"
        Me.Button2_RunFunc.Size = New System.Drawing.Size(75, 23)
        Me.Button2_RunFunc.TabIndex = 1
        Me.Button2_RunFunc.Text = "Run Func"
        Me.Button2_RunFunc.UseVisualStyleBackColor = True
        '
        'TextBox1_Output
        '
        Me.TextBox1_Output.Location = New System.Drawing.Point(148, 21)
        Me.TextBox1_Output.Multiline = True
        Me.TextBox1_Output.Name = "TextBox1_Output"
        Me.TextBox1_Output.Size = New System.Drawing.Size(252, 109)
        Me.TextBox1_Output.TabIndex = 2
        '
        'TextBox1_A
        '
        Me.TextBox1_A.Location = New System.Drawing.Point(148, 180)
        Me.TextBox1_A.Name = "TextBox1_A"
        Me.TextBox1_A.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1_A.TabIndex = 3
        '
        'TextBox2_B
        '
        Me.TextBox2_B.Location = New System.Drawing.Point(148, 223)
        Me.TextBox2_B.Name = "TextBox2_B"
        Me.TextBox2_B.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2_B.TabIndex = 4
        '
        'TextBox3_Result
        '
        Me.TextBox3_Result.Location = New System.Drawing.Point(148, 266)
        Me.TextBox3_Result.Name = "TextBox3_Result"
        Me.TextBox3_Result.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3_Result.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "="
        '
        'ComboBox1_operator
        '
        Me.ComboBox1_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1_operator.FormattingEnabled = True
        Me.ComboBox1_operator.Items.AddRange(New Object() {"+", "-", "*", "/", "^"})
        Me.ComboBox1_operator.Location = New System.Drawing.Point(98, 201)
        Me.ComboBox1_operator.Name = "ComboBox1_operator"
        Me.ComboBox1_operator.Size = New System.Drawing.Size(44, 22)
        Me.ComboBox1_operator.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(421, 340)
        Me.Controls.Add(Me.ComboBox1_operator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3_Result)
        Me.Controls.Add(Me.TextBox2_B)
        Me.Controls.Add(Me.TextBox1_A)
        Me.Controls.Add(Me.TextBox1_Output)
        Me.Controls.Add(Me.Button2_RunFunc)
        Me.Controls.Add(Me.Button1_RunSub)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1_RunSub As Button
    Friend WithEvents Button2_RunFunc As Button
    Friend WithEvents TextBox1_Output As TextBox
    Friend WithEvents TextBox1_A As TextBox
    Friend WithEvents TextBox2_B As TextBox
    Friend WithEvents TextBox3_Result As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1_operator As ComboBox
End Class
