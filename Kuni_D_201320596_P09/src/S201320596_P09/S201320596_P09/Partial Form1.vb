' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: frmCPLA
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Partial Public Class frmCPLA
    Private Sub frmCPLA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gRum(0, 1, "Name Of Rum")
        gRum(0, 2, "Bottle Capacity")
        gRum(0, 3, "Vintage")
        gRum(0, 4, "Amount Left")
        gRum(0, 5, "Popularity")
        ggrog(0, 1, "Name Of Grog")
        ggrog(0, 2, "Bottle Capacity")
        ggrog(0, 3, "Alcohol Content")
        ggrog(0, 4, "Popularity")
        gbooty(0, 1, "Name of Booty")
        gbooty(0, 2, "Value in Gold Coins")
        gbooty(0, 3, "Value in Silver Coins")
        grdDisplayBooty.set_ColWidth(0, 120)
        grdDisplayGrog.set_ColWidth(0, 120)
        grddisplayRum.set_ColWidth(0, 120)
        r = 0
        g = 0
        b = 0
        grdDisplayBooty.Cols = 1
        grdDisplayGrog.Cols = 1
        grddisplayRum.Cols = 1
    End Sub
#Region "Methods"
    Private Sub displayrum(c As Integer, index As Integer)
        'displays a specified object into a specified grid colomb
        gRum(c, 0, "Bottle " + CStr(index))
        gRum(c, 1, BottlesOfRum(index).Name)
        gRum(c, 2, CStr(BottlesOfRum(index).BottleCapacity))
        gRum(c, 3, BottlesOfRum(index).Vintage)
        gRum(c, 4, CStr(BottlesOfRum(index).AmountLeft))
        gRum(c, 5, CStr(BottlesOfRum(index).Popularity))
    End Sub
    Private Sub displayGrog(c As Integer, index As Integer)
        'displays a specified object into a specified grid colomb
        ggrog(c, 0, "Bottle " + CStr(index))
        ggrog(c, 1, bottlesofGrog(index).Name)
        ggrog(c, 2, CStr(bottlesofGrog(index).BottleCapacity))
        ggrog(c, 3, CStr(bottlesofGrog(index).AlcoholContent))
        ggrog(c, 4, CStr(bottlesofGrog(index).Popularity))
    End Sub
    Private Sub DisplayBooty(c As Integer, index As Integer)
        'displays a specified object into a specified grid colomb
        gRum(c, 0, "Booty " + CStr(index))
        gbooty(c, 1, Booties(index).Name)
        gbooty(c, 2, CStr(Booties(index).Value))
    End Sub
    Private Sub gRum(c As Integer, r As Integer, t As String)
        grddisplayRum.Col = c
        grddisplayRum.Row = r
        grddisplayRum.Text = t
    End Sub
    Private Sub ggrog(c As Integer, r As Integer, t As String)
        grdDisplayGrog.Col = c
        grdDisplayGrog.Row = r
        grdDisplayGrog.Text = t
    End Sub
    Private Sub gbooty(c As Integer, r As Integer, t As String)
        grdDisplayBooty.Col = c
        grdDisplayBooty.Row = r
        grdDisplayBooty.Text = t
    End Sub
#End Region
#Region "Extra Stuff"
    Private Sub NumbGradeA(sender As Object, e As EventArgs) Handles tsmgraderum.Click
        Try
            For i As Integer = 1 To r
                If BottlesOfRum(i).Popularity = "A" Then
                    NumbABottles += 1
                End If
            Next
            txtrum.Text = CStr(NumbABottles)
        Catch ex As Exception
            MsgBox("Probably nothing saved to file ")
        End Try
    End Sub

    Private Sub NumbGradeC(sender As Object, e As EventArgs) Handles tsmgradegrog.Click
        Try
            For i As Integer = 1 To g
                If bottlesofGrog(i).Popularity = "C" Then
                    NumbCBottles += 1
                End If
            Next
            txtgrog.Text = CStr(NumbCBottles)
        Catch ex As Exception
            MsgBox("Probably nothing saved to file ")
        End Try
    End Sub


    Private Sub enterExchangeRate(sender As Object, e As EventArgs) Handles tsmEnterEx.Click
        Try
            exchangerate = CDbl(InputBox("Please enter the exchange rate"))
        Catch ex As InvalidCastException
            MsgBox("You never Enter a numeric value , Error Details : " + vbNewLine + ex.Message)
        Catch ex As Exception
            MsgBox("Oops , sorry There was an Error, try again")
        End Try
    End Sub
#End Region
End Class
