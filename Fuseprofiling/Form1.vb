Public Class Form1
    Dim attempt As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lgnBttn.Click
        'correct login info
        If (userbox.Text = "fuse" And passbox.Text = "admin") Then
            dashboard.Show()
            Me.Hide()
            passbox.Text = ""
            userbox.Text = ""

        ElseIf (userbox.Text IsNot "fuse" And passbox.Text IsNot "admin") Then
            passbox.Text = ""
            userbox.Text = ""
            userbox.Clear()
            userbox.Focus()
            attempt += 1
            MessageBox.Show("WARNING: INVALID INPUT!!!")

            'final attempt before system error
            If attempt = 5 Then
                passbox.Text = ""
                passbox.Enabled = False
                userbox.Enabled = False
                lgnBttn.Enabled = False
                MessageBox.Show("ERROR: TOO MANY ATTEMPS!!")
            End If
        End If
    End Sub

    Private Sub extBttn_Click(sender As Object, e As EventArgs) Handles extBttn.Click
        Application.Exit()
    End Sub
End Class
