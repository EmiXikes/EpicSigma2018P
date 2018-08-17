Public Class ValueEntryDialog

    Public StartingLocation As Point

    Public RefMode As String

    Private Sub ValueEntryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case RefMode
            Case "D"

            Case "T"
                With EpicSigmaMainFrame.SigmaInst.ActiveTemplate
                    TextBox1.Text = .TemplateName
                End With
        End Select


        Me.Location = StartingLocation
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveClose()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub

    Sub SaveClose()

        Select Case RefMode
            Case "D"

            Case "T"
                With EpicSigmaMainFrame.SigmaInst.ActiveTemplate
                    .TemplateName = TextBox1.Text
                End With
        End Select

        Close()
    End Sub

End Class