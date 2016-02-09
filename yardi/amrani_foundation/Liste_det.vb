Public Class Liste_det
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Button1.Enabled = 1
        TextBox1.Enabled = 0
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Button1.Enabled = 0
        TextBox1.Enabled = 1
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim r = From d In dc.DETAILs Where d.FOURNISSEUR.Contains(TextBox1.Text.Trim) Select d
        Dim t = (From d In dc.DETAILs Where d.FOURNISSEUR.Contains(TextBox1.Text.Trim) Select d.MONTANT_TTC).Sum
        If TextBox1.Text.Trim = "" Then
            DataGrid1.DataSource = Nothing
            Label5.Visible = 0
            Label4.Visible = 0
        Else
            If r IsNot Nothing Then
                DataGrid1.DataSource = r
                Label5.Visible = 1
                Label4.Visible = 1
                Label5.Text = t & "  DHS"
                If t Is Nothing Then
                    Label5.Text = "0 DHS"
                End If
            End If
        End If
    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim r = From d In dc.DETAILs
        Dim t = (From d In dc.DETAILs Select d.MONTANT_TTC).Sum
        If r IsNot Nothing Then
            DataGrid1.DataSource = r
            Label5.Text = t & "  DHS"
            Label5.Visible = 1
            Label4.Visible = 1
        End If
    End Sub
    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        DataGrid1.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGrid1.DataSource = Nothing
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            MsgBox("Date 1 doit etre inferieur de la date 2", MsgBoxStyle.Exclamation, "Verification de la date")
        Else
            Dim r = From d In dc.DETAILs Where DateTimePicker1.Value <= d.DATE_DAQUISTATION And DateTimePicker2.Value >= d.DATE_DAQUISTATION Select d
            Dim t = (From d In dc.DETAILs Where DateTimePicker1.Value <= d.DATE_DAQUISTATION And DateTimePicker2.Value >= d.DATE_DAQUISTATION Select d.MONTANT_TTC).Sum
            If r IsNot Nothing Then
                DataGrid1.DataSource = r
                Label5.Visible = 1
                Label4.Visible = 1
                Label5.Text = t & "  DHS"
                If t Is Nothing Then
                    Label5.Text = "0 DHS"
                End If
            End If
        End If
    End Sub
End Class