Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_new_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_new.Click
        Randomize()
        A.Text = 1 + Int(Rnd() * 9)
        B.Text = 1 + Int(Rnd() * 9)

    End Sub

    Private Sub btn_check_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_check.Click
        If Val(A.Text) + Val(B.Text) = Val(C.Text) Then

            MsgBox("正確答案")

        Else

            MsgBox("豬頭")
        End If

    End Sub
End Class
