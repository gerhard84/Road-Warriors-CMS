Imports System.IO
Imports System
Public Class frnMain
    '-----BUTTONS----
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        frmResult.Show()
        Me.Hide()
    End Sub
    '-----BUTTONS----
    Private Sub btnManEvent_Click(sender As Object, e As EventArgs) Handles btnManEvent.Click
        frmEvent.Show()
        Me.Hide()
    End Sub
    '-----BUTTONS----
    Private Sub btnManMembers_Click(sender As Object, e As EventArgs) Handles btnManMembers.Click
        frmMember.Show()
        Me.Hide()
    End Sub
    '-----BUTTONS----
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    '-----MENU STRIP-----
    Private Sub RaceResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaceResultsToolStripMenuItem.Click
        frmResult.Show()
        Me.Hide()
    End Sub

    Private Sub ManageEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEventsToolStripMenuItem.Click
        frmEvent.Show()
        Me.Hide()
    End Sub

    Private Sub ManageMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMembersToolStripMenuItem.Click
        frmMember.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub CreateDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateDatabaseToolStripMenuItem.Click
        Dim memberDB = "MemberDB.txt"
        Dim eventDB = "RaceEventsDB.txt"
        Dim resultDB = "ResultDB.txt"
        If File.Exists(memberDB) = True Then
            MsgBox("Members Database already exists!!!")
        Else
            File.Create(memberDB)
            MsgBox("Members Database Created")
        End If

        If File.Exists(eventDB) = True Then
            MsgBox("Events Database already exists!!!")
        Else
            File.Create(eventDB)
            MsgBox("Events Database Created")
        End If

        If File.Exists(resultDB) = True Then
            MsgBox("Results Database already exists!!!")
        Else
            File.Create(resultDB)
            MsgBox("Results Database Created")
        End If
    End Sub

    Private Sub DeleteDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDBToolStripMenuItem.Click
        If MsgBox("This will permantly delete the Members Database, Are you sure?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim memberDB = "MemberDB.txt"
            If File.Exists(memberDB) = True Then
                File.Delete(memberDB)
                MsgBox("Members Database Deleted")
            Else
                MsgBox("There is no Members Database to delete")
            End If
        End If

        If MsgBox("This will permantly delete the Events Database, Are you sure?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim eventDB = "RaceEventsDB.txt"
            If File.Exists(eventDB) = True Then
                File.Delete(eventDB)
                MsgBox("Events Database Deleted")
            Else
                MsgBox("There is no Events Database to delete")
            End If
        End If

        If MsgBox("This will permantly delete the Results Database, Are you sure?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim resultDB = "ResultDB.txt"
            If File.Exists(resultDB) = True Then
                File.Delete(resultDB)
                MsgBox("Results Database Deleted")
            Else
                MsgBox("There is no Results Database to delete")
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created by: Gerhard Goossens (54808189)", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
