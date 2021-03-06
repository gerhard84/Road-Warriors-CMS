﻿'1. Title of the event (must be unique).
'2. Date of the event.
'3. Registration Fee.
'4. Location of the event.
'5. Distance.

Imports RoadWarriors

Public Class RaceEvent
    'Fields
    Public Property m_Title As String
    Public Property m_Time As Date
    Public Property m_Fee As Decimal
    Public Property m_Location As String
    Public Property m_Distance As Integer

    'Empty Constructor
    Public Sub New()

    End Sub

    'Custom Constructor
    Public Sub New(title As String,
                   time As Date,
                   fee As Decimal,
                   location As String,
                   distance As Integer)
        Me.Title = title
        Me.Time = time
        Me.Fee = fee
        Me.Location = location
        Me.Distance = distance
    End Sub

    'The Title Property
    Public Property Title As String
        Get
            Return m_Title
        End Get
        Set(value As String)
            m_Title = value
        End Set
    End Property

    'The Time Property
    Public Property Time As Date
        Get
            Return m_Time
        End Get
        Set(value As Date)
            m_Time = value
        End Set
    End Property

    'The Fee Property
    Public Property Fee As Decimal
        Get
            Return m_Fee
        End Get
        Set(value As Decimal)
            m_Fee = value
        End Set
    End Property

    'The Location Property
    Public Property Location As String
        Get
            Return m_Location
        End Get
        Set(value As String)
            m_Location = value
        End Set
    End Property

    'The Distance Property
    Public Property Distance As Integer
        Get
            Return m_Distance
        End Get
        Set(value As Integer)
            m_Distance = value
        End Set
    End Property

    Public Function GetDisplayText(sep As String) As String
        Dim text As String = Title & sep &
                             FormatDateTime(Time) & sep &
                             Location & sep &
                             Distance & sep &
                             FormatCurrency(Fee)
        Return text
    End Function
End Class