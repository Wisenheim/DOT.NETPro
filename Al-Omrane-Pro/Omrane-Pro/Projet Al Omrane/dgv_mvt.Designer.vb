<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgv_mvt
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.dgv.BackColor = System.Drawing.Color.Silver
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgv.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dgv.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgv.CaptionForeColor = System.Drawing.Color.White
        Me.dgv.DataMember = ""
        Me.dgv.FlatMode = True
        Me.dgv.ForeColor = System.Drawing.Color.Black
        Me.dgv.GridLineColor = System.Drawing.Color.White
        Me.dgv.HeaderBackColor = System.Drawing.Color.DarkGray
        Me.dgv.HeaderForeColor = System.Drawing.Color.Black
        Me.dgv.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgv.Location = New System.Drawing.Point(1, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.ParentRowsBackColor = System.Drawing.Color.Black
        Me.dgv.ParentRowsForeColor = System.Drawing.Color.White
        Me.dgv.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dgv.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.Size = New System.Drawing.Size(598, 239)
        Me.dgv.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(517, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgv_mvt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 295)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "dgv_mvt"
        Me.Text = "dgv_mvt"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
