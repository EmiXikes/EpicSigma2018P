Public Class TextInputBox


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveClose()
    End Sub

    Private Sub TextInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Cursor.Position
        Me.TextBox1.Select()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub SaveClose()
        EpicSigmaMainFrame.PassString = TextBox1.Text
        Close()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            SaveClose()
        End If
    End Sub
End Class