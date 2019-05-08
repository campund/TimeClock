Imports MySql.Data.MySqlClient

Public Class Login
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public fname As String
    Public lname As String
    Public gradelevel As String




    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from jag.users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            count = 0
            While READER.Read
                count = count + 1


            End While

            If count = 1 Then
                fname = READER.GetString("First_Name")
                lname = READER.GetString("Last_Name")
                gradelevel = READER.GetString("Grade")
                If gradelevel = "Teacher" Then

                    adminConfirm.Show()
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If


            ElseIf count > 1 Then
                MessageBox.Show("There are more than one username and password for this user")
            Else
                MessageBox.Show("The username/password is incorrect")
            End If

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()

        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"

        Try
            MySqlConn.Open()

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()


        End Try

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        adminConfirm.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("This feature is a work in progress. Contact an administrator to add a user")

        NewUSer.Show()
        Me.Close()

    End Sub
End Class
