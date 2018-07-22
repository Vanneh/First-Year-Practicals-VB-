' ***************************************************************************** 
'  Surname, Initials:  Kuni, D
'  Student Number:  201320596
'  Practical: P03 
'  Class name: TrafficLight
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class TrafficLight
#Region "Variable Declarations "
    Private tY As Integer
    Private tX As Integer
    Private tCurrentState As Integer
    Private Shared tCollectiveHealth As Integer
#End Region
#Region "Property Methods"
    Public Property Y As Integer
        Get
            Return tY
        End Get
        Set(value As Integer)
            tY = value
        End Set
    End Property
    Public Property X As Integer
        Get
            Return tX
        End Get
        Set(value As Integer)
            tX = value
        End Set
    End Property
    Public Property CurrentState As Integer
        Get
            Return tCurrentState
        End Get
        Set(value As Integer)
            tCurrentState = value
        End Set
    End Property
    Public Shared ReadOnly Property CollectiveHealth As Integer
        Get
            Return tCollectiveHealth
        End Get
    End Property
#End Region
#Region "Methods"
    Public Shared Function AuthorDetails() As String
        Return "Student ID: 201320596" + vbNewLine + "Student Surname and Initials: Kuni, D" 'my details
    End Function
    Public Shared Sub ResetHealth()
        tCollectiveHealth = 100 'reselts collective health to 100
    End Sub
    Public Sub ReceiveDamage()
        tCollectiveHealth = tCollectiveHealth - GenerateRandomDamage() 'decreases collective health by the number generated
    End Sub
    Private Function GenerateRandomDamage() As Integer
        Return CInt((Math.Floor(10) * Rnd()) + 1) 'returns a random number between 1 and 10
    End Function
    Public Shared Function isOnline() As Boolean
        If CollectiveHealth > 10 Then
            Return True 'is operating as normal
        Else
            Return False 'in panic state
        End If
    End Function
    Private Function PanicState() As Boolean
        If CollectiveHealth <= 10 Then
            Return True 'initiate panic state
        Else
            Return False 'resume as normal
        End If
    End Function
    Public Sub ChangeColor()
        Select Case CurrentState
            Case Is = 2 'when greem
                CurrentState = 1 'change to amber 
            Case Is = 1 'when amber 
                CurrentState = 0 'change to red
            Case Is = 3 'when transparent 
                CurrentState = 0 'change to red
            Case Is = 0
                If PanicState() = True Then
                    CurrentState = 3 'if in panic state, change to transparent
                Else
                    CurrentState = 2 'change to green when not transparent 
                End If
        End Select
    End Sub
#End Region
    Public Sub New(ByVal X As Integer, ByVal Y As Integer, ByVal currentstate As Integer)
        'gets value set by programmer and assigns it to appropriate variables
        Me.X = X
        Me.Y = Y
        Me.CurrentState = currentstate
        tCollectiveHealth = 100
    End Sub
End Class


