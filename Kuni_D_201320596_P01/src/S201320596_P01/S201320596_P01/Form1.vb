' ********************************************************************************* 
'  Surname, Initials: Kuni,D 
'  Student Number:  201320596
'  Practical: P01 
'  Class name: frmrip
' ********************************************************************************* 
Option Infer Off
Option Strict On
Option Explicit On
Public Class frmrip
    Private Function calc(ByVal dirty_word As String) As String 'works from the back of string value to the front
        calc = ""
        Dim len As Integer = dirty_word.Length - 1
        If len >= 1 Then
            If dirty_word.Chars(len) = dirty_word.Chars(len - 1) Then ' compares the present value with the previous value
                calc = calc(dirty_word.Remove(len)) + calc ' wont take the letter if the same as the adjacent letter
            Else
                calc = calc(dirty_word.Remove(len)) + dirty_word.Chars(len) + calc 'takes letter if adjacent is different 
            End If
        Else
            Return dirty_word
        End If
    End Function


    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        txtans.Text = "" ' clears textbox
        txtans.Text = calc(txtword.Text)
    End Sub
    Private Sub calculate_i(ByVal word_Dirty As String, ByRef ans As String)
        For i As Integer = 0 To word_Dirty.Length - 1
            If i = word_Dirty.Length - 1 Then 'ensures last letter is not checked 
                ans = ans + word_Dirty.Chars(i) 'takes the last letter that never appears even when there is adjacent letters or just different 
            Else
                If word_Dirty.Chars(i) <> word_Dirty.Chars(i + 1) Then 'checks for characters that are not the same 
                    ans = ans + word_Dirty.Chars(i) 'takes letter if adjacent letter is different 
                End If
            End If
        Next
    End Sub

    Private Sub btnenter2_Click(sender As Object, e As EventArgs) Handles btnenter2.Click
        txtanswer.Text = "" 'clears textbox
        calculate_i(txtdirt.Text, txtanswer.Text)
    End Sub
End Class
