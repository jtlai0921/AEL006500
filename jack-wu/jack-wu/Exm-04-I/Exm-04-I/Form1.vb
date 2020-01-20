'A 一個文字往下掉，及輸入正確會消失功能
'B 加入自動補字功能
'C 改成五個字版本
'D 題目文章改由檔案讀取
'E 時間記錄、字數統計、輸入速度計算
'F 10分鐘自動停止、暫停按鈕、繼續按鈕
'G 運用ComboBox控制項來分級、重新開始按鈕
'H 加入文字超出界限未輸入時，累積於左側功能，但於後續輸入該字時，仍應可消除該字
'I 增加掉下直接堆積於下方功能，並使用副程式簡化程式，修正空白狀況誤加分狀況

Public Class Form1
    Dim wCtr As Integer
    Dim str1 As String
    Dim wordLabel(4) As Label
    Dim score As Integer
    Dim accSec As Integer
    Dim Hstep As Integer
    Dim bLabel0Top, bLabel1Top, bLabel2Top, bLabel3Top, bLabel4Top As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bLabel0Top = 500
        bLabel1Top = 500
        bLabel2Top = 500
        bLabel3Top = 500
        bLabel4Top = 500

        Call initialValue(bLabel0)
        Call initialValue(bLabel1)
        Call initialValue(bLabel2)
        Call initialValue(bLabel3)
        Call initialValue(bLabel4)

        score = 0
        accSec = 0
        ComboBox1.SelectedItem = "中高級"
        Timer1.Interval = 1000
        Timer1.Enabled = True

        wordLabel(0) = Label1
        wordLabel(1) = Label2
        wordLabel(2) = Label3
        wordLabel(3) = Label4
        wordLabel(4) = Label5

        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & "test2000.txt")
        str1 = fileContents
        wCtr = 1
        For i = 0 To 4
            getWord(i)
        Next i
        scoLabel.Text = ""
    End Sub

    Sub initialValue(ByRef bLabelN)
        bLabelN.Text = ""
        bLabelN.ForeColor = Color.Blue
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        For i = 0 To 4
            If wordLabel(i).Text = TextBox1.Text And TextBox1.Text <> "" Then
                score = score + 1
                scoLabel.Text = "正確字數：" & score & Space(5) & "速度：" & Int(score * 60 / accSec) & "字／分" & Space(5) & "時間：" & accSec \ 60 & ":" & accSec Mod 60
                TextBox1.Text = ""
                getWord(i)
            End If
        Next i
        Call delBtmWord(bLabel0)
        Call delBtmWord(bLabel1)
        Call delBtmWord(bLabel2)
        Call delBtmWord(bLabel3)
        Call delBtmWord(bLabel4)
        TextBox1.Text = ""
    End Sub

    Sub delBtmWord(ByRef bLabelN)
        If InStr(bLabelN.Text, TextBox1.Text) <> 0 And TextBox1.Text <> "" Then
            bLabelN.Text = Replace(bLabelN.Text, TextBox1.Text, "")
            bLabelN.Text = Replace(bLabelN.Text, vbNewLine & vbNewLine, vbNewLine)
            bLabelN.Top = 500 - 8 * Len(bLabelN.text) \ 2
            score = score + 1
            scoLabel.Text = "正確字數：" & score & Space(5) & "速度：" & Int(score * 60 / accSec) & "字／分" & Space(5) & "時間：" & accSec \ 60 & ":" & accSec Mod 60
            TextBox1.Text = ""
        End If
    End Sub

    Sub getWord(ByVal i)
        wordLabel(i).Text = Mid(str1, wCtr, 1)
        wordLabel(i).Location = New Point(200 + i * 30, 30)
        wCtr = wCtr + 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If accSec = 600 Then Timer1.Enabled = False
        accSec = accSec + 1
        For i = 0 To 4
            wordLabel(i).Location = New Point(wordLabel(i).Left, wordLabel(i).Top + Hstep)
            If wordLabel(i).Top > 500 Then
                Select Case i
                    Case 0
                        Call stackrtn(i, bLabel0, bLabel0Top)
                    Case 1
                        Call stackrtn(i, bLabel1, bLabel1Top)
                    Case 2
                        Call stackrtn(i, bLabel2, bLabel2Top)
                    Case 3
                        Call stackrtn(i, bLabel3, bLabel3Top)
                    Case 4
                        Call stackrtn(i, bLabel4, bLabel4Top)
                End Select
                getWord(i)
            End If
        Next i
        scoLabel.Text = "正確字數：" & score & Space(5) & "速度：" & Int(score * 60 / accSec) & "字／分" & Space(5) & "時間：" & accSec \ 60 & ":" & accSec Mod 60
    End Sub

    Sub stackrtn(ByRef n, ByVal bLabelN, ByRef bLabelNtop)
        bLabelN.Text = Trim(wordLabel(n).Text) & vbNewLine & bLabelN.Text
        bLabelN.Text = Replace(bLabelN.Text, vbNewLine & vbNewLine, vbNewLine)
        bLabelN.Top = 500 - 8 * Len(bLabelN.text) \ 2
        If bLabelN.Top < 50 Then Timer1.Enabled = False
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
                Hstep = 20
            Case "中高級"
                Hstep = 60
            Case "高級"
                Hstep = 80
            Case "優級"
                Hstep = 150
        End Select
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1_Load(sender, e)
    End Sub
End Class
