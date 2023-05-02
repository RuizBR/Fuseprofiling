Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class occupationstats

    Private Sub purokstats_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'db connection
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

        'Pensioner
        Dim cmdPensioner = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Pensioner'", conn)
        Dim countPensioner = Convert.ToString(cmdPensioner.ExecuteScalar)
        pensionercount.Text = countPensioner
        'Employed
        Dim cmdEmployed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Employed'", conn)
        Dim countEmployed = Convert.ToString(cmdEmployed.ExecuteScalar)
        employedcount.Text = countEmployed
        'Unemployed
        Dim cmdUnemployed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Unemployed'", conn)
        Dim countUnemployed = Convert.ToString(cmdUnemployed.ExecuteScalar)
        unemployedcount.Text = countUnemployed
        'selfemployed
        Dim cmdselfemployed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Self-employed'", conn)
        Dim countselfemployed = Convert.ToString(cmdselfemployed.ExecuteScalar)
        selfemployedcount.Text = countselfemployed
        'Student
        Dim cmdStudent = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Student'", conn)
        Dim countStudent = Convert.ToString(cmdStudent.ExecuteScalar)
        studentcount.Text = countStudent

        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Pensioner", countPensioner)
        Person.Points.AddXY("Employed", countEmployed)
        Person.Points.AddXY("Unemployed", countUnemployed)
        Person.Points.AddXY("Self-employed", countselfemployed)
        Person.Points.AddXY("Student", countStudent)

        ' clear chart series to prevent continues adding 
        Chart1.Series.Clear()
        'show chart
        Chart1.Series.Add(Person)

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        'show the list in purok  1
        viewform.UpdateDataGridView("Pensioner")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        'show the list in purok  2
        viewform.UpdateDataGridView("Employed")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'show the list in purok  3
        viewform.UpdateDataGridView("Unemployed")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        'show the list in purok  4
        viewform.UpdateDataGridView("Self-employed")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        'show the list in purok  5
        viewform.UpdateDataGridView("Student")
        viewform.ShowDialog()
    End Sub

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

    Private Sub overviewbtn_Click(sender As Object, e As EventArgs) Handles overviewbtn.Click
        'navigate in to civilstats
        overview.Show()
        Me.Hide()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'back to dashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class