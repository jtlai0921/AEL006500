'A 一個文字往下掉，及輸入正確會消失功能
'B 加入自動補字功能
'C 改成五個字版本 
Public Class Form1
    Dim wCtr As Integer
    Dim str1 As String
    Dim wordLabel(4) As Label
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True

        wordLabel(0) = Label1
        wordLabel(1) = Label2
        wordLabel(2) = Label3
        wordLabel(3) = Label4
        wordLabel(4) = Label5

        str1 = "白日依山盡黃河入海流欲窮千里目更上一層樓"
        wCtr = 1
        For i = 0 To 4
            getWord(i)
        Next i
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        For i = 0 To 4
            If wordLabel(i).Text = TextBox1.Text Then
                TextBox1.Text = ""
                getWord(i)
            End If
        Next i
    End Sub
    Sub getWord(ByVal i)
        wordLabel(i).Text = Mid(str1, wCtr, 1)
        wordLabel(i).Location = New Point(50 + i * 30, 0)
        wCtr = wCtr + 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 0 To 4
            wordLabel(i).Location = New Point(wordLabel(i).Left, wordLabel(i).Top + 5)
        Next i
    End Sub
End Class
