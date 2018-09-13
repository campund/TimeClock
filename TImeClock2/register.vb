Public Class Register
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginDialogvb.Show()
        Me.Close()

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        LoginsTableAdapter1.Insert(usernameText.Text, passwordText.Text, accountCombo.Text, firstnameText.Text, lastnameText.Text)

        MessageBox.Show("Successfully Registered!")
        LoginDialogvb.Show()
        Me.Close()

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles Me.Load
        accountCombo.Items.Add("Administrator")
        accountCombo.Items.Add("Standard")

    End Sub
End Class