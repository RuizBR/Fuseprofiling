Imports System.Data.OleDb

Public Class registry

    'db connection
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
    'adapting query
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM infostb", conn)


    'showing their household memeber in datagridview
    Sub SEARCHING()
        'searchvalue variable 
        Dim searchValue As String = householdbox.Text
        'selecting colums
        Dim query As String = "SELECT * FROM infostb WHERE HOUSEHOLD LIKE '%" & searchValue & "%'"
        'use db
        Using command As New OleDbCommand(query, conn)
            'adapting query
            adapter = New OleDbDataAdapter(command)
            Dim table As New DataTable()
            'showing data in datagridview
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                householdmember.DataSource = table
                'to hide the default column in datagridview
                householdmember.Columns(0).Visible = False
                householdmember.Columns(1).Visible = False
                householdmember.Columns(2).Visible = False
                householdmember.Columns(3).Visible = False
                householdmember.Columns(4).Visible = False
                householdmember.Columns(5).Visible = False
                householdmember.Columns(6).Visible = False
                householdmember.Columns(7).Visible = False
                householdmember.Columns(8).Visible = False
                householdmember.Columns(9).Visible = False
                householdmember.Columns(10).Visible = False
                householdmember.Columns(11).Visible = False
                householdmember.Columns(12).Visible = False
            Else
                householdmember.DataSource = Nothing ' Clear the datasource if no data found

                'to show the default column in datagridview
                householdmember.Columns(0).Visible = True
                householdmember.Columns(1).Visible = True
                householdmember.Columns(2).Visible = True
                householdmember.Columns(3).Visible = True
                householdmember.Columns(4).Visible = True
                householdmember.Columns(5).Visible = True
                householdmember.Columns(6).Visible = True
                householdmember.Columns(7).Visible = True
                householdmember.Columns(8).Visible = True
                householdmember.Columns(9).Visible = True
                householdmember.Columns(10).Visible = True
                householdmember.Columns(11).Visible = True
            End If
        End Using
    End Sub
    Private Sub residents_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'showing data in datagridview
        Dim table As New DataTable()
        adapter = New OleDbDataAdapter("SELECT * FROM infostb ORDER BY SURNAME ASC", conn)
        adapter.Fill(table)
        householdmember.DataSource = table

        'to hide the default column in datagridview
        householdmember.Columns(0).Visible = False
        householdmember.Columns(1).Visible = False
        householdmember.Columns(2).Visible = False
        householdmember.Columns(3).Visible = False
        householdmember.Columns(4).Visible = False
        householdmember.Columns(5).Visible = False
        householdmember.Columns(6).Visible = False
        householdmember.Columns(7).Visible = False
        householdmember.Columns(8).Visible = False
        householdmember.Columns(9).Visible = False
        householdmember.Columns(10).Visible = False
        householdmember.Columns(11).Visible = False
        householdmember.Columns(12).Visible = False

        'hide ID column
        householdmember.Columns(0).Visible = False
    End Sub
    'Sub for clearing text fields
    Sub clearText()
        surnamebox.Text = ""
        firstbox.Text = ""
        middlebox.Text = ""
        suffixbox.SelectedIndex = -1
        purokbox.SelectedIndex = -1
        sexbox.SelectedIndex = -1
        occupationstatusbox.SelectedIndex = -1
        civilstatusbox.SelectedIndex = -1
        contactbox.Text = ""
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        'hold the user if the box is empty
        If String.IsNullOrEmpty(firstbox.Text) Then
            MessageBox.Show("Please fill the First Name.")
            Return
        End If

        If String.IsNullOrEmpty(surnamebox.Text) Then
            MessageBox.Show("Please fill the Last Name")
            Return
        End If
        If String.IsNullOrEmpty(middlebox.Text) Then
            MessageBox.Show("Please fill the Middle Name.")
            Return
        End If

        If String.IsNullOrEmpty(householdbox.Text) Then
            MessageBox.Show("Please fill the Household ID.")
            Return
        End If

        If String.IsNullOrEmpty(purokbox.Text) Then
            MessageBox.Show("Please fill the Purok.")
            Return
        End If
        If String.IsNullOrEmpty(civilstatusbox.Text) Then
            MessageBox.Show("Please fill the Civil Status.")
            Return
        End If

        If String.IsNullOrEmpty(sexbox.Text) Then
            MessageBox.Show("Please fill the Gender.")
            Return
        End If
        If String.IsNullOrEmpty(contactbox.Text) Then
            MessageBox.Show("Please fill the Contact No.")
            Return
        End If
        'declare variables
        Dim SURNAME As String = surnamebox.Text
        Dim FIRSTNAME As String = firstbox.Text
        Dim MIDDLENAME As String = middlebox.Text
        Dim SUFFIX As String = suffixbox.Text
        Dim HOUSEHOLD As String = householdbox.Text
        Dim PUROK As String = purokbox.Text
        Dim ADDRESS As String = addressbox.Text
        Dim BIRTHDATE As String = birthdatepicker.Text
        Dim SEX As String = sexbox.Text
        Dim OCCUPATIONSTATUS As String = occupationstatusbox.Text
        Dim CIVILSTATUS As String = civilstatusbox.Text
        Dim CONTACT As String = contactbox.Text


        'where to insert data
        Dim insertquery As String = "INSERT INTO infostb (SURNAME, FIRSTNAME, MIDDLENAME, SUFFIX, HOUSEHOLD, PUROK, ADDRESS, BIRTHDATE, SEX, OCCUPATIONSTATUS, CIVILSTATUS, CONTACT) " &
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        'assigning data
        Using cmdInsert As New OleDbCommand(insertquery, conn)
            Try
                'inserting data
                cmdInsert.Parameters.AddWithValue("@SURNAME", SURNAME)
                cmdInsert.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                cmdInsert.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                cmdInsert.Parameters.AddWithValue("@SUFFIX", SUFFIX)
                cmdInsert.Parameters.AddWithValue("@HOUSEHOLD", HOUSEHOLD)
                cmdInsert.Parameters.AddWithValue("@PUROK", PUROK)
                cmdInsert.Parameters.AddWithValue("@ADDRESS", ADDRESS)
                cmdInsert.Parameters.AddWithValue("@BIRTHDATE", BIRTHDATE)
                cmdInsert.Parameters.AddWithValue("@SEX", SEX)
                cmdInsert.Parameters.AddWithValue("@OCCUPATIONSTATUS", OCCUPATIONSTATUS)
                cmdInsert.Parameters.AddWithValue("@CIVILSTATUS", CIVILSTATUS)
                cmdInsert.Parameters.AddWithValue("@CONTACT", CONTACT)
                cmdInsert.ExecuteNonQuery()


                'SEARCH
                SEARCHING()

                'message box if the insertion is successfully inserted
                MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

            'clear the inputed text 
            clearText()
        End Using
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        'clear the inputed text 
        clearText()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'back to dashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    'condition in imputing data
    Private Sub surnamebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles surnamebox.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub firstbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles firstbox.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub middlebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles middlebox.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub householdbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles householdbox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub contactbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactbox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub contactbox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles contactbox.Validating
        If contactbox.Text.Length <> 11 Then
            MessageBox.Show("Contact number must be 11 digits.")
            e.Cancel = True
        End If
    End Sub

    Private Sub householdbox_TextChanged(sender As Object, e As EventArgs) Handles householdbox.TextChanged
        'SEARCH
        SEARCHING()
    End Sub

End Class