' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: PillagedGood
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public Class PillagedGood
    Protected _name As String
    Public ReadOnly Property Name As String
        Get
            Return Me._name
        End Get
    End Property
End Class
