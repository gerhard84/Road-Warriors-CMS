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
            result.EvntName = columns(0)
            result.EvntDate = columns(1)
            result.EvntLocation = columns(2)
            result.MemID = columns(3)
            result.MemName = columns(4)
            result.MemSurName = columns(5)
            result.RunTime = columns(6)
            results.Add(result)
        Loop

        textIn.Close()

        Return results

    End Function

    Public Shared Sub SaveResult(results As List(Of Result))

        Dim textOut As New StreamWriter(
            New FileStream(Path, FileMode.Create, FileAccess.Write))

        For Each result As Result In results
            textOut.Write(result.EvntName & "|")
            textOut.Write(result.EvntDate & "|")
            textOut.Write(result.EvntLocation & "|")
            textOut.Write(result.MemID & "|")
            textOut.Write(result.MemName & "|")
            textOut.Write(result.MemSurName & "|")
            textOut.Write(result.RunTime)
        Next

        textOut.Close()
    End Sub

End Class