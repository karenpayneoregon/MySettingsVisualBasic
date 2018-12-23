Imports System.Configuration

Namespace My
    Partial Class MyComputer
        ''' <summary>
        ''' To keep the current implementation of Networks
        ''' use Shadows and create a new instance of Networks.
        ''' </summary>
        ''' <returns></returns>
        Public Shadows ReadOnly Property Network() As Networks
            Get
                Return New Networks
            End Get
        End Property
    End Class
    ''' <summary>
    ''' Create a new Network class which inherits from
    ''' the Framework Network class and add new functionality.
    ''' </summary>
    Public Class Networks
        Inherits Devices.Network
        ''' <summary>
        ''' Get user Network Credentials
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks>
        ''' Parameters must be properly populated to use
        ''' </remarks>
        Public ReadOnly Property Credential() As Net.NetworkCredential
            Get
                Return New Net.NetworkCredential("user", "password", "domain")
            End Get
        End Property
    End Class

End Namespace

