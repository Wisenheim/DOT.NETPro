<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MajdossierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MajCompteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MajservicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MajSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiverUnDossierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiverUnDossierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Link_connect = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MajdossierToolStripMenuItem, Me.ConsultantToolStripMenuItem, Me.ArchiverUnDossierToolStripMenuItem, Me.HistoriqueToolStripMenuItem, Me.QuitterToolStripMenuItem, Me.DeconnexionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(679, 56)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MajdossierToolStripMenuItem
        '
        Me.MajdossierToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.MajdossierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MajCompteToolStripMenuItem1, Me.MajservicesToolStripMenuItem, Me.MajSalesToolStripMenuItem})
        Me.MajdossierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MajdossierToolStripMenuItem.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368127483_administrator
        Me.MajdossierToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MajdossierToolStripMenuItem.Name = "MajdossierToolStripMenuItem"
        Me.MajdossierToolStripMenuItem.Size = New System.Drawing.Size(129, 52)
        Me.MajdossierToolStripMenuItem.Text = "Administrer"
        '
        'MajCompteToolStripMenuItem1
        '
        Me.MajCompteToolStripMenuItem1.Name = "MajCompteToolStripMenuItem1"
        Me.MajCompteToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.MajCompteToolStripMenuItem1.Text = "Mise à jour Compte"
        '
        'MajservicesToolStripMenuItem
        '
        Me.MajservicesToolStripMenuItem.Name = "MajservicesToolStripMenuItem"
        Me.MajservicesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MajservicesToolStripMenuItem.Text = "Mise à jour services"
        '
        'MajSalesToolStripMenuItem
        '
        Me.MajSalesToolStripMenuItem.Name = "MajSalesToolStripMenuItem"
        Me.MajSalesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MajSalesToolStripMenuItem.Text = "Mise à jour Sales"
        '
        'ConsultantToolStripMenuItem
        '
        Me.ConsultantToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.ConsultantToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ConsultantToolStripMenuItem.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368129121_administrator
        Me.ConsultantToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultantToolStripMenuItem.Name = "ConsultantToolStripMenuItem"
        Me.ConsultantToolStripMenuItem.Size = New System.Drawing.Size(118, 52)
        Me.ConsultantToolStripMenuItem.Text = "Consulter"
        '
        'ArchiverUnDossierToolStripMenuItem
        '
        Me.ArchiverUnDossierToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.ArchiverUnDossierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiverUnDossierToolStripMenuItem1, Me.SuiToolStripMenuItem})
        Me.ArchiverUnDossierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ArchiverUnDossierToolStripMenuItem.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1370412451_teacher
        Me.ArchiverUnDossierToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ArchiverUnDossierToolStripMenuItem.Name = "ArchiverUnDossierToolStripMenuItem"
        Me.ArchiverUnDossierToolStripMenuItem.Size = New System.Drawing.Size(111, 52)
        Me.ArchiverUnDossierToolStripMenuItem.Text = "Archiver"
        '
        'ArchiverUnDossierToolStripMenuItem1
        '
        Me.ArchiverUnDossierToolStripMenuItem1.Name = "ArchiverUnDossierToolStripMenuItem1"
        Me.ArchiverUnDossierToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ArchiverUnDossierToolStripMenuItem1.Text = "Archiver un Dossier"
        '
        'SuiToolStripMenuItem
        '
        Me.SuiToolStripMenuItem.Name = "SuiToolStripMenuItem"
        Me.SuiToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SuiToolStripMenuItem.Text = "Suivie d'un dossier"
        '
        'HistoriqueToolStripMenuItem
        '
        Me.HistoriqueToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.HistoriqueToolStripMenuItem.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1370412243_archive_tar_gz
        Me.HistoriqueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HistoriqueToolStripMenuItem.Name = "HistoriqueToolStripMenuItem"
        Me.HistoriqueToolStripMenuItem.Size = New System.Drawing.Size(122, 52)
        Me.HistoriqueToolStripMenuItem.Text = "Historique"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.QuitterToolStripMenuItem.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1370412747_shutdown
        Me.QuitterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(88, 52)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'DeconnexionToolStripMenuItem
        '
        Me.DeconnexionToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.DeconnexionToolStripMenuItem.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368022637_power_off1
        Me.DeconnexionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeconnexionToolStripMenuItem.Name = "DeconnexionToolStripMenuItem"
        Me.DeconnexionToolStripMenuItem.Size = New System.Drawing.Size(104, 52)
        Me.DeconnexionToolStripMenuItem.Text = "Deconnexion"
        '
        'Link_connect
        '
        Me.Link_connect.AutoSize = True
        Me.Link_connect.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link_connect.LinkColor = System.Drawing.Color.Blue
        Me.Link_connect.Location = New System.Drawing.Point(546, 69)
        Me.Link_connect.Name = "Link_connect"
        Me.Link_connect.Size = New System.Drawing.Size(73, 19)
        Me.Link_connect.TabIndex = 3
        Me.Link_connect.TabStop = True
        Me.Link_connect.Text = "--------"
        Me.Link_connect.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 478)
        Me.Controls.Add(Me.Link_connect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MajdossierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MajCompteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchiverUnDossierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MajservicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MajSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchiverUnDossierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoriqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Link_connect As System.Windows.Forms.LinkLabel
    Friend WithEvents DeconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
