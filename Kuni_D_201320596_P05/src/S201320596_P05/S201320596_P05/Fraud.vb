' ********************************************************************************* 
'  Surname, Initials: Kuni, D
'  Student Number:  201320596
'  Practical: P05
'  Class name: Fraud
' *********************************************************************************  
Option Strict On
Option Explicit On
Option Infer Off
Public Class Fraud
    Inherits CommercialCrime
    Private fDuration As Integer 'Days since crime took place
    Public Property Duration As Integer
        Get
            Return fDuration
        End Get
        Set(value As Integer)
            If value > 0 Then
                fDuration = value
            End If
        End Set
    End Property
    Public Overrides Function CalcSuccessFactor(SuccessRate As Integer) As Double
        Return SuccessRate / Duration
    End Function
    Public Sub New()
        CaseID = ""
        OfficerRank = ""
        OfficerSurname = ""
        loss = 0
        fDuration = 0
    End Sub
End Class
