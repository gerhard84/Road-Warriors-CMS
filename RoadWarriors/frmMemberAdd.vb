Public Class frmMemberAdd

    Public Member As Member

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Member = New Member(12, txtName.Text, txtSurname.Text, CDate(dteDob.Text), "Male", CDate(Date.Now.Date))
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmMemberAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class