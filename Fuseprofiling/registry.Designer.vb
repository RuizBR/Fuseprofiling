<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.surnamebox = New System.Windows.Forms.TextBox()
        Me.firstbox = New System.Windows.Forms.TextBox()
        Me.middlebox = New System.Windows.Forms.TextBox()
        Me.addressbox = New System.Windows.Forms.TextBox()
        Me.householdbox = New System.Windows.Forms.TextBox()
        Me.contactbox = New System.Windows.Forms.TextBox()
        Me.purokbox = New System.Windows.Forms.ComboBox()
        Me.sexbox = New System.Windows.Forms.ComboBox()
        Me.civilstatusbox = New System.Windows.Forms.ComboBox()
        Me.birthdatepicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.householdmember = New System.Windows.Forms.DataGridView()
        Me.SURNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUFFIX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOUSEHOLD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUROK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCCUPATIONSTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.save = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.occupationstatusbox = New System.Windows.Forms.ComboBox()
        Me.suffixbox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.householdmember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'surnamebox
        '
        Me.surnamebox.Location = New System.Drawing.Point(146, 164)
        Me.surnamebox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.surnamebox.Multiline = True
        Me.surnamebox.Name = "surnamebox"
        Me.surnamebox.Size = New System.Drawing.Size(250, 40)
        Me.surnamebox.TabIndex = 0
        '
        'firstbox
        '
        Me.firstbox.Location = New System.Drawing.Point(404, 164)
        Me.firstbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.firstbox.Multiline = True
        Me.firstbox.Name = "firstbox"
        Me.firstbox.Size = New System.Drawing.Size(250, 40)
        Me.firstbox.TabIndex = 2
        '
        'middlebox
        '
        Me.middlebox.Location = New System.Drawing.Point(662, 166)
        Me.middlebox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.middlebox.Multiline = True
        Me.middlebox.Name = "middlebox"
        Me.middlebox.Size = New System.Drawing.Size(250, 40)
        Me.middlebox.TabIndex = 3
        '
        'addressbox
        '
        Me.addressbox.Cursor = System.Windows.Forms.Cursors.No
        Me.addressbox.Location = New System.Drawing.Point(408, 235)
        Me.addressbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addressbox.Name = "addressbox"
        Me.addressbox.ReadOnly = True
        Me.addressbox.Size = New System.Drawing.Size(246, 26)
        Me.addressbox.TabIndex = 5
        Me.addressbox.Text = "Brgy. Masapang, Victory, Laguna"
        '
        'householdbox
        '
        Me.householdbox.Location = New System.Drawing.Point(1178, 168)
        Me.householdbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.householdbox.Multiline = True
        Me.householdbox.Name = "householdbox"
        Me.householdbox.Size = New System.Drawing.Size(250, 40)
        Me.householdbox.TabIndex = 6
        '
        'contactbox
        '
        Me.contactbox.Location = New System.Drawing.Point(408, 304)
        Me.contactbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.contactbox.Name = "contactbox"
        Me.contactbox.Size = New System.Drawing.Size(175, 26)
        Me.contactbox.TabIndex = 9
        '
        'purokbox
        '
        Me.purokbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purokbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.purokbox.FormattingEnabled = True
        Me.purokbox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.purokbox.Location = New System.Drawing.Point(146, 237)
        Me.purokbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.purokbox.Name = "purokbox"
        Me.purokbox.Size = New System.Drawing.Size(250, 28)
        Me.purokbox.TabIndex = 11
        '
        'sexbox
        '
        Me.sexbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sexbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexbox.FormattingEnabled = True
        Me.sexbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexbox.Location = New System.Drawing.Point(920, 233)
        Me.sexbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sexbox.Name = "sexbox"
        Me.sexbox.Size = New System.Drawing.Size(250, 28)
        Me.sexbox.TabIndex = 12
        '
        'civilstatusbox
        '
        Me.civilstatusbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.civilstatusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.civilstatusbox.FormattingEnabled = True
        Me.civilstatusbox.Items.AddRange(New Object() {"Single ", "Married ", "Divorced ", "Separated ", "Widowed "})
        Me.civilstatusbox.Location = New System.Drawing.Point(191, 303)
        Me.civilstatusbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.civilstatusbox.Name = "civilstatusbox"
        Me.civilstatusbox.Size = New System.Drawing.Size(180, 28)
        Me.civilstatusbox.TabIndex = 13
        '
        'birthdatepicker
        '
        Me.birthdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.birthdatepicker.Location = New System.Drawing.Point(662, 235)
        Me.birthdatepicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.birthdatepicker.Name = "birthdatepicker"
        Me.birthdatepicker.Size = New System.Drawing.Size(250, 26)
        Me.birthdatepicker.TabIndex = 14
        Me.birthdatepicker.Value = New Date(2023, 4, 29, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(186, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(403, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "first name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(615, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "middle name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(822, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "suffix"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1056, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Household ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(186, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "purok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(403, 211)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(615, 211)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "birthdate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(822, 209)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "sex"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1056, 209)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Occupation Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(186, 278)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "civil status "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(403, 280)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "contact no."
        '
        'householdmember
        '
        Me.householdmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.householdmember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SURNAME, Me.FIRSTNAME, Me.LASTNAME, Me.SUFFIX, Me.HOUSEHOLD, Me.PUROK, Me.ADDRESS, Me.BIRTHDATE, Me.SEX, Me.OCCUPATIONSTATUS, Me.CIVILSTATUS, Me.CONTACT})
        Me.householdmember.Location = New System.Drawing.Point(191, 431)
        Me.householdmember.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.householdmember.Name = "householdmember"
        Me.householdmember.ReadOnly = True
        Me.householdmember.RowHeadersWidth = 62
        Me.householdmember.Size = New System.Drawing.Size(734, 312)
        Me.householdmember.TabIndex = 27
        '
        'SURNAME
        '
        Me.SURNAME.HeaderText = "SURNAME"
        Me.SURNAME.MinimumWidth = 8
        Me.SURNAME.Name = "SURNAME"
        Me.SURNAME.ReadOnly = True
        Me.SURNAME.Width = 150
        '
        'FIRSTNAME
        '
        Me.FIRSTNAME.HeaderText = "FIRSTNAME"
        Me.FIRSTNAME.MinimumWidth = 8
        Me.FIRSTNAME.Name = "FIRSTNAME"
        Me.FIRSTNAME.ReadOnly = True
        Me.FIRSTNAME.Width = 150
        '
        'LASTNAME
        '
        Me.LASTNAME.HeaderText = "LASTNAME"
        Me.LASTNAME.MinimumWidth = 8
        Me.LASTNAME.Name = "LASTNAME"
        Me.LASTNAME.ReadOnly = True
        Me.LASTNAME.Width = 150
        '
        'SUFFIX
        '
        Me.SUFFIX.HeaderText = "SUFFIX"
        Me.SUFFIX.MinimumWidth = 8
        Me.SUFFIX.Name = "SUFFIX"
        Me.SUFFIX.ReadOnly = True
        Me.SUFFIX.Width = 150
        '
        'HOUSEHOLD
        '
        Me.HOUSEHOLD.HeaderText = "HOUSEHOLD"
        Me.HOUSEHOLD.MinimumWidth = 8
        Me.HOUSEHOLD.Name = "HOUSEHOLD"
        Me.HOUSEHOLD.ReadOnly = True
        Me.HOUSEHOLD.Width = 150
        '
        'PUROK
        '
        Me.PUROK.HeaderText = "PUROK"
        Me.PUROK.MinimumWidth = 8
        Me.PUROK.Name = "PUROK"
        Me.PUROK.ReadOnly = True
        Me.PUROK.Width = 150
        '
        'ADDRESS
        '
        Me.ADDRESS.HeaderText = "ADDRESS"
        Me.ADDRESS.MinimumWidth = 8
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.ReadOnly = True
        Me.ADDRESS.Width = 150
        '
        'BIRTHDATE
        '
        Me.BIRTHDATE.HeaderText = "BIRTHDATE"
        Me.BIRTHDATE.MinimumWidth = 8
        Me.BIRTHDATE.Name = "BIRTHDATE"
        Me.BIRTHDATE.ReadOnly = True
        Me.BIRTHDATE.Width = 150
        '
        'SEX
        '
        Me.SEX.HeaderText = "SEX"
        Me.SEX.MinimumWidth = 8
        Me.SEX.Name = "SEX"
        Me.SEX.ReadOnly = True
        Me.SEX.Width = 150
        '
        'OCCUPATIONSTATUS
        '
        Me.OCCUPATIONSTATUS.HeaderText = "OCCUPATIONSTATUS"
        Me.OCCUPATIONSTATUS.MinimumWidth = 8
        Me.OCCUPATIONSTATUS.Name = "OCCUPATIONSTATUS"
        Me.OCCUPATIONSTATUS.ReadOnly = True
        Me.OCCUPATIONSTATUS.Width = 150
        '
        'CIVILSTATUS
        '
        Me.CIVILSTATUS.HeaderText = "CIVILSTATUS"
        Me.CIVILSTATUS.MinimumWidth = 8
        Me.CIVILSTATUS.Name = "CIVILSTATUS"
        Me.CIVILSTATUS.ReadOnly = True
        Me.CIVILSTATUS.Width = 150
        '
        'CONTACT
        '
        Me.CONTACT.HeaderText = "CONTACT"
        Me.CONTACT.MinimumWidth = 8
        Me.CONTACT.Name = "CONTACT"
        Me.CONTACT.ReadOnly = True
        Me.CONTACT.Width = 150
        '
        'save
        '
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.Location = New System.Drawing.Point(1035, 503)
        Me.save.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(202, 65)
        Me.save.TabIndex = 28
        Me.save.Text = "save"
        Me.save.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.Location = New System.Drawing.Point(1035, 598)
        Me.clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(202, 65)
        Me.clear.TabIndex = 29
        Me.clear.Text = "clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Location = New System.Drawing.Point(1035, 678)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(202, 65)
        Me.back.TabIndex = 30
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'occupationstatusbox
        '
        Me.occupationstatusbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.occupationstatusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.occupationstatusbox.FormattingEnabled = True
        Me.occupationstatusbox.Items.AddRange(New Object() {"Pensioner", "Employed", "Unemployed", "Self-employed", "Student"})
        Me.occupationstatusbox.Location = New System.Drawing.Point(1178, 233)
        Me.occupationstatusbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.occupationstatusbox.Name = "occupationstatusbox"
        Me.occupationstatusbox.Size = New System.Drawing.Size(250, 28)
        Me.occupationstatusbox.TabIndex = 31
        '
        'suffixbox
        '
        Me.suffixbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.suffixbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.suffixbox.FormattingEnabled = True
        Me.suffixbox.Items.AddRange(New Object() {"N/A", "Sr", "Jr", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "Ma."})
        Me.suffixbox.Location = New System.Drawing.Point(920, 180)
        Me.suffixbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.suffixbox.Name = "suffixbox"
        Me.suffixbox.Size = New System.Drawing.Size(250, 28)
        Me.suffixbox.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(189, 392)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(157, 20)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Household Memeber"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.householdmember)
        Me.Panel1.Controls.Add(Me.suffixbox)
        Me.Panel1.Controls.Add(Me.surnamebox)
        Me.Panel1.Controls.Add(Me.occupationstatusbox)
        Me.Panel1.Controls.Add(Me.firstbox)
        Me.Panel1.Controls.Add(Me.back)
        Me.Panel1.Controls.Add(Me.middlebox)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.addressbox)
        Me.Panel1.Controls.Add(Me.save)
        Me.Panel1.Controls.Add(Me.householdbox)
        Me.Panel1.Controls.Add(Me.contactbox)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.purokbox)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.sexbox)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.civilstatusbox)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.birthdatepicker)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1574, 876)
        Me.Panel1.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(607, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(361, 48)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Public Admission"
        '
        'registry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1574, 876)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "registry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.householdmember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents surnamebox As TextBox
    Friend WithEvents firstbox As TextBox
    Friend WithEvents middlebox As TextBox
    Friend WithEvents addressbox As TextBox
    Friend WithEvents householdbox As TextBox
    Friend WithEvents contactbox As TextBox
    Friend WithEvents purokbox As ComboBox
    Friend WithEvents sexbox As ComboBox
    Friend WithEvents civilstatusbox As ComboBox
    Friend WithEvents birthdatepicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents householdmember As DataGridView
    Friend WithEvents save As Button
    Friend WithEvents clear As Button
    Friend WithEvents back As Button
    Friend WithEvents occupationstatusbox As ComboBox
    Friend WithEvents suffixbox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SURNAME As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAME As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAME As DataGridViewTextBoxColumn
    Friend WithEvents SUFFIX As DataGridViewTextBoxColumn
    Friend WithEvents HOUSEHOLD As DataGridViewTextBoxColumn
    Friend WithEvents PUROK As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATE As DataGridViewTextBoxColumn
    Friend WithEvents SEX As DataGridViewTextBoxColumn
    Friend WithEvents OCCUPATIONSTATUS As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUS As DataGridViewTextBoxColumn
    Friend WithEvents CONTACT As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
End Class
