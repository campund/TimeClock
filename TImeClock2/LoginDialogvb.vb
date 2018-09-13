Imports System.Data.OleDb


Public Class LoginDialogvb

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim myConn As OleDbConnection
        Dim myCmd As OleDbCommand
        Dim myCmd1 As OleDbCommand
        Dim myDr As OleDbDataReader
        Dim myDr1 As OleDbDataReader
        Dim myDT As New DataTable

        Dim firstName As String


        Dim lastName As String

        myConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Logins.accdb")
        myConn.Open()
        myCmd = New OleDbCommand("SELECT Nama,Password,UserLevel FROM Logins WHERE Nama='" & UsernameTextBox.Text & "' AND Password='" & PasswordTextBox.Text & "'", myConn)
        myCmd1 = New OleDbCommand("ELECT FirstName,LastName FROM Logins WHERE FirstName='" & firstName & "' AND LastName='" & lastName & "'", myConn)

        'If UsernameTextBox.Text = "Admin" Then
        'administratorUserMenu.Show()
        ' Me.Close()
        '
        '
        'End If
        '''     myDr1 = myCmd1.ExecuteReader

        myDr = myCmd.ExecuteReader
            myDT.Clear()
            myDT.Load(myDr)



        Try
            If myDT.Rows(0)(0).ToString = UsernameTextBox.Text And myDT.Rows(0)(1).ToString = PasswordTextBox.Text Then
                If myDT.Rows(0)(2).ToString.ToLower = "Administrator" Then
                    'code if the user login as administrator
                    MsgBox("Hello")


                Else
                    'code if user login as standard user
                    StandardUserMenu.Show()
                    StandardUserMenu.Label1.Text = "Welcome" & firstName & lastName & "!"
                    Me.Close()

                End If


            End If
        Catch ex As Exception
            MessageBox.Show("Login Failed.", "Time Clock System")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""

        End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Register.Show()
        Me.Hide()

    End Sub

    Private Sub LoginDialogvb_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim myProcesses() As Process

        Dim myProcess As Process

        myProcesses = Process.GetProcesses()

        For Each myProcess In myProcesses

            If myProcess.MainModule.ModuleName = "explorer.exe" Then

                myProcess.Kill()

                Exit For

            End If

        Next
    End Sub
End Class
