Public Class schoolSelection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim school = schoolCombo.SelectedItem


        Login.Show()

    End Sub

    Private Sub schoolSelection_Load(sender As Object, e As EventArgs) Handles Me.Load
        schoolCombo.Items.Add("Northview")
        schoolCombo.Items.Add("Terre Haute North")
        schoolCombo.Items.Add("Terre Haute South")
        schoolCombo.Items.Add("West Vigo")
        schoolCombo.Items.Add("Cloverdale")
        schoolCombo.Items.Add("parke heritage")
        schoolCombo.Items.Add("Turkey Run")

    End Sub
End Class