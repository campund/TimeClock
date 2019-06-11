Imports MySql.Data.MySqlClient

Public Class ClockOutTeacher
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim fname As String = standardMain.fname
    Dim lname As String = standardMain.lname
    Dim grade As String = standardMain.gradelevel


    Dim Time = TimeString

    Private Sub clockOutButton_Click(sender As Object, e As EventArgs) Handles clockOutButton.Click
        MySQLConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer
        Dim reason As String = ClockoutConfirm.reasonList.SelectedItem
        Dim Teacher As String = teacherInput.text



        MySQLConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
        Try

            MySQLConn.Open()

            Dim Query As String

            Query = "Insert into jag.attendance (fname,lname,grade, timeOUT, Reason, TeacherName) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "','" & Teacher & "')"

            COMMAND = New MySqlCommand(Query, MySQLConn)
            READER = COMMAND.ExecuteReader
            count = 0

            MySQLConn.Close()
            MsgBox("Successfully clocked out! Returning you to the home screen!")
            Login.Show()
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClockOutTeacher_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClockoutConfirm.Close()

    End Sub


End Class