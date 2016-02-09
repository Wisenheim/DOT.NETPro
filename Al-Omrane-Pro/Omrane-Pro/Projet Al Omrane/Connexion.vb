Public Class Connexion
    Dim dc As New _archiveDataContext

    Public log As String
    Public con As String
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            T_pass.UseSystemPasswordChar = True
        Else
            T_pass.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub B_connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_connexion.Click
        Dim ad = (From u In dc.Utilisateur Where u.Matricule = T_login.Text And u.Mot_pass = T_pass.Text And u.code_role = 0).SingleOrDefault
        Dim ar = (From a In dc.Archiveur Where a.Code_archiv = T_login.Text And a.Mot_pass = T_pass.Text).SingleOrDefault
        Dim cons = (From c In dc.Utilisateur Where c.Matricule = T_login.Text And c.Mot_pass = T_pass.Text And c.code_role = 1).SingleOrDefault
        If ad IsNot Nothing Then
            Form1.Show()
            Form1.Link_connect.Text = ad.Nom_U & " est connectè"
            Form1.Link_connect.Visible = 1
            sessionLogin = ad.Matricule
            Me.Hide()
        ElseIf ar IsNot Nothing Then
            Form1.Show()
            Form1.Link_connect.Text = ar.nom & " est connectè"
            Form1.MenuStrip1.Items.Item(0).Enabled = False
            sessionLogin = ad.Matricule
            Me.Hide()
        ElseIf cons IsNot Nothing Then
            Form1.Show()
            Form1.Link_connect.Text = cons.Nom_U & " est connectè"
            Form1.Link_connect.Visible = 1
            Form1.MenuStrip1.Items.Item(0).Enabled = 0
            Form1.MenuStrip1.Items.Item(2).Enabled = 0
            Form1.MenuStrip1.Items.Item(3).Enabled = 0
            con = T_login.Text
            Me.Hide()
        Else
            Label3.Show()
            T_login.Focus()
        End If
    End Sub
    Private Sub B_annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_annuler.Click
        Me.Close()
    End Sub
    Private Sub Connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = 1
        T_login.Focus()
    End Sub
    Private Sub T_login_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_login.TextChanged
        Label3.Visible = 0
        If Not IsNumeric(T_login.Text) Then
            T_login.Clear()
            T_login.Focus()
        Else
            T_pass.Enabled = 1
        End If
        If T_login.Text.Trim = "" Then
            T_pass.Enabled = 0
            B_connexion.Enabled = 0
        End If
    End Sub
    Private Sub T_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_pass.TextChanged
        If T_pass.Text.Trim <> "" Then
            B_connexion.Enabled = 1
        Else
            B_connexion.Enabled = 0
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Inscription.ShowDialog()
    End Sub
End Class