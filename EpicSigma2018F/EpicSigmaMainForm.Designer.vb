<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EpicSigmaMainFrame
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
        Me.TableForResults = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableForESTemplates = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableForDXFExtractSets = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonTemplateDel = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.TableForResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableForESTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableForDXFExtractSets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableForResults
        '
        Me.TableForResults.AllowUserToAddRows = False
        Me.TableForResults.AllowUserToDeleteRows = False
        Me.TableForResults.AllowUserToResizeColumns = False
        Me.TableForResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TableForResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForResults.DefaultCellStyle = DataGridViewCellStyle1
        Me.TableForResults.Location = New System.Drawing.Point(415, 3)
        Me.TableForResults.Name = "TableForResults"
        Me.TableForResults.ReadOnly = True
        Me.TableForResults.RowHeadersVisible = False
        Me.TableForResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForResults.Size = New System.Drawing.Size(690, 374)
        Me.TableForResults.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Field_No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nr.p.k."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 54
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Field_Code"
        Me.Column3.HeaderText = "Kods"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 45
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Field_Name"
        Me.Column4.HeaderText = "Nosaukums"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 246
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Field_DescType"
        Me.Column5.HeaderText = "Tips"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 233
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Field_Units"
        Me.Column6.HeaderText = "Mērvien."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 51
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Field_Amount"
        Me.Column7.HeaderText = "Skaits"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 60
        '
        'TableForESTemplates
        '
        Me.TableForESTemplates.AllowUserToAddRows = False
        Me.TableForESTemplates.AllowUserToDeleteRows = False
        Me.TableForESTemplates.AllowUserToResizeColumns = False
        Me.TableForESTemplates.AllowUserToResizeRows = False
        Me.TableForESTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForESTemplates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForESTemplates.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableForESTemplates.Location = New System.Drawing.Point(209, 3)
        Me.TableForESTemplates.Name = "TableForESTemplates"
        Me.TableForESTemplates.ReadOnly = True
        Me.TableForESTemplates.RowHeadersVisible = False
        Me.TableForESTemplates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForESTemplates.Size = New System.Drawing.Size(200, 375)
        Me.TableForESTemplates.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TemplateName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'TableForDXFExtractSets
        '
        Me.TableForDXFExtractSets.AllowUserToAddRows = False
        Me.TableForDXFExtractSets.AllowUserToDeleteRows = False
        Me.TableForDXFExtractSets.AllowUserToResizeColumns = False
        Me.TableForDXFExtractSets.AllowUserToResizeRows = False
        Me.TableForDXFExtractSets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableForDXFExtractSets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableForDXFExtractSets.DefaultCellStyle = DataGridViewCellStyle3
        Me.TableForDXFExtractSets.Location = New System.Drawing.Point(3, 3)
        Me.TableForDXFExtractSets.Name = "TableForDXFExtractSets"
        Me.TableForDXFExtractSets.ReadOnly = True
        Me.TableForDXFExtractSets.RowHeadersVisible = False
        Me.TableForDXFExtractSets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableForDXFExtractSets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TableForDXFExtractSets.Size = New System.Drawing.Size(200, 374)
        Me.TableForDXFExtractSets.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "DXFItemSetName"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "DXFItemCount"
        Me.Column2.HeaderText = "Skaits"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "E"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 381)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "N"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(209, 381)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "N"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(662, 383)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Test edit from home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ButtonTemplateDel
        '
        Me.ButtonTemplateDel.Location = New System.Drawing.Point(277, 381)
        Me.ButtonTemplateDel.Name = "ButtonTemplateDel"
        Me.ButtonTemplateDel.Size = New System.Drawing.Size(32, 32)
        Me.ButtonTemplateDel.TabIndex = 20
        Me.ButtonTemplateDel.Text = "X"
        Me.ButtonTemplateDel.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(37, 381)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 32)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "X"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'EpicSigmaMainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 416)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ButtonTemplateDel)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableForResults)
        Me.Controls.Add(Me.TableForESTemplates)
        Me.Controls.Add(Me.TableForDXFExtractSets)
        Me.MaximizeBox = False
        Me.Name = "EpicSigmaMainFrame"
        Me.Text = "Epic Sigma 0.02a"
        CType(Me.TableForResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableForESTemplates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableForDXFExtractSets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableForResults As DataGridView
    Friend WithEvents TableForESTemplates As DataGridView
    Friend WithEvents TableForDXFExtractSets As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonTemplateDel As Button
    Friend WithEvents Button9 As Button
End Class
