Imports System.IO
Public Class Form1
    Dim enTextBox(9) As TextBox
    Dim ansTextBox(9) As TextBox
    Dim ans(9) As String
    Dim ansch(9) As String
    Dim ansen(9) As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        '讀取檔案內容
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText("voca.txt")

        '分列打散至陣列
        Dim lineArray As Array = Split(fileContents, vbNewLine)
        Dim generator As New Random
        Dim selValue As Integer
        Dim qStr = ""
        Dim order(25) As String
        Dim en(25) As String
        Dim ch(25) As String

        '選26個單字動作
        For i = 0 To 25
            '以亂數方式隨機取得第i列算起的任一列，與第i列更換後，打散成欄位，可避免重覆選取
            selValue = generator.Next(i, UBound(lineArray))
            Dim tem = lineArray(selValue)
            lineArray(selValue) = lineArray(i)
            lineArray(i) = tem

            Dim columnArray As Array = Split(lineArray(i), ",")

            order(i) = Chr(65 + i)
            en(i) = columnArray(0)
            ch(i) = columnArray(1)

            '組成題目
            qStr = qStr & order(i) & ". " & ch(i) & Space(2)

            '每5個字一組跳列
            If (i + 1) Mod 5 = 0 Then qStr = qStr & vbNewLine
        Next

        '題目文字方塊處理
        With qTextBox
            .Font = New Font(Me.Font.Name, Me.Font.Size + 3)
            .ScrollBars = ScrollBars.Vertical
            .Multiline = True
            .Height = 120
            .Text = qStr
        End With

        '答題區畫面處理
        enTextBox(0) = TextBox0
        enTextBox(1) = TextBox1
        enTextBox(2) = TextBox2
        enTextBox(3) = TextBox3
        enTextBox(4) = TextBox4
        enTextBox(5) = TextBox5
        enTextBox(6) = TextBox6
        enTextBox(7) = TextBox7
        enTextBox(8) = TextBox8
        enTextBox(9) = TextBox9

        ansTextBox(0) = TextBox10
        ansTextBox(1) = TextBox11
        ansTextBox(2) = TextBox12
        ansTextBox(3) = TextBox13
        ansTextBox(4) = TextBox14
        ansTextBox(5) = TextBox15
        ansTextBox(6) = TextBox16
        ansTextBox(7) = TextBox17
        ansTextBox(8) = TextBox18
        ansTextBox(9) = TextBox19

        Dim sel2Value As Integer
        '取得10個題目及其標準答案
        For i = 0 To 9
            sel2Value = generator.Next(i, 25)

            Dim tem = order(sel2Value)
            order(sel2Value) = order(i)
            order(i) = tem

            tem = ch(sel2Value)
            ch(sel2Value) = ch(i)
            ch(i) = tem

            tem = en(sel2Value)
            en(sel2Value) = en(i)
            en(i) = tem

            enTextBox(i).Text = en(i)
            ans(i) = order(i)
            ansch(i) = ch(i)
            ansen(i) = en(i)
        Next
        scoLabel.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '核對答案，並累積得分
        Dim score = 0
        Dim sw As StreamWriter = New StreamWriter("errLog.txt", True)
        For i = 0 To 9
            If Trim(ansTextBox(i).Text).ToUpper <> Trim(ans(i)).ToUpper Then
                ansTextBox(i).BackColor = Color.Red
                '答錯寫入errLog.dat中
                Dim errWordStr = ansen(i) & "," & ansch(i) & "," & Today
                sw.WriteLine(errWordStr)
            Else
                ansTextBox(i).BackColor = Me.BackColor
                score = score + 10
            End If
        Next
        sw.Flush()
        sw.Close()
        '分數顯示
        With scoLabel
            .Text = score & "分"
            .ForeColor = Color.Red
            .Font = New Font(Me.Font.Name, 30)
            .Visible = True
        End With
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '清理答案區
        For i = 0 To 9
            With ansTextBox(i)
                .Text = ""
                .BackColor = Me.BackColor
            End With
        Next
        '上次得分隱藏
        scoLabel.Visible = False

        Form1_Load(sender, e)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
