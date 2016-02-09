<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maj_Dossier
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
        Dim Label1 As System.Windows.Forms.Label
        Dim AdresseLabel As System.Windows.Forms.Label
        Dim Code_DossierLabel As System.Windows.Forms.Label
        Dim Code_serviceLabel As System.Windows.Forms.Label
        Dim Date_DepotLabel As System.Windows.Forms.Label
        Dim Etat_dossLabel As System.Windows.Forms.Label
        Dim ExerciceLabel As System.Windows.Forms.Label
        Dim Num_OrdreLabel As System.Windows.Forms.Label
        Dim ReferenceLabel As System.Windows.Forms.Label
        Dim Date_entreeLabel As System.Windows.Forms.Label
        Dim MatriculeLabel As System.Windows.Forms.Label
        Dim Type_MvtLabel As System.Windows.Forms.Label
        Dim L_obj As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.L_introuv = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_code = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Code_DossierTextBox = New System.Windows.Forms.TextBox()
        Me.Date_DepotDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Etat_dossTextBox = New System.Windows.Forms.TextBox()
        Me.Num_OrdreTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenceTextBox = New System.Windows.Forms.TextBox()
        Me.B_mouv = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TypeMouvementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Date_entreeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MatriculeTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.exercicetextbox = New System.Windows.Forms.MaskedTextBox()
        Me.Li_obg = New System.Windows.Forms.ListBox()
        Me.B_scan = New System.Windows.Forms.Button()
        Me.comb_adress = New System.Windows.Forms.ComboBox()
        Me.DossierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmplacementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combo_servic = New System.Windows.Forms.ComboBox()
        Me.ServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.get_file = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        AdresseLabel = New System.Windows.Forms.Label()
        Code_DossierLabel = New System.Windows.Forms.Label()
        Code_serviceLabel = New System.Windows.Forms.Label()
        Date_DepotLabel = New System.Windows.Forms.Label()
        Etat_dossLabel = New System.Windows.Forms.Label()
        ExerciceLabel = New System.Windows.Forms.Label()
        Num_OrdreLabel = New System.Windows.Forms.Label()
        ReferenceLabel = New System.Windows.Forms.Label()
        Date_entreeLabel = New System.Windows.Forms.Label()
        MatriculeLabel = New System.Windows.Forms.Label()
        Type_MvtLabel = New System.Windows.Forms.Label()
        L_obj = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TypeMouvementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DossierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmplacementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(68, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 16)
        Label1.TabIndex = 20
        Label1.Text = "Code_Dossier :"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdresseLabel.Location = New System.Drawing.Point(19, 116)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(92, 16)
        AdresseLabel.TabIndex = 39
        AdresseLabel.Text = "Emplacement :"
        '
        'Code_DossierLabel
        '
        Code_DossierLabel.AutoSize = True
        Code_DossierLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_DossierLabel.Location = New System.Drawing.Point(19, 148)
        Code_DossierLabel.Name = "Code_DossierLabel"
        Code_DossierLabel.Size = New System.Drawing.Size(88, 16)
        Code_DossierLabel.TabIndex = 41
        Code_DossierLabel.Text = "Code Dossier:"
        '
        'Code_serviceLabel
        '
        Code_serviceLabel.AutoSize = True
        Code_serviceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_serviceLabel.Location = New System.Drawing.Point(19, 180)
        Code_serviceLabel.Name = "Code_serviceLabel"
        Code_serviceLabel.Size = New System.Drawing.Size(84, 16)
        Code_serviceLabel.TabIndex = 43
        Code_serviceLabel.Text = "Nom service:"
        '
        'Date_DepotLabel
        '
        Date_DepotLabel.AutoSize = True
        Date_DepotLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_DepotLabel.Location = New System.Drawing.Point(19, 214)
        Date_DepotLabel.Name = "Date_DepotLabel"
        Date_DepotLabel.Size = New System.Drawing.Size(81, 16)
        Date_DepotLabel.TabIndex = 45
        Date_DepotLabel.Text = "Date Depot:"
        '
        'Etat_dossLabel
        '
        Etat_dossLabel.AutoSize = True
        Etat_dossLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Etat_dossLabel.Location = New System.Drawing.Point(19, 244)
        Etat_dossLabel.Name = "Etat_dossLabel"
        Etat_dossLabel.Size = New System.Drawing.Size(69, 16)
        Etat_dossLabel.TabIndex = 47
        Etat_dossLabel.Text = "etat doss:"
        '
        'ExerciceLabel
        '
        ExerciceLabel.AutoSize = True
        ExerciceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExerciceLabel.Location = New System.Drawing.Point(19, 276)
        ExerciceLabel.Name = "ExerciceLabel"
        ExerciceLabel.Size = New System.Drawing.Size(62, 16)
        ExerciceLabel.TabIndex = 49
        ExerciceLabel.Text = "exercice:"
        '
        'Num_OrdreLabel
        '
        Num_OrdreLabel.AutoSize = True
        Num_OrdreLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_OrdreLabel.Location = New System.Drawing.Point(19, 308)
        Num_OrdreLabel.Name = "Num_OrdreLabel"
        Num_OrdreLabel.Size = New System.Drawing.Size(79, 16)
        Num_OrdreLabel.TabIndex = 51
        Num_OrdreLabel.Text = "Num Ordre:"
        '
        'ReferenceLabel
        '
        ReferenceLabel.AutoSize = True
        ReferenceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReferenceLabel.Location = New System.Drawing.Point(19, 340)
        ReferenceLabel.Name = "ReferenceLabel"
        ReferenceLabel.Size = New System.Drawing.Size(73, 16)
        ReferenceLabel.TabIndex = 53
        ReferenceLabel.Text = "Reference:"
        '
        'Date_entreeLabel
        '
        Date_entreeLabel.AutoSize = True
        Date_entreeLabel.Location = New System.Drawing.Point(469, 311)
        Date_entreeLabel.Name = "Date_entreeLabel"
        Date_entreeLabel.Size = New System.Drawing.Size(86, 16)
        Date_entreeLabel.TabIndex = 57
        Date_entreeLabel.Text = "Date entree:"
        '
        'MatriculeLabel
        '
        MatriculeLabel.AutoSize = True
        MatriculeLabel.Location = New System.Drawing.Point(469, 343)
        MatriculeLabel.Name = "MatriculeLabel"
        MatriculeLabel.Size = New System.Drawing.Size(66, 16)
        MatriculeLabel.TabIndex = 61
        MatriculeLabel.Text = "matricule:"
        '
        'Type_MvtLabel
        '
        Type_MvtLabel.AutoSize = True
        Type_MvtLabel.Location = New System.Drawing.Point(469, 377)
        Type_MvtLabel.Name = "Type_MvtLabel"
        Type_MvtLabel.Size = New System.Drawing.Size(69, 16)
        Type_MvtLabel.TabIndex = 63
        Type_MvtLabel.Text = "Type Mvt:"
        '
        'L_obj
        '
        L_obj.AutoSize = True
        L_obj.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        L_obj.Location = New System.Drawing.Point(19, 394)
        L_obj.Name = "L_obj"
        L_obj.Size = New System.Drawing.Size(59, 16)
        L_obj.TabIndex = 72
        L_obj.Text = "Objets :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.L_introuv)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.t_code)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(341, 84)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher un Dossier"
        '
        'L_introuv
        '
        Me.L_introuv.AutoSize = True
        Me.L_introuv.ForeColor = System.Drawing.Color.Red
        Me.L_introuv.Location = New System.Drawing.Point(180, 60)
        Me.L_introuv.Name = "L_introuv"
        Me.L_introuv.Size = New System.Drawing.Size(119, 16)
        Me.L_introuv.TabIndex = 23
        Me.L_introuv.Text = "Dossier introuvable"
        Me.L_introuv.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(15, 64)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(133, 16)
        Me.LinkLabel3.TabIndex = 22
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Nouvelle Recherche !!"
        Me.LinkLabel3.Visible = False
        '
        'Label2
        '
        Me.Label2.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368042624_file_search
        Me.Label2.Location = New System.Drawing.Point(15, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 48)
        Me.Label2.TabIndex = 21
        '
        't_code
        '
        Me.t_code.Location = New System.Drawing.Point(167, 32)
        Me.t_code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_code.Name = "t_code"
        Me.t_code.Size = New System.Drawing.Size(147, 24)
        Me.t_code.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button4.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368041759_new
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(1, 493)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 44)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Nouveau"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368042946_delete_file
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(331, 493)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 44)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Supprimer"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.Enabled = False
        Me.Button2.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368042813_gtk_refresh
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(221, 493)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 44)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Modifier"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368042487_file_add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(111, 493)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 44)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Code_DossierTextBox
        '
        Me.Code_DossierTextBox.Enabled = False
        Me.Code_DossierTextBox.Location = New System.Drawing.Point(111, 145)
        Me.Code_DossierTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Code_DossierTextBox.Name = "Code_DossierTextBox"
        Me.Code_DossierTextBox.Size = New System.Drawing.Size(233, 24)
        Me.Code_DossierTextBox.TabIndex = 42
        '
        'Date_DepotDateTimePicker
        '
        Me.Date_DepotDateTimePicker.Location = New System.Drawing.Point(111, 209)
        Me.Date_DepotDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Date_DepotDateTimePicker.Name = "Date_DepotDateTimePicker"
        Me.Date_DepotDateTimePicker.Size = New System.Drawing.Size(233, 24)
        Me.Date_DepotDateTimePicker.TabIndex = 46
        '
        'Etat_dossTextBox
        '
        Me.Etat_dossTextBox.Enabled = False
        Me.Etat_dossTextBox.Location = New System.Drawing.Point(111, 241)
        Me.Etat_dossTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Etat_dossTextBox.Name = "Etat_dossTextBox"
        Me.Etat_dossTextBox.Size = New System.Drawing.Size(233, 24)
        Me.Etat_dossTextBox.TabIndex = 48
        '
        'Num_OrdreTextBox
        '
        Me.Num_OrdreTextBox.Location = New System.Drawing.Point(111, 300)
        Me.Num_OrdreTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Num_OrdreTextBox.Name = "Num_OrdreTextBox"
        Me.Num_OrdreTextBox.Size = New System.Drawing.Size(233, 24)
        Me.Num_OrdreTextBox.TabIndex = 52
        '
        'ReferenceTextBox
        '
        Me.ReferenceTextBox.Location = New System.Drawing.Point(111, 337)
        Me.ReferenceTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReferenceTextBox.Name = "ReferenceTextBox"
        Me.ReferenceTextBox.Size = New System.Drawing.Size(233, 24)
        Me.ReferenceTextBox.TabIndex = 54
        '
        'B_mouv
        '
        Me.B_mouv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.B_mouv.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369000376_stock_folder_move
        Me.B_mouv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_mouv.Location = New System.Drawing.Point(628, 428)
        Me.B_mouv.Name = "B_mouv"
        Me.B_mouv.Size = New System.Drawing.Size(110, 44)
        Me.B_mouv.TabIndex = 65
        Me.B_mouv.Text = "Mouvement "
        Me.B_mouv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_mouv.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TypeMouvementBindingSource
        Me.ComboBox1.DisplayMember = "Lib_Type"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(560, 369)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox1.TabIndex = 64
        Me.ComboBox1.ValueMember = "Code_type"
        '
        'TypeMouvementBindingSource
        '
        Me.TypeMouvementBindingSource.DataSource = GetType(Projet_Al_Omrane.Type_Mouvement)
        '
        'Date_entreeDateTimePicker
        '
        Me.Date_entreeDateTimePicker.Location = New System.Drawing.Point(560, 305)
        Me.Date_entreeDateTimePicker.Name = "Date_entreeDateTimePicker"
        Me.Date_entreeDateTimePicker.Size = New System.Drawing.Size(200, 24)
        Me.Date_entreeDateTimePicker.TabIndex = 58
        '
        'MatriculeTextBox
        '
        Me.MatriculeTextBox.Enabled = False
        Me.MatriculeTextBox.Location = New System.Drawing.Point(560, 335)
        Me.MatriculeTextBox.Name = "MatriculeTextBox"
        Me.MatriculeTextBox.Size = New System.Drawing.Size(200, 24)
        Me.MatriculeTextBox.TabIndex = 62
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LinkLabel1.Location = New System.Drawing.Point(108, 365)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(216, 16)
        Me.LinkLabel1.TabIndex = 66
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Faire un mouvement de ce dossier !!"
        Me.LinkLabel1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369000261_folder
        Me.PictureBox1.Location = New System.Drawing.Point(436, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(613, 399)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(147, 16)
        Me.LinkLabel2.TabIndex = 68
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Rechercher a nouveau !!"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button5.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369149826_user_home
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(524, 428)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 44)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Deposer"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button6.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1367006511_dialog_close1
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(648, 478)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 44)
        Me.Button6.TabIndex = 70
        Me.Button6.Text = "Quitter"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'exercicetextbox
        '
        Me.exercicetextbox.Location = New System.Drawing.Point(111, 272)
        Me.exercicetextbox.Mask = "9999"
        Me.exercicetextbox.Name = "exercicetextbox"
        Me.exercicetextbox.Size = New System.Drawing.Size(70, 24)
        Me.exercicetextbox.TabIndex = 71
        Me.exercicetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Li_obg
        '
        Me.Li_obg.FormattingEnabled = True
        Me.Li_obg.ItemHeight = 16
        Me.Li_obg.Location = New System.Drawing.Point(111, 394)
        Me.Li_obg.Name = "Li_obg"
        Me.Li_obg.Size = New System.Drawing.Size(173, 84)
        Me.Li_obg.TabIndex = 73
        '
        'B_scan
        '
        Me.B_scan.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.B_scan.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1370575587_scanner
        Me.B_scan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_scan.Location = New System.Drawing.Point(290, 394)
        Me.B_scan.Name = "B_scan"
        Me.B_scan.Size = New System.Drawing.Size(81, 43)
        Me.B_scan.TabIndex = 74
        Me.B_scan.Text = "Scanner"
        Me.B_scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_scan.UseVisualStyleBackColor = False
        '
        'comb_adress
        '
        Me.comb_adress.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DossierBindingSource, "adresse", True))
        Me.comb_adress.DataSource = Me.EmplacementBindingSource
        Me.comb_adress.DisplayMember = "Adresse"
        Me.comb_adress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comb_adress.Enabled = False
        Me.comb_adress.FormattingEnabled = True
        Me.comb_adress.Location = New System.Drawing.Point(111, 113)
        Me.comb_adress.Name = "comb_adress"
        Me.comb_adress.Size = New System.Drawing.Size(233, 24)
        Me.comb_adress.TabIndex = 75
        Me.comb_adress.ValueMember = "Adresse"
        '
        'DossierBindingSource
        '
        Me.DossierBindingSource.DataSource = GetType(Projet_Al_Omrane.Dossier)
        '
        'EmplacementBindingSource
        '
        Me.EmplacementBindingSource.DataSource = GetType(Projet_Al_Omrane.Emplacement)
        '
        'combo_servic
        '
        Me.combo_servic.DataSource = Me.ServiceBindingSource
        Me.combo_servic.DisplayMember = "Nom_Service"
        Me.combo_servic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_servic.Enabled = False
        Me.combo_servic.FormattingEnabled = True
        Me.combo_servic.Location = New System.Drawing.Point(111, 176)
        Me.combo_servic.Name = "combo_servic"
        Me.combo_servic.Size = New System.Drawing.Size(233, 24)
        Me.combo_servic.TabIndex = 76
        Me.combo_servic.ValueMember = "Code_Service"
        '
        'ServiceBindingSource
        '
        Me.ServiceBindingSource.DataSource = GetType(Projet_Al_Omrane.Service)
        '
        'get_file
        '
        Me.get_file.BackColor = System.Drawing.Color.Silver
        Me.get_file.Location = New System.Drawing.Point(291, 443)
        Me.get_file.Name = "get_file"
        Me.get_file.Size = New System.Drawing.Size(80, 42)
        Me.get_file.TabIndex = 77
        Me.get_file.Text = "Ouvrir fichier"
        Me.get_file.UseVisualStyleBackColor = False
        '
        'Maj_Dossier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 538)
        Me.Controls.Add(Me.get_file)
        Me.Controls.Add(Me.combo_servic)
        Me.Controls.Add(Me.comb_adress)
        Me.Controls.Add(Me.B_scan)
        Me.Controls.Add(Me.Li_obg)
        Me.Controls.Add(L_obj)
        Me.Controls.Add(Me.exercicetextbox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.B_mouv)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Date_entreeLabel)
        Me.Controls.Add(Me.Date_entreeDateTimePicker)
        Me.Controls.Add(MatriculeLabel)
        Me.Controls.Add(Me.MatriculeTextBox)
        Me.Controls.Add(Type_MvtLabel)
        Me.Controls.Add(AdresseLabel)
        Me.Controls.Add(Code_DossierLabel)
        Me.Controls.Add(Me.Code_DossierTextBox)
        Me.Controls.Add(Code_serviceLabel)
        Me.Controls.Add(Date_DepotLabel)
        Me.Controls.Add(Me.Date_DepotDateTimePicker)
        Me.Controls.Add(Etat_dossLabel)
        Me.Controls.Add(Me.Etat_dossTextBox)
        Me.Controls.Add(ExerciceLabel)
        Me.Controls.Add(Num_OrdreLabel)
        Me.Controls.Add(Me.Num_OrdreTextBox)
        Me.Controls.Add(ReferenceLabel)
        Me.Controls.Add(Me.ReferenceTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Maj_Dossier"
        Me.Text = "Maj_Dossier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TypeMouvementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DossierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmplacementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents t_code As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Code_DossierTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_DepotDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etat_dossTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_OrdreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_mouv As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Date_entreeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MatriculeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TypeMouvementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents exercicetextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Li_obg As System.Windows.Forms.ListBox
    Friend WithEvents B_scan As System.Windows.Forms.Button
    Friend WithEvents L_introuv As System.Windows.Forms.Label
    Friend WithEvents comb_adress As System.Windows.Forms.ComboBox
    Friend WithEvents EmplacementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents combo_servic As System.Windows.Forms.ComboBox
    Friend WithEvents ServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DossierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents get_file As System.Windows.Forms.Button
End Class
