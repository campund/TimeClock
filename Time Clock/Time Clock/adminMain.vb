Imports System.Text
Imports System.Data.SqlClient
Imports Microsoft.Office.Core

Imports MySql.Data.MySqlClient


Public Class adminMain
    Public Export1 As String
    Public Export2 As String
    Public bSource As New BindingSource
    Public dbDataSet As New DataTable
    Dim MySQLConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    'Username Table
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
        Export1 = True
        Export2 = False
        Dim School As String = adminConfirm.School
        MySQLConn = New MySqlConnection
        Dim SchoolConn As String
        Dim ReadQuery As String

        Dim READER As MySqlDataReader
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        If School = "Northview" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
            ReadQuery = "SELECT * FROM Northview.Users"
        ElseIf School = "Terre Haute North" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THNJAG;password=eyfImPSDtOUghm2z;database=TerreHauteNorth; SslMode = none"
            ReadQuery = "SELECT * FROM TerreHauteNorth.Users"

        ElseIf School = "Terre Haute South" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THSJAG;password=1367k8vPZUxhP6go;database=TerreHauteSouth; SslMode = none"
            ReadQuery = "SELECT * FROM TerreHauteSouth.Users"

        ElseIf School = "West Vigo" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=WestVigoJAG;password=5C98tdsZOr8iQaTT;database=WestVigo; SslMode = none"
            ReadQuery = "SELECT * FROM WestVigo.Users"

        ElseIf School = "Cloverdale" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
            ReadQuery = "SELECT * FROM Cloverdale.Users"

        ElseIf School = "Parke Heritage" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
            ReadQuery = "SELECT * FROM RivertonParke.Users"

        ElseIf School = "Turkey Run" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
            ReadQuery = "SELECT * FROM TurkeyRun.Users"

        End If


        MySQLConn.ConnectionString = SchoolConn

        Try

            MySQLConn.Open()

            Dim Query As String
            Query = ReadQuery

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

    'Attendance Database Table
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button2.Enabled = False
        Button4.Enabled = True
        Dim school As String = adminConfirm.School

        MySQLConn = New MySqlConnection
        Dim SchoolConn As String
        Dim ReadQuery As String

        Dim READER As MySqlDataReader
        Dim count As Integer
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        If School = "Northview" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=NHSJAG;password=NFG0Muo4w45wKxzS;database=Northview; SslMode = none"
            ReadQuery = "SELECT * FROM Northview.attendance"
        ElseIf School = "Terre Haute North" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THNJAG;password=eyfImPSDtOUghm2z;database=TerreHauteNorth; SslMode = none"
            ReadQuery = "SELECT * FROM TerreHauteNorth.attendance"

        ElseIf School = "Terre Haute South" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=THSJAG;password=1367k8vPZUxhP6go;database=TerreHauteSouth; SslMode = none"
            ReadQuery = "SELECT * FROM TerreHauteSouth.attendance"

        ElseIf School = "West Vigo" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=WestVigoJAG;password=5C98tdsZOr8iQaTT;database=WestVigo; SslMode = none"
            ReadQuery = "SELECT * FROM WestVigo.attendance"

        ElseIf School = "Cloverdale" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=CloverdaleJAG;password=iOIaRpAa34hl9UFH;database=Cloverdale; SslMode = none"
            ReadQuery = "SELECT * FROM Cloverdale.attendance"

        ElseIf School = "Parke Heritage" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=RivertonJAG;password=04PHQWanMT8RKg1I;database=RivertonParke; SslMode = none"
            ReadQuery = "SELECT * FROM RivertonParke.attendance"

        ElseIf School = "Turkey Run" Then
            SchoolConn = "server=51.79.68.145;Port=3306; userid=TurkeyRunJAG;password=KOa5dXlZPsu8uyJ4;database=TurkeyRun; SslMode = none"
            ReadQuery = "SELECT * FROM TurkeyRun.attendance"

        End If


        MySQLConn.ConnectionString = SchoolConn

        Try

            MySQLConn.Open()

            Dim Query As String
            Query = ReadQuery

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
        adminConfirm.Close()

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

    Private Sub ExportData_Click(sender As Object, e As EventArgs) Handles exportData.Click
        If Button1.Enabled = True AndAlso Button2.Enabled = False Then
            SaveFileDialog1.Filter = "Microsoft Excel files (*.xlsx*)|*.xlsx"

            SaveFileDialog1.ShowDialog()



            pleaseWait.Show()
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            pleaseWait.ProgressBar1.Value = 30
            xlApp = New Microsoft.Office.Interop.Excel.Application

            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")
            pleaseWait.ProgressBar1.Value = 40


            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next
            pleaseWait.ProgressBar1.Value = 100
            xlWorkSheet.Range("A:W").EntireColumn.AutoFit()


            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            pleaseWait.Close()


            MsgBox("You can find the file at " & SaveFileDialog1.FileName)

        ElseIf Button1.Enabled = False AndAlso Button2.Enabled = True Then
            SaveFileDialog1.Filter = "Microsoft Excel files (*.xlsx*)|*.xlsx"

            SaveFileDialog1.ShowDialog()


            pleaseWait.Show()
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application

            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")



            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next

            xlWorkSheet.Range("A:W").EntireColumn.AutoFit()


            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            pleaseWait.Close()


            MsgBox("You can find the file at " & SaveFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Enabled = False Then
            MsgBox("Please click on one of the available tables before clicking this button")
        ElseIf Button4.Enabled = True Then
            AdminSearchDialog.Show()
        End If



    End Sub

    Private Sub AdminMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button4.Enabled = False
        '   School = Login.School


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class