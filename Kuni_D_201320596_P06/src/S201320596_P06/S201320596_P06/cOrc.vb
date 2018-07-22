Option Strict On
Option Explicit On
Option Infer Off
Public Class cOrc
    Inherits cRaceGroup
#Region "Attributes "
    Protected _armor As Double 'armor for the orc
    Protected _scariness As Double 'orcs is generally scary
#End Region
#Region "Properties"
    Public Property armor As Double
        Get
            Return _armor
        End Get
        Set(value As Double)
            _armor = calcVal(value)
        End Set
    End Property
    Public Property Scariness As Double
        Get
            Return _scariness
        End Get
        Set(value As Double)
            _scariness = calcVal(value)
        End Set
    End Property
#End Region
#Region "Methods"
    Public Overrides Function defend() As Double
        Return Defence + _armor
    End Function
    Public Overrides Function rating() As Double
        Return MyBase.rating() + _scariness - _armor
    End Function
    Public Overrides Function power() As Double
        Return MyBase.power() - _armor + (0.23569 * _scariness)
    End Function
#End Region
#Region "Constructors"
    Public Sub New()
        MyBase.New()
        armor = 0
        Scariness = 0
    End Sub
    Public Sub New(name As String)
        'Gets data from the user 
        MyBase.New(name)
        armor = CDbl(InputBox("Please enter the Armor Level of " + name + " a level between 0 and 10"))
        Scariness = CDbl(InputBox("Please enter the Scariness Level of " + name + " a level between 0 and 10"))
    End Sub
#End Region
End Class
