Imports System.IO

Public Class MemberDB
    ' Use file in Bin directory
    'Private Const Dir As String = "..\"

    'Private Const Path As String = Dir & "RaceEventsDB.txt"
    Private Const Path As String = "MemberDB.txt"

    Public Shared Function GetMember() As List(Of Member)

        'If Not Directory.Exists(Dir) Then
        '    Directory.CreateDirectory(Dir)
        'End If

        Dim textIn As New StreamReader(
            New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim members As New List(Of Member)

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns As String() = row.Split(CChar("|"))
            Dim member As New Member
            member.MemberID = columns(0)
            member.Name = columns(1)
            member.Surname = columns(2)
            member.DoB = CDate(columns(3))
            member.Gender = columns(4)
            member.JoinDate = CDate(columns(5))
            members.Add(member)
        Loop

        textIn.Close()

        Return members

    End Function

    Public Shared Sub SaveMember(members As List(Of Member))

        Dim textOut As New StreamWriter(
            New FileStream(Path, FileMode.Create, FileAccess.Write))

        For Each member As Member In members
            textOut.Write(member.MemberID & "|")
            textOut.Write(member.Name & "|")
            textOut.Write(member.Surname & "|")
            textOut.Write(member.DoB & "|")
            textOut.Write(member.Gender & "|")
            textOut.WriteLine(member.JoinDate)
        Next

        textOut.Close()
    End Sub

End Class