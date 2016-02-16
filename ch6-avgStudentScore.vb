Private Sub btnEnterStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterStudent.Click
        Dim objAddItemForm As New frmEnterStudent
        objAddItemForm.ShowDialog()
        Do Until objAddItemForm.txtStudentName.Text = ""
            Dim lviStudentScores As New ListViewItem(objAddItemForm.txtStudentName.Text)

            lviStudentScores.SubItems.Add(Format$(objAddItemForm.txtScore.Text))

            lstStudentScores.Items.Add(lviStudentScores)
            objAddItemForm.ShowDialog()
        Loop
    End Sub

    Private Sub btnDisplayData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayData.Click
        Dim intIndex, intListCount As Integer
        Dim sngScores As Single
        Dim sngAverageScore As Single = 0
        Dim sngTotalScores As Single = 0
        Dim strResults As String, strScores As String
        intListCount = Convert.ToInt32(lstStudentScores.Items.Count)
        For intIndex = 0 To intListCount - 1
            strScores = lstStudentScores.Items(intIndex).SubItems(1).Text
            sngScores = Convert.ToString(strScores)
            sngTotalScores = intListCount
            sngAverageScore += sngScores / intListCount
        Next
        strResults = "Number of Scores is " & (sngTotalScores) & ControlChars.NewLine
        strResults &= "The Average Score is " & Format$(sngAverageScore)
        MessageBox.Show(strResults, "Total Scores")
    End Sub
    Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click
        lstStudentScores.Items.Clear()
    End Sub
    Private Sub frmAvgStudentScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intColumn0Width As Integer

        intColumn0Width = Me.Width - lstStudentScores.Columns(1).Width - lstStudentScores.Columns(2).Width - 12

        If intColumn0Width > 0 Then
            lstStudentScores.Columns(0).Width = intColumn0Width
        End If
    End Sub
    Private Sub lstStudentScores_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstStudentScores.KeyDown

        If e.KeyCode = Keys.Delete And lstStudentScores.SelectedIndices.Count > 0 Then
            lstStudentScores.Items.RemoveAt(lstStudentScores.SelectedIndices(0))
        End If
    End Sub
    
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub

    Private Sub frmEnterStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtStudentName.Text = ""
        txtScore.Text = ""
    End Sub
