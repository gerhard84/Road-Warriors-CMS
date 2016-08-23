Imports System.IO

Public Class MemberDB
    ' Use file in Bin directory
    'Private Const Dir As String = "..\"

    'Private Const Path As String = Dir & "RaceEventsDB.txt"
    Private Const Path As String = "RaceEventsDB.txt"

    Public Shared Function GetRaceEvent() As List(Of RaceEvent)

        'If Not Directory.Exists(Dir) Then
        '    Directory.CreateDirectory(Dir)
        'End If

        Dim textIn As New StreamReader(
            New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim raceEvents As New List(Of RaceEvent)

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns As String() = row.Split(CChar("|"))
            Dim raceEvent As New RaceEvent
            raceEvent.Title = columns(0)
            raceEvent.Time = CDate(columns(1))
            raceEvent.Fee = CDec(columns(2))
            raceEvent.Location = columns(3)
            raceEvent.Distance = CInt(columns(4))
            raceEvents.Add(raceEvent)
        Loop

        textIn.Close()

        Return raceEvents

    End Function

    Public Shared Sub SaveRaceEvent(raceEvents As List(Of RaceEvent))

        Dim textOut As New StreamWriter(
            New FileStream(Path, FileMode.Create, FileAccess.Write))

        For Each raceEvent As RaceEvent In raceEvents
            textOut.Write(raceEvent.Title & "|")
            textOut.Write(raceEvent.Time & "|")
            textOut.Write(raceEvent.Fee & "|")
            textOut.Write(raceEvent.Location & "|")
            textOut.WriteLine(raceEvent.Distance)
        Next

        textOut.Close()
    End Sub

End Class