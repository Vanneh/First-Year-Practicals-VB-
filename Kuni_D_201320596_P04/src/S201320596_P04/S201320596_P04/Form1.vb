' *****************************************************************************
' Surname, Initials: Kuni, D
' Student Number: 201320596
' Practical: P04
' Class name:  frmesl
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmesl
    Private Disasters() As Disaster
    Private Sub btnsetup_Click(sender As Object, e As EventArgs) Handles btnsetup.Click
        Dim nD As Integer = CInt(InputBox("Please enter the number of Disasters", "Number of Disasters")) - 1 'gets the number of disasters
        ReDim Disasters(nD)
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        'in here , neccessary data is obtained from the user
        Dim nH, level As Integer
        For i As Integer = 0 To Disasters.Length - 1
            nH = 0
            level = CInt(InputBox("Please enter a number between 1 to 10 for the level of disaster  " + CStr(i + 1), "Level of disaster"))
            nH = CInt(InputBox("Please enter the number of Emergancy workers for Disaster " + CStr(i + 1), "Number of emergancy workers")) - 1
            Disasters(i) = New Disaster(level, nH)
            For r As Integer = 0 To nH
                Disasters(i).Heroes(r).surname = InputBox("Please enter the surname of Emergancy worker " + CStr(r + 1), "Disaster " + CStr(i + 1))
                Disasters(i).Heroes(r).experiance = CDbl(InputBox("Please enter the number of years of experience for Emergancy worker " + Disasters(i).Heroes(r).surname, "Disaster " + CStr(i + 1)))
        Next r, i
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Dim index As Integer = CInt(InputBox("Please enter the number of the disaster's roster to view ", "Which Disaster?")) - 1
        'gets the specified array number to display the data
        txtroster.Text = Disasters(index).DisplayRoster
        txtsuccess.Text = CStr(Disasters(index).CalculateTeamSuccess)
    End Sub

    Private Sub frmesl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
