Option Strict On

'By: Quinn Edwards
'Date March 9th, 2019
'Desc: Program to store object with the users input in a list
'      and display it while allowing the user to edit the entry

Public Class frmCarInventory
    'Sorted list
    Dim carInventory As New SortedList
    'currentCarIdentificationNumber Declare
    Private currentCarIdentificationNumber As String = String.Empty
    Private Sub frmCarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add years to combo box
        For i As Integer = 2019 To 2000 Step -1
            cmbYear.Items.Add(i)
        Next
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim car As Car
        Dim carItem As ListViewItem
        'If the input is valid
        If IsValidInput() Then
            If currentCarIdentificationNumber.Trim.Length = 0 Then
                'Add input to car object
                car = New Car(cbxNew.Checked, cmbMake.Text, txtModel.Text, CInt(cmbYear.Text), CDbl(txtPrice.Text))
                'add to sorted list
                carInventory.Add(car.IdentificationNumber.ToString, car)
            Else
                'Convert
                car = CType(carInventory.Item(currentCarIdentificationNumber), Car)
                'Make car parameters equal to users input
                car.NewStatus = cbxNew.Checked
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = CInt(cmbYear.Text)
                car.Price = CDbl(txtPrice.Text)
            End If
            'Clear list
            lsvCars.Items.Clear()
            'For each entry
            For Each carEntry As DictionaryEntry In carInventory
                carItem = New ListViewItem()
                car = CType(carEntry.Value, Car)

                'Add items to sorted list
                carItem.Checked = car.NewStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString)
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString)
                carItem.SubItems.Add("$" & Math.Round(car.Price, 2).ToString)
                'Add ListViewIteam to list
                lsvCars.Items.Add(carItem)
            Next carEntry
            'Reset
            Reset()
        End If
    End Sub
    Private Sub lsvCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvCars.SelectedIndexChanged
        'Edit entry of selected entry
        Const identificationSubItemIndex As Integer = 1

        currentCarIdentificationNumber = lsvCars.Items(lsvCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        Dim car As Car = CType(carInventory.Item(currentCarIdentificationNumber), Car)

        cbxNew.Checked = car.NewStatus
        cmbMake.Text = car.Make
        txtModel.Text = car.Model
        Integer.TryParse(cmbYear.Text, car.Year)
        Double.TryParse(txtPrice.Text, car.Price)
    End Sub
    Private Function IsValidInput() As Boolean
        Dim returnValue As Boolean = True

        Dim price As Double
        'Reset output
        lblOutput.ResetText()

        'Check if the user input for textboxes and combo boxes is valid and print error if not
        If cmbMake.SelectedIndex = -1 Then
            lblOutput.Text += "Please select the cars make." & vbCrLf
            returnValue = False
        End If
        If cmbYear.SelectedIndex = -1 Then
            lblOutput.Text += "Please select the year the car was made." & vbCrLf
            returnValue = False
        End If

        If txtModel.Text.Trim.Length = 0 Then
            lblOutput.Text += "Please enter the cars model." & vbCrLf
            returnValue = False
        End If

        If txtPrice.Text.Trim.Length = 0 Then
            lblOutput.Text += "Please enter the cars price." & vbCrLf
            returnValue = False
        End If
        If Not Double.TryParse(txtPrice.Text, price) And Not txtPrice.Text.Trim.Length = 0 Then
            lblOutput.Text += "Please only enter numbers for the cars price." & vbCrLf
            returnValue = False
        End If
        If price < 0 Then
            lblOutput.Text += "Please enter numbers greater than or equal to 0 for the cars price." & vbCrLf
            returnValue = False
        End If
        If returnValue = False Then
            lblOutput.Text = "ERRORS:" & vbCrLf & lblOutput.Text
        End If
        'Return reternValue
        Return returnValue
    End Function

    Private Sub Reset()
        'Reset labels textboxes and combob boxes
        cmbMake.Select()
        lblOutput.ResetText()
        lsvCars.ResetText()
        txtModel.ResetText()
        txtPrice.ResetText()
        currentCarIdentificationNumber = String.Empty
        cbxNew.Checked = False
        cmbYear.SelectedIndex = -1
        cmbMake.SelectedIndex = -1
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset form
        Reset()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close form
        Me.Close()
    End Sub
End Class
