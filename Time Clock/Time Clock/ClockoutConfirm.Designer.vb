<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockoutConfirm
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
        Me.clockOutbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reasonList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'clockOutbutton
        '
        Me.clockOutbutton.Location = New System.Drawing.Point(150, 91)
        Me.clockOutbutton.Name = "clockOutbutton"
        Me.clockOutbutton.Size = New System.Drawing.Size(75, 23)
        Me.clockOutbutton.TabIndex = 0
        Me.clockOutbutton.Text = "Clock Out"
        Me.clockOutbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reason for Clocking Out:"
        '
        'reasonList
        '
        Me.reasonList.FormattingEnabled = True
        Me.reasonList.Location = New System.Drawing.Point(56, 49)
        Me.reasonList.Name = "reasonList"
        Me.reasonList.Size = New System.Drawing.Size(121, 21)
        Me.reasonList.TabIndex = 3
        '
        'ClockoutConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 126)
        Me.ControlBox = False
        Me.Controls.Add(Me.reasonList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clockOutbutton)
        Me.Name = "ClockoutConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClockoutConfirm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clockOutbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents reasonList As ComboBox
End Class
