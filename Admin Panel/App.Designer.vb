﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
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
        Me.canvas = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'canvas
        '
        Me.canvas.Location = New System.Drawing.Point(-1, 0)
        Me.canvas.Name = "canvas"
        Me.canvas.Size = New System.Drawing.Size(970, 530)
        Me.canvas.TabIndex = 0
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 530)
        Me.Controls.Add(Me.canvas)
        Me.Name = "App"
        Me.Text = "Admin Panel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents canvas As Panel
End Class