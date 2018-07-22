' ********************************************************************************* 
'  Surname, Initials:  Kuni, D
'  Student Number: 201320596 
'  Practical: P02 
'  Class name: frmsme
' *********************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmsme 'stand for Student Mark Evaluator
#Region "Variable Declartion "
    Private the_Student_details() As student_detail_blueprint
    Private numbstu, subz As Integer
#End Region
#Region "Custom Functions and Sub routines"
    Private Sub setup() 'helps with initialization of app
        MsgBox("Please note, to access a students information, enter the student ID of desired student in the display button", MsgBoxStyle.OkOnly, "Please Note!")
        numbstu = CInt(InputBox("Please enter the number of Students in the class", "Number of students")) - 1 'handles any number of students,the number of students is one less to work from position "0" of the array
        ReDim the_Student_details(numbstu) 'resizes the array
        subz = CInt(InputBox("Please enter the number of subjects for students ", "Subjects")) - 1 'handles any number of subjects,the number of subjects is one less to work from position "0" of the array
    End Sub
    Private Function rate(ByVal ave As Double) As Boolean 'checks if student passed the subject or not
        Select Case ave
            Case Is < 50
                Return False 'if student got less thn 50 then it is a failed the semester or year
            Case Else
                Return True ' it is a passed the semester or year
        End Select
    End Function
#End Region
    Private Sub btnsetup_Click(sender As Object, e As EventArgs) Handles btnsetup.Click
        setup() 'sub routine is called
        For i As Integer = 0 To numbstu
            the_Student_details(i) = New student_detail_blueprint(subz) 'instantiation is being done
            the_Student_details(i)._studentID = InputBox("Please enter the ID of student " + CStr(i + 1), "Student " + CStr(i + 1)) 'getting data from the user
            the_Student_details(i)._surname = InputBox("Please enter the Surname of the student ", the_Student_details(i)._studentID) 'getting data from the user
            For r As Integer = 0 To subz
                the_Student_details(i).subject_marks(r) = CInt(InputBox("Please enter subject mark " + CStr(r + 1) + " for student " + the_Student_details(i)._surname, the_Student_details(i)._studentID)) 'getting data from the user
            Next
        Next
    End Sub

    Private Sub btnave_Click(sender As Object, e As EventArgs) Handles btnave.Click
        If subz <= 0 Or numbstu <= 0 Then ' if the user has not setup the app, program will stop user and infrom the user to enter correct values
            MsgBox("Please click te setup application and enter neccessary data", MsgBoxStyle.OkOnly, "ERROR!!!")
        Else
            Dim total As Integer
            For i As Integer = 0 To numbstu
                total = 0 'initialized value
                the_Student_details(i).passed = 0 'initialized value
                For r As Integer = 0 To subz
                    If the_Student_details(i).subject_marks(r) >= 50 Then 'gets the number of subjects passed
                        the_Student_details(i).passed += 1
                    End If
                    total += the_Student_details(i).subject_marks(r)
                Next
                the_Student_details(i).average = total / (subz + 1) 'calculates the average 
            Next
            MsgBox("The Averages have been calculated ", MsgBoxStyle.OkOnly, "Averages") 'since no data is displayed , user will be notified that the average has been calculated
        End If
    End Sub

    Private Sub btnrating_Click(sender As Object, e As EventArgs) Handles btnrating.Click
        If subz <= 0 Or numbstu <= 0 Then ' if the user has not setup the app, program will stop user and infrom the user to enter correct values
            MsgBox("Please click te setup application and enter neccessary data", MsgBoxStyle.OkOnly, "ERROR!!!")
        Else
            For i As Integer = 0 To numbstu
                the_Student_details(i).rating = rate(the_Student_details(i).average) ' it rates the student average and gives an end result of a fail or pass
            Next
            MsgBox("The ratings have been calculated", MsgBoxStyle.OkOnly, "Ratings")
        End If
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        txtdisplay.Text = "" 'clears the textbox
        If subz <= 0 Or numbstu <= 0 Then ' if the user has not setup the app, program will stop user and infrom the user to enter correct values
            MsgBox("Please click te setup application and enter neccessary data", MsgBoxStyle.OkOnly, "ERROR!!!")
        Else
            ' in this button the user will be able to display a students details with the use of there ID
            Dim ID As String = InputBox("Please enter the student ID of the details you wish to view", "Student ID")
            For i As Integer = 0 To numbstu
                If ID = the_Student_details(i)._studentID Then
                    txtdisplay.Text = "Student ID : " + the_Student_details(i)._studentID + vbNewLine + "Surname : " + the_Student_details(i)._surname
                    For r As Integer = 0 To subz
                        txtdisplay.Text += vbNewLine + "Subject " + CStr(r + 1) + " mark: " + CStr(the_Student_details(i).subject_marks(r))
                    Next r
                    txtdisplay.Text += vbNewLine + "Number of subjects Passed : " + CStr(the_Student_details(i).passed)
                    txtdisplay.Text += vbNewLine + "Student Average : " + CStr(Math.Round(the_Student_details(i).average, 2)) 'rounds of the average to avoid recurring numbers
                    If the_Student_details(i).rating = True Then
                        txtdisplay.Text += vbNewLine + "Rating :Student Has Passed"
                    Else
                        txtdisplay.Text += vbNewLine + "Rating :Student Has Failed"
                    End If
                End If
            Next
        End If
    End Sub
End Class
