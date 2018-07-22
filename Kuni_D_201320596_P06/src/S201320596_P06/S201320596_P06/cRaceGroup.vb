Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class cRaceGroup
    Implements ibasics
#Region "Attributes "
    Protected _name As String
    Protected _Attack As Double
    Protected _Defence As Double
#End Region
#Region "Properties"
    Public ReadOnly Property name As String
        Get
            Return _name
        End Get
    End Property
    Public Property Attack As Double
        Get
            Return _Attack
        End Get
        Set(value As Double)
            _Attack = calcVal(value)
        End Set
    End Property
    Public Property Defence As Double
        Get
            Return _Defence
        End Get
        Set(value As Double)
            _Defence = calcVal(value)
        End Set
    End Property
#End Region
#Region "Methods"
    Public MustOverride Function defend() As Double Implements ibasics.defend
    Protected Function calcVal(ByVal value As Double) As Double 'Utillity for property methods
        If value <= 10 And value >= 0 Then
            calcVal = value
        Else
            Dim a As Double = CDbl(InputBox("Invalid input , Please enter a value between 0 and 10 ", "Error!!"))
            calcVal = calcVal(a)
        End If
    End Function
    Public Overridable Function power() As Double Implements ibasics.power
        power = _Attack 'just returns attack
    End Function

    Public Overridable Function rating() As Double Implements ibasics.rating
        rating = 10 * (Attack / Defence) 'calculates rating 
    End Function
#End Region
#Region "Constructors"
    Public Sub New(name As String)
        'gets necessary data from the user
        Me._name = name
        Attack = CDbl(InputBox("Please enter the Attack of " + name + " a level between 0 and 10"))
        Defence = CDbl(InputBox("Please enter the Defence of " + name + " a level between 0 and 10"))
    End Sub
    Public Sub New() 'incase user wants to enter data differently
        _name = ""
        Attack = 0
        Defence = 0
    End Sub
#End Region
End Class
