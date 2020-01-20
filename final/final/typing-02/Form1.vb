Public Class Form1
    Dim mstp As Integer = 20
    Dim mstr = "白日依山盡黃河入海流欲窮千里目更上一層樓"
    Dim mcnt = 0
    Dim msucc = 0
    Dim mfail = 0
    Dim lbl_score As Label

    Private Sub txt_keyin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_keyin.TextChanged
        If lbl_drop.Text = txt_keyin.Text Then
            lbl_drop.Text = ""
            getword()
            lbl_drop.Top = 0
            msucc = msucc + 1
        End If
        txt_keyin.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_drop.Top = lbl_drop.Top + mstp
        If lbl_drop.Top > 450 Then
            mfail = mfail + 1
            lbl_drop.Top = 0
            getword()
        End If
        lbl_score.Text = "成功：" & msucc & "    失敗：" & mfail
        If msucc + mfail > Len(mstr) Then Timer1.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        getword()
        lbl_score = New Label
        With lbl_score
            .Location = New Point(0, 450)
            .Size = New Size(150, 50)
            .Text = "成功：" & msucc & "    失敗：" & mfail
        End With
        Me.Controls.Add(lbl_score)

    End Sub
    Private Sub getword()
        mcnt = mcnt + 1
        lbl_drop.Text = Mid(mstr, mcnt, 1)

    End Sub
End Class
