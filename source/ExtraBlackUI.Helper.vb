Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Module ExtraBlackNativeHelper

    Private Declare Function DwmSetWindowAttribute Lib "dwmapi.dll" (hwnd As IntPtr, dwAttribute As UInteger, pvAttribute As Integer(), cbAttribute As UInteger) As Integer

    Private Const ECM_FIRST As UInteger = &H1500
    Private Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=False)>
    Private Function SendMessage(ByVal hWnd As IntPtr,
                                 ByVal Msg As UInteger,
                                 ByVal wParam As UInteger,
                                 <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As IntPtr
    End Function

    <Extension()>
    Sub SetCueBanner(ByVal txt As TextBox, ByVal WaterMarkTextString As String)
        SendMessage(txt.Handle, EM_SETCUEBANNER, 0, WaterMarkTextString)
    End Sub


    <Extension()>
    Sub EnableDarkMode(ByVal form As Form)
        If DwmSetWindowAttribute(form.Handle, 19UI, New Integer() {True}, 4UI) <> 0 Then
            DwmSetWindowAttribute(form.Handle, 20UI, New Integer() {True}, 4UI)
        End If
    End Sub

    ' <Extension()>
    ' Sub DisableDarkMode(ByVal form As Form)
    '     If DwmSetWindowAttribute(form.Handle, 19UI, New Integer() {False}, 4UI) <> 0 Then
    '         DwmSetWindowAttribute(form.Handle, 20UI, New Integer() {False}, 4UI)
    '     End If
    ' End Sub
End Module
