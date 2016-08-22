Public Class formResults
    Private Sub FormResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '-----BUTTONS----
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Me.Hide()
    End Sub

    '-----BUTTONS----
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

End Class