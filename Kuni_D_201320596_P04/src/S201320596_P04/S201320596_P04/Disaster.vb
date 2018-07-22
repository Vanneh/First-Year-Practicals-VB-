' *****************************************************************************
' Surname, Initials: Kuni, D
' Student Number: 201320596
' Practical: P04
' Class name: Disaster
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Disaster
#Region "Attributes"
    Private dID As Integer
    Private dLevel As Integer
    Private _Heroes() As EmergencyWorker
    Private Shared IDcount As Integer = 0 'used to keep track of the number of objects created
#End Region
#Region "Property Methods"
    Public ReadOnly Property ID As Integer
        Get
            Return dID
        End Get
    End Property
    Public WriteOnly Property level As Integer
        Set(value As Integer)
            dLevel = value
        End Set
    End Property
    Public Property Heroes(ByVal index As Integer) As EmergencyWorker
        Get
            Return _Heroes(index)
        End Get
        Set(value As EmergencyWorker)
            _Heroes(index) = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Shared Function GenerateID() As Integer
        IDcount += 1
        Return IDcount
    End Function
    Public Function DisplayRoster() As String
        DisplayRoster = "Disaster ID :" + CStr(ID) + Environment.NewLine 'gets id of disaster
        For i As Integer = 0 To _Heroes.Length - 1 'goes through all workers to collect information
            DisplayRoster += "Emergancy worker Number " + CStr(i + 1) + " : "
            DisplayRoster += Heroes(i).Rank + Space(2) + Heroes(i).surname + Environment.NewLine
            DisplayRoster += "Experience : " + CStr(Heroes(i).experiance) + " years" + Environment.NewLine
        Next
    End Function
    Public Function CalculateTeamSuccess() As Double
        Dim total As Double = 0
        Dim array_size As Integer = _Heroes.Length - 1
        For i As Integer = 0 To array_size
            total += Heroes(i).CalculateSuccess(dLevel) 'total up
        Next
        Return Math.Round(total / (array_size + 1), 2) 'average the total and return rounded off value 
    End Function
#End Region
    Public Sub New(ByVal level As Integer, ByVal NumberofWorkers As Integer)
        dID = GenerateID() 'set ID of disaster
        Me.level = level 'set level of disaster
        ReDim _Heroes(NumberofWorkers)
        For i As Integer = 0 To NumberofWorkers
            _Heroes(i) = New EmergencyWorker 'creates the objects
        Next
    End Sub
End Class
