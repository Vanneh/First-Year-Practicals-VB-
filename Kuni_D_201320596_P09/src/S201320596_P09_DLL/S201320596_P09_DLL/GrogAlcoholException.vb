' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: GrogAlcoholException
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class GrogAlcoholException
    Inherits Exception
    Public Sub New()
        MyBase.New("Hey!! that Grog's alcohol content is less then 30, enter the record again")
    End Sub
End Class
