' ***************************************************************************** 
'  Surname, Initials: Kuni, D
'  Student Number: 201320596
'  Practical: P09
'  Class name: frmCPLA
' *****************************************************************************
Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports S201320596_P09_DLL
Public Class frmCPLA
#Region "Attributes"
    Private exchangerate As Double = 0
    Private BottlesOfRum(0) As cRum
    Private bottlesofGrog(0) As cGrog
    Private Booties(0) As cBooty_Not_Nicky_Minaj_Anaconda_
    Private FSrum, FSgrog, FSBooty As FileStream 'file streams for each file
    Private BF As BinaryFormatter
    Private r, g, b As Integer
    Private NumbCBottles, NumbABottles As Integer
    Const FBooty As String = "BootyRecords.P09"
    Const FGrog As String = "GrogRecords.P09"
    Const FRum As String = "RumRecords.P09"
#End Region
    Private Sub ExchangeBooties(sender As Object, e As EventArgs) Handles tsmExBoot.Click
        'calculates the exchanged value for all booties and the total
        If exchangerate <= 0 Then
            MsgBox("The exchange rate is either Zero or a negative value ")
            Exit Sub
        End If
        Dim total As Double
        Dim answer As Double
        Try
            For i As Integer = 1 To b
                answer = cBooty_Not_Nicky_Minaj_Anaconda_.CalcExchangedVal(exchangerate, Booties(i).Value)
                gbooty(i, 3, CStr(Math.Round(answer, 2)))
                total += answer
            Next
            txtboot.Text = CStr(Math.Round(total, 2))
        Catch ex As Exception
            MsgBox("Oops , sorry There was an Error, try again")
        End Try
    End Sub
#Region "File Option Subs "
    Private Sub CreateFiles(sender As Object, e As EventArgs) Handles tsmCreate.Click
        'creates the files 
        FSgrog = New FileStream(FGrog, FileMode.Create, FileAccess.Write)
        FSgrog.Close()
        FSgrog = Nothing
        FSrum = New FileStream(FRum, FileMode.Create, FileAccess.Write)
        FSrum.Close()
        FSrum = Nothing
        FSBooty = New FileStream(FBooty, FileMode.Create, FileAccess.Write)
        FSBooty.Close()
        FSBooty = Nothing
        MsgBox("Files have been created ")
    End Sub
    Private Sub DisplayFromFile(sender As Object, e As EventArgs) Handles tsmDisplay.Click
        'displays data from files into grid
        ReDim BottlesOfRum(0)
        ReDim bottlesofGrog(0)
        ReDim Booties(0)
        r = 0
        g = 0
        b = 0
        grdDisplayBooty.Cols = 1
        grdDisplayGrog.Cols = 1
        grddisplayRum.Cols = 1
        FSgrog = New FileStream(FGrog, FileMode.Open, FileAccess.Read)
        FSBooty = New FileStream(FBooty, FileMode.Open, FileAccess.Read)
        FSrum = New FileStream(FRum, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter
        Dim temprum As cRum
        Dim tempgrog As cGrog
        Dim tempbooty As cBooty_Not_Nicky_Minaj_Anaconda_
        Try
            While FSrum.Position < FSrum.Length
                temprum = CType(BF.Deserialize(FSrum), cRum)
                r += 1
                ReDim Preserve BottlesOfRum(r)
                BottlesOfRum(r) = temprum
                grddisplayRum.Cols = r + 1
                displayrum(r, r)
                If BottlesOfRum(r).Popularity = "A" Then
                    NumbABottles += 1
                End If
            End While
            While FSgrog.Position < FSgrog.Length
                tempgrog = CType(BF.Deserialize(FSgrog), cGrog)
                g += 1
                ReDim Preserve bottlesofGrog(g)
                bottlesofGrog(g) = tempgrog
                grdDisplayGrog.Cols = g + 1
                displayGrog(g, g)
            End While
            While FSBooty.Position < FSBooty.Length
                tempbooty = CType(BF.Deserialize(FSBooty), cBooty_Not_Nicky_Minaj_Anaconda_)
                b += 1
                ReDim Preserve Booties(b)
                Booties(b) = tempbooty
                grdDisplayBooty.Cols = b + 1
                DisplayBooty(b, b)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
        FSrum.Close()
        FSgrog.Close()
        FSBooty.Close()
        FSgrog = Nothing
        FSBooty = Nothing
        FSrum = Nothing
        BF = Nothing
    End Sub
    Private Sub SaveToFile(sender As Object, e As EventArgs) Handles tsmSave.Click
        'Saves data to files
        FSrum = New FileStream(FRum, FileMode.Open, FileAccess.Write)
        FSBooty = New FileStream(FBooty, FileMode.Open, FileAccess.Write)
        FSgrog = New FileStream(FGrog, FileMode.Open, FileAccess.Write)
        BF = New BinaryFormatter
        Try
            For i As Integer = 1 To r
                BF.Serialize(FSrum, BottlesOfRum(i))
            Next
            For i As Integer = 1 To g
                BF.Serialize(FSgrog, bottlesofGrog(i))
            Next
            For i As Integer = 1 To b
                BF.Serialize(FSBooty, Booties(i))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FSBooty.Close()
        FSgrog.Close()
        FSrum.Close()
        FSBooty = Nothing
        FSrum = Nothing
        FSgrog = Nothing
        BF = Nothing
        MsgBox("All records have been saved to file")
    End Sub
#End Region
#Region "Inputting Subs"
    Private Sub Addbooty(sender As Object, e As EventArgs) Handles tsmBooty.Click
        Dim name As String
        Dim ValueOfBooty As Double
        Try
            name = InputBox("Pleas enter the name of the Booty ")
            ValueOfBooty = CDbl(InputBox("Please enter the Value of the Booty"))
            b += 1
            ReDim Preserve Booties(b)
            Booties(b) = New cBooty_Not_Nicky_Minaj_Anaconda_(name)
            Booties(b).Value = ValueOfBooty
        Catch ex As TaskCanceledException
            Exit Sub
        Catch ex As ArgumentException
            MsgBox("Nothing was enter into a variable ")
        Catch grex As GrogAlcoholException
            MsgBox(grex.Message)
        Catch negexp As NegativeException
            MsgBox(negexp.Message, MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Sorry the value you have entered caused an Error, please click the button to enter the details again of the rum bottle", MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub AddRum(sender As Object, e As EventArgs) Handles tsmRum.Click
        Dim name, vintage As String
        Dim BottleCapacity, amountRemaining As Double
        Try
            name = InputBox("Pleas enter the name of the rum ")
            vintage = InputBox("Please enter the year it was produced (Vintage)")
            BottleCapacity = CDbl(InputBox("Please enter the capacity of the bottle in Millilitres "))
            If BottleCapacity <= 0 Then Throw New NegativeException("Bottle Capacity")
            amountRemaining = CDbl(InputBox("Please enter the about left in the bottle as a percentage"))
            If amountRemaining < 0 Then Throw New NegativeException("Amount Remaining In Bottle")
            r += 1
            ReDim Preserve BottlesOfRum(r)
            BottlesOfRum(r) = New cRum(name, vintage)
            BottlesOfRum(r).BottleCapacity = BottleCapacity
            BottlesOfRum(r).AmountLeft = amountRemaining
            grddisplayRum.Cols = r + 1
            displayrum(r, r)
            gRum(0, 0, "Number of A-Rated Bottles: " + CStr(NumbABottles))
        Catch ex As TaskCanceledException
            Exit Sub
        Catch ex As ArgumentException
            MsgBox("Nothing was enter into a variable ")
        Catch ex As InvalidCastException
            MsgBox("You never enter a numerical value into a variable which caused an error, try again")
        Catch negexp As NegativeException
            MsgBox(negexp.Message, MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Sorry the value you have entered caused an Error, please click the button to enter the details again of the rum bottle", MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub AddGrog(sender As Object, e As EventArgs) Handles tsmGrog.Click
        Dim name As String
        Dim BottleCapacity, alcoholcontent As Double
        MsgBox(CStr(g))
        Try
            name = InputBox("Pleas enter the name of the Grog ")
            BottleCapacity = CDbl(InputBox("Please enter the capacity of the bottle in Millilitres "))
            If BottleCapacity <= 0 Then Throw New NegativeException("Bottle Capacity")
            alcoholcontent = CDbl(InputBox("Please enter the Alchohol Content in the bottle as a percentage"))
            If alcoholcontent < 30 Then Throw New GrogAlcoholException
            g += 1
            ReDim Preserve bottlesofGrog(g)
            bottlesofGrog(g) = New cGrog(name)
            bottlesofGrog(g).BottleCapacity = BottleCapacity
            bottlesofGrog(g).AlcoholContent = alcoholcontent
            grdDisplayGrog.Cols = g + 1
            displayGrog(g, g)
        Catch ex As TaskCanceledException
            Exit Sub
        Catch ex As ArgumentException
            MsgBox("Nothing was enter into a variable ")
        Catch grex As GrogAlcoholException
            MsgBox("Ka-Boom!!! , the universe has exploded")
            MsgBox("I lied!! hahahaha")
            MsgBox(grex.Message)
        Catch negexp As NegativeException
            MsgBox(negexp.Message, MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Sorry the value you have entered caused an Error, please click the button to enter the details again of the rum bottle", MsgBoxStyle.OkOnly)
        End Try
    End Sub
#End Region

End Class
