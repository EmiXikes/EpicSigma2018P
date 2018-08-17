Imports EpicSigma2018P.EpicSigma2018lib

Public Class ConditionPropertyDialog

    Dim SelectedCondition As EpicSigmaCondition

    Sub saveclose()
        GlobalVar.GlobalVar.SectionName = ComboBox1.Text
        If ComboBox1.Text = "Attributes" Then
            GlobalVar.GlobalVar.PropName = TextBox1.Text
        Else
            GlobalVar.GlobalVar.PropName = ComboBox2.Text
        End If
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saveclose()
    End Sub

    Private Sub ConditionPropertyDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Cursor.Position

        SelectedCondition = EpicSigmaMainFrame.SigmaInst.ActiveCondition

        ComboBox1.DataSource = GlobalVar.CoditionLists.SectionList
        ComboBox2.DataSource = GlobalVar.CoditionLists.GeneralPropList

        ComboBox1.Text = SelectedCondition.Section

        If SelectedCondition.Section = "Attributes" Then
            ComboBox2.Visible = False
            TextBox1.Visible = True
            TextBox1.Text = SelectedCondition.Prop
            Label2.Text = "TAG:"
            TextBox1.Select()
        Else
            ComboBox2.Visible = True
            TextBox1.Visible = False

            ComboBox2.Text = SelectedCondition.Prop
            Label2.Text = "Property:"
        End If

    End Sub

    Private Sub ConditionPropertyDialog_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.Text = "Attributes" Then
            ComboBox2.Visible = False
            TextBox1.Visible = True
            Label2.Text = "TAG:"
            TextBox1.Select()
        Else
            ComboBox2.Visible = True
            TextBox1.Visible = False
            Label2.Text = "Property:"
            ComboBox1.Select()
        End If
    End Sub

    Private Sub ComboBox1_TextUpdate(sender As Object, e As EventArgs) Handles ComboBox1.TextUpdate

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            saveclose()
        End If
    End Sub
End Class