
Imports System.Data.OleDb



Public Class StandardUserMenu


    Private Sub StandardUserMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim firstName As String

        Dim lastName As String


        Label1.Text = "Welcome" & firstName & lastName & "!"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim reason As String
        reason = InputBox("What is the reason for leaving?")
        Me.TimesTableAdapter1.Insert("test", "test", "", TimeOfDay, reason)
        MessageBox.Show("Successfully clocked out!", "Time Clock System")
        LoginDialogvb.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.TimesTableAdapter1.Insert("test", "test", TimeOfDay, "", "")
        MessageBox.Show("Successfuly clocked in! Returning to login screen", "Time Clock System")
        LoginDialogvb.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Coming Soon")
    End Sub
End Class
