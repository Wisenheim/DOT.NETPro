<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maj_salle
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
        Dim CapaciteLabel As System.Windows.Forms.Label
        Dim Code_SalleLabel As System.Windows.Forms.Label
        Dim Lib_salleLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.L_introuv = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.T_codesall = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CapaciteTextBox = New System.Windows.Forms.TextBox()
        Me.Code_SalleTextBox = New System.Windows.Forms.TextBox()
        Me.Lib_salleTextBox = New System.Windows.Forms.TextBox()
        Me.B_del = New System.Windows.Forms.Button()
        Me.b_mod = New System.Windows.Forms.Button()
        Me.B_add = New System.Windows.Forms.Button()
        Me.B_new = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CapaciteLabel = New System.Windows.Forms.Label()
        Code_SalleLabel = New System.Windows.Forms.Label()
        Lib_salleLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CapaciteLabel
        '
        CapaciteLabel.AutoSize = True
        CapaciteLabel.Location = New System.Drawing.Point(30, 111)
        CapaciteLabel.Name = "CapaciteLabel"
        CapaciteLabel.Size = New System.Drawing.Size(52, 13)
        CapaciteLabel.TabIndex = 3
        CapaciteLabel.Text = "Capacite:"
        '
        'Code_SalleLabel
        '
        Code_SalleLabel.AutoSize = True
        Code_SalleLabel.Location = New System.Drawing.Point(30, 137)
        Code_SalleLabel.Name = "Code_SalleLabel"
        Code_SalleLabel.Size = New System.Drawing.Size(61, 13)
        Code_SalleLabel.TabIndex = 5
        Code_SalleLabel.Text = "Code Salle:"
        '
        'Lib_salleLabel
        '
        Lib_salleLabel.AutoSize = True
        Lib_salleLabel.Location = New System.Drawing.Point(30, 163)
        Lib_salleLabel.Name = "Lib_salleLabel"
        Lib_salleLabel.Size = New System.Drawing.Size(48, 13)
        Lib_salleLabel.TabIndex = 7
        Lib_salleLabel.Text = "Lib salle:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.L_introuv)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.T_codesall)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 64)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher une Salle"
        '
        'L_introuv
        '
        Me.L_introuv.AutoSize = True
        Me.L_introuv.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_introuv.ForeColor = System.Drawing.Color.Red
        Me.L_introuv.Location = New System.Drawing.Point(116, 43)
        Me.L_introuv.Name = "L_introuv"
        Me.L_introuv.Size = New System.Drawing.Size(97, 16)
        Me.L_introuv.TabIndex = 24
        Me.L_introuv.Text = "Salle introuvable"
        Me.L_introuv.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 45)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nouvelle recherche"
        Me.LinkLabel1.Visible = False
        '
        'T_codesall
        '
        Me.T_codesall.Location = New System.Drawing.Point(119, 17)
        Me.T_codesall.Name = "T_codesall"
        Me.T_codesall.Size = New System.Drawing.Size(95, 20)
        Me.T_codesall.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrer le code Salle :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CapaciteTextBox
        '
        Me.CapaciteTextBox.Location = New System.Drawing.Point(97, 108)
        Me.CapaciteTextBox.Name = "CapaciteTextBox"
        Me.CapaciteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CapaciteTextBox.TabIndex = 4
        '
        'Code_SalleTextBox
        '
        Me.Code_SalleTextBox.Location = New System.Drawing.Point(97, 134)
        Me.Code_SalleTextBox.Name = "Code_SalleTextBox"
        Me.Code_SalleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Code_SalleTextBox.TabIndex = 6
        '
        'Lib_salleTextBox
        '
        Me.Lib_salleTextBox.Location = New System.Drawing.Point(97, 160)
        Me.Lib_salleTextBox.Name = "Lib_salleTextBox"
        Me.Lib_salleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Lib_salleTextBox.TabIndex = 8
        '
        'B_del
        '
        Me.B_del.Enabled = False
        Me.B_del.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369232217_DeleteRed
        Me.B_del.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_del.Location = New System.Drawing.Point(163, 240)
        Me.B_del.Name = "B_del"
        Me.B_del.Size = New System.Drawing.Size(83, 33)
        Me.B_del.TabIndex = 12
        Me.B_del.Text = "Supprimer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.B_del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_del.UseVisualStyleBackColor = True
        '
        'b_mod
        '
        Me.b_mod.Enabled = False
        Me.b_mod.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369232230_Modify
        Me.b_mod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_mod.Location = New System.Drawing.Point(82, 240)
        Me.b_mod.Name = "b_mod"
        Me.b_mod.Size = New System.Drawing.Size(75, 33)
        Me.b_mod.TabIndex = 11
        Me.b_mod.Text = "Modifier"
        Me.b_mod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_mod.UseVisualStyleBackColor = True
        '
        'B_add
        '
        Me.B_add.Enabled = False
        Me.B_add.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369232184_netvibes
        Me.B_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_add.Location = New System.Drawing.Point(123, 201)
        Me.B_add.Name = "B_add"
        Me.B_add.Size = New System.Drawing.Size(75, 33)
        Me.B_add.TabIndex = 10
        Me.B_add.Text = "Ajouter"
        Me.B_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_add.UseVisualStyleBackColor = True
        '
        'B_new
        '
        Me.B_new.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369232529_new_24
        Me.B_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_new.Location = New System.Drawing.Point(33, 201)
        Me.B_new.Name = "B_new"
        Me.B_new.Size = New System.Drawing.Size(84, 33)
        Me.B_new.TabIndex = 9
        Me.B_new.Text = "Nouveau"
        Me.B_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_new.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1369230878_document_preview_archive1
        Me.PictureBox1.Location = New System.Drawing.Point(277, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'maj_salle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 277)
        Me.Controls.Add(Me.B_del)
        Me.Controls.Add(Me.b_mod)
        Me.Controls.Add(Me.B_add)
        Me.Controls.Add(Me.B_new)
        Me.Controls.Add(CapaciteLabel)
        Me.Controls.Add(Me.CapaciteTextBox)
        Me.Controls.Add(Code_SalleLabel)
        Me.Controls.Add(Me.Code_SalleTextBox)
        Me.Controls.Add(Lib_salleLabel)
        Me.Controls.Add(Me.Lib_salleTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "maj_salle"
        Me.Text = "Mise a jour salle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T_codesall As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CapaciteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Code_SalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lib_salleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents B_new As System.Windows.Forms.Button
    Friend WithEvents B_add As System.Windows.Forms.Button
    Friend WithEvents b_mod As System.Windows.Forms.Button
    Friend WithEvents B_del As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents L_introuv As System.Windows.Forms.Label
End Class
