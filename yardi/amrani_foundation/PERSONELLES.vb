Public Class PERSONELLES
    Sub effacer()
        ComboBox3.SelectedIndex = -1
        CINTextBox.Clear()
        NOMTextBox.Clear()
        PRENOMTextBox.Clear()
        ADRESSETextBox.Clear()
        TELEPHONETextBox.Clear()
        SALAIRETextBox.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
    Private Sub PERSONELLES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CATEGORIEBindingSource.DataSource = dc.CATEGORIE
        PERSONNELBindingSource.DataSource = dc.PERSONNEL
        ComboBox3.SelectedIndex = -1
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim r = From p In dc.PERSONNEL
        Dim t = (From p In dc.PERSONNEL Select p.SALAIRE).Sum
        DataGrid1.DataSource = r
        Label3.Text = t & "  DHS"
        Me.Width = 977
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        effacer()
        Button1.Enabled = 1
        ComboBox3.Enabled = 0
        Button3.Enabled = 0
        Button4.Enabled = 0
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ComboBox3.Enabled = 1
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ComboBox3.Enabled = 1
        Me.Width = 395
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim r = (From p In dc.PERSONNEL Where p.CIN = CStr(ComboBox3.SelectedValue)).SingleOrDefault
        Try
            If r IsNot Nothing Then
                CINTextBox.Text = r.CIN
                NOMTextBox.Text = r.NOM
                PRENOMTextBox.Text = r.PRENOM
                ADRESSETextBox.Text = r.ADRESSE
                TELEPHONETextBox.Text = r.TELEPHONE
                ComboBox1.SelectedValue = CInt(r.ID_CATEG)
                ComboBox2.Text = r.MODE_PAY
                SALAIRETextBox.Text = r.SALAIRE
                TextBox1.Text = r.Code_cheque
                Button3.Enabled = 1
                Button4.Enabled = 1
                Button1.Enabled = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r = (From p In dc.PERSONNEL Where p.CIN = CStr(ComboBox3.SelectedValue)).SingleOrDefault

        If r IsNot Nothing Then
            If CINTextBox.Text.Trim = "" Or NOMTextBox.Text.Trim = "" Or PRENOMTextBox.Text.Trim = "" Or ADRESSETextBox.Text.Trim = "" _
                Or TELEPHONETextBox.Text.Trim = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or SALAIRETextBox.Text.Trim = "" Then
                MsgBox("(*) Obligatiore : Remplit tous les champs ", MsgBoxStyle.Exclamation, "Attention")
            Else
                r.NOM = NOMTextBox.Text.Trim
                r.PRENOM = PRENOMTextBox.Text.Trim
                r.ADRESSE = ADRESSETextBox.Text.Trim
                r.TELEPHONE = TELEPHONETextBox.Text.Trim
                r.ID_CATEG = ComboBox1.SelectedValue
                r.MODE_PAY = ComboBox2.Text
                r.SALAIRE = SALAIRETextBox.Text.Trim
                dc.SubmitChanges()
                MsgBox("Personnel est bien Modifiè" & vbNewLine & vbNewLine & "/!\ CIN est non modifable ", MsgBoxStyle.Information, "Information")
                effacer()
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CINTextBox.Text.Trim = "" Or NOMTextBox.Text.Trim = "" Or PRENOMTextBox.Text.Trim = "" Or ADRESSETextBox.Text.Trim = "" _
               Or TELEPHONETextBox.Text.Trim = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or SALAIRETextBox.Text.Trim = "" Then
            MsgBox("(*) Obligatiore : Remplit tous les champs ", MsgBoxStyle.Exclamation, "Attention")
        Else
            If ComboBox2.Text = "CHEQUE" And TextBox1.Text.Trim = "" Then
                MsgBox("(*) Obligatiore : Remplit le champ de CODE CHEQUE !! ", MsgBoxStyle.Exclamation, "Attention")
                TextBox1.Focus()
           
            Else
                Dim r = (From p In dc.PERSONNEL Where p.CIN = CStr(CINTextBox.Text.Trim)).SingleOrDefault
                If r IsNot Nothing Then
                    MsgBox("Personnel existe Dejà " & vbNewLine & "Ressayer a nouveau !!", MsgBoxStyle.Exclamation, "Attention")
                    CINTextBox.Focus()
                Else
                    If ComboBox2.Text = "CASH" Then
                        TextBox1.Text = "[NO N° for (CASH)]"
                    End If
                    Dim p As New PERSONNEL
                    p.CIN = CINTextBox.Text.Trim
                    p.NOM = NOMTextBox.Text.Trim
                    p.PRENOM = PRENOMTextBox.Text.Trim
                    p.ADRESSE = ADRESSETextBox.Text.Trim
                    p.TELEPHONE = TELEPHONETextBox.Text.Trim
                    p.ID_CATEG = ComboBox1.SelectedValue
                    p.MODE_PAY = ComboBox2.Text
                    p.SALAIRE = SALAIRETextBox.Text.Trim
                    p.Code_cheque = TextBox1.Text.Trim
                    dc.PERSONNEL.InsertOnSubmit(p)
                    dc.SubmitChanges()
                    MsgBox("Personnel est bien ajoutè ", MsgBoxStyle.Information, "Information")
                    effacer()
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim r = (From p In dc.PERSONNEL Where p.CIN = CStr(ComboBox3.SelectedValue)).SingleOrDefault
        If r IsNot Nothing Then
            Try
                Dim answer As MsgBoxResult = MsgBox("Voulez vous vraiment supprimer ce Article !!!!", MsgBoxStyle.YesNoCancel, "Attention !!")
                If answer = MsgBoxResult.Yes Then
                    dc.PERSONNEL.DeleteOnSubmit(r)
                    dc.SubmitChanges()
                    MsgBox("Personnel est bien Supprimè", MsgBoxStyle.Information, "Information")
                    effacer()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "CHEQUE" Then
            TextBox1.Visible = 1
            LinkLabel4.Visible = 1
        Else
            TextBox1.Clear()
            TextBox1.Visible = 0
            LinkLabel4.Visible = 0
        End If
    End Sub
End Class