Public Class Connexion
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            T_pass.UseSystemPasswordChar = True
        Else
            T_pass.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub T_login_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_login.TextChanged
        Label3.Visible = 0
        If IsNumeric(T_login.Text) Then
            T_login.Clear()
            T_login.Focus()
        Else
            T_pass.Enabled = 1
        End If
        If T_login.Text.Trim = "" Then
            T_pass.Enabled = 0
            B_connexion.Enabled = 0
        End If
    End Sub
    Private Sub T_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_pass.TextChanged
        If T_pass.Text.Trim <> "" Then
            B_connexion.Enabled = 1
            Label3.Visible = 0
        Else
            B_connexion.Enabled = 0
        End If
    End Sub

    Private Sub B_connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_connexion.Click
        If T_login.Text.Trim = "amrani" And T_pass.Text.Trim = "amrani@adam" Then
            Timer1.Start()
            ProgressBar1.Visible = 1
        Else
            Label3.Visible = 1
        End If
    End Sub
    Private Sub B_annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_annuler.Click
        Me.Close()
    End Sub
    Private Sub Connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
        T_login.Text = "amrani"
        T_pass.Text = "amrani@adam"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 10
        ProgressBar1.Maximum = 200
        ProgressBar1.Increment(+10)
        If ProgressBar1.Value = 120 Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\PsyLogic\Desktop\yardi\amrani_foundation\resources\lock.png")
        End If
        If ProgressBar1.Value = 200 Then
            ProgressBar1.Visible = 0
            Timer1.Stop()
            Form1.Show()
            'T_login.Clear()
            'T_pass.Clear()
            Me.Hide()
        End If

    End Sub

End Class