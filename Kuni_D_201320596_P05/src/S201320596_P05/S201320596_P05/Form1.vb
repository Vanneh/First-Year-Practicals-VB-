' ********************************************************************************* 
'  Surname, Initials:  Kuni, D
'  Student Number:  201320596
'  Practical: P05
'  Class name: frmUPD
' *********************************************************************************  
Option Explicit On
Option Strict On
Option Infer Off
Public Class frmUPD
#Region "Variable Declarations "
    Private Frauds() As Fraud
    Private Fences() As Fencing
    Private launderies() As Laundering
    Private nfe, nfr, nl As Integer
#End Region
    Private Sub btndisplayfr_Click(sender As Object, e As EventArgs) Handles btndisplayfr.Click
        'displays all necessary data values for fraud cases
        Dim answer As Double
        Dim rate As Integer
        grdDisplay.Cols = nfr + 1
        lblgrid.Text = "A table showing all the Fraud Case details"
        For i As Integer = 1 To nfr
            pig(i, 0, "Case " + CStr(i))
            pig(i, 1, Frauds(i).CaseID)
            pig(i, 2, Frauds(i).OfficerRank + Space(1) + Frauds(i).OfficerSurname)
            pig(i, 3, CStr(Frauds(i).loss))
            Rate = Frauds(i).CalcOfficerSuccess 'stores value , calls the function once
            pig(i, 4, CStr(Math.Round(Rate, 2)))
            answer = 0
            Frauds(i).CalcRecovery(Frauds(i).CalcSuccessFactor(rate), answer)
            pig(i, 5, CStr(Math.Round(answer)))
        Next
    End Sub

    Private Sub btndisplayfe_Click(sender As Object, e As EventArgs) Handles btndisplayfe.Click
        'displays all necessary data values for fencing cases
        Dim answer As Double
        Dim rate As Integer
        grdDisplay.Cols = nfe + 1
        lblgrid.Text = "A table showing all the Fencing Case details"
        For i As Integer = 1 To nfe
            pig(i, 0, "Case " + CStr(i))
            pig(i, 1, Fences(i).CaseID)
            pig(i, 2, Fences(i).OfficerRank + Space(1) + Fences(i).OfficerSurname)
            pig(i, 3, CStr(Fences(i).loss))
            rate = Fences(i).CalcOfficerSuccess
            pig(i, 4, CStr(Math.Round(rate, 2)))
            answer = 0
            Fences(i).CalcRecovery(Fences(i).CalcSuccessFactor(rate), answer)
            pig(i, 5, CStr(Math.Round(answer)))
        Next
    End Sub

    Private Sub btndisplayl_Click(sender As Object, e As EventArgs) Handles btndisplayl.Click
        'displays all necessary data values for laundry cases
        Dim answer As Double
        Dim rate As Integer
        grdDisplay.Cols = nl + 1
        lblgrid.Text = "A table showing all the Laundry Case details"
        For i As Integer = 1 To nl
            pig(i, 0, "Case " + CStr(i))
            pig(i, 1, launderies(i).CaseID)
            pig(i, 2, launderies(i).OfficerRank + Space(1) + launderies(i).OfficerSurname)
            pig(i, 3, CStr(launderies(i).loss))
            rate = launderies(i).CalcOfficerSuccess 'stores value , calls the function once
            pig(i, 4, CStr(Math.Round(rate, 2)))
            answer = 0
            launderies(i).CalcRecovery(launderies(i).CalcSuccessFactor(rate), answer)
            pig(i, 5, CStr(Math.Round(answer)))
        Next
    End Sub
End Class
