Option Strict On
'Author: Quinn Edwards
'Created: April 1st, 2019
'Desc: This program will be a text editor that is able to
'      open, edit and save text files using System.IO

Imports System.IO 'Import System.IO
Public Class frmTextEditor
    'Declare fileStream
    Dim fileStream As FileStream
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAbout.Click
        'Show Message box
        MessageBox.Show("NETD-2202" & vbCrLf & vbCrLf &
                        "Lab# 5" & vbCrLf & vbCrLf &
                        "Quinn Edwards", "About")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        'Close program
        Me.Close()
    End Sub

    Private Sub OpenCtrlOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmOpen.Click
        'Filter OpenFileDialog
        OpenFileDialog.Filter = "Text File|*.txt"

        'If OpenFileDialog selection is valid
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            'fileStream constructor
            fileStream = New FileStream(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read)
            'streamReader with fileStream
            Dim streamReader As New StreamReader(fileStream)
            'Set text to the files text
            txtInput.Text = streamReader.ReadToEnd()
            'Close the streamReader
            streamReader.Close()
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
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        'Reset the text box text
        txtInput.ResetText()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCopy.Click
        'Copy selected text
        My.Computer.Clipboard.SetText(txtInput.SelectedText)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCut.Click
        'Copy selected text
        My.Computer.Clipboard.SetText(txtInput.SelectedText)
        'Remove selected text
        txtInput.SelectedText = String.Empty
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmPaste.Click
        'Paste selected text
        txtInput.Text += My.Computer.Clipboard.GetText()
        'Move to the end
        txtInput.Select(txtInput.MaxLength, txtInput.MaxLength)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmNew.Click
        'Reset Text box text
        txtInput.ResetText()
        'Reset SaveFileDialog
        SaveFileDialog.Reset()
        'Reset OpenFileDialog
        OpenFileDialog.Reset()
        'Filter SaveFileDialog
        SaveFileDialog.Filter = "Text File|*.txt"
    End Sub

    'Save method with string parameter ByVal
    Private Sub Save(ByVal path As String)
        'fileStream constructor
        fileStream = New FileStream(path, FileMode.Create, FileAccess.Write)
        'streamWriter with fileStream
        Dim streamWriter As New StreamWriter(fileStream)
        'Write the text box text to the file
        streamWriter.Write(txtInput.Text)
        'Close streamWriter
        streamWriter.Close()
    End Sub

    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset SaveFileDialog
        SaveFileDialog.Reset()
        'Reset OpenFileDialog
        OpenFileDialog.Reset()
        'Filter SaveFileDialog
        SaveFileDialog.Filter = "Text File|*.txt"
    End Sub
End Class
