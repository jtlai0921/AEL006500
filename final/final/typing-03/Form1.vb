Public Class Form1
    Dim mstp As Integer = 5
    Dim mstr = "白日依山盡黃河入海流欲窮千里目更上一層樓"
    Dim mcnt = 0
    Dim msucc = 0
    Dim mfail = 0
    Dim lbl_score As Label
    Dim adrop(5) As Label
    Dim mx1 = 150


    Private Sub txt_keyin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_keyin.TextChanged
        For i = 1 To 5
            If adrop(i).Text = txt_keyin.Text Then
                adrop(i).Text = ""
                getword(i)
                adrop(i).Top = 0
                msucc = msucc + 1
            End If
        Next
        txt_keyin.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 1 To 5
            adrop(i).Top = adrop(i).Top + mstp
            If adrop(i).Top > 450 Then
                mfail = mfail + 1
                adrop(i).Top = 0
                getword(i)
            End If
        Next

        lbl_score.Text = "成功：" & msucc & "    失敗：" & mfail
        If msucc + mfail > Len(mstr) Then Timer1.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        addcon()
        For i = 1 To 5
            getword(i)
        Next
    End Sub
    Private Sub getword(ByVal i)
        mcnt = mcnt + 1
        adrop(i).Text = Mid(mstr, mcnt, 1)

    End Sub
    Private Sub addcon()
        For i = 1 To 5
            adrop(i) = New Label
            With adrop(i)
                .Location = New Point(mx1 + (i - 1) * 70, 0)
                .Size = New Size(30, 30)
                .Text = "*"
            End With
            Me.Controls.Add(adrop(i))
        Next

        lbl_score = New Label
        With lbl_score
            .Location = New Point(0, 450)
            .Size = New Size(150, 50)
            .Text = "成功：" & msucc & "    失敗：" & mfail
        End With
        Me.Controls.Add(lbl_score)
    End Sub
End Class
