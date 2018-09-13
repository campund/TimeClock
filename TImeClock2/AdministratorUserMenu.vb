Imports System.Data.OleDb


Public Class administratorUserMenu
    Private Sub administratorUserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Logins.Times' table. You can move, or remove it, as needed.
        Me.TimesTableAdapter.Fill(Me.Logins.Times)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer As String


        answer = InputBox("Input Name to search")


    End Sub
End Class