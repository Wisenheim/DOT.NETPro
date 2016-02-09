<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTwainPicture

    Inherits System.Windows.Forms.Form

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTwainPicture))
        Me.ItemMenu = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.TSS = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.SBLWidth = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBWidth = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBLHeight = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBHeight = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBLResolution = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBResolution = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBLSize = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBSize = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBSep = New System.Windows.Forms.ToolStripStatusLabel
        Me.SBLMode = New System.Windows.Forms.ToolStripDropDownButton
        Me.SBMAuto = New System.Windows.Forms.ToolStripMenuItem
        Me.SBMCenter = New System.Windows.Forms.ToolStripMenuItem
        Me.SBMStretch = New System.Windows.Forms.ToolStripMenuItem
        Me.SBMNormal = New System.Windows.Forms.ToolStripMenuItem
        Me.SBMZoom = New System.Windows.Forms.ToolStripMenuItem
        Me.pScan = New System.Windows.Forms.PictureBox
        Me.ItemMenu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.pScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemMenu
        '
        Me.ItemMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.ItemMenu.Location = New System.Drawing.Point(0, 0)
        Me.ItemMenu.Name = "ItemMenu"
        Me.ItemMenu.Size = New System.Drawing.Size(544, 24)
        Me.ItemMenu.TabIndex = 0
        Me.ItemMenu.Text = "MenuStrip"
        Me.ItemMenu.Visible = False
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSS, Me.mnuSaveAs, Me.mnuClose})
        Me.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.mnuFile.MergeIndex = 0
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(54, 20)
        Me.mnuFile.Text = "&Fichier"
        '
        'TSS
        '
        Me.TSS.Name = "TSS"
        Me.TSS.Size = New System.Drawing.Size(154, 6)
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(157, 22)
        Me.mnuSaveAs.Text = "&Enregistrer sous"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(157, 22)
        Me.mnuClose.Text = "&Fermer"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SBLWidth, Me.SBWidth, Me.SBLHeight, Me.SBHeight, Me.SBLResolution, Me.SBResolution, Me.SBLSize, Me.SBSize, Me.SBSep, Me.SBLMode})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 318)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(544, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'SBLWidth
        '
        Me.SBLWidth.Name = "SBLWidth"
        Me.SBLWidth.Size = New System.Drawing.Size(47, 17)
        Me.SBLWidth.Text = "Largeur"
        '
        'SBWidth
        '
        Me.SBWidth.Name = "SBWidth"
        Me.SBWidth.Size = New System.Drawing.Size(13, 17)
        Me.SBWidth.Text = "0"
        '
        'SBLHeight
        '
        Me.SBLHeight.Name = "SBLHeight"
        Me.SBLHeight.Size = New System.Drawing.Size(50, 17)
        Me.SBLHeight.Text = "Hauteur"
        '
        'SBHeight
        '
        Me.SBHeight.Name = "SBHeight"
        Me.SBHeight.Size = New System.Drawing.Size(13, 17)
        Me.SBHeight.Text = "0"
        '
        'SBLResolution
        '
        Me.SBLResolution.Name = "SBLResolution"
        Me.SBLResolution.Size = New System.Drawing.Size(63, 17)
        Me.SBLResolution.Text = "Résolution"
        '
        'SBResolution
        '
        Me.SBResolution.Name = "SBResolution"
        Me.SBResolution.Size = New System.Drawing.Size(13, 17)
        Me.SBResolution.Text = "0"
        '
        'SBLSize
        '
        Me.SBLSize.Name = "SBLSize"
        Me.SBLSize.Size = New System.Drawing.Size(60, 17)
        Me.SBLSize.Text = "Taille (Ko)"
        '
        'SBSize
        '
        Me.SBSize.Name = "SBSize"
        Me.SBSize.Size = New System.Drawing.Size(13, 17)
        Me.SBSize.Text = "0"
        '
        'SBSep
        '
        Me.SBSep.Name = "SBSep"
        Me.SBSep.Size = New System.Drawing.Size(16, 17)
        Me.SBSep.Text = "   "
        '
        'SBLMode
        '
        Me.SBLMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SBLMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SBMAuto, Me.SBMCenter, Me.SBMStretch, Me.SBMNormal, Me.SBMZoom})
        Me.SBLMode.Image = CType(resources.GetObject("SBLMode.Image"), System.Drawing.Image)
        Me.SBLMode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SBLMode.Name = "SBLMode"
        Me.SBLMode.Size = New System.Drawing.Size(113, 20)
        Me.SBLMode.Text = "Mode d'affichage"
        '
        'SBMAuto
        '
        Me.SBMAuto.Name = "SBMAuto"
        Me.SBMAuto.Size = New System.Drawing.Size(114, 22)
        Me.SBMAuto.Text = "Auto"
        '
        'SBMCenter
        '
        Me.SBMCenter.Name = "SBMCenter"
        Me.SBMCenter.Size = New System.Drawing.Size(114, 22)
        Me.SBMCenter.Text = "Centré"
        '
        'SBMStretch
        '
        Me.SBMStretch.Name = "SBMStretch"
        Me.SBMStretch.Size = New System.Drawing.Size(114, 22)
        Me.SBMStretch.Text = "Etiré"
        '
        'SBMNormal
        '
        Me.SBMNormal.Name = "SBMNormal"
        Me.SBMNormal.Size = New System.Drawing.Size(114, 22)
        Me.SBMNormal.Text = "Normal"
        '
        'SBMZoom
        '
        Me.SBMZoom.Name = "SBMZoom"
        Me.SBMZoom.Size = New System.Drawing.Size(114, 22)
        Me.SBMZoom.Text = "Zoom"
        '
        'pScan
        '
        Me.pScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pScan.Location = New System.Drawing.Point(0, 0)
        Me.pScan.Name = "pScan"
        Me.pScan.Size = New System.Drawing.Size(544, 318)
        Me.pScan.TabIndex = 2
        Me.pScan.TabStop = False
        '
        'frmTwainPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 340)
        Me.Controls.Add(Me.pScan)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ItemMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ItemMenu
        Me.Menu = Me.Menu
        Me.Name = "frmTwainPicture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Image"
        Me.ItemMenu.ResumeLayout(False)
        Me.ItemMenu.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.pScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ImgMenu As System.Windows.Forms.MainMenu
    Friend WithEvents ItemMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents SBLWidth As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SBWidth As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SBLHeight As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SBHeight As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SBLResolution As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SBResolution As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SBLSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SBSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pScan As System.Windows.Forms.PictureBox
    Friend WithEvents SBLMode As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SBMZoom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SBMNormal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SBMStretch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SBMAuto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SBMCenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SBSep As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSS As System.Windows.Forms.ToolStripSeparator


End Class
