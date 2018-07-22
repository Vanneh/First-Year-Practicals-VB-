' *****************************************************************************
' Surname, Initials:Kuni, D
' Student Number:201320596
' Practical: P11
' Class name: cRep
' *****************************************************************************
Option Strict On
Option Infer Off
Option Explicit On
<Serializable> Public Class cRep
    Inherits cMember
#Region "Attributes"
    Private _Popularity As Integer
    Private _years As Integer
#End Region
#Region "Methods"
    Public Property Popularity As Integer
        Get
            Return _Popularity
        End Get
        Set(value As Integer)
            _Popularity = checkval(value)
        End Set
    End Property
    Public Property Years As Integer
        Get
            Return _years
        End Get
        Set(value As Integer)
            _years = checkval(value)
        End Set
    End Property
    Public Overrides Function GiveBudgetProposal() As Double
        Return _DesiredBudget * (_Popularity / _years)
    End Function
    Public Sub New(Name As String, Reputation As Integer, Desiredbudget As Double, Popularity As Integer, years As Integer)
        MyBase.New(Name, Reputation, Desiredbudget)
        Me.Popularity = Popularity
        Me.Years = years
    End Sub
#End Region
End Class
