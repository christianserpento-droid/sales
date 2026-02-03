Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("You have entered an incorrect login details", "Closing Exams",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you would like to exit?", "Closing Exams",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub
End Class
