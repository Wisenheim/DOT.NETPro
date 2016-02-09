Public Class suivi_dos
    Dim dc As New _archiveDataContext
    Private Const DEPOSER As String = "Déposer"
    Private Const MOUV As String = "Mouvement"

    Public Sub afficher(ByVal obj As Object, ByVal et As String)
        If obj IsNot Nothing Then
            DataGridView1.DataSource = obj
            L_list.Text = "La liste de dossier :" & T_code_D.Text & " en état de " & et
            L_list.Visible = 1
        Else
            DataGridView1.Rows.Clear()
        End If
    End Sub
    Private Sub dossierParEtat(ByVal etat As String)

        Try
            If T_code_D.Text.Trim <> "" And IsNumeric(T_code_D.Text) Then
                GroupBox2.Enabled = 0
                If etat = DEPOSER Then
                    Dim r = From mvt In dc.Mvt_Dossier Where mvt.code_dossier = CInt(T_code_D.Text) And Not mvt.Date_Sortie.HasValue _
                                       Select mvt.Code_Mvt, mvt.code_dossier, mvt.Utilisateur.Nom_U, mvt.matricule _
                                       , mvt.Date_entree, mvt.Date_Sortie, mvt.Type_Mouvement.Lib_Type, mvt.Dossier.Service.Nom_Service

                    afficher(r, etat)
                Else
                    Dim r = From mvt In dc.Mvt_Dossier Where mvt.code_dossier = T_code_D.Text _
                                       Select mvt.Code_Mvt, mvt.code_dossier, mvt.Utilisateur.Nom_U, mvt.matricule _
                                       , mvt.Date_entree, mvt.Date_Sortie, mvt.Type_Mouvement.Lib_Type, mvt.Dossier.Service.Nom_Service

                    afficher(r, etat)
                End If
            Else
                GroupBox2.Enabled = 1
                T_code_D.Clear()
                T_code_D.Focus()
                L_list.Visible = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub B_aff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_aff.Click
        Dim m = From mv In dc.Mvt_Dossier Where (mv.Date_entree > DateTimePicker1.Text And mv.Date_entree < DateTimePicker2.Text) _
                Or (mv.Date_Sortie > DateTimePicker1.Text And mv.Date_Sortie < DateTimePicker2.Text)
        Dim r = From d In dc.Dossier Where m.Any _
                Select d.adresse, d.Code_Dossier, d.Service.Nom_Service, d.Reference, d.Num_Ordre, d.Date_Depot, d.exercice
        DataGridView1.DataSource = r
        L_list.Text = "Liste des dossier entre " & DateTimePicker1.Value & " et " & DateTimePicker2.Value
        L_list.Visible = 1
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GroupBox1.Enabled = 0
        GroupBox2.Enabled = 0
        T_code_D.Clear()
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        Dim r = From d In dc.Dossier Select d.adresse, d.Code_Dossier, d.Service.Nom_Service, d.Reference, d.Num_Ordre, d.Date_Depot, d.exercice
        If r IsNot Nothing Then
            DataGridView1.DataSource = r
            L_list.Text = "Liste de tous les Dossiers"
            L_list.Visible = 1
        End If
    End Sub
    Private Sub T_code_D_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_code_D.TextChanged
     
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        GroupBox1.Enabled = 0
        If DateTimePicker1.Value = Now Then
            GroupBox1.Enabled = 1
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        GroupBox1.Enabled = 0
        If DateTimePicker1.Value = Now Then
            GroupBox1.Enabled = 1
        End If
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        GroupBox1.Enabled = 1
        GroupBox2.Enabled = 1
        T_code_D.Focus()
        DataGridView1.Rows.Clear()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub suivi_dos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        T_code_D.Focus()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Dim r = From mvt In dc.Mvt_Dossier Where mvt.code_dossier = i
        If r.Any Then
            dgv_mvt.dgv.DataSource = r
            dgv_mvt.ShowDialog()
        Else
            MsgBox("aucune mouvement ")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        dossierParEtat(DEPOSER)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        dossierParEtat(MOUV)
    End Sub
End Class