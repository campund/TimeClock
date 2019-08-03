Imports System.Text
Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class AdminSearchDialog
    Dim DataSet As DataTable = adminMain.dbDataSet

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim results As New DataView(adminMain.dbDataSet)
        Dim SearchString As String
        Dim SchoolConn As String
        Dim MySqlConn As New MySqlConnection

        Dim fName1 As String = fName.Text
        Dim lName1 As String = lName.Text
        Dim grade1 As String = grade.Text
        Dim bDate1 As String = beforeDate.Text
        Dim tDate1 As String = toDate.Text

        ' SearchString = results.RowFilter = String.Format("fName like '%{0}%'", fName1, Text OrElse "lName like '%{0}%'", lName1, Text OrElse
        '    "grade like '%{0}%'", grade1, Text)


        '       Dim search = TextBox1.Text
        '      If RadioButton1.Checked = True Then

        ' results.RowFilter = String.Format("fName like'%{0}%'", search, Text)

        ' ElseIf RadioButton2.Checked = True Then
        'results.RowFilter = String.Format("lName like'%{0}%'", search, Text)
        'ElseIf RadioButton3.Checked = True Then
        ' results.RowFilter = String.Format("grade like '%{0}%'", search, Text)
        ' ElseIf RadioButton4.Checked = True Then
        ' results.RowFilter = String.Format("Date like '%{0}%'", search, Text)
        ' End If


        adminMain.DataGridView1.DataSource = results
        MySqlConn.Close()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK


        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AdminSearchDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FNameCheck_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles fNameCheck.CheckedChanged
        If fNameCheck.Checked = True Then
            fName.Enabled = True
        Else
            fName.Enabled = False
        End If
    End Sub

    Private Sub LNameCheck_CheckedChanged(sender As Object, e As EventArgs) Handles lNameCheck.CheckedChanged
        If lNameCheck.Checked = True Then
            lName.Enabled = True
        Else
            lName.Enabled = False
        End If
    End Sub

    Private Sub GradeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles gradeCheck.CheckedChanged
        If gradeCheck.Checked = True Then
            grade.Enabled = True
        Else
            grade.Enabled = False
        End If
    End Sub

    Private Sub BeforedateCheck_CheckedChanged(sender As Object, e As EventArgs) Handles beforedateCheck.CheckedChanged
        If beforedateCheck.Checked = True Then
            beforeDate.Enabled = True
        Else
            beforeDate.Enabled = False
        End If
    End Sub

    Private Sub TodateCheck_CheckedChanged(sender As Object, e As EventArgs) Handles todateCheck.CheckedChanged
        If todateCheck.Checked = True Then
            toDate.Enabled = True
        Else
            toDate.Enabled = False
        End If
    End Sub
End Class
