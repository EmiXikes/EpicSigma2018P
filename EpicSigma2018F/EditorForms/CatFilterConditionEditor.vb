Imports EpicSigma2018P.EpicSigma2018lib
Imports EpicSigma2018P.EpicSigmaTemplateDef

Public Class CatFilterConditionEditor

    Dim SelectedCondition As ConditionDef
    Public StartingtLocation As Point
    Public ConditionType As String

    Private Sub ConditionPropertyDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''MsgBox(StartingtLocation.ToString)

        Me.Location = New Point(StartingtLocation)

        ComboBoxSection.Items.AddRange(GlobalVar.CoditionLists.SectionList)
        ComboBoxProp.Items.AddRange(GlobalVar.CoditionLists.GeneralPropList)
        ComboBoxOprt.Items.AddRange(GlobalVar.CoditionLists.EqualOperator)

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory.ActiveFilterCondition
            TextBoxConditionName.Text = .ConditionName
            ComboBoxSection.Text = .Section
            If .Section = "Attributes" Then
                ComboBoxProp.Visible = False
                TextBoxAttr.Visible = True
                TextBoxAttr.Text = .Prop
            Else
                ComboBoxProp.Visible = True
                TextBoxAttr.Visible = False
                ComboBoxProp.Text = .Prop
            End If
            ComboBoxOprt.Text = .Oprtr
            TextBoxValue.Text = .Value
        End With

    End Sub

    Sub SaveClose()

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory.ActiveFilterCondition
            .ConditionName = TextBoxConditionName.Text
            .Section = ComboBoxSection.Text
            If ComboBoxSection.Text = "Attributes" Then
                .Prop = TextBoxAttr.Text
            Else
                .Prop = ComboBoxProp.Text
            End If
            .Oprtr = ComboBoxOprt.Text
            .Value = TextBoxValue.Text
        End With

        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveClose()
    End Sub



    Private Sub ConditionPropertyDialog_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxSection.SelectionChangeCommitted
        If ComboBoxSection.Text = "Attributes" Then
            ComboBoxProp.Visible = False
            TextBoxAttr.Visible = True
            ''Label2.Text = "TAG:"
            TextBoxAttr.Select()
        Else
            ComboBoxProp.Visible = True
            TextBoxAttr.Visible = False
            ''Label2.Text = "Property:"
            ComboBoxSection.Select()
        End If
    End Sub

    Private Sub ComboBox1_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxSection.TextUpdate

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSection.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAttr.TextChanged

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxAttr.KeyUp
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub

    Private Sub ConditionPropertyDialog_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        SaveClose()
    End Sub

    Private Sub TextBoxConditionName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxConditionName.TextChanged

    End Sub

    Private Sub TextBoxConditionName_KeyUp(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBoxValue_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub TextBoxValue_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBoxConditionName_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBoxConditionName.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub

    Private Sub TextBoxAttr_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBoxAttr.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub

    Private Sub ComboBoxProp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles ComboBoxProp.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub

    Private Sub TextBoxValue_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBoxValue.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub
End Class