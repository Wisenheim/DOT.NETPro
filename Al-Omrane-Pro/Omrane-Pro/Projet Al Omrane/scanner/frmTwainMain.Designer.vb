<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTwainMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTwainMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainSelectSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainCloseAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuList, Me.mnuAbout})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.mnuList
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainSelectSource, Me.mnuMainScan})
        Me.mnuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(53, 20)
        Me.mnuFile.Text = "&Fichier"
        '
        'mnuMainSelectSource
        '
        Me.mnuMainSelectSource.Name = "mnuMainSelectSource"
        Me.mnuMainSelectSource.Size = New System.Drawing.Size(175, 22)
        Me.mnuMainSelectSource.Text = "&Sélectionner source"
        '
        'mnuMainScan
        '
        Me.mnuMainScan.Name = "mnuMainScan"
        Me.mnuMainScan.Size = New System.Drawing.Size(175, 22)
        Me.mnuMainScan.Text = "&Acquérir image"
        '
        'mnuList
        '
        Me.mnuList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainCloseAll})
        Me.mnuList.Name = "mnuList"
        Me.mnuList.Size = New System.Drawing.Size(63, 20)
        Me.mnuList.Text = "F&enêtres"
        '
        'mnuMainCloseAll
        '
        Me.mnuMainCloseAll.Name = "mnuMainCloseAll"
        Me.mnuMainCloseAll.Size = New System.Drawing.Size(152, 22)
        Me.mnuMainCloseAll.Text = "&Fermer tout"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(24, 20)
        Me.mnuAbout.Text = "&?"
        '
        'frmTwainMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 445)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmTwainMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OpenTwain.NET"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMainSelectSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainScan As System.Windows.Forms.ToolStripMenuItem

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents mnuList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainCloseAll As System.Windows.Forms.ToolStripMenuItem

End Class
