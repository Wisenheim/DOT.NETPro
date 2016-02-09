Public Class Form1
    Private Sub MajcompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MAJ_Comptes.ShowDialog()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Link_connect.Visible = 0
        Link_connect.Visible = 0
        Connexion.Show()
        Connexion.T_login.Focus()
    End Sub

    Private Sub MajDossierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Maj_Dossier.Show()
        Maj_Dossier.Button1.Visible = 1
        Maj_Dossier.Button2.Visible = 1
        Maj_Dossier.Button3.Visible = 1
        Maj_Dossier.Button4.Visible = 1
    End Sub

    Private Sub MajCompteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MajCompteToolStripMenuItem1.Click
        MAJ_Comptes.Show()
    End Sub
    Private Sub ConsulterUnDossierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Maj_Dossier.ShowDialog()
    End Sub
    Private Sub MajSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MajSalesToolStripMenuItem.Click
        maj_salle.ShowDialog()
    End Sub
    Private Sub ConsultantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultantToolStripMenuItem.Click
        Consulter_dos.ShowDialog()

    End Sub
    Private Sub ArchiverUnDossierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiverUnDossierToolStripMenuItem1.Click
        Maj_Dossier.ShowDialog()

    End Sub
    Private Sub SuiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuiToolStripMenuItem.Click
        suivi_dos.ShowDialog()

    End Sub
    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub HistoriqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoriqueToolStripMenuItem.Click
        historic.Show()
        historic.T_code_D.Focus()
    End Sub
    Private Sub InscriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Inscription.ShowDialog()

    End Sub
    Private Sub DeconnexionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeconnexionToolStripMenuItem.Click
        Link_connect.Visible = 0
        Connexion.T_login.Clear()
        Connexion.T_pass.Clear()
        Connexion.Show()
        Me.Close()
        Connexion.T_login.Focus()
    End Sub

    Private Sub MajservicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MajservicesToolStripMenuItem.Click
        Maj_services.ShowDialog()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Connexion.Show()
        Connexion.T_pass.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not (System.IO.Directory.Exists("C:\Archive")) Then
                System.IO.Directory.CreateDirectory("C:\Archive")
            End If

            If Not (System.IO.Directory.Exists("C:\Historique")) Then
                System.IO.Directory.CreateDirectory("C:\Historique")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
