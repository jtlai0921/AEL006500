'A 一個文字往下掉，及輸入正確會消失功能
'B 加入自動補字功能
Public Class Form1
    Dim wCtr As Integer
    Dim str1 As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
        str1 = "白日依山盡黃河入海流欲窮千里目更上一層樓"
        wCtr = 0
        getWord()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Label1.Text = TextBox1.Text Then
            TextBox1.Text = ""
            getWord()
        End If
    End Sub
    Sub getWord()
        wCtr = wCtr + 1
        Label1.Text = Mid(str1, wCtr, 1)
        Label1.Location = New Point(50, 0)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Location = New Point(Label1.Left, Label1.Top + 5)
    End Sub
End Class
