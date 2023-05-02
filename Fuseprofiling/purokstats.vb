Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class purokstats
    Private Sub purokstats_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'db connection
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

        'count population in purok 1
        Dim cmdpurok1 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '1'", conn)
        Dim countpurok1 = Convert.ToString(cmdpurok1.ExecuteScalar)
        purok1count.Text = countpurok1
        'count population in purok 2
        Dim cmdpurok2 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '2'", conn)
        Dim countpurok2 = Convert.ToString(cmdpurok2.ExecuteScalar)
        purok2count.Text = countpurok2
        'count population in purok 3
        Dim cmdpurok3 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '3'", conn)
        Dim countpurok3 = Convert.ToString(cmdpurok3.ExecuteScalar)
        purok3count.Text = countpurok3
        'count population in purok 4
        Dim cmdpurok4 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '4'", conn)
        Dim countpurok4 = Convert.ToString(cmdpurok4.ExecuteScalar)
        purok4count.Text = countpurok4
        'count population in purok 5
        Dim cmdpurok5 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '5'", conn)
        Dim countpurok5 = Convert.ToString(cmdpurok5.ExecuteScalar)
        purok5count.Text = countpurok5


        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Purok 1", countpurok1)
        Person.Points.AddXY("Purok 2", countpurok2)
        Person.Points.AddXY("Purok 3", countpurok3)
        Person.Points.AddXY("Purok 4", countpurok4)
        Person.Points.AddXY("Purok 5", countpurok5)

        ' clear chart series to prevent continues adding 
        Chart1.Series.Clear()
        'show chart
        Chart1.Series.Add(Person)


    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'back to dashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        'show the list in purok  1
        viewform.UpdateDataGridView("1")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        'show the list in purok  2
        viewform.UpdateDataGridView("2")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'show the list in purok  3
        viewform.UpdateDataGridView("3")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        'show the list in purok  4
        viewform.UpdateDataGridView("4")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        'show the list in purok  5
        viewform.UpdateDataGridView("5")
        viewform.ShowDialog()
    End Sub

    'navigation btn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'navigate in to purokstats
        demographics.Show()
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

    Private Sub overviewbtn_Click(sender As Object, e As EventArgs) Handles overviewbtn.Click
        'navigate in to civilstats
        overview.Show()
        Me.Hide()
    End Sub

End Class