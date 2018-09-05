Imports System.Data.OleDb
Public Class LoginDialogvb

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim myConn As OleDbConnection
        Dim myCmd As OleDbCommand
        Dim myDr As OleDbDataReader
        Dim myDT As New DataTable

        myConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Logins.accdb")
        myConn.Open()
        myCmd = New OleDbCommand("SELECT Nama,Password,UserLevel FROM Logins WHERE Nama='" & UsernameTextBox.Text & "' AND Password='" & PasswordTextBox.Text & "'", myConn)
        myDr = myCmd.ExecuteReader
        myDT.Clear()
        myDT.Load(myDr)
        Try
            If myDT.Rows(0)(0).ToString = UsernameTextBox.Text And myDT.Rows(0)(1).ToString = PasswordTextBox.Text Then
                If myDT.Rows(0)(2).ToString.ToLower = "Admin" Then
                    'code if the user login as administrator
                    MsgBox("Hello")
                Else
                    'code if user login as standard user
                    StandardUserMenu.Show()
                    Me.Close()

                End If


            End If
        Catch ex As Exception
            MessageBox.Show("Login Failed. Do you have an account?", "Time Clock System")
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
End Class
