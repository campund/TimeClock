Imports MySql.Data.MySqlClient

Public Class standardMain
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public fname As String = Login.fname
    Public lname As String = Login.lname
    Public gradelevel As String = Login.gradelevel


    Dim Time = TimeString

    Dim Date1 As String = System.DateTime.Now.ToString("MM/dd/yy")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label1.Text = "Welcome " & fname & " " & lname & "!"

        Label2.Text = "The current time is: " & Time


    End Sub

    Private Sub clockinButton_Click(sender As Object, e As EventArgs) Handles clockinButton.Click
        MySQLConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySQLConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
        Try

            MySQLConn.Open()

            Dim Query As String

            Query = "Insert into jag.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time & "')"

            COMMAND = New MySqlCommand(Query, MySQLConn)
            READER = COMMAND.ExecuteReader
            count = 0

            MySQLConn.Close()

            MsgBox("Successfully clocked in! Returning you to the home screen!")
            Login.Show()
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.message)
        End Try

    End Sub

    Private Sub ClockoutButton_Click(sender As Object, e As EventArgs) Handles clockoutButton.Click
        ClockoutConfirm.Show()
        Me.Close()

    End Sub
End Class
