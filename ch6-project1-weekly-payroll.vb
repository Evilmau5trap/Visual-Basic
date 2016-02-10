Private Sub btnEnterWeeklyData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterWeeklyData.Click
        Dim objAddItemForm As New frmAddData
        objAddItemForm.ShowDialog()
        Do Until objAddItemForm.txtEmployeeName.Text = ""
            Dim lviWeeklyData As New ListViewItem(objAddItemForm.txtEmployeeName.Text)

            lviWeeklyData.SubItems.Add(objAddItemForm.nudHours.Value)

            lviWeeklyData.SubItems.Add(Format$(objAddItemForm.txtRate.Text, "Currency"))

            lstWeeklyPayroll.Items.Add(lviWeeklyData)
            objAddItemForm.ShowDialog()
        Loop
    End Sub

    Private Sub btnTotalWeeklyPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalWeeklyPayroll.Click
        Dim intIndex, intListCount As Integer
        Dim sngTotalSales As Single = 0
        Dim sngTotalWorkerPay As Single = 0
        Dim strPayRate As Single
        Dim sngHours As Single
        Dim strResults As String, strHours As String
        intListCount = Convert.ToInt32(lstWeeklyPayroll.Items.Count)
        For intIndex = 0 To intListCount - 1
            strHours = lstWeeklyPayroll.Items(intIndex).SubItems(1).Text
            strPayRate = lstWeeklyPayroll.Items(intIndex).SubItems(2).Text
            strHours = strHours.Replace("$", "0")
            sngHours = Convert.ToString(strHours)
            sngTotalSales += sngHours
            sngTotalWorkerPay += sngHours * strPayRate
        Next
        strResults = "Total Hours Worked: " & (sngTotalSales) & ControlChars.NewLine
        strResults &= "Total  Pay: " & Format$(sngTotalWorkerPay, "Currency")
        MessageBox.Show(strResults, "Total Hours Paid")
    End Sub

    Private Sub btnClearWeeklyData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearWeeklyData.Click
        lstWeeklyPayroll.Items.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intColumn0Width As Integer

        intColumn0Width = Me.Width - lstWeeklyPayroll.Columns(1).Width - lstWeeklyPayroll.Columns(2).Width - 12

        If intColumn0Width > 0 Then
            lstWeeklyPayroll.Columns(0).Width = intColumn0Width
        End If
    End Sub

    Private Sub lstWeeklyData_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstWeeklyPayroll.KeyDown

        If e.KeyCode = Keys.Delete And lstWeeklyPayroll.SelectedIndices.Count > 0 Then
            lstWeeklyPayroll.Items.RemoveAt(lstWeeklyPayroll.SelectedIndices(0))
        End If
    End Sub
    
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub

    Private Sub Enter_Weekly_Data_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtEmployeeName.Text = ""
        nudHours.Value = 0
        txtRate.Text = 0
    End Sub
