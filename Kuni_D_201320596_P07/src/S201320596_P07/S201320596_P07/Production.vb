' *****************************************************************************
' Surname, Initials: Kuni, D
' Student Number: 201320596
' Practical: P07
' Class name: Production
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class Production
    Private _name As String
    Protected AveAudience As Double
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Public Overridable Function DisplayDetails() As String
        ' displays all neccessary data
        Return "The Name of the production : " + Name + Environment.NewLine + "The average audience numbers : " + CStr(Math.Round(AveAudience, 2)) + Environment.NewLine
    End Function
    Private Function CalculateAveAudience(ByRef arr() As Integer) As Double
        For Each Val As Integer In arr
            If Val < 0 Then
                Val = 0
            End If
            CalculateAveAudience += Val
        Next
        CalculateAveAudience = CalculateAveAudience / arr.Length
    End Function
    Public Sub New(Name As String, ParamArray AudienceNumbers() As Integer)
        'sets all neccessary input data 
        _name = Name 'set name at instantiation
        AveAudience = CalculateAveAudience(AudienceNumbers)
    End Sub
End Class
