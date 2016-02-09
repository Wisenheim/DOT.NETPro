<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAJ_Comptes
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
        Me.components = New System.ComponentModel.Container()
        Dim MatriculeLabel As System.Windows.Forms.Label
        Dim Nom_ULabel As System.Windows.Forms.Label
        Dim Prenom_ULabel As System.Windows.Forms.Label
        Dim Mot_passLabel As System.Windows.Forms.Label
        Dim Code_roleLabel As System.Windows.Forms.Label
        Dim Code_serviceLabel As System.Windows.Forms.Label
        Me.l_salle = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.T_mat = New System.Windows.Forms.TextBox()
        Me.Combo_roles = New System.Windows.Forms.ComboBox()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.B_Supprimer = New System.Windows.Forms.Button()
        Me.B_Modifier = New System.Windows.Forms.Button()
        Me.L_notfound = New System.Windows.Forms.Label()
        Me.MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_UTextBox = New System.Windows.Forms.TextBox()
        Me.Prenom_UTextBox = New System.Windows.Forms.TextBox()
        Me.Mot_passTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C_service = New System.Windows.Forms.ComboBox()
        Me.ServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_ar = New System.Windows.Forms.Label()
        Me.L_archiv = New System.Windows.Forms.Label()
        MatriculeLabel = New System.Windows.Forms.Label()
        Nom_ULabel = New System.Windows.Forms.Label()
        Prenom_ULabel = New System.Windows.Forms.Label()
        Mot_passLabel = New System.Windows.Forms.Label()
        Code_roleLabel = New System.Windows.Forms.Label()
        Code_serviceLabel = New System.Windows.Forms.Label()
        CType(Me.SalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculeLabel
        '
        MatriculeLabel.AutoSize = True
        MatriculeLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculeLabel.Location = New System.Drawing.Point(23, 110)
        MatriculeLabel.Name = "MatriculeLabel"
        MatriculeLabel.Size = New System.Drawing.Size(64, 16)
        MatriculeLabel.TabIndex = 43
        MatriculeLabel.Text = "Matricule:"
        '
        'Nom_ULabel
        '
        Nom_ULabel.AutoSize = True
        Nom_ULabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_ULabel.Location = New System.Drawing.Point(23, 139)
        Nom_ULabel.Name = "Nom_ULabel"
        Nom_ULabel.Size = New System.Drawing.Size(42, 16)
        Nom_ULabel.TabIndex = 45
        Nom_ULabel.Text = "Nom :"
        '
        'Prenom_ULabel
        '
        Prenom_ULabel.AutoSize = True
        Prenom_ULabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prenom_ULabel.Location = New System.Drawing.Point(23, 168)
        Prenom_ULabel.Name = "Prenom_ULabel"
        Prenom_ULabel.Size = New System.Drawing.Size(56, 16)
        Prenom_ULabel.TabIndex = 47
        Prenom_ULabel.Text = "Prenom :"
        '
        'Mot_passLabel
        '
        Mot_passLabel.AutoSize = True
        Mot_passLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mot_passLabel.Location = New System.Drawing.Point(23, 197)
        Mot_passLabel.Name = "Mot_passLabel"
        Mot_passLabel.Size = New System.Drawing.Size(62, 16)
        Mot_passLabel.TabIndex = 49
        Mot_passLabel.Text = "Mot pass:"
        '
        'Code_roleLabel
        '
        Code_roleLabel.AutoSize = True
        Code_roleLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_roleLabel.Location = New System.Drawing.Point(23, 226)
        Code_roleLabel.Name = "Code_roleLabel"
        Code_roleLabel.Size = New System.Drawing.Size(40, 16)
        Code_roleLabel.TabIndex = 51
        Code_roleLabel.Text = "Role :"
        '
        'Code_serviceLabel
        '
        Code_serviceLabel.AutoSize = True
        Code_serviceLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_serviceLabel.Location = New System.Drawing.Point(23, 255)
        Code_serviceLabel.Name = "Code_serviceLabel"
        Code_serviceLabel.Size = New System.Drawing.Size(57, 16)
        Code_serviceLabel.TabIndex = 52
        Code_serviceLabel.Text = "Service :"
        '
        'l_salle
        '
        Me.l_salle.AutoSize = True
        Me.l_salle.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_salle.Location = New System.Drawing.Point(23, 288)
        Me.l_salle.Name = "l_salle"
        Me.l_salle.Size = New System.Drawing.Size(34, 16)
        Me.l_salle.TabIndex = 60
        Me.l_salle.Text = "Salle"
        Me.l_salle.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SalleBindingSource
        Me.ComboBox1.DisplayMember = "Lib_salle"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(100, 283)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 24)
        Me.ComboBox1.TabIndex = 59
        Me.ComboBox1.ValueMember = "Code_Salle"
        Me.ComboBox1.Visible = False
        '
        'SalleBindingSource
        '
        Me.SalleBindingSource.DataSource = GetType(Projet_Al_Omrane.Salle)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrer le Matricule :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button4.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368041759_new
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(288, 106)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 44)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Nouveau"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369232217_DeleteRed
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(288, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 36)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Quitter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'T_mat
        '
        Me.T_mat.Location = New System.Drawing.Point(192, 35)
        Me.T_mat.Name = "T_mat"
        Me.T_mat.Size = New System.Drawing.Size(117, 23)
        Me.T_mat.TabIndex = 1
        '
        'Combo_roles
        '
        Me.Combo_roles.DataSource = Me.RolesBindingSource
        Me.Combo_roles.DisplayMember = "Lib_Role"
        Me.Combo_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_roles.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_roles.FormattingEnabled = True
        Me.Combo_roles.Location = New System.Drawing.Point(100, 223)
        Me.Combo_roles.Name = "Combo_roles"
        Me.Combo_roles.Size = New System.Drawing.Size(163, 24)
        Me.Combo_roles.TabIndex = 55
        Me.Combo_roles.ValueMember = "Code_Role"
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataSource = GetType(Projet_Al_Omrane.Roles)
        '
        'B_Supprimer
        '
        Me.B_Supprimer.Enabled = False
        Me.B_Supprimer.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368111692_Remove_Male_User
        Me.B_Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_Supprimer.Location = New System.Drawing.Point(288, 205)
        Me.B_Supprimer.Name = "B_Supprimer"
        Me.B_Supprimer.Size = New System.Drawing.Size(84, 42)
        Me.B_Supprimer.TabIndex = 54
        Me.B_Supprimer.Text = "Supprimer"
        Me.B_Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Supprimer.UseVisualStyleBackColor = True
        '
        'B_Modifier
        '
        Me.B_Modifier.Enabled = False
        Me.B_Modifier.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368042813_gtk_refresh
        Me.B_Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_Modifier.Location = New System.Drawing.Point(288, 157)
        Me.B_Modifier.Name = "B_Modifier"
        Me.B_Modifier.Size = New System.Drawing.Size(84, 42)
        Me.B_Modifier.TabIndex = 53
        Me.B_Modifier.Text = "Modifier"
        Me.B_Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Modifier.UseVisualStyleBackColor = True
        '
        'L_notfound
        '
        Me.L_notfound.AutoSize = True
        Me.L_notfound.ForeColor = System.Drawing.Color.Red
        Me.L_notfound.Location = New System.Drawing.Point(172, 59)
        Me.L_notfound.Name = "L_notfound"
        Me.L_notfound.Size = New System.Drawing.Size(123, 15)
        Me.L_notfound.TabIndex = 3
        Me.L_notfound.Text = "Compte Introuvable !!"
        Me.L_notfound.Visible = False
        '
        'MatriculeTextBox
        '
        Me.MatriculeTextBox.Enabled = False
        Me.MatriculeTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculeTextBox.Location = New System.Drawing.Point(100, 107)
        Me.MatriculeTextBox.Name = "MatriculeTextBox"
        Me.MatriculeTextBox.Size = New System.Drawing.Size(163, 23)
        Me.MatriculeTextBox.TabIndex = 44
        '
        'Nom_UTextBox
        '
        Me.Nom_UTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_UTextBox.Location = New System.Drawing.Point(100, 136)
        Me.Nom_UTextBox.Name = "Nom_UTextBox"
        Me.Nom_UTextBox.Size = New System.Drawing.Size(163, 23)
        Me.Nom_UTextBox.TabIndex = 46
        '
        'Prenom_UTextBox
        '
        Me.Prenom_UTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prenom_UTextBox.Location = New System.Drawing.Point(100, 165)
        Me.Prenom_UTextBox.Name = "Prenom_UTextBox"
        Me.Prenom_UTextBox.Size = New System.Drawing.Size(163, 23)
        Me.Prenom_UTextBox.TabIndex = 48
        '
        'Mot_passTextBox
        '
        Me.Mot_passTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mot_passTextBox.Location = New System.Drawing.Point(100, 194)
        Me.Mot_passTextBox.Name = "Mot_passTextBox"
        Me.Mot_passTextBox.Size = New System.Drawing.Size(163, 23)
        Me.Mot_passTextBox.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.L_notfound)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.T_mat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 78)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chercher Un Compte"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368129121_administrator1
        Me.PictureBox1.Location = New System.Drawing.Point(315, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368042624_file_search
        Me.Label2.Location = New System.Drawing.Point(-3, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 49)
        Me.Label2.TabIndex = 2
        '
        'C_service
        '
        Me.C_service.DataSource = Me.ServiceBindingSource
        Me.C_service.DisplayMember = "Nom_Service"
        Me.C_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_service.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_service.FormattingEnabled = True
        Me.C_service.Location = New System.Drawing.Point(100, 254)
        Me.C_service.Name = "C_service"
        Me.C_service.Size = New System.Drawing.Size(163, 23)
        Me.C_service.TabIndex = 61
        Me.C_service.ValueMember = "Code_Service"
        '
        'ServiceBindingSource
        '
        Me.ServiceBindingSource.DataSource = GetType(Projet_Al_Omrane.Service)
        '
        'L_ar
        '
        Me.L_ar.AutoSize = True
        Me.L_ar.BackColor = System.Drawing.Color.Transparent
        Me.L_ar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ar.Location = New System.Drawing.Point(116, 226)
        Me.L_ar.Name = "L_ar"
        Me.L_ar.Size = New System.Drawing.Size(64, 18)
        Me.L_ar.TabIndex = 62
        Me.L_ar.Text = "Archiveur"
        Me.L_ar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L_ar.Visible = False
        '
        'L_archiv
        '
        Me.L_archiv.AutoSize = True
        Me.L_archiv.BackColor = System.Drawing.Color.Transparent
        Me.L_archiv.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_archiv.Location = New System.Drawing.Point(116, 257)
        Me.L_archiv.Name = "L_archiv"
        Me.L_archiv.Size = New System.Drawing.Size(65, 18)
        Me.L_archiv.TabIndex = 63
        Me.L_archiv.Text = "Archivage"
        Me.L_archiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L_archiv.Visible = False
        '
        'MAJ_Comptes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(415, 322)
        Me.Controls.Add(Me.L_archiv)
        Me.Controls.Add(Me.L_ar)
        Me.Controls.Add(Me.C_service)
        Me.Controls.Add(Me.l_salle)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Combo_roles)
        Me.Controls.Add(Me.B_Supprimer)
        Me.Controls.Add(Me.B_Modifier)
        Me.Controls.Add(MatriculeLabel)
        Me.Controls.Add(Me.MatriculeTextBox)
        Me.Controls.Add(Nom_ULabel)
        Me.Controls.Add(Me.Nom_UTextBox)
        Me.Controls.Add(Prenom_ULabel)
        Me.Controls.Add(Me.Prenom_UTextBox)
        Me.Controls.Add(Mot_passLabel)
        Me.Controls.Add(Me.Mot_passTextBox)
        Me.Controls.Add(Code_roleLabel)
        Me.Controls.Add(Code_serviceLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MAJ_Comptes"
        Me.Text = "MAJ_Comptes"
        CType(Me.SalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l_salle As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents T_mat As System.Windows.Forms.TextBox
    Friend WithEvents Combo_roles As System.Windows.Forms.ComboBox
    Friend WithEvents B_Supprimer As System.Windows.Forms.Button
    Friend WithEvents B_Modifier As System.Windows.Forms.Button
    Friend WithEvents L_notfound As System.Windows.Forms.Label
    Friend WithEvents MatriculeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prenom_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mot_passTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents C_service As System.Windows.Forms.ComboBox
    Friend WithEvents ServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents L_ar As System.Windows.Forms.Label
    Friend WithEvents L_archiv As System.Windows.Forms.Label
End Class
