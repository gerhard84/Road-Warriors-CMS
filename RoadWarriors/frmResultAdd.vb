Public Class frmResultAdd
    Public Result As Result

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub frmResultAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Member Search
        Dim autoMemberList As New AutoCompleteStringCollection
        Dim foundMember As String
        Dim memSearch As String = txtMemSearch.Text
        Dim aryCommaSplit() As String
        Dim aryLineRead() As String
        Dim intArray As Integer
        Dim currentline As Integer
        Dim i As Integer
        Dim lines = IO.File.ReadAllLines("MemberDB.txt")
        For i = 0 To lines.Length - 1
            currentline = i
            aryCommaSplit = lines(i).Split("|")
            aryLineRead = aryCommaSplit
            'Searches for word entered in txtMemSearch within the open file
            If lines(i).Contains(memSearch) Then
                For intArray = 0 To UBound(aryLineRead)
                    foundMember = aryCommaSplit(0)
                    autoMemberList.Add(foundMember)
                    Me.txtMemSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
                    Me.txtMemSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    Me.txtMemSearch.AutoCompleteCustomSource = autoMemberList
                Next
            End If
        Next
        '-----------------------------------------------------------------------------
        'Event Search
        Dim autoEventList As New AutoCompleteStringCollection
        Dim foundEvent As String
        Dim eventSearch As String = txtEventSearch.Text
        Dim evntAryCommaSplit() As String
        Dim evntAryLineRead() As String
        Dim evntIntArray As Integer
        Dim evntCurrentline As Integer
        Dim evnt As Integer
        Dim evntLines = IO.File.ReadAllLines("RaceEventsDB.txt")
        For evnt = 0 To evntLines.Length - 1
            evntCurrentline = evnt
            evntAryCommaSplit = evntLines(evnt).Split("|")
            evntAryLineRead = evntAryCommaSplit
            'Searches for word entered in txtMemSearch within the open file
            If evntLines(evnt).Contains(eventSearch) Then
                For evntIntArray = 0 To UBound(evntAryLineRead)
                    foundEvent = evntAryCommaSplit(0)
                    autoEventList.Add(foundEvent)
                    Me.txtEventSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
                    Me.txtEventSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    Me.txtEventSearch.AutoCompleteCustomSource = autoEventList
                Next
            End If
        Next


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim autocompleteList As New AutoCompleteStringCollection
        Dim foundMember As String
        Dim memSearch As String = txtMemSearch.Text
        Dim aryCommaSplit() As String
        Dim aryLineRead() As String
        Dim intArray As Integer
        Dim currentline As Integer
        Dim i As Integer
        Dim lines = IO.File.ReadAllLines("MemberDB.txt")
        For i = 0 To lines.Length - 1
            currentline = i
            aryCommaSplit = lines(i).Split("|")
            aryLineRead = aryCommaSplit
            'Searches for word entered in txtMemSearch within the open file
            If lines(i).Contains(memSearch) Then
                For intArray = 0 To UBound(aryLineRead)
                    foundMember = aryCommaSplit(0)
                    lblName.Text = aryCommaSplit(1)
                    lblSurn.Text = aryCommaSplit(2)
                    autocompleteList.Add(foundMember)

                    Me.txtMemSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
                    Me.txtMemSearch.AutoCompleteMode = AutoCompleteMode.Suggest
                    Me.txtMemSearch.AutoCompleteCustomSource = autocompleteList
                Next
            End If
        Next

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnEvntSearch_Click(sender As Object, e As EventArgs) Handles btnEvntSearch.Click
        'Event Search
        Dim autoEventList As New AutoCompleteStringCollection()
        Dim foundEvent As String
        Dim eventSearch As String = txtEventSearch.Text
        Dim evntAryCommaSplit() As String
        Dim evntAryLineRead() As String
        Dim evntIntArray As Integer
        Dim evntCurrentline As Integer
        Dim evnt As Integer
        Dim evntLines = IO.File.ReadAllLines("RaceEventsDB.txt")
        For evnt = 0 To evntLines.Length - 1
            evntCurrentline = evnt
            evntAryCommaSplit = evntLines(evnt).Split("|")
            evntAryLineRead = evntAryCommaSplit
            'Searches for word entered in txtMemSearch within the open file
            If evntLines(evnt).Contains(eventSearch) Then
                For evntIntArray = 0 To UBound(evntAryLineRead)
                    foundEvent = evntAryCommaSplit(0)
                    'lblName.Text = evntAryCommaSplit(1)
                    lblLocation.Text = evntAryCommaSplit(3)
                    lblEvntDate.Text = evntAryCommaSplit(1)
                    autoEventList.Add(foundEvent)
                    Me.txtEventSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
                    Me.txtEventSearch.AutoCompleteMode = AutoCompleteMode.Suggest
                    Me.txtEventSearch.AutoCompleteCustomSource = autoEventList
                Next
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim runTime As String = txtHr.Text & ":" & txtMin.Text & ":" & txtSec.Text & ":" & txtMs.Text
        Result = New Result(txtEventSearch.Text, CDate(lblEvntDate.Text), lblLocation.Text,
                                   txtMemSearch.Text, lblName.Text, lblSurn.Text, runTime)
        Me.Close()
    End Sub
End Class