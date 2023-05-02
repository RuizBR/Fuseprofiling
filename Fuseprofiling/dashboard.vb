Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class dashboard

    Private Sub residents_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'db connection
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

        'showing totals
        Dim cmdHouseholdID As New OleDbCommand("SELECT COUNT(*) FROM (SELECT DISTINCT HOUSEHOLD FROM infostb)", conn)
        Dim countHouseholdID = Convert.ToString(cmdHouseholdID.ExecuteScalar())
        total_household.Text = countHouseholdID

        Dim cmdpopulation As New OleDbCommand("SELECT COUNT(FIRSTNAME) FROM infostb", conn)
        Dim countpopulation = Convert.ToString(cmdpopulation.ExecuteScalar)
        total_population.Text = countpopulation

        Dim cmdfemale = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE SEX = 'FEMALE'", conn)
        Dim countfemale = Convert.ToString(cmdfemale.ExecuteScalar)
        total_female.Text = countfemale

        Dim cmdmale = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE SEX = 'MALE'", conn)
        Dim countmale = Convert.ToString(cmdmale.ExecuteScalar)
        total_male.Text = countmale


        ' add data points to the chart series
        Dim series1 As New Series()
        series1.ChartType = SeriesChartType.Pie
        series1.Points.AddXY("FEMALE", countfemale)
        series1.Points.AddXY("MALE", countmale)

        ' clear chart series to prevent continues adding 
        Chart1.Series.Clear()
        'show chart
        Chart1.Series.Add(series1)


    End Sub
    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        'navigate to registry
        registry.Show()
        Me.Close()
    End Sub

    Private Sub residentsbtn_Click(sender As Object, e As EventArgs) Handles residentsbtn.Click
        'navigate to residents
        residents.Show()
        Me.Hide()
    End Sub

    Private Sub demographicsbtn_Click(sender As Object, e As EventArgs) Handles demographicsbtn.Click
        'navigate to demographics
        demographics.Show()
        Me.Hide()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'show the list of Female
        viewform.UpdateDataGridView("Female")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        'show the list of Male
        viewform.UpdateDataGridView("Male")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        'show the list of All recidents
        viewform.UpdateDataGridView("All")
        viewform.ShowDialog()
    End Sub

End Class