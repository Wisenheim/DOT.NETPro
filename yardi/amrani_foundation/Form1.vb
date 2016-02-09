Public Class Form1
    Private Sub ArticlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticlesToolStripMenuItem.Click
        Articles.Show()
    End Sub
    Private Sub PersonnelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonnelToolStripMenuItem.Click
        PERSONELLES.Show()
    End Sub
    Private Sub ListesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListesDetailsToolStripMenuItem.Click
        Liste_det.Show()
    End Sub
    Private Sub CategoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriesToolStripMenuItem.Click
        Categories.Show()
    End Sub
    Private Sub DeconnexionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeconnexionToolStripMenuItem.Click
        Me.Close()
        Connexion.Show()
        Connexion.BackgroundImage = System.Drawing.Image.FromFile("D:\ahmed amrani\amrani_foundation\amrani_foundation\resources\1368110654_preferences-desktop-cryptography.png")
        Connexion.ProgressBar1.Value = 20
        Connexion.Timer1.Interval = 200
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer = 0
        Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
        x1 = 12
        y1 = 66
        x2 = 257
        y2 = 66
        x3 = 543
        y3 = 66
        x4 = 849
        y4 = 66
        ProgressBar1.Minimum = 10
        ProgressBar1.Maximum = 400
        ProgressBar1.Increment(+2)
        If ProgressBar1.Value = 20 Then
            Label1.Location = New Point(x1 + ProgressBar1.Value, y1 + ProgressBar1.Value)
            Label2.Location = New Point(x2 + ProgressBar1.Value, y2 + ProgressBar1.Value)
            Label3.Location = New Point(x3 - ProgressBar1.Value, y3 + ProgressBar1.Value)
            Label4.Location = New Point(x4 - ProgressBar1.Value, y4 + ProgressBar1.Value)
        ElseIf ProgressBar1.Value = 60 Then
            Label1.Location = New Point(x1 + ProgressBar1.Value, y1 + ProgressBar1.Value)
            Label2.Location = New Point(x2 + ProgressBar1.Value, y2 + ProgressBar1.Value)
            Label3.Location = New Point(x3 - ProgressBar1.Value, y3 + ProgressBar1.Value)
            Label4.Location = New Point(x4 - ProgressBar1.Value, y4 + ProgressBar1.Value)
        ElseIf ProgressBar1.Value = 100 Then
            Label1.Location = New Point(x1 + ProgressBar1.Value, y1 + ProgressBar1.Value)
            Label2.Location = New Point(x2 + ProgressBar1.Value, y2 + ProgressBar1.Value)
            Label3.Location = New Point(x3 - ProgressBar1.Value, y3 + ProgressBar1.Value)
            Label4.Location = New Point(x4 - ProgressBar1.Value, y4 + ProgressBar1.Value)
        ElseIf ProgressBar1.Value = 140 Then
            Label1.Location = New Point(x1 + ProgressBar1.Value, y1 + ProgressBar1.Value)
            Label2.Location = New Point(x2 + ProgressBar1.Value, y2 + ProgressBar1.Value)
            Label3.Location = New Point(x3 - ProgressBar1.Value, y3 + ProgressBar1.Value)
            Label4.Location = New Point(x4 - ProgressBar1.Value, y4 + ProgressBar1.Value)
        ElseIf ProgressBar1.Value = 180 Then
            Label1.Location = New Point(x1 + ProgressBar1.Value, y1 + ProgressBar1.Value)
            Label2.Location = New Point(x2 + ProgressBar1.Value, y2 + ProgressBar1.Value)
            Label3.Location = New Point(x3 - ProgressBar1.Value, y3 + ProgressBar1.Value)
            Label4.Location = New Point(x4 - ProgressBar1.Value, y4 + ProgressBar1.Value)
        ElseIf ProgressBar1.Value = 240 Then
            Label1.Location = New Point(x1 + ProgressBar1.Value, y1 + ProgressBar1.Value)
            Label2.Location = New Point(x2 + ProgressBar1.Value, y2 + ProgressBar1.Value)
            Label3.Location = New Point(x3 - ProgressBar1.Value, y3 + ProgressBar1.Value)
            Label4.Location = New Point(x4 - ProgressBar1.Value, y4 + ProgressBar1.Value)
        End If
        If ProgressBar1.Value = 300 Then
            Timer1.Stop()
            Label1.Location = New Point(232, 391)
            Label2.Location = New Point(355, 391)
            Label3.Location = New Point(482, 391)
            Label4.Location = New Point(602, 391)
        End If
    End Sub
    Private Sub RESTARTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESTARTToolStripMenuItem.Click
        Application.Restart()
    End Sub
    Private Sub SHUTDOWNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHUTDOWNToolStripMenuItem.Click
        End
    End Sub
    Private Sub ArticleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Article_det.Show()
    End Sub

    Private Sub DetailsArticleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsArticleToolStripMenuItem.Click
        DETAILS.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        Cry_Detail_article.Show()
    End Sub

    Private Sub PersonnelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonnelToolStripMenuItem1.Click
        Cry_Det_per.Show()
    End Sub

    Private Sub DetailsPersonellesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsPersonellesToolStripMenuItem.Click
        deatail_P.Show()
    End Sub
End Class
