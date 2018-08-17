Imports System.IO
Imports System.Windows.Forms
Imports DEL_acadltlib_EM
Imports DEL_acadltlib_EM.DXF
Imports DEL_acadltlib_EM.CAD_attextract
Imports DEL_acadltlib_EM.FileIO
Imports EpicSigma2018P.EpicSigmaTemplateDef

Public Class EpicSigma2018lib

    ' --------------------- Main Functions  -----------------

    Public Class EpicSigmaInstance

        Public Property CurrentProjectName As String = "_DefaultProject"
        Public Property CurrentProjectpath As String = Path.Combine({My.Application.Info.DirectoryPath, "Projects", CurrentProjectName})

        Public ESTemplates As New List(Of TemplateDef)
        Public ActiveTemplate As New TemplateDef
        Public ActiveDXFSet As New DXFItemSet

        Public DXFExtractSets As New List(Of DXFItemSet)
        ''Public CatFilteredDXFItemSets As List(Of DXFItemSet)
        Public ResultSheetEntries As New List(Of OutputSheetEntry)
        Public UnknownDXFItems As New List(Of DXFExtItemRef)


        Public Function DXFElementSets() As List(Of DXFItemSet)

            RewritePathsForDXFSets()
            Dim ResultList As New List(Of DXFItemSet)

            Dim DXFExtractSetFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "ExtractSets"}))
            For Each ExtractSetFilePath In DXFExtractSetFilePaths
                ResultList.Add(FileIO.LoadObjFromFile(Of DXFItemSet)(ExtractSetFilePath))
            Next
            Return ResultList

        End Function

        Public Function AddNewDXFSetFromSelected(ByVal SetName As String)

            Dim New_DXFExtractSet As New DXFItemSet

            Dim FilePath As String = FileExistIncrementer(Path.Combine({CurrentProjectpath, "ExtractSets", SetName & ".gy"}))

            DDE.initDDE()

            New_DXFExtractSet = New DXFItemSet
            New_DXFExtractSet.DXFItemList = New List(Of DXFExtItemRef)
            New_DXFExtractSet.DXFItemList = ReadBlockAttributesFromDXFExtractFile(Export2DXF_Selected())
            New_DXFExtractSet.DXFItemSetName = SetName ''Path.GetFileName(FilePath)
            New_DXFExtractSet.DXFItemSetFilePath = FilePath
            New_DXFExtractSet.DXFItemCount = New_DXFExtractSet.DXFItemList.Count

            FilePath = SaveObjToFile(FilePath, New_DXFExtractSet)

            DDE.CloseDDE()

        End Function

        Public Function EditDXFSet(ByVal SelectedDXFSetIndex As Integer)

        End Function

        Public Function RemoveDXFSet(ByVal SelectedDXFSetIndex As Integer)

        End Function

        Public Function SigmaTemplates() As List(Of TemplateDef)

            RewritePathsForESTemplates()
            Dim ResultList As New List(Of TemplateDef)

            Dim ESTemplateFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "Templates"}))
            For Each ExtractSetFilePath In ESTemplateFilePaths
                ResultList.Add(FileIO.LoadObjFromFile(Of TemplateDef)(ExtractSetFilePath))
            Next

            Return ResultList
        End Function

        Public Function AddNewSigmaTemplate(ByVal NewSigmaTemplate As TemplateDef)

            Dim FilePath As String = FileExistIncrementer(Path.Combine({CurrentProjectpath, "Templates", NewSigmaTemplate.TemplateName & ".esT"}))

            NewSigmaTemplate.TemplateSavePath = FilePath

            SaveObjToFile(FilePath, NewSigmaTemplate)

        End Function

        Public Function RemoveSigmaTemplate(ByVal SelectedTemplateIndex As Integer)
        End Function

        Public Function OutputSheetRows() As List(Of OutputSheetEntry)
        End Function



        ' Main::
        Public Function ReloadDXFSets() As Boolean

            RewritePathsForDXFSets()
            DXFExtractSets.Clear()

            Dim DXFExtractSetFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "ExtractSets"}))
            For Each ExtractSetFilePath In DXFExtractSetFilePaths
                DXFExtractSets.Add(FileIO.LoadObjFromFile(Of DXFItemSet)(ExtractSetFilePath))
            Next
            Return True

        End Function
        Public Function RewritePathsForDXFSets() As Boolean

            Dim ThisDXFExtractSet As DXFItemSet

            Dim DXFExtractSetFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "ExtractSets"}))
            For Each ExtractSetFilePath In DXFExtractSetFilePaths

                ThisDXFExtractSet = FileIO.LoadObjFromFile(Of DXFItemSet)(ExtractSetFilePath)
                ThisDXFExtractSet.DXFItemSetFilePath = ExtractSetFilePath
                SaveObjToFile(ExtractSetFilePath, ThisDXFExtractSet, True)

            Next
            Return True

        End Function
        Public Function GetSelectedDxfExtractItems(ByVal SelectedIndexes As List(Of Integer)) As List(Of DXFExtItemRef)

            Dim ResultList As New List(Of CAD_attextract.DXFExtItemRef)

            For Each index In SelectedIndexes
                For Each DxfItem In DXFExtractSets(index).DXFItemList
                    ResultList.Add(DxfItem)
                Next
            Next

            Return ResultList

        End Function
        Public Function ReloadESTemplates() As Boolean

            RewritePathsForESTemplates()
            ESTemplates.Clear()

            Dim ESTemplateFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "Templates"}))
            For Each ExtractSetFilePath In ESTemplateFilePaths
                ESTemplates.Add(FileIO.LoadObjFromFile(Of TemplateDef)(ExtractSetFilePath))
            Next

            'Binding_ESTemplates.ResetBindings(True)

            Return True
        End Function
        Public Function RewritePathsForESTemplates() As Boolean

            Dim ThisESTempalte As TemplateDef
            Dim ESTemplateFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "Templates"}))
            For Each ExtractSetFilePath In ESTemplateFilePaths
                ThisESTempalte = FileIO.LoadObjFromFile(Of TemplateDef)(ExtractSetFilePath)
                ThisESTempalte.TemplateSavePath = ExtractSetFilePath
                SaveObjToFile(ExtractSetFilePath, ThisESTempalte, True)
            Next

            Return True
        End Function
        Public Sub ResaveActiveTemplate()
            SaveObjToFile(ActiveTemplate.TemplateSavePath, ActiveTemplate, True)
        End Sub
        Public Sub ResaveActiveDXFSet()
            SaveObjToFile(ActiveDXFSet.DXFItemSetFilePath, ActiveDXFSet, True)
        End Sub

        Public Function RunFilter(ByVal DXFExtractItems As List(Of DXFExtItemRef), ByVal CurrentTempalte As TemplateDef) As List(Of OutputSheetEntry)

            Dim ValidItems As New List(Of DXFExtItemRef)
            Dim ValidCatItems As New List(Of DXFExtItemRef)
            Dim ResultCatEntry As New OutputSheetEntry

            Dim ListofResultCatEntries As New List(Of OutputSheetEntry)

            Dim isDxfItemValid As Boolean = True

            Dim ExactMatch As Boolean

            ''TODO not finished!!!! Missing category loop

            For Each Cat In CurrentTempalte.Lst_SortCategories

                ValidCatItems = New List(Of DXFExtItemRef)

                For Each DxfI In DXFExtractItems

                    isDxfItemValid = True

                    For Each CatFilter In Cat.Lst_FilterConditions
                        If CatFilter.Oprtr = "ir vienāds ar vērtību" Then
                            ExactMatch = True
                        Else
                            ExactMatch = False
                        End If

                        Select Case CatFilter.Section
                            Case "General"
                                Select Case CatFilter.Prop
                                    Case "Layer"
                                        If Not (StrEq(DxfI.Layer, CatFilter.Value, ExactMatch)) Then isDxfItemValid = False
                                    Case "Color"
                                        If Not (StrEq(DxfI.Color, CatFilter.Value, ExactMatch)) Then isDxfItemValid = False
                                End Select
                            Case "Attributes"
                                If Not (StrEq(DxfI.GetAttValue(CatFilter.Prop), CatFilter.Value, ExactMatch)) Then isDxfItemValid = False
                        End Select
                    Next

                    If isDxfItemValid = True Then
                        DxfI.Var7 = "SigmaMark"
                        ValidCatItems.Add(DxfI)
                    End If

                Next


                If ValidCatItems.Count > 0 Then

                    ResultCatEntry = New OutputSheetEntry
                    ResultCatEntry.AssociatedDxfItems = New List(Of DXFExtItemRef)

                    ResultCatEntry.Field_Name = Cat.Field_Name.ManualText
                    ResultCatEntry.Field_Amount = ValidCatItems.Count
                    ResultCatEntry.AssociatedDxfItems.AddRange(ValidCatItems)

                End If

                If ValidCatItems.Count > 0 Then
                    ListofResultCatEntries.Add(ResultCatEntry)
                End If

            Next

            UnknownDXFItems = New List(Of DXFExtItemRef)

            For Each DxfI In DXFExtractItems
                If Not (DxfI.Var7 = "SigmaMark") Then
                    UnknownDXFItems.Add(DxfI)
                End If
            Next

            Return ListofResultCatEntries

        End Function

        Private Function StrEq(ByVal Str As String, ByVal StrToCheckAgainst As String, ByVal ExactMatch As Boolean)

            Str = Strings.Trim(Strings.UCase(Str))
            StrToCheckAgainst = Strings.Trim(Strings.UCase(StrToCheckAgainst))

            If ExactMatch = True Then
                If Str = StrToCheckAgainst Then
                    Return True
                End If
            Else
                If Str.Contains(StrToCheckAgainst) = True Then
                    Return True
                End If
            End If

            Return False

        End Function

        'Public Function RunGroupRoutine(ByVal DXFExtractItems As List(Of DXFExtItemRef), ByVal CurrentTempalte As TemplateDef) As List(Of ExtListItem)

        '    Dim GroupedList As New List(Of ExtListItem)
        '    Dim GroupSettings As List(Of DXFItemProp)
        '    Dim GrS As DXFItemProp



        '    GroupedList.Add(New ExtListItem With {.BlckRefs = DXFExtractItems})

        '    For Each GrCond In CurrentTempalte.Lst_GroupConditions
        '        GroupSettings = New List(Of DXFItemProp)
        '        GrS = New DXFItemProp

        '        For Each cond In CurrentTempalte.Lst_GroupConditions
        '            Select Case cond.Section
        '                Case "Type"

        '                    GrS.PropSection = DXFItemPropSections.DxfItemCategory

        '                Case "General"

        '                    GrS.PropSection = DXFItemPropSections.General

        '                    Select Case cond.Prop

        '                        Case "Layer"
        '                            GrS.PropName = DXFItemPropName.Layer
        '                        Case "Color"
        '                            GrS.PropName = DXFItemPropName.Color

        '                    End Select

        '                Case "Attributes"

        '                    GrS.PropSection = DXFItemPropSections.Attributes
        '                    GrS.PropAttributeTAG = cond.Prop

        '            End Select

        '            GroupSettings.Add(GrS)

        '        Next

        '        GroupedList = ReGroupDXFItemsBy(GroupedList, GroupSettings)
        '    Next

        '    Return GroupedList

        'End Function


        'Public Function TestOutput()
        '    'ResultSheetEntries.Clear()
        '    'UnknownDXFItems.Clear()

        '    'If Not IsNothing(GroupedDXFItems) Then
        '    '    If GroupedDXFItems.Count > 0 Then
        '    '        For Each gr In GroupedDXFItems
        '    '            ResultSheetEntries.Add(New OutputSheetEntry With {.AssociatedDxfItems = gr.BlckRefs,
        '    '                           .Field_Name = gr.BlckRefs(0).GetAttValue("KABELIS"),
        '    '                           .Field_Amount = gr.BlckRefs.Count})
        '    '        Next
        '    '    End If
        '    'End If

        '    'BindingResultSheetTable.ResetBindings(True)
        'End Function

        ' Main:: Output

    End Class

    '------------------------ Classes and items ----------------------

    ' DXF Extract items

    Public Class DXFItemSet
        Public Property DXFItemSetName As String
        Public Property DXFItemSetFilePath As String
        Public Property DXFItemCount As Integer
        Public Property Index As Integer

        Public DXFItemList As List(Of DXFExtItemRef)
    End Class

    Public Class DXFItemCatSet
        Public Property DXFItemSetName As String
        Public Property DXFItemSetFilePath As String
        Public Property DXFItemCount As Integer
        Public Property Index As Integer

        Public DXFItemList As List(Of DXFExtItemRef)
    End Class

    'Public Class GroupedDXFItemSet
    '    Public DXFItemList As List(Of DXFExtItemRef)
    'End Class

    'Public Class TemplateItems

    '    '    <Serializable>
    '    '    Public Class TemplateDef

    '    '        ''V2
    '    '        Public Property TemplateName As String
    '    '        Public Property TemplateSavePath As String

    '    '        Public Property Lst_FilterConditions As List(Of ConditionDef)
    '    '        Public Property Lst_SortCategories As List(Of SortCatDef)


    '    '        ''V1 --- OLD
    '    '        Public Property Lst_GroupConditions As New List(Of ConditionDef)

    '    '        Public Property PostFilterActionCollection As List(Of PostProcessAction)
    '    '        Public Property PostGroupActionCollection As List(Of PostProcessAction)

    '    '        Public Property EpicSigma_OutputEntries As List(Of OutputEntryTextField)

    '    '    End Class

    '    '    <Serializable>
    '    '    Public Class ConditionDef
    '    '        Public Property ConditionName As String
    '    '        Public Property Type As String
    '    '        Public Property Section As String
    '    '        Public Property Prop As String
    '    '        Public Property Value As String
    '    '        Public Property Oprtr As String

    '    '    End Class

    '    '    Public Class SortCatDef
    '    '        Public Property AssociatedDxfItems As List(Of DXFExtItemRef)
    '    '        Public Property Field_No As OutputFieldDef
    '    '        Public Property Field_Code As OutputFieldDef
    '    '        Public Property Field_Name As OutputFieldDef
    '    '        Public Property Field_DescType As OutputFieldDef
    '    '        Public Property Field_Units As OutputFieldDef
    '    '        Public Property Field_Amount As OutputFieldDef
    '    '    End Class

    '    '    Public Class OutputFieldDef
    '    '        Public Property FieldType As OutputFieldType
    '    '        Public Property ManualText As String
    '    '        Public Property AttributeTag As String
    '    '    End Class

    '    '    Public Enum OutputFieldType
    '    '        ManualTextField
    '    '        AttributeValue
    '    '        ItemCount
    '    '        AttrValueSum
    '    '        Special
    '    '    End Enum


















    '    '' OLD VER






    '    '<Serializable>
    '    'Public Enum GroupType
    '    '    SUM
    '    '    COUNT
    '    'End Enum

    '    <Serializable>
    '    Public Class GroupSUMItem
    '        Public Property Type As String
    '        Public Property Section As String
    '        Public Property Prop As String
    '    End Class

    '    <Serializable>
    '    Public Enum FilterSections
    '        General
    '        Attributes
    '        'Geometry
    '        'Misc
    '    End Enum

    '    <Serializable>
    '    Public Enum FilterOperators
    '        Equals
    '        Contains
    '        Exists
    '        'isLarger
    '        'isSmaller
    '    End Enum

    '    ' Tempaltes::Actions
    '    <Serializable>
    '    Public Class PostProcessAction
    '        Public Property ProcessActionName As String
    '        Public Property ProcessActionType As PostProcessActionType
    '        Public Property Data As String()

    '    End Class

    '    <Serializable>
    '    Public Enum PostProcessActionType
    '        FindReplace
    '        Other
    '    End Enum

    '    ' Templates::Output

    '    <Serializable>
    '    Public Enum OutputField
    '        ESigmaOutCathegory
    '        ESigmaOutNo
    '        ESigmaOutCode
    '        ESigmaOutName
    '        ESigmaOutType
    '        ESigmaOutUnits
    '        ESigmaOutCount
    '    End Enum

    '    <Serializable>
    '    Public Class OutputEntryTextField

    '        Public Property ESigmaOutFieldDesignation As OutputField
    '        Public Property ESigmaOutFieldType As OutputFieldType

    '        Public Property OutFieldTextEntry As String

    '    End Class

    '    ' Output items

    '    <Serializable>
    '    Public Class OutputSheetEntry
    '        Public Property AssociatedDxfItems As List(Of CAD_attextract.DXFExtItemRef)
    '        Public Property Field_No As String
    '        Public Property Field_Code As String
    '        Public Property Field_Name As String
    '        Public Property Field_DescType As String
    '        Public Property Field_Units As String
    '        Public Property Field_Amount As String
    '    End Class
    'End Class


End Class
