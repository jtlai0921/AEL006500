Public Class Form1
    'A.顯示過去、現在、未來日期
    'B.顯示過去、現在、未來時間、時間的加減運算 
    'C.加入時間判斷功能，改以TextBox顯示資料
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim hireDay As Date = #8/1/1991#
        Dim retireDay As Date = #7/31/2016#
        Dim str1 = "聘用日期:" & hireDay
        str1 = str1 & vbNewLine & "今天日期:" & Now.Date
        str1 = str1 & vbNewLine & "預計退休日期:" & retireDay
        str1 = str1 & vbNewLine
        str1 = str1 & vbNewLine & "已工作天數:" & CInt((Now - hireDay).TotalDays)
        str1 = str1 & vbNewLine & "離退休天數:" & CInt((retireDay - Now).TotalDays)
       
        Dim ondutyTime As DateTime = #8:00:00 AM#
        Dim offdutyTime As DateTime = #5:00:00 PM#
        Dim str2 = "上班時間：" & ondutyTime
        str2 = str2 & vbNewLine & "現在時間：" & TimeOfDay
        str2 = str2 & vbNewLine & "預計下班時間：" & offdutyTime
        str2 = str2 & vbNewLine
        If TimeOfDay.Hour < 8 Then
            str2 = str2 & vbNewLine & "離上班小時數：" & CInt((ondutyTime - TimeOfDay).TotalHours * 100) / 100
        Else
            If TimeOfDay.Hour > 17 Then
                str2 = str2 & vbNewLine & "已下班小時數：" & CInt((TimeOfDay - offdutyTime).TotalHours * 100) / 100
            Else
                str2 = str2 & vbNewLine & "已上班小時數：" & CInt((TimeOfDay - ondutyTime).TotalHours * 100) / 100
                str2 = str2 & vbNewLine & "離下班小時數：" & CInt((offdutyTime - TimeOfDay).TotalHours * 100) / 100
            End If
        End If
        TextBox1.Text = str1 & vbNewLine & vbNewLine & vbNewLine & str2
    End Sub
End Class
