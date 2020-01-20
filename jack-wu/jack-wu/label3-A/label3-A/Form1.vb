Public Class Form1
    '顯示過去、現在、未來日期
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim hireDay As Date = #8/1/1991#
        Dim hireTime As Date = #8/1/1991 11:12:15 AM#
        Dim retireDay As Date = #7/31/2016#
        Dim str1 = "聘用日期:" & hireDay
        str1 = str1 & vbNewLine & "今天日期:" & Now.Date
        str1 = str1 & vbNewLine & "預計退休日期:" & retireDay
        MsgBox(str1)
    End Sub
End Class
