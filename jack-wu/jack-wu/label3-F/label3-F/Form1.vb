Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    'A.顯示過去、現在、未來日期
    'B.顯示過去、現在、未來時間、時間的加減運算 
    'C.加入時間判斷功能，改以TextBox顯示資料
    'D.把畫面放至最大，去除視窗標題列，改為每秒訊息更新一次
    'E.從文字檔讀入資料做為訊息跑馬燈、畫面修飾、時間改為每秒即時更新
    'F.模組化,混用 Sub 與Function。判斷取得未過期的訊息資料

    Dim hireDay As Date = #8/1/1991#
    Dim retireDay As Date = #7/31/2016#
    Dim ondutyTime As DateTime = #8:00:00 AM#
    Dim offdutyTime As DateTime = #5:00:00 PM#
    Dim title = "XX公司三等專員專用電子看板"
    Dim str1 = "聘用日期:" & hireDay
    Dim str2 = ""
    Dim str3 = ""
    Dim str4 = ""
    Dim str5 = ""
    Dim n = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        str1 = str1 & vbNewLine & "今天日期:" & Now.Date
        str1 = str1 & vbNewLine & "預計退休日期:" & retireDay
        str1 = str1 & vbNewLine
        str1 = str1 & vbNewLine & "已工作天數:" & CInt((Now - hireDay).TotalDays)
        str1 = str1 & Space(5) & "離退休天數:" & CInt((retireDay - Now).TotalDays)

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None '去除視窗標題
        Me.WindowState = FormWindowState.Maximized '視窗最大化
        Button1.Location = New Point(Me.Width - 30 - Button1.Width, Me.Height - 80) '移結束Button至右下角 

        Dim filename As String = Application.StartupPath & "\message.txt" '方便以後只要把訊息資料檔與可執行檔放在同一子目錄下即可執行
        Dim fields As String()
        Dim delimiter As String = ","
        Using parser As New TextFieldParser(filename)
            parser.SetDelimiters(delimiter)
            While Not parser.EndOfData
                ' Read in the fields for the current line
                fields = parser.ReadFields()

                ' Add code here to use data in fields variable.
                '判斷讀入的訊息資料是否過期
                If CType(fields(0), Date) > Now.Date Then
                    str3 = str3 & fields(0).ToString & "︰" & fields(1) & Space(5)
                End If
            End While
        End Using
        textBoxSetup(TextBox3, title, Me.Width - 30, 100, 30, 60, Color.Red, Color.Blue)
        Timer1.Interval = 1000
        Timer1.Enabled = True

    End Sub

    Sub textBoxSetup(ByVal textBoxC, ByVal textC, ByVal widthC, ByVal heightC, ByVal topC, ByVal fontsizeC, ByVal foreColorC, ByVal backColorC)
        With textBoxC
            .Text = textC
            .TextAlign = HorizontalAlignment.Center
            .Width = widthC
            .Height = heightC
            .Top = topC
            .Font = New Font("微軟正黑體", fontsizeC, FontStyle.Bold)
            .ForeColor = foreColorC
            .BackColor = backColorC
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        str2 = "上班時間：" & ondutyTime
        str2 = str2 & vbNewLine & "現在時間：" & TimeOfDay
        str2 = str2 & vbNewLine & "預計下班時間：" & offdutyTime
        str2 = str2 & vbNewLine

        selectRtn()

        str5 = vbNewLine & str1 & vbNewLine & vbNewLine & str2
        textBoxSetup(TextBox1, str5, Me.Width - 30, Me.Height - 180, 140, 40, Color.Yellow, Color.Blue)
        textBoxSetup(TextBox2, " ", Me.Width - 30, 50, Me.Height - 170, 20, Color.White, Color.Blue)

        str4 = Mid(str3 & str3, n, 80)
        TextBox2.Text = str4
        n = n + 1
        n = n Mod Len(str3) + 1
    End Sub

    Sub selectRtn()
        If TimeOfDay.Hour < 8 Then
            str2 = str2 & vbNewLine & "離上班小時數：" & HMS(ondutyTime, TimeOfDay)
        ElseIf TimeOfDay.Hour < 12 Then
            str2 = str2 & vbNewLine & "離中餐還有：" & HMS(#12:00:00 PM#, TimeOfDay)
            str2 = str2 & Space(5) & "離下班還有：" & HMS(offdutyTime, TimeOfDay)
        ElseIf TimeOfDay.Hour < 17 Then
            str2 = str2 & Space(5) & "離下班還有：" & HMS(offdutyTime, TimeOfDay)
        Else
            str2 = str2 & vbNewLine & "下班已過時間：" & HMS(TimeOfDay, offdutyTime)
        End If
    End Sub

    Function HMS(ByVal endTime, ByVal startTime)
        HMS = (endTime - startTime).Hours & ":" & (endTime - startTime).Minutes & ":" & (endTime - startTime).Seconds
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
