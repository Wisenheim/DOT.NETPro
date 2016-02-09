Public Class maj_salle

    Dim dc As New _archiveDataContext
    Sub eff()
        Code_SalleTextBox.Clear()
        CapaciteTextBox.Clear()
        Lib_salleTextBox.Clear()
    End Sub
    Private Sub T_codesall_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_codesall.TextChanged
        B_add.Enabled = 0
        If Not IsNumeric(T_codesall.Text.Trim) Then
            eff()
        Else
            Dim r = (From s In dc.Salle Where s.Code_Salle = T_codesall.Text).SingleOrDefault
            If r IsNot Nothing Then
                L_introuv.Visible = 0
                b_mod.Enabled = 1
                B_del.Enabled = 1
                CapaciteTextBox.Text = r.Capacite
                Code_SalleTextBox.Text = r.Code_Salle
                Lib_salleTextBox.Text = r.Lib_salle
            Else
                L_introuv.Visible = 1
                eff()
            End If
        End If
        If T_codesall.Text.Trim = "" Then
            L_introuv.Hide()
            eff()
            b_mod.Enabled = 0
            B_del.Enabled = 0
        End If
    End Sub

    Private Sub B_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_new.Click
        eff()
        T_codesall.Clear()
        T_codesall.Enabled = 0
        CapaciteTextBox.Focus()
        LinkLabel1.Visible = 1
        B_add.Enabled = 1
        b_mod.Enabled = 0
        B_del.Enabled = 0
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        T_codesall.Enabled = 1
        T_codesall.Focus()
        LinkLabel1.Visible = 0
        B_add.Enabled = 0
    End Sub

    Private Sub B_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_add.Click
        Dim r = (From se In dc.Salle Where se.Code_Salle = Code_SalleTextBox.Text.Trim).SingleOrDefault
        Dim s As New Salle
        If r IsNot Nothing Then
            MsgBox("Salle dejà existante")
            Code_SalleTextBox.Focus()
        Else

            If CapaciteTextBox.Text.Trim = "" Or Lib_salleTextBox.Text.Trim = "" Then
                MsgBox("Remplir tous les champs")
                CapaciteTextBox.Focus()
            Else
                Try
                    s.Capacite = CapaciteTextBox.Text
                    s.Code_Salle = Code_SalleTextBox.Text
                    s.Lib_salle = Lib_salleTextBox.Text
                    dc.Salle.InsertOnSubmit(s)
                    dc.SubmitChanges()
                    MsgBox("Salle est bien Ajoutè")
                    eff()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub b_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_mod.Click
        Code_SalleTextBox.Enabled = 0
        Dim r = (From s In dc.Salle Where s.Code_Salle = Code_SalleTextBox.Text.Trim).SingleOrDefault
        If r IsNot Nothing Then
            If CapaciteTextBox.Text.Trim = "" Or Lib_salleTextBox.Text.Trim = "" Then
                MsgBox("Remplir tous les champs")
                CapaciteTextBox.Focus()
            Else
                Try
                    r.Capacite = CapaciteTextBox.Text
                    r.Lib_salle = Lib_salleTextBox.Text
                    dc.SubmitChanges()
                    MsgBox("Salle est bien modifiè")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub B_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_del.Click
        Dim r = (From s In dc.Salle Where s.Code_Salle = T_codesall.Text.Trim).SingleOrDefault
        If r Is Nothing Then
            MsgBox("Salle dejà introuvable")
            Code_SalleTextBox.Focus()
        Else
            Try
                dc.Salle.DeleteOnSubmit(r)
                dc.SubmitChanges()
                MsgBox("Salle est bien Supprimè")
                eff()
                b_mod.Enabled = False
                B_del.Enabled = True
                T_codesall.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class