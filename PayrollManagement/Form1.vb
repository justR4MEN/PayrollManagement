Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            MsgBox("Log in Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
