<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultFieldEditor
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
        Me.RadioButton1_Text = New System.Windows.Forms.RadioButton()
        Me.RadioButton2_Attribute = New System.Windows.Forms.RadioButton()
        Me.RadioButton3_Count = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RadioButton1_Text
        '
        Me.RadioButton1_Text.AutoSize = True
        Me.RadioButton1_Text.Enabled = False
        Me.RadioButton1_Text.Location = New System.Drawing.Point(332, 37)
        Me.RadioButton1_Text.Name = "RadioButton1_Text"
        Me.RadioButton1_Text.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton1_Text.TabIndex = 0
        Me.RadioButton1_Text.TabStop = True
        Me.RadioButton1_Text.Text = "Text"
        Me.RadioButton1_Text.UseVisualStyleBackColor = True
        '
        'RadioButton2_Attribute
        '
        Me.RadioButton2_Attribute.AutoSize = True
        Me.RadioButton2_Attribute.Enabled = False
        Me.RadioButton2_Attribute.Location = New System.Drawing.Point(332, 60)
        Me.RadioButton2_Attribute.Name = "RadioButton2_Attribute"
        Me.RadioButton2_Attribute.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2_Attribute.TabIndex = 1
        Me.RadioButton2_Attribute.TabStop = True
        Me.RadioButton2_Attribute.Text = "Attribute"
        Me.RadioButton2_Attribute.UseVisualStyleBackColor = True
        '
        'RadioButton3_Count
        '
        Me.RadioButton3_Count.AutoSize = True
        Me.RadioButton3_Count.Enabled = False
        Me.RadioButton3_Count.Location = New System.Drawing.Point(332, 83)
        Me.RadioButton3_Count.Name = "RadioButton3_Count"
        Me.RadioButton3_Count.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton3_Count.TabIndex = 2
        Me.RadioButton3_Count.TabStop = True
        Me.RadioButton3_Count.Text = "Count"
        Me.RadioButton3_Count.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 209)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(103, 232)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(228, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(278, 54)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'ResultFieldEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 89)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton3_Count)
        Me.Controls.Add(Me.RadioButton2_Attribute)
        Me.Controls.Add(Me.RadioButton1_Text)
        Me.Name = "ResultFieldEditor"
        Me.Text = "ResultFieldEditor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton1_Text As RadioButton
    Friend WithEvents RadioButton2_Attribute As RadioButton
    Friend WithEvents RadioButton3_Count As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
