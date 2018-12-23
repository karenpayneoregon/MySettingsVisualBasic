Imports System.ComponentModel
Imports System.Configuration
Imports System.IO

Namespace My
    Partial Class MySettings
        ''' <summary>
        ''' User configuration folder path on the current computer.
        ''' </summary>
        ''' <returns>The current user's user configuration folder path</returns>
        <Category("Local"), Browsable(True),
            DescriptionAttribute("User configuration folder path")>
        Public ReadOnly Property ConfigurationFolder() As String
            Get
                Dim config = ConfigurationManager.
                        OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
                Return config.FilePath.Replace("\user.config", "")
            End Get
        End Property
        ''' <summary>
        ''' Determines if the current user's configuration folder exists
        ''' </summary>
        ''' <returns>True if folder exists, False if the folder does not exits</returns>
        <Category("Local"), Browsable(True),
            DescriptionAttribute("User configuration folder exists")>
        Public ReadOnly Property ConfigurationFolderExists() As Boolean
            Get
                Return Directory.Exists(ConfigurationFolder)
            End Get
        End Property
        ''' <summary>
        ''' Provides name of current user's configuration file name
        ''' </summary>
        ''' <returns></returns>
        <Category("Local"), Browsable(True),
            DescriptionAttribute("User configuration file name")>
        Public Function ConfigurationFile() As String
            Return Path.GetFileName(ConfigurationManager.
                OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath)
        End Function
        ''' <summary>
        ''' Get shared folder
        ''' </summary>
        ''' <returns>Shared folder path</returns>
        <Category("Local"), Browsable(True),
            DescriptionAttribute("Folder where common settings are stored")>
        Public ReadOnly Property SharedFolder() As String
            Get
                Return Path.Combine(Environment.
                    GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "MyData")
            End Get
        End Property
        <Category("Local"), Browsable(True),
            DescriptionAttribute("Indicates common settings folder exists")>
        Public ReadOnly Property SharedFolderExists() As Boolean
            Get
                Return Directory.Exists(SharedFolder)
            End Get
        End Property
        <Category("Local"), Browsable(True),
            DescriptionAttribute("Indicates common file name")>
        Public ReadOnly Property CommonConfigurationFileName() As String
            Get
                Return Path.Combine(SharedFolder, "common.xml")
            End Get
        End Property
        <Category("Local"), Browsable(True),
            DescriptionAttribute("Indicates common settings file exists")>
        Public ReadOnly Property CommonFigurationFileExists() As Boolean
            Get
                Return File.Exists(CommonConfigurationFileName)
            End Get
        End Property

        Private _fileMap As ConfigurationFileMap
        Private _configuration As Configuration
        Private _fileName As String

        ''' <summary>
        ''' Get shared server name
        ''' </summary>
        ''' <returns>shared server name from common configuration file</returns>
        <Category("Shared"), Browsable(False)>
        Public ReadOnly Property GetServerName() As String
            Get
                Return _configuration.AppSettings.Settings("ServerName").Value
            End Get
        End Property
        ''' <summary>
        ''' Set shared server name to common configuration file
        ''' </summary>
        ''' <param name="pValue">Server name</param>
        <Category("Shared"), Browsable(False)>
        Public Sub SetServerName(pValue As String)
            _configuration.AppSettings.Settings("ServerName").Value = pValue
            _configuration.Save()
        End Sub
        <Category("Shared"), Browsable(True),
            DescriptionAttribute("Default server")>
        Public Property ServerInGrid() As String
            Get
                Return _configuration.AppSettings.Settings("ServerName").Value
            End Get
            Set
                _configuration.AppSettings.Settings("ServerName").Value = Value
                _configuration.Save()
            End Set
        End Property

        <Category("Shared"), Browsable(True),
            DescriptionAttribute("Default server")>
        Public Property DatabaseInGrid() As String
            Get
                Return _configuration.AppSettings.Settings("DefaultCatalog").Value
            End Get
            Set
                _configuration.AppSettings.Settings("DefaultCatalog").Value = Value
                _configuration.Save()
            End Set
        End Property

        ''' <summary>
        ''' Get default catalog
        ''' </summary>
        ''' <returns>Default catalog from common configuration file</returns>
        <Category("Shared"), Browsable(False)>
        Public ReadOnly Property GetDefaultCatalog() As String
            Get
                Return _configuration.AppSettings.Settings("DefaultCatalog").Value
            End Get
        End Property
        <Category("Shared"), Browsable(True),
            DescriptionAttribute("Default database")>
        Public ReadOnly Property Database() As String
            Get
                Return GetDefaultCatalog()
            End Get
        End Property
        <Category("Shared"), Browsable(True),
            DescriptionAttribute("Default server")>
        Public ReadOnly Property Server() As String
            Get
                Return GetServerName()
            End Get
        End Property
        ''' <summary>
        ''' Set default catalog to common configuration file
        ''' </summary>
        ''' <param name="pValue">Server name</param>
        <Category("Shared"), Browsable(True)>
        Public Sub SetDefaultCatalog(pValue As String)
            _configuration.AppSettings.Settings("DefaultCatalog").Value = pValue
            _configuration.Save()
        End Sub
        Public Sub New()
            _fileName = CommonConfigurationFileName
            _fileMap = New ConfigurationFileMap(_fileName)
            _configuration = ConfigurationManager.OpenMappedMachineConfiguration(_fileMap)
        End Sub
    End Class
End Namespace
