Imports MySql.Data.MySqlClient

Public Class Login

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public fname As String
    Public lname As String
    Public gradelevel As String
    Public School As String

    Private Function Northview()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306;userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from Northview.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "Northview"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If


            End If

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()

        End Try

    End Function

    Private Function THS()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=THSJAG;password=1367k8vPZUxhP6go;database=TerreHauteSouth; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from TerreHauteSouth.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            count = 0
            While READER.Read
                count += 1


            End While

            If count = 1 Then
                fname = READER.GetString("First_Name")
                lname = READER.GetString("Last_Name")
                gradelevel = READER.GetString("Grade")
                If gradelevel = "Teacher" Then

                    adminConfirm.Show()
                    adminConfirm.SchoolCombo.Text = "Terre Haute South"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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

    End Function

    Private Function THN()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=THNJAG;password=eyfImPSDtOUghm2z;database=TerreHauteNorth; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from TerreHauteNorth.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "Terre Haute North"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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

    End Function

    Private Function WHS()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=WestVigoJAG;password=5C98tdsZOr8iQaTT;database=WestVigo; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from WestVigo.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "West Vigo"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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


    End Function

    Private Function NPHS()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=NPHSJAG;password=UPnLYerIS8sZGLDS;database=North_Putnam; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from North_Putnam.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "North Putnam"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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


    End Function

    Private Function CHS()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from Cloverdale.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "Cloverdale"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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


    End Function

    Private Function RHS()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from Riverton.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "parke heritage"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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


    End Function

    Private Function TRHS()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from TurkeyRun.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "Turkey Run"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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


    End Function
    Private Function SPHS()
        MySqlConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer

        MySqlConn.ConnectionString =
        "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
        Try
            MySqlConn.Open()
            Dim Query As String

            Query = "select * from Cloverdale.Users where Username='" & UsernameTextBox.Text & "'and password='" & PasswordTextBox.Text & "'"

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
                    adminConfirm.SchoolCombo.Text = "Cloverdale"
                    Me.Close()
                Else


                    standardMain.Show()
                    Me.Close()

                End If



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


    End Function
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        School = SchoolCombo.SelectedItem
        If School = "Northview" Then

            Northview()
        ElseIf School = "Terre Haute North" Then

            THN()
        ElseIf School = "Terre Haute South" Then

            THS()
        ElseIf School = "West Vigo" Then

            WHS()
        ElseIf School = "Cloverdale" Then
            CHS()
        ElseIf School = "Parke Heritage" Then

            RHS()
        ElseIf School = "Turkey Run" Then

            TRHS()
        ElseIf School = "North Putnam" Then
            NPHS()
        ElseIf School = "South Putnam" Then
            SPHS()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Sets the school list
        SchoolCombo.Items.Add("Northview")
        SchoolCombo.Items.Add("Terre Haute North")
        SchoolCombo.Items.Add("Terre Haute South")
        SchoolCombo.Items.Add("West Vigo")
        SchoolCombo.Items.Add("Cloverdale")
        SchoolCombo.Items.Add("Parke Peritage")
        SchoolCombo.Items.Add("Turkey Run")
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        adminConfirm.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  MsgBox("This feature is a work in progress. Contact an administrator to add a user")

        NewUSer.Show()
        'Me.Close()

    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub
End Class