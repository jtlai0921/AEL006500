'畫接線、擺車廂、建立支架

Public Class Form1
    '定義車廂
    Dim seat As PictureBox
    '定義中心點X,Y座標及X，Y軸長度
    Dim centerX, centerY, radX, radY As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '設摩天輪圓心及X，Y軸大小
        centerX = 180
        centerY = 220
        radX = 150
        radY = 150
        Me.BackColor = Color.White
        '建立車廂
        seat = New PictureBox
        With seat
            .Image = My.Resources.seatRed
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Size = New Size(24, 36)
            .BackColor = Color.White
        End With
        Me.Controls.Add(seat)
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        '繪出支架
        Dim Pen1 As New System.Drawing.Pen(Color.Black, 5)
        g.DrawLine(Pen1, centerX, centerY, centerX - 30, centerY + 250)
        g.DrawLine(Pen1, centerX, centerY, centerX + 30, centerY + 250)
        g.DrawLine(Pen1, centerX - 27, centerY + 225, centerX + 27, centerY + 225)
        '定車廂位置
        Dim x1, y1 As Integer
        x1 = centerX + radX
        y1 = centerY + radY
        With seat
            .Location = New Point(x1, y1)
        End With
        '繪出車廂與支架連接線
        g.DrawLine(Pens.Black, centerX, centerY, x1, y1)
    End Sub
End Class
