Public Class frmMemberAdd

    Public Member As Member

    Dim memID = "RW" & GetRandom(1000, 9999)
    Dim gender As String

    Private Sub frmMemberAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMemID.Text = memID
    End Sub

    'RANDOM NUM GEN
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'RADIO BUTTON
        If (rbtnMale.Checked) Then
            gender = "Male"
        ElseIf (rbtnFemale.Checked) Then
            gender = "Female"
        End If

        Member = New Member(memID, txtName.Text, txtSurname.Text, CDate(dteDob.Text), gender, CDate(Date.Now.Date))
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub


End Class