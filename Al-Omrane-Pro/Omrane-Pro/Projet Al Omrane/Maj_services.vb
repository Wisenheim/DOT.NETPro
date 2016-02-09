Public Class Maj_services
    Public Sub eff()
        Code_ServiceTextBox.Clear()
        Masque_SaisiTextBox.Clear()
        Nom_ServiceTextBox.Clear()
    End Sub
    Dim dc As New _archiveDataContext
    Private Sub code_service_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code_service.TextChanged
        Try
            If Not IsNumeric(code_service.Text.Trim) Then
                code_service.Clear()
            Else
                Dim r = (From s In dc.Service Where s.Code_Service = code_service.Text).SingleOrDefault
                If r IsNot Nothing Then
                    Label2.Hide()
                    Button3.Enabled = 1
                    Button4.Enabled = 1
                    Code_ServiceTextBox.Text = r.Code_Service
                    Masque_SaisiTextBox.Text = r.Masque_Saisi
                    Nom_ServiceTextBox.Text = r.Nom_Service
                    Code_ServiceTextBox.Enabled = True
                    Masque_SaisiTextBox.Enabled = True
                    Nom_ServiceTextBox.Enabled = True
                Else
                    eff()
                    Label2.Show()
                End If
            End If
            If code_service.Text.Trim = "" Then
                eff()
                Button3.Enabled = 0
                Button4.Enabled = 0
                Code_ServiceTextBox.Enabled = False
                Masque_SaisiTextBox.Enabled = False
                Nom_ServiceTextBox.Enabled = False
                Label2.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        eff()
        code_service.Enabled = False
        LinkLabel1.Visible = 1
        Button2.Enabled = 1
        code_service.Clear()
        Code_ServiceTextBox.Enabled = True
        Masque_SaisiTextBox.Enabled = True
        Nom_ServiceTextBox.Enabled = True
        Code_ServiceTextBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim r = From s In dc.Service Where s.Code_Service = Code_ServiceTextBox.Text
        If r.Any Then
            MsgBox("se code service exist deja ")
            Code_ServiceTextBox.Focus()
        End If
        Try
            Dim s As New Service
            If Not (Code_ServiceTextBox.Text = "" And Masque_SaisiTextBox.Text = "" And Nom_ServiceTextBox.Text = "") Then

                s.Code_Service = Code_ServiceTextBox.Text
                s.Masque_Saisi = Masque_SaisiTextBox.Text
                s.Nom_Service = Nom_ServiceTextBox.Text
                dc.Service.InsertOnSubmit(s)
                dc.SubmitChanges()
                MsgBox(" bien ajouter ")
            Else
                MsgBox(" remplit tous les champs ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        eff()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not (Code_ServiceTextBox.Text = "" And Masque_SaisiTextBox.Text = "" And Nom_ServiceTextBox.Text = "") Then
            Try
                Dim r = (From s In dc.Service Where s.Code_Service = Code_ServiceTextBox.Text).SingleOrDefault
                r.Code_Service = Code_ServiceTextBox.Text
                r.Masque_Saisi = Masque_SaisiTextBox.Text
                r.Nom_Service = Nom_ServiceTextBox.Text
                dc.SubmitChanges()
                MsgBox("bien modifier")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox(" remplit tous les champs ")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        code_service.Enabled = True
        Code_ServiceTextBox.Enabled = True
        Masque_SaisiTextBox.Enabled = True
        Nom_ServiceTextBox.Enabled = True
        Button2.Enabled = False

    End Sub

    Private Sub Maj_services_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Hide() : Button3.Enabled = False : Button4.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Try
            Dim r = (From s In dc.Service Where s.Code_Service = Code_ServiceTextBox.Text).SingleOrDefault
            dc.Service.DeleteOnSubmit(r)
            dc.SubmitChanges()
            MsgBox("Bien supprimer")
            code_service.Clear()
            eff() : Button3.Enabled = False : Button4.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class