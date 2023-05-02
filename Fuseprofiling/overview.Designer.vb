<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class overview
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
        Me.occupationstatsbtn = New System.Windows.Forms.Button()
        Me.overviewbtn = New System.Windows.Forms.Button()
        Me.civilstatsbtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'occupationstatsbtn
        '
        Me.occupationstatsbtn.Location = New System.Drawing.Point(38, 274)
        Me.occupationstatsbtn.Name = "occupationstatsbtn"
        Me.occupationstatsbtn.Size = New System.Drawing.Size(104, 34)
        Me.occupationstatsbtn.TabIndex = 55
        Me.occupationstatsbtn.Text = "occupational distribution"
        Me.occupationstatsbtn.UseVisualStyleBackColor = True
        '
        'overviewbtn
        '
        Me.overviewbtn.Location = New System.Drawing.Point(38, 323)
        Me.overviewbtn.Name = "overviewbtn"
        Me.overviewbtn.Size = New System.Drawing.Size(134, 34)
        Me.overviewbtn.TabIndex = 54
        Me.overviewbtn.Text = "overview"
        Me.overviewbtn.UseVisualStyleBackColor = True
        '
        'civilstatsbtn
        '
        Me.civilstatsbtn.Location = New System.Drawing.Point(38, 218)
        Me.civilstatsbtn.Name = "civilstatsbtn"
        Me.civilstatsbtn.Size = New System.Drawing.Size(104, 50)
        Me.civilstatsbtn.TabIndex = 53
        Me.civilstatsbtn.Text = "demographic distribution by marital status"
        Me.civilstatsbtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 50)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Residential Population Analysis by Purok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 34)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "demographic info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(12, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(52, 45)
        Me.back.TabIndex = 46
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.occupationstatsbtn)
        Me.Controls.Add(Me.overviewbtn)
        Me.Controls.Add(Me.civilstatsbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.back)
        Me.Name = "overview"
        Me.Text = "overview"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents occupationstatsbtn As Button
    Friend WithEvents overviewbtn As Button
    Friend WithEvents civilstatsbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents back As Button
End Class
