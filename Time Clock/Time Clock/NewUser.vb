Imports MySql.Data.MySqlClient


Public Class NewUSer
    Public idnumber As Integer = 0
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub NewUSer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SchoolCombo.Items.Add("Northview")
        SchoolCombo.Items.Add("Terre Haute North")
        SchoolCombo.Items.Add("Terre Haute South")
        SchoolCombo.Items.Add("West Vigo")
        SchoolCombo.Items.Add("Cloverdale")
        SchoolCombo.Items.Add("Riverton Parke")
        SchoolCombo.Items.Add("Turkey Run")

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
        Dim School As String = SchoolCombo.SelectedItem

        Dim SchoolConn As String
        Dim WriteQuery As String
        If School = "Northview" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
            WriteQuery = "Insert into Northview.Users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"
        ElseIf School = "Terre Haute North" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THNJAG;password=eyfImPSDtOUghm2z;database=TerreHauteNorth; SslMode = none"
            WriteQuery = "Insert into TerreHauteNorth.Users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"


        ElseIf School = "Terre Haute South" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THSJAG;password=1367k8vPZUxhP6go;database=TerreHauteSouth; SslMode = none"
            WriteQuery = "Insert into TerreHauteSouth.Users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"

        ElseIf School = "West Vigo" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=WestVigoJAG;password=5C98tdsZOr8iQaTT;database=WestVigo; SslMode = none"
            WriteQuery = "Insert into WestVigo.Users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"

        ElseIf School = "Cloverdale" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
            WriteQuery = "Insert into Cloverdale.Users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"

        ElseIf School = "Riverton Parke" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
            WriteQuery = "Insert into RivertonParke.Users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"

        ElseIf School = "Turkey Run" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
            WriteQuery = "Insert into TurkeyRun.Users (username,password,First_Name,Last_Name,grade) VALUES ('" & usernameTextBox.Text & "', '" & passwordTextBox.Text & "','" & firstnameTextBox.Text & "', '" & lastnameTextBox.Text & "','" & gradelevel & "')"

        End If

        If gradeCombo.SelectedItem = "Teacher/Administrator" Then
            Dim response As String
            response = InputBox("Administrator Password Required", "Time Clock Program")
            If response = "JobsForAmericasGraduates" Then
                MySQLConn.ConnectionString = SchoolConn

                Try

                    MySQLConn.Open()

                    Dim Query As String
                    Query = WriteQuery


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

            MySQLConn.ConnectionString = SchoolConn

            Try

                MySQLConn.Open()

                Dim Query As String

                Query = WriteQuery


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


End Class