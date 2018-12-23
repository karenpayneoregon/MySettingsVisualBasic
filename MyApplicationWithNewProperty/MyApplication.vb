Namespace My
    Partial Class MyApplication
        ''' <summary>
        ''' Determine if the application is running in the IDE or outside of the IDE.
        ''' </summary>
        ''' <returns>True if running under the IDE debugger, False if not.</returns>
        Public ReadOnly Property InDebugMode As Boolean
            Get
                Return Debugger.IsAttached
            End Get
        End Property
        ''' <summary>
        ''' Get application folder with trailing backslash.
        ''' </summary>
        ''' <returns>Application folder</returns>
        Public ReadOnly Property Folder() As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory
            End Get
        End Property
    End Class
End Namespace