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
        Me.SuspendLayout()
        '
        'firstnameTextBox
        '
        Me.firstnameTextBox.Location = New System.Drawing.Point(117, 42)
        Me.firstnameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.firstnameTextBox.Name = "firstnameTextBox"
        Me.firstnameTextBox.Size = New System.Drawing.Size(148, 26)
        Me.firstnameTextBox.TabIndex = 0
        '
        'lastnameTextBox
        '
        Me.lastnameTextBox.Location = New System.Drawing.Point(117, 106)
        Me.lastnameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lastnameTextBox.Name = "lastnameTextBox"
        Me.lastnameTextBox.Size = New System.Drawing.Size(148, 26)
        Me.lastnameTextBox.TabIndex = 1
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(117, 183)
        Me.usernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(148, 26)
        Me.usernameTextBox.TabIndex = 2
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(117, 258)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(148, 26)
        Me.passwordTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 258)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 343)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Grade Level:"
        '
        'gradeCombo
        '
        Me.gradeCombo.FormattingEnabled = True
        Me.gradeCombo.Location = New System.Drawing.Point(116, 338)
        Me.gradeCombo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gradeCombo.Name = "gradeCombo"
        Me.gradeCombo.Size = New System.Drawing.Size(150, 28)
        Me.gradeCombo.TabIndex = 9
        '
        'registerButton
        '
        Me.registerButton.Location = New System.Drawing.Point(9, 423)
        Me.registerButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(112, 35)
        Me.registerButton.TabIndex = 10
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(154, 423)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NewUSer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 477)
        Me.ControlBox = False
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "NewUSer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "6"
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
End Class
