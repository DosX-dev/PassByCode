Public Class DoNotCaptureMe

    Private Declare Function SetWindowDisplayAffinity Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal dwAffinity As UInteger) As Boolean
    Private Declare Function GetWindowDisplayAffinity Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef dwAffinity As UInteger) As Boolean

    Public Enum Affinity
        None = 0
        Primary = 1
    End Enum

    Public Sub DisableScreenshots(ByVal hwnd As IntPtr)
        SetWindowDisplayAffinity(hwnd, Affinity.Primary)
    End Sub

    Public Sub EnableScreenshots(ByVal hwnd As IntPtr)
        SetWindowDisplayAffinity(hwnd, Affinity.None)
    End Sub

    Public Function GetCurrentAffinity(ByVal hwnd As IntPtr) As Affinity
        Dim dwAffinity As UInteger = 0
        GetWindowDisplayAffinity(hwnd, dwAffinity)
        Return CType(dwAffinity, Affinity)
    End Function

End Class