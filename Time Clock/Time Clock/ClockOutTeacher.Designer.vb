<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockOutTeacher
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
        Me.teacherInput = New System.Windows.Forms.TextBox()
        Me.clockOutButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'teacherInput
        '
        Me.teacherInput.Location = New System.Drawing.Point(12, 65)
        Me.teacherInput.Name = "teacherInput"
        Me.teacherInput.Size = New System.Drawing.Size(385, 20)
        Me.teacherInput.TabIndex = 0
        '
        'clockOutButton
        '
        Me.clockOutButton.Location = New System.Drawing.Point(322, 130)
        Me.clockOutButton.Name = "clockOutButton"
        Me.clockOutButton.Size = New System.Drawing.Size(75, 23)
        Me.clockOutButton.TabIndex = 1
        Me.clockOutButton.Text = "Clock Out"
        Me.clockOutButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please enter your teacher's name below"
        '
        'ClockOutTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clockOutButton)
        Me.Controls.Add(Me.teacherInput)
        Me.Name = "ClockOutTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Name Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents teacherInput As TextBox
    Friend WithEvents clockOutButton As Button
    Friend WithEvents Label1 As Label
End Class
