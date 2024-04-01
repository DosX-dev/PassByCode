<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PhraseLbl = New System.Windows.Forms.Label()
        Me.LoginLbl = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.ResultLbl = New System.Windows.Forms.Label()
        Me.PassLbl = New System.Windows.Forms.Label()
        Me.SubTextServiceNameLbl = New System.Windows.Forms.Label()
        Me.SubTextLoginLbl = New System.Windows.Forms.Label()
        Me.SubTextAnySecretLbl = New System.Windows.Forms.Label()
        Me.RedPointServiceName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RedPointLogin = New System.Windows.Forms.Label()
        Me.RedPointAnySecret = New System.Windows.Forms.Label()
        Me.WarningLbl = New System.Windows.Forms.Label()
        Me.GHLbl = New System.Windows.Forms.Label()
        Me.GHLink = New System.Windows.Forms.LinkLabel()
        Me.NicknameLbl = New System.Windows.Forms.Label()
        Me.SubTextNickNameLbl = New System.Windows.Forms.Label()
        Me.ShowMessage = New PassByCode.ExtraBlack.ExtraBlackButton()
        Me.CopyResult = New PassByCode.ExtraBlack.ExtraBlackButton()
        Me.AnySecret = New PassByCode.ExtraBlack.ExtraBlackTextbox()
        Me.Login = New PassByCode.ExtraBlack.ExtraBlackTextbox()
        Me.captureProtection = New PassByCode.ExtraBlack.ExtraBlackCheckBox()
        Me.NickName = New PassByCode.ExtraBlack.ExtraBlackTextbox()
        Me.ServiceName = New PassByCode.ExtraBlack.ExtraBlackTextbox()
        Me.Generate = New PassByCode.ExtraBlack.ExtraBlackButton()
        Me.SuspendLayout()
        '
        'PhraseLbl
        '
        Me.PhraseLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PhraseLbl.Location = New System.Drawing.Point(13, 60)
        Me.PhraseLbl.Name = "PhraseLbl"
        Me.PhraseLbl.Size = New System.Drawing.Size(133, 19)
        Me.PhraseLbl.TabIndex = 0
        Me.PhraseLbl.Text = "Service name:"
        '
        'LoginLbl
        '
        Me.LoginLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LoginLbl.Location = New System.Drawing.Point(13, 131)
        Me.LoginLbl.Name = "LoginLbl"
        Me.LoginLbl.Size = New System.Drawing.Size(273, 19)
        Me.LoginLbl.TabIndex = 0
        Me.LoginLbl.Text = "Service login/email:"
        '
        'NameLbl
        '
        Me.NameLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NameLbl.Location = New System.Drawing.Point(12, 199)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(274, 19)
        Me.NameLbl.TabIndex = 0
        Me.NameLbl.Text = "Your any secret:"
        '
        'ResultLbl
        '
        Me.ResultLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultLbl.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ResultLbl.Location = New System.Drawing.Point(13, 332)
        Me.ResultLbl.Name = "ResultLbl"
        Me.ResultLbl.Size = New System.Drawing.Size(273, 23)
        Me.ResultLbl.TabIndex = 0
        Me.ResultLbl.Text = "Your password:"
        Me.ResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PassLbl
        '
        Me.PassLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PassLbl.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PassLbl.ForeColor = System.Drawing.Color.White
        Me.PassLbl.Location = New System.Drawing.Point(13, 359)
        Me.PassLbl.Name = "PassLbl"
        Me.PassLbl.Size = New System.Drawing.Size(242, 39)
        Me.PassLbl.TabIndex = 0
        Me.PassLbl.Text = ". . ."
        Me.PassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PassLbl.UseMnemonic = False
        '
        'SubTextServiceNameLbl
        '
        Me.SubTextServiceNameLbl.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SubTextServiceNameLbl.ForeColor = System.Drawing.Color.Silver
        Me.SubTextServiceNameLbl.Location = New System.Drawing.Point(9, 108)
        Me.SubTextServiceNameLbl.Name = "SubTextServiceNameLbl"
        Me.SubTextServiceNameLbl.Size = New System.Drawing.Size(137, 19)
        Me.SubTextServiceNameLbl.TabIndex = 0
        Me.SubTextServiceNameLbl.Text = "Service domain or name"
        Me.SubTextServiceNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SubTextLoginLbl
        '
        Me.SubTextLoginLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubTextLoginLbl.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SubTextLoginLbl.ForeColor = System.Drawing.Color.Silver
        Me.SubTextLoginLbl.Location = New System.Drawing.Point(9, 176)
        Me.SubTextLoginLbl.Name = "SubTextLoginLbl"
        Me.SubTextLoginLbl.Size = New System.Drawing.Size(277, 19)
        Me.SubTextLoginLbl.TabIndex = 0
        Me.SubTextLoginLbl.Text = "Login from the service you are registering for"
        Me.SubTextLoginLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SubTextAnySecretLbl
        '
        Me.SubTextAnySecretLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubTextAnySecretLbl.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SubTextAnySecretLbl.ForeColor = System.Drawing.Color.Silver
        Me.SubTextAnySecretLbl.Location = New System.Drawing.Point(9, 247)
        Me.SubTextAnySecretLbl.Name = "SubTextAnySecretLbl"
        Me.SubTextAnySecretLbl.Size = New System.Drawing.Size(277, 19)
        Me.SubTextAnySecretLbl.TabIndex = 0
        Me.SubTextAnySecretLbl.Text = "Write a text that you will definitely remember!"
        Me.SubTextAnySecretLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RedPointServiceName
        '
        Me.RedPointServiceName.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RedPointServiceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RedPointServiceName.Location = New System.Drawing.Point(126, 60)
        Me.RedPointServiceName.Name = "RedPointServiceName"
        Me.RedPointServiceName.Size = New System.Drawing.Size(20, 19)
        Me.RedPointServiceName.TabIndex = 0
        Me.RedPointServiceName.Text = "*"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(264, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(266, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "*"
        '
        'RedPointLogin
        '
        Me.RedPointLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RedPointLogin.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RedPointLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RedPointLogin.Location = New System.Drawing.Point(264, 131)
        Me.RedPointLogin.Name = "RedPointLogin"
        Me.RedPointLogin.Size = New System.Drawing.Size(20, 19)
        Me.RedPointLogin.TabIndex = 0
        Me.RedPointLogin.Text = "*"
        '
        'RedPointAnySecret
        '
        Me.RedPointAnySecret.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RedPointAnySecret.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RedPointAnySecret.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RedPointAnySecret.Location = New System.Drawing.Point(264, 199)
        Me.RedPointAnySecret.Name = "RedPointAnySecret"
        Me.RedPointAnySecret.Size = New System.Drawing.Size(20, 19)
        Me.RedPointAnySecret.TabIndex = 0
        Me.RedPointAnySecret.Text = "*"
        '
        'WarningLbl
        '
        Me.WarningLbl.BackColor = System.Drawing.Color.Maroon
        Me.WarningLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WarningLbl.ForeColor = System.Drawing.Color.White
        Me.WarningLbl.Location = New System.Drawing.Point(0, 422)
        Me.WarningLbl.Name = "WarningLbl"
        Me.WarningLbl.Size = New System.Drawing.Size(298, 29)
        Me.WarningLbl.TabIndex = 0
        Me.WarningLbl.Text = "Remember the entered data!"
        Me.WarningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GHLbl
        '
        Me.GHLbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GHLbl.AutoSize = True
        Me.GHLbl.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GHLbl.ForeColor = System.Drawing.Color.Silver
        Me.GHLbl.Location = New System.Drawing.Point(33, 4)
        Me.GHLbl.Name = "GHLbl"
        Me.GHLbl.Size = New System.Drawing.Size(43, 13)
        Me.GHLbl.TabIndex = 0
        Me.GHLbl.Text = "GitHub:"
        Me.GHLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GHLink
        '
        Me.GHLink.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.GHLink.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GHLink.AutoSize = True
        Me.GHLink.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GHLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.GHLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GHLink.Location = New System.Drawing.Point(75, 4)
        Me.GHLink.Name = "GHLink"
        Me.GHLink.Size = New System.Drawing.Size(203, 13)
        Me.GHLink.TabIndex = 0
        Me.GHLink.TabStop = True
        Me.GHLink.Text = "https://github.com/DosX-dev/PassByCode"
        '
        'NicknameLbl
        '
        Me.NicknameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NicknameLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NicknameLbl.Location = New System.Drawing.Point(153, 60)
        Me.NicknameLbl.Name = "NicknameLbl"
        Me.NicknameLbl.Size = New System.Drawing.Size(133, 19)
        Me.NicknameLbl.TabIndex = 0
        Me.NicknameLbl.Text = "Your nickname:"
        '
        'SubTextNickNameLbl
        '
        Me.SubTextNickNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SubTextNickNameLbl.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SubTextNickNameLbl.ForeColor = System.Drawing.Color.Silver
        Me.SubTextNickNameLbl.Location = New System.Drawing.Point(153, 108)
        Me.SubTextNickNameLbl.Name = "SubTextNickNameLbl"
        Me.SubTextNickNameLbl.Size = New System.Drawing.Size(133, 19)
        Me.SubTextNickNameLbl.TabIndex = 0
        Me.SubTextNickNameLbl.Text = "Nickname or alias"
        Me.SubTextNickNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ShowMessage
        '
        Me.ShowMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ShowMessage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ShowMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ShowMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowMessage.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ShowMessage.ForeColor = System.Drawing.Color.White
        Me.ShowMessage.Image = Global.PassByCode.My.Resources.Icons.QuestionMark_16_16
        Me.ShowMessage.Location = New System.Drawing.Point(269, 422)
        Me.ShowMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowMessage.Name = "ShowMessage"
        Me.ShowMessage.Size = New System.Drawing.Size(29, 29)
        Me.ShowMessage.TabIndex = 0
        Me.ShowMessage.UseVisualStyleBackColor = False
        '
        'CopyResult
        '
        Me.CopyResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.CopyResult.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CopyResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CopyResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyResult.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CopyResult.ForeColor = System.Drawing.Color.White
        Me.CopyResult.Image = Global.PassByCode.My.Resources.Icons.Copy_16_16
        Me.CopyResult.Location = New System.Drawing.Point(253, 359)
        Me.CopyResult.Margin = New System.Windows.Forms.Padding(4)
        Me.CopyResult.Name = "CopyResult"
        Me.CopyResult.Size = New System.Drawing.Size(33, 39)
        Me.CopyResult.TabIndex = 0
        Me.CopyResult.UseVisualStyleBackColor = False
        '
        'AnySecret
        '
        Me.AnySecret.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnySecret.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.AnySecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AnySecret.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.AnySecret.Cursor = System.Windows.Forms.Cursors.Default
        Me.AnySecret.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.AnySecret.ForeColor = System.Drawing.Color.White
        Me.AnySecret.Location = New System.Drawing.Point(13, 221)
        Me.AnySecret.MaxLength = 100
        Me.AnySecret.Name = "AnySecret"
        Me.AnySecret.Size = New System.Drawing.Size(273, 23)
        Me.AnySecret.TabIndex = 4
        '
        'Login
        '
        Me.Login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Login.Cursor = System.Windows.Forms.Cursors.Default
        Me.Login.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Login.ForeColor = System.Drawing.Color.White
        Me.Login.Location = New System.Drawing.Point(13, 153)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(273, 23)
        Me.Login.TabIndex = 3
        '
        'captureProtection
        '
        Me.captureProtection.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.captureProtection.AutoSize = True
        Me.captureProtection.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.captureProtection.Checked = True
        Me.captureProtection.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.captureProtection.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.captureProtection.ForeColor = System.Drawing.Color.White
        Me.captureProtection.Location = New System.Drawing.Point(51, 23)
        Me.captureProtection.Name = "captureProtection"
        Me.captureProtection.Size = New System.Drawing.Size(204, 23)
        Me.captureProtection.TabIndex = 0
        Me.captureProtection.Text = "Window capture protection"
        Me.captureProtection.UseVisualStyleBackColor = False
        '
        'NickName
        '
        Me.NickName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NickName.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.NickName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NickName.Cursor = System.Windows.Forms.Cursors.Default
        Me.NickName.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NickName.ForeColor = System.Drawing.Color.White
        Me.NickName.Location = New System.Drawing.Point(153, 82)
        Me.NickName.Name = "NickName"
        Me.NickName.Size = New System.Drawing.Size(133, 23)
        Me.NickName.TabIndex = 2
        '
        'ServiceName
        '
        Me.ServiceName.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServiceName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ServiceName.Cursor = System.Windows.Forms.Cursors.Default
        Me.ServiceName.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ServiceName.ForeColor = System.Drawing.Color.White
        Me.ServiceName.Location = New System.Drawing.Point(13, 82)
        Me.ServiceName.Name = "ServiceName"
        Me.ServiceName.Size = New System.Drawing.Size(133, 23)
        Me.ServiceName.TabIndex = 1
        '
        'Generate
        '
        Me.Generate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Generate.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Generate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Generate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Generate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Generate.ForeColor = System.Drawing.Color.White
        Me.Generate.Image = Global.PassByCode.My.Resources.Icons.Editor_16_16
        Me.Generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Generate.Location = New System.Drawing.Point(13, 274)
        Me.Generate.Margin = New System.Windows.Forms.Padding(4)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(273, 40)
        Me.Generate.TabIndex = 5
        Me.Generate.Text = "Generate password"
        Me.Generate.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(298, 451)
        Me.Controls.Add(Me.ShowMessage)
        Me.Controls.Add(Me.GHLink)
        Me.Controls.Add(Me.GHLbl)
        Me.Controls.Add(Me.WarningLbl)
        Me.Controls.Add(Me.RedPointAnySecret)
        Me.Controls.Add(Me.RedPointLogin)
        Me.Controls.Add(Me.SubTextAnySecretLbl)
        Me.Controls.Add(Me.SubTextLoginLbl)
        Me.Controls.Add(Me.SubTextNickNameLbl)
        Me.Controls.Add(Me.SubTextServiceNameLbl)
        Me.Controls.Add(Me.CopyResult)
        Me.Controls.Add(Me.PassLbl)
        Me.Controls.Add(Me.ResultLbl)
        Me.Controls.Add(Me.NameLbl)
        Me.Controls.Add(Me.AnySecret)
        Me.Controls.Add(Me.LoginLbl)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RedPointServiceName)
        Me.Controls.Add(Me.NicknameLbl)
        Me.Controls.Add(Me.PhraseLbl)
        Me.Controls.Add(Me.captureProtection)
        Me.Controls.Add(Me.NickName)
        Me.Controls.Add(Me.ServiceName)
        Me.Controls.Add(Me.Generate)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassByCode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Generate As ExtraBlack.ExtraBlackButton
    Friend WithEvents ServiceName As ExtraBlack.ExtraBlackTextbox
    Friend WithEvents captureProtection As ExtraBlack.ExtraBlackCheckBox
    Friend WithEvents PhraseLbl As Label
    Friend WithEvents LoginLbl As Label
    Friend WithEvents Login As ExtraBlack.ExtraBlackTextbox
    Friend WithEvents AnySecret As ExtraBlack.ExtraBlackTextbox
    Friend WithEvents NameLbl As Label
    Friend WithEvents ResultLbl As Label
    Friend WithEvents PassLbl As Label
    Friend WithEvents CopyResult As ExtraBlack.ExtraBlackButton
    Friend WithEvents SubTextServiceNameLbl As Label
    Friend WithEvents SubTextLoginLbl As Label
    Friend WithEvents SubTextAnySecretLbl As Label
    Friend WithEvents RedPointServiceName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RedPointLogin As Label
    Friend WithEvents RedPointAnySecret As Label
    Friend WithEvents WarningLbl As Label
    Friend WithEvents GHLbl As Label
    Friend WithEvents GHLink As LinkLabel
    Friend WithEvents NickName As ExtraBlack.ExtraBlackTextbox
    Friend WithEvents NicknameLbl As Label
    Friend WithEvents ShowMessage As ExtraBlack.ExtraBlackButton
    Friend WithEvents SubTextNickNameLbl As Label
End Class
