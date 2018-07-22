' *****************************************************************************
' Surname, Initials: Kuni, D
' Student Number: 201320596
' Practical: P04
' Class name:  EmergencyWorker
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class EmergencyWorker
#Region "Attributes"
    Private eSurname As String
    Private eExperiance As Double
    Private eRank As String
#End Region
#Region "Properties"
    Public Property surname As String
        Get
            Return eSurname
        End Get
        Set(value As String)
            eSurname = value
        End Set
    End Property
    Public Property experiance As Double
        Get
            Return eExperiance
        End Get
        Set(value As Double)
            If value >= 0 Then
                eExperiance = value
            End If
            SetRank() 'calls the sub to set the rank when experience is set 
        End Set
    End Property
    Public ReadOnly Property Rank As String
        Get
            Return eRank
        End Get
    End Property
#End Region
#Region "Methods"
    Private Function LuckRandomiser() As Double
        Return 1 * Rnd()
    End Function
    Private Sub SetRank() 'sets the experience of emergency worker
        Select Case experiance
            Case Is < 3
                eRank = "Private"
            Case 3 To 5
                eRank = "Sergeant"
            Case Is > 5
                eRank = "Lieutenant"
        End Select
    End Sub
    Public Function CalculateSuccess(ByVal difficulty As Integer) As Double
        Dim Luck As Double = LuckRandomiser()
        ' calculates the success rate of the emergency worker by multiplying the difficulty level by a random number and adding 9 6ths of his or her experience
        Return (difficulty * Luck) + (experiance * 1.5)
    End Function
#End Region
    Public Sub New()
        eSurname = ""
        eExperiance = 0
        eRank = "unknown" 'experience is 0 therefore rank is unknown
    End Sub
End Class

