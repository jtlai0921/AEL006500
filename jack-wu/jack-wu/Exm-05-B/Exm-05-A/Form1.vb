'畫接線、擺車廂、建立支架
'依圓形方向運行

Public Class Form1
    Dim seat As PictureBox
    '定義角度
    Dim Angs As Integer
    Dim centerX, centerY, radX, radY As Integer
    '定義擺上次位置的暫存值參數
    Dim x1b, y1b As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '設定timer1每100/1000秒，即1/10秒運作一次
        Timer1.Interval = 100
        Timer1.Enabled = True
        Angs = 0
        centerX = 180
        centerY = 220
        radX = 150
        radY = 180
        Me.BackColor = Color.White
        seat = New PictureBox
        With seat
            .Image = My.Resources.seatRed
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Size = New Size(24, 36)
            .BackColor = Color.White
        End With
        Me.Controls.Add(seat)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim g As Graphics = Me.CreateGraphics
        Angs = Angs + 1
        '定義車廂位置
        Dim x1, y1 As Integer
        '轉換角度為弳度
        Dim AngPi = Angs * 3.14 / 180
        '以三角函數求出車廂之X、Y座標
        x1 = centerX + radX * Math.Cos(AngPi)
        y1 = centerY + radY * Math.Sin(AngPi)
        With seat
            .Location = New Point(x1, y1)
        End With
        '繪出同背景色的直線於上次位置上，達到清除效果
        g.DrawLine(Pens.White, centerX, centerY, x1b, y1b)
        '繪出本次連接線
        g.DrawLine(Pens.Black, centerX, centerY, x1, y1)
        '保留本次X、Y座標值
        x1b = x1
        y1b = y1
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        Dim Pen1 As New System.Drawing.Pen(Color.Black, 5)
        g.DrawLine(Pen1, centerX, centerY, centerX - 30, centerY + 250)
        g.DrawLine(Pen1, centerX, centerY, centerX + 30, centerY + 250)
        g.DrawLine(Pen1, centerX - 27, centerY + 225, centerX + 27, centerY + 225)
    End Sub
End Class
