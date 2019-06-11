Imports MySql.Data.MySqlClient


Public Class NewUSer
    Public idnumber As Integer = 0
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub NewUSer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gradeCombo.Items.Add("9")
        gradeCombo.Items.Add("10")
        gradeCombo.Items.Add("11")
        gradeCombo.Items.Add("12")
        gradeCombo.Items.Add("Teacher/Administrator")

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

        If gradeCombo.SelectedItem = "Teacher/Administrator" Then
            Dim response As String
            response = InputBox("Administrator Password Required", "Time Clock Program")
            If response = "JobsForAmericasGraduates" Then
                MySQLConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
                Try

                    MySQLConn.Open()

                    Dim Query As String



                    Query = "INSERT INTO jag.users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"


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
            End If
        Else




            MySQLConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
            Try

                MySQLConn.Open()

                Dim Query As String



                Query = "INSERT INTO jag.users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"


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
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub gradeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradeCombo.SelectedIndexChanged

    End Sub
End Class