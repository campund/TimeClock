Imports MySql.Data.MySqlClient


Public Class NewUSer
    Public idnumber As Integer = 0
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub NewUSer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gradeCombo.Items.Add("11")
        gradeCombo.Items.Add("12")

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        MySQLConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer
        Dim fname As String = firstnameTextBox.Text
        Dim lname As String = lastnameTextBox.Text
        Dim username As String = usernameTextBox.Text
        Dim password As String = passwordTextBox.Text
        Dim gradelevel As String = gradeCombo.SelectedItem

        MySQLConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
        Try

            MySQLConn.Open()

            Dim Query As String


            Query = "INSERT INTO jag.users ( 'username', 'password', 'First_Name', 'Last_Name', 'grade') VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"
            COMMAND = New MySqlCommand(Query, MySQLConn)
            READER = COMMAND.ExecuteReader
            count = 0

            MySQLConn.Close()

            MsgBox("User created! Returning you to the home screen!")
            Login.Show()
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()

    End Sub
End Class