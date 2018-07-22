' ***************************************************************************** 
'  Surname, Initials:  Kuni, D
'  Student Number:  201320596
'  Practical: P10 
'  Class name: cStadium
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class cStadium
#Region "Attributes"
    Private _Name As String
    Private _NumberofFacilities As Integer
    Private _Facilities() As cFacility
#End Region
#Region "Properties"
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
    Public ReadOnly Property NumberOfFacilities As Integer
        Get
            Return _NumberofFacilities
        End Get
    End Property
    Public Property Facilities(index As Integer) As cFacility
        Get
            Return _Facilities(index)
        End Get
        Set(value As cFacility)
            _Facilities(index) = value
        End Set
    End Property
#End Region
#Region "methods"
    Public Function Display() As String
        Display = "Name Of Stadium : " + _Name + vbNewLine
        Display += "Number Of Facilities : " + CStr(_NumberofFacilities) + vbNewLine
        Display += "Overall Rating : " + CStr(Math.Round(DetermineOverallRating, 2)) + vbNewLine
        For i As Integer = 1 To NumberOfFacilities
            Display += "Facility Number " + CStr(i) + " details " + vbNewLine
            Display += _Facilities(i).display
        Next
    End Function
    Public Function DetermineOverallRating() As Double
        Dim total As Double = 0
        For i As Integer = 1 To NumberOfFacilities
            total += _Facilities(i).DeterminePopularityFactor
        Next
        Return total / _Facilities.Length
    End Function
    Public Sub New(NumberOfFacilities As Integer)
        _NumberofFacilities = NumberOfFacilities
        ReDim _Facilities(_NumberofFacilities)
    End Sub
#End Region
End Class
