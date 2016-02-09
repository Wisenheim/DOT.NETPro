Public Class Consulter_dos
    Dim dc As New _archiveDataContext
    Sub searchfile()
        'Creation NameSpace IO
        Dim di As New IO.DirectoryInfo("c:\Archive\" & t_code.Text)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Public Sub effacer()
        L_adress.Text = "-------------------------------------"
        L_Codedos.Text = "-------------------------------------"
        L_Codeserv.Text = "-------------------------------------"
        L_dat.Text = "-------------------------------------"
        L_etat_dos.Text = "-------------------------------------"
        L_numordr.Text = "-------------------------------------"
        L_ref.Text = "-------------------------------------"
        L_exer.Text = "-------------------------------------"
        ListBox1.Items.Clear()
    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        effacer()
        t_code.Focus()
        Me.Width = 344
    End Sub
    Private Sub B_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_quit.Click
        effacer()
        Me.Close()
    End Sub
    Private Sub Consulter_dos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 344
        t_code.Focus()
    End Sub
    Private Sub t_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_code.TextChanged
        LinkLabel3.Visible = 0
        If t_code.Text.Trim = "" Then
            L_notfound.Visible = 0
            effacer()
            Me.Width = 365
        End If
        Try
            If Not IsNumeric(t_code.Text.Trim) Then
                t_code.Clear()
            Else
                Dim r = (From d In dc.Dossier Where d.Code_Dossier = t_code.Text).SingleOrDefault
                If r IsNot Nothing Then
                    If Connexion.con = Nothing Then
                        L_adress.Text = r.adresse
                        L_Codedos.Text = r.Code_Dossier
                        L_Codeserv.Text = r.code_service
                        L_dat.Text = r.Date_Depot
                        L_exer.Text = r.exercice
                        L_numordr.Text = r.Num_Ordre
                        L_ref.Text = r.Reference
                        L_etat_dos.Text = r.etat_doss
                        L_notfound.Visible = 0
                        Me.Width = 715
                        searchfile()
                    Else
                        Dim ut = (From u In dc.Utilisateur Where u.Matricule = Connexion.con And u.code_service = r.code_service).SingleOrDefault
                        If ut IsNot Nothing Then
                            L_adress.Text = r.adresse
                            L_Codedos.Text = r.Code_Dossier
                            L_Codeserv.Text = r.code_service
                            L_dat.Text = r.Date_Depot
                            L_exer.Text = r.exercice
                            L_numordr.Text = r.Num_Ordre
                            L_ref.Text = r.Reference
                            L_etat_dos.Text = r.etat_doss
                            L_notfound.Visible = 0
                            Me.Width = 715
                            searchfile()
                        End If
                    End If
                Else
                    effacer()
                    Me.Width = 341
                    L_notfound.Visible = 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("C:\Archive\" & t_code.Text & "\" & ListBox1.Text)
    End Sub
End Class