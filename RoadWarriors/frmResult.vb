Imports System.IO
Public Class frmResult
    Dim results As List(Of Result)

    Private Sub frmResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        results = ResultDB.GetResult
        Me.FillResultListBox()
    End Sub

    Private Sub FillResultListBox()
        lstResults.Items.Clear()
        For Each p As Result In results
            lstResults.Items.Add(p.GetDisplayText(vbTab))
        Next
    End Sub
    '-----ADD BUTTON----
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newResultForm As New frmResultAdd
        newResultForm.ShowDialog()
        If newResultForm.Result IsNot Nothing Then
            results.Add(newResultForm.Result)
            ResultDB.SaveResult(results)
            Me.FillResultListBox()
        End If
    End Sub
    '-----DELETE BUTTON----
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstResults.SelectedIndex
        If i <> -1 Then
            Dim result As Result = results(i)
            Dim message As String = "Are you sure you want to delete " &
                result.MemID & "?"
            Dim button As DialogResult = MessageBox.Show(message,
                "Confirm Delete", MessageBoxButtons.YesNo)
            If button = DialogResult.Yes Then
                results.Remove(result)
                ResultDB.SaveResult(results)
                Me.FillResultListBox()
            End If
        End If
    End Sub




    'Private Sub FormResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'Try
    '    '    ComboBox1.Items.Clear()
    '    '    ComboBox1.Items.AddRange(File.ReadAllLines("MemberDB.txt"))
    '    'Catch ex As Exception
    '    '    MsgBox("Oops")
    '    'End Try
    '    Me.Refresh()

    '    Dim myStreamReader As System.IO.StreamReader = New System.IO.StreamReader("MemberDB.txt")

    '    Dim lines As String() = myStreamReader.ReadToEnd().Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
    '    Dim providers = (From line In lines
    '                     Let parts = line.Split("|"c)
    '                     Select New With {.MemID = parts(0),
    '                                        .Name = parts(1),
    '                         .Surname = parts(1),
    '                         .Dob = parts(1),
    '                         .Gender = parts(1),
    '                         .JoinDate = parts(1)}).ToArray()

    '    ComboBox1.DisplayMember = "Name"
    '    ComboBox1.DataSource = providers

    '    ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
    '    ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems


    '    myStreamReader.Close()
    '    Me.Refresh()
    'End Sub







    '-----BACK BUTTON----
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frnMain.Show()
        Me.Hide()
    End Sub
    '-----EXIT BUTTON----
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub


End Class