<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
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
        Me.Combo_services = New System.Windows.Forms.ComboBox()
        Me.ServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Combo_roles = New System.Windows.Forms.ComboBox()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.t_prenom = New System.Windows.Forms.TextBox()
        Me.t_nom = New System.Windows.Forms.TextBox()
        Me.t_pass = New System.Windows.Forms.TextBox()
        Me.T_matric = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Login_lab = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Radio_admin = New System.Windows.Forms.RadioButton()
        Me.Radio_archiv = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combo_salle = New System.Windows.Forms.ComboBox()
        Me.SalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Combo_services
        '
        Me.Combo_services.BackColor = System.Drawing.Color.Silver
        Me.Combo_services.DataSource = Me.ServiceBindingSource
        Me.Combo_services.DisplayMember = "Nom_Service"
        Me.Combo_services.Enabled = False
        Me.Combo_services.FormattingEnabled = True
        Me.Combo_services.Location = New System.Drawing.Point(128, 238)
        Me.Combo_services.Name = "Combo_services"
        Me.Combo_services.Size = New System.Drawing.Size(155, 21)
        Me.Combo_services.TabIndex = 30
        Me.Combo_services.ValueMember = "Code_Service"
        '
        'ServiceBindingSource
        '
        Me.ServiceBindingSource.DataSource = GetType(Projet_Al_Omrane.Service)
        '
        'Combo_roles
        '
        Me.Combo_roles.BackColor = System.Drawing.Color.Silver
        Me.Combo_roles.DataSource = Me.RolesBindingSource
        Me.Combo_roles.DisplayMember = "Lib_Role"
        Me.Combo_roles.Enabled = False
        Me.Combo_roles.FormattingEnabled = True
        Me.Combo_roles.Location = New System.Drawing.Point(128, 274)
        Me.Combo_roles.Name = "Combo_roles"
        Me.Combo_roles.Size = New System.Drawing.Size(155, 21)
        Me.Combo_roles.TabIndex = 29
        Me.Combo_roles.ValueMember = "Code_Role"
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataSource = GetType(Projet_Al_Omrane.Roles)
        '
        't_prenom
        '
        Me.t_prenom.Enabled = False
        Me.t_prenom.Location = New System.Drawing.Point(128, 204)
        Me.t_prenom.Name = "t_prenom"
        Me.t_prenom.Size = New System.Drawing.Size(155, 20)
        Me.t_prenom.TabIndex = 26
        '
        't_nom
        '
        Me.t_nom.Enabled = False
        Me.t_nom.Location = New System.Drawing.Point(128, 168)
        Me.t_nom.Name = "t_nom"
        Me.t_nom.Size = New System.Drawing.Size(155, 20)
        Me.t_nom.TabIndex = 25
        '
        't_pass
        '
        Me.t_pass.Enabled = False
        Me.t_pass.Location = New System.Drawing.Point(128, 135)
        Me.t_pass.Name = "t_pass"
        Me.t_pass.Size = New System.Drawing.Size(155, 20)
        Me.t_pass.TabIndex = 24
        '
        'T_matric
        '
        Me.T_matric.Enabled = False
        Me.T_matric.Location = New System.Drawing.Point(128, 99)
        Me.T_matric.Name = "T_matric"
        Me.T_matric.Size = New System.Drawing.Size(155, 20)
        Me.T_matric.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Service"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NOM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mot-pass"
        '
        'Login_lab
        '
        Me.Login_lab.AutoSize = True
        Me.Login_lab.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_lab.Location = New System.Drawing.Point(37, 103)
        Me.Login_lab.Name = "Login_lab"
        Me.Login_lab.Size = New System.Drawing.Size(63, 16)
        Me.Login_lab.TabIndex = 17
        Me.Login_lab.Text = "Matricule"
        '
        'Button2
        '
        Me.Button2.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1367007187_001_39
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(200, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 40)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Annuler"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368041173_user_group_new
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(112, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 40)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "OK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Radio_admin
        '
        Me.Radio_admin.AutoSize = True
        Me.Radio_admin.Location = New System.Drawing.Point(40, 26)
        Me.Radio_admin.Name = "Radio_admin"
        Me.Radio_admin.Size = New System.Drawing.Size(109, 17)
        Me.Radio_admin.TabIndex = 31
        Me.Radio_admin.TabStop = True
        Me.Radio_admin.Text = "Admin/Consultant"
        Me.Radio_admin.UseVisualStyleBackColor = True
        '
        'Radio_archiv
        '
        Me.Radio_archiv.AutoSize = True
        Me.Radio_archiv.Location = New System.Drawing.Point(193, 26)
        Me.Radio_archiv.Name = "Radio_archiv"
        Me.Radio_archiv.Size = New System.Drawing.Size(70, 17)
        Me.Radio_archiv.TabIndex = 32
        Me.Radio_archiv.TabStop = True
        Me.Radio_archiv.Text = "Archiveur"
        Me.Radio_archiv.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Code Salle"
        '
        'Combo_salle
        '
        Me.Combo_salle.BackColor = System.Drawing.Color.DarkGray
        Me.Combo_salle.DataSource = Me.SalleBindingSource
        Me.Combo_salle.DisplayMember = "Lib_salle"
        Me.Combo_salle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_salle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combo_salle.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Combo_salle.FormattingEnabled = True
        Me.Combo_salle.Location = New System.Drawing.Point(128, 71)
        Me.Combo_salle.Name = "Combo_salle"
        Me.Combo_salle.Size = New System.Drawing.Size(155, 21)
        Me.Combo_salle.TabIndex = 34
        Me.Combo_salle.Tag = "selectionnez une salle"
        Me.Combo_salle.ValueMember = "Code_Salle"
        '
        'SalleBindingSource
        '
        Me.SalleBindingSource.DataSource = GetType(Projet_Al_Omrane.Salle)
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 396)
        Me.Controls.Add(Me.Combo_salle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Radio_archiv)
        Me.Controls.Add(Me.Radio_admin)
        Me.Controls.Add(Me.Combo_services)
        Me.Controls.Add(Me.Combo_roles)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t_prenom)
        Me.Controls.Add(Me.t_nom)
        Me.Controls.Add(Me.t_pass)
        Me.Controls.Add(Me.T_matric)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Login_lab)
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Combo_services As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_roles As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents t_prenom As System.Windows.Forms.TextBox
    Friend WithEvents t_nom As System.Windows.Forms.TextBox
    Friend WithEvents t_pass As System.Windows.Forms.TextBox
    Friend WithEvents T_matric As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Login_lab As System.Windows.Forms.Label
    Friend WithEvents ServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Radio_admin As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_archiv As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combo_salle As System.Windows.Forms.ComboBox
    Friend WithEvents SalleBindingSource As System.Windows.Forms.BindingSource
End Class
