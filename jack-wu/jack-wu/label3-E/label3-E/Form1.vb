Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    'A.顯示過去、現在、未來日期
    'B.顯示過去、現在、未來時間、時間的加減運算 
    'C.加入時間判斷功能，改以TextBox顯示資料
    'D.把畫面放至最大，去除視窗標題列，改為每秒訊息更新一次
    'E.從文字檔讀入資料做為訊息跑馬燈、畫面修飾
    Dim hireDay As Date = #8/1/1991#
    Dim retireDay As Date = #7/31/2016#
    Dim str1 = "聘用日期:" & hireDay

    Dim ondutyTime As DateTime = #8:00:00 AM#
    Dim offdutyTime As DateTime = #5:00:00 PM#
    Dim str2 = "上班時間：" & ondutyTime
    Dim title As String = "三等專員專用訊息佈告欄"
    Dim str3 As String = ""
    Dim str4 As String = ""
    Dim n As Integer = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        str1 = str1 & vbNewLine & "今天日期:" & Now.Date
        str1 = str1 & vbNewLine & "預計退休日期:" & retireDay
        str1 = str1 & vbNewLine
        str1 = str1 & vbNewLine & "已工作天數:" & CInt((Now - hireDay).TotalDays)
        str1 = str1 & Space(5) & "離退休天數:" & CInt((retireDay - Now).TotalDays)

        str2 = str2 & vbNewLine & "現在時間：" & TimeOfDay
        str2 = str2 & vbNewLine & "預計下班時間：" & offdutyTime
        str2 = str2 & vbNewLine

        If TimeOfDay.Hour < 8 Then
            str2 = str2 & vbNewLine & "離上班小時數：" & CInt((ondutyTime - TimeOfDay).TotalHours * 100) / 100
        ElseIf TimeOfDay.Hour < 12 Then
            str2 = str2 & vbNewLine & "離中餐小時數：" & CInt((#11:59:59 AM# - TimeOfDay).TotalHours * 100) / 100
            str2 = str2 & Space(5) & "離下班小時數：" & CInt((offdutyTime - TimeOfDay).TotalHours * 100) / 100
        ElseIf TimeOfDay.Hour < 17 Then
            str2 = str2 & Space(5) & "離下班小時數：" & CInt((offdutyTime - TimeOfDay).TotalHours * 100) / 100
        Else
            str2 = str2 & vbNewLine & "已下班小時數：" & CInt((TimeOfDay - offdutyTime).TotalHours * 100) / 100
        End If

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        With TextBox1
            .Text = str1 & vbNewLine & str2
            .TextAlign = HorizontalAlignment.Center
            .Width = Me.Width - 30
            .Height = Me.Height - 330
            .Top = 140
            .Font = New Font("微軟正黑體", 30, FontStyle.Bold)
            .ForeColor = Color.Yellow
            .BackColor = Color.Blue
        End With
        Button1.Location = New Point(Me.Width - 30 - Button1.Width, Me.Height - 80)

        Dim filename As String = Application.StartupPath & "\message.txt" '方便以後只要把訊息資料檔與可執行檔放在同一子目錄下即可執行
        Dim fields As String()
        Dim delimiter As String = ","
        Using parser As New TextFieldParser(filename)
            parser.SetDelimiters(delimiter)
            While Not parser.EndOfData
                ' Read in the fields for the current line
                fields = parser.ReadFields()
                ' Add code here to use data in fields variable.
                If CType(fields(0), Date) > Now.Date Then
                    str3 = str3 & fields(0).ToString & "︰" & fields(1) & Space(5)
                End If
            End While
        End Using

        With TextBox2
            .TextAlign = HorizontalAlignment.Center
            .Width = Me.Width - 30
            .Height = 50
            .Top = Me.Height - 170
            .Font = New Font("微軟正黑體", 16, FontStyle.Bold)
            .ForeColor = Color.White
            .BackColor = Color.Blue
        End With

        With TextBox3
            .Text = title
            .TextAlign = HorizontalAlignment.Center
            .Width = Me.Width - 30
            .Height = 100
            .Top = 30
            .Font = New Font("微軟正黑體", 60, FontStyle.Bold)
            .ForeColor = Color.Red
            .BackColor = Color.Blue
        End With

        Timer1.Interval = 300
        Timer1.Enabled = True
        TextBox2.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'str4 = Mid(str3 & str3, n, 80)
        'TextBox2.Text = str4
        'n = n + 1
        'n = n Mod Len(str3) + 1
        str3 = Mid(str3, 2, Len(str3) - 1) & Mid(str3, 1, 1)
        TextBox2.Text = str3


    End Sub
End Class
