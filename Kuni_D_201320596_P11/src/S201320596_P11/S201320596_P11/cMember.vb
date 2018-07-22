' *****************************************************************************
' Surname, Initials:Kuni, D
' Student Number:201320596
' Practical: P11
' Class name: cMember
' *****************************************************************************
Option Strict On
Option Infer Off
Option Explicit On
<Serializable> Public Class cMember
#Region "Attributes"
    Protected _Name As String
    Protected _Reputation As Integer
    Private Shared _Count As Integer
    Protected _DesiredBudget As Double
#End Region
#Region "Methods"
    Protected Function checkval(value As Integer) As Integer
        If value < +10 And value >= 1 Then ' checks for valid value
            Return value
        Else
            Return 1 ' default to one 
        End If
    End Function
    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property
    Private Function CalculateBudgetModifier() As Double
        Return _Reputation * (1 / 10)
    End Function
    Public Overridable Function GiveBudgetProposal() As Double
        Return CalculateBudgetModifier() * _DesiredBudget
    End Function
    Public Function Display() As String
        Dim i As String = Environment.NewLine
        Display = "Members Name : " + _Name + i
        Display += "Reputation Level : " + CStr(_Reputation) + i
        Display += "Desired Budget : " + CStr(_DesiredBudget) + i
        Display += "Proposed Budget : " + CStr(GiveBudgetProposal()) + i
    End Function
    Public Shared Function GetMemberCount() As Integer
        Return _Count
    End Function
    Public Sub New(Name As String, Reputation As Integer, Desiredbudget As Double)
        _Name = Name
        _Reputation = checkval(Reputation)
        _DesiredBudget = Desiredbudget
        _Count += 1
    End Sub
#End Region
End Class
