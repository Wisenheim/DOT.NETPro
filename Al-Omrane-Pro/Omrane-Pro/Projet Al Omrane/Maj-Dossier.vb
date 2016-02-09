Imports System.IO
Public Class Maj_Dossier
    Public code As String
    Sub searchfile()
        'Creation NameSpace IO
        Dim di As New IO.DirectoryInfo("c:\Archive\" & t_code.Text)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        Li_obg.Items.Clear()
        For Each dra In diar1
            Li_obg.Items.Add(dra)
        Next
    End Sub
    Public Sub effacer()
        comb_adress.SelectedIndex = -1
        Code_DossierTextBox.Clear()
        combo_servic.SelectedIndex = -1
        exercicetextbox.Clear()
        Num_OrdreTextBox.Clear()
        ReferenceTextBox.Clear()
        Etat_dossTextBox.Clear()
        Date_DepotDateTimePicker.Value = Now
        Li_obg.Items.Clear()
    End Sub
    Sub nouveau()
        comb_adress.Enabled = 1
        combo_servic.Enabled = 1
        Button1.Enabled = 1
        LinkLabel3.Visible = 1
        t_code.Enabled = 0
        t_code.Clear()
        Me.Width = 442
        Code_DossierTextBox.Enabled = True
        Etat_dossTextBox.Enabled = 0
        Code_DossierTextBox.Focus()
        Etat_dossTextBox.Text = "Disponnible"
    End Sub
    Sub tenabled()
        Button2.Enabled = 1
        Button3.Enabled = 1
    End Sub
    Sub wenabled()
        Button2.Enabled = 0
        Button3.Enabled = 0
    End Sub
    Dim dc As New _archiveDataContext
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim r = (From d In dc.Dossier Where d.Code_Dossier = t_code.Text).SingleOrDefault
        r.adresse = comb_adress.SelectedValue
        r.code_service = combo_servic.SelectedValue
        r.Date_Depot = Date_DepotDateTimePicker.Text()
        r.exercice = exercicetextbox.Text()
        r.Num_Ordre = Num_OrdreTextBox.Text
        r.Reference = ReferenceTextBox.Text
        dc.SubmitChanges()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Maj_Dossier_Load(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim r = From d In dc.Dossier Where d.Code_Dossier = Code_DossierTextBox.Text.Trim
            If r.Any Then
                MsgBox("Dossier dejà existant")
                Code_DossierTextBox.Focus()
            Else
                Dim d As New Dossier
                d.adresse = comb_adress.SelectedValue
                d.code_service = combo_servic.SelectedValue
                d.Code_Dossier = Code_DossierTextBox.Text
                d.Date_Depot = Date_DepotDateTimePicker.Text
                d.etat_doss = Etat_dossTextBox.Text
                d.exercice = exercicetextbox.Text
                d.Num_Ordre = Num_OrdreTextBox.Text
                d.Reference = ReferenceTextBox.Text
                dc.Dossier.InsertOnSubmit(d)
                Dim p = (From em In dc.Emplacement Where em.Adresse = d.adresse).SingleOrDefault
                p.Salle.Capacite -= 1
                dc.SubmitChanges()

                CreateFolder("C:\Archive\", Code_DossierTextBox.Text)
                If MsgBox("Dossier < " & Code_DossierTextBox.Text & " > est bien ajoutè" & vbCrLf & "Tu veux Scanner des Fichies dans cette dernier ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = 6 Then
                    code = Code_DossierTextBox.Text
                    B_scan_Click(sender, e)
                End If
                effacer()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim hel As Integer
    Private Sub t_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_code.TextChanged

        Try
            If Not IsNumeric(t_code.Text.Trim) Or t_code.Text.Trim = "" Then
                t_code.Clear()
                L_introuv.Visible = 0
                effacer()
            Else
                Dim r = (From d In dc.Dossier Where d.Code_Dossier = t_code.Text).SingleOrDefault
                If r IsNot Nothing Then
                    Code_DossierTextBox.Enabled = 0
                    L_introuv.Visible = 0
                    Button1.Enabled = 0
                    comb_adress.SelectedValue = r.adresse
                    Code_DossierTextBox.Text = r.Code_Dossier
                    combo_servic.SelectedValue = r.code_service
                    Date_DepotDateTimePicker.Text = r.Date_Depot
                    exercicetextbox.Text = r.exercice
                    Num_OrdreTextBox.Text = r.Num_Ordre
                    ReferenceTextBox.Text = r.Reference
                    Etat_dossTextBox.Text = r.etat_doss
                    searchfile()
                    tenabled()
                    B_scan.Enabled = True
                    LinkLabel1.Visible = 1
                    If Etat_dossTextBox.Text = "Non Disponnible" Then
                        LinkLabel1.Text = "Redèposer ce Dossier "
                        Date_entreeDateTimePicker.Visible = False
                        Date_entreeDateTimePicker.Visible = False
                    Else
                        LinkLabel1.Text = "Faire une mouvement de ce dossier "
                        Date_entreeDateTimePicker.Visible = True
                        Date_entreeDateTimePicker.Visible = True
                    End If
                Else
                    L_introuv.Visible = 1
                    Button1.Enabled = 1
                    Code_DossierTextBox.Enabled = 1
                    effacer()
                    Li_obg.Items.Clear()
                    LinkLabel1.Visible = 0
                    Me.Width = 441
                    wenabled()
                    B_scan.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub B_mouv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_mouv.Click
        Dim r = (From d In dc.Dossier Where d.Code_Dossier = t_code.Text).SingleOrDefault
        If MatriculeTextBox.Text.Trim = "" Or ComboBox1.SelectedIndex = -1 Then
            MsgBox("Remplir tous les champs obligatoire")
            MatriculeTextBox.Focus()
        Else
            Try
                Dim md As New Mvt_Dossier
                Code_DossierTextBox.Text = r.Code_Dossier
                md.code_dossier = Code_DossierTextBox.Text
                md.Date_entree = Date_entreeDateTimePicker.Text
                md.Date_Sortie = Date.Today
                md.matricule = MatriculeTextBox.Text
                md.code_type_mvt = ComboBox1.SelectedValue
                dc.Mvt_Dossier.InsertOnSubmit(md)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            r.etat_doss = "Non Disponnible"
            Etat_dossTextBox.Text = "Non Disponnible"
            dc.SubmitChanges()
            MsgBox("Mouvement avec succès")
            effacer()
            nouveau()
            MatriculeTextBox.Clear()
            ComboBox1.SelectedIndex = -1
        End If
    End Sub

    'Private Sub MatriculeTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MatriculeTextBox.LostFocus
    '    If MatriculeTextBox.Text.Trim = "" Then
    '        MatriculeTextBox.Focus()
    '    Else
    '        Dim g = From u In dc.Utilisateur Where u.Matricule = MatriculeTextBox.Text
    '        Dim f = From a In dc.Archiveur Where a.Code_archiv = MatriculeTextBox.Text
    '        If g.Any Or f.Any Then
    '        Else
    '            MsgBox("utilisateur non existant")
    '            MatriculeTextBox.Focus()
    '        End If
    '    End If
    'End Sub
    Private Sub Maj_Dossier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 442
        t_code.Focus()
        B_scan.Enabled = False
        MatriculeTextBox.Text = sessionLogin
        TypeMouvementBindingSource.DataSource = dc.Type_Mouvement
        EmplacementBindingSource.DataSource = dc.Emplacement
        ServiceBindingSource.DataSource = dc.Service
        effacer()
        nouveau()

        'If Not (System.IO.Directory.Exists("C:\Historique")) Then
        '    System.IO.Directory.CreateDirectory("C:\Historique")
        'End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Etat_dossTextBox.Text = "Non Disponnible" Then
            B_mouv.Enabled = 0
            Button5.Enabled = 1
            Me.Width = 777
            LinkLabel1.Visible = 0

            TypeMouvementBindingSource.DataSource = dc.Type_Mouvement
        Else
            Button5.Enabled = 0
            B_mouv.Enabled = 1
            Me.Width = 777
            LinkLabel1.Visible = 0
        End If
        'If Etat_dossTextBox.Text = "Disponnible" Then
        '    TypeMouvementBindingSource.Remove(ComboBox1.ValueMember = "depot")
        'Else
        '    If ComboBox1.Items.Count = 2 Then
        '        TypeMouvementBindingSource.Remove(ComboBox1.ValueMember = "depot")
        '        Dim r = (From typ In dc.Type_Mouvement Where typ.Lib_Type = "depot").SingleOrDefault
        '        TypeMouvementBindingSource.Add(r)
        '    End If
        'End If
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Width = 441
        LinkLabel1.Visible = 1
        t_code.Focus()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim ar = From arc In dc.Archiveur Where arc.Code_archiv = MatriculeTextBox.Text
        If ar.Any Then
            MsgBox("Vous navez pas le droit de faire une mouvement")
            MatriculeTextBox.Focus()
        Else
            Dim mv = From mvt In dc.Mvt_Dossier Where mvt.code_dossier = Code_DossierTextBox.Text And MatriculeTextBox.Text = mvt.matricule
            Dim md As New Mvt_Dossier
            If mv.Any Then
                Dim r = (From d In dc.Dossier Where d.Code_Dossier = t_code.Text).SingleOrDefault
                md.code_dossier = Code_DossierTextBox.Text
                md.Date_entree = Date.Today
                md.Date_Sortie = Nothing
                md.matricule = MatriculeTextBox.Text
                md.code_type_mvt = ComboBox1.SelectedValue
                dc.Mvt_Dossier.InsertOnSubmit(md)
                r.etat_doss = "Disponnible"
                Etat_dossTextBox.Text = "Disponnible"
                dc.SubmitChanges()
                MsgBox("Déposement avec succès")
                effacer()
                nouveau()
            Else
                MsgBox("vous n'avez pas la possibilitè")
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Ce dossier serà deplacè a l'Historique, Voulez-vous vraiment deplacer ce Dossier !!", MsgBoxStyle.OkCancel)
        Try
            If MsgBoxResult.Ok Then
                Dim r = (From de In dc.Dossier Where de.Code_Dossier = Code_DossierTextBox.Text And de.etat_doss = "Disponnible").SingleOrDefault
                If r IsNot Nothing Then
                    Dim d As New Historique_Dos
                    d.code_dos = Code_DossierTextBox.Text
                    d.code_service = combo_servic.SelectedValue
                    d.Date_depot = Date_DepotDateTimePicker.Text
                    d.adresse = comb_adress.SelectedValue
                    d.exercice = exercicetextbox.Text
                    d.num_ordre = Num_OrdreTextBox.Text
                    d.Reference = ReferenceTextBox.Text
                    d.etat_doss = Etat_dossTextBox.Text
                    dc.Dossier.DeleteOnSubmit(r)
                    Dim p = (From em In dc.Emplacement Where em.Adresse = d.adresse).SingleOrDefault
                    p.Salle.Capacite += 1
                    dc.Historique_Dos.InsertOnSubmit(d)
                    dc.SubmitChanges()
                    Directory.Move("C:\Archive\" & Code_DossierTextBox.Text, "C:\Historique\" & Code_DossierTextBox.Text)
                    MsgBox("Dossier est bien deplacè a l'historique des dossiers")
                    effacer()
                Else
                    MsgBox("Dossier Non disponnible")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Button1.Enabled = 0
        t_code.Enabled = 1
        t_code.Clear()
        Etat_dossTextBox.Clear()
        t_code.Focus()
        effacer()

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub B_scan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_scan.Click

        frmTwainMain.ShowDialog()


    End Sub
    Private Sub comb_adress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comb_adress.SelectedIndexChanged
        If comb_adress.SelectedIndex = -1 Then
        Else
            Dim emp = (From em In dc.Emplacement Where em.Adresse = CStr(comb_adress.SelectedValue)).SingleOrDefault
            If emp IsNot Nothing Then
                If emp.Salle.Capacite = 0 Then
                    MsgBox("Capacite Salle est plein , Essayer autre Adresse")
                End If
            End If
        End If
    End Sub

    Private Sub get_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_file.Click
        If (Li_obg.SelectedIndex <> -1) Then
            System.Diagnostics.Process.Start("C:\Archive\" & t_code.Text & "\" & Li_obg.Text)
        Else
            MsgBox("Une Erreur:" & vbCrLf & "Description: " & vbCrLf & "- Votre dossier contien aucun fichier" _
                   & vbCrLf & "OU " & vbCrLf & "- Vous n'avez pas selectionez un fichier", MsgBoxStyle.Information)
        End If

    End Sub



End Class