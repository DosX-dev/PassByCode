Public Class Main
    Private noScreen As New DoNotCaptureMe

    Private Declare Function DwmSetWindowAttribute Lib "dwmapi.dll" (hwnd As IntPtr, dwAttribute As UInteger, pvAttribute As Integer(), cbAttribute As UInteger) As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DwmSetWindowAttribute(MyBase.Handle, 19UI, New Integer() {1}, 4UI) <> 0 Then
            DwmSetWindowAttribute(MyBase.Handle, 20UI, New Integer() {True}, 4UI)
        End If

        ' center screen
        Dim bounds = Screen.PrimaryScreen.Bounds
        Dim x As Integer = (bounds.Width - Me.Width) / 2,
            y As Integer = (bounds.Height - Me.Height) / 2
        Me.Location = New Point(x, y)

        Me.MinimumSize = Me.Size
    End Sub

    Private Sub captureProtection_CheckedChanged(sender As Object, e As EventArgs) Handles captureProtection.CheckedChanged
        If captureProtection.Checked Then
            noScreen.DisableScreenshots(Me.Handle)
        Else
            noScreen.EnableScreenshots(Me.Handle)
        End If
    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        Dim serviceNameVal = ServiceName.Text.Trim(),
            nickNameVal = NickName.Text.Trim(),
            loginVal = Login.Text.Trim(),
            anySecretVal = AnySecret.Text.Trim()

        If serviceNameVal = String.Empty Then
            MsgBox("Service name required.", &H10)
            Return
        ElseIf loginVal = String.Empty Then
            MsgBox("Enter the login for the service you are registering for.", &H10)
            Return
        ElseIf anySecretVal = String.Empty Then
            MsgBox("You must enter a secret phrase that you will definitely remember.", &H10)
            Return
        End If

        Dim seed = serviceNameVal & nickNameVal & loginVal & anySecretVal

        ' salt
        seed &= seed.Length.ToString("x16") & "_{NO_MORE_THAN_ILLUSION}"

        Dim generator As New PasswordGenerator(seed)
        PassLbl.Text = "PBC-" & generator.GeneratePassword(17, True)
        PassLbl.ForeColor = Color.FromArgb(255, 190, 190)
    End Sub

    Private Sub CopyResult_Click(sender As Object, e As EventArgs) Handles CopyResult.Click
        Clipboard.SetText(PassLbl.Text)
    End Sub

    Private Sub GHLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GHLink.LinkClicked
        Try
            Process.Start(GHLink.Text)
        Catch ex As Exception
            MsgBox("No default browser... :(", &H10)
        End Try
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        ' block 1
        ServiceName.Size = New Size((Me.Size.Width / 2) - 25, ServiceName.Size.Height)
        SubTextServiceNameLbl.Size = New Size(ServiceName.Size.Width, SubTextServiceNameLbl.Size.Height)
        RedPointServiceName.Location = New Point(ServiceName.Size.Width - (RedPointServiceName.Size.Width / 2), RedPointServiceName.Location.Y)

        ' block 2
        Dim paddingSize = (Me.Size.Width / 2) - 19
        NickName.Size = New Size(paddingSize, NickName.Size.Height)
        NickName.Left = paddingSize + 10
        NicknameLbl.Location = New Point(NickName.Location.X, NicknameLbl.Location.Y)

        SubTextNickNameLbl.Location = New Point(NickName.Location.X, SubTextNickNameLbl.Location.Y)
        SubTextNickNameLbl.Size = New Size(NickName.Size.Width, SubTextNickNameLbl.Size.Height)
    End Sub

    Private Sub ShowMessage_Click(sender As Object, e As EventArgs) Handles ShowMessage.Click
        MsgBox("Remember every character you enter. Any letter or number affects the final password.

Also, do not provide the data you enter to anyone.", &H40, "Advice")
    End Sub
End Class
