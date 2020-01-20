Public Class Form1
    Dim mstp As Integer = 2
    Private Sub txt_keyin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_keyin.TextChanged
        If lbl_drop.Text = txt_keyin.Text Then
            lbl_drop.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_drop.Top = lbl_drop.Top + mstp
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub
End Class
