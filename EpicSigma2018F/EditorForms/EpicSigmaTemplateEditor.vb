Imports EpicSigma2018P.EpicSigmaTemplateDef
Imports EpicSigma2018P.EpicSigma2018lib
Imports DEL_acadltlib_EM.FileIO

Public Class EpicSigmaTemplateEditor

    Dim isLoadingLock As Boolean

    Dim Binding_Lst_SortCategories As New BindingSource
    Dim Binding_Lst_FilterConditions As New BindingSource

    Public Sub AddNewSortCategory(ByVal NewSortCat As SortCatDef)
        With EpicSigmaMainFrame.SigmaInst
            .ActiveTemplate.Lst_SortCategories.Add(NewSortCat)
            .ResaveActiveTemplate()
            .ReloadESTemplates()
        End With

        ReloadSortCategoryTable()
        ReloadCategoryFilterControls()

    End Sub
    Public Sub AddNewFilterCondition(ByVal NewCondition As ConditionDef)
        With EpicSigmaMainFrame.SigmaInst
            .ActiveTemplate.ActiveSortCategory.Lst_FilterConditions.Add(NewCondition)
            .ResaveActiveTemplate()
            .ReloadESTemplates()
            ReloadCategoryFilterConditionTable()

        End With
    End Sub

    Private Sub ReloadTemplateTable()
        With EpicSigmaMainFrame
            TableForESTemplatesED.DataSource = .Binding_ESTemplates
        End With
    End Sub
    Private Sub ReloadTemplateGeneralFields()
        ''TextBx_TemplateName.Text = EpicSigmaMainFrame.SigmaInst.ActiveTemplate.TemplateName
    End Sub
    Private Sub ReloadSortCategoryTable()
        With EpicSigmaMainFrame.SigmaInst
            Binding_Lst_SortCategories.DataSource = .ActiveTemplate.Lst_SortCategories
            TableForSortCategories.DataSource = Binding_Lst_SortCategories
            TableForTemplateEntries.DataSource = Binding_Lst_SortCategories
            Binding_Lst_SortCategories.ResetBindings(True)


        End With
    End Sub
    Private Sub ReloadCategoryFilterConditionTable()
        With EpicSigmaMainFrame.SigmaInst
            Binding_Lst_FilterConditions.DataSource = .ActiveTemplate.ActiveSortCategory.Lst_FilterConditions
            TableForCatFilterConditions.DataSource = Binding_Lst_FilterConditions
            Binding_Lst_FilterConditions.ResetBindings(True)
        End With
    End Sub
    Private Sub ReloadCategoryFilterControls()
        Dim DispText As String

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory.ActiveFilterCondition
            DispText = .ConditionName & Chr(10)
            DispText = DispText & "------------------" & Chr(10) & Chr(10)
            DispText = DispText & .Section & Chr(10)
            DispText = DispText & .Prop & Chr(10)
            DispText = DispText & .Oprtr & Chr(10)
            DispText = DispText & .Value & Chr(10)
        End With

        ButtonEditCatFilterCondition.Text = DispText

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory
            Button9.Text = .Field_Name.ManualText
        End With

    End Sub
    '' --------- LOAD AND SAVE -------------

    Private Sub EpicSigmaTemplateEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''DataGridView2.Rows.Add()

        TableForTemplateEntries.AutoGenerateColumns = False

        isLoadingLock = True
        EpicSigmaMainFrame.SigmaInst.ReloadESTemplates()
        ReloadTemplateTable()
        ReloadTemplateGeneralFields()
        ReloadSortCategoryTable()
        ReloadCategoryFilterConditionTable()
        ReloadCategoryFilterControls()

        ''TextBx_TemplateName.Text = EpicSigmaMainFrame.SigmaInst.ActiveTemplate.TemplateName

    End Sub


    Private Sub EpicSigmaTemplateEditor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        isLoadingLock = False
        EpicSigmaMainFrame.SigmaInst.ActiveTemplate = EpicSigmaMainFrame.SigmaInst.ESTemplates(TableForESTemplatesED.CurrentCell.RowIndex)

        With EpicSigmaMainFrame.SigmaInst
            If isLoadingLock = False And Not IsNothing(TableForSortCategories.CurrentCell) Then
                .ActiveTemplate.ActiveSortCategory = .ActiveTemplate.Lst_SortCategories(TableForSortCategories.CurrentCell.RowIndex)
            End If
        End With

        With EpicSigmaMainFrame.SigmaInst
            If isLoadingLock = False And Not IsNothing(TableForCatFilterConditions.CurrentCell) Then
                .ActiveTemplate.ActiveSortCategory.ActiveFilterCondition = .ActiveTemplate.ActiveSortCategory.Lst_FilterConditions(TableForCatFilterConditions.CurrentCell.RowIndex)

            End If
        End With

        ReloadTemplateTable()
        ReloadSortCategoryTable()
        ReloadCategoryFilterConditionTable()
        ReloadCategoryFilterControls()

    End Sub

    '' --------- SELECTION CHANGED PART -------------

    Private Sub TableForESTemplatesED_SelectionChanged(sender As Object, e As EventArgs) Handles TableForESTemplatesED.SelectionChanged
        With EpicSigmaMainFrame.SigmaInst
            If isLoadingLock = False Then
                .ActiveTemplate = .ESTemplates(TableForESTemplatesED.CurrentCell.RowIndex)
                ReloadTemplateGeneralFields()
                ReloadSortCategoryTable()
                ReloadCategoryFilterConditionTable()
                ReloadCategoryFilterControls()
            End If
        End With
    End Sub

    Private Sub TableForSortCategories_SelectionChanged(sender As Object, e As EventArgs) Handles TableForSortCategories.SelectionChanged
        With EpicSigmaMainFrame.SigmaInst
            If isLoadingLock = False And Not IsNothing(TableForSortCategories.CurrentCell) Then
                .ActiveTemplate.ActiveSortCategory = .ActiveTemplate.Lst_SortCategories(TableForSortCategories.CurrentCell.RowIndex)
                ReloadCategoryFilterConditionTable()
            End If
        End With
    End Sub
    Private Sub TableForCatFilterConditions_SelectionChanged(sender As Object, e As EventArgs) Handles TableForCatFilterConditions.SelectionChanged
        With EpicSigmaMainFrame.SigmaInst
            If isLoadingLock = False And Not IsNothing(TableForCatFilterConditions.CurrentCell) Then
                .ActiveTemplate.ActiveSortCategory.ActiveFilterCondition = .ActiveTemplate.ActiveSortCategory.Lst_FilterConditions(TableForCatFilterConditions.CurrentCell.RowIndex)
                ReloadCategoryFilterControls()
            End If
        End With
    End Sub


    '' --------- FILTER CONDITIONS ---------------

    Private Sub ButtonEditConditionSection_Click_1(sender As Object, e As EventArgs) Handles ButtonEditCatFilterCondition.Click

        Dim FilterEd As New CatFilterConditionEditor

        FilterEd.StartingtLocation = PointToScreen(sender.Location)
        FilterEd.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
        ReloadCategoryFilterConditionTable()

    End Sub





    ' ------------- OUTPUT FIELDS -----------------

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        'Dim EditOutputField As New ResultFieldEditor
        'EditOutputField.FieldDesignation = OutputField.ESigmaOutCathegory
        'EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        'EditOutputField.ShowDialog()
        'EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Dim EditOutputField As New ResultFieldEditor
        'EditOutputField.FieldDesignation = OutputField.ESigmaOutNo
        'EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        'EditOutputField.ShowDialog()
        'EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Dim EditOutputField As New ResultFieldEditor
        'EditOutputField.FieldDesignation = OutputField.ESigmaOutCode
        'EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        'EditOutputField.ShowDialog()
        'EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        With EpicSigmaMainFrame.SigmaInst
            .ActiveTemplate.ActiveSortCategory.FieldEdit = .ActiveTemplate.ActiveSortCategory.Field_Name

            Dim EditOutputField As New TemplateFieldEditor
            EditOutputField.ShowDialog()

            .ActiveTemplate.ActiveSortCategory.Field_Name = .ActiveTemplate.ActiveSortCategory.FieldEdit
            .ResaveActiveTemplate()
            .ReloadESTemplates()
        End With

        ReloadCategoryFilterControls()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Dim EditOutputField As New ResultFieldEditor
        'EditOutputField.FieldDesignation = OutputField.ESigmaOutType
        'EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        'EditOutputField.ShowDialog()
        'EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Dim EditOutputField As New ResultFieldEditor
        'EditOutputField.FieldDesignation = OutputField.ESigmaOutUnits
        'EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        'EditOutputField.ShowDialog()
        'EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Dim EditOutputField As New ResultFieldEditor
        'EditOutputField.FieldDesignation = OutputField.ESigmaOutCount
        'EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        'EditOutputField.ShowDialog()
        'EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub

    ' Other crap



    Private Sub GroupConditionTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableForCatFilterConditions.CellContentClick

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        AddNewFilterCondition(New ConditionDef With {
                              .ConditionName = "Jauns nosacījums",
                              .Section = "General",
                              .Prop = "Layer",
                              .Oprtr = "ir vienāds ar vērtību",
                              .Value = "0"})

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

        'AddNewGroupCondition(New ConditionDef With {
        '                     .ConditionName = "new NEO",
        '                     .Section = "Attributes",
        '                     .Prop = "SKAITS"})


    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub TableForGroupConditions_SelectionChanged(sender As Object, e As EventArgs)
        'If isLoadingLock = False Then
        '    EpicSigmaMainFrame.SigmaInst.ActiveGCondition = EpicSigmaMainFrame.SigmaInst.ActiveTemplate.Lst_GroupConditions(TableForGroupConditions.CurrentCell.RowIndex)
        '    TemplateEditorReloadControls()
        'End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        AddNewSortCategory(New SortCatDef With {
                           .CategoryDefName = "New Cat",
                           .Field_Name = New OutputFieldDef With {.ManualText = ""}
                           })
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ttsdt As New TemplateFieldEditor
        ttsdt.ShowDialog()
    End Sub

    Private Sub TextBx_TemplateName_TextChanged(sender As Object, e As EventArgs)

        With EpicSigmaMainFrame.SigmaInst
            ''.ActiveTemplate.TemplateName = TextBx_TemplateName.Text
            .ResaveActiveTemplate()
        End With

        ReloadTemplateTable()


    End Sub

    Private Sub TableForSortCategories_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TableForSortCategories.CellMouseDoubleClick
        Dim RenameBox As New TextInputBox
        RenameBox.RefMode = "C"
        RenameBox.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
        EpicSigmaMainFrame.SigmaInst.ReloadESTemplates()
        ReloadTemplateTable()
    End Sub

    Private Sub TableForESTemplatesED_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TableForESTemplatesED.CellMouseDoubleClick
        Dim RenameBox As New TextInputBox
        RenameBox.RefMode = "T"
        RenameBox.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
        EpicSigmaMainFrame.SigmaInst.ReloadESTemplates()
        ReloadTemplateTable()
    End Sub

    Private Sub TableForTemplateEntries_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles TableForTemplateEntries.CellPainting
        If TableForTemplateEntries.Columns(e.ColumnIndex).Name = "Edit" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.box_edit_45, CInt((e.CellBounds.Width / 2) - (My.Resources.box_edit_45.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.box_edit_45.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub TableForTemplateEntries_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableForTemplateEntries.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class