Public Class frmMember
    Dim members As List(Of Member)

    Private Sub formMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        members = MemberDB.GetMember
        Me.FillMemberListBox()
    End Sub

    Private Sub FillRaceListBox()
        lstMembers.Items.Clear()
        For Each p As Member In members
            lstMembers.Items.Add(p.GetDisplayText(vbTab))
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newMemberForm As New frmNewMember
        newMemberForm.ShowDialog()
        If newMemberForm.Member IsNot Nothing Then
            members.Add(newMemberForm.Members)
            MemberDB.SaveMember(members)
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