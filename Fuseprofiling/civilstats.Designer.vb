<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class civilstats
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.occupationstatsbtn = New System.Windows.Forms.Button()
        Me.overviewbtn = New System.Windows.Forms.Button()
        Me.civilstatsbtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.widowedcount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.separatedcount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.divorcedcount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.singlecount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.marriedcount = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'occupationstatsbtn
        '
        Me.occupationstatsbtn.Location = New System.Drawing.Point(38, 274)
        Me.occupationstatsbtn.Name = "occupationstatsbtn"
        Me.occupationstatsbtn.Size = New System.Drawing.Size(104, 34)
        Me.occupationstatsbtn.TabIndex = 33
        Me.occupationstatsbtn.Text = "occupational distribution"
        Me.occupationstatsbtn.UseVisualStyleBackColor = True
        '
        'overviewbtn
        '
        Me.overviewbtn.Location = New System.Drawing.Point(38, 323)
        Me.overviewbtn.Name = "overviewbtn"
        Me.overviewbtn.Size = New System.Drawing.Size(104, 34)
        Me.overviewbtn.TabIndex = 32
        Me.overviewbtn.Text = "overview"
        Me.overviewbtn.UseVisualStyleBackColor = True
        '
        'civilstatsbtn
        '
        Me.civilstatsbtn.Location = New System.Drawing.Point(38, 218)
        Me.civilstatsbtn.Name = "civilstatsbtn"
        Me.civilstatsbtn.Size = New System.Drawing.Size(134, 50)
        Me.civilstatsbtn.TabIndex = 31
        Me.civilstatsbtn.Text = "demographic distribution by marital status"
        Me.civilstatsbtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 50)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Residential Population Analysis by Purok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 34)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "demographic info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.widowedcount)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(274, 234)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(161, 58)
        Me.Panel6.TabIndex = 27
        '
        'widowedcount
        '
        Me.widowedcount.AutoSize = True
        Me.widowedcount.Location = New System.Drawing.Point(79, 19)
        Me.widowedcount.Name = "widowedcount"
        Me.widowedcount.Size = New System.Drawing.Size(13, 13)
        Me.widowedcount.TabIndex = 1
        Me.widowedcount.Text = "_"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Widowed"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.separatedcount)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(461, 163)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(161, 58)
        Me.Panel5.TabIndex = 25
        '
        'separatedcount
        '
        Me.separatedcount.AutoSize = True
        Me.separatedcount.Location = New System.Drawing.Point(79, 19)
        Me.separatedcount.Name = "separatedcount"
        Me.separatedcount.Size = New System.Drawing.Size(13, 13)
        Me.separatedcount.TabIndex = 1
        Me.separatedcount.Text = "_"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Separated"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.divorcedcount)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(274, 163)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(161, 58)
        Me.Panel4.TabIndex = 26
        '
        'divorcedcount
        '
        Me.divorcedcount.AutoSize = True
        Me.divorcedcount.Location = New System.Drawing.Point(79, 19)
        Me.divorcedcount.Name = "divorcedcount"
        Me.divorcedcount.Size = New System.Drawing.Size(13, 13)
        Me.divorcedcount.TabIndex = 1
        Me.divorcedcount.Text = "_"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Divorced"
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(12, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(52, 45)
        Me.back.TabIndex = 23
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Single:"
        '
        'singlecount
        '
        Me.singlecount.AutoSize = True
        Me.singlecount.Location = New System.Drawing.Point(79, 19)
        Me.singlecount.Name = "singlecount"
        Me.singlecount.Size = New System.Drawing.Size(13, 13)
        Me.singlecount.TabIndex = 1
        Me.singlecount.Text = "_"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.singlecount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(274, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 58)
        Me.Panel1.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Married"
        '
        'marriedcount
        '
        Me.marriedcount.AutoSize = True
        Me.marriedcount.Location = New System.Drawing.Point(79, 19)
        Me.marriedcount.Name = "marriedcount"
        Me.marriedcount.Size = New System.Drawing.Size(13, 13)
        Me.marriedcount.TabIndex = 1
        Me.marriedcount.Text = "_"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.marriedcount)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(461, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(161, 58)
        Me.Panel3.TabIndex = 34
        '
        'Chart1
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -60
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(452, 234)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Person"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(333, 206)
        Me.Chart1.TabIndex = 35
        Me.Chart1.Text = "Chart1"
        '
        'civilstats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.occupationstatsbtn)
        Me.Controls.Add(Me.overviewbtn)
        Me.Controls.Add(Me.civilstatsbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.back)
        Me.Name = "civilstats"
        Me.Text = "civilstats"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents occupationstatsbtn As Button
    Friend WithEvents overviewbtn As Button
    Friend WithEvents civilstatsbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents widowedcount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents separatedcount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents divorcedcount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents singlecount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents marriedcount As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
