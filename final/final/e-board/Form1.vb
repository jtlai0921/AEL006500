Public Class Form1
    Dim mn(8) As String
    Dim md_hire As Date = #8/1/1991#
    Dim md_retire As Date = #7/31/2016#
    Dim mt_on As DateTime = #8:00:00 AM#
    Dim mt_off As DateTime = #5:00:00 PM#

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer1.Interval = 500
        Me.Size = New Size(550, 550)
        frm_arr()
        mar_data1()
        mar_data2()
        cont_show()
        title_data()


    End Sub
    Private Sub frm_arr()
        With txt_title
            .Text = "標題"
            .Font = New Font("微軟正黑體", 24, FontStyle.Bold)
            .ForeColor = Color.White
            .BackColor = Color.Red
            .Size = New Size(500, 150)
            .TextAlign = HorizontalAlignment.Center
            .Top = 20
        End With
        With txt_cont
            .Text = "公告事項"
            .Font = New Font("標楷體", 14, FontStyle.Italic)
            .ForeColor = Color.Yellow
            .BackColor = Color.Green
            .Size = New Size(500, 200)
            .TextAlign = HorizontalAlignment.Center
            .Top = txt_title.Top + txt_title.Height
        End With
        With txt_marqee
            .Text = "跑馬燈"
            .Font = New Font("新細明體", 14, FontStyle.Underline)
            .ForeColor = Color.Red
            .BackColor = Color.Blue
            .Size = New Size(500, 25)
            .TextAlign = HorizontalAlignment.Center
            .Top = txt_cont.Top + txt_cont.Height
        End With
        With btn_end
            .Location = New Point(Me.Width - 100, Me.Height - 100)
        End With
    End Sub
    Private Sub mar_data1()
        mn(1) = "#07/28/2008#,颱風假不上班。"
        mn(2) = "#07/30/2009#,三等指的是：等吃飯、等下班以及等退休。"
        mn(3) = "#08/11/2009#,返校日。"
        mn(4) = "#08/28/2009#,正式上班。"
        mn(5) = "#08/31/2009#,職訓中心活動支援。"
        mn(6) = "#09/10/2009#,一等指的是：等吃飯。"
        mn(7) = "#09/12/2009#,二等指的是：等下班。"
        mn(8) = "#10/14/2009#,三等指的是：等退休。"
    End Sub
    Private Sub mar_data2()
        Dim mtmp1, mtmp2
        Dim mstr = ""

        For i = 1 To 8
            Dim mlen = Len(mn(i))
            mtmp1 = Mid(mn(i), 1, 12)
            mtmp2 = Mid(mn(i), 14, mlen - 13)
            If CType(mtmp1, Date) >= Now Then
                mtmp2 = Replace(mtmp2, "。", "......")
                mstr = mstr & mtmp1 & mtmp2
            End If
        Next
        txt_marqee.Text = mstr
    End Sub
    Private Sub cont_show()
        Dim mstr = ""
        mstr = mstr & "今天日期：" & Now.Date & vbNewLine
        mstr = mstr & "到職日期：" & md_hire & "    "
        mstr = mstr & "退休日期：" & md_retire & vbNewLine
        mstr = mstr & "已工作天數：" & (Now.Date - md_hire).TotalDays & vbNewLine
        mstr = mstr & "離退休天數：" & (md_retire - Now.Date).TotalDays & vbNewLine
        mstr = mstr & vbNewLine
        mstr = mstr & "現在時間：" & TimeOfDay & vbNewLine
        mstr = mstr & vbNewLine
        If TimeOfDay <= mt_off Then
            mstr = mstr & "剩下上班秒數：" & (mt_off - TimeOfDay).TotalSeconds & vbNewLine
        Else
            mstr = mstr & "超過下班秒數：" & (TimeOfDay - mt_off).TotalSeconds & vbNewLine
        End If
        txt_cont.Text = mstr
    End Sub
    Private Sub title_data()
        txt_title.Text = "CC123公司三等員工電子佈告欄"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        cont_show()
        Dim A = Mid(txt_marqee.Text, 1, 1)
        Dim B = Mid(txt_marqee.Text, 2, Len(txt_marqee.Text) - 1)
        txt_marqee.Text = B & A
    End Sub

    Private Sub btn_end_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_end.Click
        End
    End Sub
End Class
