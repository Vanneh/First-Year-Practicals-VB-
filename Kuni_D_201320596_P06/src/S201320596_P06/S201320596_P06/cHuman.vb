Option Strict On
Option Explicit On
Option Infer Off
Public Class cHuman
    Inherits cRaceGroup
#Region "Attributes "
    Protected _speed As Double 'increases the attack of the human
    Protected _cowardness As Double 'weakens the defence and attack of the human
#End Region
#Region "Properties"
    Public Property speed As Double
        Get
            Return _speed
        End Get
        Set(value As Double)
            _speed = calcVal(value)
        End Set
    End Property
    Public Property Cowardness As Double
        Get
            Return _cowardness
        End Get
        Set(value As Double)
            _cowardness = calcVal(value)
        End Set
    End Property
#End Region
#Region "Methods"
    Public Overrides Function defend() As Double
        Return Defence - _cowardness
    End Function

    Public Overrides Function power() As Double
        Return MyBase.power - _cowardness + (_speed * 0.3256)
    End Function

    Public Overrides Function rating() As Double
        Return MyBase.rating - _cowardness + (0.5 * _speed)
    End Function
#End Region
#Region "Constructors"
    Public Sub New(name As String)
        'Gets data from the user 
        MyBase.New(name)
        speed = CDbl(InputBox("Please enter the speed of " + name + " a level between 0 and 10"))
        Cowardness = CDbl(InputBox("Please enter the cowardness level of " + name + " a level between 0 and 10"))
    End Sub
    Public Sub New()
        MyBase.New()
        speed = 0
        Cowardness = 0
    End Sub
#End Region
End Class
