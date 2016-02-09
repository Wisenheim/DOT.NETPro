Public Class DETAILS
    Dim rech As DETAIL
    Sub effacer()
        Date_dacquistationDateTimePicker.Value = Now
        'ComboBox1.Text = Nothing
        TextBox1.Clear()
        TextBox4.Clear()
        'ComboBox5.Text = Nothing
        Prix_unitaireTextBox.Clear()
        TVATextBox.Clear()
        QuantiteTextBox.Clear()
        Montant_htTextBox.Clear()
        Montant_ttcTextBox.Clear()
    End Sub

    Private Sub DETAILS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = From det In dc.DETAILs Select det.ID
        ComboBox5.DataSource = From a In dc.ARTICLE Select a.REF_ART
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or TextBox1.Text.Trim = "" Or TextBox4.Text.Trim = "" Or ComboBox5.SelectedIndex = -1 _
            Or Prix_unitaireTextBox.Text.Trim = "" Or QuantiteTextBox.Text.Trim = "" Or TVATextBox.Text.Trim = "" Then
            MsgBox("Remplir tous les champs est obligatiore !!!")
        Else
            Try
                Dim d As New DETAIL
                d.ID = T_ID.Text
                d.DATE_DAQUISTATION = Date_dacquistationDateTimePicker.Value
                d.FOURNISSEUR = TextBox3.Text
                d.REF_ART = CStr(ComboBox5.SelectedValue)
                d.NOM_ART = Nothing
                d.PRIX_UNITAIRE = CType(Prix_unitaireTextBox.Text, Single)
                d.QUANTITE = CInt(QuantiteTextBox.Text)
                d.TVA = CType(TVATextBox.Text, Single)
                d.MONTANT_HT = CType(Montant_htTextBox.Text, Single)
                d.MONTANT_TTC = CType(Montant_ttcTextBox.Text, Single)
                d.DESIGNATION = TextBox2.Text
                d.MODE_PAY = TextBox1.Text
                d.UNITEE = TextBox4.Text
                dc.DETAILs.InsertOnSubmit(d)
                dc.SubmitChanges()
                MsgBox("Detail est bien Ajoutè", MsgBoxStyle.Information, "Information")
                effacer()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub



    Private Sub Prix_unitaireTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prix_unitaireTextBox.TextChanged
        If Prix_unitaireTextBox.Text.Trim = "" Then
            Montant_htTextBox.Clear()
        Else
            If QuantiteTextBox.Text.Trim <> "" Then
                Montant_htTextBox.Text = CInt(QuantiteTextBox.Text) * CType(Prix_unitaireTextBox.Text, Single)
                Montant_ttcTextBox.Text = CType(Montant_htTextBox.Text, Single) + ((CInt(TVATextBox.Text) / 100) * CType(Montant_htTextBox.Text, Single))
            End If
        End If
    End Sub



    Private Sub QuantiteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantiteTextBox.TextChanged
        If QuantiteTextBox.Text.Trim = "" Or Prix_unitaireTextBox.Text = "" Then
            Montant_htTextBox.Clear()
        Else
            Montant_htTextBox.Text = CInt(QuantiteTextBox.Text) * CType(Prix_unitaireTextBox.Text, Single)
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        effacer()
        Button3.Enabled = 0
        Button4.Enabled = 0
        Button1.Enabled = 0
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Button3.Enabled = 0
        Button4.Enabled = 0
    End Sub


    'Supprimer Detail
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Voulez vous vraiment supprimer ce Detail !!!!", MsgBoxStyle.YesNoCancel, "Attention !!") = MsgBoxResult.Yes Then
            Try
                dc.DETAILs.DeleteOnSubmit(rech)
                dc.SubmitChanges()
                MsgBox("Detail est bien Supprimè", MsgBoxStyle.Information, "Information")
                effacer()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    ' Modifier Detail
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            rech.DATE_DAQUISTATION = Date_dacquistationDateTimePicker.Value
            rech.REF_ART = CInt(ComboBox5.SelectedValue)
            rech.QUANTITE = CInt(QuantiteTextBox.Text)
            rech.MONTANT_HT = CType(Montant_htTextBox.Text, Single)
            rech.MONTANT_TTC = CType(Montant_ttcTextBox.Text, Single)
            dc.SubmitChanges()
            MsgBox("Detail est bien Modifiè", MsgBoxStyle.Information, "Information")
            effacer()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub TVATextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TVATextBox.TextChanged
        If Montant_htTextBox.Text <> Nothing Then
            Montant_ttcTextBox.Text = CType(Montant_htTextBox.Text, Single) + ((CInt(TVATextBox.Text) / 100) * CType(Montant_htTextBox.Text, Single))
        End If

    End Sub
    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim r = (From a In dc.DETAILs Where a.REF_ART = CInt(ComboBox5.SelectedValue)).FirstOrDefault
        Dim r2 = (From dd In dc.ARTICLE Where dd.REF_ART = CInt(ComboBox5.SelectedValue)).FirstOrDefault
        If r Is Nothing Then
            TextBox2.Text = r2.DESIGNATION
            TextBox3.Text = r2.FOURNISSEUR
            TextBox1.Text = r2.MODE_PAY
            TextBox4.Text = r2.PRIX_UNIT
            Prix_unitaireTextBox.Text = r2.PRIX_UNIT
            TVATextBox.Text = r2.TVA
        Else
            TextBox2.Text = r2.DESIGNATION
            TextBox3.Text = r2.FOURNISSEUR
            TextBox1.Text = r2.MODE_PAY
            TextBox4.Text = r2.PRIX_UNIT
            Prix_unitaireTextBox.Text = r2.PRIX_UNIT
            TVATextBox.Text = r2.TVA

        End If
    End Sub
    Private Sub Montant_htTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Montant_htTextBox.TextChanged
        If Montant_htTextBox.Text.Trim <> "" And TVATextBox.Text.Trim <> "" Then
            Montant_ttcTextBox.Text = CType(Montant_htTextBox.Text, Single) + ((CInt(TVATextBox.Text) / 100) * CType(Montant_htTextBox.Text, Single))
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        rech = (From d In dc.DETAILs Where d.ID = CStr(ComboBox1.SelectedItem)).FirstOrDefault
        If rech IsNot Nothing Then
            TextBox2.Text = rech.DESIGNATION
            TextBox3.Text = rech.FOURNISSEUR
            TextBox1.Text = rech.MODE_PAY
            TextBox4.Text = rech.UNITEE
            TVATextBox.Text = rech.TVA
            Montant_htTextBox.Text = rech.MONTANT_HT
            Montant_ttcTextBox.Text = rech.MONTANT_TTC
            QuantiteTextBox.Text = rech.QUANTITE
            Date_dacquistationDateTimePicker.Value = rech.DATE_DAQUISTATION
            Prix_unitaireTextBox.Text = rech.PRIX_UNITAIRE
            Button3.Enabled = 1
            Button4.Enabled = 1
            Button1.Enabled = 0
        End If

    End Sub
End Class