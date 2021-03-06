﻿'2. Manage athletes (members) of the club.
'1. Membership number (see 4.2.1),
'2. Name And surname,
'3. Birth date,
'4. Gender,
'5. Date on which the club was joined,
'6. Membership fee amount outstanding.
'7. Races competed
'8. Finish-times for each race.

Imports RoadWarriors

Public Class Member

    'Fields
    Public Property m_MemberID As String
    Public Property m_Name As String
    Public Property m_Surname As String
    Public Property m_DoB As Date
    Public Property m_Gender As String
    Public Property m_JoinDate As Date

    'Empty Constructor
    Public Sub New()

    End Sub

    'Custom Constructor
    Public Sub New(memberID As String,
                   name As String,
                   surname As String,
                   dob As Date,
                   gender As String,
                   joinDate As Date)
        Me.MemberID = memberID
        Me.Name = name
        Me.Surname = surname
        Me.DoB = dob
        Me.Gender = gender
        Me.JoinDate = joinDate
    End Sub

    'The MemberID Property
    Public Property MemberID As String
        Get
            Return m_MemberID
        End Get
        Set(value As String)
            m_MemberID = value
        End Set
    End Property

    'The Name  Property
    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    'The Surname Property
    Public Property Surname As String
        Get
            Return m_Surname
        End Get
        Set(value As String)
            m_Surname = value
        End Set
    End Property

    'The DoB Property
    Public Property DoB As Date
        Get
            Return m_DoB
        End Get
        Set(value As Date)
            m_DoB = value
        End Set
    End Property

    'The Gender Property
    Public Property Gender As String
        Get
            Return m_Gender
        End Get
        Set(value As String)
            m_Gender = value
        End Set
    End Property

    'The JoinDate Property
    Public Property JoinDate As Date
        Get
            Return m_JoinDate
        End Get
        Set(value As Date)
            m_JoinDate = value
        End Set
    End Property

    Public Function GetDisplayText(sep As String) As String
        Dim text As String = MemberID & sep &
                             Name & sep &
                             Surname & sep &
                             FormatDateTime(DoB) & sep &
                             Gender & sep &
                             FormatDateTime(JoinDate)
        Return text
    End Function
End Class