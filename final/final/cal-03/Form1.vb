Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_new_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_new.Click
        Randomize()
        A.Text = 1 + Int(Rnd() * 9)
        B.Text = 1 + Int(Rnd() * 9)
        C.Focus()

    End Sub

    Private Sub btn_check_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_check.Click
        If Val(A.Text) + Val(B.Text) = Val(C.Text) Then

            'MsgBox("正確答案")
            pb_ans.Image = My.Resources.win
        Else
            pb_ans.Image = My.Resources.loss
            MsgBox("正確答案：" & Val(A.Text) + Val(B.Text))
        End If
        btn_new.Focus()

    End Sub
End Class
