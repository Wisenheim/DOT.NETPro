<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DETAILS
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
        Dim Id_fournLabel As System.Windows.Forms.Label
        Dim Id_modeLabel As System.Windows.Forms.Label
        Dim Id_uniteLabel As System.Windows.Forms.Label
        Dim Montant_htLabel As System.Windows.Forms.Label
        Dim Montant_ttcLabel As System.Windows.Forms.Label
        Dim Prix_unitaireLabel As System.Windows.Forms.Label
        Dim QuantiteLabel As System.Windows.Forms.Label
        Dim Ref_articleLabel As System.Windows.Forms.Label
        Dim Date_dacquistationLabel As System.Windows.Forms.Label
        Dim TVALabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Montant_htTextBox = New System.Windows.Forms.TextBox()
        Me.Montant_ttcTextBox = New System.Windows.Forms.TextBox()
        Me.Prix_unitaireTextBox = New System.Windows.Forms.TextBox()
        Me.QuantiteTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Date_dacquistationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TVATextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.T_ID = New System.Windows.Forms.TextBox()
        Id_fournLabel = New System.Windows.Forms.Label()
        Id_modeLabel = New System.Windows.Forms.Label()
        Id_uniteLabel = New System.Windows.Forms.Label()
        Montant_htLabel = New System.Windows.Forms.Label()
        Montant_ttcLabel = New System.Windows.Forms.Label()
        Prix_unitaireLabel = New System.Windows.Forms.Label()
        QuantiteLabel = New System.Windows.Forms.Label()
        Ref_articleLabel = New System.Windows.Forms.Label()
        Date_dacquistationLabel = New System.Windows.Forms.Label()
        TVALabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Id_fournLabel
        '
        Id_fournLabel.AutoSize = True
        Id_fournLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_fournLabel.Location = New System.Drawing.Point(68, 164)
        Id_fournLabel.Name = "Id_fournLabel"
        Id_fournLabel.Size = New System.Drawing.Size(83, 16)
        Id_fournLabel.TabIndex = 5
        Id_fournLabel.Text = "Fournisseur :"
        '
        'Id_modeLabel
        '
        Id_modeLabel.AutoSize = True
        Id_modeLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_modeLabel.Location = New System.Drawing.Point(34, 188)
        Id_modeLabel.Name = "Id_modeLabel"
        Id_modeLabel.Size = New System.Drawing.Size(117, 16)
        Id_modeLabel.TabIndex = 7
        Id_modeLabel.Text = "Mode de paiment :"
        '
        'Id_uniteLabel
        '
        Id_uniteLabel.AutoSize = True
        Id_uniteLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_uniteLabel.Location = New System.Drawing.Point(102, 217)
        Id_uniteLabel.Name = "Id_uniteLabel"
        Id_uniteLabel.Size = New System.Drawing.Size(49, 16)
        Id_uniteLabel.TabIndex = 9
        Id_uniteLabel.Text = "Unitè :"
        '
        'Montant_htLabel
        '
        Montant_htLabel.AutoSize = True
        Montant_htLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Montant_htLabel.Location = New System.Drawing.Point(65, 359)
        Montant_htLabel.Name = "Montant_htLabel"
        Montant_htLabel.Size = New System.Drawing.Size(86, 16)
        Montant_htLabel.TabIndex = 11
        Montant_htLabel.Text = "montant HT :"
        '
        'Montant_ttcLabel
        '
        Montant_ttcLabel.AutoSize = True
        Montant_ttcLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Montant_ttcLabel.Location = New System.Drawing.Point(59, 385)
        Montant_ttcLabel.Name = "Montant_ttcLabel"
        Montant_ttcLabel.Size = New System.Drawing.Size(92, 16)
        Montant_ttcLabel.TabIndex = 13
        Montant_ttcLabel.Text = "montant TTC :"
        '
        'Prix_unitaireLabel
        '
        Prix_unitaireLabel.AutoSize = True
        Prix_unitaireLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prix_unitaireLabel.Location = New System.Drawing.Point(67, 244)
        Prix_unitaireLabel.Name = "Prix_unitaireLabel"
        Prix_unitaireLabel.Size = New System.Drawing.Size(84, 16)
        Prix_unitaireLabel.TabIndex = 15
        Prix_unitaireLabel.Text = "prix unitaire:"
        '
        'QuantiteLabel
        '
        QuantiteLabel.AutoSize = True
        QuantiteLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantiteLabel.Location = New System.Drawing.Point(91, 329)
        QuantiteLabel.Name = "QuantiteLabel"
        QuantiteLabel.Size = New System.Drawing.Size(60, 16)
        QuantiteLabel.TabIndex = 17
        QuantiteLabel.Text = "quantite:"
        '
        'Ref_articleLabel
        '
        Ref_articleLabel.AutoSize = True
        Ref_articleLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ref_articleLabel.Location = New System.Drawing.Point(93, 106)
        Ref_articleLabel.Name = "Ref_articleLabel"
        Ref_articleLabel.Size = New System.Drawing.Size(58, 16)
        Ref_articleLabel.TabIndex = 34
        Ref_articleLabel.Text = "Article :"
        '
        'Date_dacquistationLabel
        '
        Date_dacquistationLabel.AutoSize = True
        Date_dacquistationLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_dacquistationLabel.Location = New System.Drawing.Point(31, 304)
        Date_dacquistationLabel.Name = "Date_dacquistationLabel"
        Date_dacquistationLabel.Size = New System.Drawing.Size(120, 16)
        Date_dacquistationLabel.TabIndex = 36
        Date_dacquistationLabel.Text = "date dacquistation:"
        '
        'TVALabel
        '
        TVALabel.AutoSize = True
        TVALabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TVALabel.Location = New System.Drawing.Point(113, 274)
        TVALabel.Name = "TVALabel"
        TVALabel.Size = New System.Drawing.Size(38, 16)
        TVALabel.TabIndex = 38
        TVALabel.Text = "TVA:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(23, 136)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(128, 16)
        Label2.TabIndex = 43
        Label2.Text = "Designation Article :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(77, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 16)
        Label1.TabIndex = 34
        Label1.Text = "ID Detail :"
        '
        'Montant_htTextBox
        '
        Me.Montant_htTextBox.Enabled = False
        Me.Montant_htTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Montant_htTextBox.Location = New System.Drawing.Point(157, 356)
        Me.Montant_htTextBox.Name = "Montant_htTextBox"
        Me.Montant_htTextBox.Size = New System.Drawing.Size(200, 24)
        Me.Montant_htTextBox.TabIndex = 12
        '
        'Montant_ttcTextBox
        '
        Me.Montant_ttcTextBox.Enabled = False
        Me.Montant_ttcTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Montant_ttcTextBox.Location = New System.Drawing.Point(157, 382)
        Me.Montant_ttcTextBox.Name = "Montant_ttcTextBox"
        Me.Montant_ttcTextBox.Size = New System.Drawing.Size(200, 24)
        Me.Montant_ttcTextBox.TabIndex = 14
        '
        'Prix_unitaireTextBox
        '
        Me.Prix_unitaireTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prix_unitaireTextBox.Location = New System.Drawing.Point(157, 241)
        Me.Prix_unitaireTextBox.Name = "Prix_unitaireTextBox"
        Me.Prix_unitaireTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Prix_unitaireTextBox.TabIndex = 16
        '
        'QuantiteTextBox
        '
        Me.QuantiteTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteTextBox.Location = New System.Drawing.Point(157, 326)
        Me.QuantiteTextBox.Name = "QuantiteTextBox"
        Me.QuantiteTextBox.Size = New System.Drawing.Size(200, 24)
        Me.QuantiteTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.amrani_foundation.My.Resources.Resources._1369232184_netvibes
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(120, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.amrani_foundation.My.Resources.Resources._1368041759_new
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(24, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 37)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Nouveau"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.amrani_foundation.My.Resources.Resources._1369232230_Modify
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(208, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 37)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Modifier"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.amrani_foundation.My.Resources.Resources._1367006511_dialog_close
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(300, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 37)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Supprimer"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(157, 103)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox5.TabIndex = 35
        '
        'Date_dacquistationDateTimePicker
        '
        Me.Date_dacquistationDateTimePicker.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_dacquistationDateTimePicker.Location = New System.Drawing.Point(157, 300)
        Me.Date_dacquistationDateTimePicker.Name = "Date_dacquistationDateTimePicker"
        Me.Date_dacquistationDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Date_dacquistationDateTimePicker.TabIndex = 37
        '
        'TVATextBox
        '
        Me.TVATextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVATextBox.Location = New System.Drawing.Point(157, 271)
        Me.TVATextBox.Name = "TVATextBox"
        Me.TVATextBox.Size = New System.Drawing.Size(200, 23)
        Me.TVATextBox.TabIndex = 39
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(157, 135)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 23)
        Me.TextBox2.TabIndex = 44
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(157, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 23)
        Me.TextBox3.TabIndex = 45
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 190)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 46
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(157, 216)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'T_ID
        '
        Me.T_ID.Location = New System.Drawing.Point(157, 77)
        Me.T_ID.Name = "T_ID"
        Me.T_ID.Size = New System.Drawing.Size(200, 20)
        Me.T_ID.TabIndex = 49
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(117, 78)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(34, 16)
        Label3.TabIndex = 34
        Label3.Text = "ID :"
        '
        'DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(406, 472)
        Me.Controls.Add(Me.T_ID)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label2)
        Me.Controls.Add(TVALabel)
        Me.Controls.Add(Me.TVATextBox)
        Me.Controls.Add(Date_dacquistationLabel)
        Me.Controls.Add(Me.Date_dacquistationDateTimePicker)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Ref_articleLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_fournLabel)
        Me.Controls.Add(Id_modeLabel)
        Me.Controls.Add(Id_uniteLabel)
        Me.Controls.Add(Montant_htLabel)
        Me.Controls.Add(Me.Montant_htTextBox)
        Me.Controls.Add(Montant_ttcLabel)
        Me.Controls.Add(Me.Montant_ttcTextBox)
        Me.Controls.Add(Prix_unitaireLabel)
        Me.Controls.Add(Me.Prix_unitaireTextBox)
        Me.Controls.Add(QuantiteLabel)
        Me.Controls.Add(Me.QuantiteTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DETAILS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detail Article"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Montant_htTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Montant_ttcTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prix_unitaireTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Date_dacquistationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents T_ID As System.Windows.Forms.TextBox
End Class
