Imports System.Windows.Forms

Public Class adminConfirm
    Public School As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim password As String = TextBox1.Text


        If password = "JobsForAmericasGraduates" Then
            School = SchoolCombo.SelectedItem

            adminMain.Show()
            Me.Hide()

        Else
            MsgBox("Incorrect Password. Returning to the home page")
            Login.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub adminConfirm_Load(sender As Object, e As EventArgs) Handles Me.Load


        SchoolCombo.Items.Add("Northview")
        SchoolCombo.Items.Add("Terre Haute North")
        SchoolCombo.Items.Add("Terre Haute South")
        SchoolCombo.Items.Add("West Vigo")
        SchoolCombo.Items.Add("Cloverdale")
        SchoolCombo.Items.Add("Riverton Parke")
        SchoolCombo.Items.Add("Turkey Run")
    End Sub
End Class
