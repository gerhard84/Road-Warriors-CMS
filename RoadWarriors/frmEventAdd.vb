Public Class frmNewEvent

    Public RaceEvent As RaceEvent

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaceEvent = New RaceEvent(txtEvent.Text, CDate(dateEvent.Text), CDec(txtFee.Text),
                                   txtLocation.Text, CInt(txtDistance.Text))
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmNewEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class