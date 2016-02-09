<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_login = New System.Windows.Forms.TextBox()
        Me.T_pass = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.B_connexion = New System.Windows.Forms.Button()
        Me.B_annuler = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mot de Passe : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login :"
        '
        'T_login
        '
        Me.T_login.Location = New System.Drawing.Point(281, 30)
        Me.T_login.Name = "T_login"
        Me.T_login.Size = New System.Drawing.Size(147, 20)
        Me.T_login.TabIndex = 2
        '
        'T_pass
        '
        Me.T_pass.Enabled = False
        Me.T_pass.Location = New System.Drawing.Point(281, 56)
        Me.T_pass.Name = "T_pass"
        Me.T_pass.Size = New System.Drawing.Size(147, 20)
        Me.T_pass.TabIndex = 3
        Me.T_pass.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(281, 83)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Masquer les Caracteres "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(188, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Login ou Mot de passe incorrect"
        Me.Label3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1368110654_preferences_desktop_cryptography
        Me.PictureBox1.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 147)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'B_connexion
        '
        Me.B_connexion.Enabled = False
        Me.B_connexion.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1366992260_tick
        Me.B_connexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_connexion.Location = New System.Drawing.Point(259, 178)
        Me.B_connexion.Name = "B_connexion"
        Me.B_connexion.Size = New System.Drawing.Size(81, 38)
        Me.B_connexion.TabIndex = 6
        Me.B_connexion.Text = "Connexion"
        Me.B_connexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_connexion.UseVisualStyleBackColor = True
        '
        'B_annuler
        '
        Me.B_annuler.Image = Global.Projet_Al_Omrane.My.Resources.Resources._1367006511_dialog_close
        Me.B_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_annuler.Location = New System.Drawing.Point(346, 178)
        Me.B_annuler.Name = "B_annuler"
        Me.B_annuler.Size = New System.Drawing.Size(75, 38)
        Me.B_annuler.TabIndex = 5
        Me.B_annuler.Text = "Annuler"
        Me.B_annuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_annuler.UseVisualStyleBackColor = True
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 226)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_connexion)
        Me.Controls.Add(Me.B_annuler)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.T_pass)
        Me.Controls.Add(Me.T_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Connexion"
        Me.Text = "Connexion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents T_login As System.Windows.Forms.TextBox
    Friend WithEvents T_pass As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents B_annuler As System.Windows.Forms.Button
    Friend WithEvents B_connexion As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
