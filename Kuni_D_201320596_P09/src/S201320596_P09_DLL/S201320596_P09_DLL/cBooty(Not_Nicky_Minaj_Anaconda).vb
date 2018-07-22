' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: cBooty_Not_Nicky_Minaj_Anaconda_
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public Class cBooty_Not_Nicky_Minaj_Anaconda_
    Inherits PillagedGood
    Private _Value As Double
    Public Sub New(name As String)
        Me._name = name
    End Sub
#Region "Methods"
    Public Property Value As Double 'In Gold Coins
        Get
            Return _Value
        End Get
        Set(value As Double)
            Me._Value = value
        End Set
    End Property
    Public Shared Function CalcExchangedVal(ByVal ExchangeRate As Double, ByVal Value As Double) As Double
        Return Value * ExchangeRate
    End Function
#End Region
End Class
