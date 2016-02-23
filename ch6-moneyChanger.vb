Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        nudTotal.Value = 0.0
    End Sub

    Private Sub btnComputeChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeChange.Click
        Dim shrHalfDollar, shrQuarter, shrDime, shrNickel, shrPenny, shrCounter As Integer
        Dim strResults As String


        shrCounter = 100 - nudTotal.Value

        If shrCounter >= 50 Then
            shrHalfDollar += 1
            shrCounter -= 50
        End If
        If shrCounter >= 25 Then
            shrQuarter += 1
            shrCounter -= 25
        End If
        If shrCounter >= 10 Then
            shrDime += 1
            shrCounter -= 10
        End If
        If shrCounter >= 5 Then
            shrNickel += 1
            shrCounter -= 5
        End If
        If shrCounter >= 1 Then
            shrPenny += 1
            shrCounter -= 1
        End If
        strResults = "Half Dollars: " & shrHalfDollar & ControlChars.NewLine
        strResults &= "Quarters: " & shrQuarter & ControlChars.NewLine
        strResults &= "Dimes: " & shrDime & ControlChars.NewLine
        strResults &= "Nickels: " & shrNickel & ControlChars.NewLine
        strResults &= "Pennies: " & shrPenny & ControlChars.NewLine
        MessageBox.Show(strResults, "Change Amount")
    End Sub
