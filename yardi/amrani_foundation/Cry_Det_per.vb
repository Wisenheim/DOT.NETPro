Public Class Cry_Det_per
    Private Sub Cry_Det_per_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        C_Perso1.SetDataSource(dc.V_Pers)
        CrystalReportViewer1.ReportSource = C_Perso1
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Filtre_Det_Per.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Cry_Det_per_Load(sender, e)
    End Sub


End Class