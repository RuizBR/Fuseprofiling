Imports System.Data.OleDb

Public Class viewform
    Public Sub UpdateDataGridView(buttonClicked As String)
        'connection to db
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
        'adapter
        Dim adapter As OleDbDataAdapter
        'table
        Dim table As New DataTable()
        'conditions on what data will show in datagridview
        If buttonClicked = "All" Then
            ' table for view all 
            adapter = New OleDbDataAdapter("SELECT * FROM infostb ORDER BY SURNAME ASC", conn)

        ElseIf buttonClicked = "Male" Then
            ' table for male 
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE SEX = 'Male' ORDER BY SURNAME ASC", conn)

        ElseIf buttonClicked = "Female" Then
            ' table for female
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE SEX = 'Female' ORDER BY SURNAME ASC", conn)

        ElseIf buttonClicked = "Child" Then
            'table for child
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) <= 12", conn)

        ElseIf buttonClicked = "Adolescent" Then
            'adolescent
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 13 AND 17", conn)

        ElseIf buttonClicked = "Adult" Then
            'adult
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 18 AND 59", conn)

        ElseIf buttonClicked = "Elderly" Then
            'Elderly
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) >= 60", conn)

        ElseIf buttonClicked = "1" Then
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '1'", conn)

        ElseIf buttonClicked = "2" Then
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '2'", conn)

        ElseIf buttonClicked = "3" Then
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '3'", conn)

        ElseIf buttonClicked = "4" Then
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '4'", conn)

        ElseIf buttonClicked = "5" Then
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '5'", conn)

        ElseIf buttonClicked = "Single" Then
            'Single
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Single'", conn)

        ElseIf buttonClicked = "Married" Then
            'Married
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Married'", conn)

        ElseIf buttonClicked = "Divorced" Then
            'Divorced
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Divorced'", conn)

        ElseIf buttonClicked = "Separated" Then
            'Separated
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Separated'", conn)

        ElseIf buttonClicked = "Single" Then
            'Widowed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Widowed'", conn)

        ElseIf buttonClicked = "Pensioner" Then
            'Pensioner
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Pensioner'", conn)

        ElseIf buttonClicked = "Employed" Then
            'Employed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Employed'", conn)

        ElseIf buttonClicked = "Unemployed" Then
            'Unemployed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Unemployed'", conn)

        ElseIf buttonClicked = "Self-employed" Then
            'Self-employed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Self-employed'", conn)

        ElseIf buttonClicked = "Student" Then
            'Student
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Student'", conn)

        End If

        'input data
        adapter.Fill(table)

        'remove primary key
        table.Columns.Remove("ID")

        'add No. rows alternative for primary key  
        Dim noColumn As DataColumn = table.Columns.Add("No.", GetType(Integer))
        For i As Integer = 0 To table.Rows.Count - 1
            table.Rows(i)("No.") = i + 1
        Next

        noColumn.SetOrdinal(0)
        'show data in datagridview
        personalinfo.DataSource = table
    End Sub

End Class