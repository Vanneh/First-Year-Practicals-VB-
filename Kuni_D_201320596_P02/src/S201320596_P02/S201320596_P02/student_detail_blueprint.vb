' ********************************************************************************* 
'  Surname, Initials:  Kuni, D
'  Student Number: 201320596 
'  Practical: P02 
'  Class name: student_detail_blueprint
' *********************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Public Class student_detail_blueprint
#Region "Variable Declartion "
    Public _studentID As String
    Friend _surname As String
    Private _subject_marks(), _passed As Integer
    Private _average As Double
    Private _rating As Boolean
#End Region
#Region "Property Methods"
    Public Property rating As Boolean
        Get
            Return _rating
        End Get
        Set(value As Boolean)
            _rating = value
        End Set
    End Property
    Public Property passed As Integer
        Get
            Return _passed
        End Get
        Set(ByVal value As Integer)
            _passed = value
        End Set
    End Property
    Public Property subject_marks(ByVal index As Integer) As Integer
        Get
            Return _subject_marks(index)
        End Get
        Set(value As Integer)
            If value <= 100 And value >= 0 Then 'Stops User from Entering an invalid value
                _subject_marks(index) = value
            Else
                MsgBox("Error! value incorrect , please provide the correct value again", MsgBoxStyle.OkOnly, "ERORR!!")
                Dim re_entered_mark As Integer = CInt(InputBox("Enter the correct integer mark for the student", _studentID)) 'gets the correct value
                subject_marks(index) = re_entered_mark 'sends value back into property method to check its validity
            End If
        End Set
    End Property
    Public Property average As Double
        Get
            Return _average
        End Get
        Set(value As Double)
            _average = value
        End Set
    End Property
#End Region
    Friend Sub New(ByVal index As Integer)
        ReDim _subject_marks(index) 'resizes the array
        For Each mark As Integer In _subject_marks
            subject_marks(mark) = 0 'deletes any values within the array
        Next
    End Sub
End Class


