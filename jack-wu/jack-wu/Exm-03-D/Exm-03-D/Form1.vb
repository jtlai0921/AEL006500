Imports System.IO
Public Class Form1
    Dim enTextBox(9) As TextBox
    Dim ansTextBox(9) As TextBox
    Dim ans(9) As String
    Dim ansch(9) As String
    Dim ansen(9) As String

    Dim order(25) As String
    Dim en(25) As String
    Dim ch(25) As String
    Dim timeCount As Integer

    Dim qStr = ""
    Dim qStr5 = ""


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timeCount = 0
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Randomize()
        '讀取檔案內容
        Dim fileContents, fileContents2 As String
        fileContents = My.Computer.FileSystem.ReadAllText("voca.txt")
        fileContents2 = My.Computer.FileSystem.ReadAllText("error.txt")

        '分列打散至陣列
        Dim lineArray As Array = Split(fileContents, vbNewLine)
        Dim lineArray2 As Array = Split(fileContents2, vbNewLine)
        Dim generator As New Random
        Dim selValue As Integer
      
        '選26個單字動作
        For i = 0 To 25
            '以亂數方式隨機取得第i列算起的任一列，與第i列更換後，打散成欄位，可避免重覆選取
            Dim columnArray As Array
            If i = 0 Then
                selValue = generator.Next(i, UBound(lineArray2))
                Dim tem1 = lineArray2(selValue)
                lineArray2(selValue) = lineArray2(i)
                lineArray2(i) = tem1

                columnArray = Split(lineArray2(i), ",")
            ElseIf i <= 9 And i > 0 Then
                '挑出不重覆於前面資料的資料作為考題
                Dim doubleFlag As Boolean
                Do
                    doubleFlag = False
                    selValue = generator.Next(i, UBound(lineArray2))
                    Dim tem2 = lineArray2(selValue)
                    lineArray2(selValue) = lineArray2(i)
                    lineArray2(i) = tem2

                    Dim j = 0
                    While j <= i - 1 And doubleFlag = False
                        If Microsoft.VisualBasic.Left(lineArray2(j), lineArray2(j).ToString.Length - 12) = Microsoft.VisualBasic.Left(lineArray2(i), lineArray2(i).ToString.Length - 12) Then doubleFlag = True
                        j = j + 1
                    End While
                Loop While doubleFlag = True
                columnArray = Split(lineArray2(i), ",")
            Else
                '挑出不重覆於前面資料的資料作為考題
                Dim doubleFlag As Boolean
                Do
                    doubleFlag = False
                    selValue = generator.Next(i - 10, UBound(lineArray))
                    Dim tem3 = lineArray(selValue)
                    lineArray(selValue) = lineArray(i)
                    lineArray(i) = tem3

                    '檢查不和前面Error.txt取出的重覆
                    Dim k = 0
                    While k <= 9 And doubleFlag = False
                        If Microsoft.VisualBasic.Left(lineArray2(k), 5) = Microsoft.VisualBasic.Left(lineArray(i), 5) Then doubleFlag = True
                        k = k + 1
                    End While
                    '檢查不和前面voca.txt取出的重覆
                    While k <= i - 1 And doubleFlag = False
                        If Microsoft.VisualBasic.Left(lineArray(k), 5) = Microsoft.VisualBasic.Left(lineArray(i), 5) Then doubleFlag = True
                        k = k + 1
                    End While

                Loop While doubleFlag = True

                    columnArray = Split(lineArray(i), ",")
            End If

            order(i) = Chr(65 + i)
            en(i) = columnArray(0)
            ch(i) = columnArray(1)

            '組成題目
            qStr = qStr & order(i) & ". " & ch(i) & Space(2) & en(i) & Space(3)

            qStr5 = qStr5 & order(i) & ". " & ch(i) & Space(2)

            '每5個字一組跳列
            If (i + 1) Mod 5 = 0 Then qStr = qStr & vbNewLine
            If (i + 1) Mod 5 = 0 Then qStr5 = qStr5 & vbNewLine
        Next

        '題目文字方塊處理
        With qTextBox
            .Font = New Font(Me.Font.Name, Me.Font.Size)
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

        sel2Value = generator.Next(0, 25)

        Dim tem = order(sel2Value)
        order(sel2Value) = order(0)
        order(0) = tem

        tem = ch(sel2Value)
        ch(sel2Value) = ch(0)
        ch(0) = tem

        tem = en(sel2Value)
        en(sel2Value) = en(0)
        en(0) = tem

        enTextBox(0).Text = en(0)
        ans(0) = order(0)
        ansch(0) = ch(0)
        ansen(0) = en(0)


        For i = 1 To 9
            Dim doubleFlag As Boolean
            Do
                doubleFlag = False
                sel2Value = generator.Next(i, 25)

                tem = order(sel2Value)
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

                '檢查有無重覆
                Dim k = 0
                While k <= i - 1 And doubleFlag <> True
                    If ansch(i) = ansch(k) Then doubleFlag = True
                    k = k + 1
                End While

            Loop While doubleFlag = True
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
        qStr = ""
        qStr5 = ""
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
        Button2.Visible = True
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timeCount = timeCount + 1
        secLabel.Text = "剩下時間：" & 20 - timeCount & "秒"
        If timeCount >= 5 Then
           
            '題目文字方塊處理
            With qTextBox
                .Font = New Font(Me.Font.Name, Me.Font.Size + 3)
                .Text = qStr5
                .TextAlign = HorizontalAlignment.Center
            End With
        End If
        If timeCount >= 20 Then
            Call Button2_Click(sender, e)
            Button2.Visible = False
            Timer1.Enabled = False
        End If
    End Sub
End Class
