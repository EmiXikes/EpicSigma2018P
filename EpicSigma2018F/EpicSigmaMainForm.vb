Imports EpicSigma2018P.EpicSigma2018lib
Imports EpicSigma2018P.EpicSigmaTemplateDef
Imports DEL_acadltlib_EM
Imports DEL_acadltlib_EM.CAD_attextract
Imports DEL_acadltlib_EM.DXF
Imports DEL_acadltlib_EM.FileIO
Imports System.IO


Public Class EpicSigmaMainFrame



    Public Shared SigmaInst As New EpicSigmaInstance

    Public Binding_DXFExtractSets As New BindingSource
    Public Binding_ESTemplates As New BindingSource
    Public Binding_ResultSheetEntries As New BindingSource

    Dim hasLoaded As Boolean

    Dim FilePath As String = "C:\Epic\zzTsave.fud"
    Dim FF As New FileInfo("FF")
    Dim nn As Integer = 0
    ''  Dim tsavelist As List(Of DXFExtItemRef)

    Dim New_DXFExtractSet As New DXFItemSet

    Public Sub ReloadDXFSetTable()
        SigmaInst.ReloadDXFSets()
        Binding_DXFExtractSets.DataSource = SigmaInst.DXFExtractSets
        TableForDXFExtractSets.DataSource = Binding_DXFExtractSets
        Binding_DXFExtractSets.ResetBindings(True)
    End Sub
    Public Sub ReloadTemplateTable()
        SigmaInst.ReloadESTemplates()
        Binding_ESTemplates.DataSource = SigmaInst.ESTemplates
        TableForESTemplates.DataSource = Binding_ESTemplates
        Binding_ESTemplates.ResetBindings(True)
    End Sub

    Public Sub ReloadResultTable()
        ''SigmaInst.ReloadESTemplates()
        Binding_ResultSheetEntries.DataSource = SigmaInst.ResultSheetEntries
        TableForResults.DataSource = Binding_ResultSheetEntries
        Binding_ResultSheetEntries.ResetBindings(True)
    End Sub



    '' -------------- load and save --------------

    Private Sub EpicSigmaMainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hasLoaded = False

        ReloadDXFSetTable()
        ReloadTemplateTable()

        hasLoaded = True

        If SigmaInst.ESTemplates.Count > 0 And SigmaInst.DXFExtractSets.Count > 0 Then
            SigmaInst.ActiveTemplate = SigmaInst.ESTemplates(TableForESTemplates.CurrentCell.RowIndex)
            Recalculate()
        End If

    End Sub

    Private Sub EpicSigmaMainFrame_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        hasLoaded = True
    End Sub


    '' ------------ DXF sets part --------------------

    ' add selected items from open autocad
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        hasLoaded = False

        FilePath = FileExistIncrementer(Path.Combine({SigmaInst.CurrentProjectpath, "ExtractSets", "Jauns Skaitījums.gy"}))

        DDE.initDDE()

        New_DXFExtractSet = New DXFItemSet
        New_DXFExtractSet.DXFItemList = New List(Of DXFExtItemRef)
        New_DXFExtractSet.DXFItemList = ReadBlockAttributesFromDXFExtractFile(Export2DXF_Selected())
        New_DXFExtractSet.DXFItemSetName = "New Set" ''Path.GetFileName(FilePath)
        New_DXFExtractSet.DXFItemSetFilePath = FilePath
        New_DXFExtractSet.DXFItemCount = New_DXFExtractSet.DXFItemList.Count

        FilePath = SaveObjToFile(FilePath, New_DXFExtractSet)

        DDE.CloseDDE()

        SigmaInst.ReloadDXFSets()
        ReloadDXFSetTable()

        hasLoaded = True

    End Sub

    Private Sub TableCountResults_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableForDXFExtractSets.CellContentDoubleClick
        ''RenameSelected_DXFExtractSet()


    End Sub
    Public Shared PassString As String
    'Private Sub RenameSelected_DXFExtractSet()
    '    ' Upon d-click, read the associated saved file, read the name, display rename-form with the name, resave the new name to the save file and reload the bindings/table
    '    Dim RenameBox As New TextInputBox
    '    Dim LoadedObj As New DXFItemSet
    '    Dim LoadedFilePath As String = SigmaInst.DXFExtractSets(TableForDXFExtractSets.CurrentCell.RowIndex).DXFItemSetFilePath
    '    LoadedObj = LoadObjFromFile(Of DXFItemSet)(LoadedFilePath)
    '    PassString = LoadedObj.DXFItemSetName
    '    RenameBox.TextBox1.Text = PassString
    '    RenameBox.ShowDialog()
    '    LoadedObj.DXFItemSetName = PassString
    '    SaveObjToFile(LoadedFilePath, LoadedObj, True)
    '    SigmaInst.ReloadDXFSets()
    '    ''CurrentSigma.DXFExtractTableBinding.ResetBindings(True)
    'End Sub

    Private Sub DXFExtractSetTable_KeyUp(sender As Object, e As KeyEventArgs) Handles TableForDXFExtractSets.KeyUp
        If e.KeyCode = Keys.Delete Then
            DeleteSelected_DXFExtractSet()
        End If
    End Sub

    Private Sub DeleteSelected_DXFExtractSet()
        'TODO Generate the delete routine
    End Sub


    '' ------------- Calculation -----------------------

    Sub Recalculate()

        If hasLoaded = False Then Exit Sub

        If Not IsNothing(SigmaInst.ResultSheetEntries) Then SigmaInst.ResultSheetEntries.Clear()

        SigmaInst.ResultSheetEntries = SigmaInst.RunFilter(SelectedDxfItems, SigmaInst.ActiveTemplate)

        ReloadResultTable()

        'If Not IsNothing(SigmaInst.FilteredDXFItems) Then SigmaInst.FilteredDXFItems.Clear()
        ''If Not IsNothing(SigmaInst.GroupedDXFItems) Then SigmaInst.GroupedDXFItems.Clear()

        'SigmaInst.FilteredDXFItems = SigmaInst.RunFilter(SigmaInst.GetSelectedDxfExtractItems(SelectedIndexes), SigmaInst.ActiveTemplate)

        'If SigmaInst.FilteredDXFItems.Count > 0 Then
        '    SigmaInst.GroupedDXFItems = SigmaInst.RunGroupRoutine(SigmaInst.FilteredDXFItems, SigmaInst.ActiveTemplate)
        'End If

        ''SigmaInst.TestOutput()

    End Sub


    Private Sub TableCountResults_SelectionChanged(sender As Object, e As EventArgs) Handles TableForDXFExtractSets.SelectionChanged

        If hasLoaded = True Then

            SigmaInst.ActiveDXFSet = SigmaInst.DXFExtractSets(TableForDXFExtractSets.CurrentCell.RowIndex)

            Recalculate()
        End If

    End Sub
    Private Sub TableTemplates_SelectionChanged(sender As Object, e As EventArgs) Handles TableForESTemplates.SelectionChanged

        If hasLoaded = True Then
            SigmaInst.ActiveTemplate = SigmaInst.ESTemplates(TableForESTemplates.CurrentCell.RowIndex)
            Recalculate()
        End If

    End Sub

    '' --------------------- templates ----------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SigmaInst.ActiveTemplate = SigmaInst.ESTemplates(TableForESTemplates.CurrentCell.RowIndex)

        Dim TemplateEditor As New EpicSigmaTemplateEditor
        TemplateEditor.ShowDialog()

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FilePath = FileExistIncrementer(Path.Combine({SigmaInst.CurrentProjectpath, "Templates", "PathTest.esT"}))

        Dim New_Template As New TemplateDef
        New_Template.TemplateName = "New"

        New_Template.TemplateSavePath = FilePath

        FilePath = SaveObjToFile(FilePath, New_Template)

        SigmaInst.ReloadESTemplates()
        ReloadTemplateTable()
        'Binding_ESTemplates.ResetBindings(True)

    End Sub




    '' ------------ unorganized -------------------

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim SelectedIndexes As New List(Of Integer)

        For Each TRow In TableForDXFExtractSets.SelectedRows
            SelectedIndexes.Add(TRow.Index)
        Next

        MsgBox(SigmaInst.RunFilter(SelectedDxfItems, SigmaInst.ActiveTemplate)(0).AssociatedDxfItems.Count)

    End Sub

    Public Function SelectedDxfItems() As List(Of DXFExtItemRef)
        Dim SelectedIndexes As New List(Of Integer)

        For Each TRow In TableForDXFExtractSets.SelectedRows
            SelectedIndexes.Add(TRow.Index)
        Next

        Return SigmaInst.GetSelectedDxfExtractItems(SelectedIndexes)
    End Function


    Private Sub ButtonTemplateDel_Click(sender As Object, e As EventArgs) Handles ButtonTemplateDel.Click
        File.Delete(SigmaInst.ActiveTemplate.TemplateSavePath)
        SigmaInst.ReloadESTemplates()
        ReloadTemplateTable()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For Each TRow In TableForDXFExtractSets.SelectedRows
            File.Delete(SigmaInst.DXFExtractSets(TRow.index).DXFItemSetFilePath)
        Next

        SigmaInst.ReloadDXFSets()
        ReloadDXFSetTable()
    End Sub

    Private Sub TableForESTemplates_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TableForESTemplates.CellMouseDoubleClick
        SigmaInst.ActiveTemplate = SigmaInst.ESTemplates(TableForESTemplates.CurrentCell.RowIndex)
        Dim TemplateEditor As New EpicSigmaTemplateEditor
        TemplateEditor.ShowDialog()
    End Sub

    Private Sub TableForDXFExtractSets_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TableForDXFExtractSets.CellMouseDoubleClick
        Dim RenameBox As New TextInputBox
        RenameBox.RefMode = "D"
        RenameBox.ShowDialog()
        SigmaInst.ResaveActiveDXFSet()
        SigmaInst.ReloadDXFSets()
        ReloadDXFSetTable()
    End Sub
End Class
