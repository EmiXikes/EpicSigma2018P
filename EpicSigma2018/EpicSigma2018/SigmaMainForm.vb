Imports DEL_acadltlib_EM.EpicProfiles

Public Class SigmaMainForm

    Dim TestSaveSystem As SaveProfileSystem
    Dim TestBindList As List(Of TestThing)
    Dim Listbinding As New BindingSource
    Dim n As Integer = 0

    Private Class TestThing
        Property Axx As String
        Property Axx2 As String
    End Class

    Private Sub TableResultSheet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableResultSheet.CellContentClick

    End Sub

    Private Sub SigmaMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TestBindList = New List(Of TestThing)

        Listbinding.DataSource = TestBindList
        TableCountResults.DataSource = Listbinding

        TestSaveSystem = New SaveProfileSystem
        TestSaveSystem.Ext = "sgm"
        TestSaveSystem.ProfileSavePath = "C:\Epic\test\sgm"


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TestBindList.Add(New TestThing With {.Axx = "TEST " & n, .Axx2 = "AA " & n})
        n += 1
        Listbinding.ResetBindings(True)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Move selected item down
        Dim SelectedItem As Integer = TableCountResults.SelectedCells(0).RowIndex
        Dim MovableThing As New TestThing
        If SelectedItem < TableCountResults.Rows.Count - 1 Then
            MovableThing = TestBindList(SelectedItem)
            TestBindList.RemoveAt(SelectedItem)
            TestBindList.Insert(SelectedItem + 1, MovableThing)
            Listbinding.ResetBindings(True)
            TableCountResults.Rows(SelectedItem + 1).Selected = True
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' Move selected item up
        Dim SelectedItem As Integer = TableCountResults.SelectedCells(0).RowIndex
        Dim MovableThing As New TestThing
        If SelectedItem >= 1 Then
            MovableThing = TestBindList(SelectedItem)
            TestBindList.RemoveAt(SelectedItem)
            TestBindList.Insert(SelectedItem - 1, MovableThing)
            Listbinding.ResetBindings(True)
            TableCountResults.Rows(SelectedItem - 1).Selected = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TestSaveSystem.SaveSettingToProfile("SigmaGroupCondition_01", "SettingName", "valll")

    End Sub
End Class
