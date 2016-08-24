'The end user must be able to choose an athlete
'(either through the use of a textbox in which the 
'athletes membership number Is entered, Or by 
'selecting an athletes name from a drop-down list).

'Once the user has selected an athlete, they must be able 
'To record race results For a particular race For that athlete. 
'These results form part Of the permanent history Of the athlete at the club.

'Imports RoadWarriors

Public Class Result

    'Fields
    Public Property m_MemID As String
    Public Property m_MemName As String
    Public Property m_EventName As String
    Public Property m_RunTime As Integer


    'Empty Constructor
    Public Sub New()

    End Sub

    'Custom Constructor
    Public Sub New(memID As String,
                   memName As String,
                   eventName As String,
                   runTime As Integer)
        Me.MemID = memID
        Me.MemName = memName
        Me.EventName = eventName
        Me.RunTime = runTime
    End Sub

    'The MemID Property
    Public Property MemID As String
        Get
            Return m_MemID
        End Get
        Set(value As String)
            m_MemID = value
        End Set
    End Property

    'The MemName Property
    Public Property MemName As String
        Get
            Return m_MemName
        End Get
        Set(value As String)
            m_MemName = value
        End Set
    End Property

    'The EventName Property
    Public Property EventName As String
        Get
            Return m_EventName
        End Get
        Set(value As String)
            m_EventName = value
        End Set
    End Property

    'The RunTime  Property
    Public Property RunTime As Integer
        Get
            Return m_RunTime
        End Get
        Set(value As Integer)
            m_RunTime = value
        End Set
    End Property

    Public Function GetDisplayText(sep As String) As String
        Dim text As String = MemID & sep &
                             MemName & sep &
                             EventName & sep &
                             RunTime
        Return text
    End Function
End Class