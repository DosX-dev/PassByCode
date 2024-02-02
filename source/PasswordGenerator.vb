Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordGenerator

    Private _seed As String
    Private _md5 As MD5

    Public Sub New(seed As String)
        _seed = seed
        _md5 = MD5.Create()
    End Sub

    Private Function GetNextRandomByte() As Byte
        Dim hash As Byte() = _md5.ComputeHash(Encoding.UTF8.GetBytes(_seed))
        _seed = Convert.ToBase64String(hash) ' Updating the seed based on the previous hash
        Return hash(0)
    End Function

    Public Function GeneratePassword(length As Integer, includeSymbols As Boolean) As String
        Dim password As New StringBuilder
        Dim chars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        If includeSymbols Then
            chars &= "!@#$%^&*()<>.,=;:{}[]_"
        End If

        For i As Integer = 0 To length - 1
            Dim index As Integer = GetNextRandomByte() Mod chars.Length
            password.Append(chars(index))
        Next

        Return password.ToString()
    End Function

End Class
