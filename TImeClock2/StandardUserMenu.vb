Imports System.ComponentModel
Imports System.Data.OleDb

Public Class StandardUserMenu
    Private Sub StandardUserMenu_Load(sender As Object, e As EventArgs) Handles Me.Load



        'Dim firstName As String = "name"



        'Dim lastName As String = "Name"


        '  Label1.Text = "Welcome " & firstName & " " & lastName & " !"
    End Sub

    Public Sub save()
        Dim firstName As String
        Dim lastName As String
        Dim Time As Date

        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Logins.accdb"
        con = New OleDbConnection(cs)
        con.Open()
        Dim cb As String = "Insert INTO Times (FirstName, LastName, ClockedIN, ClockedOut) Values ('" & firstName & lastName & TimeOfDay & "')"
        cmd = New OleDbCommand(cs)

        con.Close()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim reason As String
        reason = InputBox("What is the reason for leaving?")
        Me.TimesTableAdapter1.Insert("test", "test", "", TimeOfDay, reason)
        save()

        MessageBox.Show("Successfully clocked out!", "Time Clock System")
        LoginDialogvb.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.TimesTableAdapter1.Insert("test", "test", TimeOfDay, "", "")
        MessageBox.Show("Successfuly clocked in! Returning to login screen", "Time Clock System")
        save()

        LoginDialogvb.Show()
        Me.Close()

    End Sub

    Private Sub StandardUserMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class
