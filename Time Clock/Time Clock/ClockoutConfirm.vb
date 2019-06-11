Imports MySql.Data.MySqlClient


Public Class ClockoutConfirm
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim fname As String = standardMain.fname
    Dim lname As String = standardMain.lname
    Dim grade As String = standardMain.gradelevel


    Dim Time = TimeString

    Private Sub clockOutbutton_Click(sender As Object, e As EventArgs) Handles clockOutbutton.Click
        If reasonList.SelectedItem = "Another Teacher" Then
            ClockOutTeacher.Show()
        Else

            MySQLConn = New MySqlConnection
            Dim READER As MySqlDataReader
            Dim count As Integer
            Dim reason As String = reasonList.SelectedItem




            MySQLConn.ConnectionString =
                "server=localhost;userid=root;password=Class19;database=jag"
            Try

                MySQLConn.Open()

                Dim Query As String

                Query = "Insert into jag.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

                COMMAND = New MySqlCommand(Query, MySQLConn)
                READER = Command.ExecuteReader
                count = 0

                MySQLConn.Close()
                MsgBox("Successfully clocked out! Returning you to the home screen!")
                Login.Show()
                Me.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub ClockoutConfirm_Load(sender As Object, e As EventArgs) Handles Me.Load
        reasonList.Items.Add("Another Teacher")
        reasonList.Items.Add("Bathroom")
        reasonList.Items.Add("End of Class")
        reasonList.Items.Add("Guidence Department")
        reasonList.Items.Add("Media Center")
        reasonList.Items.Add("Nurse")

    End Sub

End Class