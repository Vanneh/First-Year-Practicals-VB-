' ********************************************************************************* 
'  Surname, Initials: Kuni, D
'  Student Number:  201320596
'  Practical: P05
'  Class name: Laundering
' *********************************************************************************  
Option Strict On
Option Explicit On
Option Infer Off
Public Class Laundering
    Inherits CommercialCrime
#Region "Attributes"
    Private Currencies As Integer
    Private Accounts As Integer
#End Region
#Region "Property Methods"
    Public Property numbCurrencies As Integer
        Get
            Return Currencies
        End Get
        Set(value As Integer)
            If value > 0 Then
                Currencies = value
            End If
        End Set
    End Property
    Public Property numbAccounts As Integer
        Get
            Return Accounts
        End Get
        Set(value As Integer)
            If value > 0 Then
                Accounts = value
            End If
        End Set
    End Property
#End Region
    Public Overrides Function CalcSuccessFactor(SuccessRate As Integer) As Double
        Return (Currencies / Accounts) + SuccessRate
    End Function
    Public Sub New()
        CaseID = ""
        OfficerRank = ""
        OfficerSurname = ""
        loss = 0
        Currencies = 0
        Accounts = 0
    End Sub
End Class
