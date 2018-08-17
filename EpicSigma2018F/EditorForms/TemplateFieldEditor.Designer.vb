<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateFieldEditor
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
        Me.RB_Sel_ManualText = New System.Windows.Forms.RadioButton()
        Me.RB_Sel_Attr = New System.Windows.Forms.RadioButton()
        Me.RB_Sel_Count = New System.Windows.Forms.RadioButton()
        Me.RB_Sel_Sum = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RTB_ManualText = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_Sel_Numbering = New System.Windows.Forms.RadioButton()
        Me.GroupBox_TextValueEntry = New System.Windows.Forms.GroupBox()
        Me.GroupBox_SumOptions = New System.Windows.Forms.GroupBox()
        Me.TB_SumDef = New System.Windows.Forms.TextBox()
        Me.ComboBox_RoundValue = New System.Windows.Forms.ComboBox()
        Me.TB_SumSparePercentage = New System.Windows.Forms.TextBox()
        Me.CB_SumRound = New System.Windows.Forms.CheckBox()
        Me.CB_SumAddSpare = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_CountOptions = New System.Windows.Forms.GroupBox()
        Me.TB_MultDef = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RB_CountMultNumber = New System.Windows.Forms.RadioButton()
        Me.RB_CountMultTAG = New System.Windows.Forms.RadioButton()
        Me.TB_CountMultTAG = New System.Windows.Forms.TextBox()
        Me.TB_CountMultNumber = New System.Windows.Forms.TextBox()
        Me.CB_CountMultiply = New System.Windows.Forms.CheckBox()
        Me.GroupBox_AttributeOptions = New System.Windows.Forms.GroupBox()
        Me.CB_AttrMultiline = New System.Windows.Forms.CheckBox()
        Me.TB_AttrReplace = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_AttrFind = New System.Windows.Forms.TextBox()
        Me.RB_NumT1 = New System.Windows.Forms.RadioButton()
        Me.RB_NumT2 = New System.Windows.Forms.RadioButton()
        Me.RB_NumT3 = New System.Windows.Forms.RadioButton()
        Me.RB_NumT4 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Numbering = New System.Windows.Forms.CheckBox()
        Me.GroupBox_NumberingOptions = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RTB_AttrTAG = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RTB_SumAtrTag = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_TextValueEntry.SuspendLayout()
        Me.GroupBox_SumOptions.SuspendLayout()
        Me.GroupBox_CountOptions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox_AttributeOptions.SuspendLayout()
        Me.GroupBox_NumberingOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'RB_Sel_ManualText
        '
        Me.RB_Sel_ManualText.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Sel_ManualText.Checked = True
        Me.RB_Sel_ManualText.Location = New System.Drawing.Point(112, 15)
        Me.RB_Sel_ManualText.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_Sel_ManualText.Name = "RB_Sel_ManualText"
        Me.RB_Sel_ManualText.Size = New System.Drawing.Size(104, 22)
        Me.RB_Sel_ManualText.TabIndex = 1
        Me.RB_Sel_ManualText.TabStop = True
        Me.RB_Sel_ManualText.Text = "Parasts teksts"
        Me.RB_Sel_ManualText.UseVisualStyleBackColor = True
        '
        'RB_Sel_Attr
        '
        Me.RB_Sel_Attr.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Sel_Attr.Location = New System.Drawing.Point(218, 15)
        Me.RB_Sel_Attr.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_Sel_Attr.Name = "RB_Sel_Attr"
        Me.RB_Sel_Attr.Size = New System.Drawing.Size(104, 22)
        Me.RB_Sel_Attr.TabIndex = 2
        Me.RB_Sel_Attr.Text = "No attribūta"
        Me.RB_Sel_Attr.UseVisualStyleBackColor = True
        '
        'RB_Sel_Count
        '
        Me.RB_Sel_Count.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Sel_Count.Location = New System.Drawing.Point(324, 15)
        Me.RB_Sel_Count.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_Sel_Count.Name = "RB_Sel_Count"
        Me.RB_Sel_Count.Size = New System.Drawing.Size(104, 22)
        Me.RB_Sel_Count.TabIndex = 3
        Me.RB_Sel_Count.Text = "Elementu skaits"
        Me.RB_Sel_Count.UseVisualStyleBackColor = True
        '
        'RB_Sel_Sum
        '
        Me.RB_Sel_Sum.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Sel_Sum.Location = New System.Drawing.Point(430, 15)
        Me.RB_Sel_Sum.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_Sel_Sum.Name = "RB_Sel_Sum"
        Me.RB_Sel_Sum.Size = New System.Drawing.Size(104, 22)
        Me.RB_Sel_Sum.TabIndex = 4
        Me.RB_Sel_Sum.Text = "Atribūtu summa"
        Me.RB_Sel_Sum.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(470, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RTB_ManualText
        '
        Me.RTB_ManualText.Location = New System.Drawing.Point(20, 39)
        Me.RTB_ManualText.Name = "RTB_ManualText"
        Me.RTB_ManualText.Size = New System.Drawing.Size(511, 69)
        Me.RTB_ManualText.TabIndex = 14
        Me.RTB_ManualText.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_Sel_Numbering)
        Me.GroupBox1.Controls.Add(Me.RB_Sel_ManualText)
        Me.GroupBox1.Controls.Add(Me.RB_Sel_Attr)
        Me.GroupBox1.Controls.Add(Me.RB_Sel_Count)
        Me.GroupBox1.Controls.Add(Me.RB_Sel_Sum)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 42)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veids:"
        '
        'RB_Sel_Numbering
        '
        Me.RB_Sel_Numbering.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Sel_Numbering.Location = New System.Drawing.Point(6, 15)
        Me.RB_Sel_Numbering.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_Sel_Numbering.Name = "RB_Sel_Numbering"
        Me.RB_Sel_Numbering.Size = New System.Drawing.Size(104, 22)
        Me.RB_Sel_Numbering.TabIndex = 5
        Me.RB_Sel_Numbering.Text = "Nummerācija"
        Me.RB_Sel_Numbering.UseVisualStyleBackColor = True
        '
        'GroupBox_TextValueEntry
        '
        Me.GroupBox_TextValueEntry.Controls.Add(Me.Label10)
        Me.GroupBox_TextValueEntry.Controls.Add(Me.RTB_ManualText)
        Me.GroupBox_TextValueEntry.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox_TextValueEntry.Name = "GroupBox_TextValueEntry"
        Me.GroupBox_TextValueEntry.Size = New System.Drawing.Size(542, 114)
        Me.GroupBox_TextValueEntry.TabIndex = 19
        Me.GroupBox_TextValueEntry.TabStop = False
        '
        'GroupBox_SumOptions
        '
        Me.GroupBox_SumOptions.Controls.Add(Me.Label7)
        Me.GroupBox_SumOptions.Controls.Add(Me.Label6)
        Me.GroupBox_SumOptions.Controls.Add(Me.RTB_SumAtrTag)
        Me.GroupBox_SumOptions.Controls.Add(Me.TB_SumDef)
        Me.GroupBox_SumOptions.Controls.Add(Me.ComboBox_RoundValue)
        Me.GroupBox_SumOptions.Controls.Add(Me.TB_SumSparePercentage)
        Me.GroupBox_SumOptions.Controls.Add(Me.CB_SumRound)
        Me.GroupBox_SumOptions.Controls.Add(Me.CB_SumAddSpare)
        Me.GroupBox_SumOptions.Controls.Add(Me.Label1)
        Me.GroupBox_SumOptions.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox_SumOptions.Name = "GroupBox_SumOptions"
        Me.GroupBox_SumOptions.Size = New System.Drawing.Size(542, 114)
        Me.GroupBox_SumOptions.TabIndex = 20
        Me.GroupBox_SumOptions.TabStop = False
        '
        'TB_SumDef
        '
        Me.TB_SumDef.Location = New System.Drawing.Point(459, 81)
        Me.TB_SumDef.Name = "TB_SumDef"
        Me.TB_SumDef.Size = New System.Drawing.Size(23, 20)
        Me.TB_SumDef.TabIndex = 25
        Me.TB_SumDef.Text = "1"
        '
        'ComboBox_RoundValue
        '
        Me.ComboBox_RoundValue.FormattingEnabled = True
        Me.ComboBox_RoundValue.Items.AddRange(New Object() {"10", "100", "1000", "10000"})
        Me.ComboBox_RoundValue.Location = New System.Drawing.Point(386, 54)
        Me.ComboBox_RoundValue.Name = "ComboBox_RoundValue"
        Me.ComboBox_RoundValue.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox_RoundValue.TabIndex = 22
        '
        'TB_SumSparePercentage
        '
        Me.TB_SumSparePercentage.Location = New System.Drawing.Point(386, 33)
        Me.TB_SumSparePercentage.Name = "TB_SumSparePercentage"
        Me.TB_SumSparePercentage.Size = New System.Drawing.Size(96, 20)
        Me.TB_SumSparePercentage.TabIndex = 25
        '
        'CB_SumRound
        '
        Me.CB_SumRound.AutoSize = True
        Me.CB_SumRound.Location = New System.Drawing.Point(290, 58)
        Me.CB_SumRound.Name = "CB_SumRound"
        Me.CB_SumRound.Size = New System.Drawing.Size(88, 17)
        Me.CB_SumRound.TabIndex = 26
        Me.CB_SumRound.Text = "Noapaļot līdz"
        Me.CB_SumRound.UseVisualStyleBackColor = True
        '
        'CB_SumAddSpare
        '
        Me.CB_SumAddSpare.AutoSize = True
        Me.CB_SumAddSpare.Location = New System.Drawing.Point(290, 36)
        Me.CB_SumAddSpare.Name = "CB_SumAddSpare"
        Me.CB_SumAddSpare.Size = New System.Drawing.Size(81, 17)
        Me.CB_SumAddSpare.TabIndex = 25
        Me.CB_SumAddSpare.Text = "Pievienot %"
        Me.CB_SumAddSpare.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Noklusējuma vērtība, gadīumā, ja " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "norādītais atribūts nesatur vērtību:"
        '
        'GroupBox_CountOptions
        '
        Me.GroupBox_CountOptions.Controls.Add(Me.Label8)
        Me.GroupBox_CountOptions.Controls.Add(Me.TB_MultDef)
        Me.GroupBox_CountOptions.Controls.Add(Me.Panel1)
        Me.GroupBox_CountOptions.Controls.Add(Me.CB_CountMultiply)
        Me.GroupBox_CountOptions.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox_CountOptions.Name = "GroupBox_CountOptions"
        Me.GroupBox_CountOptions.Size = New System.Drawing.Size(542, 114)
        Me.GroupBox_CountOptions.TabIndex = 21
        Me.GroupBox_CountOptions.TabStop = False
        '
        'TB_MultDef
        '
        Me.TB_MultDef.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_MultDef.Location = New System.Drawing.Point(266, 59)
        Me.TB_MultDef.Name = "TB_MultDef"
        Me.TB_MultDef.Size = New System.Drawing.Size(20, 13)
        Me.TB_MultDef.TabIndex = 24
        Me.TB_MultDef.Text = "1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RB_CountMultNumber)
        Me.Panel1.Controls.Add(Me.RB_CountMultTAG)
        Me.Panel1.Controls.Add(Me.TB_CountMultTAG)
        Me.Panel1.Controls.Add(Me.TB_CountMultNumber)
        Me.Panel1.Location = New System.Drawing.Point(20, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 54)
        Me.Panel1.TabIndex = 23
        '
        'RB_CountMultNumber
        '
        Me.RB_CountMultNumber.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_CountMultNumber.Checked = True
        Me.RB_CountMultNumber.Location = New System.Drawing.Point(4, 4)
        Me.RB_CountMultNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.RB_CountMultNumber.Name = "RB_CountMultNumber"
        Me.RB_CountMultNumber.Size = New System.Drawing.Size(59, 21)
        Me.RB_CountMultNumber.TabIndex = 22
        Me.RB_CountMultNumber.TabStop = True
        Me.RB_CountMultNumber.Text = "Skaitli:"
        Me.RB_CountMultNumber.UseVisualStyleBackColor = True
        '
        'RB_CountMultTAG
        '
        Me.RB_CountMultTAG.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_CountMultTAG.Location = New System.Drawing.Point(4, 25)
        Me.RB_CountMultTAG.Margin = New System.Windows.Forms.Padding(0)
        Me.RB_CountMultTAG.Name = "RB_CountMultTAG"
        Me.RB_CountMultTAG.Size = New System.Drawing.Size(59, 21)
        Me.RB_CountMultTAG.TabIndex = 23
        Me.RB_CountMultTAG.Text = "No TAG:"
        Me.RB_CountMultTAG.UseVisualStyleBackColor = True
        '
        'TB_CountMultTAG
        '
        Me.TB_CountMultTAG.Location = New System.Drawing.Point(65, 25)
        Me.TB_CountMultTAG.Name = "TB_CountMultTAG"
        Me.TB_CountMultTAG.Size = New System.Drawing.Size(55, 20)
        Me.TB_CountMultTAG.TabIndex = 24
        '
        'TB_CountMultNumber
        '
        Me.TB_CountMultNumber.Location = New System.Drawing.Point(65, 4)
        Me.TB_CountMultNumber.Name = "TB_CountMultNumber"
        Me.TB_CountMultNumber.Size = New System.Drawing.Size(55, 20)
        Me.TB_CountMultNumber.TabIndex = 5
        '
        'CB_CountMultiply
        '
        Me.CB_CountMultiply.AutoSize = True
        Me.CB_CountMultiply.Location = New System.Drawing.Point(20, 34)
        Me.CB_CountMultiply.Name = "CB_CountMultiply"
        Me.CB_CountMultiply.Size = New System.Drawing.Size(169, 17)
        Me.CB_CountMultiply.TabIndex = 3
        Me.CB_CountMultiply.Text = "Reizināt (Noklusējums:           )"
        Me.CB_CountMultiply.UseVisualStyleBackColor = True
        '
        'GroupBox_AttributeOptions
        '
        Me.GroupBox_AttributeOptions.Controls.Add(Me.Label9)
        Me.GroupBox_AttributeOptions.Controls.Add(Me.Label5)
        Me.GroupBox_AttributeOptions.Controls.Add(Me.RTB_AttrTAG)
        Me.GroupBox_AttributeOptions.Controls.Add(Me.CB_AttrMultiline)
        Me.GroupBox_AttributeOptions.Controls.Add(Me.Label2)
        Me.GroupBox_AttributeOptions.Controls.Add(Me.TB_AttrFind)
        Me.GroupBox_AttributeOptions.Controls.Add(Me.TB_AttrReplace)
        Me.GroupBox_AttributeOptions.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox_AttributeOptions.Name = "GroupBox_AttributeOptions"
        Me.GroupBox_AttributeOptions.Size = New System.Drawing.Size(542, 114)
        Me.GroupBox_AttributeOptions.TabIndex = 22
        Me.GroupBox_AttributeOptions.TabStop = False
        '
        'CB_AttrMultiline
        '
        Me.CB_AttrMultiline.AutoSize = True
        Me.CB_AttrMultiline.Location = New System.Drawing.Point(276, 88)
        Me.CB_AttrMultiline.Name = "CB_AttrMultiline"
        Me.CB_AttrMultiline.Size = New System.Drawing.Size(123, 17)
        Me.CB_AttrMultiline.TabIndex = 25
        Me.CB_AttrMultiline.Text = "Apvienot no multiline"
        Me.CB_AttrMultiline.UseVisualStyleBackColor = True
        '
        'TB_AttrReplace
        '
        Me.TB_AttrReplace.Location = New System.Drawing.Point(379, 62)
        Me.TB_AttrReplace.Name = "TB_AttrReplace"
        Me.TB_AttrReplace.Size = New System.Drawing.Size(97, 20)
        Me.TB_AttrReplace.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Atrast/aizvietot"
        '
        'TB_AttrFind
        '
        Me.TB_AttrFind.Location = New System.Drawing.Point(276, 62)
        Me.TB_AttrFind.Name = "TB_AttrFind"
        Me.TB_AttrFind.Size = New System.Drawing.Size(97, 20)
        Me.TB_AttrFind.TabIndex = 0
        '
        'RB_NumT1
        '
        Me.RB_NumT1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_NumT1.Checked = True
        Me.RB_NumT1.Location = New System.Drawing.Point(24, 75)
        Me.RB_NumT1.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_NumT1.Name = "RB_NumT1"
        Me.RB_NumT1.Size = New System.Drawing.Size(54, 24)
        Me.RB_NumT1.TabIndex = 23
        Me.RB_NumT1.TabStop = True
        Me.RB_NumT1.Text = "X"
        Me.RB_NumT1.UseVisualStyleBackColor = True
        '
        'RB_NumT2
        '
        Me.RB_NumT2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_NumT2.Location = New System.Drawing.Point(80, 75)
        Me.RB_NumT2.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_NumT2.Name = "RB_NumT2"
        Me.RB_NumT2.Size = New System.Drawing.Size(54, 24)
        Me.RB_NumT2.TabIndex = 24
        Me.RB_NumT2.Text = "X.X"
        Me.RB_NumT2.UseVisualStyleBackColor = True
        '
        'RB_NumT3
        '
        Me.RB_NumT3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_NumT3.Location = New System.Drawing.Point(136, 75)
        Me.RB_NumT3.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_NumT3.Name = "RB_NumT3"
        Me.RB_NumT3.Size = New System.Drawing.Size(54, 24)
        Me.RB_NumT3.TabIndex = 25
        Me.RB_NumT3.Text = "X.X.X"
        Me.RB_NumT3.UseVisualStyleBackColor = True
        '
        'RB_NumT4
        '
        Me.RB_NumT4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_NumT4.Location = New System.Drawing.Point(192, 75)
        Me.RB_NumT4.Margin = New System.Windows.Forms.Padding(1)
        Me.RB_NumT4.Name = "RB_NumT4"
        Me.RB_NumT4.Size = New System.Drawing.Size(54, 24)
        Me.RB_NumT4.TabIndex = 26
        Me.RB_NumT4.Text = "X.X.X.X"
        Me.RB_NumT4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Ieraksta nummerācijas pakāpe"
        '
        'CB_Numbering
        '
        Me.CB_Numbering.AutoSize = True
        Me.CB_Numbering.Location = New System.Drawing.Point(24, 41)
        Me.CB_Numbering.Name = "CB_Numbering"
        Me.CB_Numbering.Size = New System.Drawing.Size(114, 17)
        Me.CB_Numbering.TabIndex = 28
        Me.CB_Numbering.Text = "Rādīt nummerāciju"
        Me.CB_Numbering.UseVisualStyleBackColor = True
        '
        'GroupBox_NumberingOptions
        '
        Me.GroupBox_NumberingOptions.Controls.Add(Me.Label11)
        Me.GroupBox_NumberingOptions.Controls.Add(Me.ComboBox1)
        Me.GroupBox_NumberingOptions.Controls.Add(Me.CB_Numbering)
        Me.GroupBox_NumberingOptions.Controls.Add(Me.Label3)
        Me.GroupBox_NumberingOptions.Controls.Add(Me.RB_NumT1)
        Me.GroupBox_NumberingOptions.Controls.Add(Me.RB_NumT4)
        Me.GroupBox_NumberingOptions.Controls.Add(Me.RB_NumT2)
        Me.GroupBox_NumberingOptions.Controls.Add(Me.RB_NumT3)
        Me.GroupBox_NumberingOptions.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox_NumberingOptions.Name = "GroupBox_NumberingOptions"
        Me.GroupBox_NumberingOptions.Size = New System.Drawing.Size(542, 114)
        Me.GroupBox_NumberingOptions.TabIndex = 20
        Me.GroupBox_NumberingOptions.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"X", "X.X", "X.X.X", "X.X.X.X"})
        Me.ComboBox1.Location = New System.Drawing.Point(257, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(54, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'RTB_AttrTAG
        '
        Me.RTB_AttrTAG.Location = New System.Drawing.Point(20, 62)
        Me.RTB_AttrTAG.Name = "RTB_AttrTAG"
        Me.RTB_AttrTAG.Size = New System.Drawing.Size(238, 43)
        Me.RTB_AttrTAG.TabIndex = 14
        Me.RTB_AttrTAG.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(882, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(879, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Label4"
        '
        'RTB_SumAtrTag
        '
        Me.RTB_SumAtrTag.Location = New System.Drawing.Point(20, 52)
        Me.RTB_SumAtrTag.Name = "RTB_SumAtrTag"
        Me.RTB_SumAtrTag.Size = New System.Drawing.Size(237, 25)
        Me.RTB_SumAtrTag.TabIndex = 14
        Me.RTB_SumAtrTag.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Atribūta TAG, no kura ņemt vērtību"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Atribūta TAG, no kura ņemt summējamās vērtības"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(388, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Summēt visu atlasīto elementu atribūtos ierakstītās vērtības"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Iegūt atlasīto elementu skaitu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(278, 15)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Iegūt tekstu no atribūtā ierakstītās vērtības"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Manuāli ievadāms teksts"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Nummerācija"
        '
        'TemplateFieldEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 193)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox_NumberingOptions)
        Me.Controls.Add(Me.GroupBox_AttributeOptions)
        Me.Controls.Add(Me.GroupBox_CountOptions)
        Me.Controls.Add(Me.GroupBox_SumOptions)
        Me.Controls.Add(Me.GroupBox_TextValueEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TemplateFieldEditor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox_TextValueEntry.ResumeLayout(False)
        Me.GroupBox_TextValueEntry.PerformLayout()
        Me.GroupBox_SumOptions.ResumeLayout(False)
        Me.GroupBox_SumOptions.PerformLayout()
        Me.GroupBox_CountOptions.ResumeLayout(False)
        Me.GroupBox_CountOptions.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox_AttributeOptions.ResumeLayout(False)
        Me.GroupBox_AttributeOptions.PerformLayout()
        Me.GroupBox_NumberingOptions.ResumeLayout(False)
        Me.GroupBox_NumberingOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RB_Sel_ManualText As RadioButton
    Friend WithEvents RB_Sel_Attr As RadioButton
    Friend WithEvents RB_Sel_Count As RadioButton
    Friend WithEvents RB_Sel_Sum As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents RTB_ManualText As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox_TextValueEntry As GroupBox
    Friend WithEvents GroupBox_SumOptions As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox_CountOptions As GroupBox
    Friend WithEvents TB_CountMultTAG As TextBox
    Friend WithEvents CB_CountMultiply As CheckBox
    Friend WithEvents TB_CountMultNumber As TextBox
    Friend WithEvents RB_CountMultTAG As RadioButton
    Friend WithEvents RB_CountMultNumber As RadioButton
    Friend WithEvents ComboBox_RoundValue As ComboBox
    Friend WithEvents TB_SumSparePercentage As TextBox
    Friend WithEvents CB_SumRound As CheckBox
    Friend WithEvents CB_SumAddSpare As CheckBox
    Friend WithEvents GroupBox_AttributeOptions As GroupBox
    Friend WithEvents CB_AttrMultiline As CheckBox
    Friend WithEvents TB_AttrReplace As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_AttrFind As TextBox
    Friend WithEvents RB_Sel_Numbering As RadioButton
    Friend WithEvents RB_NumT1 As RadioButton
    Friend WithEvents CB_Numbering As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RB_NumT4 As RadioButton
    Friend WithEvents RB_NumT3 As RadioButton
    Friend WithEvents RB_NumT2 As RadioButton
    Friend WithEvents GroupBox_NumberingOptions As GroupBox
    Friend WithEvents RTB_AttrTAG As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_MultDef As TextBox
    Friend WithEvents TB_SumDef As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RTB_SumAtrTag As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
End Class
