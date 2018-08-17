Imports System.Windows.Forms
Imports DEL_acadltlib_EM.CAD_attextract

Public Class EpicSigmaTemplateDef
    Public Class TemplateDef

        ''V2
        Public Property TemplateName As String
        Public Property TemplateSavePath As String

        ''Public Property Lst_FilterConditions As New List(Of ConditionDef)

        Public Property Lst_SortCategories As New List(Of SortCatDef)
        'Public Binding_Lst_SortCategories As New BindingSource
        Public ActiveSortCategory As New SortCatDef
    End Class

    <Serializable>
    Public Class ConditionDef
        Public Property ConditionName As String
        Public Property Type As String
        Public Property Section As String
        Public Property Prop As String
        Public Property Value As String
        Public Property Oprtr As String

    End Class

    Public Class SortCatDef

        Public Property CategoryDefName As String

        Public Property Lst_FilterConditions As New List(Of ConditionDef)
        'Public Binding_Lst_FilterConditions As New BindingSource
        Public ActiveFilterCondition As New ConditionDef
        Public FieldEdit As New OutputFieldDef

        ''Output Data
        Public Property AssociatedDxfItems As List(Of DXFExtItemRef)

        Public Property Field_No As OutputFieldDef
        Public Property Field_Code As OutputFieldDef
        Public Property Field_Name As New OutputFieldDef
        Public Property Field_DescType As OutputFieldDef
        Public Property Field_Units As OutputFieldDef
        Public Property Field_Amount As OutputFieldDef

    End Class

    Public Class OutputFieldDef
        Public Property FieldType As OutputFieldType

        ''Field Type
        Public Property FieldTypeNumbering As Boolean = False
        Public Property FieldTypeManualText As Boolean = False
        Public Property FieldTypeAttributeValue As Boolean = False
        Public Property FieldTypeItemCount As Boolean = False
        Public Property FieldTypeAttributeSum As Boolean = False

        ''Numbering
        Public Property Num_Show As Boolean
        Public Property Num_Tier01 As Boolean
        Public Property Num_Tier02 As Boolean
        Public Property Num_Tier03 As Boolean
        Public Property Num_Tier04 As Boolean

        ''Manual Text
        Public Property ManualText As String

        ''Attribute Text
        Public Property AttributeTag As String
        Public Property Attribute_ValueFind As String
        Public Property Attribute_ValueReplace As String
        Public Property Attribute_isMultiline As Boolean

        ''Item Count
        Public Property Count_isMultiplicationModeEnabled As Boolean
        Public Property Count_MultiplicatorDefaultForMissingValue As Integer

        Public Property Count_isMultiplicatorSourceCustomInt As Boolean
        Public Property Count_isMultiplicatorSourceAttrValue As Boolean

        Public Property Count_MultiplicatorSourceCustomInt As Integer
        Public Property Count_MultiplicatorSourceAttrTAG As String

        ''Attribute SUM
        Public Property Sum_DefaultForMissingValue As Integer
        Public Property Sum_SparePercentageValue As Integer
        Public Property Sum_RoundValue As Integer
        Public Property Sum_isAddSparePercentageEnabled As Boolean
        Public Property Sum_isRoundValueEnabled As Boolean

    End Class

    Public Enum OutputFieldType
        FieldTypeNumbering
        FieldTypeManualText
        FieldTypeAttributeValue
        FieldTypeItemCount
        FieldTypeAttributeSum
    End Enum


    '' TODO Revise these

    Public Class OutputSheetEntry
        Public Property AssociatedDxfItems As List(Of DXFExtItemRef)

        Public Property Field_No As String
        Public Property Field_Code As String
        Public Property Field_Name As String
        Public Property Field_DescType As String
        Public Property Field_Units As String
        Public Property Field_Amount As String

        Public Property CatName As String
        Public Property EntryID As Integer
    End Class

    Public Enum FilterOperators
        Equals
        Contains
        Exists
        'isLarger
        'isSmaller
    End Enum

    Public Enum FilterSections
        General
        Attributes
        'Geometry
        'Misc
    End Enum
End Class
