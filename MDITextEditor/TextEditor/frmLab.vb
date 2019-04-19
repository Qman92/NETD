Option Strict On

Public Class frmUnitsShipped
    Private Const EMPLOYEE_ONE As Integer = 0
    Private Const EMPLOYEE_TWO As Integer = 1
    Private Const EMPLOYEE_THREE As Integer = 2

    Private Const SHIP_LIMIT As Integer = 7
    Private Const SHIP_SIZE_LIMIT As Integer = 1000

    Private employeeOneAverage As Double = 0
    Private employeeTwoAverage As Double = 0
    Private employeeThreeAverage As Double = 0
    Private index As Integer = 0
    Private userInput As Integer = Nothing
    Private shipList(2, SHIP_LIMIT - 1) As Integer
    Private shipDay As Integer = 0
    Private sum As Integer
    Private count As Integer

    Private Sub frmUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDay.Text = "Day: " + shipDay.ToString()
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If (Integer.TryParse(txtUnitsShipped.Text, userInput) And (userInput <= SHIP_SIZE_LIMIT And userInput >= 0) And Not userInput = Nothing) Then
            shipDay += 1
            lblDay.Text = "Day: " + shipDay.ToString()
            If (count < SHIP_LIMIT) Then
                lblEmployee2.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee3.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
                shipList(EMPLOYEE_ONE, index) = userInput
                lblEmployee1Units.Text += shipList(EMPLOYEE_ONE, index) & vbCrLf
            ElseIf (count >= SHIP_LIMIT And count < 14) Then
                lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee3.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee2.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
                lblEmployee1Average.Text = "Average : " & Math.Round((shipList(0, 0) + shipList(0, 1) + shipList(0, 2) + shipList(0, 3) + shipList(0, 4) + shipList(0, 5) + shipList(0, 6)) / 7, 2)
                shipList(EMPLOYEE_TWO, index) = userInput
                lblEmployee2Units.Text += shipList(EMPLOYEE_TWO, index) & vbCrLf
            ElseIf (count >= 14 And count < 21) Then
                lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee2.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee3.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
                lblEmployee2Average.Text = "Average : " & Math.Round((shipList(1, 0) + shipList(1, 1) + shipList(1, 2) + shipList(1, 3) + shipList(1, 4) + shipList(1, 5) + shipList(1, 6)) / 7, 2)
                shipList(EMPLOYEE_THREE, index) = userInput
                lblEmployee3Units.Text += shipList(EMPLOYEE_THREE, index) & vbCrLf
            Else
                lblDay.Text = "Done"
                For i As Integer = 0 To SHIP_LIMIT - 1
                    sum += shipList(EMPLOYEE_ONE, i)
                    sum += shipList(EMPLOYEE_TWO, i)
                    sum += shipList(EMPLOYEE_THREE, i)
                Next

                lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee2.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                lblEmployee3.Font = New Font(lblEmployee1.Font, FontStyle.Regular)

                lblEmployee3Average.Text = "Average : " & Math.Round((shipList(2, 0) + shipList(2, 1) + shipList(2, 2) + shipList(2, 3) + shipList(2, 4) + shipList(2, 5) + shipList(2, 6)) / 7, 2)
                lblAverage.Text = "Total employee average is : " & Math.Round((sum / 21), 2).ToString()
                btnEnter.Enabled = False
                txtUnitsShipped.Enabled = False
            End If
            count += 1
        Else
            MessageBox.Show("ERROR: Please make sure your input is numaric between 0 and 1000")
        End If

        If (index < SHIP_LIMIT - 1) Then
            index += 1
        Else
            index = 0
        End If

        If (shipDay >= SHIP_LIMIT) Then
            shipDay = 0
            'lblDay.Text = "Day: " & shipDay.ToString()
        End If
        txtUnitsShipped.ResetText()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Reset()
        Array.Clear(shipList, 0, shipList.Length)
        lblDay.ResetText()
        txtUnitsShipped.ResetText()
        lblEmployee1Units.ResetText()
        lblEmployee2Units.ResetText()
        lblEmployee3Units.ResetText()
        lblEmployee1Average.ResetText()
        lblEmployee2Average.ResetText()
        lblEmployee3Average.ResetText()
        lblAverage.ResetText()
        txtUnitsShipped.Enabled = True
        btnEnter.Enabled = True

        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
        lblEmployee2.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
        lblEmployee3.Font = New Font(lblEmployee1.Font, FontStyle.Regular)

        employeeOneAverage = 0
        employeeTwoAverage = 0
        employeeThreeAverage = 0
        shipDay = 0
        sum = 0
        count = 0
    End Sub
End Class
