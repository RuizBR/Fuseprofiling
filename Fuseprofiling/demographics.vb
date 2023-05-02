Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class demographics
    Private Sub demographics_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'db connection
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

        'child
        Dim cmdchildAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) <= 12", conn)
        Dim countchild = Convert.ToString(cmdchildAge.ExecuteScalar)
        childcount.Text = countchild

        'adolescent
        Dim cmdadolescentAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 13 AND 17", conn)
        Dim countadolescent = Convert.ToString(cmdadolescentAge.ExecuteScalar)
        Adolescentcount.Text = countadolescent

        'adult
        Dim cmdadultAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 18 AND 59", conn)
        Dim countadult = Convert.ToString(cmdadultAge.ExecuteScalar)
        Adultcount.Text = countadult

        'Elderly
        Dim cmdelderAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) >= 60", conn)
        Dim countelder = Convert.ToString(cmdelderAge.ExecuteScalar)
        Elderlycount.Text = countelder

        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Child", countchild)
        Person.Points.AddXY("Adolescent", countadolescent)
        Person.Points.AddXY("Adult", countadult)
        Person.Points.AddXY("Elderly", countelder)

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
        'show the list of child
        viewform.UpdateDataGridView("Child")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs)
        'show the list of Adolescent
        viewform.UpdateDataGridView("Adolescent")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'show the list of Adult
        viewform.UpdateDataGridView("Adult")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        'show the list of Elderly
        viewform.UpdateDataGridView("Elderly")
        viewform.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'navigate in to purokstats
        purokstats.Show()
        Me.Hide()
    End Sub

    Private Sub civilstatsbtn_Click(sender As Object, e As EventArgs) Handles civilstatsbtn.Click
        'navigate in to civilstats
        civilstats.Show()
        Me.Hide()
    End Sub

    Private Sub occupationstatsbtn_Click(sender As Object, e As EventArgs) Handles occupationstatsbtn.Click
        occupationstats.Show()
        Me.Hide()
    End Sub

    Private Sub overviewbtn_Click(sender As Object, e As EventArgs) Handles overviewbtn.Click
        overview.Show()
        Me.Hide()
    End Sub

End Class