Imports System.IO

Public Class ResultDB

    Private Const Path As String = "ResultDB.txt"

    Public Shared Function GetResult() As List(Of Result)

        Dim textIn As New StreamReader(
            New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim results As New List(Of Result)

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns As String() = row.Split(CChar("|"))
            Dim result As New Result
            result.MemID = columns(0)
            result.MemName = columns(1)
            result.EventName = columns(2)
            result.RunTime = columns(3)
            results.Add(result)
        Loop

        textIn.Close()

        Return results

    End Function

    Public Shared Sub SaveResult(results As List(Of Result))

        Dim textOut As New StreamWriter(
            New FileStream(Path, FileMode.Create, FileAccess.Write))

        For Each result As Result In results
            textOut.Write(result.MemID & "|")
            textOut.Write(result.MemName & "|")
            textOut.Write(result.EventName & "|")
            textOut.Write(result.RunTime)
        Next

        textOut.Close()
    End Sub

End Class