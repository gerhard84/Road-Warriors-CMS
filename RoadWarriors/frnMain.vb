Public Class frnMain
    '-----BUTTONS----
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        frmResult.Show()
        Me.Hide()
    End Sub
    '-----BUTTONS----
    Private Sub btnManEvent_Click(sender As Object, e As EventArgs) Handles btnManEvent.Click
        frmEvent.Show()
        Me.Hide()
    End Sub
    '-----BUTTONS----
    Private Sub btnManMembers_Click(sender As Object, e As EventArgs) Handles btnManMembers.Click
        frmMember.Show()
        Me.Hide()
    End Sub
    '-----BUTTONS----
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
End Class
