Imports System.Xml,
        System.Graphics


Namespace ExtraBlack
    Class ExtraBlackButton
        Inherits Button

        Sub New()

            Font = New Font("Calibri", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
            Size = New Point(130, 40)
            ForeColor = Color.White
            BackColor = Color.FromArgb(24, 24, 24)

            FlatStyle = FlatStyle.Flat
            With FlatAppearance
                .BorderColor = Color.White
                .MouseOverBackColor = Color.White
            End With

        End Sub

        Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
            Dim Btn = DirectCast(sender, Button)
            Using P As New Pen(Me.BackColor, 1)
                e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
            End Using
        End Sub

        Sub OnHover() Handles Me.MouseEnter
            BackColor = Color.White
            ForeColor = Color.FromArgb(24, 24, 24)
        End Sub

        Sub OnLeave() Handles Me.MouseLeave
            BackColor = Color.FromArgb(24, 24, 24)
            ForeColor = Color.White
        End Sub

    End Class



    Class ExtraBlackTextbox
        Inherits TextBox
        Sub New()
            Font = New Font("Calibri", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
            BackColor = Color.FromArgb(24, 24, 24)
            Cursor = Cursors.Default
            BorderStyle = BorderStyle.FixedSingle

            ' Multiline = True

            ForeColor = Color.White
        End Sub
        Private Sub HotKeys(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
            'Ctrl + Backspace
            If Me.ReadOnly = False Then
                If e.Control AndAlso e.KeyCode = Keys.Back Then
                    e.SuppressKeyPress = True
                    If Me.SelectionStart > 0 Then
                        SendKeys.Send("+{LEFT}{DEL}")
                    End If
                End If
            End If
        End Sub

        Sub OnFocus() Handles Me.GotFocus
            BackColor = Color.White
            ForeColor = Color.FromArgb(30, 30, 30)
        End Sub

        Sub NonFocus() Handles Me.LostFocus
            BackColor = Color.FromArgb(30, 30, 30)
            ForeColor = Color.White
        End Sub
    End Class

    Class ExtraBlackCheckBox
        Inherits CheckBox

        Sub New()
            Font = New Font("Calibri", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
            BackColor = Color.FromArgb(24, 24, 24)
            ForeColor = Color.White
        End Sub

        Sub OnChecked() Handles Me.CheckedChanged
            If CheckState = CheckState.Checked Then
                CheckState = CheckState.Indeterminate
            End If
        End Sub
    End Class

End Namespace