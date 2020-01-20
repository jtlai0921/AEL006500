Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Size = New Size(550, 550)
        frm_arr()

    End Sub
    Private Sub frm_arr()
        With txt_title
            .Text = "標題"
            .Font = New Font("微軟正黑體", 24, FontStyle.Bold)
            .ForeColor = Color.White
            .BackColor = Color.Red
            .Size = New Size(500, 100)
            .TextAlign = HorizontalAlignment.Center
            .Top = 20
        End With
        With txt_cont
            .Text = "公告事項"
            .Font = New Font("標楷體", 18, FontStyle.Italic)
            .ForeColor = Color.Yellow
            .BackColor = Color.Green
            .Size = New Size(500, 250)
            .TextAlign = HorizontalAlignment.Center
            .Top = 120
        End With
        With txt_marqee
            .Text = "跑馬燈"
            .Font = New Font("新細明體", 14, FontStyle.Underline)
            .ForeColor = Color.Red
            .BackColor = Color.Blue
            .Size = New Size(500, 50)
            .TextAlign = HorizontalAlignment.Center
            .Top = 370
        End With
        With btn_end
            .Location = New Point(Me.Width - 100, Me.Height - 100)
        End With


    End Sub
End Class
