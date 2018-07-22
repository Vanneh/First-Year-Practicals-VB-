Option Strict On
Option Explicit On
Option Infer Off
Public Class frmrge
    Private Elfs() As cElf
    Private Orcs() As cOrc
    Private Humans() As cHuman
    Private ne, h, o As Integer
#Region "Inputting of data"
    Private Sub btnhuman_Click(sender As Object, e As EventArgs) Handles btnhuman.Click
        h += 1 'increase of number of objects
        ReDim Preserve Humans(h)
        Dim name As String = InputBox("Please enter the name of the Human")
        Humans(h) = New cHuman(name) 'calls constructor to get rest of the data
    End Sub
    Private Sub btnorc_Click(sender As Object, e As EventArgs) Handles btnorc.Click
        o += 1 'increase of number of objects
        ReDim Preserve Orcs(o)
        Dim name As String = InputBox("Please enter the name of the Orc")
        Orcs(o) = New cOrc(name) 'calls constructor to get rest of the data
    End Sub
    Private Sub btnelf_Click(sender As Object, e As EventArgs) Handles btnelf.Click
        ne += 1 'increase of number of objects
        ReDim Preserve Elfs(ne)
        Dim name As String = InputBox("Please enter the name of the Elf")
        Elfs(ne) = New cElf(name) 'calls constructor to get rest of the data
    End Sub
#End Region
#Region "Display of Data"
    Private Sub btndh_Click(sender As Object, e As EventArgs) Handles btndh.Click
        'displays all Humans into the grid 
        grdDp.Cols = h + 1
        PIG(0, 4, "Cowardness Level")
        PIG(0, 5, "Speed Level ")
        For i As Integer = 1 To h
            PIG(i, 0, "Human " + CStr(i))
            PIG(i, 1, Humans(i).name)
            PIG(i, 2, CStr(Humans(i).Attack))
            PIG(i, 3, CStr(Humans(i).Defence))
            PIG(i, 4, CStr(Humans(i).Cowardness))
            PIG(i, 5, CStr(Humans(i).speed))
            PIG(i, 6, CStr(Math.Round(Humans(i).power, 2)))
            PIG(i, 7, CStr(Math.Round(Humans(i).defend, 2)))
            PIG(i, 8, CStr(Math.Round(Humans(i).rating, 2)))
        Next
    End Sub
    Private Sub btndo_Click(sender As Object, e As EventArgs) Handles btndo.Click
        grdDp.Cols = o + 1
        PIG(0, 5, "Scariness Level")
        PIG(0, 4, "Armor Level ")
        For i As Integer = 1 To o
            PIG(i, 0, "Orc " + CStr(i))
            PIG(i, 1, Orcs(i).name)
            PIG(i, 2, CStr(Orcs(i).Attack))
            PIG(i, 3, CStr(Orcs(i).Defence))
            PIG(i, 4, CStr(Orcs(i).armor))
            PIG(i, 5, CStr(Orcs(i).Scariness))
            PIG(i, 6, CStr(Math.Round(Orcs(i).power, 2)))
            PIG(i, 7, CStr(Math.Round(Orcs(i).defend, 2)))
            PIG(i, 8, CStr(Math.Round(Orcs(i).rating, 2)))
        Next
    End Sub

    Private Sub btnElfs_Click(sender As Object, e As EventArgs) Handles btnElfs.Click
        'displays all Elfs into the grid 
        grdDp.Cols = ne + 1
        lblGridText.Text = "A Table showing multiple Elf information"
        PIG(0, 4, "AccuracyLevel")
        PIG(0, 5, "Adrenaline  Level ")
        For i As Integer = 1 To ne
            PIG(i, 0, "Elf " + CStr(i))
            PIG(i, 1, Elfs(i).name)
            PIG(i, 2, CStr(Elfs(i).Attack))
            PIG(i, 3, CStr(Elfs(i).Defence))
            PIG(i, 4, CStr(Elfs(i).Accuracy))
            PIG(i, 5, CStr(Elfs(i).Adrenaline))
            PIG(i, 6, CStr(Math.Round(Elfs(i).power, 2)))
            PIG(i, 7, CStr(Math.Round(Elfs(i).defend, 2)))
            PIG(i, 8, CStr(Math.Round(Elfs(i).rating, 2)))
        Next
    End Sub
#End Region
#Region "Methods and others"
    Private Sub PIG(c As Integer, r As Integer, t As String) 'stands for place in grid
        grdDp.Col = c
        grdDp.Row = r
        grdDp.Text = t
    End Sub
    Private Sub frmrge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set up of grid partially
        grdDp.set_ColWidth(0, 120)
        PIG(0, 1, "Name ")
        PIG(0, 2, "Attack Level")
        PIG(0, 3, "Defence Level")
        PIG(0, 6, "Power")
        PIG(0, 7, "Overrall Defence")
        PIG(0, 8, "Rating")
    End Sub
#End Region

End Class
