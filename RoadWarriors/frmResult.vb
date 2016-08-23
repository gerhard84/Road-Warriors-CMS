Imports System.IO
Public Class frmResult



    Private Sub FormResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    ComboBox1.Items.Clear()
        '    ComboBox1.Items.AddRange(File.ReadAllLines("MemberDB.txt"))
        'Catch ex As Exception
        '    MsgBox("Oops")
        'End Try
        Me.Refresh()

        Dim myStreamReader As System.IO.StreamReader = New System.IO.StreamReader("MemberDB.txt")

        Dim lines As String() = myStreamReader.ReadToEnd().Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim providers = (From line In lines
                         Let parts = line.Split("|"c)
                         Select New With {.MemID = parts(0),
                                            .Name = parts(1),
                             .Surname = parts(1),
                             .Dob = parts(1),
                             .Gender = parts(1),
                             .JoinDate = parts(1)}).ToArray()

        ComboBox1.DisplayMember = "Name"
        ComboBox1.DataSource = providers

        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems


        myStreamReader.Close()
        Me.Refresh()
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