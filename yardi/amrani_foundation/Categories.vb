Public Class Categories
    Sub effacer()
        ID_CATTextBox.Clear()
        LIB_CATEGTextBox.Clear()
        ID_CATTextBox.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        effacer()
        ComboBox1.Enabled = 0
        Button3.Enabled = 0
        Button4.Enabled = 0
        Button1.Enabled = 1
        ComboBox1.Text = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim r = (From c In dc.CATEGORIE Where c.ID_CAT = CInt(ComboBox1.SelectedValue)).SingleOrDefault
        If r IsNot Nothing Then
            ID_CATTextBox.Text = r.ID_CAT
            LIB_CATEGTextBox.Text = r.LIB_CATEG
            Button3.Enabled = 1
            Button4.Enabled = 1
            Button1.Enabled = 0
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ComboBox1.Enabled = 1
    End Sub
    Private Sub Categories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CATEGORIEBindingSource.DataSource = dc.CATEGORIE
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ID_CATTextBox.Text.Trim = "" Or LIB_CATEGTextBox.Text.Trim = "" Then
            MsgBox("(*) Obligatoire : Remplir tous les champs !!", MsgBoxStyle.Exclamation, "Attention")
            ID_CATTextBox.Focus()
        Else
            Dim r = (From g In dc.CATEGORIE Where g.ID_CAT = ID_CATTextBox.Text).SingleOrDefault
            If r IsNot Nothing Then
                MsgBox("/!\ Categorie existe Dejà", MsgBoxStyle.Critical, "Warning")
                ID_CATTextBox.Focus()
            Else
                Dim c As New CATEGORIE
                c.ID_CAT = ID_CATTextBox.Text.Trim
                c.LIB_CATEG = LIB_CATEGTextBox.Text.Trim
                dc.CATEGORIE.InsertOnSubmit(c)
                dc.SubmitChanges()
                MsgBox("Categorie est bien ajoutè ", MsgBoxStyle.Information, "Information")
                effacer()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ID_CATTextBox.Text.Trim = "" Or LIB_CATEGTextBox.Text.Trim = "" Then
            MsgBox("(*) Obligatoire : Remplir tous les champs !!", MsgBoxStyle.Exclamation, "Attention")
            ID_CATTextBox.Focus()
        Else
            Dim r = (From g In dc.CATEGORIE Where g.ID_CAT = CInt(ComboBox1.SelectedValue)).SingleOrDefault
            If r IsNot Nothing Then
                r.ID_CAT = ID_CATTextBox.Text.Trim
                r.LIB_CATEG = LIB_CATEGTextBox.Text.Trim
                dc.SubmitChanges()
                MsgBox("Categorie est bien Modifiè " & vbNewLine & vbNewLine & "/!\ Id categorie est non modifable", MsgBoxStyle.Information, "Information")
                effacer()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim r = (From c In dc.CATEGORIE Where c.ID_CAT = CInt(ComboBox1.SelectedValue)).SingleOrDefault
        If r IsNot Nothing Then
            Dim result As MsgBoxResult = MsgBox("/!\ Attention : Voulez vous vraiement supprimer cet Categorie ??", MsgBoxStyle.YesNoCancel, "Attention")
            If result = MsgBoxResult.Yes Then
                dc.CATEGORIE.DeleteOnSubmit(r)
                dc.SubmitChanges()
                MsgBox("Categorie est bien supprimè ", MsgBoxStyle.Information, "Information")
                effacer()
            End If
        End If
    End Sub
End Class