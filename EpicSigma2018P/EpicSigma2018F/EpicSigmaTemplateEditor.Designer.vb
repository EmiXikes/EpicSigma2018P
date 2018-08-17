<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EpicSigmaTemplateEditor
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ESTemplateTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupConditionTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConSectionCBox = New System.Windows.Forms.ComboBox()
        Me.ConditionNameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PropNameBox = New System.Windows.Forms.TextBox()
        Me.PropNameCBox = New System.Windows.Forms.ComboBox()
        Me.PropValueBox = New System.Windows.Forms.TextBox()
        Me.ConditionOP = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.ESTemplateTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GroupConditionTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ESTemplateTable
        '
        Me.ESTemplateTable.AllowUserToAddRows = False
        Me.ESTemplateTable.AllowUserToDeleteRows = False
        Me.ESTemplateTable.AllowUserToResizeColumns = False
        Me.ESTemplateTable.AllowUserToResizeRows = False
        Me.ESTemplateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ESTemplateTable.ColumnHeadersVisible = False
        Me.ESTemplateTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ESTemplateTable.DefaultCellStyle = DataGridViewCellStyle7
        Me.ESTemplateTable.Location = New System.Drawing.Point(9, 17)
        Me.ESTemplateTable.MultiSelect = False
        Me.ESTemplateTable.Name = "ESTemplateTable"
        Me.ESTemplateTable.ReadOnly = True
        Me.ESTemplateTable.RowHeadersVisible = False
        Me.ESTemplateTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ESTemplateTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ESTemplateTable.Size = New System.Drawing.Size(200, 350)
        Me.ESTemplateTable.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TemplateName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ESTemplateTable)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 407)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sagataves"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button14)
        Me.GroupBox4.Controls.Add(Me.Button12)
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Location = New System.Drawing.Point(228, 313)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(874, 96)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Izvade"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(6, 19)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(859, 23)
        Me.Button14.TabIndex = 0
        Me.Button14.Text = "Kategorija"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(800, 45)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(65, 42)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "Skaits"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(729, 45)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(65, 42)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "Vienības"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(437, 45)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(286, 42)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "Tips"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(145, 45)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(286, 42)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Nosaukums"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(75, 45)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(65, 42)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Kods"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 45)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(63, 42)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Nr.p.k."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupConditionTable
        '
        Me.GroupConditionTable.AllowUserToAddRows = False
        Me.GroupConditionTable.AllowUserToDeleteRows = False
        Me.GroupConditionTable.AllowUserToResizeColumns = False
        Me.GroupConditionTable.AllowUserToResizeRows = False
        Me.GroupConditionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GroupConditionTable.ColumnHeadersVisible = False
        Me.GroupConditionTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GroupConditionTable.DefaultCellStyle = DataGridViewCellStyle8
        Me.GroupConditionTable.Location = New System.Drawing.Point(9, 36)
        Me.GroupConditionTable.Name = "GroupConditionTable"
        Me.GroupConditionTable.ReadOnly = True
        Me.GroupConditionTable.RowHeadersVisible = False
        Me.GroupConditionTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GroupConditionTable.Size = New System.Drawing.Size(174, 228)
        Me.GroupConditionTable.TabIndex = 15
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ConditionName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.ConditionOP)
        Me.GroupBox2.Controls.Add(Me.PropValueBox)
        Me.GroupBox2.Controls.Add(Me.PropNameCBox)
        Me.GroupBox2.Controls.Add(Me.PropNameBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ConditionNameBox)
        Me.GroupBox2.Controls.Add(Me.ConSectionCBox)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupConditionTable)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(874, 305)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sagataves uzstādījumi"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Grupēšanas nosacījumi"
        '
        'ConSectionCBox
        '
        Me.ConSectionCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConSectionCBox.FormattingEnabled = True
        Me.ConSectionCBox.Location = New System.Drawing.Point(274, 68)
        Me.ConSectionCBox.Name = "ConSectionCBox"
        Me.ConSectionCBox.Size = New System.Drawing.Size(109, 21)
        Me.ConSectionCBox.TabIndex = 18
        '
        'ConditionNameBox
        '
        Me.ConditionNameBox.Location = New System.Drawing.Point(274, 33)
        Me.ConditionNameBox.Name = "ConditionNameBox"
        Me.ConditionNameBox.Size = New System.Drawing.Size(491, 20)
        Me.ConditionNameBox.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Con. name"
        '
        'PropNameBox
        '
        Me.PropNameBox.Location = New System.Drawing.Point(389, 69)
        Me.PropNameBox.Name = "PropNameBox"
        Me.PropNameBox.Size = New System.Drawing.Size(117, 20)
        Me.PropNameBox.TabIndex = 22
        '
        'PropNameCBox
        '
        Me.PropNameCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PropNameCBox.FormattingEnabled = True
        Me.PropNameCBox.Location = New System.Drawing.Point(389, 68)
        Me.PropNameCBox.Name = "PropNameCBox"
        Me.PropNameCBox.Size = New System.Drawing.Size(117, 21)
        Me.PropNameCBox.TabIndex = 24
        '
        'PropValueBox
        '
        Me.PropValueBox.Location = New System.Drawing.Point(642, 69)
        Me.PropValueBox.Name = "PropValueBox"
        Me.PropValueBox.Size = New System.Drawing.Size(123, 20)
        Me.PropValueBox.TabIndex = 26
        '
        'ConditionOP
        '
        Me.ConditionOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConditionOP.FormattingEnabled = True
        Me.ConditionOP.Location = New System.Drawing.Point(549, 68)
        Me.ConditionOP.Name = "ConditionOP"
        Me.ConditionOP.Size = New System.Drawing.Size(57, 21)
        Me.ConditionOP.TabIndex = 27
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(690, 241)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'EpicSigmaTemplateEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 419)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EpicSigmaTemplateEditor"
        Me.Text = "EpicSigmaTemplateEditor"
        CType(Me.ESTemplateTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GroupConditionTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ESTemplateTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupConditionTable As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ConSectionCBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ConditionNameBox As TextBox
    Friend WithEvents ConditionOP As ComboBox
    Friend WithEvents PropValueBox As TextBox
    Friend WithEvents PropNameCBox As ComboBox
    Friend WithEvents PropNameBox As TextBox
    Friend WithEvents Button4 As Button
End Class
