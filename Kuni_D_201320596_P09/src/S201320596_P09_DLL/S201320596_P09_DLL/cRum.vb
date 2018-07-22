' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: cRum
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public Class cRum
    Inherits PillagedGood
    Implements iBottleStuff
#Region "Variables "
    Private _Vintage As String
    Private _AmountLeft As Double
    Protected _BottleCapacity As Double
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
    Public ReadOnly Property Vintage As String
        Get
            Return _Vintage
        End Get
    End Property

    Public Property AmountLeft As Double
        Get
            Return _AmountLeft
        End Get
        Set(value As Double)
            If value >= 0 And value <= 100 Then
                _AmountLeft = value
            End If
        End Set
    End Property
#End Region
#Region "methods"
    Public Function Popularity() As String Implements iBottleStuff.Popularity
        Select Case _AmountLeft
            Case 0 To 10
                Return "A"
            Case 60 To 100
                Return "C"
            Case Is > 10
                Return "B"
        End Select
    End Function
    Public Sub New(Name As String, Vintage As String)
        Me._name = Name
        _Vintage = Vintage
    End Sub
#End Region
End Class
