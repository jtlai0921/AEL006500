'一個文字往下掉，及輸入正確會消失功能
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Enabled = True
        Label1.Text = "明"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Label1.Text = TextBox1.Text Then
            Label1.Text = ""
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Location = New Point(Label1.Left, Label1.Top + 5)
    End Sub
End Class
