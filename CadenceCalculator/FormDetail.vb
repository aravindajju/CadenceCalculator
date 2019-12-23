Public Class FormDetail
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Clipboard.SetText(rtbDetail.Text, TextDataFormat.Text)
    End Sub
End Class

