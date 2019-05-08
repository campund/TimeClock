Public Class CustomSplash
    Private Sub CustomSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            Login.Show()
            Me.Close()
        End If
    End Sub
End Class