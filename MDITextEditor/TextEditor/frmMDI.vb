Option Strict On
'Author: Quinn Edwards
'Created: April 1st, 2019
'Desc: This program will be a MDI text editor that is able to
'      open, edit and save text files using System.IO and can
'      open lab 3 in a form

Imports System.IO
Imports System.Linq

Public Class frmTextEditor
    'Declare fileStream
    Dim fileStream As FileStream
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAbout.Click
        'Show Message box
        MessageBox.Show("NETD-2202" & vbCrLf & vbCrLf &
                        "Lab# 6" & vbCrLf & vbCrLf &
                        "Quinn Edwards", "About")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        'Close program
        Me.Close()
    End Sub

    Private Sub OpenCtrlOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmOpen.Click
        'Show open dialog and if its ok
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            'New form
            Dim newTextForm As New frmSubForm
            'Set mdi parent
            newTextForm.MdiParent = Me
            'Set name to file path
            newTextForm.Text = System.IO.Path.GetFullPath(OpenFileDialog.FileName)
            'Update status strip
            ToolStripStatusLabel.Text = "Opened"
            Try
                fileStream = New FileStream(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read)
                Dim inputStream As New StreamReader(fileStream)
                newTextForm.txtText.Text = inputStream.ReadToEnd
                inputStream.Close()
                'show new sub form
                newTextForm.Show()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        Else
            ToolStripStatusLabel.Text = "Opening"
        End If
    End Sub

    Private Sub SaveCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmSave.Click
        'If there is not a selected file
        If OpenFileDialog.FileName = String.Empty Then
            'Open SaveFileDialog
            If SaveFileDialog.ShowDialog = DialogResult.OK Then
                'Save file
                Save(SaveFileDialog.FileName)
            End If
        Else
            'Save file
            Save(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmSaveAs.Click
        'Open SaveFileDialog
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            'Save file
            Save(SaveFileDialog.FileName)
        Else
            ToolStripStatusLabel.Text = "Saving"
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        If Me.MdiChildren.Length > 0 Then
            Dim activeForm As frmSubForm = DirectCast(Me.ActiveMdiChild, frmSubForm)
            activeForm.Close()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCopy.Click
        Dim activeForm As frmSubForm = DirectCast(Me.ActiveMdiChild, frmSubForm)
        If Me.MdiChildren.Length > 0 Then
            'Copy selected text
            My.Computer.Clipboard.SetText(activeForm.txtText.SelectedText)
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCut.Click
        Dim activeForm As frmSubForm = DirectCast(Me.ActiveMdiChild, frmSubForm)
        If MdiChildren.Length > 0 Then
            'Copy selected text
            My.Computer.Clipboard.SetText(activeForm.txtText.SelectedText)
            'Remove selected text
            activeForm.txtText.SelectedText = String.Empty
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmPaste.Click
        Dim activeForm As frmSubForm = DirectCast(Me.ActiveMdiChild, frmSubForm)
        'Paste selected text
        If Me.MdiChildren.Length > 0 Then
            'Paste selected text
            activeForm.txtText.Text += My.Computer.Clipboard.GetText()
            'Move to the end
            activeForm.txtText.Select(activeForm.txtText.SelectionStart, activeForm.txtText.SelectionStart)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmNew.Click
        'new sub form
        Dim newForm As New frmSubForm
        newForm.MdiParent = Me
        Try
            newForm.Text = "Untitled"
            newForm.Show()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    'Save method with string parameter ByVal
    Private Sub Save(ByVal path As String)
        ToolStripStatusLabel.Text = "Saving"
        Dim activeForm As frmSubForm = DirectCast(Me.ActiveMdiChild, frmSubForm)
        'fileStream constructor
        fileStream = New FileStream(path, FileMode.Create, FileAccess.Write)
        'streamWriter with fileStream
        Dim streamWriter As New StreamWriter(fileStream)
        'Write the text box text to the file
        streamWriter.Write(activeForm.txtText.Text)
        'Close streamWriter
        streamWriter.Close()
        ToolStripStatusLabel.Text = "Saved"
    End Sub

    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset SaveFileDialog
        SaveFileDialog.Reset()
        'Reset OpenFileDialog
        OpenFileDialog.Reset()
        'Filter SaveFileDialog
        SaveFileDialog.Filter = "Text File|*.txt"
    End Sub

    Private Sub Lab3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmLab3.Click
        'new sub form
        Dim newLabWindow As New frmUnitsShipped
        newLabWindow.MdiParent = Me
        newLabWindow.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
