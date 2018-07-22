' ********************************************************************************* 
'  Surname, Initials:  Kuni, D
'  Student Number:  201320596
'  Practical: P05
'  Class name: frmUPD
' *********************************************************************************  
Option Explicit On
Option Strict On
Option Infer Off
Partial Class frmUPD
    Private Sub pig(c As Integer, r As Integer, t As String) 'stands for place in grid
        grdDisplay.Col = c
        grdDisplay.Row = r
        grdDisplay.Text = t
    End Sub
    Private Sub frmUPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        grdDisplay.set_ColWidth(0, 120)
        pig(0, 1, "Case ID")
        pig(0, 2, "Investigating Officer")
        pig(0, 3, "Value of Loss")
        pig(0, 4, "Officer's Success Rate")
        pig(0, 5, "Value Recovered")
    End Sub
    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        nfr = CInt(txtfraud.Text)
        nfe = CInt(txtfencing.Text)
        nl = CInt(txtlaundering.Text)
        ReDim Frauds(nfr)
        ReDim Fences(nfe)
        ReDim launderies(nl)
        MsgBox("Program settings have been set", MsgBoxStyle.OkOnly, "Settings altered")
    End Sub
#Region "Inputted Data buttons"
    Private Sub btnfraud_Click(sender As Object, e As EventArgs) Handles btnfraud.Click
        'gets all necessary values for fraud cases
        For i As Integer = 1 To nfr
            Frauds(i) = New Fraud
            Frauds(i).CaseID = InputBox("Please enter the Case ID for Fraud case " + CStr(i), "Fraud case " + CStr(i))
            Frauds(i).OfficerSurname = InputBox("Please enter the Investigating Officer Surname for Fraud case " + CStr(i), "Fraud case " + CStr(i))
            Frauds(i).OfficerRank = InputBox("Please enter the Investigating Officer Rank for Fraud case " + CStr(i), "Fraud case " + CStr(i))
            Frauds(i).loss = CDbl(InputBox("Please enter the Value of Loss for Fraud case " + CStr(i), "Fraud case " + CStr(i)))
            Frauds(i).Duration = CInt(InputBox("Please enter the Days since crime took place for Fraud case " + CStr(i), "Fraud case " + CStr(i)))
        Next i
        MsgBox("All necessary data has been entered for all fraud cases", MsgBoxStyle.OkOnly, "fraud cases")
    End Sub
    Private Sub btnfence_Click(sender As Object, e As EventArgs) Handles btnfence.Click
        'gets all necessary values for fence cases
        For i As Integer = 1 To nfe
            Fences(i) = New Fencing
            Fences(i).CaseID = InputBox("Please enter the Case ID for Fencing case " + CStr(i), "Fencing case " + CStr(i))
            Fences(i).OfficerSurname = InputBox("Please enter the Investigating Officer Surname for Fencing case " + CStr(i), "Fencing case " + CStr(i))
            Fences(i).OfficerRank = InputBox("Please enter the Investigating Officer Rank for Fencing case " + CStr(i), "Fencing case " + CStr(i))
            Fences(i).loss = CDbl(InputBox("Please enter the Value of Loss for Fencing case " + CStr(i), "Fencing case " + CStr(i)))
            Fences(i).MOG = CInt(InputBox("Please enter the Mobility of Goods(value between 1-10) for Fencing case " + CStr(i), "Fencing case " + CStr(i)))
        Next i
        MsgBox("All necessary data has been entered for all fencing cases", MsgBoxStyle.OkOnly, "fencing cases")
    End Sub
    Private Sub btnlaunder_Click(sender As Object, e As EventArgs) Handles btnlaunder.Click
        'gets all necessary values for laurndry cases
        For i As Integer = 1 To nl
            launderies(i) = New Laundering
            launderies(i).CaseID = InputBox("Please enter the Case ID for Laundering case " + CStr(i), "Laundering case " + CStr(i))
            launderies(i).OfficerSurname = InputBox("Please enter the Investigating Officer Surname for Laundering case " + CStr(i), "Laundering case " + CStr(i))
            launderies(i).OfficerRank = InputBox("Please enter the Investigating Officer Rank for Laundering case " + CStr(i), "Laundering case " + CStr(i))
            launderies(i).loss = CDbl(InputBox("Please enter the Value of Loss for Laundering case " + CStr(i), "Laundering case " + CStr(i)))
            launderies(i).numbCurrencies = CInt(InputBox("Please enter the Number of different currencies involved for Laundering case " + CStr(i), "Laundering case " + CStr(i)))
            launderies(i).numbAccounts = CInt(InputBox("Please enter the Number of accountants involved for Laundering case " + CStr(i), "Laundering case " + CStr(i)))
        Next i
        MsgBox("All necessary data has been entered for all laundry cases", MsgBoxStyle.OkOnly, "laundry cases")
    End Sub
#End Region
End Class
