<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUSer
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
        Me.firstnameTextBox = New System.Windows.Forms.TextBox()
        Me.lastnameTextBox = New System.Windows.Forms.TextBox()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gradeCombo = New System.Windows.Forms.ComboBox()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SchoolCombo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'firstnameTextBox
        '
        Me.firstnameTextBox.Location = New System.Drawing.Point(76, 54)
        Me.firstnameTextBox.Name = "firstnameTextBox"
        Me.firstnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.firstnameTextBox.TabIndex = 0
        '
        'lastnameTextBox
        '
        Me.lastnameTextBox.Location = New System.Drawing.Point(76, 96)
        Me.lastnameTextBox.Name = "lastnameTextBox"
        Me.lastnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lastnameTextBox.TabIndex = 1
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(76, 146)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.usernameTextBox.TabIndex = 2
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(76, 195)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Grade Level:"
        '
        'gradeCombo
        '
        Me.gradeCombo.FormattingEnabled = True
        Me.gradeCombo.Location = New System.Drawing.Point(75, 247)
        Me.gradeCombo.Name = "gradeCombo"
        Me.gradeCombo.Size = New System.Drawing.Size(101, 21)
        Me.gradeCombo.TabIndex = 9
        '
        'registerButton
        '
        Me.registerButton.Location = New System.Drawing.Point(4, 302)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(75, 23)
        Me.registerButton.TabIndex = 10
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(101, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "School:"
        '
        'SchoolCombo
        '
        Me.SchoolCombo.FormattingEnabled = True
        Me.SchoolCombo.Location = New System.Drawing.Point(71, 19)
        Me.SchoolCombo.Name = "SchoolCombo"
        Me.SchoolCombo.Size = New System.Drawing.Size(105, 21)
        Me.SchoolCombo.TabIndex = 13
        '
        'NewUSer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.SchoolCombo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.gradeCombo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.lastnameTextBox)
        Me.Controls.Add(Me.firstnameTextBox)
        Me.Name = "NewUSer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gradeCombo As ComboBox
    Friend WithEvents registerButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SchoolCombo As ComboBox
End Class
