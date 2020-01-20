Public Class Form1
    Dim mA, mB, mC As Integer
 
    Private Sub btn_new_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_new.Click
        Randomize()
        mA = Int(Rnd() * 9) + 1 : A.Text = mA
        mB = Int(Rnd() * 9) + 1 : B.Text = mB

        If rb_plus.Checked Then lbl_ctype.Text = "+"
        If rb_minus.Checked Then lbl_ctype.Text = "-"
        If rb_prod.Checked Then lbl_ctype.Text = "x"
        If rb_div.Checked Then lbl_ctype.Text = "/"

        C.Enabled = True : btn_check.Enabled = True
        gb_ctype.Enabled = False : btn_new.Enabled = False

    End Sub

    Private Sub btn_check_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_check.Click

        If rb_plus.Checked Then mC = mA + mB
        If rb_minus.Checked Then mC = mA - mB
        If rb_prod.Checked Then mC = mA * mB
        If rb_div.Checked Then mC = Int(mA / mB)

        If Val(C.Text) = mC Then
            pb_ans.Image = My.Resources.win
        Else
            pb_ans.Image = My.Resources.loss
            MsgBox("正確答案：" & mC)
        End If

        gb_ctype.Enabled = True : btn_new.Enabled = True
        C.Enabled = False : btn_check.Enabled = False

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gb_ctype.Enabled = True
        btn_new.Enabled = True
        C.Enabled = False
        btn_check.Enabled = False

    End Sub
End Class
