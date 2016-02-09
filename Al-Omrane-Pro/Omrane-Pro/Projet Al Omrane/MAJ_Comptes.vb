Public Class MAJ_Comptes
    Dim bd As New _archiveDataContext
    Public Sub effacer()
        MatriculeTextBox.Clear()
        Nom_UTextBox.Clear()
        Prenom_UTextBox.Clear()
        Mot_passTextBox.Clear()
        Combo_roles.SelectedIndex = -1
        C_service.SelectedIndex = -1
    End Sub
    Private Sub MAJ_Comptes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesBindingSource.DataSource = bd.Roles
        ServiceBindingSource.DataSource = bd.Service
        SalleBindingSource.DataSource = bd.Salle
    End Sub
    Private Sub T_mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_mat.TextChanged
        If T_mat.Text.Trim = "" Then
            effacer()
            L_ar.Visible = 0
            L_notfound.Visible = 0
            L_archiv.Visible = 0
            l_salle.Visible = 0
            ComboBox1.Visible = 0
            C_service.Visible = 1 : Combo_roles.Visible = 1
            B_Modifier.Enabled = 0
            B_Supprimer.Enabled = 0
            L_notfound.Hide()
        End If
        Try
            Dim r = (From t In bd.Utilisateur Where t.Matricule = T_mat.Text).SingleOrDefault
            Dim w = (From j In bd.Archiveur Where j.Code_archiv = T_mat.Text).SingleOrDefault
            If r IsNot Nothing Then
                B_Modifier.Enabled = 1
                B_Supprimer.Enabled = 1
                L_notfound.Visible = 0
                Combo_roles.Visible = 1 : C_service.Visible = 1
                MatriculeTextBox.Text = r.Matricule
                Nom_UTextBox.Text = r.Nom_U
                Prenom_UTextBox.Text = r.Prenom_U
                Mot_passTextBox.Text = r.Mot_pass
                Combo_roles.SelectedValue = r.code_role
                C_service.SelectedValue = r.code_service
                L_ar.Visible = 0 : L_archiv.Visible = 0
                l_salle.Visible = 0 : ComboBox1.Visible = 0
            ElseIf w IsNot Nothing Then
                B_Modifier.Enabled = 1
                B_Supprimer.Enabled = 1
                L_notfound.Visible = 0
                l_salle.Visible = 1
                ComboBox1.Visible = 1
                L_ar.Visible = 1 : L_archiv.Visible = 1
                MatriculeTextBox.Text = w.Code_archiv
                Nom_UTextBox.Text = w.nom
                Prenom_UTextBox.Text = w.prenom
                Mot_passTextBox.Text = w.Mot_pass
                Combo_roles.Visible = 0 : C_service.Visible = 0
                ComboBox1.SelectedValue = w.code_salle
            Else
                effacer()
                l_salle.Visible = 0
                ComboBox1.Visible = 0
                L_notfound.Visible = 1
                B_Modifier.Enabled = 0
                B_Supprimer.Enabled = 0
            End If
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Inscription.Show()
    End Sub
    Private Sub B_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Modifier.Click
        Dim r = (From t In bd.Utilisateur Where t.Matricule = T_mat.Text).SingleOrDefault
        Dim w = (From v In bd.Archiveur Where v.Code_archiv = T_mat.Text).SingleOrDefault
        Try
            If r IsNot Nothing Then
                r.Matricule = MatriculeTextBox.Text
                r.Nom_U = Nom_UTextBox.Text
                r.Prenom_U = Prenom_UTextBox.Text()
                r.Mot_pass = Mot_passTextBox.Text()
                r.code_role = Combo_roles.SelectedValue
                r.code_service = C_service.SelectedValue
                MsgBox("Compte est bien modifiè ")
            End If
            If w IsNot Nothing Then
                w.Code_archiv = MatriculeTextBox.Text
                w.nom = Nom_UTextBox.Text
                w.prenom = Prenom_UTextBox.Text()
                w.Mot_pass = Mot_passTextBox.Text()
                w.code_salle = ComboBox1.SelectedValue
                MsgBox("Compte est bien modifiè ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bd.SubmitChanges()
    End Sub
    Private Sub B_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Supprimer.Click
        Try
            Dim p = (From u In bd.Utilisateur Where u.Matricule = T_mat.Text).SingleOrDefault
            bd.Utilisateur.DeleteOnSubmit(p)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bd.SubmitChanges()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

  
End Class