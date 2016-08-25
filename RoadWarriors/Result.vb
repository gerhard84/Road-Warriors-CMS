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
    Public Property m_EvntName As String
    Public Property m_EvntDate As Date
    Public Property m_EvntLocation As String
    Public Property m_MemID As String
    Public Property m_MemName As String
    Public Property m_MemSurName As String
    Public Property m_RunTime As String


    'Empty Constructor
    Public Sub New()

    End Sub

    'Custom Constructor
    Public Sub New(EvntName As String,
                   EvntDate As Date,
                   EvntLocation As String,
                   MemID As String,
                   MemName As String,
                   MemSurName As String,
                   runTime As String)
        Me.EvntName = EvntName
        Me.EvntDate = EvntDate
        Me.EvntLocation = EvntLocation
        Me.MemID = MemID
        Me.MemName = MemName
        Me.MemSurName = MemSurName
        Me.RunTime = runTime
    End Sub

    'The EvntName Property
    Public Property EvntName As String
        Get
            Return m_EvntName
        End Get
        Set(value As String)
            m_EvntName = value
        End Set
    End Property

    'The EvntDate Property
    Public Property EvntDate As Date
        Get
            Return m_EvntDate
        End Get
        Set(value As Date)
            m_EvntDate = value
        End Set
    End Property


    'The EvntLocation Property
    Public Property EvntLocation As String
        Get
            Return m_EvntLocation
        End Get
        Set(value As String)
            m_EvntLocation = value
        End Set
    End Property

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

    'The MemSurName Property
    Public Property MemSurName As String
        Get
            Return m_MemSurName
        End Get
        Set(value As String)
            m_MemSurName = value
        End Set
    End Property

    'The RunTime  Property
    Public Property RunTime As String
        Get
            Return m_RunTime
        End Get
        Set(value As String)
            m_RunTime = value
        End Set
    End Property

    Public Function GetDisplayText(sep As String) As String
        Dim text As String = EvntName & sep &
                             EvntDate & sep &
                             EvntLocation & sep &
                             MemID & sep &
                             MemName & sep &
                             MemSurName & sep &
                             RunTime
        Return text
    End Function
End Class