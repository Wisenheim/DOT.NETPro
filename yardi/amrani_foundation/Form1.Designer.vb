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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaisirDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsArticleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsPersonellesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonnelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpressionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonnelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESTARTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHUTDOWNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaisirDetailsToolStripMenuItem, Me.ArticlesToolStripMenuItem, Me.PersonnelToolStripMenuItem, Me.ListesDetailsToolStripMenuItem, Me.CategoriesToolStripMenuItem, Me.ImpressionsToolStripMenuItem, Me.DeconnexionToolStripMenuItem, Me.QuitterApplicationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(996, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaisirDetailsToolStripMenuItem
        '
        Me.SaisirDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SaisirDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsArticleToolStripMenuItem, Me.DetailsPersonellesToolStripMenuItem})
        Me.SaisirDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SaisirDetailsToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1369149826_user_home
        Me.SaisirDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaisirDetailsToolStripMenuItem.Name = "SaisirDetailsToolStripMenuItem"
        Me.SaisirDetailsToolStripMenuItem.Size = New System.Drawing.Size(111, 52)
        Me.SaisirDetailsToolStripMenuItem.Tag = "Saisir des Details"
        Me.SaisirDetailsToolStripMenuItem.Text = "Saisir Details"
        '
        'DetailsArticleToolStripMenuItem
        '
        Me.DetailsArticleToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise
        Me.DetailsArticleToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1375637457_lists1
        Me.DetailsArticleToolStripMenuItem.Name = "DetailsArticleToolStripMenuItem"
        Me.DetailsArticleToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DetailsArticleToolStripMenuItem.Text = "Details Article"
        '
        'DetailsPersonellesToolStripMenuItem
        '
        Me.DetailsPersonellesToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine
        Me.DetailsPersonellesToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1368127483_administrator2
        Me.DetailsPersonellesToolStripMenuItem.Name = "DetailsPersonellesToolStripMenuItem"
        Me.DetailsPersonellesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DetailsPersonellesToolStripMenuItem.Text = "Details Personelles"
        '
        'ArticlesToolStripMenuItem
        '
        Me.ArticlesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ArticlesToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1368042487_file_add
        Me.ArticlesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ArticlesToolStripMenuItem.Name = "ArticlesToolStripMenuItem"
        Me.ArticlesToolStripMenuItem.Size = New System.Drawing.Size(86, 52)
        Me.ArticlesToolStripMenuItem.Tag = "Mise a jours des Articles "
        Me.ArticlesToolStripMenuItem.Text = "Articles"
        '
        'PersonnelToolStripMenuItem
        '
        Me.PersonnelToolStripMenuItem.AccessibleDescription = ""
        Me.PersonnelToolStripMenuItem.AccessibleName = ""
        Me.PersonnelToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PersonnelToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1368127483_administrator
        Me.PersonnelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PersonnelToolStripMenuItem.Name = "PersonnelToolStripMenuItem"
        Me.PersonnelToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.PersonnelToolStripMenuItem.Size = New System.Drawing.Size(114, 52)
        Me.PersonnelToolStripMenuItem.Tag = ""
        Me.PersonnelToolStripMenuItem.Text = "Personnel"
        '
        'ListesDetailsToolStripMenuItem
        '
        Me.ListesDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ListesDetailsToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1375637457_lists
        Me.ListesDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ListesDetailsToolStripMenuItem.Name = "ListesDetailsToolStripMenuItem"
        Me.ListesDetailsToolStripMenuItem.Size = New System.Drawing.Size(132, 52)
        Me.ListesDetailsToolStripMenuItem.Text = "Listes Details "
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.CategoriesToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1375648247_catalog
        Me.CategoriesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(119, 52)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'ImpressionsToolStripMenuItem
        '
        Me.ImpressionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ImpressionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonnelToolStripMenuItem1, Me.DetailsToolStripMenuItem})
        Me.ImpressionsToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1376542362_Print
        Me.ImpressionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImpressionsToolStripMenuItem.Name = "ImpressionsToolStripMenuItem"
        Me.ImpressionsToolStripMenuItem.Size = New System.Drawing.Size(108, 52)
        Me.ImpressionsToolStripMenuItem.Text = "Impressions"
        '
        'PersonnelToolStripMenuItem1
        '
        Me.PersonnelToolStripMenuItem1.Name = "PersonnelToolStripMenuItem1"
        Me.PersonnelToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.PersonnelToolStripMenuItem1.Text = "Personnel"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'DeconnexionToolStripMenuItem
        '
        Me.DeconnexionToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DeconnexionToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1370412747_shutdown
        Me.DeconnexionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeconnexionToolStripMenuItem.Name = "DeconnexionToolStripMenuItem"
        Me.DeconnexionToolStripMenuItem.Size = New System.Drawing.Size(113, 52)
        Me.DeconnexionToolStripMenuItem.Text = "Deconnexion"
        '
        'QuitterApplicationToolStripMenuItem
        '
        Me.QuitterApplicationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.QuitterApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RESTARTToolStripMenuItem, Me.SHUTDOWNToolStripMenuItem})
        Me.QuitterApplicationToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1376542606_system_log_out
        Me.QuitterApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitterApplicationToolStripMenuItem.Name = "QuitterApplicationToolStripMenuItem"
        Me.QuitterApplicationToolStripMenuItem.Size = New System.Drawing.Size(156, 52)
        Me.QuitterApplicationToolStripMenuItem.Text = "Quitter Application"
        '
        'RESTARTToolStripMenuItem
        '
        Me.RESTARTToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RESTARTToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESTARTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RESTARTToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1367007187_001_39
        Me.RESTARTToolStripMenuItem.Name = "RESTARTToolStripMenuItem"
        Me.RESTARTToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RESTARTToolStripMenuItem.Text = "RESTART"
        '
        'SHUTDOWNToolStripMenuItem
        '
        Me.SHUTDOWNToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SHUTDOWNToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHUTDOWNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SHUTDOWNToolStripMenuItem.Image = Global.amrani_foundation.My.Resources.Resources._1368022637_power_off
        Me.SHUTDOWNToolStripMenuItem.Name = "SHUTDOWNToolStripMenuItem"
        Me.SHUTDOWNToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SHUTDOWNToolStripMenuItem.Text = "SHUTDOWN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "--M--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "--2--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCoral
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(543, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "--A--"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LimeGreen
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(849, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "--M--"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(261, 429)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(354, 23)
        Me.ProgressBar1.TabIndex = 5
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.amrani_foundation.My.Resources.Resources._04_08_2013_11_43_33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(996, 476)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU PRINCIPALE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaisirDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticlesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonnelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpressionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RESTARTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SHUTDOWNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonnelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsArticleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsPersonellesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
