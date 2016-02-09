Imports System.Windows.Forms

Public Class frmTwainMain

    Implements IMessageFilter
    Public SD As SaveFileDialog = New SaveFileDialog()

    Private ChildFormNumber As Integer
    Private MsgFilter As Boolean
    Private TW As Twain = New Twain()

#Region "GESTION DE LA FENETRE"

    'Initialisation de la fenetre
    Private Sub frmTwainMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TW.Init(Me.Handle)
    End Sub

    'Fermeture de la fenetre
    Private Sub frmTwainMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'On libère le scanner
        TW.Dispose()
        'On ferme toutes les fenetres filles
        CloseChilds()
    End Sub
    Private Sub mnuMainCloseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainCloseAll.Click
        CloseChilds()
    End Sub
    Private Sub CloseChilds()
        'On ferme toutes les fenetres filles
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    'Fenetre à propos
    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        MsgBox("Thanks for using our product")
    End Sub

#End Region

#Region "GESTION DU SCAN"

    'Sélection de la source
    Private Sub mnuMainSelectSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainSelectSource.Click
        TW.Select()
    End Sub

    'Lancement d'un scan
    Private Sub mnuMainScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainScan.Click
        If (Not MsgFilter) Then
            Me.Enabled = False
            MsgFilter = True
            Application.AddMessageFilter(Me)
        End If
        TW.Acquire()
    End Sub

    'Traitement des messages du scan
    Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage

        Dim TwainCmd As TwainCommand = TW.PassMessage(m)

        Select Case TwainCmd
            Case TwainCommand.Not
                Return False

            Case TwainCommand.CloseRequest
                EndingScan()
                TW.CloseSrc()
            Case TwainCommand.CloseOk
                EndingScan()
                TW.CloseSrc()
            Case TwainCommand.DeviceEvent
            Case TwainCommand.TransferReady
                Dim MyPics As ArrayList = TW.TransferPictures()
                EndingScan()
                TW.CloseSrc()
                ChildFormNumber += 1
                Dim i As Integer
                For i = 0 To MyPics.Count - 1 Step 1
                    Dim img As IntPtr = CType(MyPics(i), IntPtr)
                    Dim NewPic As frmTwainPicture = New frmTwainPicture(img)
                    NewPic.MdiParent = Me
                    Dim iPicNum As Integer = i + 1
                    NewPic.Text = "Scan" + ChildFormNumber.ToString() + "_Pic" + iPicNum.ToString()
                    NewPic.Show()
                Next
        End Select

        Return True

    End Function

    'Fin du scan
    Private Sub EndingScan()
        If (MsgFilter) Then
            Application.RemoveMessageFilter(Me)
            MsgFilter = False
            Me.Enabled = True
            Me.Activate()
        End If
    End Sub

#End Region

#Region "POUR L'ENREGISTREMENT DES FICHIERS"

    Public Function SaveFile(ByRef fChild As frmTwainPicture) As Boolean


        SD.FileName = fChild.Text
        If (Maj_Dossier.t_code.Text = "") Then
            SD.InitialDirectory = "C:\Archive\" + Maj_Dossier.code
        ElseIf (Maj_Dossier.Code_DossierTextBox.Text = "") Then
            SD.InitialDirectory = "C:\Archive\" + Maj_Dossier.t_code.Text
        End If
        'SD.InitialDirectory = "C:\Archive\" + Maj_Dossier.t_code.Text
        SD.Title = "Enregistrer sous..."
        SD.Filter = "Fichier PDF (*.pdf)|*.pdf|Fichier Bitmap (*.bmp)|*.bmp|Fichier TIFF (*.tif)|*.tif|Fichier JPEG (*.jpg)|*.jpg|Fichier PNG (*.png)|*.png|Fichier GIF (*.gif)|*.gif|Tous les fichiers (*.*)|*.*"
        SD.FilterIndex = 1

        If SD.ShowDialog() = DialogResult.OK Then

            Select Case System.IO.Path.GetExtension(SD.FileName).ToUpper
                Case ".PDF"
                    Return SavePDF(SD.FileName)
                Case Else
                    Return cGDIPlus.SaveDIBAs(SD.FileName, fChild.BmpPtr, fChild.PixPtr)
            End Select

        Else
            Return False
        End If

    End Function

    Private Function SavePDF(ByVal FileName As String) As Boolean

        Dim wsPDF As cPDF = New cPDF
        With wsPDF
            'Préparation du fichier et des options
            .PDFTitle = System.IO.Path.GetFileNameWithoutExtension(FileName)
            .PDFFileName = FileName

            .PDFLoadAFM()

            If MessageBox.Show("Ouvrir le fichier après création ?", "OpenTwain.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                .PDFView = True
                .PDFConfirm = False
            Else
                .PDFView = False
                .PDFConfirm = True
            End If

            .PDFWaitForExit = False

            .PDFFormatPage = cPDF.PDFFormatPgStr.FORMAT_A4
            .PDFOrientation = cPDF.PDFOrientationStr.ORIENT_PORTRAIT
            .PDFUnit = cPDF.PDFUnitStr.UNIT_PT
            .PDFZoomMode = cPDF.PDFZoomMd.ZOOM_FULLWIDTH
            .PDFLayoutMode = cPDF.PDFLayoutMd.LAYOUT_DEFAULT
            .PDFUseOutlines = True
            .PDFUseThumbs = False

            'Début de la création
            .PDFBeginDoc()

            Dim iPageCount As Integer = 0

            For Each ChildForm As frmTwainPicture In Me.MdiChildren
                Dim dReso As Double = ChildForm.BMI.biXPelsPerMeter / 39.37

                Dim dRapport As Double = 595.28 / 72

                Dim dWidth As Integer = ChildForm.BMI.biWidth * 72 / dReso
                Dim dHeight As Integer = ChildForm.BMI.biHeight * 72 / dReso

                'On réduit l'image si necessaire
                If dWidth > .PDFPageWidth Then
                    Dim dCoef As Double = dWidth / .PDFPageWidth
                    dWidth = dWidth / dCoef
                    dHeight = dHeight / dCoef
                End If
                If dHeight > .PDFPageHeight Then
                    Dim dCoef As Double = dHeight / .PDFPageHeight
                    dWidth = dWidth * dCoef
                    dHeight = dHeight * dCoef
                End If

                'On centre l'image
                Dim dTop As Integer = (.PDFPageHeight - dHeight) / 2
                Dim dLeft As Integer = (.PDFPageWidth - dWidth) / 2

                'On ajoute l'image
                iPageCount += 1
                If iPageCount <> 1 Then
                    .PDFNewPage()
                End If

                .PDFImage(ChildForm.pScan.Image, CDbl(dLeft), CDbl(dTop), CDbl(dWidth), CDbl(dHeight))

                If iPageCount <> Me.ChildFormNumber Then
                    .PDFEndPage()
                End If

            Next

            .PDFEndDoc()
        End With

    End Function

#End Region

End Class
