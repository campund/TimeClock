Imports System.Text
Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports MySql.Data.MySqlClient

Public Class adminMain
    Public bSource As New BindingSource
    Public dbDataSet As New DataTable
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySQLConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        MySQLConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
        Try

            MySQLConn.Open()

            Dim Query As String
            Query = "select * from jag.users"

            COMMAND = New MySqlCommand(Query, MySQLConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

            count = 0

            MySQLConn.Close()



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySQLConn = New MySqlConnection
        Dim READER As MySqlDataReader
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter


        MySQLConn.ConnectionString =
            "server=localhost;userid=root;password=Class19;database=jag"
        Try

            MySQLConn.Open()

            Dim Query As String
            Query = "select * from jag.attendance"

            COMMAND = New MySqlCommand(Query, MySQLConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

            count = 0

            MySQLConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub exportData_Click(sender As Object, e As EventArgs) Handles exportData.Click
        SaveFileDialog1.Filter = "Microsoft Excel files (*.xlsx*)|*.xlsx"
        SaveFileDialog1.ShowDialog()


        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application

        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file at " & SaveFileDialog1.FileName)





        'Dim str As New StringBuilder
        'For Each dr As DataRow In dbDataSet.Rows


        ' For Each field As Object In dr.ItemArray

        '      str.Append(field.ToString & ",")

        'Next
        '
        '   str.Replace(",", vbNewLine, str.Length - 1, 1)

        '        Next



        'Try

        ' My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, str.ToString, False)

        '     Catch ex As Exception

        '            MessageBox.Show("There was an error while exporting the data. ")
        '
        '        End Try

        'SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        'SaveFileDialog1.ShowDialog()
        ' Dim sFile = SaveFileDialog1.FileName
        ' Using f As New IO.StreamWriter(sFile, True)


        'If SaveFileDialog1.ShowDialog = DialogResult.OK Then



        'Dim col As String = ""

        'Dim row As String = ""
        'Dim i As Integer = 0
        'For Each r As DataGridViewRow In DataGridView1.Rows
        'For Each c As DataGridViewColumn In DataGridView1.Columns
        'row = row & "'" & Convert.ToString(r.Cells(c.HeaderText).Value) & "' "
        ' Next
        '            If i < DataGridView1.Rows.Count - 1 Then row &= Environment.NewLine
        'Next


        'f.WriteLine(row)
        'MessageBox.Show("file created")
        'End If
        'End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AdminSearchDialog.Show()


    End Sub
End Class