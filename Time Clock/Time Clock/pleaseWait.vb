Public Class pleaseWait
    Private Sub PleaseWait_Load(sender As Object, e As EventArgs) Handles Me.Load

        Timer1.Enabled = True
        Timer1.Interval = 5


        '      ProgressBar1.Step = 5
        '       Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)

        '   ProgressBar1.Refresh()
    End Sub
End Class