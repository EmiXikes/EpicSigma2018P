Imports EpicSigma2018P.EpicSigma2018lib
Imports EpicSigma2018P.EpicSigma2018lib.TemplateItems
Imports EpicSigma2018P.EpicSigmaTemplateDef

Public Class ResultFieldEditor

    ''Public FieldDesignation As OutputField

    Private Sub ResultFieldEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory

            RichTextBox1.Text = .Field_Name.ManualText
            RichTextBox1.Select()
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SaveClose()

    End Sub

    Private Sub SaveClose()
        With EpicSigmaMainFrame.SigmaInst.ActiveTemplate.ActiveSortCategory

            .Field_Name.ManualText = RichTextBox1.Text

        End With

        Close()
    End Sub

    Private Sub ResultFieldEditor_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        ''SaveClose()
    End Sub
End Class