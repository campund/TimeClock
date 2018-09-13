Public Class StudentList
    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Logins.Times' table. You can move, or remove it, as needed.
        Me.TimesTableAdapter.Fill(Me.Logins.Times)

    End Sub
End Class