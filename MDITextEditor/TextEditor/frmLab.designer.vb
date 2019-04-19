<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitsShipped
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtUnitsShipped = New System.Windows.Forms.TextBox()
        Me.lblEmployee1Units = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTipUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEmployee2Units = New System.Windows.Forms.Label()
        Me.lblEmployee3Units = New System.Windows.Forms.Label()
        Me.lblEmployee1Average = New System.Windows.Forms.Label()
        Me.lblEmployee2Average = New System.Windows.Forms.Label()
        Me.lblEmployee3Average = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUnitsShipped
        '
        Me.txtUnitsShipped.Location = New System.Drawing.Point(44, 29)
        Me.txtUnitsShipped.Name = "txtUnitsShipped"
        Me.txtUnitsShipped.Size = New System.Drawing.Size(51, 20)
        Me.txtUnitsShipped.TabIndex = 2
        Me.ToolTipUnitsShipped.SetToolTip(Me.txtUnitsShipped, "Enter number of units shipped")
        '
        'lblEmployee1Units
        '
        Me.lblEmployee1Units.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Units.Location = New System.Drawing.Point(11, 91)
        Me.lblEmployee1Units.Name = "lblEmployee1Units"
        Me.lblEmployee1Units.Size = New System.Drawing.Size(108, 142)
        Me.lblEmployee1Units.TabIndex = 4
        Me.lblEmployee1Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblEmployee1Units, "List of shipped units for employee 3")
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(11, 274)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(361, 23)
        Me.lblAverage.TabIndex = 12
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblAverage, "List average")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(16, 317)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(97, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipUnitsShipped.SetToolTip(Me.btnEnter, "Add number to the list")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(145, 317)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(97, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTipUnitsShipped.SetToolTip(Me.btnReset, "Reset form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(274, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTipUnitsShipped.SetToolTip(Me.btnExit, "Exit program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployee2Units
        '
        Me.lblEmployee2Units.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Units.Location = New System.Drawing.Point(138, 91)
        Me.lblEmployee2Units.Name = "lblEmployee2Units"
        Me.lblEmployee2Units.Size = New System.Drawing.Size(108, 142)
        Me.lblEmployee2Units.TabIndex = 7
        Me.lblEmployee2Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblEmployee2Units, "List of shipped units for employee 2")
        '
        'lblEmployee3Units
        '
        Me.lblEmployee3Units.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Units.Location = New System.Drawing.Point(264, 91)
        Me.lblEmployee3Units.Name = "lblEmployee3Units"
        Me.lblEmployee3Units.Size = New System.Drawing.Size(108, 142)
        Me.lblEmployee3Units.TabIndex = 10
        Me.lblEmployee3Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblEmployee3Units, "List of shipped units for employee 3")
        '
        'lblEmployee1Average
        '
        Me.lblEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Average.Location = New System.Drawing.Point(11, 242)
        Me.lblEmployee1Average.Name = "lblEmployee1Average"
        Me.lblEmployee1Average.Size = New System.Drawing.Size(108, 23)
        Me.lblEmployee1Average.TabIndex = 5
        Me.lblEmployee1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblEmployee1Average, "Employee 1 average")
        '
        'lblEmployee2Average
        '
        Me.lblEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Average.Location = New System.Drawing.Point(138, 242)
        Me.lblEmployee2Average.Name = "lblEmployee2Average"
        Me.lblEmployee2Average.Size = New System.Drawing.Size(108, 23)
        Me.lblEmployee2Average.TabIndex = 8
        Me.lblEmployee2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblEmployee2Average, "Employee 2 average")
        '
        'lblEmployee3Average
        '
        Me.lblEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Average.Location = New System.Drawing.Point(264, 242)
        Me.lblEmployee3Average.Name = "lblEmployee3Average"
        Me.lblEmployee3Average.Size = New System.Drawing.Size(108, 23)
        Me.lblEmployee3Average.TabIndex = 11
        Me.lblEmployee3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblEmployee3Average, "Employee 3 average")
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(8, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(58, 17)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "&Day: "
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipUnitsShipped.SetToolTip(Me.lblDay, "Day number")
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(9, 32)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(31, 13)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblEmployee1.Location = New System.Drawing.Point(12, 68)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(101, 13)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee &1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblEmployee2.Location = New System.Drawing.Point(138, 68)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(104, 13)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee &2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblEmployee3.Location = New System.Drawing.Point(264, 68)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(107, 13)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee &3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblEmployee3Average)
        Me.Controls.Add(Me.lblEmployee2Average)
        Me.Controls.Add(Me.lblEmployee1Average)
        Me.Controls.Add(Me.lblEmployee3Units)
        Me.Controls.Add(Me.lblEmployee2Units)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblEmployee1Units)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtUnitsShipped)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "frmUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUnitsShipped As TextBox
    Friend WithEvents lblEmployee1Units As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTipUnitsShipped As ToolTip
    Friend WithEvents lblEmployee2Units As Label
    Friend WithEvents lblEmployee3Units As Label
    Friend WithEvents lblEmployee1Average As Label
    Friend WithEvents lblEmployee2Average As Label
    Friend WithEvents lblEmployee3Average As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
End Class
