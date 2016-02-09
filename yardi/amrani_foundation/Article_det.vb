Public Class Article_det
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            DateTimePicker1.Enabled = 1
        Else
            DateTimePicker1.Enabled = 0
        End If
    End Sub
    Private Sub Article_det_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ARTICLEBindingSource.DataSource = dc.ARTICLE
        ComboBox1.SelectedIndex = -1
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If CheckBox1.Checked = False Then
            Dim r = From ar In dc.DETAILs Where ar.REF_ART = CInt(ComboBox1.SelectedValue) Select ar
            Dim t = (From s In dc.DETAILs Where s.REF_ART = CInt(ComboBox1.SelectedValue) Select s.MONTANT_TTC).Sum
            If r IsNot Nothing Then
                DataGridView1.DataSource = r
                Label5.Text = t & "  DHS"
            Else
                Label5.Text = "0 DHS"
            End If
        Else
            Dim r = From ar In dc.DETAILs Where ar.REF_ART = CInt(ComboBox1.SelectedValue) And ar.DATE_DAQUISTATION = DateTimePicker1.Value Select ar
            Dim t = (From s In dc.DETAILs Where s.REF_ART = CInt(ComboBox1.SelectedValue) And s.DATE_DAQUISTATION = DateTimePicker1.Value Select s.MONTANT_TTC).Sum
            If r IsNot Nothing Then
                DataGridView1.DataSource = r
                Label5.Text = t & "  DHS"
            Else
                Label5.Text = "0 DHS"
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Trim <> "" Then
            Dim r = From d In dc.DETAILs Where d.FOURNISSEUR.Contains(TextBox1.Text) Select d.FOURNISSEUR
            ListBox1.DataSource = r
            ListBox1.Visible = True
        Else
            Label5.Visible = 0
            Label4.Visible = 0
            ListBox1.Visible = 0
            ListBox1.Items.Clear()
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If CheckBox2.Checked = False Then
            Dim r = From d In dc.DETAILs Where d.FOURNISSEUR = CStr(ListBox1.SelectedItem) Select d
            Dim t = (From s In dc.DETAILs Where s.FOURNISSEUR = CStr(ListBox1.SelectedItem) Select s.MONTANT_TTC).Sum
            If r IsNot Nothing Then
                DataGridView1.DataSource = r
                Label5.Visible = 1
                Label4.Visible = 1
                Label5.Text = t & "  DHS"
            Else
                Label5.Text = "0 DHS"
            End If
        Else
            Dim r = From d In dc.DETAILs Where d.FOURNISSEUR = CStr(ListBox1.SelectedItem) And d.DATE_DAQUISTATION = DateTimePicker2.Value Select d
            Dim t = (From s In dc.DETAILs Where s.FOURNISSEUR = CStr(ListBox1.SelectedItem) And s.DATE_DAQUISTATION = DateTimePicker2.Value Select s.MONTANT_TTC).Sum
            If r IsNot Nothing Then
                DataGridView1.DataSource = r
                Label5.Visible = 1
                Label4.Visible = 1
                Label5.Text = t & "  DHS"
            Else
                Label5.Text = "0 DHS"
            End If
        End If

    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked Then
            DateTimePicker2.Enabled = 1
        Else
            DateTimePicker2.Enabled = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox1.Enabled = 1
            CheckBox1.Enabled = 1
            DateTimePicker1.Enabled = 1
            CheckBox2.Enabled = 0
            DateTimePicker2.Enabled = 0
            TextBox1.Enabled = 0
        ElseIf RadioButton2.Checked Then
            CheckBox2.Enabled = 1
            DateTimePicker2.Enabled = 1
            TextBox1.Enabled = 1
            ComboBox1.Enabled = 0
            CheckBox1.Enabled = 0
            DateTimePicker1.Enabled = 0
        Else


        End If
    End Sub
End Class