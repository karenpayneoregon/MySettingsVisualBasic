Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Application.InDebugMode Then
            Label1.Text = "Started from Visual Studio"
        Else
            Label1.Text = "Started outside Visual Studio"
        End If

        Label2.Text = $"Folder: {My.Application.Folder}"

        ' Use My.Application.Folder to get files in the application folder
        ListBox1.Items.AddRange(Directory.
            GetFiles(My.Application.Folder).
                Select(Function(file) Path.GetFileName(file)).ToArray())

    End Sub
End Class
