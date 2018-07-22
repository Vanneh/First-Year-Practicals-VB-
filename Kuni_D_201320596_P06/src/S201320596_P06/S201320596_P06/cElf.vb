Option Strict On
Option Explicit On
Option Infer Off
Public Class cElf
    Inherits cRaceGroup
#Region "Attributes "
    Protected _Accuracy As Double
    Protected _Adrenaline As Double
#End Region
#Region "Properties"
    Public Property Accuracy As Double
        Get
            Return _Accuracy
        End Get
        Set(value As Double)
            _Accuracy = calcVal(value)
        End Set
    End Property
    Public Property Adrenaline As Double
        Get
            Return _Adrenaline
        End Get
        Set(value As Double)
            _Adrenaline = calcVal(value)
        End Set
    End Property
#End Region
#Region "Methods"
    Public Overrides Function defend() As Double
        Return Defence
    End Function
    Public Overrides Function power() As Double
        Return MyBase.power() + (0.25 * _Adrenaline) + _Accuracy
    End Function
#End Region
#Region "Constructors"
    Public Sub New()
        MyBase.New()
        Accuracy = 0
        Adrenaline = 0
    End Sub
    Public Sub New(name As String)
        'Gets data from the user 
        MyBase.New(name)
        Accuracy = CDbl(InputBox("Please enter the Accuracy Level of " + name + " a level between 0 and 10"))
        Adrenaline = CDbl(InputBox("Please enter the Adrenaline level of " + name + " a level between 0 and 10"))
    End Sub
#End Region
End Class
