Imports System.Text
Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class AdminSearchDialog
    Dim DataSet As DataTable = adminMain.dbDataSet

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim results As New DataView(adminMain.dbDataSet)
        Dim search = TextBox1.Text

        results.RowFilter = String.Format("fname like'%{0}%'", search, Text)

        adminMain.DataGridView1.DataSource = results

        Me.DialogResult = System.Windows.Forms.DialogResult.OK


        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
