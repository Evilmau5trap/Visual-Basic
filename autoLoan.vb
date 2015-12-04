    'Chapter 4:     Automobile Loan Calculator
    'Programmer:    Daniel Salgado
    'Date:          12/1/15
    'Purpose:       This program calculates the monthly payment for
    '               a loan based on loan amount, interest rate and
    '               length of loan.
    Dim globalMonths As Double = 60.0
    Const maxLoanAmountAllowed As Integer = 25000
    Const maxLowCreditAllowed As Double = 5000


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the maximum value of the loan amount NumericUpDown control
        nudLoanAmount.Maximum = maxLoanAmountAllowed
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        monthlyPayment.Text = "$0.00"
        nudLoanAmount.Value = "10000"
        nudInterestRate.Value = "10.00"
        fiveYears.Checked = True
        cbCreditRating.Text = " "
    End Sub

    Private Sub compute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compute.Click
        Dim dblRate, dblMonths, dblPayment As Double
        Dim dblLoanAmount As Double, strPayment As String
        Dim dblAdjustedRate As Double, strErrorMessage As String

        dblLoanAmount = Convert.ToDouble(nudLoanAmount.Value)

        If cbCreditRating.Text = "" Then
            MessageBox.Show("Please enter the customer's credit rating in the credit rating box.", "No Credit Rating")
            cbCreditRating.Focus()
        End If

        dblRate = (Convert.ToDouble(nudInterestRate.Value) / 100) / 12

        Select Case cbCreditRating.SelectedIndex
            Case 0
                dblAdjustedRate = dblRate
            Case 1
                dblAdjustedRate = dblRate * 1.1
            Case 2
                dblAdjustedRate = dblRate * 1.15
            Case 3
                dblAdjustedRate = dblRate * 1.17
            Case 4
                dblAdjustedRate = dblRate * 1.25
        End Select

        dblPayment = Pmt(dblAdjustedRate, globalMonths, -dblLoanAmount)
        strPayment = Format$(dblPayment, "Currency")
        monthlyPayment.Text = strPayment
    End Sub

    Private Sub threeYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles threeYears.CheckedChanged
        globalMonths = 36
    End Sub

    Private Sub fiveYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fiveYears.CheckedChanged
        globalMonths = 60
    End Sub

    Private Sub sevenYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sevenYears.CheckedChanged
        globalMonths = 84
    End Sub
End Class
