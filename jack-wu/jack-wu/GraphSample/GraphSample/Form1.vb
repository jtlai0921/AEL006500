Public Class Form1
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' 畫一條黑色實心線
        e.Graphics.DrawLine(Pens.Black, 15, 15, 100, 15)

        ' 畫一條黑色虛線
        Dim LPen As New System.Drawing.Pen(System.Drawing.Color.Black)
        LPen.DashStyle = Drawing2D.DashStyle.Dot
        e.Graphics.DrawLine(LPen, 15, 30, 100, 30)

        ' 畫一條黑色實心線，寬度5 pixel
        Dim TPen As New System.Drawing.Pen(System.Drawing.Color.Black, 1)
        TPen.Width = 5
        e.Graphics.DrawLine(TPen, 15, 45, 100, 45)

        ' 畫一個半徑30的圓
        e.Graphics.DrawEllipse(Pens.Red, 40, 90, 30, 30)

        ' 畫一個長軸50，短軸30的橢圓
        e.Graphics.DrawEllipse(Pens.Red, 30, 140, 50, 30)

        '畫一個長方形
        e.Graphics.DrawRectangle(Pens.Black, 120, 5, 150, 30)

        ' 畫一個紅色實心長方形
        Dim SBrush As New System.Drawing.SolidBrush(System.Drawing.Color.Red)
        ' e.Graphics.DrawRectangle(Pens.Red, 120, 50, 60, 30)
        e.Graphics.FillRectangle(SBrush, 120, 50, 60, 30)

        ' 畫一個黑色十字方格填滿長方形
        Dim HBrush As New System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Cross, _
            System.Drawing.Color.Black, System.Drawing.Color.Transparent)
        e.Graphics.DrawRectangle(Pens.Black, 210, 50, 60, 30)
        e.Graphics.FillRectangle(HBrush, 210, 50, 60, 30)

        '在座標(120,100)處，繪出寬150高80圖形

        Dim Pict1 As New Bitmap(My.Resources.Oryx_Antelope)
        e.Graphics.DrawImage(Pict1, 120, 100, 150, 80)

        '在座標題(10,190)處顯示標楷體、22點大小、字體加粗而顏色為黃綠色的文字"明天會更好"
        Dim TextFont As New System.Drawing.Font("標楷體", 22, FontStyle.Bold)
        Dim TextBrush As New System.Drawing.SolidBrush(System.Drawing.Color.YellowGreen)
        e.Graphics.DrawString("明天會更好!", TextFont, TextBrush, 10, 190)

        '繪製10個單一點
        Dim x1 As Integer
        For x1 = 20 To 110 Step 10
            e.Graphics.DrawEllipse(Pens.Red, x1, 230, 1, 1)
        Next x1

        '繪製10個單一加粗的點--方法1
        Dim x2 As Integer
        Dim pen1 As New Pen(Color.DeepSkyBlue)
        pen1.Width = 3
        For x2 = 20 To 110 Step 10
            e.Graphics.DrawEllipse(pen1, x2, 240, 1, 1)
        Next x2

        '繪製10個單一加粗的點--方法2
        For x2 = 20 To 110 Step 10
            e.Graphics.FillEllipse(Brushes.Blue, New Rectangle(x2, 250, 10, 10))
        Next x2
    End Sub
End Class
