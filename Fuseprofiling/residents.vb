Imports System.Data.OleDb

Public Class residents
    'call GetConnection() from dbconnection.vb
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
    'adapting query
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM infostb", conn)
    'var for command
    Dim comm As OleDbCommand

    'declair variable to get value from datagridview
    Dim ID As Integer
    Dim surname As String
    Dim firstname As String
    Dim middlename As String
    Dim suffix As String
    Dim household As String
    Dim purok As String
    Dim address As String
    Dim birthdate As String
    Dim sex As String
    Dim OCCUPATIONSTATUS As String
    Dim civilstatus As String
    Dim contact As String

    Private Sub residents_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'showing data in datagridview
        Dim table As New DataTable()
        adapter = New OleDbDataAdapter("SELECT * FROM infostb ORDER BY SURNAME ASC", conn)
        adapter.Fill(table)
        personalinfo.DataSource = table

        'hide ID column
        personalinfo.Columns(0).Visible = False

        'select cell
        personalinfo.ClearSelection()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        'searchvalue variable 
        Dim searchValue As String = search.Text
        'selecting colums
        Dim query As String = "SELECT * FROM infostb WHERE SURNAME LIKE '%" & searchValue & "%' OR FIRSTNAME LIKE '%" & searchValue & "%' OR MIDDLENAME LIKE '%" & searchValue & "%' OR SUFFIX LIKE '%" & searchValue & "%' OR HOUSEHOLD LIKE '%" & searchValue & "%' OR PUROK LIKE '%" & searchValue & "%' OR ADDRESS LIKE '%" & searchValue & "%' OR BIRTHDATE LIKE '%" & searchValue & "%' OR SEX LIKE '%" & searchValue & "%' OR OCCUPATIONSTATUS LIKE '%" & searchValue & "%' OR CIVILSTATUS LIKE '%" & searchValue & "%' OR CONTACT LIKE '%" & searchValue & "%'"
        'use db
        Using comm = New OleDbCommand(query, conn)
            'new adapting query
            adapter = New OleDbDataAdapter(comm)
            Dim table As New DataTable()
            'showing data in datagridview
            adapter.Fill(table)
            personalinfo.DataSource = table
        End Using
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub personalinfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles personalinfo.CellClick
        'when row is clicked
        ID = Convert.ToInt32(personalinfo.Rows(e.RowIndex).Cells(0).Value)
        surname = personalinfo.Rows(e.RowIndex).Cells(1).Value.ToString
        firstname = personalinfo.Rows(e.RowIndex).Cells(2).Value.ToString
        middlename = personalinfo.Rows(e.RowIndex).Cells(3).Value.ToString
        suffix = personalinfo.Rows(e.RowIndex).Cells(4).Value.ToString
        address = personalinfo.Rows(e.RowIndex).Cells(5).Value.ToString
        sex = personalinfo.Rows(e.RowIndex).Cells(6).Value.ToString
        civilstatus = personalinfo.Rows(e.RowIndex).Cells(7).Value.ToString
        household = personalinfo.Rows(e.RowIndex).Cells(8).Value.ToString
        purok = personalinfo.Rows(e.RowIndex).Cells(9).Value.ToString
        birthdate = personalinfo.Rows(e.RowIndex).Cells(10).Value.ToString
        OCCUPATIONSTATUS = personalinfo.Rows(e.RowIndex).Cells(11).Value.ToString
        contact = personalinfo.Rows(e.RowIndex).Cells(12).Value.ToString
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        ' Check if any cell is selected
        If personalinfo.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell to Delete.")
            Return
        Else
            'delete comand
            comm = New OleDbCommand("DELETE FROM infostb WHERE ID = @ID", conn)
            comm.Parameters.AddWithValue("@ID", ID)

            'execute
            Dim rowsAffected As Integer = comm.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Record deleted successfully.")
            Else
                MessageBox.Show("Failed to delete record.")
            End If

            'show updated data in datagridview
            Dim table As New DataTable()
            adapter.Fill(table)
            personalinfo.DataSource = table

        End If

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        ' Check if any cell is selected
        If personalinfo.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell to update.")
            Return

        End If
        ' send the data clicked from the datagridview and send it to updateform
        Dim updateForm As New UpdateForm(ID, surname, firstname, middlename, suffix, household, purok, address, birthdate, sex, OCCUPATIONSTATUS, civilstatus, contact)
        updateForm.Show()
        Me.Hide()

    End Sub

    Private Sub viewall_Click(sender As Object, e As EventArgs) Handles viewall.Click
        viewform.UpdateDataGridView("All")
        viewform.ShowDialog()
    End Sub

End Class