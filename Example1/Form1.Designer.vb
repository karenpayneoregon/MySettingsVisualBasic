<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.cmdGetServerName = New System.Windows.Forms.Button()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.cmdSetServerName = New System.Windows.Forms.Button()
        Me.txtNewServerName = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdResetSettings = New System.Windows.Forms.Button()
        Me.cmdUserFolderExists = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(800, 359)
        Me.PropertyGrid1.TabIndex = 0
        '
        'cmdGetServerName
        '
        Me.cmdGetServerName.Location = New System.Drawing.Point(12, 381)
        Me.cmdGetServerName.Name = "cmdGetServerName"
        Me.cmdGetServerName.Size = New System.Drawing.Size(121, 23)
        Me.cmdGetServerName.TabIndex = 1
        Me.cmdGetServerName.Text = "Get Server Name"
        Me.cmdGetServerName.UseVisualStyleBackColor = True
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(139, 384)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(144, 20)
        Me.txtServerName.TabIndex = 2
        '
        'cmdSetServerName
        '
        Me.cmdSetServerName.Location = New System.Drawing.Point(12, 410)
        Me.cmdSetServerName.Name = "cmdSetServerName"
        Me.cmdSetServerName.Size = New System.Drawing.Size(121, 23)
        Me.cmdSetServerName.TabIndex = 3
        Me.cmdSetServerName.Text = "Set Server Name"
        Me.cmdSetServerName.UseVisualStyleBackColor = True
        '
        'txtNewServerName
        '
        Me.txtNewServerName.Location = New System.Drawing.Point(139, 412)
        Me.txtNewServerName.Name = "txtNewServerName"
        Me.txtNewServerName.Size = New System.Drawing.Size(144, 20)
        Me.txtNewServerName.TabIndex = 4
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(713, 409)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdResetSettings
        '
        Me.cmdResetSettings.Location = New System.Drawing.Point(331, 381)
        Me.cmdResetSettings.Name = "cmdResetSettings"
        Me.cmdResetSettings.Size = New System.Drawing.Size(121, 23)
        Me.cmdResetSettings.TabIndex = 6
        Me.cmdResetSettings.Text = "Reset"
        Me.cmdResetSettings.UseVisualStyleBackColor = True
        '
        'cmdUserFolderExists
        '
        Me.cmdUserFolderExists.Location = New System.Drawing.Point(331, 412)
        Me.cmdUserFolderExists.Name = "cmdUserFolderExists"
        Me.cmdUserFolderExists.Size = New System.Drawing.Size(121, 23)
        Me.cmdUserFolderExists.TabIndex = 7
        Me.cmdUserFolderExists.Text = "User folder exists"
        Me.cmdUserFolderExists.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdUserFolderExists)
        Me.Controls.Add(Me.cmdResetSettings)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtNewServerName)
        Me.Controls.Add(Me.cmdSetServerName)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.cmdGetServerName)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents cmdGetServerName As Button
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents cmdSetServerName As Button
    Friend WithEvents txtNewServerName As TextBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdResetSettings As Button
    Friend WithEvents cmdUserFolderExists As Button
End Class
