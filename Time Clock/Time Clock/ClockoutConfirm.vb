Imports MySql.Data.MySqlClient


Public Class ClockoutConfirm
    Public Function MySQLTimeCalc()

    End Function

    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim fname As String = standardMain.fname
    Dim lname As String = standardMain.lname
    Dim grade As String = standardMain.gradelevel
    Dim School As String = standardMain.School

    Dim Time = TimeString


    Private Sub clockOutbutton_Click(sender As Object, e As EventArgs) Handles clockOutbutton.Click
        If reasonList.SelectedItem = "Another Teacher" Then
            ClockOutTeacher.Show()
        Else

            MySQLConn = New MySqlConnection
            Dim READER As MySqlDataReader
            Dim count As Integer
            Dim reason As String = reasonList.SelectedItem

            Dim SchoolConn As String
            Dim WriteQuery As String
            If School = "Northview" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
                WriteQuery = "Insert into Northview.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"
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

            ElseIf School = "Riverton Parke" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
                WriteQuery = "Insert into RivertonParke.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

            ElseIf School = "Turkey Run" Then
                SchoolConn = "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
                WriteQuery = "Insert into TurkeyRun.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

            End If


            '   MySQLConn.ConnectionString = 

            Try

                MySQLConn.Open()

                Dim Query As String

                Query = "Insert into jag.attendance (fname,lname,grade, timeOUT, Reason) values ('" & fname & "','" & lname & "','" & grade & "','" & Time & "','" & reason & "')"

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