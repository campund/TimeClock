Imports MySql.Data.MySqlClient


Public Class ClockoutConfirm
    Public Function MySQLTimeCalc()

    End Function

    Dim MySQLConn As MySqlConnection
    Public READER As MySqlDataReader

    Dim COMMAND As MySqlCommand
    Dim fname As String = standardMain.fname
    Dim lname As String = standardMain.lname
    Dim grade As String = standardMain.gradelevel
    Dim School As String = standardMain.School
    '   Dim clockinTime As String = standardMain.Time1
    Dim Date1 As String = standardMain.Date1

    Dim Time = TimeString

    Dim TimeQuery As String = "TIMEDIFF(TimeOUT, TimeIN)"

    Private Sub clockOutbutton_Click(sender As Object, e As EventArgs) Handles clockOutbutton.Click
        If reasonList.SelectedItem = "Another Teacher" Then
            ClockOutTeacher.Show()
        Else
            'Reads the Clock In time
            Dim SchoolConn As String
            Dim ReadQuery As String
            Dim Query As String
            Dim Query1 As String

            Dim READER As MySqlDataReader
            Dim count As Integer
            Dim ClockInTime As String
            MySQLConn = New MySqlConnection
            If School = "Northview" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
                ReadQuery = "SELECT * FROM Northview.attendance WHERE fName='" & fname & " and lName=" & lname & " and grade=" & grade & " and Date=" & Date1 & "'"
            ElseIf School = "Terre Haute North" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=THNJAG;password=eyfImPSDtOUghm2z;database=TerreHauteNorth; SslMode = none"
                ReadQuery = "SELECT * FROM TerreHauteNorth.attendance"

            ElseIf School = "Terre Haute South" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=THSJAG;password=1367k8vPZUxhP6go;database=TerreHauteSouth; SslMode = none"
                ReadQuery = "SELECT * FROM TerreHauteSouth.attendance"

            ElseIf School = "West Vigo" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=WestVigoJAG;password=5C98tdsZOr8iQaTT;database=WestVigo; SslMode = none"
                ReadQuery = "SELECT * FROM WestVigo.attendance"

            ElseIf School = "Cloverdale" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
                ReadQuery = "SELECT * FROM Cloverdale.attendance"

            ElseIf School = "Parke Heritage" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
                ReadQuery = "SELECT * FROM RivertonParke.attendance"

            ElseIf School = "Turkey Run" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
                ReadQuery = "SELECT * FROM TurkeyRun.attendance"

            End If

            MySQLConn.ConnectionString = SchoolConn

            Try

                MySQLConn.Open()
                COMMAND = New MySqlCommand(ReadQuery, MySQLConn)
                Query = ReadQuery

                READER = COMMAND.ExecuteReader
                count = 0
                While READER.Read
                    count = count + 1
                End While

                If count = 1 Then
                    ClockInTime = READER.GetString("TimeIN")
                ElseIf Count > 1 Then
                    MsgBox("Unable to pull the Time Clocked In")
                End If


            Catch ex As Exception

            End Try

            MySQLConn.Close()

            '  Writes the update query
            MySQLConn = New MySqlConnection
            Dim UpdateQuery As String


            Dim reason As String = reasonList.SelectedItem


            Dim WriteQuery As String




            'End If

            If School = "Northview" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
                WriteQuery = "Insert into Northview.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"
                UpdateQuery = "update Northview.attendance SET TimeOUT = '" & Time & ", Reason = " & reason & "' WHERE fName = '" & fname & "' AND lName = '" & lname & "' AND Date = '" & Date1 & "' AND TimeIN = '" & clockinTime & "'"

            ElseIf School = "Terre Haute North" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=THNJAG;password=eyfImPSDtOUghm2z;database=TerreHauteNorth; SslMode = none"
                WriteQuery = "Insert into TerreHauteNorth.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"


            ElseIf School = "Terre Haute South" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=THSJAG;password=1367k8vPZUxhP6go;database=TerreHauteSouth; SslMode = none"
                WriteQuery = "Insert into TerreHauteSouth.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

            ElseIf School = "West Vigo" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=WestVigoJAG;password=5C98tdsZOr8iQaTT;database=WestVigo; SslMode = none"
                WriteQuery = "Insert into WestVigo.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

            ElseIf School = "Cloverdale" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
                WriteQuery = "Insert into Cloverdale.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

            ElseIf School = "parke heritage" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
                WriteQuery = "Insert into RivertonParke.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

            ElseIf School = "Turkey Run" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
                WriteQuery = "Insert into TurkeyRun.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

            End If


            MySQLConn.ConnectionString = SchoolConn

            Try


                MySQLConn.Open()



                Query1 = UpdateQuery
                COMMAND = New MySqlCommand(Query1, MySQLConn)
                '  COMMAND.Parameters.Add("@lName", MySqlDbType.Text).Value = fname
                ' COMMAND.Parameters.Add("@lName", MySqlDbType.Text).Value = lname
                READER = COMMAND.ExecuteReader
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