<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PERSONELLES
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
        Dim ADRESSELabel As System.Windows.Forms.Label
        Dim CINLabel As System.Windows.Forms.Label
        Dim ID_CATEGLabel As System.Windows.Forms.Label
        Dim MODE_PAYLabel As System.Windows.Forms.Label
        Dim NOMLabel As System.Windows.Forms.Label
        Dim PRENOMLabel As System.Windows.Forms.Label
        Dim SALAIRELabel As System.Windows.Forms.Label
        Dim TELEPHONELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.ADRESSETextBox = New System.Windows.Forms.TextBox()
        Me.CINTextBox = New System.Windows.Forms.TextBox()
        Me.NOMTextBox = New System.Windows.Forms.TextBox()
        Me.PRENOMTextBox = New System.Windows.Forms.TextBox()
        Me.SALAIRETextBox = New System.Windows.Forms.TextBox()
        Me.TELEPHONETextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.PERSONNELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CATEGORIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        ADRESSELabel = New System.Windows.Forms.Label()
        CINLabel = New System.Windows.Forms.Label()
        ID_CATEGLabel = New System.Windows.Forms.Label()
        MODE_PAYLabel = New System.Windows.Forms.Label()
        NOMLabel = New System.Windows.Forms.Label()
        PRENOMLabel = New System.Windows.Forms.Label()
        SALAIRELabel = New System.Windows.Forms.Label()
        TELEPHONELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ADRESSELabel
        '
        ADRESSELabel.AutoSize = True
        ADRESSELabel.BackColor = System.Drawing.Color.Transparent
        ADRESSELabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ADRESSELabel.ForeColor = System.Drawing.SystemColors.ControlText
        ADRESSELabel.Location = New System.Drawing.Point(30, 199)
        ADRESSELabel.Name = "ADRESSELabel"
        ADRESSELabel.Size = New System.Drawing.Size(76, 16)
        ADRESSELabel.TabIndex = 1
        ADRESSELabel.Text = "ADRESSE  :"
        '
        'CINLabel
        '
        CINLabel.AutoSize = True
        CINLabel.BackColor = System.Drawing.Color.Transparent
        CINLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CINLabel.ForeColor = System.Drawing.SystemColors.ControlText
        CINLabel.Location = New System.Drawing.Point(30, 121)
        CINLabel.Name = "CINLabel"
        CINLabel.Size = New System.Drawing.Size(45, 16)
        CINLabel.TabIndex = 3
        CINLabel.Text = "CIN  :"
        '
        'ID_CATEGLabel
        '
        ID_CATEGLabel.AutoSize = True
        ID_CATEGLabel.BackColor = System.Drawing.Color.Transparent
        ID_CATEGLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_CATEGLabel.ForeColor = System.Drawing.SystemColors.ControlText
        ID_CATEGLabel.Location = New System.Drawing.Point(30, 251)
        ID_CATEGLabel.Name = "ID_CATEGLabel"
        ID_CATEGLabel.Size = New System.Drawing.Size(89, 16)
        ID_CATEGLabel.TabIndex = 5
        ID_CATEGLabel.Text = "CATEGORIE  :"
        '
        'MODE_PAYLabel
        '
        MODE_PAYLabel.AutoSize = True
        MODE_PAYLabel.BackColor = System.Drawing.Color.Transparent
        MODE_PAYLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MODE_PAYLabel.ForeColor = System.Drawing.SystemColors.ControlText
        MODE_PAYLabel.Location = New System.Drawing.Point(30, 277)
        MODE_PAYLabel.Name = "MODE_PAYLabel"
        MODE_PAYLabel.Size = New System.Drawing.Size(84, 16)
        MODE_PAYLabel.TabIndex = 7
        MODE_PAYLabel.Text = "MODE PAY  :"
        '
        'NOMLabel
        '
        NOMLabel.AutoSize = True
        NOMLabel.BackColor = System.Drawing.Color.Transparent
        NOMLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMLabel.ForeColor = System.Drawing.SystemColors.ControlText
        NOMLabel.Location = New System.Drawing.Point(30, 147)
        NOMLabel.Name = "NOMLabel"
        NOMLabel.Size = New System.Drawing.Size(52, 16)
        NOMLabel.TabIndex = 9
        NOMLabel.Text = "NOM  :"
        '
        'PRENOMLabel
        '
        PRENOMLabel.AutoSize = True
        PRENOMLabel.BackColor = System.Drawing.Color.Transparent
        PRENOMLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRENOMLabel.ForeColor = System.Drawing.SystemColors.ControlText
        PRENOMLabel.Location = New System.Drawing.Point(30, 173)
        PRENOMLabel.Name = "PRENOMLabel"
        PRENOMLabel.Size = New System.Drawing.Size(77, 16)
        PRENOMLabel.TabIndex = 11
        PRENOMLabel.Text = "PRENOM   :"
        '
        'SALAIRELabel
        '
        SALAIRELabel.AutoSize = True
        SALAIRELabel.BackColor = System.Drawing.Color.Transparent
        SALAIRELabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SALAIRELabel.ForeColor = System.Drawing.SystemColors.ControlText
        SALAIRELabel.Location = New System.Drawing.Point(30, 303)
        SALAIRELabel.Name = "SALAIRELabel"
        SALAIRELabel.Size = New System.Drawing.Size(78, 16)
        SALAIRELabel.TabIndex = 13
        SALAIRELabel.Text = "SALAIRE   :"
        '
        'TELEPHONELabel
        '
        TELEPHONELabel.AutoSize = True
        TELEPHONELabel.BackColor = System.Drawing.Color.Transparent
        TELEPHONELabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TELEPHONELabel.ForeColor = System.Drawing.SystemColors.ControlText
        TELEPHONELabel.Location = New System.Drawing.Point(30, 225)
        TELEPHONELabel.Name = "TELEPHONELabel"
        TELEPHONELabel.Size = New System.Drawing.Size(90, 16)
        TELEPHONELabel.TabIndex = 15
        TELEPHONELabel.Text = "TELEPHONE  :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Gainsboro
        Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(15, 29)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 16)
        Label1.TabIndex = 66
        Label1.Text = "Personnel :"
        '
        'ADRESSETextBox
        '
        Me.ADRESSETextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADRESSETextBox.Location = New System.Drawing.Point(125, 196)
        Me.ADRESSETextBox.Name = "ADRESSETextBox"
        Me.ADRESSETextBox.Size = New System.Drawing.Size(197, 23)
        Me.ADRESSETextBox.TabIndex = 2
        '
        'CINTextBox
        '
        Me.CINTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CINTextBox.Location = New System.Drawing.Point(125, 118)
        Me.CINTextBox.Name = "CINTextBox"
        Me.CINTextBox.Size = New System.Drawing.Size(197, 23)
        Me.CINTextBox.TabIndex = 4
        '
        'NOMTextBox
        '
        Me.NOMTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMTextBox.Location = New System.Drawing.Point(125, 144)
        Me.NOMTextBox.Name = "NOMTextBox"
        Me.NOMTextBox.Size = New System.Drawing.Size(197, 23)
        Me.NOMTextBox.TabIndex = 10
        '
        'PRENOMTextBox
        '
        Me.PRENOMTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRENOMTextBox.Location = New System.Drawing.Point(125, 170)
        Me.PRENOMTextBox.Name = "PRENOMTextBox"
        Me.PRENOMTextBox.Size = New System.Drawing.Size(197, 23)
        Me.PRENOMTextBox.TabIndex = 12
        '
        'SALAIRETextBox
        '
        Me.SALAIRETextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALAIRETextBox.Location = New System.Drawing.Point(125, 300)
        Me.SALAIRETextBox.Name = "SALAIRETextBox"
        Me.SALAIRETextBox.Size = New System.Drawing.Size(197, 23)
        Me.SALAIRETextBox.TabIndex = 14
        '
        'TELEPHONETextBox
        '
        Me.TELEPHONETextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TELEPHONETextBox.Location = New System.Drawing.Point(125, 222)
        Me.TELEPHONETextBox.Name = "TELEPHONETextBox"
        Me.TELEPHONETextBox.Size = New System.Drawing.Size(197, 23)
        Me.TELEPHONETextBox.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.ComboBox2.Location = New System.Drawing.Point(125, 274)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox2.TabIndex = 18
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(139, 79)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 16)
        Me.LinkLabel1.TabIndex = 75
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nouvelle Recherche !!!!"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 64)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche Personnelles :"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox3.DataSource = Me.PERSONNELBindingSource
        Me.ComboBox3.DisplayMember = "CIN"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(120, 29)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(169, 24)
        Me.ComboBox3.TabIndex = 67
        Me.ComboBox3.ValueMember = "CIN"
        '
        'PERSONNELBindingSource
        '
        Me.PERSONNELBindingSource.DataSource = GetType(amrani_foundation.PERSONNEL)
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.amrani_foundation.My.Resources.Resources._1368111692_Remove_Male_User
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(279, 370)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 37)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "Supprimer"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.amrani_foundation.My.Resources.Resources._1369232230_Modify
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(187, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 37)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Modifier"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.amrani_foundation.My.Resources.Resources._1368041759_new
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(-2, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 37)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Nouveau"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.amrani_foundation.My.Resources.Resources._1368041173_user_group_new
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(94, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 37)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Ajouter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(91, 421)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(217, 15)
        Me.LinkLabel2.TabIndex = 80
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Afficher tous les Personnelles !!!!"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.Black
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Silver
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.Black
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.Location = New System.Drawing.Point(394, 62)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid1.Size = New System.Drawing.Size(564, 315)
        Me.DataGrid1.TabIndex = 81
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(422, 391)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(139, 16)
        Me.LinkLabel3.TabIndex = 82
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Nouvelle Recherche !!!!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(559, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 23)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Tous les Personnelles :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERSONNELBindingSource, "ID_CATEG", True))
        Me.ComboBox1.DataSource = Me.CATEGORIEBindingSource
        Me.ComboBox1.DisplayMember = "LIB_CATEG"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(125, 248)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox1.TabIndex = 84
        Me.ComboBox1.ValueMember = "ID_CAT"
        '
        'CATEGORIEBindingSource
        '
        Me.CATEGORIEBindingSource.DataSource = GetType(amrani_foundation.CATEGORIE)
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(125, 329)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 23)
        Me.TextBox1.TabIndex = 86
        Me.TextBox1.Visible = False
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel4.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel4.Location = New System.Drawing.Point(23, 334)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(101, 16)
        Me.LinkLabel4.TabIndex = 87
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "CODE CHEQUE :"
        Me.LinkLabel4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(706, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "TOTAL :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(804, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 19)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "------------------"
        '
        'PERSONELLES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 442)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(ADRESSELabel)
        Me.Controls.Add(Me.ADRESSETextBox)
        Me.Controls.Add(CINLabel)
        Me.Controls.Add(Me.CINTextBox)
        Me.Controls.Add(ID_CATEGLabel)
        Me.Controls.Add(MODE_PAYLabel)
        Me.Controls.Add(NOMLabel)
        Me.Controls.Add(Me.NOMTextBox)
        Me.Controls.Add(PRENOMLabel)
        Me.Controls.Add(Me.PRENOMTextBox)
        Me.Controls.Add(SALAIRELabel)
        Me.Controls.Add(Me.SALAIRETextBox)
        Me.Controls.Add(TELEPHONELabel)
        Me.Controls.Add(Me.TELEPHONETextBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PERSONELLES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PERSONELLES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ADRESSETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRENOMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SALAIRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TELEPHONETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PERSONNELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CATEGORIEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
