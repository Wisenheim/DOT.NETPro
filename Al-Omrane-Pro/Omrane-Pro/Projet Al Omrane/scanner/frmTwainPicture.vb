Imports System.Runtime.InteropServices

Public Class frmTwainPicture

#Region "APIs"

    <DllImport("gdi32.dll", ExactSpelling:=True)> Friend Shared Function SetDIBitsToDevice(ByVal hdc As IntPtr, ByVal xdst As Integer, ByVal ydst As Integer, ByVal width As Integer, ByVal height As Integer, ByVal xsrc As Integer, ByVal ysrc As Integer, ByVal start As Integer, ByVal lines As Integer, ByVal bitsptr As IntPtr, ByVal bmiptr As IntPtr, ByVal color As Integer) As Integer
    End Function
    <DllImport("gdiplus.dll", ExactSpelling:=True)> Friend Shared Function GdipCreateBitmapFromGdiDib(ByVal bminfo As IntPtr, ByVal pixdat As IntPtr, ByRef image As IntPtr) As Integer
    End Function
    <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalLock(ByVal handle As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalFree(ByVal handle As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> Public Shared Sub OutputDebugString(ByVal outstr As String)
    End Sub

#End Region

#Region "VARIABLES"
    'Privées
    Private BmpRect As Rectangle
    Private DIBhand As IntPtr
    'Public
    Public BMI As BITMAPINFOHEADER
    Public BmpPtr As IntPtr
    Public PixPtr As IntPtr
#End Region

#Region "GESTION DE LA FENETRE"

    'Chargement de la fenêtre
    Public Sub New(ByVal NewDIBhand As IntPtr)
        InitializeComponent()

        BmpRect = New Rectangle(0, 0, 0, 0)
        DIBhand = NewDIBhand
        BmpPtr = GlobalLock(DIBhand)
        PixPtr = GetPixelInfo(BmpPtr)

        With BMI
            SBWidth.Text = .biWidth.ToString()
            SBHeight.Text = .biHeight.ToString()
            Dim iReso As Integer = .biXPelsPerMeter / 39.37
            SBResolution.Text = iReso.ToString
            Dim iSize As Integer = Int(.biSizeImage / 2 ^ 10)
            SBSize.Text = iSize.ToString()
        End With

        pScan.Image = BitmapFromDIB(BmpPtr, PixPtr)

    End Sub

    'Fermeture de la fenetre
    Private Sub frmTwainPicture_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Equals(DIBhand, IntPtr.Zero) Then
            GlobalFree(DIBhand)
            DIBhand = IntPtr.Zero
        End If
    End Sub

    'Récupére un bimtap depuis son Handle
    Public Shared Function BitmapFromDIB(ByVal pDIB As IntPtr, ByVal pPix As IntPtr) As Bitmap

        Dim MI As Reflection.MethodInfo = GetType(Bitmap).GetMethod("FromGDIplus", Reflection.BindingFlags.Static Or Reflection.BindingFlags.NonPublic)

        If MI Is Nothing Then
            Return Nothing
        End If

        Dim pBmp As IntPtr = IntPtr.Zero
        Dim Status As Integer = GdipCreateBitmapFromGdiDib(pDIB, pPix, pBmp)

        If (Status = 0) AndAlso (pBmp <> IntPtr.Zero) Then
            Return DirectCast(MI.Invoke(Nothing, New Object() {pBmp}), Bitmap)
        Else
            Return Nothing
        End If

    End Function

    'Récupère quelques infos sur l'image
    Protected Function GetPixelInfo(ByVal bmpptr As IntPtr) As IntPtr
        BMI = New BITMAPINFOHEADER()
        Marshal.PtrToStructure(bmpptr, BMI)

        BmpRect.X = BmpRect.Y = 0
        BmpRect.Width = BMI.biWidth
        BmpRect.Height = BMI.biHeight

        If (BMI.biSizeImage = 0) Then
            BMI.biSizeImage = Int((((BMI.biWidth * BMI.biBitCount) + 31) & Hex(Not (31))) / 2 ^ 3) * BMI.biHeight
        End If

        Dim p As Integer = BMI.biClrUsed
        If ((p = 0) And (BMI.biBitCount <= 8)) Then
            p = Int(1 * 2 ^ BMI.biBitCount)
        End If
        p = (p * 4) + BMI.biSize + CType(bmpptr.ToInt32, Integer)
        Return New IntPtr(p)
    End Function

#End Region

#Region "GESTION DES MENUS"

    'Pour fermer la fenetre
    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    'Pour enregistrer l'image
    Private Sub mnuSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveAs.Click
        frmTwainMain.SaveFile(Me)
    End Sub

#End Region

#Region "MODE AFFICHAGE IMAGE"

    Private Sub SBMAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBMAuto.Click
        pScan.SizeMode = PictureBoxSizeMode.AutoSize
        SBLMode.Text = "Auto"
    End Sub

    Private Sub SBMCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBMCenter.Click
        pScan.SizeMode = PictureBoxSizeMode.CenterImage
        SBLMode.Text = "Centré"
    End Sub

    Private Sub SBMStretch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBMStretch.Click
        pScan.SizeMode = PictureBoxSizeMode.StretchImage
        SBLMode.Text = "Etiré"
    End Sub

    Private Sub SBMNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBMNormal.Click
        pScan.SizeMode = PictureBoxSizeMode.Normal
        SBLMode.Text = "Normal"
    End Sub

    Private Sub SBMZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBMZoom.Click
        pScan.SizeMode = PictureBoxSizeMode.Zoom
        SBLMode.Text = "Zoom"
    End Sub

#End Region

End Class