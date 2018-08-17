Imports EpicSigma2018P.EpicSigma2018lib
Imports DEL_acadltlib_EM.FileIO

Public Class EpicSigmaTemplateEditor
    Dim GroupConditionList As New List(Of EpicSigmaGroupCondition)

    Dim GroupConditionListB As New BindingSource
    Dim SelectedCondition As New EpicSigmaGroupCondition

    Dim hasloaded As Boolean = False


    Private Sub ReloadConditionList()

        GroupConditionList = EpicSigmaMainFrame.CurrentSigma.ESTemplates(ESTemplateTable.CurrentCell.RowIndex).EpicSigma_GroupConditionCollection
        GroupConditionListB.DataSource = GroupConditionList
        GroupConditionTable.DataSource = GroupConditionListB
        GroupConditionListB.ResetBindings(True)

    End Sub

    Private Sub ReloadConditionControls()

        SelectedCondition = GroupConditionList(GroupConditionTable.CurrentCell.RowIndex)

        ConditionNameBox.Text = SelectedCondition.ConditionName
        ConSectionCBox.Text = SelectedCondition.Section

        If SelectedCondition.Section = "Attributes" Then
            PropNameBox.Text = SelectedCondition.Prop
        Else
            PropNameCBox.Text = SelectedCondition.Prop
        End If

        ConditionOP.Text = "="

        PropValueBox.Text = SelectedCondition.Value

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        EpicSigmaMainFrame.Label3.Text = "sfbksdfb"
    End Sub

    Private Sub EpicSigmaTemplateEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hasloaded = False

        EpicSigmaMainFrame.CurrentSigma.ReloadESTemplates()

        EpicSigmaMainFrame.CurrentSigma.ESTemplateTableBinding.DataSource = EpicSigmaMainFrame.CurrentSigma.ESTemplates
        ESTemplateTable.DataSource = EpicSigmaMainFrame.CurrentSigma.ESTemplateTableBinding

        ConSectionCBox.Items.Add("General")
        ConSectionCBox.Items.Add("Attributes")

        PropNameCBox.Items.Add("Color")
        PropNameCBox.Items.Add("Layer")

        ConditionOP.Items.Add("=")

        ReloadConditionList()
        ReloadConditionControls()

        hasloaded = True

    End Sub



    Private Sub ESTemplateTable_SelectionChanged(sender As Object, e As EventArgs) Handles ESTemplateTable.SelectionChanged

        ReloadConditionList()

    End Sub

    Private Sub GroupConditionTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GroupConditionTable.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim ttt As New EpicSigmaGroupCondition
        ttt.ConditionName = "fuck you"
        ttt.Section = ""
        ttt.Prop = ""
        ttt.Value = ""





        EpicSigmaMainFrame.CurrentSigma.ESTemplates(ESTemplateTable.CurrentCell.RowIndex).EpicSigma_GroupConditionCollection.Add(ttt)

        SaveObjToFile(EpicSigmaMainFrame.CurrentSigma.ESTemplates(ESTemplateTable.CurrentCell.RowIndex).TemplateSavePath, EpicSigmaMainFrame.CurrentSigma.ESTemplates(ESTemplateTable.CurrentCell.RowIndex), True)

        EpicSigmaMainFrame.CurrentSigma.ReloadESTemplates()
        ReloadConditionList()

    End Sub

    Private Sub GroupConditionTable_SelectionChanged(sender As Object, e As EventArgs) Handles GroupConditionTable.SelectionChanged
        ReloadConditionControls()
    End Sub

    Private Sub ResaveCondition()
        If hasloaded = False Then
            Exit Sub
        End If

        With EpicSigmaMainFrame.CurrentSigma.ESTemplates(ESTemplateTable.CurrentCell.RowIndex).EpicSigma_GroupConditionCollection(GroupConditionTable.CurrentCell.RowIndex)

            .ConditionName = ConditionNameBox.Text
            .Section = ConSectionCBox.Text

            If .Section = "Attributes" Then
                .Prop = PropNameBox.Text
            Else
                .Prop = PropNameCBox.Text
            End If

            .Value = PropValueBox.Text
        End With

        SaveObjToFile(EpicSigmaMainFrame.CurrentSigma.ESTemplates(ESTemplateTable.CurrentCell.RowIndex).TemplateSavePath, EpicSigmaMainFrame.CurrentSigma.ESTemplates(ESTemplateTable.CurrentCell.RowIndex), True)

        EpicSigmaMainFrame.CurrentSigma.ReloadESTemplates()
        ReloadConditionList()

    End Sub

    Private Sub ConSectionCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConSectionCBox.SelectedIndexChanged
        If ConSectionCBox.Text = "Attributes" Then
            PropNameBox.Visible = True
            PropNameCBox.Visible = False
        Else
            PropNameBox.Visible = False
            PropNameCBox.Visible = True
        End If
    End Sub

    Private Sub ConditionNameBox_TextChanged(sender As Object, e As EventArgs) Handles ConditionNameBox.TextChanged

    End Sub

    Private Sub PropNameBox_TextChanged(sender As Object, e As EventArgs) Handles PropNameBox.TextChanged

    End Sub

    Private Sub PropValueBox_TextChanged(sender As Object, e As EventArgs) Handles PropValueBox.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResaveCondition()
    End Sub
End Class