Public Class historic
    Dim dc As New _archiveDataContext
    Sub searchfile()
        'Creation NameSpace IO
        Dim di As New IO.DirectoryInfo("c:\Historique\" & T_code_D.Text)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub T_code_D_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_code_D.TextChanged
        If T_code_D.Text.Trim <> "" And IsNumeric(T_code_D.Text) Then
            GroupBox2.Enabled = 0
            L_found.Visible = 0
            Dim r = From h In dc.Historique_Dos Where h.code_dos = T_code_D.Text
            If r.Any Then
                DataGridView1.DataSource = r
                L_liste.Text = "Les donnèe de Dossier N :" & T_code_D.Text
                L_liste.Visible = 1
                searchfile()
                If DataGridView1.Rows.Count = -1 Then
                    L_found.Visible = 1
                End If
            Else
                L_found.Visible = 1
            End If
        Else
            L_found.Visible = 0
            GroupBox2.Enabled = 1
            T_code_D.Clear()
            T_code_D.Focus()
            L_liste.Visible = 0
        End If
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        GroupBox1.Enabled = 1
        GroupBox2.Enabled = 1
        L_liste.Visible = 0
        T_code_D.Focus()
        DataGridView1.Rows.Clear()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GroupBox1.Enabled = 0
        GroupBox2.Enabled = 0
        T_code_D.Clear()
        T_code_mvt.Clear()
        Dim p = (From dhi In dc.Historique_Dos).SingleOrDefault
        Dim se = (From s In dc.Service Where s.Code_Service = p.code_service).SingleOrDefault
        Dim r = From dh In dc.Historique_Dos Select dh.adresse, dh.code_dos, se.Nom_Service, dh.Reference, dh.num_ordre, dh.Date_depot, dh.exercice
        If r IsNot Nothing Then
            DataGridView1.DataSource = r
            L_liste.Text = "Liste de tous les Dossiers historisè"
            L_liste.Visible = 1
        End If
    End Sub
    Private Sub T_code_mvt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_code_mvt.TextChanged
        If T_code_mvt.Text.Trim <> "" And IsNumeric(T_code_mvt.Text) Then
            GroupBox1.Enabled = 0
            Dim h = (From his In dc.Historique_Dos Where his.code_dos = T_code_mvt.Text).SingleOrDefault
            Dim r = From mvt In dc.Mvt_Dossier Where mvt.code_dossier = h.code_dos
            If h IsNot Nothing Then
                DataGridView1.DataSource = r
                L_liste.Text = "Liste des mouvements historisè de Dossier N :" & T_code_mvt.Text
                L_liste.Visible = 1
            Else
                L_found.Visible = 1
            End If
        Else
            L_found.Visible = 0
            GroupBox1.Enabled = 1
            T_code_mvt.Clear()
            T_code_mvt.Focus()
            L_liste.Visible = 0
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Dim r = From mvt In dc.Mvt_Dossier Where mvt.code_dossier = i
        If r.Any Then
            dgv_mvt.dgv.DataSource = r
            dgv_mvt.ShowDialog()
        Else
            MsgBox("aucune mouvement ")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Not (ListBox1.SelectedIndex = -1) Then
                System.Diagnostics.Process.Start("C:\Archive\" & T_code_D.Text & "\" & ListBox1.Text)
            Else
                MsgBox("Non fichier selectionnez", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class