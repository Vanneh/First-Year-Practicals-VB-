' *****************************************************************************
' Surname, Initials: Kuni, D
' Student Number: 201320596
' Practical: P07
' Class name: ComedyProduction
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class ComedyProduction
    Inherits Production
    Implements iWinning
#Region "Attributes"
    Private _NumberOfComedians As Integer
    Private _AwardWinningStaff As Integer
    Private _PreviousAwards As Integer
#End Region
   public Function CalculateScore() As Double Implements iWinning.CalculateScore
        Return AveAudience * ((_AwardWinningStaff + _PreviousAwards) / 2) + _NumberOfComedians
    End Function
    Public Property NumberOfComedians As Integer
        Get
            Return _NumberOfComedians
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _NumberOfComedians = value
            End If
        End Set
    End Property
    Public Property NumberOfAwardWinningStaff As Integer Implements iWinning.NumberOfAwardWinningStaff
        Get
            Return _AwardWinningStaff
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _AwardWinningStaff = value
            End If
        End Set
    End Property
    Public Property NumberOfPreviousAwards As Integer Implements iWinning.NumberOfPreviousAwards
        Get
            Return _PreviousAwards
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _PreviousAwards = value
            End If
        End Set
    End Property
    Public Sub New(name As String, NumberOfComedians As Integer, NumberOfAwardWinningStaff As Integer, NumberOfPreviousAwards As Integer, ParamArray AudienceNumbers() As Integer)
        'sets all neccessary input data 
        MyBase.New(name, AudienceNumbers)
        Me.NumberOfComedians = NumberOfComedians
        Me.NumberOfAwardWinningStaff = NumberOfAwardWinningStaff
        Me.NumberOfPreviousAwards = NumberOfPreviousAwards
    End Sub
    Public Overrides Function DisplayDetails() As String
        ' displays all neccessary data 
        Return MyBase.DisplayDetails() + "Number Of Award Winning Staff : " + CStr(NumberOfAwardWinningStaff) + Environment.NewLine + "Number Of Previous Awards : " + CStr(NumberOfPreviousAwards) + Environment.NewLine + "Number Of Comedians : " + CStr(NumberOfComedians) + Environment.NewLine
    End Function
End Class
