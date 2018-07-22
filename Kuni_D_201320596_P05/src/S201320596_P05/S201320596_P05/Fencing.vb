' ********************************************************************************* 
'  Surname, Initials: Kuni, D
'  Student Number:  201320596
'  Practical: P05
'  Class name: Fencing
' *********************************************************************************  
Option Strict On
Option Explicit On
Option Infer Off
Public Class Fencing
    Inherits CommercialCrime
    Private fMOG As Double
    Public Property MOG As Double
        Get
            Return fMOG
        End Get
        Set(value As Double)
            fMOG = value
        End Set
    End Property
    Public Overrides Function CalcSuccessFactor(SuccessRate As Integer) As Double
        Return SuccessRate - MOG
    End Function
    Public Sub New()
        CaseID = ""
        OfficerRank = ""
        OfficerSurname = ""
        loss = 0
        fMOG = 0
    End Sub
End Class
