Public Class Filter_Crystal_Detail
    Private Sub Filter_Crystal_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        C_D.DataSource = From r In dc.ARTICLE Select r.DESIGNATION
        C_d1.DataSource = From r In dc.ARTICLE Select r.DESIGNATION
        C_D2.DataSource = From r In dc.ARTICLE Select r.DESIGNATION
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r = From v In dc.V_details Where v.FOURNISSEUR = CStr(T_Four1.Text)
        Cry_Detail_article.C_detail1.SetDataSource(r)
        Cry_Detail_article.CrystalReportViewer1.ReportSource = Cry_Detail_article.C_detail1

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim r = From v In dc.V_details Where v.FOURNISSEUR = CStr(T_Four1.Text) And v.DATE_DAQUISTATION = CDate(D1.Value)
        Cry_Detail_article.C_detail1.SetDataSource(r)
        Cry_Detail_article.CrystalReportViewer1.ReportSource = Cry_Detail_article.C_detail1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim r = From v In dc.V_details Where v.FOURNISSEUR = CStr(T_Four1.Text) And v.DATE_DAQUISTATION = CDate(D1.Value) And v.DESIGNATION = CStr(C_D.SelectedValue)
        Cry_Detail_article.C_detail1.SetDataSource(r)
        Cry_Detail_article.CrystalReportViewer1.ReportSource = Cry_Detail_article.C_detail1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r = From v In dc.V_details Where v.DATE_DAQUISTATION = CDate(D2.Value)
        Cry_Detail_article.C_detail1.SetDataSource(r)
        Cry_Detail_article.CrystalReportViewer1.ReportSource = Cry_Detail_article.C_detail1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim r = From v In dc.V_details Where v.DESIGNATION = CStr(C_d1.SelectedValue)
        Cry_Detail_article.C_detail1.SetDataSource(r)
        Cry_Detail_article.CrystalReportViewer1.ReportSource = Cry_Detail_article.C_detail1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim r = From v In dc.V_details Where v.DESIGNATION = CStr(C_D2.SelectedValue) And v.DATE_DAQUISTATION = CDate(D3.Value)
        Cry_Detail_article.C_detail1.SetDataSource(r)
        Cry_Detail_article.CrystalReportViewer1.ReportSource = Cry_Detail_article.C_detail1
    End Sub
End Class