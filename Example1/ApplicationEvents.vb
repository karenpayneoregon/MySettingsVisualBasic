Imports System.ComponentModel
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

        End Sub
    End Class
    Partial Friend NotInheritable Class MySettings
        Inherits Configuration.ApplicationSettingsBase

        Private Sub MySettings_SettingChanging(ByVal sender As Object, ByVal e As System.Configuration.SettingChangingEventArgs) Handles Me.SettingChanging

            If (e.SettingName.Equals("ServerName")) Then
                Dim currentServerName = CType(e.NewValue, String)
                If My.Dialogs.Question($"Change server name from {Settings.ServerName} to {currentServerName}?") Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            ElseIf (e.SettingName.Equals("DefaultCatalog")) Then
                Dim currentCatalog = CType(e.NewValue, String)
                If My.Dialogs.Question($"Change catalog from {Settings.DefaultCatalog} to {currentCatalog}?") Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            End If

        End Sub


    End Class

End Namespace
