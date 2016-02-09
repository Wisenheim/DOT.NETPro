<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulter_dos
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
        Dim Label1 As System.Windows.Forms.Label
        Dim AdresseLabel As System.Windows.Forms.Label
        Dim Code_DossierLabel As System.Windows.Forms.Label
        Dim Code_serviceLabel As System.Windows.Forms.Label
        Dim Date_DepotLabel As System.Windows.Forms.Label
        Dim Etat_dossLabel As System.Windows.Forms.Label
        Dim ExerciceLabel As System.Windows.Forms.Label
        Dim Num_OrdreLabel As System.Windows.Forms.Label
        Dim ReferenceLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.L_notfound = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_code = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.B_quit = New System.Windows.Forms.Button()
        Me.L_adress = New System.Windows.Forms.Label()
        Me.L_Codedos = New System.Windows.Forms.Label()
        Me.L_Codeserv = New System.Windows.Forms.Label()
        Me.L_dat = New System.Windows.Forms.Label()
        Me.L_etat_dos = New System.Windows.Forms.Label()
        Me.L_exer = New System.Windows.Forms.Label()
        Me.L_numordr = New System.Windows.Forms.Label()
        Me.L_ref = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        AdresseLabel = New System.Windows.Forms.Label()
        Code_DossierLabel = New System.Windows.Forms.Label()
        Code_serviceLabel = New System.Windows.Forms.Label()
        Date_DepotLabel = New System.Windows.Forms.Label()
        Etat_dossLabel = New System.Windows.Forms.Label()
        ExerciceLabel = New System.Windows.Forms.Label()
        Num_OrdreLabel = New System.Windows.Forms.Label()
        ReferenceLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(69, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(88, 12)
        Label1.TabIndex = 20
        Label1.Text = "Code_Dossier :"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdresseLabel.Location = New System.Drawing.Point(24, 114)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(97, 16)
        AdresseLabel.TabIndex = 80
        AdresseLabel.Text = "Emplacement  :"
        '
        'Code_DossierLabel
        '
        Code_DossierLabel.AutoSize = True
        Code_DossierLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_DossierLabel.Location = New System.Drawing.Point(24, 143)
        Code_DossierLabel.Name = "Code_DossierLabel"
        Code_DossierLabel.Size = New System.Drawing.Size(88, 16)
        Code_DossierLabel.TabIndex = 82
        Code_DossierLabel.Text = "Code Dossier:"
        '
        'Code_serviceLabel
        '
        Code_serviceLabel.AutoSize = True
        Code_serviceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_serviceLabel.Location = New System.Drawing.Point(24, 173)
        Code_serviceLabel.Name = "Code_serviceLabel"
        Code_serviceLabel.Size = New System.Drawing.Size(85, 16)
        Code_serviceLabel.TabIndex = 84
        Code_serviceLabel.Text = "code service:"
        '
        'Date_DepotLabel
        '
        Date_DepotLabel.AutoSize = True
        Date_DepotLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_DepotLabel.Location = New System.Drawing.Point(24, 204)
        Date_DepotLabel.Name = "Date_DepotLabel"
        Date_DepotLabel.Size = New System.Drawing.Size(81, 16)
        Date_DepotLabel.TabIndex = 86
        Date_DepotLabel.Text = "Date Depot:"
        '
        'Etat_dossLabel
        '
        Etat_dossLabel.AutoSize = True
        Etat_dossLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Etat_dossLabel.Location = New System.Drawing.Point(24, 232)
        Etat_dossLabel.Name = "Etat_dossLabel"
        Etat_dossLabel.Size = New System.Drawing.Size(69, 16)
        Etat_dossLabel.TabIndex = 88
        Etat_dossLabel.Text = "etat doss:"
        '
        'ExerciceLabel
        '
        ExerciceLabel.AutoSize = True
        ExerciceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExerciceLabel.Location = New System.Drawing.Point(24, 261)
        ExerciceLabel.Name = "ExerciceLabel"
        ExerciceLabel.Size = New System.Drawing.Size(62, 16)
        ExerciceLabel.TabIndex = 90
        ExerciceLabel.Text = "exercice:"
        '
        'Num_OrdreLabel
        '
        Num_OrdreLabel.AutoSize = True
        Num_OrdreLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_OrdreLabel.Location = New System.Drawing.Point(24, 291)
        Num_OrdreLabel.Name = "Num_OrdreLabel"
        Num_OrdreLabel.Size = New System.Drawing.Size(79, 16)
        Num_OrdreLabel.TabIndex = 92
        Num_OrdreLabel.Text = "Num Ordre:"
        '
        'ReferenceLabel
        '
        ReferenceLabel.AutoSize = True
        ReferenceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReferenceLabel.Location = New System.Drawing.Point(24, 320)
        ReferenceLabel.Name = "ReferenceLabel"
        ReferenceLabel.Size = New System.Drawing.Size(73, 16)
        ReferenceLabel.TabIndex = 94
        ReferenceLabel.Text = "Reference:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Label3.Location = New System.Drawing.Point(363, 207)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(181, 16)
        Label3.TabIndex = 98
        Label3.Text = "Liste des objets de Dossier :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.L_notfound)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.t_code)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(304, 78)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher un Dossier"
        '
        'L_notfound
        '
        Me.L_notfound.AutoSize = True
        Me.L_notfound.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_notfound.ForeColor = System.Drawing.Color.Red
        Me.L_notfound.Location = New System.Drawing.Point(165, 54)
        Me.L_notfound.Name = "L_notfound"
        Me.L_notfound.Size = New System.Drawing.Size(122, 15)
        Me.L_notfound.TabIndex = 23
        Me.L_notfound.Text = "Dossier Introuvable !!"
        Me.L_notfound.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(27, 62)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(129, 12)
        Me.LinkLabel3.TabIndex = 22
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Nouvelle Recherche !!"
        Me.LinkLabel3.Visible = False
        '
        'Label2
        '
        Me.Label2.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368042624_file_search
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 44)
        Me.Label2.TabIndex = 21
        '
        't_code
        '
        Me.t_code.Location = New System.Drawing.Point(168, 30)
        Me.t_code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_code.Name = "t_code"
        Me.t_code.Size = New System.Drawing.Size(120, 20)
        Me.t_code.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369000261_folder
        Me.PictureBox1.Location = New System.Drawing.Point(366, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'B_quit
        '
        Me.B_quit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.B_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_quit.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_quit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B_quit.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369232217_DeleteRed
        Me.B_quit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_quit.Location = New System.Drawing.Point(5, 353)
        Me.B_quit.Name = "B_quit"
        Me.B_quit.Size = New System.Drawing.Size(89, 35)
        Me.B_quit.TabIndex = 96
        Me.B_quit.Text = "Quitter"
        Me.B_quit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_quit.UseVisualStyleBackColor = False
        '
        'L_adress
        '
        Me.L_adress.AutoSize = True
        Me.L_adress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_adress.Location = New System.Drawing.Point(143, 114)
        Me.L_adress.Name = "L_adress"
        Me.L_adress.Size = New System.Drawing.Size(153, 12)
        Me.L_adress.TabIndex = 99
        Me.L_adress.Text = "-------------------------------------"
        '
        'L_Codedos
        '
        Me.L_Codedos.AutoSize = True
        Me.L_Codedos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Codedos.Location = New System.Drawing.Point(143, 145)
        Me.L_Codedos.Name = "L_Codedos"
        Me.L_Codedos.Size = New System.Drawing.Size(153, 12)
        Me.L_Codedos.TabIndex = 100
        Me.L_Codedos.Text = "-------------------------------------"
        '
        'L_Codeserv
        '
        Me.L_Codeserv.AutoSize = True
        Me.L_Codeserv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Codeserv.Location = New System.Drawing.Point(143, 174)
        Me.L_Codeserv.Name = "L_Codeserv"
        Me.L_Codeserv.Size = New System.Drawing.Size(153, 12)
        Me.L_Codeserv.TabIndex = 101
        Me.L_Codeserv.Text = "-------------------------------------"
        '
        'L_dat
        '
        Me.L_dat.AutoSize = True
        Me.L_dat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_dat.Location = New System.Drawing.Point(143, 207)
        Me.L_dat.Name = "L_dat"
        Me.L_dat.Size = New System.Drawing.Size(153, 12)
        Me.L_dat.TabIndex = 102
        Me.L_dat.Text = "-------------------------------------"
        '
        'L_etat_dos
        '
        Me.L_etat_dos.AutoSize = True
        Me.L_etat_dos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_etat_dos.Location = New System.Drawing.Point(143, 234)
        Me.L_etat_dos.Name = "L_etat_dos"
        Me.L_etat_dos.Size = New System.Drawing.Size(153, 12)
        Me.L_etat_dos.TabIndex = 103
        Me.L_etat_dos.Text = "-------------------------------------"
        '
        'L_exer
        '
        Me.L_exer.AutoSize = True
        Me.L_exer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_exer.Location = New System.Drawing.Point(143, 264)
        Me.L_exer.Name = "L_exer"
        Me.L_exer.Size = New System.Drawing.Size(153, 12)
        Me.L_exer.TabIndex = 104
        Me.L_exer.Text = "-------------------------------------"
        '
        'L_numordr
        '
        Me.L_numordr.AutoSize = True
        Me.L_numordr.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_numordr.Location = New System.Drawing.Point(143, 293)
        Me.L_numordr.Name = "L_numordr"
        Me.L_numordr.Size = New System.Drawing.Size(153, 12)
        Me.L_numordr.TabIndex = 105
        Me.L_numordr.Text = "-------------------------------------"
        '
        'L_ref
        '
        Me.L_ref.AutoSize = True
        Me.L_ref.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ref.Location = New System.Drawing.Point(143, 322)
        Me.L_ref.Name = "L_ref"
        Me.L_ref.Size = New System.Drawing.Size(153, 12)
        Me.L_ref.TabIndex = 106
        Me.L_ref.Text = "-------------------------------------"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(366, 248)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(236, 136)
        Me.ListBox1.TabIndex = 107
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Ouvrir un Fichier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Consulter_dos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 391)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.L_ref)
        Me.Controls.Add(Me.L_numordr)
        Me.Controls.Add(Me.L_exer)
        Me.Controls.Add(Me.L_etat_dos)
        Me.Controls.Add(Me.L_dat)
        Me.Controls.Add(Me.L_Codeserv)
        Me.Controls.Add(Me.L_Codedos)
        Me.Controls.Add(Me.L_adress)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.B_quit)
        Me.Controls.Add(AdresseLabel)
        Me.Controls.Add(Code_DossierLabel)
        Me.Controls.Add(Code_serviceLabel)
        Me.Controls.Add(Date_DepotLabel)
        Me.Controls.Add(Etat_dossLabel)
        Me.Controls.Add(ExerciceLabel)
        Me.Controls.Add(Num_OrdreLabel)
        Me.Controls.Add(ReferenceLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Consulter_dos"
        Me.Text = "Consulter_dos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t_code As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents B_quit As System.Windows.Forms.Button
    Friend WithEvents L_adress As System.Windows.Forms.Label
    Friend WithEvents L_Codedos As System.Windows.Forms.Label
    Friend WithEvents L_Codeserv As System.Windows.Forms.Label
    Friend WithEvents L_dat As System.Windows.Forms.Label
    Friend WithEvents L_etat_dos As System.Windows.Forms.Label
    Friend WithEvents L_exer As System.Windows.Forms.Label
    Friend WithEvents L_numordr As System.Windows.Forms.Label
    Friend WithEvents L_ref As System.Windows.Forms.Label
    Friend WithEvents L_notfound As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
