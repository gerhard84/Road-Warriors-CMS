Public Class frmResultAdd
    Public Result As Result

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub frmResultAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    autocompleteList.Add(foundMember)

                    Me.txtMemSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
                    Me.txtMemSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    Me.txtMemSearch.AutoCompleteCustomSource = autocompleteList
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
                    Me.txtMemSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    Me.txtMemSearch.AutoCompleteCustomSource = autocompleteList
                Next
            End If
        Next

    End Sub
End Class