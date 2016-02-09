Public Class deatail_P
    Dim r As DETAIL_perso
    Sub vider()

        T_Nom.Clear()
        T_pren.Clear()
        D_Paye.Value = Now
    End Sub
    Private Sub deatail_P_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        C_P.DataSource = From p In dc.PERSONNEL Select p.CIN

        T_Nom.Focus()
        Button1.Enabled = 0
        Button3.Enabled = 0
        Button4.Enabled = 0

    End Sub

    Private Sub C_P_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_P.SelectedIndexChanged
        r = (From p In dc.DETAIL_persos Where p.CIN = CStr(C_P.SelectedValue)).FirstOrDefault
        Dim r2 = (From cc In dc.PERSONNEL Where cc.CIN = CStr(C_P.SelectedValue)).SingleOrDefault

        If r Is Nothing Then

            T_Nom.Text = r2.NOM
            T_pren.Text = r2.PRENOM
            D_Paye.Value = Now
            Button1.Enabled = 1
            Button3.Enabled = 0
            Button4.Enabled = 0
        Else
            T_Nom.Text = r.PERSONNEL.NOM
            T_pren.Text = r.PERSONNEL.PRENOM
            D_Paye.Value = r.DATE_PAY
            Button1.Enabled = 0
            Button3.Enabled = 1
            Button4.Enabled = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim d As New DETAIL_perso
        Try
            d.CIN = CStr(C_P.SelectedValue)
            d.DATE_PAY = CDate(D_Paye.Value.Date)
            dc.DETAIL_persos.InsertOnSubmit(d)
            dc.SubmitChanges()
            vider()
            MsgBox("Detail bien Affectez", 64, "Information")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            dc.DETAIL_persos.DeleteOnSubmit(r)
            dc.SubmitChanges()
            MsgBox("Detail Bien supprimer", 64, "Information")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            r.DATE_PAY = CDate(D_Paye.Value.Date)
            dc.SubmitChanges()
            MsgBox("detail a été bien Modifier", 64, "Information")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        vider()
        deatail_P_Load(sender, e)
    End Sub
End Class