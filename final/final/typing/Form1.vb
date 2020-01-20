Public Class Form1
    Dim mstp As Integer = 5
    Dim mstr = My.Computer.FileSystem.ReadAllText("test1.txt")
    Dim mcnt
    Dim msucc
    Dim mfail
    Dim lbl_score As Label
    Dim adrop(5) As Label
    Dim mx1 = 150
    Dim mfsize = Me.Font.Size
    Dim isFirst = True

    Private Sub txt_keyin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_keyin.GotFocus
        If isFirst Then My.Computer.Keyboard.SendKeys("^" & Chr(32))
        isFirst = False
    End Sub


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
        mcnt = 0 : msucc = 0 : mfail = 0
        sclean()
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
                .Font = New Font(Me.Font.Name , mfsize)
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

    Private Sub com_level_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles com_level.SelectedIndexChanged
        Select Case com_level.SelectedItem
            Case "初級"
                mstp = 5
            Case "中級"
                mstp = 10
            Case "高級"
                mstp = 20
            Case "超級"
                mstp = 30
        End Select
    End Sub

    Private Sub btn_new_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_new.Click
        Timer1.Enabled = True
        Form1_Load(sender, e)
        txt_keyin.Focus()
    End Sub

    Private Sub btn_stop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        If btn_stop.Text = "暫停" Then
            btn_stop.Text = "繼續"
            Timer1.Enabled = False
        Else
            btn_stop.Text = "暫停"
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub btn_fsize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_fsize.Click
        mfsize = mfsize + 1
        For I = 1 To 5
            adrop(I).Font = New Font(Me.Font.Name, mfsize)
        Next
    End Sub
    Private Sub sclean()
        For Each Control As Windows.Forms.Control In Me.Controls
            If Control.GetType Is GetType(Label) Then
                Control.Visible = False
            End If
        Next
    End Sub
End Class
