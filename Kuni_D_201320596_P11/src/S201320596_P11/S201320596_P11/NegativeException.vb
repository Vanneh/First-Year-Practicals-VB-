' *****************************************************************************
' Surname, Initials:Kuni, D
' Student Number:201320596
' Practical: P11
' Class name: NegativeException
' *****************************************************************************
Option Strict On
Option Infer Off
Option Explicit On
Public Class NegativeException
    Inherits Exception
    Public Sub New(cause As String)
        MyBase.New("You Have enter a Negative Value for the input of " + cause)
    End Sub
End Class
