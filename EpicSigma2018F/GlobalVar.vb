Module GlobalVar

    Public Class GlobalVar
        Public Shared ConditionName As String
        Public Shared PropName As String
        Public Shared SectionName As String
        Public Shared ConditionValue As String
        Public Shared ConditionOperator As String



    End Class


    Public Class CoditionLists
        Public Shared SectionList As String() = {
            "General",
            "Attributes"}

        Public Shared GeneralPropList As String() = {
            "Color",
            "Layer"}

        Public Shared EqualOperator As String() = {
    "ir vienāds ar vērtību",
    "satur vērtību"}
    End Class
End Module
