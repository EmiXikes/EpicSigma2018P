<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CatFilterConditionEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxSection = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProp = New System.Windows.Forms.ComboBox()
        Me.TextBoxAttr = New System.Windows.Forms.TextBox()
        Me.ComboBoxOprt = New System.Windows.Forms.ComboBox()
        Me.TextBoxValue = New System.Windows.Forms.TextBox()
        Me.TextBoxConditionName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(188, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 21)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxSection
        '
        Me.ComboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSection.FormattingEnabled = True
        Me.ComboBoxSection.Location = New System.Drawing.Point(128, 39)
        Me.ComboBoxSection.Name = "ComboBoxSection"
        Me.ComboBoxSection.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxSection.TabIndex = 1
        '
        'ComboBoxProp
        '
        Me.ComboBoxProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProp.FormattingEnabled = True
        Me.ComboBoxProp.Location = New System.Drawing.Point(128, 66)
        Me.ComboBoxProp.Name = "ComboBoxProp"
        Me.ComboBoxProp.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxProp.TabIndex = 2
        '
        'TextBoxAttr
        '
        Me.TextBoxAttr.Location = New System.Drawing.Point(128, 66)
        Me.TextBoxAttr.Name = "TextBoxAttr"
        Me.TextBoxAttr.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxAttr.TabIndex = 2
        '
        'ComboBoxOprt
        '
        Me.ComboBoxOprt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxOprt.FormattingEnabled = True
        Me.ComboBoxOprt.Location = New System.Drawing.Point(128, 93)
        Me.ComboBoxOprt.Name = "ComboBoxOprt"
        Me.ComboBoxOprt.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxOprt.TabIndex = 3
        '
        'TextBoxValue
        '
        Me.TextBoxValue.Location = New System.Drawing.Point(128, 120)
        Me.TextBoxValue.Name = "TextBoxValue"
        Me.TextBoxValue.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxValue.TabIndex = 4
        '
        'TextBoxConditionName
        '
        Me.TextBoxConditionName.Location = New System.Drawing.Point(128, 12)
        Me.TextBoxConditionName.Name = "TextBoxConditionName"
        Me.TextBoxConditionName.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxConditionName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filtra nosaukums:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Parametru sadaļa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Parametrs / TAG:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pārbaudes operācija:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Salīdzināmā vērtība:"
        '
        'CatFilterConditionEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxConditionName)
        Me.Controls.Add(Me.TextBoxValue)
        Me.Controls.Add(Me.ComboBoxOprt)
        Me.Controls.Add(Me.TextBoxAttr)
        Me.Controls.Add(Me.ComboBoxProp)
        Me.Controls.Add(Me.ComboBoxSection)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Name = "CatFilterConditionEditor"
        Me.Text = "ConditionProperty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxSection As ComboBox
    Friend WithEvents ComboBoxProp As ComboBox
    Friend WithEvents TextBoxAttr As TextBox
    Friend WithEvents ComboBoxOprt As ComboBox
    Friend WithEvents TextBoxValue As TextBox
    Friend WithEvents TextBoxConditionName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
