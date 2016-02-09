Imports System.Runtime.InteropServices


Public Enum TwainCommand
    [Not] = -1
    Null = 0
    TransferReady = 1
    CloseRequest = 2
    CloseOk = 3
    DeviceEvent = 4
End Enum

Public Class Twain

#Region "STRUCTURES"

    <StructLayout(LayoutKind.Sequential, Pack:=4)> Friend Structure WINMSG_S
        Public hWnd As IntPtr
        Public Message As Integer
        Public wParam As IntPtr
        Public lParam As IntPtr
        Public Time As Integer
        Public X As Integer
        Public Y As Integer
    End Structure

#End Region

#Region "VARIABLES"
    Private hWnd As IntPtr
    Private AppId As TwIdentity
    Private SrcDS As TwIdentity
    Private EvtMsg As TwEvent
    Private WinMsg_m As WINMSG_S
#End Region

#Region "APIs"
    'TWAIN32
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSMparent(<[In](), Out()> ByVal origin As TwIdentity, ByVal zeroptr As IntPtr, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByRef refptr As IntPtr) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSMident(<[In](), Out()> ByVal origin As TwIdentity, ByVal zeroptr As IntPtr, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal idds As TwIdentity) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSMstatus(<[In](), Out()> ByVal origin As TwIdentity, ByVal zeroptr As IntPtr, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal dsmstat As TwStatus) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSuserif(<[In](), Out()> ByVal origin As TwIdentity, <[In](), Out()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByVal guif As TwUserInterface) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSevent(<[In](), Out()> ByVal origin As TwIdentity, <[In](), Out()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByRef evt As TwEvent) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSstatus(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal dsmstat As TwStatus) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DScap(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal capa As TwCapability) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSiinf(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal imginf As TwImageInfo) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSixfer(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByRef hbitmap As IntPtr) As TwRC
    End Function
    <DllImport("twain_32.dll", EntryPoint:="#1")> Private Shared Function DSpxfer(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal pxfr As TwPendingXfers) As TwRC
    End Function
    'KERNEL32
    <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalAlloc(ByVal flags As Integer, ByVal size As Integer) As IntPtr
    End Function
    <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalLock(ByVal handle As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalUnlock(ByVal handle As IntPtr) As Boolean
    End Function
    <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalFree(ByVal handle As IntPtr) As IntPtr
    End Function
    'USER32
    <DllImport("user32.dll", ExactSpelling:=True)> Private Shared Function GetMessagePos() As Integer
    End Function
    <DllImport("user32.dll", ExactSpelling:=True)> Private Shared Function GetMessageTime() As Integer
    End Function
    'GDI32
    <DllImport("gdi32.dll", ExactSpelling:=True)> Private Shared Function GetDeviceCaps(ByVal hDC As IntPtr, ByVal nIndex As Integer) As Integer
    End Function
    <DllImport("gdi32.dll", CharSet:=CharSet.Auto)> Private Shared Function CreateDC(ByVal szdriver As String, ByVal szdevice As String, ByVal szoutput As String, ByVal devmode As IntPtr) As IntPtr
    End Function
    <DllImport("gdi32.dll", ExactSpelling:=True)> Private Shared Function DeleteDC(ByVal hdc As IntPtr) As Boolean
    End Function
#End Region

#Region "CONSTANTES"
    Private Const CountryUSA As Short = 1
    Private Const LanguageUSA As Short = 13
#End Region

#Region "FONCTIONS ET PROCEDURES"

    Public Sub New()
        AppId = New TwIdentity()
        With AppId
            .Id = IntPtr.Zero
            .Version.MajorNum = 1
            .Version.MinorNum = 1
            .Version.Language = LanguageUSA
            .Version.Country = CountryUSA
            .Version.Info = "Hack 1"
            .ProtocolMajor = TwProtocol.Major
            .ProtocolMinor = TwProtocol.Minor
            .SupportedGroups = CType(TwDG.Image Or TwDG.Control, Integer)
            .Manufacturer = "NETMaster"
            .ProductFamily = "Freeware"
            .ProductName = "Hack"
        End With

        SrcDS = New TwIdentity()
        SrcDS.Id = IntPtr.Zero

        EvtMsg.EventPtr = Marshal.AllocHGlobal(Marshal.SizeOf(WinMsg_m))
    End Sub

    Public Sub Dispose()
        Marshal.FreeHGlobal(EvtMsg.EventPtr)
    End Sub

    Protected Overrides Sub Finalize()
        Try
            Marshal.FreeHGlobal(EvtMsg.EventPtr)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Init(ByVal hwndp As IntPtr)
        Finish()
        Dim rc As TwRC = DSMparent(AppId, IntPtr.Zero, TwDG.Control, TwDAT.Parent, TwMSG.OpenDSM, hwndp)
        If (rc = TwRC.Success) Then
            rc = DSMident(AppId, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.GetDefault, SrcDS)
            If (rc = TwRC.Success) Then
                hWnd = hwndp
            Else
                rc = DSMparent(AppId, IntPtr.Zero, TwDG.Control, TwDAT.Parent, TwMSG.CloseDSM, hwndp)
            End If
        End If
    End Sub

    Public Sub [Select]()
        Dim rc As TwRC
        CloseSrc()
        If Equals(AppId.Id, IntPtr.Zero) = True Then
            Init(hWnd)
            If Equals(AppId.Id, IntPtr.Zero) = True Then
                Return
            End If
        End If
        rc = DSMident(AppId, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.UserSelect, SrcDS)
    End Sub

    Public Sub Acquire()
        Dim rc As TwRC
        CloseSrc()
        If Equals(AppId.Id, IntPtr.Zero) = True Then
            Init(hWnd)
            If Equals(AppId.Id, IntPtr.Zero) = True Then
                Return
            End If
        End If

        rc = DSMident(AppId, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.OpenDS, SrcDS)
        If (rc <> TwRC.Success) Then
            Return
        End If

        Dim cap As TwCapability = New TwCapability(TwCap.XferCount, 1)
        rc = DScap(AppId, SrcDS, TwDG.Control, TwDAT.Capability, TwMSG.Set, cap)
        If (rc <> TwRC.Success) Then
            CloseSrc()
            Return
        End If

        Dim guif As TwUserInterface = New TwUserInterface()
        guif.ShowUI = 1
        guif.ModalUI = 1
        guif.ParentHand = hWnd
        rc = DSuserif(AppId, SrcDS, TwDG.Control, TwDAT.UserInterface, TwMSG.EnableDS, guif)
        If (rc <> TwRC.Success) Then
            CloseSrc()
            Return
        End If
    End Sub

    Public Function TransferPictures() As ArrayList
        Dim pics As ArrayList = New ArrayList()
        If Equals(SrcDS.Id, IntPtr.Zero) Then
            Return pics
        End If

        Dim rc As TwRC
        Dim hbitmap As IntPtr = IntPtr.Zero
        Dim pxfr As TwPendingXfers = New TwPendingXfers()

        Do
            pxfr.Count = 0
            hbitmap = IntPtr.Zero

            Dim iinf As TwImageInfo = New TwImageInfo()
            rc = DSiinf(AppId, SrcDS, TwDG.Image, TwDAT.ImageInfo, TwMSG.Get, iinf)
            If (rc <> TwRC.Success) Then
                CloseSrc()
                Return pics
            End If

            rc = DSixfer(AppId, SrcDS, TwDG.Image, TwDAT.ImageNativeXfer, TwMSG.Get, hbitmap)
            If (rc <> TwRC.XferDone) Then
                CloseSrc()
                Return pics
            End If

            rc = DSpxfer(AppId, SrcDS, TwDG.Control, TwDAT.PendingXfers, TwMSG.EndXfer, pxfr)
            If (rc <> TwRC.Success) Then
                CloseSrc()
                Return pics
            End If

            pics.Add(hbitmap)
        Loop While (pxfr.Count <> 0)

        rc = DSpxfer(AppId, SrcDS, TwDG.Control, TwDAT.PendingXfers, TwMSG.Reset, pxfr)
        Return pics
    End Function

    Public Function PassMessage(ByVal m As Message) As TwainCommand

        If Equals(SrcDS.Id, IntPtr.Zero) Then
            Return TwainCommand.Not
        End If

        Dim pos As Integer = GetMessagePos()

        WinMsg_m.hWnd = m.HWnd
        WinMsg_m.Message = m.Msg
        WinMsg_m.wParam = m.WParam
        WinMsg_m.lParam = m.LParam
        WinMsg_m.Time = GetMessageTime()
        WinMsg_m.X = pos
        WinMsg_m.Y = Int(pos / 2 ^ 16)

        Marshal.StructureToPtr(WinMsg_m, EvtMsg.EventPtr, False)
        EvtMsg.Message = 0

        Dim rc As TwRC = DSevent(AppId, SrcDS, TwDG.Control, TwDAT.Event, TwMSG.ProcessEvent, EvtMsg)
        If (rc = TwRC.NotDSEvent) Then
            Return TwainCommand.Not
        End If

        Select Case EvtMsg.Message
            Case TwMSG.XFerReady
                Return TwainCommand.TransferReady
            Case TwMSG.CloseDSReq
                Return TwainCommand.CloseRequest
            Case TwMSG.CloseDSOK
                Return TwainCommand.CloseOk
            Case TwMSG.DeviceEvent
                Return TwainCommand.DeviceEvent
            Case Else
                Return TwainCommand.Null
        End Select

    End Function

    Public Sub CloseSrc()
        Dim rc As TwRC
        If Not Equals(SrcDS.Id, IntPtr.Zero) Then
            Dim guif As TwUserInterface = New TwUserInterface()
            rc = DSuserif(AppId, SrcDS, TwDG.Control, TwDAT.UserInterface, TwMSG.DisableDS, guif)
            rc = DSMident(AppId, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.CloseDS, SrcDS)
        End If
    End Sub

    Public Sub Finish()
        Dim rc As TwRC
        CloseSrc()
        If Not Equals(AppId.Id, IntPtr.Zero) Then
            rc = DSMparent(AppId, IntPtr.Zero, TwDG.Control, TwDAT.Parent, TwMSG.CloseDSM, hWnd)
        End If
        AppId.Id = IntPtr.Zero
    End Sub

    Public Shared ReadOnly Property ScreenBitDepth() As Integer
        Get
            Dim screenDC As IntPtr = CreateDC("DISPLAY", Nothing, Nothing, IntPtr.Zero)
            Dim bitDepth As Integer = GetDeviceCaps(screenDC, 12)
            bitDepth *= GetDeviceCaps(screenDC, 14)
            DeleteDC(screenDC)
            Return bitDepth
        End Get
    End Property

#End Region

End Class
