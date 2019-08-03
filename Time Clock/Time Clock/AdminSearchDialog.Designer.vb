<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSearchDialog
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.toDate = New System.Windows.Forms.TextBox()
        Me.beforeDate = New System.Windows.Forms.TextBox()
        Me.grade = New System.Windows.Forms.TextBox()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.todateCheck = New System.Windows.Forms.CheckBox()
        Me.beforedateCheck = New System.Windows.Forms.CheckBox()
        Me.gradeCheck = New System.Windows.Forms.CheckBox()
        Me.lNameCheck = New System.Windows.Forms.CheckBox()
        Me.fNameCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(282, 197)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(355, 197)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'toDate
        '
        Me.toDate.Enabled = False
        Me.toDate.Location = New System.Drawing.Point(155, 169)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(283, 20)
        Me.toDate.TabIndex = 23
        Me.toDate.Text = "Feature Coming Soon"
        Me.toDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'beforeDate
        '
        Me.beforeDate.Enabled = False
        Me.beforeDate.Location = New System.Drawing.Point(155, 126)
        Me.beforeDate.Name = "beforeDate"
        Me.beforeDate.Size = New System.Drawing.Size(283, 20)
        Me.beforeDate.TabIndex = 22
        Me.beforeDate.Text = "Feature Coming Soon"
        Me.beforeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grade
        '
        Me.grade.Enabled = False
        Me.grade.Location = New System.Drawing.Point(155, 83)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(283, 20)
        Me.grade.TabIndex = 21
        '
        'lName
        '
        Me.lName.Enabled = False
        Me.lName.Location = New System.Drawing.Point(155, 43)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(283, 20)
        Me.lName.TabIndex = 20
        '
        'fName
        '
        Me.fName.Enabled = False
        Me.fName.Location = New System.Drawing.Point(155, 12)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(283, 20)
        Me.fName.TabIndex = 19
        '
        'todateCheck
        '
        Me.todateCheck.AutoSize = True
        Me.todateCheck.Location = New System.Drawing.Point(12, 172)
        Me.todateCheck.Name = "todateCheck"
        Me.todateCheck.Size = New System.Drawing.Size(65, 17)
        Me.todateCheck.TabIndex = 18
        Me.todateCheck.Text = "To Date"
        Me.todateCheck.UseVisualStyleBackColor = True
        '
        'beforedateCheck
        '
        Me.beforedateCheck.AutoSize = True
        Me.beforedateCheck.Location = New System.Drawing.Point(12, 126)
        Me.beforedateCheck.Name = "beforedateCheck"
        Me.beforedateCheck.Size = New System.Drawing.Size(83, 17)
        Me.beforedateCheck.TabIndex = 17
        Me.beforedateCheck.Text = "Before Date"
        Me.beforedateCheck.UseVisualStyleBackColor = True
        '
        'gradeCheck
        '
        Me.gradeCheck.AutoSize = True
        Me.gradeCheck.Location = New System.Drawing.Point(12, 83)
        Me.gradeCheck.Name = "gradeCheck"
        Me.gradeCheck.Size = New System.Drawing.Size(84, 17)
        Me.gradeCheck.TabIndex = 16
        Me.gradeCheck.Text = "Grade Level"
        Me.gradeCheck.UseVisualStyleBackColor = True
        '
        'lNameCheck
        '
        Me.lNameCheck.AutoSize = True
        Me.lNameCheck.Location = New System.Drawing.Point(12, 46)
        Me.lNameCheck.Name = "lNameCheck"
        Me.lNameCheck.Size = New System.Drawing.Size(77, 17)
        Me.lNameCheck.TabIndex = 15
        Me.lNameCheck.Text = "Last Name"
        Me.lNameCheck.UseVisualStyleBackColor = True
        '
        'fNameCheck
        '
        Me.fNameCheck.AutoSize = True
        Me.fNameCheck.Location = New System.Drawing.Point(12, 12)
        Me.fNameCheck.Name = "fNameCheck"
        Me.fNameCheck.Size = New System.Drawing.Size(76, 17)
        Me.fNameCheck.TabIndex = 14
        Me.fNameCheck.Text = "First Name"
        Me.fNameCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "All Dates need to be formatted like this: MM/DD/YYYY"
        '
        'AdminSearchDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(450, 228)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toDate)
        Me.Controls.Add(Me.beforeDate)
        Me.Controls.Add(Me.grade)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.todateCheck)
        Me.Controls.Add(Me.beforedateCheck)
        Me.Controls.Add(Me.gradeCheck)
        Me.Controls.Add(Me.lNameCheck)
        Me.Controls.Add(Me.fNameCheck)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminSearchDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents toDate As TextBox
    Friend WithEvents beforeDate As TextBox
    Friend WithEvents grade As TextBox
    Friend WithEvents lName As TextBox
    Friend WithEvents fName As TextBox
    Friend WithEvents todateCheck As CheckBox
    Friend WithEvents beforedateCheck As CheckBox
    Friend WithEvents gradeCheck As CheckBox
    Friend WithEvents lNameCheck As CheckBox
    Friend WithEvents fNameCheck As CheckBox
    Friend WithEvents Label1 As Label
End Class
