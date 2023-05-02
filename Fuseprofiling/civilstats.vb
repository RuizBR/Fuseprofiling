Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class civilstats
    Private Sub civilstats_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'db connection
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

        'SINGLE
        Dim cmdsingl = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Single'", conn)
        Dim countsingl = Convert.ToString(cmdsingl.ExecuteScalar)
        singlecount.Text = countsingl

        'married
        Dim cmdmarried = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Married'", conn)
        Dim countmarried = Convert.ToString(cmdmarried.ExecuteScalar)
        marriedcount.Text = countmarried

        'Divorced
        Dim cmdDivorced = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Divorced'", conn)
        Dim countDivorced = Convert.ToString(cmdDivorced.ExecuteScalar)
        divorcedcount.Text = countDivorced

        'Separated
        Dim cmdSeparated = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Separated'", conn)
        Dim countSeparated = Convert.ToString(cmdSeparated.ExecuteScalar)
        separatedcount.Text = countSeparated

        'Widowed
        Dim cmdWidowed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Widowed'", conn)
        Dim countWidowed = Convert.ToString(cmdWidowed.ExecuteScalar)
        widowedcount.Text = countWidowed

        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Single", countsingl)
        Person.Points.AddXY("Married", countmarried)
        Person.Points.AddXY("Divorced", countDivorced)
        Person.Points.AddXY("Separated", countSeparated)
        Person.Points.AddXY("Widowed", countWidowed)

        ' clear chart series to prevent continues adding 
        Chart1.Series.Clear()
        'show chart
        Chart1.Series.Add(Person)

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        'show the list in purok  1
        viewform.UpdateDataGridView("Single")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        'show the list in purok  2
        viewform.UpdateDataGridView("Married")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'show the list in purok  3
        viewform.UpdateDataGridView("Divorced")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        'show the list in purok  4
        viewform.UpdateDataGridView("Separated")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        'show the list in purok  5
        viewform.UpdateDataGridView("Widowed")
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

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'back to dashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class