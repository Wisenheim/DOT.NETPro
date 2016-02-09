Public Class Articles
    Sub effacer()
        ComboBox2.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TVATextBox.Clear()
        Prix_unitaireTextBox.Clear()
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        effacer()
        TVATextBox.Text = 20
        Button1.Enabled = 1
        ComboBox2.Enabled = 1
        Button3.Enabled = 0
        Button4.Enabled = 0
    End Sub
    Private Sub Articles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim r = From a In dc.ARTICLE Select a.DESIGNATION

        ComboBox2.DataSource = r
        ComboBox2.SelectedIndex = -1
        TVATextBox.Text = 20
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or TextBox4.Text.Trim = "" _
            Or ComboBox3.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1 Or TVATextBox.Text.Trim = "" Or Prix_unitaireTextBox.Text.Trim = "" Then
            MsgBox("(*) Obligatoire : Remplit tous les champs ", MsgBoxStyle.Exclamation, "Attention")
        Else
            Dim a As New ARTICLE
            a.REF_ART = TextBox1.Text
            a.NOM_ART = TextBox3.Text
            a.DESIGNATION = TextBox4.Text
            a.FOURNISSEUR = TextBox2.Text
            a.MODE_PAY = ComboBox3.Text
            a.UNITE = ComboBox4.Text
            a.PRIX_UNIT = Prix_unitaireTextBox.Text
            a.TVA = TVATextBox.Text
            dc.ARTICLE.InsertOnSubmit(a)
            dc.SubmitChanges()
            MsgBox("Article est bien Ajoutè", MsgBoxStyle.Information, "Information")
            effacer()

            Articles_Load(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r = (From a In dc.ARTICLE Where a.REF_ART = CInt(ComboBox2.SelectedValue)).SingleOrDefault
        If r IsNot Nothing Then
            If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or TextBox4.Text.Trim = "" _
           Or ComboBox3.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1 Or TVATextBox.Text.Trim = "" Or Prix_unitaireTextBox.Text.Trim = "" Then
                MsgBox("(*) Obligatiore : Remplit tous les champs ", MsgBoxStyle.Exclamation, "Attention")
            Else
                r.REF_ART = TextBox1.Text
                r.NOM_ART = TextBox3.Text
                r.DESIGNATION = TextBox4.Text
                r.FOURNISSEUR = TextBox2.Text
                r.MODE_PAY = ComboBox3.Text
                r.UNITE = ComboBox4.Text
                r.PRIX_UNIT = Prix_unitaireTextBox.Text
                r.TVA = TVATextBox.Text
                dc.SubmitChanges()
                MsgBox("Article est bien Modifiè" & vbNewLine & vbNewLine & "/!\ Reference Article est non modifable ", MsgBoxStyle.Information, "Information")
                effacer()
            End If
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim r = (From a In dc.ARTICLE Where a.REF_ART = CInt(ComboBox2.SelectedValue)).SingleOrDefault
        If r IsNot Nothing Then
            Try
                Dim answer As MsgBoxResult = MsgBox("Voulez vous vraiment supprimer ce Article !!!!", MsgBoxStyle.YesNoCancel, "Attention !!")
                If answer = MsgBoxResult.Yes Then
                    dc.ARTICLE.DeleteOnSubmit(r)
                    dc.SubmitChanges()
                    MsgBox("Article est bien Supprimè", MsgBoxStyle.Information, "Information")
                    effacer()
                End If
            Catch ex As Exception
                MsgBox("L'Article est dejà pris dans un detail ou plusieurs , Supprimer les detail premierement !!." & vbNewLine & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ComboBox2.Enabled = 1
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim r = From ar In dc.ARTICLE
        '_Select ar.REF_ART And ar.NOM_ART And ar.DESIGNATION And ar.FOURNISSEUR And ar.UNITE.LIB_UNITE _
        'And ar.PRIX_UNIT And ar.MODE_PAY And ar.TVA

        If r IsNot Nothing Then
            DataGrid1.DataSource = r
            Me.Width = 1144
            'Dim s = (From ar In dc.ARTICLE Select ar.PRIX_UNIT).Sum
            'TVATextBox.Text = s
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ComboBox2.Enabled = 1
        Me.Width = 384
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Dim r = (From a In dc.ARTICLE Where a.DESIGNATION = CStr(ComboBox2.SelectedValue)).FirstOrDefault
            If r IsNot Nothing Then
                TextBox1.Text = r.REF_ART
                TextBox3.Text = r.NOM_ART
                TextBox4.Text = r.DESIGNATION
                TextBox2.Text = r.FOURNISSEUR
                ComboBox3.Text = r.MODE_PAY
                ComboBox4.Text = r.UNITE
                Prix_unitaireTextBox.Text = r.PRIX_UNIT
                TVATextBox.Text = r.TVA
                Button3.Enabled = 1
                Button4.Enabled = 1
                Button1.Enabled = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class