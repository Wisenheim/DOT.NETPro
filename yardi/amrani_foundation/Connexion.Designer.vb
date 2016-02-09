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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.B_connexion = New System.Windows.Forms.Button()
        Me.B_annuler = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.T_pass = New System.Windows.Forms.TextBox()
        Me.T_login = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(142, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Login ou Mot de passe incorrect"
        Me.Label3.Visible = False
        '
        'B_connexion
        '
        Me.B_connexion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.B_connexion.Enabled = False
        Me.B_connexion.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_connexion.Image = Global.amrani_foundation.My.Resources.Resources._1366992260_tick
        Me.B_connexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_connexion.Location = New System.Drawing.Point(219, 131)
        Me.B_connexion.Name = "B_connexion"
        Me.B_connexion.Size = New System.Drawing.Size(81, 38)
        Me.B_connexion.TabIndex = 14
        Me.B_connexion.Text = "Connexion"
        Me.B_connexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_connexion.UseVisualStyleBackColor = False
        '
        'B_annuler
        '
        Me.B_annuler.BackColor = System.Drawing.SystemColors.ControlLight
        Me.B_annuler.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_annuler.Image = Global.amrani_foundation.My.Resources.Resources._1367006511_dialog_close1
        Me.B_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_annuler.Location = New System.Drawing.Point(306, 131)
        Me.B_annuler.Name = "B_annuler"
        Me.B_annuler.Size = New System.Drawing.Size(75, 38)
        Me.B_annuler.TabIndex = 13
        Me.B_annuler.Text = "Annuler"
        Me.B_annuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_annuler.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(239, 67)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 20)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Masquer les Caracteres "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'T_pass
        '
        Me.T_pass.Enabled = False
        Me.T_pass.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_pass.Location = New System.Drawing.Point(239, 40)
        Me.T_pass.Name = "T_pass"
        Me.T_pass.Size = New System.Drawing.Size(149, 23)
        Me.T_pass.TabIndex = 11
        Me.T_pass.UseSystemPasswordChar = True
        '
        'T_login
        '
        Me.T_login.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_login.Location = New System.Drawing.Point(239, 14)
        Me.T_login.Name = "T_login"
        Me.T_login.Size = New System.Drawing.Size(149, 23)
        Me.T_login.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Login :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mot de Passe : "
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 146)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(192, 23)
        Me.ProgressBar1.TabIndex = 16
        Me.ProgressBar1.Visible = False
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.amrani_foundation.My.Resources.Resources._1368110654_preferences_desktop_cryptography
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(393, 181)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_connexion)
        Me.Controls.Add(Me.B_annuler)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.T_pass)
        Me.Controls.Add(Me.T_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents B_connexion As System.Windows.Forms.Button
    Friend WithEvents B_annuler As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents T_pass As System.Windows.Forms.TextBox
    Friend WithEvents T_login As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
