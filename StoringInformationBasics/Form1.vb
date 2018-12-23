''' <summary>
''' In this code sample property binding is done by selecting
''' a control, select the property window, select Data -> (ApplicationSettings)
''' then the Text property following by clicking the eclipse button to create
''' a new setting which is part of My.Settings, provide a name and done.
''' </summary>
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.LastUsed = DateTime.MinValue Then
            lblLastOpened.DataBindings.Add("Text", My.Settings, "LastUsed")
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.LastUsed = Now
    End Sub
    ''' <summary>
    ''' Provide a method to reset form elements that persisted via My.Settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkResetSettings_CheckedChanged(sender As Object, e As EventArgs) Handles chkResetSettings.CheckedChanged
        If chkResetSettings.Checked Then
            If My.Dialogs.Question("By pressing yes all settings will revert to their initial values, continue?") Then
                My.Settings.Reset()
                lblLastOpened.DataBindings.Clear()
            Else
                chkResetSettings.Checked = False
            End If
        End If
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class
