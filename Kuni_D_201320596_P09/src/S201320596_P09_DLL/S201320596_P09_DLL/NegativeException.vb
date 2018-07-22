' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: NegativeException
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class NegativeException 'exception for negative values and Zero values among anything
    Inherits Exception
    Public Sub New(NameOfProblemArea As String)
        MyBase.New("The Value you have entered for " + NameOfProblemArea + " was negative or less the and equal to zero , Please try again")
    End Sub
End Class
