Public Class Form2
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
        MsgBox("Logout Successful", MsgBoxStyle.OkOnly, "User Logout")
    End Sub

    Private Sub btnLogoutExit_Click(sender As Object, e As EventArgs) Handles btnLogoutExit.Click
        Me.Close()
        MsgBox("Logout Successful", MsgBoxStyle.OkOnly, "User Logout")
    End Sub
End Class