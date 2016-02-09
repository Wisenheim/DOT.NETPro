<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maj_services
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
        Dim Code_ServiceLabel As System.Windows.Forms.Label
        Dim Masque_SaisiLabel As System.Windows.Forms.Label
        Dim Nom_ServiceLabel As System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Code_ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.Masque_SaisiTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.code_service = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Code_ServiceLabel = New System.Windows.Forms.Label()
        Masque_SaisiLabel = New System.Windows.Forms.Label()
        Nom_ServiceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Code_ServiceLabel
        '
        Code_ServiceLabel.AutoSize = True
        Code_ServiceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Code_ServiceLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Code_ServiceLabel.Location = New System.Drawing.Point(28, 118)
        Code_ServiceLabel.Name = "Code_ServiceLabel"
        Code_ServiceLabel.Size = New System.Drawing.Size(88, 16)
        Code_ServiceLabel.TabIndex = 14
        Code_ServiceLabel.Text = "Code Service:"
        '
        'Masque_SaisiLabel
        '
        Masque_SaisiLabel.AutoSize = True
        Masque_SaisiLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Masque_SaisiLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Masque_SaisiLabel.Location = New System.Drawing.Point(28, 144)
        Masque_SaisiLabel.Name = "Masque_SaisiLabel"
        Masque_SaisiLabel.Size = New System.Drawing.Size(88, 16)
        Masque_SaisiLabel.TabIndex = 16
        Masque_SaisiLabel.Text = "Masque Saisi:"
        '
        'Nom_ServiceLabel
        '
        Nom_ServiceLabel.AutoSize = True
        Nom_ServiceLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_ServiceLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Nom_ServiceLabel.Location = New System.Drawing.Point(28, 170)
        Nom_ServiceLabel.Name = "Nom_ServiceLabel"
        Nom_ServiceLabel.Size = New System.Drawing.Size(86, 16)
        Nom_ServiceLabel.TabIndex = 18
        Nom_ServiceLabel.Text = "Nom Service:"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(255, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 42)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(174, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 42)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(93, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 42)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(12, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Nouveau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Code_ServiceTextBox
        '
        Me.Code_ServiceTextBox.Location = New System.Drawing.Point(122, 117)
        Me.Code_ServiceTextBox.Name = "Code_ServiceTextBox"
        Me.Code_ServiceTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Code_ServiceTextBox.TabIndex = 15
        '
        'Masque_SaisiTextBox
        '
        Me.Masque_SaisiTextBox.Location = New System.Drawing.Point(122, 143)
        Me.Masque_SaisiTextBox.Name = "Masque_SaisiTextBox"
        Me.Masque_SaisiTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Masque_SaisiTextBox.TabIndex = 17
        '
        'Nom_ServiceTextBox
        '
        Me.Nom_ServiceTextBox.Location = New System.Drawing.Point(122, 169)
        Me.Nom_ServiceTextBox.Name = "Nom_ServiceTextBox"
        Me.Nom_ServiceTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Nom_ServiceTextBox.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.code_service)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 71)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chercher service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(155, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Service Introuvable"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 49)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(122, 16)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nouvelle Recherche"
        Me.LinkLabel1.Visible = False
        '
        'code_service
        '
        Me.code_service.Location = New System.Drawing.Point(137, 22)
        Me.code_service.Name = "code_service"
        Me.code_service.Size = New System.Drawing.Size(147, 24)
        Me.code_service.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code Service :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Al_Omrane.My.Resources.Resources.service
        Me.PictureBox1.Location = New System.Drawing.Point(359, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Maj_services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 296)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Code_ServiceLabel)
        Me.Controls.Add(Me.Code_ServiceTextBox)
        Me.Controls.Add(Masque_SaisiLabel)
        Me.Controls.Add(Me.Masque_SaisiTextBox)
        Me.Controls.Add(Nom_ServiceLabel)
        Me.Controls.Add(Me.Nom_ServiceTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Maj_services"
        Me.Text = "Maj_services"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Code_ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Masque_SaisiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_ServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents code_service As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
