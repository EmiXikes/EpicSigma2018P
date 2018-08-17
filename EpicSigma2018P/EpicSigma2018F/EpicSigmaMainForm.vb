Imports EpicSigma2018P.EpicSigma2018lib
Imports DEL_acadltlib_EM
Imports DEL_acadltlib_EM.CAD_attextract
Imports DEL_acadltlib_EM.DXF
Imports DEL_acadltlib_EM.FileIO
Imports System.IO

Public Class EpicSigmaMainFrame

    Public Shared CurrentSigma As New EpicSigmaInstance
    Dim hasLoaded As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TemplateEditor As New EpicSigmaTemplateEditor
        TemplateEditor.ShowDialog()
    End Sub

    Private Sub TableTemplates_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ESTemplateTable.CellContentClick

    End Sub

    Sub Recalculate()
        Dim SelectedIndexes As New List(Of Integer)

        If hasLoaded = False Then Exit Sub

        For Each TRow In DXFExtractSetTable.SelectedRows
            SelectedIndexes.Add(TRow.Index)
        Next
        Label3.Text = CurrentSigma.ValidateItems(CurrentSigma.GetSelectedDxfExtractItems(SelectedIndexes), ESTemplateTable.CurrentCell.RowIndex).Count
    End Sub


    Private Sub TableCountResults_SelectionChanged(sender As Object, e As EventArgs) Handles DXFExtractSetTable.SelectionChanged
        Recalculate()
    End Sub
    Private Sub TableTemplates_SelectionChanged(sender As Object, e As EventArgs) Handles ESTemplateTable.SelectionChanged
        Recalculate()
    End Sub

    Dim FilePath As String = "C:\Epic\zzTsave.fud"
    Dim FF As New FileInfo("FF")
    Dim nn As Integer = 0
    Dim tsavelist As List(Of CAD_attextract.DXFExtItemRef)
    ''Dim DXFExtractTableBinding As New BindingSource
    ''Dim ESTemplateTableBinding As New BindingSource

    Dim New_DXFExtractSet As New DXFExtractSet

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FilePath = FileExistIncrementer(Path.Combine({CurrentSigma.CurrentProjectpath, "ExtractSets", "Jauns Skaitījums.gy"}))

        DDE.initDDE()

        New_DXFExtractSet = New DXFExtractSet
        New_DXFExtractSet.DXFItemList = New List(Of DXFExtItemRef)
        New_DXFExtractSet.DXFItemList = ReadBlockAttributesFromDXFExtractFile(Export2DXF_Selected())
        New_DXFExtractSet.DXFItemSetName = Path.GetFileName(FilePath)
        New_DXFExtractSet.DXFItemSetFilePath = FilePath
        New_DXFExtractSet.DXFItemCount = New_DXFExtractSet.DXFItemList.Count

        FilePath = SaveObjToFile(FilePath, New_DXFExtractSet)

        DDE.CloseDDE()

        CurrentSigma.ReloadDXFSets()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ReadFP As String = CurrentSigma.DXFExtractSets(DXFExtractSetTable.CurrentCell.RowIndex).DXFItemSetFilePath

        New_DXFExtractSet = LoadObjFromFile(Of DXFExtractSet)(ReadFP)

        For Each t In New_DXFExtractSet.DXFItemList
            MsgBox(t.Attributes(0).Value)
        Next


    End Sub

    Private Sub EpicSigmaMainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hasLoaded = False


        CurrentSigma.ReloadDXFSets()
        CurrentSigma.ReloadESTemplates()

        CurrentSigma.DXFExtractTableBinding.DataSource = CurrentSigma.DXFExtractSets
        DXFExtractSetTable.DataSource = CurrentSigma.DXFExtractTableBinding

        CurrentSigma.ESTemplateTableBinding.DataSource = CurrentSigma.ESTemplates
        ESTemplateTable.DataSource = CurrentSigma.ESTemplateTableBinding

        hasLoaded = True

    End Sub

    Private Sub TableCountResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DXFExtractSetTable.CellContentClick

    End Sub



    Public Shared PassString As String

    Private Sub TableCountResults_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DXFExtractSetTable.CellContentDoubleClick

        RenameSelected_DXFExtractSet()

    End Sub

    Private Sub RenameSelected_DXFExtractSet()
        ' Upon d-click, read the associated saved file, read the name, display rename-form with the name, resave the new name to the save file and reload the bindings/table
        Dim RenameBox As New TextInputBox
        Dim LoadedObj As New DXFExtractSet
        Dim LoadedFilePath As String = CurrentSigma.DXFExtractSets(DXFExtractSetTable.CurrentCell.RowIndex).DXFItemSetFilePath
        LoadedObj = LoadObjFromFile(Of DXFExtractSet)(LoadedFilePath)
        PassString = LoadedObj.DXFItemSetName
        RenameBox.TextBox1.Text = PassString
        RenameBox.ShowDialog()
        LoadedObj.DXFItemSetName = PassString
        SaveObjToFile(LoadedFilePath, LoadedObj, True)
        CurrentSigma.ReloadDXFSets()
        ''CurrentSigma.DXFExtractTableBinding.ResetBindings(True)
    End Sub

    Private Sub DXFExtractSetTable_KeyUp(sender As Object, e As KeyEventArgs) Handles DXFExtractSetTable.KeyUp
        If e.KeyCode = Keys.Delete Then
            DeleteSelected_DXFExtractSet()
        End If
    End Sub

    Private Sub DeleteSelected_DXFExtractSet()
        'TODO Generate the delete routine
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FilePath = FileExistIncrementer(Path.Combine({CurrentSigma.CurrentProjectpath, "Templates", "GrnadTest.esT"}))

        Dim New_Template As New ESTemplate
        New_Template.TemplateName = "GrandTest2"

        New_Template.EpicSigma_GroupConditionCollection = New List(Of EpicSigmaGroupCondition)
        New_Template.EpicSigma_GroupConditionCollection.Add(New EpicSigmaGroupCondition With {
                                                            .ConditionName = "TestCondition",
                                                            .Oprtr = GroupOperators.Equals,
                                                            .Section = GroupSections.Attributes,
                                                            .Prop = "REFNAME",
                                                            .Value = "AS detektors"})

        New_Template.EpicSigma_GroupConditionCollection.Add(New EpicSigmaGroupCondition With {
                                                            .ConditionName = "TestCondition",
                                                            .Oprtr = GroupOperators.Equals,
                                                            .Section = GroupSections.General,
                                                            .Prop = "Layer",
                                                            .Value = "ESS-AS_Detektori"})

        New_Template.EpicSigma_OutputEntries = New List(Of OutputEntryTextField)
        New_Template.EpicSigma_OutputEntries.Add(New OutputEntryTextField With {
                                                 .ESigmaOutFieldType = OutputField.ESigmaOutName,
                                                 .ManualTextField = "AS Detektors Gratz"})
        New_Template.EpicSigma_OutputEntries.Add(New OutputEntryTextField With {
                                                 .ESigmaOutFieldType = OutputField.ESigmaOutCount,
                                                 .ItemCount = ""})

        New_Template.TemplateSavePath = FileExistIncrementer(FilePath)

        FilePath = SaveObjToFile(FilePath, New_Template)

        CurrentSigma.ReloadESTemplates()

        ''ESTemplateTableBinding.ResetBindings(True)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim SelectedIndexes As New List(Of Integer)

        For Each TRow In DXFExtractSetTable.SelectedRows
            SelectedIndexes.Add(TRow.Index)
        Next

        MsgBox(CurrentSigma.ValidateItems(CurrentSigma.GetSelectedDxfExtractItems(SelectedIndexes), ESTemplateTable.CurrentCell.RowIndex).Count)

    End Sub

    Private Sub EpicSigmaMainFrame_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        hasLoaded = True
    End Sub
End Class
