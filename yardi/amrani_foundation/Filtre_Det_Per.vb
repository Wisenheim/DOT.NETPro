Public Class Filtre_Det_Per

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r = From v In dc.V_Pers Where v.CIN = CStr(TCIn.Text)
        Cry_Det_per.C_Perso1.SetDataSource(r)
        Cry_Det_per.CrystalReportViewer1.ReportSource = Cry_Det_per.C_Perso1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim r = From v In dc.V_Pers Where v.DATE_PAY = CStr(D1.Value)
        Cry_Det_per.C_Perso1.SetDataSource(r)
        Cry_Det_per.CrystalReportViewer1.ReportSource = Cry_Det_per.C_Perso1
    End Sub
End Class