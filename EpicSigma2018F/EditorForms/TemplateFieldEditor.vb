Imports EpicSigma2018P.EpicSigmaTemplateDef
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class TemplateFieldEditor
    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged


    Dim hasLoaded As Boolean

    Private _FEditType As OutputFieldType
    Property FEditType As OutputFieldType

        Get
            Return _FEditType
        End Get

        Set(value As OutputFieldType)
            _FEditType = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("FEditType"))
            With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory
                Select Case value
                    Case OutputFieldType.FieldTypeNumbering
                        .FieldEdit.FieldType = OutputFieldType.FieldTypeNumbering
                        RB_Sel_Numbering.Checked = True
                    Case OutputFieldType.FieldTypeManualText
                        .FieldEdit.FieldType = OutputFieldType.FieldTypeManualText
                        RB_Sel_ManualText.Checked = True
                    Case OutputFieldType.FieldTypeAttributeValue
                        .FieldEdit.FieldType = OutputFieldType.FieldTypeAttributeValue
                        RB_Sel_Attr.Checked = True
                    Case OutputFieldType.FieldTypeItemCount
                        .FieldEdit.FieldType = OutputFieldType.FieldTypeItemCount
                        RB_Sel_Count.Checked = True
                    Case OutputFieldType.FieldTypeAttributeSum
                        .FieldEdit.FieldType = OutputFieldType.FieldTypeAttributeSum
                        RB_Sel_Sum.Checked = True
                End Select
            End With
        End Set
    End Property

    Private Sub TemplateFieldEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hasLoaded = False

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory

            FEditType = .FieldEdit.FieldType

            Label4.DataBindings.Add(New Binding("Text", Me, "FEditType"))

            CB_Numbering.DataBindings.Add(New Binding("Checked", .FieldEdit, "Num_Show"))
            RB_NumT1.DataBindings.Add(New Binding("Checked", .FieldEdit, "Num_Tier01"))
            RB_NumT2.DataBindings.Add(New Binding("Checked", .FieldEdit, "Num_Tier02"))
            RB_NumT3.DataBindings.Add(New Binding("Checked", .FieldEdit, "Num_Tier03"))
            RB_NumT4.DataBindings.Add(New Binding("Checked", .FieldEdit, "Num_Tier04"))

            RTB_ManualText.DataBindings.Add(New Binding("Text", .FieldEdit, "ManualText"))

            RTB_AttrTAG.DataBindings.Add(New Binding("Text", .FieldEdit, "AttributeTag"))
            TB_AttrFind.DataBindings.Add(New Binding("Text", .FieldEdit, "Attribute_ValueFind"))
            TB_AttrReplace.DataBindings.Add(New Binding("Text", .FieldEdit, "Attribute_ValueReplace"))
            CB_AttrMultiline.DataBindings.Add(New Binding("Checked", .FieldEdit, "Attribute_isMultiline"))

            CB_CountMultiply.DataBindings.Add(New Binding("Checked", .FieldEdit, "Count_isMultiplicationModeEnabled"))
            TB_MultDef.DataBindings.Add(New Binding("Text", .FieldEdit, "Count_MultiplicatorDefaultForMissingValue"))
            RB_CountMultNumber.DataBindings.Add(New Binding("Checked", .FieldEdit, "Count_isMultiplicatorSourceCustomInt"))
            RB_CountMultTAG.DataBindings.Add(New Binding("Checked", .FieldEdit, "Count_isMultiplicatorSourceAttrValue"))
            TB_CountMultNumber.DataBindings.Add(New Binding("Text", .FieldEdit, "Count_MultiplicatorSourceCustomInt"))
            TB_CountMultTAG.DataBindings.Add(New Binding("Text", .FieldEdit, "Count_MultiplicatorSourceAttrTAG"))

            TB_SumDef.DataBindings.Add(New Binding("Text", .FieldEdit, "Sum_DefaultForMissingValue"))
            CB_SumAddSpare.DataBindings.Add(New Binding("Checked", .FieldEdit, "Sum_isAddSparePercentageEnabled"))
            CB_SumRound.DataBindings.Add(New Binding("Checked", .FieldEdit, "Sum_isRoundValueEnabled"))
            TB_SumSparePercentage.DataBindings.Add(New Binding("Text", .FieldEdit, "Sum_SparePercentageValue"))
            ComboBox_RoundValue.DataBindings.Add(New Binding("Text", .FieldEdit, "Sum_RoundValue"))

        End With

        hasLoaded = True

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sel_Numbering.CheckedChanged
        If sender.checked = True Then
            If hasLoaded = True Then FEditType = OutputFieldType.FieldTypeNumbering
            GroupBox_NumberingOptions.Visible = True
            GroupBox_TextValueEntry.Visible = False
            GroupBox_AttributeOptions.Visible = False
            GroupBox_CountOptions.Visible = False
            GroupBox_SumOptions.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sel_ManualText.CheckedChanged
        If sender.checked = True Then
            If hasLoaded = True Then FEditType = OutputFieldType.FieldTypeManualText
            GroupBox_NumberingOptions.Visible = False
            GroupBox_TextValueEntry.Visible = True
            GroupBox_AttributeOptions.Visible = False
            GroupBox_CountOptions.Visible = False
            GroupBox_SumOptions.Visible = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sel_Attr.CheckedChanged
        If sender.checked = True Then
            If hasLoaded = True Then FEditType = OutputFieldType.FieldTypeAttributeValue
            GroupBox_NumberingOptions.Visible = False
            GroupBox_TextValueEntry.Visible = False
            GroupBox_AttributeOptions.Visible = True
            GroupBox_CountOptions.Visible = False
            GroupBox_SumOptions.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sel_Count.CheckedChanged
        If sender.checked = True Then
            If hasLoaded = True Then FEditType = OutputFieldType.FieldTypeItemCount
            GroupBox_NumberingOptions.Visible = False
            GroupBox_TextValueEntry.Visible = False
            GroupBox_AttributeOptions.Visible = False
            GroupBox_CountOptions.Visible = True
            GroupBox_SumOptions.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sel_Sum.CheckedChanged
        If sender.checked = True Then
            If hasLoaded = True Then FEditType = OutputFieldType.FieldTypeAttributeSum
            GroupBox_NumberingOptions.Visible = False
            GroupBox_TextValueEntry.Visible = False
            GroupBox_AttributeOptions.Visible = False
            GroupBox_CountOptions.Visible = False
            GroupBox_SumOptions.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' SaveClose()
        EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory.FieldEdit.FieldType = FEditType
        Me.Close()
    End Sub

    Private Sub SaveClose()
        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory

            .Field_Name.ManualText = RTB_ManualText.Text

        End With

        Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RTB_ManualText.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FEditType = OutputFieldType.FieldTypeAttributeValue

        'With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory

        '    .FieldEdit.FieldType = OutputFieldType.FieldTypeItemCount

        'End With
    End Sub

    Private Sub RB_MultDef1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class