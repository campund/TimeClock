<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.accountCombo = New System.Windows.Forms.ComboBox()
        Me.firstnameText = New System.Windows.Forms.TextBox()
        Me.lastnameText = New System.Windows.Forms.TextBox()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.usernameText = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.LoginsTableAdapter1 = New TImeClock2.LoginsTableAdapters.LoginsTableAdapter()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Account Type:"
        '
        'accountCombo
        '
        Me.accountCombo.FormattingEnabled = True
        Me.accountCombo.Location = New System.Drawing.Point(109, 121)
        Me.accountCombo.Name = "accountCombo"
        Me.accountCombo.Size = New System.Drawing.Size(121, 21)
        Me.accountCombo.TabIndex = 5
        '
        'firstnameText
        '
        Me.firstnameText.Location = New System.Drawing.Point(109, 12)
        Me.firstnameText.Name = "firstnameText"
        Me.firstnameText.Size = New System.Drawing.Size(121, 20)
        Me.firstnameText.TabIndex = 6
        '
        'lastnameText
        '
        Me.lastnameText.Location = New System.Drawing.Point(109, 38)
        Me.lastnameText.Name = "lastnameText"
        Me.lastnameText.Size = New System.Drawing.Size(121, 20)
        Me.lastnameText.TabIndex = 7
        '
        'registerButton
        '
        Me.registerButton.Location = New System.Drawing.Point(12, 178)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(75, 23)
        Me.registerButton.TabIndex = 8
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'usernameText
        '
        Me.usernameText.Location = New System.Drawing.Point(109, 66)
        Me.usernameText.Name = "usernameText"
        Me.usernameText.Size = New System.Drawing.Size(121, 20)
        Me.usernameText.TabIndex = 10
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(109, 95)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.Size = New System.Drawing.Size(121, 20)
        Me.passwordText.TabIndex = 11
        '
        'LoginsTableAdapter1
        '
        Me.LoginsTableAdapter1.ClearBeforeFill = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.usernameText)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.lastnameText)
        Me.Controls.Add(Me.firstnameText)
        Me.Controls.Add(Me.accountCombo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents accountCombo As ComboBox
    Friend WithEvents firstnameText As TextBox
    Friend WithEvents lastnameText As TextBox
    Friend WithEvents registerButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents usernameText As TextBox
    Friend WithEvents passwordText As TextBox
    Friend WithEvents LoginsTableAdapter1 As LoginsTableAdapters.LoginsTableAdapter
End Class
