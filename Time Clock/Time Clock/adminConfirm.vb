Imports System.Windows.Forms

Public Class adminConfirm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim password As String = TextBox1.Text

        If password = "NorthviewHighSchoolJAG" Then
            adminMain.Show()
            Me.Close()

        Else
            MsgBox("Incorrect Password. Returning to the home page")
            Login.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
