' *****************************************************************************
' Surname, Initials: Kuni, D
' Student Number: 201320596
' Practical: P07
' Class name: DramaProduction
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class DramaProduction
    Inherits Production
    Private _Themes As Integer
    Private _PlotTwists As Integer
    Public Property NumberOfThemes As Integer
        Get
            Return _Themes
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _Themes = value
            End If
        End Set
    End Property
    Public Property NumberOfPlotTwists As Integer
        Get
            Return _PlotTwists
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _PlotTwists = value
            End If
        End Set
    End Property
    Public Overrides Function DisplayDetails() As String
        ' displays all neccessary data 
        Return MyBase.DisplayDetails() + "Number of Themes : " + CStr(_Themes) + Environment.NewLine + "Number of Plot Twists : " + CStr(_PlotTwists) + Environment.NewLine
    End Function
    Public Sub New(name As String, NumberOfPlotTwists As Integer, NumberOfThemes As Integer, ParamArray AudienceNumbers() As Integer)
        'sets all neccessary input data 
        MyBase.New(name, AudienceNumbers)
        Me.NumberOfPlotTwists = NumberOfPlotTwists
        Me.NumberOfThemes = NumberOfThemes
    End Sub
End Class
