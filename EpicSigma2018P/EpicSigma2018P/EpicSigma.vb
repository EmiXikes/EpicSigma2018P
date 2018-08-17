Imports System.IO
Imports System.Windows.Forms
Imports DEL_acadltlib_EM
Imports DEL_acadltlib_EM.CAD_attextract

Public Class EpicSigma2018lib

    ' Main

    Public Class EpicSigmaInstance

        Public Property CurrentProjectName As String = "_DefaultProject"
        Public Property CurrentProjectpath As String = Path.Combine({My.Application.Info.DirectoryPath, "Projects", CurrentProjectName})

        Public DXFExtractTableBinding As New BindingSource
        Public ESTemplateTableBinding As New BindingSource

        ' Main::DXF
        Public DXFExtractSets As New List(Of DXFExtractSet)
        Public Function ReloadDXFSets() As Boolean

            DXFExtractSets.Clear()

            Dim DXFExtractSetFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "ExtractSets"}))
            For Each ExtractSetFilePath In DXFExtractSetFilePaths
                DXFExtractSets.Add(FileIO.LoadObjFromFile(Of DXFExtractSet)(ExtractSetFilePath))
            Next

            DXFExtractTableBinding.ResetBindings(True)

            Return True


        End Function

        ' Main::Templates
        Public ESTemplates As New List(Of ESTemplate)
        Public Function ReloadESTemplates() As Boolean

            ESTemplates.Clear()

            Dim ESTemplateFilePaths As String() = Directory.GetFiles(Path.Combine({CurrentProjectpath, "Templates"}))
            For Each ExtractSetFilePath In ESTemplateFilePaths
                ESTemplates.Add(FileIO.LoadObjFromFile(Of ESTemplate)(ExtractSetFilePath))
            Next

            ESTemplateTableBinding.ResetBindings(True)

            Return True
        End Function

        Public Function GetSelectedDxfExtractItems(ByVal SelectedIndexes As List(Of Integer)) As List(Of CAD_attextract.DXFExtItemRef)

            Dim ResultList As New List(Of CAD_attextract.DXFExtItemRef)

            For Each index In SelectedIndexes
                For Each DxfItem In DXFExtractSets(index).DXFItemList
                    ResultList.Add(DxfItem)
                Next
            Next

            Return ResultList

        End Function


        Public ValidOutputItems As New List(Of OutputEntryTextField)
        Public UnknownOutputItems As New List(Of CAD_attextract.DXFExtItemRef)


        Public Function ValidateItems(ByVal DXFExtractItems As List(Of DXFExtItemRef), ByVal SelectedTemplate As Integer)

            Dim ResultList As New List(Of DXFExtItemRef)

            Dim isDxfItemValid As Boolean = True

            For Each DxfI In DXFExtractItems

                isDxfItemValid = True

                For Each GroupCondition In ESTemplates(SelectedTemplate).EpicSigma_GroupConditionCollection
                    Select Case GroupCondition.Section
                        Case "General"
                            Select Case GroupCondition.Prop
                                Case "Layer"
                                    If DxfI.Layer = GroupCondition.Value Then Else isDxfItemValid = False
                                Case "Color"
                                    If DxfI.Color = GroupCondition.Value Then Else isDxfItemValid = False
                            End Select
                        ''Case GroupSections.Misc
                        Case "Attributes"
                            If DxfI.GetAttValue(GroupCondition.Prop) = GroupCondition.Value Then Else isDxfItemValid = False
                    End Select

                Next

                If isDxfItemValid = True Then
                    ResultList.Add(DxfI)
                End If

            Next

            Return ResultList

        End Function

        Public Function CalculateOutput()

        End Function

    End Class

    ' DXF Extract items

    <Serializable>
    Public Class DXFExtractSet

        Public Property DXFItemSetName As String
        Public Property DXFItemSetFilePath As String
        Public Property DXFItemCount As Integer
        Public Property Index As Integer

        Public DXFItemList As List(Of CAD_attextract.DXFExtItemRef)

        Public EpicSigma_OutputEntries As List(Of OutputEntry)

    End Class

    ' Templates

    ' Group
    <Serializable>
    Public Class ESTemplate

        Public Property TemplateName As String
        Public Property TemplateSavePath As String

        Public Property EpicSigma_GroupConditionCollection As List(Of EpicSigmaGroupCondition)
        Public Property EpicSigma_GroupConditionSequence As List(Of String)

        Public Property EpicSigma_OutputEntries As List(Of OutputEntryTextField)

    End Class

    <Serializable>
    Public Class EpicSigmaGroupCondition
        Public Property ConditionName As String
        Public Property Type As String
        Public Property Section As String
        Public Property Prop As String
        Public Property Value As String
        Public Property Oprtr As GroupOperators

    End Class

    <Serializable>
    Public Enum GroupSections
        General
        Attributes
        'Geometry
        'Misc
    End Enum

    <Serializable>
    Public Enum GroupOperators
        Equals
        Contains
        Exists
        'isLarger
        'isSmaller
    End Enum

    ' Output

    <Serializable>
    Public Enum OutputField
        ESigmaOutCathegory
        ESigmaOutNo
        ESigmaOutCode
        ESigmaOutName
        ESigmaOutType
        ESigmaOutUnits
        ESigmaOutCount
    End Enum

    <Serializable>
    Public Class OutputEntry
        Public Property DxfItems As List(Of CAD_attextract.DXFExtItemRef)
        Public Property TextFields As List(Of OutputEntryTextField)
    End Class

    <Serializable>
    Public Class OutputEntryTextField

        Public Property ESigmaOutFieldType As OutputField

        Public Property ManualTextField As String
        Public Property AttrValueField As String

        Public Property ItemCount As String
        Public Property AttrSum As String

        Public Property AttrFind As String
        Public Property AttrReplace As String

        Public Property AttrSep As String
        Public Property AttrSepSection As Integer = 0

        Public Property AttrPrefix As String
        Public Property AttrSufffix As String

        Public Property AttrInsertText As String
        Public Property AttrInsertAt As Integer = 0

    End Class









End Class
