' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: cGrog
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public Class cGrog
    Inherits PillagedGood
    Implements iBottleStuff
#Region "Variables "
    Protected _BottleCapacity As Double
    Private _AlcoholContent As Double
#End Region
#Region "Properties"
    Public Property BottleCapacity As Double Implements iBottleStuff.BottleCapacity
        Get
            Return _BottleCapacity
        End Get
        Set(value As Double)
            If value > 0 Then
                _BottleCapacity = value
            End If
        End Set
    End Property
    Public Property AlcoholContent As Double
        Get
            Return _AlcoholContent
        End Get
        Set(value As Double)
            If value >= 0 Then
                _AlcoholContent = value
            End If
        End Set
    End Property
#End Region
#Region "Methods"
    Public Function Popularity() As String Implements iBottleStuff.Popularity
        Select Case _AlcoholContent
            Case Is > 70
                Return "A"
            Case Is > 50
                Return "B"
            Case Is > 40
                Return "C"
        End Select
    End Function
    Public Sub New(name As String)
        Me._name = name
    End Sub
#End Region
End Class
