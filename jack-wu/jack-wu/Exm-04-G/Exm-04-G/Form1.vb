'A 一個文字往下掉，及輸入正確會消失功能
'B 加入自動補字功能
'C 改成五個字版本
'D 題目文章改由檔案讀取
'E 時間記錄、字數統計、輸入速度計算
'F 10分鐘自動停止、暫停按鈕、繼續按鈕
'G 運用ComboBox控制項來分級、重新開始按鈕
Public Class Form1
    Dim wCtr As Integer
    Dim str1 As String
    Dim wordLabel(4) As Label
    Dim score
    Dim accSec As Integer
    Dim Hstep As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        score = 0
        accSec = 0
        ComboBox1.SelectedItem = "初級"
        Timer1.Interval = 1000
        Timer1.Enabled = True

        wordLabel(0) = Label1
        wordLabel(1) = Label2
        wordLabel(2) = Label3
        wordLabel(3) = Label4
        wordLabel(4) = Label5

        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText("test2000.txt")
        str1 = fileContents
        wCtr = 1
        For i = 0 To 4
            getWord(i)
        Next i
        scoLabel.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        For i = 0 To 4
            If wordLabel(i).Text = TextBox1.Text Then
                score = score + 1
                scoLabel.Text = "正確字數：" & score & Space(5) & "速度：" & Int(score * 60 / accSec) & "字／分" & Space(5) & "時間：" & accSec \ 60 & ":" & accSec Mod 60
                TextBox1.Text = ""
                getWord(i)
            End If
        Next i
        If Len(TextBox1.Text) = 2 Then
            TextBox1.Text = ""
        End If
    End Sub
    Sub getWord(ByVal i)
        wordLabel(i).Text = Mid(str1, wCtr, 1)
        wordLabel(i).Location = New Point(150 + i * 30, 30)
        wCtr = wCtr + 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If accSec = 600 Then Timer1.Enabled = False
        accSec = accSec + 1
        For i = 0 To 4
            wordLabel(i).Location = New Point(wordLabel(i).Left, wordLabel(i).Top + Hstep)
        Next i
        scoLabel.Text = "正確字數：" & score & Space(5) & "速度：" & Int(score * 60 / accSec) & "字／分" & Space(5) & "時間：" & accSec \ 60 & ":" & accSec Mod 60
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case "初級"
                Hstep = 5
            Case "中級"
                Hstep = 15
            Case "高級"
                Hstep = 50
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1_Load(sender, e)
    End Sub
End Class
