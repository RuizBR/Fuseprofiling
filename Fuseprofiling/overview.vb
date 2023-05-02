Public Class overview

    'navigation btn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'navigate in to purokstats
        demographics.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'navigate in to civilstats
        purokstats.Show()
        Me.Hide()
    End Sub

    Private Sub civilstatsbtn_Click(sender As Object, e As EventArgs) Handles civilstatsbtn.Click
        'navigate in to civilstats
        civilstats.Show()
        Me.Hide()
    End Sub

    Private Sub occupationstatsbtn_Click(sender As Object, e As EventArgs) Handles occupationstatsbtn.Click
        'navigate in to civilstats
        occupationstats.Show()
        Me.Hide()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'back to dashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class