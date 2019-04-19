<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmLab3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmEdit, Me.tsmWindow, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.tsmWindow
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmOpen, Me.tsmSave, Me.tsmSaveAs, Me.tsmClose, Me.tsmExit})
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmFile.Text = "&File"
        Me.tsmFile.ToolTipText = "File options"
        '
        'tsmNew
        '
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsmNew.Size = New System.Drawing.Size(180, 22)
        Me.tsmNew.Text = "&New"
        Me.tsmNew.ToolTipText = "Create a new document"
        '
        'tsmOpen
        '
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmOpen.Size = New System.Drawing.Size(180, 22)
        Me.tsmOpen.Text = "&Open"
        Me.tsmOpen.ToolTipText = "Open a file"
        '
        'tsmSave
        '
        Me.tsmSave.Name = "tsmSave"
        Me.tsmSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmSave.Size = New System.Drawing.Size(180, 22)
        Me.tsmSave.Text = "&Save"
        Me.tsmSave.ToolTipText = "Save current file"
        '
        'tsmSaveAs
        '
        Me.tsmSaveAs.Name = "tsmSaveAs"
        Me.tsmSaveAs.Size = New System.Drawing.Size(180, 22)
        Me.tsmSaveAs.Text = "S&ave As"
        Me.tsmSaveAs.ToolTipText = "Save current file as..."
        '
        'tsmClose
        '
        Me.tsmClose.Name = "tsmClose"
        Me.tsmClose.Size = New System.Drawing.Size(180, 22)
        Me.tsmClose.Text = "&Close"
        Me.tsmClose.ToolTipText = "Close"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(180, 22)
        Me.tsmExit.Text = "E&xit"
        Me.tsmExit.ToolTipText = "Exit program"
        '
        'tsmEdit
        '
        Me.tsmEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCopy, Me.tsmCut, Me.tsmPaste})
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsmEdit.Text = "&Edit"
        Me.tsmEdit.ToolTipText = "Editing options"
        '
        'tsmCopy
        '
        Me.tsmCopy.Name = "tsmCopy"
        Me.tsmCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmCopy.Size = New System.Drawing.Size(180, 22)
        Me.tsmCopy.Text = "&Copy"
        Me.tsmCopy.ToolTipText = "Copy text"
        '
        'tsmCut
        '
        Me.tsmCut.Name = "tsmCut"
        Me.tsmCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.tsmCut.Size = New System.Drawing.Size(180, 22)
        Me.tsmCut.Text = "Cu&t"
        Me.tsmCut.ToolTipText = "Cut text"
        '
        'tsmPaste
        '
        Me.tsmPaste.Name = "tsmPaste"
        Me.tsmPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.tsmPaste.Size = New System.Drawing.Size(180, 22)
        Me.tsmPaste.Text = "&Paste"
        Me.tsmPaste.ToolTipText = "Paste text"
        '
        'tsmWindow
        '
        Me.tsmWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCascade, Me.tsmTileHorizontal, Me.tsmLab3, Me.tsmTileVertical})
        Me.tsmWindow.Name = "tsmWindow"
        Me.tsmWindow.Size = New System.Drawing.Size(63, 20)
        Me.tsmWindow.Text = "&Window"
        '
        'tsmLab3
        '
        Me.tsmLab3.Name = "tsmLab3"
        Me.tsmLab3.Size = New System.Drawing.Size(180, 22)
        Me.tsmLab3.Text = "Average &Units"
        Me.tsmLab3.ToolTipText = "Open lab 3"
        '
        'tsmCascade
        '
        Me.tsmCascade.Name = "tsmCascade"
        Me.tsmCascade.Size = New System.Drawing.Size(180, 22)
        Me.tsmCascade.Text = "Casca&de"
        Me.tsmCascade.ToolTipText = "Cascade forms"
        '
        'tsmTileHorizontal
        '
        Me.tsmTileHorizontal.Name = "tsmTileHorizontal"
        Me.tsmTileHorizontal.Size = New System.Drawing.Size(180, 22)
        Me.tsmTileHorizontal.Text = "Tile &Horizontal"
        Me.tsmTileHorizontal.ToolTipText = "Tile forms horizontally"
        '
        'tsmTileVertical
        '
        Me.tsmTileVertical.Name = "tsmTileVertical"
        Me.tsmTileVertical.Size = New System.Drawing.Size(180, 22)
        Me.tsmTileVertical.Text = "Tile &Vertical"
        Me.tsmTileVertical.ToolTipText = "Tile forms verticlly"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "Help for the program"
        '
        'tsmAbout
        '
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.Size = New System.Drawing.Size(180, 22)
        Me.tsmAbout.Text = "A&bout"
        Me.tsmAbout.ToolTipText = "About this program"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel.Text = "Welcome"
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 450)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents tsmFile As ToolStripMenuItem
    Friend WithEvents tsmEdit As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmNew As ToolStripMenuItem
    Friend WithEvents tsmOpen As ToolStripMenuItem
    Friend WithEvents tsmSave As ToolStripMenuItem
    Friend WithEvents tsmSaveAs As ToolStripMenuItem
    Friend WithEvents tsmClose As ToolStripMenuItem
    Friend WithEvents tsmExit As ToolStripMenuItem
    Friend WithEvents tsmCopy As ToolStripMenuItem
    Friend WithEvents tsmCut As ToolStripMenuItem
    Friend WithEvents tsmPaste As ToolStripMenuItem
    Friend WithEvents tsmAbout As ToolStripMenuItem
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents tsmWindow As ToolStripMenuItem
    Friend WithEvents tsmLab3 As ToolStripMenuItem
    Friend WithEvents tsmCascade As ToolStripMenuItem
    Friend WithEvents tsmTileHorizontal As ToolStripMenuItem
    Friend WithEvents tsmTileVertical As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
End Class
