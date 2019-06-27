Public Class CustomSplash
    Private Sub CustomSplash_Load(sender As Object, e As EventArgs) Handles Me.Load

        Timer1.Enabled = True



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Login.Show()
            Me.Close()

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class