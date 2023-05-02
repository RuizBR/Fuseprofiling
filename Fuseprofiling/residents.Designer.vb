<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class residents
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
        Me.components = New System.ComponentModel.Container()
        Me.search = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.personalinfo = New System.Windows.Forms.DataGridView()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.viewall = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.personalinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(177, 29)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(330, 20)
        Me.search.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "search"
        '
        'personalinfo
        '
        Me.personalinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.personalinfo.Location = New System.Drawing.Point(44, 77)
        Me.personalinfo.Name = "personalinfo"
        Me.personalinfo.ReadOnly = True
        Me.personalinfo.Size = New System.Drawing.Size(609, 215)
        Me.personalinfo.TabIndex = 3
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(305, 346)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(106, 41)
        Me.updatebtn.TabIndex = 4
        Me.updatebtn.Text = "update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(141, 344)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(106, 41)
        Me.deletebtn.TabIndex = 4
        Me.deletebtn.Text = "delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'viewall
        '
        Me.viewall.Location = New System.Drawing.Point(497, 344)
        Me.viewall.Name = "viewall"
        Me.viewall.Size = New System.Drawing.Size(106, 41)
        Me.viewall.TabIndex = 5
        Me.viewall.Text = "view all"
        Me.viewall.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(5, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(44, 41)
        Me.back.TabIndex = 6
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        'residents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 450)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.viewall)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.personalinfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search)
        Me.Name = "residents"
        Me.Text = "residents"
        CType(Me.personalinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents search As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents personalinfo As DataGridView
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents viewall As Button
    Friend WithEvents back As Button
End Class
