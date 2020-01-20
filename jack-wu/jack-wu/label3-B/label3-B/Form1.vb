Public Class Form1
    'A.顯示過去、現在、未來日期
    'B.顯示過去、現在、未來時間、時間的加減運算 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim hireDay As Date = #8/1/1991#
        Dim retireDay As Date = #7/31/2016#
        Dim str1 = "聘用日期:" & hireDay
        str1 = str1 & vbNewLine & "今天日期:" & Now.Date
        str1 = str1 & vbNewLine & "預計退休日期:" & retireDay
        str1 = str1 & vbNewLine
        str1 = str1 & vbNewLine & "已工作天數:" & CInt((Now - hireDay).TotalDays)
        str1 = str1 & vbNewLine & "離退休天數:" & CInt((retireDay - Now).TotalDays)
        MsgBox(str1)

        Dim now1 As DateTime = #10:55:35 AM# '以now1模擬當日早上10:51:25 時間，避免因程式尚未加入判斷功能，非上班時間執行會產生錯誤
        Dim ondutyTime As DateTime = #8:00:00 AM#
        Dim offdutyTime As DateTime = #5:00:00 PM#
        Dim str2 = "上班時間：" & ondutyTime
        str2 = str2 & vbNewLine & "現在時間：" & now1.TimeOfDay.ToString
        str2 = str2 & vbNewLine & "預計下班時間：" & offdutyTime
        str2 = str2 & vbNewLine
        str2 = str2 & vbNewLine & "已上班小時數：" & CInt((now1 - ondutyTime).TotalHours * 100) / 100
        str2 = str2 & vbNewLine & "離下班小時數：" & CInt((offdutyTime - now1).TotalHours * 100) / 100
        MsgBox(str2)
    End Sub
End Class
