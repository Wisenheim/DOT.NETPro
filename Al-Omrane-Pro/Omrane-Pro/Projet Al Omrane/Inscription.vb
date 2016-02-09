Public Class Inscription
    Dim dc As New _archiveDataContext
    Sub fenabled()
        Combo_salle.Enabled = 0
        T_matric.Enabled = 0
        t_pass.Enabled = 0
        t_nom.Enabled = 0
        t_prenom.Enabled = 0
        Combo_services.SelectedIndex = -1
        Combo_services.Enabled = 0
        Combo_roles.SelectedIndex = -1
        Combo_roles.Enabled = 0
    End Sub
    Public Sub effacer()
        T_matric.Clear()
        t_pass.Clear()
        t_nom.Clear()
        t_prenom.Clear()
        Combo_roles.SelectedIndex = -1
        Combo_services.SelectedIndex = -1
        Combo_salle.SelectedIndex = -1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim u As New Utilisateur
        Dim ar As New Archiveur
        Try
            If Radio_admin.Checked Then
                u.Matricule = T_matric.Text
                u.Mot_pass = t_pass.Text
                u.Nom_U = t_nom.Text
                u.Prenom_U = t_prenom.Text
                u.code_role = Combo_roles.SelectedValue
                u.code_service = Combo_services.SelectedValue
                dc.Utilisateur.InsertOnSubmit(u)
                dc.SubmitChanges()
                MsgBox("Utilisateur est ajoutè avec succès")
            End If
            If Radio_archiv.Checked Then
                ar.code_salle = Combo_salle.SelectedValue
                ar.Code_archiv = T_matric.Text
                ar.Mot_pass = t_pass.Text
                ar.nom = t_nom.Text
                ar.prenom = t_prenom.Text
                ar.services = "Archivage"
                ar.roles = "Archiveur"
                dc.Archiveur.InsertOnSubmit(ar)
                dc.SubmitChanges()
                MsgBox("Archiveur est ajoutè avec succès")
                Combo_salle.Enabled = 1
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException)
        End Try
        effacer()
    End Sub

    Private Sub Inscription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Radio_admin.Checked = 1
        T_matric.Enabled = 1
        ServiceBindingSource.DataSource = dc.Service
        RolesBindingSource.DataSource = dc.Roles
        SalleBindingSource.DataSource = dc.Salle
        Combo_salle.SelectedIndex = -1
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        effacer()
        fenabled()
    End Sub
    Private Sub Radio_admin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_admin.CheckedChanged
        If Radio_admin.Checked Then
            T_matric.Enabled = 1
            Label1.Visible = 0
            Combo_salle.Visible = 0
            Combo_roles.Visible = 1
            Combo_services.Visible = 1
            Label5.Visible = 1
            Label6.Visible = 1
            Button1.Enabled = 0
            Button1.Location = New Point(92, 325)
            Button2.Location = New Point(180, 325)
            Me.Height = 404
            T_matric.Focus()
        Else
            Combo_salle.Focus()
            T_matric.Enabled = 0
            Combo_salle.Enabled = 1
            Label1.Visible = 1
            Combo_salle.Visible = 1
            Combo_roles.Visible = 0
            Combo_services.Visible = 0
            Label5.Visible = 0
            Label6.Visible = 0
            Button1.Enabled = 0
            Button1.Location = New Point(70, 255)
            Button2.Location = New Point(190, 255)
            Me.Height = 333
        End If
    End Sub
    Private Sub T_matric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_matric.TextChanged
        If Not IsNumeric(T_matric.Text) Then
            T_matric.Clear()
            T_matric.Focus()
        ElseIf T_matric.Text.Trim = "" Then
            t_pass.Enabled = 0
        Else
            t_pass.Enabled = 1
        End If
        If Radio_admin.Checked Then
            If T_matric.Text.Trim <> "" And Combo_salle.SelectedIndex = -1 Then
                Radio_archiv.Enabled = 0
                t_pass.Enabled = 1
            Else
                Radio_archiv.Enabled = 1
            End If
        End If
    End Sub
    Private Sub T_matric_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles T_matric.Leave
        If T_matric.Text.Trim = "" Then
            t_pass.Enabled = 0
            If Combo_salle.CanFocus Then
                Combo_salle.Focus()
                Radio_admin.Enabled = True
            Else
                T_matric.Focus()
            End If
        Else
            Dim r = From u In dc.Utilisateur Where u.Matricule = T_matric.Text
            Dim ar = From a In dc.Archiveur Where a.Code_archiv = T_matric.Text
            If r.Any Or ar.Any Then
                MsgBox("matricule existe dejà ")
                T_matric.Clear()
                T_matric.Focus()
            End If
        End If
    End Sub
    Private Sub t_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_pass.TextChanged
        If t_pass.Text.Trim = "" Then
            t_pass.Focus()
            t_nom.Enabled = 0
        Else
            t_nom.Enabled = 1
        End If
    End Sub
    Private Sub t_nom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_nom.TextChanged
        If IsNumeric(t_nom.Text) Then
            t_nom.Clear()
            t_nom.Focus()
        Else
            t_prenom.Enabled = 1
        End If
        If t_nom.Text.Trim = "" Then
            t_prenom.Enabled = 0
        End If
    End Sub
    Private Sub t_prenom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_prenom.TextChanged
        If IsNumeric(t_prenom.Text) Then
            t_prenom.Clear()
            t_prenom.Focus()
        Else
            Combo_services.SelectedIndex = -1
            Combo_services.Enabled = 1
        End If
        If t_prenom.Text.Trim = "" Then
            Combo_services.Enabled = 0
        Else
            If Radio_archiv.Checked Then
                Button1.Enabled = 1

            End If
        End If
    End Sub
    Private Sub Combo_services_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_services.SelectedIndexChanged
        If Combo_services.SelectedIndex = -1 Then
            Combo_roles.Enabled = 0
            Combo_roles.SelectedIndex = -1
        Else
            Combo_roles.Enabled = 1
        End If
    End Sub

    Private Sub Combo_roles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_roles.SelectedIndexChanged
        If Combo_roles.SelectedIndex <> -1 Then
            Button1.Enabled = 1
        Else
            Button1.Enabled = 0
        End If
    End Sub

    Private Sub Combo_salle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_salle.SelectedIndexChanged
        If Radio_archiv.Checked Then
            If Combo_salle.SelectedIndex = -1 Then
                T_matric.Enabled = 0
                Radio_admin.Enabled = 1
            Else
                T_matric.Enabled = 1
                Radio_admin.Enabled = 0
            End If
        End If
    End Sub
End Class