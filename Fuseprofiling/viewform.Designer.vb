﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewform
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
        Me.personalinfo = New System.Windows.Forms.DataGridView()
        CType(Me.personalinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'personalinfo
        '
        Me.personalinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.personalinfo.Location = New System.Drawing.Point(22, 50)
        Me.personalinfo.Name = "personalinfo"
        Me.personalinfo.ReadOnly = True
        Me.personalinfo.Size = New System.Drawing.Size(756, 388)
        Me.personalinfo.TabIndex = 0
        '
        'viewform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.personalinfo)
        Me.Name = "viewform"
        Me.Text = "viewall"
        CType(Me.personalinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents personalinfo As DataGridView
End Class
