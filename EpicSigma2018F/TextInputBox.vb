Public Class TextInputBox

    Public RefMode As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveClose()
    End Sub

    Private Sub TextInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Select Case RefMode
            Case "D"
                With EpicSigmaMainFrame.SigmaInst.ActiveDXFSet
                    TextBox1.Text = .DXFItemSetName
                End With
            Case "T"
                With EpicSigmaMainFrame.SigmaInst.ActiveTemplate
                    TextBox1.Text = .TemplateName
                End With
            Case "C"
                With EpicSigmaMainFrame.SigmaInst.ActiveTemplate
                    TextBox1.Text = .ActiveSortCategory.CategoryDefName
                End With
        End Select

        Me.Location = Cursor.Position
        Me.TextBox1.Select()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub SaveClose()
        Select Case RefMode
            Case "D"
                With EpicSigmaMainFrame.SigmaInst.ActiveDXFSet
                    .DXFItemSetName = TextBox1.Text
                End With
            Case "T"
                With EpicSigmaMainFrame.SigmaInst.ActiveTemplate
                    .TemplateName = TextBox1.Text
                End With
            Case "C"
                With EpicSigmaMainFrame.SigmaInst.ActiveTemplate
                    .ActiveSortCategory.CategoryDefName = TextBox1.Text
                End With
        End Select
        Close()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub
End Class