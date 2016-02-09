Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Public Class cGDIPlus

#Region "APIs"
    <DllImport("gdiplus.dll", ExactSpelling:=True)> Friend Shared Function GdipCreateBitmapFromGdiDib(ByVal bminfo As IntPtr, ByVal pixdat As IntPtr, ByRef image As IntPtr) As Integer
    End Function
    <DllImport("gdiplus.dll", ExactSpelling:=True, CharSet:=CharSet.Unicode)> Friend Shared Function GdipSaveImageToFile(ByVal image As IntPtr, ByVal filename As String, <[In]()> ByRef clsid As Guid, ByVal encparams As IntPtr) As Integer
    End Function
    <DllImport("gdiplus.dll", ExactSpelling:=True)> Friend Shared Function GdipDisposeImage(ByVal image As IntPtr) As Integer
    End Function
#End Region

#Region "FONCTIONS ET PROCEDURES"

    Private Shared codecs() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders()

    Private Shared Function GetCodecClsid(ByVal filename As String, ByRef clsid As Guid) As Boolean
        clsid = Guid.Empty
        Dim ext As String = Path.GetExtension(filename)
        'Checking string for null
        If IsNothing(ext) Then
            Return False
        End If
        ext = "*" + ext.ToUpper()
        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If (codec.FilenameExtension.IndexOf(ext) >= 0) Then
                clsid = codec.Clsid
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Function SaveDIBAs(ByVal FileName As String, ByVal BMinfo As IntPtr, ByVal PixDat As IntPtr) As Boolean

        Dim CLSID As Guid
        If Not GetCodecClsid(FileName, CLSID) Then
            MessageBox.Show("Format de fichier inconnu pour l'extension " + Path.GetExtension(FileName), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Dim IMG As IntPtr = IntPtr.Zero
        Dim st As Integer = GdipCreateBitmapFromGdiDib(BMinfo, PixDat, IMG)
        If (st <> 0) Or (Equals(IMG, IntPtr.Zero)) Then
            Return False
        End If

        st = GdipSaveImageToFile(IMG, FileName, CLSID, IntPtr.Zero)
        GdipDisposeImage(IMG)
        Return st = 0

    End Function

#End Region

End Class

<StructLayout(LayoutKind.Sequential, Pack:=2)> Public Class BITMAPINFOHEADER
    Public biSize As Integer
    Public biWidth As Integer
    Public biHeight As Integer
    Public biPlanes As Short
    Public biBitCount As Short
    Public biCompression As Integer
    Public biSizeImage As Integer
    Public biXPelsPerMeter As Integer
    Public biYPelsPerMeter As Integer
    Public biClrUsed As Integer
    Public biClrImportant As Integer
End Class

<StructLayout(LayoutKind.Sequential, Pack:=2)> Public Class RGBQUAD
    Public rgbBlue As Byte
    Public rgbGreen As Byte
    Public rgbRed As Byte
    Public rgbReserved As Byte
End Class

<StructLayout(LayoutKind.Sequential, Pack:=2)> Public Class BITMAPINFO2
    Public bmiHeader As BITMAPINFOHEADER
    Public bmiColors(1) As RGBQUAD
End Class

<StructLayout(LayoutKind.Sequential, Pack:=2)> Public Class BITMAPINFO8
    Public bmiHeader As BITMAPINFOHEADER
    Public bmiColors(255) As RGBQUAD
End Class
