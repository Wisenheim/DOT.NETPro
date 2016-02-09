<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articles
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
        Dim TVALabel As System.Windows.Forms.Label
        Dim Ref_articleLabel As System.Windows.Forms.Label
        Dim Id_fournLabel As System.Windows.Forms.Label
        Dim Id_modeLabel As System.Windows.Forms.Label
        Dim Id_uniteLabel As System.Windows.Forms.Label
        Dim Prix_unitaireLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.TVATextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Prix_unitaireTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        TVALabel = New System.Windows.Forms.Label()
        Ref_articleLabel = New System.Windows.Forms.Label()
        Id_fournLabel = New System.Windows.Forms.Label()
        Id_modeLabel = New System.Windows.Forms.Label()
        Id_uniteLabel = New System.Windows.Forms.Label()
        Prix_unitaireLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TVALabel
        '
        TVALabel.AutoSize = True
        TVALabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TVALabel.Location = New System.Drawing.Point(43, 305)
        TVALabel.Name = "TVALabel"
        TVALabel.Size = New System.Drawing.Size(38, 16)
        TVALabel.TabIndex = 62
        TVALabel.Text = "TVA:"
        '
        'Ref_articleLabel
        '
        Ref_articleLabel.AutoSize = True
        Ref_articleLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ref_articleLabel.Location = New System.Drawing.Point(19, 114)
        Ref_articleLabel.Name = "Ref_articleLabel"
        Ref_articleLabel.Size = New System.Drawing.Size(121, 16)
        Ref_articleLabel.TabIndex = 58
        Ref_articleLabel.Text = "Reference article :"
        '
        'Id_fournLabel
        '
        Id_fournLabel.AutoSize = True
        Id_fournLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_fournLabel.Location = New System.Drawing.Point(43, 193)
        Id_fournLabel.Name = "Id_fournLabel"
        Id_fournLabel.Size = New System.Drawing.Size(83, 16)
        Id_fournLabel.TabIndex = 40
        Id_fournLabel.Text = "Fournisseur :"
        '
        'Id_modeLabel
        '
        Id_modeLabel.AutoSize = True
        Id_modeLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_modeLabel.Location = New System.Drawing.Point(23, 219)
        Id_modeLabel.Name = "Id_modeLabel"
        Id_modeLabel.Size = New System.Drawing.Size(117, 16)
        Id_modeLabel.TabIndex = 41
        Id_modeLabel.Text = "Mode de paiment :"
        '
        'Id_uniteLabel
        '
        Id_uniteLabel.AutoSize = True
        Id_uniteLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_uniteLabel.Location = New System.Drawing.Point(43, 245)
        Id_uniteLabel.Name = "Id_uniteLabel"
        Id_uniteLabel.Size = New System.Drawing.Size(49, 16)
        Id_uniteLabel.TabIndex = 42
        Id_uniteLabel.Text = "Unitè :"
        '
        'Prix_unitaireLabel
        '
        Prix_unitaireLabel.AutoSize = True
        Prix_unitaireLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prix_unitaireLabel.Location = New System.Drawing.Point(43, 275)
        Prix_unitaireLabel.Name = "Prix_unitaireLabel"
        Prix_unitaireLabel.Size = New System.Drawing.Size(84, 16)
        Prix_unitaireLabel.TabIndex = 47
        Prix_unitaireLabel.Text = "prix unitaire:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(15, 29)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 16)
        Label1.TabIndex = 66
        Label1.Text = "Article :"
        '
        'TVATextBox
        '
        Me.TVATextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVATextBox.Location = New System.Drawing.Point(146, 302)
        Me.TVATextBox.Name = "TVATextBox"
        Me.TVATextBox.Size = New System.Drawing.Size(200, 24)
        Me.TVATextBox.TabIndex = 63
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"UNITE", "TON", "KG", "METRE", "CENTIMETRE", "LITRE", "GRAMME"})
        Me.ComboBox4.Location = New System.Drawing.Point(146, 242)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox4.TabIndex = 53
        '
        'ComboBox3
        '
        Me.ComboBox3.DisplayMember = "mode"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.ComboBox3.Location = New System.Drawing.Point(146, 216)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox3.TabIndex = 52
        Me.ComboBox3.ValueMember = "id_pai"
        '
        'Prix_unitaireTextBox
        '
        Me.Prix_unitaireTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prix_unitaireTextBox.Location = New System.Drawing.Point(146, 272)
        Me.Prix_unitaireTextBox.Name = "Prix_unitaireTextBox"
        Me.Prix_unitaireTextBox.Size = New System.Drawing.Size(200, 24)
        Me.Prix_unitaireTextBox.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 64
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(146, 192)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 23)
        Me.TextBox2.TabIndex = 65
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 64)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche Article"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(219, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(92, 24)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 78
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.amrani_foundation.My.Resources.Resources._1367006511_dialog_close
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(278, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 37)
        Me.Button4.TabIndex = 57
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
        Me.Button3.Location = New System.Drawing.Point(186, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 37)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "Modifier"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.amrani_foundation.My.Resources.Resources._1368041759_new
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(2, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 37)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Nouveau"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.amrani_foundation.My.Resources.Resources._1369232184_netvibes
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(98, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Article"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Designation :"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(146, 139)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 24)
        Me.TextBox3.TabIndex = 71
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(146, 165)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 24)
        Me.TextBox4.TabIndex = 72
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(133, 79)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 16)
        Me.LinkLabel1.TabIndex = 73
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nouvelle Recherche !!!!"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(92, 402)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(180, 15)
        Me.LinkLabel2.TabIndex = 74
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Afficher tous les Articles !!!!"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid1.Location = New System.Drawing.Point(377, 51)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(739, 348)
        Me.DataGrid1.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(652, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 23)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Tous les Articles"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(680, 402)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(139, 16)
        Me.LinkLabel3.TabIndex = 77
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Nouvelle Recherche !!!!"
        '
        'Articles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 429)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(TVALabel)
        Me.Controls.Add(Me.TVATextBox)
        Me.Controls.Add(Ref_articleLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Id_fournLabel)
        Me.Controls.Add(Id_modeLabel)
        Me.Controls.Add(Id_uniteLabel)
        Me.Controls.Add(Prix_unitaireLabel)
        Me.Controls.Add(Me.Prix_unitaireTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Articles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Prix_unitaireTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
End Class
