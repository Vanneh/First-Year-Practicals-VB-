' ***************************************************************************** 
'  Surname, Initials:  Kuni, D
'  Student Number:  201320596
'  Practical: P10 
'  Class name: cfacility
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class cFacility
#Region "Attributes"
    Private _Name As String
    Private _ID As Integer
    Private _Popularity As Integer
    Private _Lockers As Boolean
#End Region
    Public Function DeterminePopularityFactor() As Double
        If IsOdd() Then
            Return _Popularity * 1.5
        Else
            Return _Popularity
        End If
    End Function
    Private Function IsOdd() As Boolean
        If _ID Mod 2 = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub New(_Name As String, _ID As Integer, _Popularity As Integer, _Lockers As Boolean)
        Me._Name = _Name
        Me._ID = _ID
        Me._Popularity = _Popularity
        Me._Lockers = _Lockers
    End Sub
    Public Function display() As String
        display = "ID Of Facility : " + CStr(_ID) + vbNewLine
        display += "Name Of Facility : " + _Name + vbNewLine
        display += "Needs Lockers : " + NeedsLocker() + vbNewLine
        display += "Popularity : " + CStr(_Popularity) + vbNewLine
    End Function
    Private Function NeedsLocker() As String
        If _Lockers Then
            Return "Yes"
        Else
            Return "No"
        End If
    End Function
End Class
