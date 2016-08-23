Public Class frmMemberAdd

    Public Member As Member

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Member = New RaceEvent(txtEvent.Text, CDate(dateEvent.Text), CDec(txtFee.Text),
                                   txtLocation.Text, CInt(txtDistance.Text))
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class