Imports MySql.Data.MySqlClient



Public Class standardMain
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public fname As String = Login.fname
    Public lname As String = Login.lname
    Public gradelevel As String = Login.gradelevel
    Public School As String = Login.School


    Public Time1 = TimeString

    Public Date1 As String = System.DateTime.Now.ToString("MM/dd/yy")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label1.Text = "Welcome " & fname & " " & lname & "! "

        Label2.Text = "The current time is: " & Time1


    End Sub

    Private Sub clockinButton_Click(sender As Object, e As EventArgs) Handles clockinButton.Click
        MySQLConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer
        Dim SchoolConn As String
        Dim WriteQuery As String
        If School = "Northview" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
            WriteQuery = "Insert into Northview.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time1 & "')"
        ElseIf School = "Terre Haute North" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THNJAG;password=eyfImPSDtOUghm2z;database=TerreHauteNorth; SslMode = none"
            WriteQuery = "Insert into TerreHauteNorth.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time1 & "')"


        ElseIf School = "Terre Haute South" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THSJAG;password=1367k8vPZUxhP6go;database=TerreHauteSouth; SslMode = none"
            WriteQuery = "Insert into TerreHauteSouth.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time1 & "')"

        ElseIf School = "West Vigo" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=WestVigoJAG;password=5C98tdsZOr8iQaTT;database=WestVigo; SslMode = none"
            WriteQuery = "Insert into WestVigo.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time1 & "')"

        ElseIf School = "Cloverdale" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
            WriteQuery = "Insert into Cloverdale.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time1 & "')"

        ElseIf School = "Riverton Parke" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
            WriteQuery = "Insert into RivertonParke.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time1 & "')"

        ElseIf School = "Turkey Run" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
            WriteQuery = "Insert into TurkeyRun.attendance (fname,lname,grade,Date,timeIN) values ('" & fname & "','" & lname & "','" & gradelevel & "','" & Date1 & "','" & Time1 & "')"

        End If


        MySQLConn.ConnectionString = SchoolConn

        Try

            MySQLConn.Open()

            Dim Query As String

            Query = WriteQuery

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
