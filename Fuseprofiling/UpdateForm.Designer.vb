<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Me.back = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.undo = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.birthdatepicker = New System.Windows.Forms.DateTimePicker()
        Me.contactbox = New System.Windows.Forms.TextBox()
        Me.householdbox = New System.Windows.Forms.TextBox()
        Me.addressbox = New System.Windows.Forms.TextBox()
        Me.middlebox = New System.Windows.Forms.TextBox()
        Me.firstbox = New System.Windows.Forms.TextBox()
        Me.surnamebox = New System.Windows.Forms.TextBox()
        Me.householdmember = New System.Windows.Forms.DataGridView()
        Me.SURNAMEVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUFFIXVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOUSEHOLDVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUROKVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDATEVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCCUPATIONSTATUSVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUSVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTVIEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.occupationstatusbox = New System.Windows.Forms.ComboBox()
        Me.suffixbox = New System.Windows.Forms.ComboBox()
        Me.purokbox = New System.Windows.Forms.ComboBox()
        Me.sexbox = New System.Windows.Forms.ComboBox()
        Me.civilstatusbox = New System.Windows.Forms.ComboBox()
        CType(Me.householdmember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(616, 379)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(135, 42)
        Me.back.TabIndex = 58
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(616, 327)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(135, 42)
        Me.updatebtn.TabIndex = 57
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'undo
        '
        Me.undo.Location = New System.Drawing.Point(616, 265)
        Me.undo.Name = "undo"
        Me.undo.Size = New System.Drawing.Size(135, 42)
        Me.undo.TabIndex = 56
        Me.undo.Text = "undo"
        Me.undo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(195, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "contact no."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "civil status "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(630, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "occupation status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(474, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "sex"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "birthdate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "purok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(630, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "household ID."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "suffix"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "middle name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "first name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "surname"
        '
        'birthdatepicker
        '
        Me.birthdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.birthdatepicker.Location = New System.Drawing.Point(339, 91)
        Me.birthdatepicker.Name = "birthdatepicker"
        Me.birthdatepicker.Size = New System.Drawing.Size(118, 20)
        Me.birthdatepicker.TabIndex = 42
        Me.birthdatepicker.Value = New Date(2023, 4, 29, 0, 0, 0, 0)
        '
        'contactbox
        '
        Me.contactbox.Location = New System.Drawing.Point(198, 136)
        Me.contactbox.Name = "contactbox"
        Me.contactbox.Size = New System.Drawing.Size(118, 20)
        Me.contactbox.TabIndex = 38
        '
        'householdbox
        '
        Me.householdbox.Location = New System.Drawing.Point(633, 45)
        Me.householdbox.Name = "householdbox"
        Me.householdbox.Size = New System.Drawing.Size(118, 20)
        Me.householdbox.TabIndex = 36
        '
        'addressbox
        '
        Me.addressbox.Location = New System.Drawing.Point(198, 91)
        Me.addressbox.Name = "addressbox"
        Me.addressbox.ReadOnly = True
        Me.addressbox.Size = New System.Drawing.Size(118, 20)
        Me.addressbox.TabIndex = 35
        Me.addressbox.Text = "Brgy. Masapang, Victory, Laguna"
        '
        'middlebox
        '
        Me.middlebox.Location = New System.Drawing.Point(339, 45)
        Me.middlebox.Name = "middlebox"
        Me.middlebox.Size = New System.Drawing.Size(118, 20)
        Me.middlebox.TabIndex = 33
        '
        'firstbox
        '
        Me.firstbox.Location = New System.Drawing.Point(198, 45)
        Me.firstbox.Name = "firstbox"
        Me.firstbox.Size = New System.Drawing.Size(118, 20)
        Me.firstbox.TabIndex = 32
        '
        'surnamebox
        '
        Me.surnamebox.Location = New System.Drawing.Point(53, 45)
        Me.surnamebox.Name = "surnamebox"
        Me.surnamebox.Size = New System.Drawing.Size(118, 20)
        Me.surnamebox.TabIndex = 31
        '
        'householdmember
        '
        Me.householdmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.householdmember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SURNAMEVIEW, Me.FIRSTNAMEVIEW, Me.LASTNAMEVIEW, Me.SUFFIXVIEW, Me.HOUSEHOLDVIEW, Me.PUROKVIEW, Me.ADDRESSVIEW, Me.BIRTHDATEVIEW, Me.SEXVIEW, Me.OCCUPATIONSTATUSVIEW, Me.CIVILSTATUSVIEW, Me.CONTACTVIEW})
        Me.householdmember.Location = New System.Drawing.Point(53, 218)
        Me.householdmember.Name = "householdmember"
        Me.householdmember.ReadOnly = True
        Me.householdmember.Size = New System.Drawing.Size(489, 203)
        Me.householdmember.TabIndex = 59
        '
        'SURNAMEVIEW
        '
        Me.SURNAMEVIEW.HeaderText = "SURNAME"
        Me.SURNAMEVIEW.Name = "SURNAMEVIEW"
        Me.SURNAMEVIEW.ReadOnly = True
        '
        'FIRSTNAMEVIEW
        '
        Me.FIRSTNAMEVIEW.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEVIEW.Name = "FIRSTNAMEVIEW"
        Me.FIRSTNAMEVIEW.ReadOnly = True
        '
        'LASTNAMEVIEW
        '
        Me.LASTNAMEVIEW.HeaderText = "LASTNAME"
        Me.LASTNAMEVIEW.Name = "LASTNAMEVIEW"
        Me.LASTNAMEVIEW.ReadOnly = True
        '
        'SUFFIXVIEW
        '
        Me.SUFFIXVIEW.HeaderText = "SUFFIX"
        Me.SUFFIXVIEW.Name = "SUFFIXVIEW"
        Me.SUFFIXVIEW.ReadOnly = True
        '
        'HOUSEHOLDVIEW
        '
        Me.HOUSEHOLDVIEW.HeaderText = "HOUSEHOLD"
        Me.HOUSEHOLDVIEW.Name = "HOUSEHOLDVIEW"
        Me.HOUSEHOLDVIEW.ReadOnly = True
        '
        'PUROKVIEW
        '
        Me.PUROKVIEW.HeaderText = "PUROK"
        Me.PUROKVIEW.Name = "PUROKVIEW"
        Me.PUROKVIEW.ReadOnly = True
        '
        'ADDRESSVIEW
        '
        Me.ADDRESSVIEW.HeaderText = "ADDRESS"
        Me.ADDRESSVIEW.Name = "ADDRESSVIEW"
        Me.ADDRESSVIEW.ReadOnly = True
        '
        'BIRTHDATEVIEW
        '
        Me.BIRTHDATEVIEW.HeaderText = "BIRTHDATE"
        Me.BIRTHDATEVIEW.Name = "BIRTHDATEVIEW"
        Me.BIRTHDATEVIEW.ReadOnly = True
        '
        'SEXVIEW
        '
        Me.SEXVIEW.HeaderText = "SEX"
        Me.SEXVIEW.Name = "SEXVIEW"
        Me.SEXVIEW.ReadOnly = True
        '
        'OCCUPATIONSTATUSVIEW
        '
        Me.OCCUPATIONSTATUSVIEW.HeaderText = "OCCUPATIONSTATUS"
        Me.OCCUPATIONSTATUSVIEW.Name = "OCCUPATIONSTATUSVIEW"
        Me.OCCUPATIONSTATUSVIEW.ReadOnly = True
        '
        'CIVILSTATUSVIEW
        '
        Me.CIVILSTATUSVIEW.HeaderText = "CIVILSTATUS"
        Me.CIVILSTATUSVIEW.Name = "CIVILSTATUSVIEW"
        Me.CIVILSTATUSVIEW.ReadOnly = True
        '
        'CONTACTVIEW
        '
        Me.CONTACTVIEW.HeaderText = "CONTACT"
        Me.CONTACTVIEW.Name = "CONTACTVIEW"
        Me.CONTACTVIEW.ReadOnly = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(50, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Household Memeber"
        '
        'occupationstatusbox
        '
        Me.occupationstatusbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.occupationstatusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.occupationstatusbox.FormattingEnabled = True
        Me.occupationstatusbox.Items.AddRange(New Object() {"Pensioner", "Employed", "Unemployed", "Self-employed", "Student"})
        Me.occupationstatusbox.Location = New System.Drawing.Point(630, 94)
        Me.occupationstatusbox.Name = "occupationstatusbox"
        Me.occupationstatusbox.Size = New System.Drawing.Size(121, 21)
        Me.occupationstatusbox.TabIndex = 61
        '
        'suffixbox
        '
        Me.suffixbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.suffixbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.suffixbox.FormattingEnabled = True
        Me.suffixbox.Items.AddRange(New Object() {"N/A", "Sr", "Jr", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "Ma."})
        Me.suffixbox.Location = New System.Drawing.Point(477, 45)
        Me.suffixbox.Name = "suffixbox"
        Me.suffixbox.Size = New System.Drawing.Size(121, 21)
        Me.suffixbox.TabIndex = 62
        '
        'purokbox
        '
        Me.purokbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purokbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.purokbox.FormattingEnabled = True
        Me.purokbox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.purokbox.Location = New System.Drawing.Point(53, 94)
        Me.purokbox.Name = "purokbox"
        Me.purokbox.Size = New System.Drawing.Size(121, 21)
        Me.purokbox.TabIndex = 63
        '
        'sexbox
        '
        Me.sexbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sexbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexbox.FormattingEnabled = True
        Me.sexbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexbox.Location = New System.Drawing.Point(477, 94)
        Me.sexbox.Name = "sexbox"
        Me.sexbox.Size = New System.Drawing.Size(121, 21)
        Me.sexbox.TabIndex = 65
        '
        'civilstatusbox
        '
        Me.civilstatusbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.civilstatusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.civilstatusbox.FormattingEnabled = True
        Me.civilstatusbox.Items.AddRange(New Object() {"Single ", "Married ", "Divorced ", "Separated ", "Widowed "})
        Me.civilstatusbox.Location = New System.Drawing.Point(53, 136)
        Me.civilstatusbox.Name = "civilstatusbox"
        Me.civilstatusbox.Size = New System.Drawing.Size(121, 21)
        Me.civilstatusbox.TabIndex = 66
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.civilstatusbox)
        Me.Controls.Add(Me.sexbox)
        Me.Controls.Add(Me.purokbox)
        Me.Controls.Add(Me.suffixbox)
        Me.Controls.Add(Me.occupationstatusbox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.householdmember)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.undo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.birthdatepicker)
        Me.Controls.Add(Me.contactbox)
        Me.Controls.Add(Me.householdbox)
        Me.Controls.Add(Me.addressbox)
        Me.Controls.Add(Me.middlebox)
        Me.Controls.Add(Me.firstbox)
        Me.Controls.Add(Me.surnamebox)
        Me.Name = "UpdateForm"
        Me.Text = "update"
        CType(Me.householdmember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents undo As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents birthdatepicker As DateTimePicker
    Friend WithEvents contactbox As TextBox
    Friend WithEvents householdbox As TextBox
    Friend WithEvents addressbox As TextBox
    Friend WithEvents middlebox As TextBox
    Friend WithEvents firstbox As TextBox
    Friend WithEvents surnamebox As TextBox
    Friend WithEvents householdmember As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents occupationstatusbox As ComboBox
    Friend WithEvents suffixbox As ComboBox
    Friend WithEvents purokbox As ComboBox
    Friend WithEvents sexbox As ComboBox
    Friend WithEvents SURNAMEVIEW As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEVIEW As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEVIEW As DataGridViewTextBoxColumn
    Friend WithEvents SUFFIXVIEW As DataGridViewTextBoxColumn
    Friend WithEvents HOUSEHOLDVIEW As DataGridViewTextBoxColumn
    Friend WithEvents PUROKVIEW As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSVIEW As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATEVIEW As DataGridViewTextBoxColumn
    Friend WithEvents SEXVIEW As DataGridViewTextBoxColumn
    Friend WithEvents OCCUPATIONSTATUSVIEW As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUSVIEW As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTVIEW As DataGridViewTextBoxColumn
    Friend WithEvents civilstatusbox As ComboBox
End Class
