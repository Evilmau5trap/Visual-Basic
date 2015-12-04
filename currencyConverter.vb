    Dim dollarValue, euroValue, poundsValue As Double

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click

        usDollars.Text = " "
        euros.Text = " "
        pounds.Text = " "
    End Sub

    Private Sub enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exchange.Click

        dollarValue = usDollars.Text
        euroValue = euroRate.Value
        poundsValue = poundRate.Value

        euros.Text = dollarValue * euroValue
        pounds.Text = dollarValue * poundsValue

    End Sub
End Class
