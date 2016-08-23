Public Class frmMemberAdd

    Public Member As Member

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'RADIO BUTTON
        Dim gender As String
        If (rbtnMale.Checked) Then
            gender = "Male"
        ElseIf (rbtnFemale.Checked) Then
            gender = "Female"
        End If

        Member = New Member(12, txtName.Text, txtSurname.Text, CDate(dteDob.Text), gender, CDate(Date.Now.Date))
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class