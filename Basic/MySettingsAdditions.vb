
Imports System.Configuration
Imports System.IO

Namespace My
    Partial Class MySettings
        Public ReadOnly Property ConfigurationFolder() As String
            Get
                Dim config = ConfigurationManager.
                        OpenExeConfiguration(ConfigurationUserLevel.
                                                PerUserRoamingAndLocal)
                Return config.FilePath.Replace("\user.config", "")
            End Get
        End Property
        Public ReadOnly Property ConfigurationFolderExists() As Boolean
            Get
                Return Directory.Exists(ConfigurationFolder)
            End Get
        End Property
        Public Function ConfigurationFile() As String
            Return Path.GetFileName(ConfigurationManager.
                OpenExeConfiguration(ConfigurationUserLevel.
                                        PerUserRoamingAndLocal).FilePath)
        End Function
    End Class
End Namespace
