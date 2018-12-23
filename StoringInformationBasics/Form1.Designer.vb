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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastOpened = New System.Windows.Forms.Label()
        Me.chkResetSettings = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(173, 160)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nick name"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.StoringInformationBasics.My.MySettings.Default, "NickName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(82, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = Global.StoringInformationBasics.My.MySettings.Default.NickName
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.StoringInformationBasics.My.MySettings.Default, "LastName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLastName.Location = New System.Drawing.Point(82, 40)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(166, 20)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.Text = Global.StoringInformationBasics.My.MySettings.Default.LastName
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.StoringInformationBasics.My.MySettings.Default, "FirstName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFirstName.Location = New System.Drawing.Point(82, 11)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(166, 20)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.Text = Global.StoringInformationBasics.My.MySettings.Default.FirstName
        '
        'lblLastOpened
        '
        Me.lblLastOpened.AutoSize = True
        Me.lblLastOpened.Location = New System.Drawing.Point(12, 164)
        Me.lblLastOpened.Name = "lblLastOpened"
        Me.lblLastOpened.Size = New System.Drawing.Size(53, 13)
        Me.lblLastOpened.TabIndex = 7
        Me.lblLastOpened.Text = "Last used"
        '
        'chkResetSettings
        '
        Me.chkResetSettings.AutoSize = True
        Me.chkResetSettings.Location = New System.Drawing.Point(21, 131)
        Me.chkResetSettings.Name = "chkResetSettings"
        Me.chkResetSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkResetSettings.Size = New System.Drawing.Size(54, 17)
        Me.chkResetSettings.TabIndex = 3
        Me.chkResetSettings.Text = "Reset"
        Me.chkResetSettings.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email address"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.StoringInformationBasics.My.MySettings.Default, "EmailAddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtEmailAddress.Location = New System.Drawing.Point(82, 99)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(166, 20)
        Me.txtEmailAddress.TabIndex = 9
        Me.txtEmailAddress.Text = Global.StoringInformationBasics.My.MySettings.Default.EmailAddress
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 186)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkResetSettings)
        Me.Controls.Add(Me.lblLastOpened)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bind to My Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblLastOpened As Label
    Friend WithEvents chkResetSettings As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmailAddress As TextBox
End Class
