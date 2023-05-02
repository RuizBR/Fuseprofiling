<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.total_household = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.total_population = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.total_male = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.total_female = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.create = New System.Windows.Forms.Button()
        Me.demographicsbtn = New System.Windows.Forms.Button()
        Me.residentsbtn = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.total_household)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(360, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 67)
        Me.Panel1.TabIndex = 1
        '
        'total_household
        '
        Me.total_household.AutoSize = True
        Me.total_household.Location = New System.Drawing.Point(93, 24)
        Me.total_household.Name = "total_household"
        Me.total_household.Size = New System.Drawing.Size(13, 13)
        Me.total_household.TabIndex = 1
        Me.total_household.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "household count:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.total_population)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(562, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 67)
        Me.Panel2.TabIndex = 2
        '
        'total_population
        '
        Me.total_population.AutoSize = True
        Me.total_population.Location = New System.Drawing.Point(93, 24)
        Me.total_population.Name = "total_population"
        Me.total_population.Size = New System.Drawing.Size(13, 13)
        Me.total_population.TabIndex = 1
        Me.total_population.Text = "_"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "population count:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.total_male)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(360, 191)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 67)
        Me.Panel3.TabIndex = 2
        '
        'total_male
        '
        Me.total_male.AutoSize = True
        Me.total_male.Location = New System.Drawing.Point(93, 24)
        Me.total_male.Name = "total_male"
        Me.total_male.Size = New System.Drawing.Size(13, 13)
        Me.total_male.TabIndex = 1
        Me.total_male.Text = "_"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "male count:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.total_female)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(562, 191)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 67)
        Me.Panel4.TabIndex = 2
        '
        'total_female
        '
        Me.total_female.AutoSize = True
        Me.total_female.Location = New System.Drawing.Point(93, 24)
        Me.total_female.Name = "total_female"
        Me.total_female.Size = New System.Drawing.Size(13, 13)
        Me.total_female.TabIndex = 1
        Me.total_female.Text = "_"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "female count:"
        '
        'create
        '
        Me.create.Location = New System.Drawing.Point(71, 125)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(105, 43)
        Me.create.TabIndex = 3
        Me.create.Text = "Registry"
        Me.create.UseVisualStyleBackColor = True
        '
        'demographicsbtn
        '
        Me.demographicsbtn.Location = New System.Drawing.Point(71, 223)
        Me.demographicsbtn.Name = "demographicsbtn"
        Me.demographicsbtn.Size = New System.Drawing.Size(105, 43)
        Me.demographicsbtn.TabIndex = 4
        Me.demographicsbtn.Text = "demographics"
        Me.demographicsbtn.UseVisualStyleBackColor = True
        '
        'residentsbtn
        '
        Me.residentsbtn.Location = New System.Drawing.Point(71, 174)
        Me.residentsbtn.Name = "residentsbtn"
        Me.residentsbtn.Size = New System.Drawing.Size(105, 43)
        Me.residentsbtn.TabIndex = 4
        Me.residentsbtn.Text = "residents"
        Me.residentsbtn.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.No
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(333, 279)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(382, 203)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Title1"
        Title1.Position.Auto = False
        Title1.Position.Height = 6.636756!
        Title1.Position.X = 3.0!
        Title1.Position.Y = 3.0!
        Title1.Text = "SEX:"
        Me.Chart1.Titles.Add(Title1)
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 514)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.residentsbtn)
        Me.Controls.Add(Me.demographicsbtn)
        Me.Controls.Add(Me.create)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents total_household As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents total_population As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents total_male As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents total_female As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents create As Button
    Friend WithEvents demographicsbtn As Button
    Friend WithEvents residentsbtn As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
