Public Class Main
    Private noScreen As New DoNotCaptureMe


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServiceName.SetCueBanner("example.com")
        NickName.SetCueBanner("coolguy")
        Login.SetCueBanner("account@gmail.com")
        AnySecret.SetCueBanner("for example: my favorite dish is ...")

        Me.EnableDarkMode()

        ' center screen
        Dim bounds = Screen.PrimaryScreen.Bounds
        Dim x As Integer = (bounds.Width - Me.Width) / 2,
            y As Integer = (bounds.Height - Me.Height) / 2
        Me.Location = New Point(x, y)

        Me.MinimumSize = Me.Size

        Generate.Focus()
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
        Try
            Clipboard.SetText(PassLbl.Text)
        Catch ex As Exception
            MsgBox(ex.Message, &H10)
        End Try
    End Sub

    Private Sub GHLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GHLink.LinkClicked
        Try
            Process.Start(GHLink.Text)
        Catch ex As Exception
            MsgBox("No default browser... :(", &H10)
        End Try
    End Sub

    Dim cordPoint As New Point,
        cordSize As New Size
    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not Me.WindowState = FormWindowState.Minimized Then
            ' block 1
            cordSize.Width = (Me.Size.Width / 2) - 25
            cordSize.Height = ServiceName.Size.Height
            ServiceName.Size = cordSize

            cordSize.Width = ServiceName.Size.Width
            cordSize.Height = SubTextServiceNameLbl.Size.Height
            SubTextServiceNameLbl.Size = cordSize

            cordPoint.X = ServiceName.Size.Width - (RedPointServiceName.Size.Width / 2)
            cordPoint.Y = RedPointServiceName.Location.Y
            RedPointServiceName.Location = cordPoint

            ' block 2
            Dim paddingSize = (Me.Size.Width / 2) - 19

            cordSize.Width = paddingSize
            cordSize.Height = NickName.Size.Height

            NickName.Size = cordSize
            NickName.Left = paddingSize + 10

            cordPoint.X = NickName.Location.X
            cordPoint.Y = NicknameLbl.Location.Y

            NicknameLbl.Location = cordPoint

            cordPoint.X = NickName.Location.X
            cordPoint.Y = SubTextNickNameLbl.Location.Y

            SubTextNickNameLbl.Location = cordPoint

            cordSize.Width = NickName.Size.Width
            cordSize.Height = SubTextNickNameLbl.Size.Height

            SubTextNickNameLbl.Size = cordSize

            ' block 3 (result)
            Dim resultBlockY = ((Me.ClientSize.Height / 12) * 2) + 283

            cordPoint.X = ResultLbl.Location.X
            cordPoint.Y = resultBlockY - 27
            ResultLbl.Location = cordPoint

            cordPoint.Y = resultBlockY

            cordPoint.X = PassLbl.Location.X
            PassLbl.Location = cordPoint

            cordPoint.X = CopyResult.Location.X
            CopyResult.Location = cordPoint
        End If

    End Sub

    Private Sub ShowMessage_Click(sender As Object, e As EventArgs) Handles ShowMessage.Click
        MsgBox("Remember every character you enter. Any letter or number affects the final password.

Also, do not provide the data you enter to anyone.", &H40, "Advice")
    End Sub
End Class
