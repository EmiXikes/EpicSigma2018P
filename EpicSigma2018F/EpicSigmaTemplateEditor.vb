Imports EpicSigma2018P.EpicSigma2018lib
Imports DEL_acadltlib_EM.FileIO

Public Class EpicSigmaTemplateEditor

    '' --------- LOAD AND SAVE -------------

    Private Sub EpicSigmaTemplateEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EpicSigmaMainFrame.SigmaInst.ReloadESTemplates()
        ReloadTableLists()
        ReloadControls()

        ConditionOP.Items.Add("=")

    End Sub

    Private Sub ReloadTableLists()

        With EpicSigmaMainFrame.SigmaInst
            .BindingESTemplates.DataSource = .ESTemplates
            TableForESTemplates.DataSource = .BindingESTemplates
            ''.BindingESTemplates.ResetBindings(True)

            .BindingFilterCondition.DataSource = .ActiveTemplate.EpicSigma_FilterConditionCollection
            TableForFilterConditions.DataSource = .BindingFilterCondition
            .BindingFilterCondition.ResetBindings(True)

            .BindingGroupCondition.DataSource = .ActiveTemplate.EpicSigma_GroupConditionCollection
            TableForGroupConditions.DataSource = .BindingGroupCondition
            .BindingGroupCondition.ResetBindings(True)

            .BindingPostFilterAction.DataSource = .ActiveTemplate.EpicSigma_PostFilterActionCollection
            TableForPostFilterActions.DataSource = .BindingPostFilterAction
            .BindingPostFilterAction.ResetBindings(True)

            .BindingPostGroupAction.DataSource = .ActiveTemplate.EpicSigma_PostGroupActionCollection
            TableForPostGroupActions.DataSource = .BindingPostGroupAction
            .BindingPostGroupAction.ResetBindings(True)
        End With

    End Sub

    Private Sub ReloadControls()

        With EpicSigmaMainFrame.SigmaInst
            .ActiveCondition = .ActiveTemplate.EpicSigma_FilterConditionCollection(TableForFilterConditions.CurrentCell.RowIndex)

            Button1.Text = .ActiveCondition.Section & " :: " & .ActiveCondition.Prop
            Button6.Text = .ActiveCondition.Value

            ConditionNameBox.Text = .ActiveCondition.ConditionName

        End With

        ConditionOP.Text = "="
    End Sub


    '' New item genereation

    Private Sub AddNewFilterCondition(ByVal NewCondition As EpicSigmaCondition)
        EpicSigmaMainFrame.SigmaInst.AddNewFilterCondition(NewCondition)
        ReloadTableLists()
        ReloadControls()
    End Sub

    Private Sub AddNewGroupCondition(ByVal NewCondition As EpicSigmaCondition)
        EpicSigmaMainFrame.SigmaInst.AddNewGroupCondition(NewCondition)
        ReloadTableLists()
        ReloadControls()
    End Sub

    Private Sub AddNewPostFilterAction(ByVal NewAction As PostProcessAction)
        EpicSigmaMainFrame.SigmaInst.AddNewPostFilterAction(NewAction)
        ReloadTableLists()
        ReloadControls()
    End Sub

    Private Sub AddNewPostGroupAction(ByVal NewAction As PostProcessAction)
        EpicSigmaMainFrame.SigmaInst.AddNewPostGroupAction(NewAction)
        ReloadTableLists()
        ReloadControls()
    End Sub


    '' --------- SELECTION CHANGED PART -------------

    Private Sub ESTemplateTable_SelectionChanged(sender As Object, e As EventArgs) Handles TableForESTemplates.SelectionChanged
        ReloadTableLists()
        ReloadControls()
    End Sub
    Private Sub GroupConditionTable_SelectionChanged(sender As Object, e As EventArgs) Handles TableForFilterConditions.SelectionChanged
        ReloadControls()
    End Sub


    '' --------- FILTER CONDITIONS ---------------

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CondPropDialog As New ConditionPropertyDialog

        CondPropDialog.ShowDialog()

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.EpicSigma_FilterConditionCollection(TableForFilterConditions.CurrentCell.RowIndex)

            .ConditionName = ConditionNameBox.Text
            .Section = GlobalVar.GlobalVar.SectionName
            .Prop = GlobalVar.GlobalVar.PropName

        End With

        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
        ReloadControls()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim EditValue As New ValueEntryDialog
        EditValue.ShowDialog()

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.EpicSigma_FilterConditionCollection(TableForFilterConditions.CurrentCell.RowIndex)

            .ConditionName = ConditionNameBox.Text
            .Value = GlobalVar.GlobalVar.ConditionValue

        End With

        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
        ReloadControls()
    End Sub


    ' ------------- OUTPUT FIELDS -----------------

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim EditOutputField As New ResultFieldEditor
        EditOutputField.FieldDesignation = OutputField.ESigmaOutCathegory
        EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        EditOutputField.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim EditOutputField As New ResultFieldEditor
        EditOutputField.FieldDesignation = OutputField.ESigmaOutNo
        EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        EditOutputField.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim EditOutputField As New ResultFieldEditor
        EditOutputField.FieldDesignation = OutputField.ESigmaOutCode
        EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        EditOutputField.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim EditOutputField As New ResultFieldEditor
        EditOutputField.FieldDesignation = OutputField.ESigmaOutName
        EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        EditOutputField.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim EditOutputField As New ResultFieldEditor
        EditOutputField.FieldDesignation = OutputField.ESigmaOutType
        EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        EditOutputField.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim EditOutputField As New ResultFieldEditor
        EditOutputField.FieldDesignation = OutputField.ESigmaOutUnits
        EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        EditOutputField.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim EditOutputField As New ResultFieldEditor
        EditOutputField.FieldDesignation = OutputField.ESigmaOutCount
        EditOutputField.SelectedTemplateID = TableForESTemplates.CurrentCell.RowIndex
        EditOutputField.ShowDialog()
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub

    ' Other crap

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub ConSectionCBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConditionNameBox_TextChanged(sender As Object, e As EventArgs) Handles ConditionNameBox.TextChanged

    End Sub

    Private Sub PropNameBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PropValueBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EpicSigmaMainFrame.SigmaInst.ResaveActiveTemplate()
    End Sub

    Private Sub GroupConditionTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableForFilterConditions.CellContentClick

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        EpicSigmaMainFrame.Label3.Text = "sfbksdfb"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        AddNewFilterCondition(New EpicSigmaCondition With {
                              .ConditionName = "NeoCondition",
                              .Section = "General",
                              .Prop = "Layer",
                              .Value = "0"})

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        AddNewGroupCondition(New EpicSigmaCondition With {
                             .GroupReultType = GroupType.COUNT,
                             .ConditionName = "new NEO",
                             .Section = "Attributes",
                             .Prop = "SKAITS"})


    End Sub




End Class