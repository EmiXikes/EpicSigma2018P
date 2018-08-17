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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableForESTemplates = New System.Windows.Forms.DataGridView()
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
        Me.TableForFilterConditions = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ConditionOP = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ConditionNameBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TableForGroupConditions = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableForPostFilterActions = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableForPostGroupActions = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TableForESTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TableForFilterConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TableForGroupConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TableForPostFilterActions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TableForPostGroupActions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableForESTemplates
        '
        Me.TableForESTemplates.AllowUserToAddRows = False
        Me.TableForESTemplates.AllowUserToDeleteRows = False
        Me.TableForESTemplates.AllowUserToResizeColumns = False
        Me.TableForESTemplates.AllowUserToResizeRows = False
        Me.TableForESTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForESTemplates.ColumnHeadersVisible = False
        Me.TableForESTemplates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForESTemplates.DefaultCellStyle = DataGridViewCellStyle1
        Me.TableForESTemplates.Location = New System.Drawing.Point(9, 17)
        Me.TableForESTemplates.MultiSelect = False
        Me.TableForESTemplates.Name = "TableForESTemplates"
        Me.TableForESTemplates.ReadOnly = True
        Me.TableForESTemplates.RowHeadersVisible = False
        Me.TableForESTemplates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForESTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TableForESTemplates.Size = New System.Drawing.Size(200, 463)
        Me.TableForESTemplates.TabIndex = 10
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
        Me.GroupBox1.Controls.Add(Me.TableForESTemplates)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 515)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sagataves"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 486)
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
        Me.GroupBox4.Location = New System.Drawing.Point(850, 31)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(595, 96)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Izvades skats"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(6, 19)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(581, 23)
        Me.Button14.TabIndex = 0
        Me.Button14.Text = "Kategorija"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(522, 45)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(65, 42)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "Skaits"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(451, 45)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(65, 42)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "Vienības"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(294, 45)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(151, 42)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "Tips"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(145, 45)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(143, 42)
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
        'TableForFilterConditions
        '
        Me.TableForFilterConditions.AllowUserToAddRows = False
        Me.TableForFilterConditions.AllowUserToDeleteRows = False
        Me.TableForFilterConditions.AllowUserToResizeColumns = False
        Me.TableForFilterConditions.AllowUserToResizeRows = False
        Me.TableForFilterConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForFilterConditions.ColumnHeadersVisible = False
        Me.TableForFilterConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForFilterConditions.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableForFilterConditions.Location = New System.Drawing.Point(10, 17)
        Me.TableForFilterConditions.Name = "TableForFilterConditions"
        Me.TableForFilterConditions.ReadOnly = True
        Me.TableForFilterConditions.RowHeadersVisible = False
        Me.TableForFilterConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForFilterConditions.Size = New System.Drawing.Size(142, 180)
        Me.TableForFilterConditions.TabIndex = 15
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ConditionName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Khaki
        Me.Button6.Location = New System.Drawing.Point(158, 131)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 37)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(221, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 37)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Khaki
        Me.Button1.Location = New System.Drawing.Point(158, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 37)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ConditionOP
        '
        Me.ConditionOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConditionOP.FormattingEnabled = True
        Me.ConditionOP.Location = New System.Drawing.Point(158, 88)
        Me.ConditionOP.Name = "ConditionOP"
        Me.ConditionOP.Size = New System.Drawing.Size(57, 21)
        Me.ConditionOP.TabIndex = 27
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(210, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ConditionNameBox
        '
        Me.ConditionNameBox.Location = New System.Drawing.Point(155, 17)
        Me.ConditionNameBox.Name = "ConditionNameBox"
        Me.ConditionNameBox.Size = New System.Drawing.Size(141, 20)
        Me.ConditionNameBox.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1298, 493)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Grupēšanas nosacījumi"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.ConditionNameBox)
        Me.GroupBox3.Controls.Add(Me.ConditionOP)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TableForFilterConditions)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(228, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 236)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrēšanas nosacījumi"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button13)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.ComboBox2)
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.TableForGroupConditions)
        Me.GroupBox5.Location = New System.Drawing.Point(228, 281)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(311, 236)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Grupēšanas nosacījumi"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(6, 208)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 31
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 32
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(158, 45)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox2.TabIndex = 31
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(158, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'TableForGroupConditions
        '
        Me.TableForGroupConditions.AllowUserToAddRows = False
        Me.TableForGroupConditions.AllowUserToDeleteRows = False
        Me.TableForGroupConditions.AllowUserToResizeColumns = False
        Me.TableForGroupConditions.AllowUserToResizeRows = False
        Me.TableForGroupConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForGroupConditions.ColumnHeadersVisible = False
        Me.TableForGroupConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForGroupConditions.DefaultCellStyle = DataGridViewCellStyle3
        Me.TableForGroupConditions.Location = New System.Drawing.Point(6, 19)
        Me.TableForGroupConditions.Name = "TableForGroupConditions"
        Me.TableForGroupConditions.ReadOnly = True
        Me.TableForGroupConditions.RowHeadersVisible = False
        Me.TableForGroupConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForGroupConditions.Size = New System.Drawing.Size(146, 178)
        Me.TableForGroupConditions.TabIndex = 29
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ConditionName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableForPostFilterActions)
        Me.GroupBox2.Location = New System.Drawing.Point(545, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 236)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Darbības pēc filtrēšanas"
        '
        'TableForPostFilterActions
        '
        Me.TableForPostFilterActions.AllowUserToAddRows = False
        Me.TableForPostFilterActions.AllowUserToDeleteRows = False
        Me.TableForPostFilterActions.AllowUserToResizeColumns = False
        Me.TableForPostFilterActions.AllowUserToResizeRows = False
        Me.TableForPostFilterActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForPostFilterActions.ColumnHeadersVisible = False
        Me.TableForPostFilterActions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForPostFilterActions.DefaultCellStyle = DataGridViewCellStyle4
        Me.TableForPostFilterActions.Location = New System.Drawing.Point(6, 17)
        Me.TableForPostFilterActions.Name = "TableForPostFilterActions"
        Me.TableForPostFilterActions.ReadOnly = True
        Me.TableForPostFilterActions.RowHeadersVisible = False
        Me.TableForPostFilterActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForPostFilterActions.Size = New System.Drawing.Size(146, 178)
        Me.TableForPostFilterActions.TabIndex = 30
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TableForPostGroupActions)
        Me.GroupBox6.Location = New System.Drawing.Point(545, 281)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(299, 236)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Darbības pēc grupēšanas"
        '
        'TableForPostGroupActions
        '
        Me.TableForPostGroupActions.AllowUserToAddRows = False
        Me.TableForPostGroupActions.AllowUserToDeleteRows = False
        Me.TableForPostGroupActions.AllowUserToResizeColumns = False
        Me.TableForPostGroupActions.AllowUserToResizeRows = False
        Me.TableForPostGroupActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForPostGroupActions.ColumnHeadersVisible = False
        Me.TableForPostGroupActions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForPostGroupActions.DefaultCellStyle = DataGridViewCellStyle5
        Me.TableForPostGroupActions.Location = New System.Drawing.Point(6, 19)
        Me.TableForPostGroupActions.Name = "TableForPostGroupActions"
        Me.TableForPostGroupActions.ReadOnly = True
        Me.TableForPostGroupActions.RowHeadersVisible = False
        Me.TableForPostGroupActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForPostGroupActions.Size = New System.Drawing.Size(146, 178)
        Me.TableForPostGroupActions.TabIndex = 30
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProcessActionName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProcessActionName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'EpicSigmaTemplateEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 524)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EpicSigmaTemplateEditor"
        Me.Text = "EpicSigmaTemplateEditor"
        CType(Me.TableForESTemplates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TableForFilterConditions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.TableForGroupConditions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TableForPostFilterActions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.TableForPostGroupActions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableForESTemplates As DataGridView
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
    Friend WithEvents TableForFilterConditions As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ConditionNameBox As TextBox
    Friend WithEvents ConditionOP As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableForGroupConditions As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableForPostFilterActions As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TableForPostGroupActions As DataGridView
    Friend WithEvents Button13 As Button
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
