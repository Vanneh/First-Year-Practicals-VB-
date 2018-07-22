' *****************************************************************************
' Surname, Initials:Kuni, D
' Student Number:201320596
' Practical: P11
' Class name: cMin
' *****************************************************************************
Option Strict On
Option Infer Off
Option Explicit On
<Serializable> Public Class cMin
    Inherits cMember
    Private _portfolio As Integer
#Region "Methods"
    Public Property Portfolio As Integer
        Get
            Return _portfolio
        End Get
        Set(value As Integer)
            _portfolio = checkval(value)
        End Set
    End Property
    Public Overrides Function GiveBudgetProposal() As Double
        Return MyBase.GiveBudgetProposal() * _portfolio
    End Function
    Public Sub New(Name As String, Desiredbudget As Double, Portfolio As Integer)
        MyBase.New(Name, 1, Desiredbudget)
        Me.Portfolio = Portfolio
    End Sub
#End Region
End Class
