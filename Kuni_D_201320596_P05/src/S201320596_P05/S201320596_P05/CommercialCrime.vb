' ********************************************************************************* 
'  Surname, Initials: Kuni, D
'  Student Number:  201320596
'  Practical: P05
'  Class name: CommercialCrime 
' *********************************************************************************  
Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class CommercialCrime
#Region "Attributes"
    Protected iCaseID As String
    Protected iOfficerSurname As String
    Protected iOfficerRank As String
    Protected iLoss As Double
#End Region
#Region "Propert methods"
    Public Property CaseID As String
        Get
            Return iCaseID
        End Get
        Set(value As String)
            iCaseID = value
        End Set
    End Property
    Public Property OfficerSurname As String
        Get
            Return iOfficerSurname
        End Get
        Set(value As String)
            iOfficerSurname = value
        End Set
    End Property
    Public Property OfficerRank As String
        Get
            Return iOfficerRank
        End Get
        Set(value As String)
            iOfficerRank = value
        End Set
    End Property
    Public Property loss As Double
        Get
            Return iLoss
        End Get
        Set(value As Double)
            iLoss = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Function CalcOfficerSuccess() As Integer
        Return CInt(Math.Floor((100 - 10 + 1) * Rnd())) + 10
    End Function
    Public MustOverride Function CalcSuccessFactor(SuccessRate As Integer) As Double 'forces derived classes to edit code
    Public Sub CalcRecovery(ByVal successfactor As Double, ByRef ans As Double)
        ans = (successfactor / 100) * loss
    End Sub
#End Region
End Class
