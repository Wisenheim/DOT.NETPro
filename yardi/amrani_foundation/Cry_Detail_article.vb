Public Class Cry_Detail_article

    Private Sub Cry_Detail_article_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        C_detail1.SetDataSource(dc.V_details)
        CrystalReportViewer1.ReportSource = C_detail1
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Cry_Detail_article_Load(sender, e)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Width = 1148

        Filter_Crystal_Detail.Show()
        Filter_Crystal_Detail.Location = New Point(870, 297)
    End Sub
End Class