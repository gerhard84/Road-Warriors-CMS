Public Class frmEvent
    Dim raceEvents As List(Of RaceEvent)

    Private Sub frmEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        raceEvents = RaceEventDB.GetRaceEvent
        Me.FillRaceListBox()
    End Sub

    Private Sub FillRaceListBox()
        lstEvents.Items.Clear()
        For Each p As RaceEvent In raceEvents
            lstEvents.Items.Add(p.GetDisplayText(vbTab))
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newEventForm As New frmNewEvent
        newEventForm.ShowDialog()
        If newEventForm.RaceEvent IsNot Nothing Then
            raceEvents.Add(newEventForm.RaceEvent)
            RaceEventDB.SaveRaceEvent(raceEvents)
            Me.FillRaceListBox()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstEvents.SelectedIndex
        If i <> -1 Then
            Dim raceEvent As RaceEvent = raceEvents(i)
            Dim message As String = "Are you sure you want to delete " &
                raceEvent.Title & "?"
            Dim button As DialogResult = MessageBox.Show(message,
                "Confirm Delete", MessageBoxButtons.YesNo)
            If button = DialogResult.Yes Then
                raceEvents.Remove(raceEvent)
                RaceEventDB.SaveRaceEvent(raceEvents)
                Me.FillRaceListBox()
            End If
        End If
    End Sub

    '-----BUTTONS----
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frnMain.Show()
        Me.Hide()
    End Sub
    '-----BUTTONS----
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub


End Class