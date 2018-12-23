Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PropertyGrid1.SelectedObject = My.Settings


        If My.Settings.SharedFolderExists Then
            Console.WriteLine($"       Shared folder: {My.Settings.SharedFolder}")
            Console.WriteLine($"         Shared file: {My.Settings.CommonConfigurationFileName}")
            Console.WriteLine($"  Shared file exists: {My.Settings.CommonFigurationFileExists}")

            txtServerName.Text = My.Settings.GetServerName

        End If

    End Sub
    ''' <summary>
    ''' Assign GetServerName to TextBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdGetServerName_Click(sender As Object, e As EventArgs) Handles cmdGetServerName.Click

        txtServerName.Text = My.Settings.GetServerName

    End Sub
    ''' <summary>
    ''' Manually refresh property grid which could also be done in 
    ''' <see cref="PropertyGrid1_PropertyValueChanged"/>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdSetServerName_Click(sender As Object, e As EventArgs) Handles cmdSetServerName.Click

        My.Settings.SetServerName(txtNewServerName.Text)
        PropertyGrid1.Refresh()

    End Sub
    ''' <summary>
    ''' Listen for changes for a property under My.Settings
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="e"></param>
    Private Sub PropertyGrid1_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) _
        Handles PropertyGrid1.PropertyValueChanged

        If e.ChangedItem.Label = "ServerInGrid" Then
            PropertyGrid1.Refresh()
        End If

    End Sub
    ''' <summary>
    ''' Provides method to reset My.Settings to values in app.config
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdResetSettings_Click(sender As Object, e As EventArgs) Handles cmdResetSettings.Click
        If My.Dialogs.Question("Selecting yes will reset all settings to default value, continue?") Then
            My.Settings.Reset()
        End If
    End Sub
    ''' <summary>
    ''' Detects if user settings folder exists, if so prompts to open the folder
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdUserFolderExists_Click(sender As Object, e As EventArgs) Handles cmdUserFolderExists.Click
        If My.Settings.ConfigurationFolderExists Then
            If My.Dialogs.Question("Folder exists, open the folder in Windows Explorer?") Then
                Process.Start(My.Settings.ConfigurationFolder)
            End If
        Else
            My.Dialogs.InformationDialog("User configuration folder does not exists")
        End If
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

End Class
