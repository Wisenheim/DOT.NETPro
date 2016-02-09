<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deatail_P
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Date_dacquistationLabel As System.Windows.Forms.Label
        Dim Ref_articleLabel As System.Windows.Forms.Label
        Dim Id_fournLabel As System.Windows.Forms.Label
        Me.T_pren = New System.Windows.Forms.TextBox()
        Me.T_Nom = New System.Windows.Forms.TextBox()
        Me.D_Paye = New System.Windows.Forms.DateTimePicker()
        Me.C_P = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Date_dacquistationLabel = New System.Windows.Forms.Label()
        Ref_articleLabel = New System.Windows.Forms.Label()
        Id_fournLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(39, 49)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(49, 16)
        Label2.TabIndex = 71
        Label2.Text = "NOM :"
        '
        'Date_dacquistationLabel
        '
        Date_dacquistationLabel.AutoSize = True
        Date_dacquistationLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_dacquistationLabel.Location = New System.Drawing.Point(16, 109)
        Date_dacquistationLabel.Name = "Date_dacquistationLabel"
        Date_dacquistationLabel.Size = New System.Drawing.Size(107, 16)
        Date_dacquistationLabel.TabIndex = 66
        Date_dacquistationLabel.Text = "Date payement :"
        '
        'Ref_articleLabel
        '
        Ref_articleLabel.AutoSize = True
        Ref_articleLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ref_articleLabel.Location = New System.Drawing.Point(39, 25)
        Ref_articleLabel.Name = "Ref_articleLabel"
        Ref_articleLabel.Size = New System.Drawing.Size(42, 16)
        Ref_articleLabel.TabIndex = 64
        Ref_articleLabel.Text = "CIN :"
        '
        'Id_fournLabel
        '
        Id_fournLabel.AutoSize = True
        Id_fournLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_fournLabel.Location = New System.Drawing.Point(39, 76)
        Id_fournLabel.Name = "Id_fournLabel"
        Id_fournLabel.Size = New System.Drawing.Size(58, 16)
        Id_fournLabel.TabIndex = 46
        Id_fournLabel.Text = "Prenom :"
        '
        'T_pren
        '
        Me.T_pren.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_pren.Location = New System.Drawing.Point(142, 75)
        Me.T_pren.Name = "T_pren"
        Me.T_pren.Size = New System.Drawing.Size(210, 23)
        Me.T_pren.TabIndex = 73
        '
        'T_Nom
        '
        Me.T_Nom.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_Nom.Location = New System.Drawing.Point(142, 48)
        Me.T_Nom.Name = "T_Nom"
        Me.T_Nom.Size = New System.Drawing.Size(210, 23)
        Me.T_Nom.TabIndex = 72
        '
        'D_Paye
        '
        Me.D_Paye.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Paye.Location = New System.Drawing.Point(142, 104)
        Me.D_Paye.Name = "D_Paye"
        Me.D_Paye.Size = New System.Drawing.Size(210, 23)
        Me.D_Paye.TabIndex = 67
        '
        'C_P
        '
        Me.C_P.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_P.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_P.FormattingEnabled = True
        Me.C_P.Location = New System.Drawing.Point(142, 17)
        Me.C_P.Name = "C_P"
        Me.C_P.Size = New System.Drawing.Size(210, 24)
        Me.C_P.TabIndex = 65
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.amrani_foundation.My.Resources.Resources._1367006511_dialog_close
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(284, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 37)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Supprimer"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.amrani_foundation.My.Resources.Resources._1369232230_Modify
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(192, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 37)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Modifier"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.amrani_foundation.My.Resources.Resources._1368041759_new
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(8, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 37)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Nouveau"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.amrani_foundation.My.Resources.Resources._1369232184_netvibes
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(104, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'deatail_P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(380, 213)
        Me.Controls.Add(Me.T_pren)
        Me.Controls.Add(Me.T_Nom)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Date_dacquistationLabel)
        Me.Controls.Add(Me.D_Paye)
        Me.Controls.Add(Me.C_P)
        Me.Controls.Add(Ref_articleLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_fournLabel)
        Me.Name = "deatail_P"
        Me.Text = "deatail_P"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T_pren As System.Windows.Forms.TextBox
    Friend WithEvents T_Nom As System.Windows.Forms.TextBox
    Friend WithEvents D_Paye As System.Windows.Forms.DateTimePicker
    Friend WithEvents C_P As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
