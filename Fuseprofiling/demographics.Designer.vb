<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class demographics
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
        Me.back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.civilstatsbtn = New System.Windows.Forms.Button()
        Me.overviewbtn = New System.Windows.Forms.Button()
        Me.occupationstatsbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.childcount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Adultcount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Elderlycount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Adolescentcount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(12, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(52, 45)
        Me.back.TabIndex = 0
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "demographic info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(36, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Residential Population Analysis by Purok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'civilstatsbtn
        '
        Me.civilstatsbtn.Location = New System.Drawing.Point(36, 218)
        Me.civilstatsbtn.Name = "civilstatsbtn"
        Me.civilstatsbtn.Size = New System.Drawing.Size(104, 50)
        Me.civilstatsbtn.TabIndex = 3
        Me.civilstatsbtn.Text = "demographic distribution by marital status"
        Me.civilstatsbtn.UseVisualStyleBackColor = True
        '
        'overviewbtn
        '
        Me.overviewbtn.Location = New System.Drawing.Point(36, 323)
        Me.overviewbtn.Name = "overviewbtn"
        Me.overviewbtn.Size = New System.Drawing.Size(104, 34)
        Me.overviewbtn.TabIndex = 4
        Me.overviewbtn.Text = "overview"
        Me.overviewbtn.UseVisualStyleBackColor = True
        '
        'occupationstatsbtn
        '
        Me.occupationstatsbtn.Location = New System.Drawing.Point(36, 274)
        Me.occupationstatsbtn.Name = "occupationstatsbtn"
        Me.occupationstatsbtn.Size = New System.Drawing.Size(104, 34)
        Me.occupationstatsbtn.TabIndex = 5
        Me.occupationstatsbtn.Text = "occupational distribution"
        Me.occupationstatsbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.childcount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(274, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 58)
        Me.Panel1.TabIndex = 6
        '
        'childcount
        '
        Me.childcount.AutoSize = True
        Me.childcount.Location = New System.Drawing.Point(79, 19)
        Me.childcount.Name = "childcount"
        Me.childcount.Size = New System.Drawing.Size(13, 13)
        Me.childcount.TabIndex = 1
        Me.childcount.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Child:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Adultcount)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(274, 163)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(161, 58)
        Me.Panel4.TabIndex = 7
        '
        'Adultcount
        '
        Me.Adultcount.AutoSize = True
        Me.Adultcount.Location = New System.Drawing.Point(79, 19)
        Me.Adultcount.Name = "Adultcount"
        Me.Adultcount.Size = New System.Drawing.Size(13, 13)
        Me.Adultcount.TabIndex = 1
        Me.Adultcount.Text = "_"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Adult:"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Elderlycount)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(461, 163)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(161, 58)
        Me.Panel5.TabIndex = 7
        '
        'Elderlycount
        '
        Me.Elderlycount.AutoSize = True
        Me.Elderlycount.Location = New System.Drawing.Point(79, 19)
        Me.Elderlycount.Name = "Elderlycount"
        Me.Elderlycount.Size = New System.Drawing.Size(13, 13)
        Me.Elderlycount.TabIndex = 1
        Me.Elderlycount.Text = "_"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Elderly:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Adolescentcount)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(461, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(161, 58)
        Me.Panel3.TabIndex = 8
        '
        'Adolescentcount
        '
        Me.Adolescentcount.AutoSize = True
        Me.Adolescentcount.Location = New System.Drawing.Point(79, 19)
        Me.Adolescentcount.Name = "Adolescentcount"
        Me.Adolescentcount.Size = New System.Drawing.Size(13, 13)
        Me.Adolescentcount.TabIndex = 1
        Me.Adolescentcount.Text = "_"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adolescent:"
        '
        'Chart1
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -60
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(248, 227)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Person"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(528, 211)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart1"
        '
        'demographics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.occupationstatsbtn)
        Me.Controls.Add(Me.overviewbtn)
        Me.Controls.Add(Me.civilstatsbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.back)
        Me.Name = "demographics"
        Me.Text = "demographics"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents civilstatsbtn As Button
    Friend WithEvents overviewbtn As Button
    Friend WithEvents occupationstatsbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents childcount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Adultcount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Elderlycount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Adolescentcount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
