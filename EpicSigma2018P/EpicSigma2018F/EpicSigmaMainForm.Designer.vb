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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ResultSheetTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTemplateTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DXFExtractSetTable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.ResultSheetTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTemplateTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DXFExtractSetTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResultSheetTable
        '
        Me.ResultSheetTable.AllowUserToResizeColumns = False
        Me.ResultSheetTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ResultSheetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultSheetTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResultSheetTable.DefaultCellStyle = DataGridViewCellStyle10
        Me.ResultSheetTable.Location = New System.Drawing.Point(416, 20)
        Me.ResultSheetTable.Name = "ResultSheetTable"
        Me.ResultSheetTable.RowHeadersVisible = False
        Me.ResultSheetTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ResultSheetTable.Size = New System.Drawing.Size(690, 374)
        Me.ResultSheetTable.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nr.p.k."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 54
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kods"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 45
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nosaukums"
        Me.Column4.Name = "Column4"
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 246
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tips"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 233
        '
        'Column6
        '
        Me.Column6.HeaderText = "Mērvien."
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 51
        '
        'Column7
        '
        Me.Column7.HeaderText = "Skaits"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 60
        '
        'ESTemplateTable
        '
        Me.ESTemplateTable.AllowUserToAddRows = False
        Me.ESTemplateTable.AllowUserToDeleteRows = False
        Me.ESTemplateTable.AllowUserToResizeColumns = False
        Me.ESTemplateTable.AllowUserToResizeRows = False
        Me.ESTemplateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ESTemplateTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ESTemplateTable.DefaultCellStyle = DataGridViewCellStyle11
        Me.ESTemplateTable.Location = New System.Drawing.Point(210, 20)
        Me.ESTemplateTable.Name = "ESTemplateTable"
        Me.ESTemplateTable.ReadOnly = True
        Me.ESTemplateTable.RowHeadersVisible = False
        Me.ESTemplateTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ESTemplateTable.Size = New System.Drawing.Size(200, 374)
        Me.ESTemplateTable.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TemplateName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sagataves"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DXFExtractSetTable
        '
        Me.DXFExtractSetTable.AllowUserToAddRows = False
        Me.DXFExtractSetTable.AllowUserToDeleteRows = False
        Me.DXFExtractSetTable.AllowUserToResizeColumns = False
        Me.DXFExtractSetTable.AllowUserToResizeRows = False
        Me.DXFExtractSetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DXFExtractSetTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DXFExtractSetTable.DefaultCellStyle = DataGridViewCellStyle12
        Me.DXFExtractSetTable.Location = New System.Drawing.Point(4, 20)
        Me.DXFExtractSetTable.Name = "DXFExtractSetTable"
        Me.DXFExtractSetTable.ReadOnly = True
        Me.DXFExtractSetTable.RowHeadersVisible = False
        Me.DXFExtractSetTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DXFExtractSetTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DXFExtractSetTable.Size = New System.Drawing.Size(200, 374)
        Me.DXFExtractSetTable.TabIndex = 6
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
        Me.Button1.Location = New System.Drawing.Point(251, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "new set"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(114, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Load"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(210, 401)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "new template"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(663, 400)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Test validation"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EpicSigmaMainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 475)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ResultSheetTable)
        Me.Controls.Add(Me.ESTemplateTable)
        Me.Controls.Add(Me.DXFExtractSetTable)
        Me.Name = "EpicSigmaMainFrame"
        Me.Text = "Epic Sigma 0.02a"
        CType(Me.ResultSheetTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTemplateTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DXFExtractSetTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultSheetTable As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ESTemplateTable As DataGridView
    Friend WithEvents DXFExtractSetTable As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
End Class
