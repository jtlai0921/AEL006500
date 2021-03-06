﻿'畫接線、擺車廂、建立支架
'依圓形方向運行
'擴展成24個車廂


Public Class Form1
    Dim seat(24) As PictureBox
    Dim Ang(24) As Integer
    Dim Angs As Integer
    Dim centerX, centerY, radX, radY As Integer
    Dim x1b(24), y1b(24) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True
        Angs = 0
        centerX = 180
        centerY = 220
        radX = 150
        radY = 180
        Me.BackColor = Color.White
        '以迴路方式重覆24個車廂建立
        For i = 1 To 24
            seat(i) = New PictureBox
            With seat(i)
                .Image = Choose(i Mod 6 + 1, My.Resources.seatRed, My.Resources.seatOrange, My.Resources.seatYellow, My.Resources.seatGreen, My.Resources.seatBlue, My.Resources.seatPurple)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Size = New Size(24, 36)
                .BackColor = Color.White
            End With
            Me.Controls.Add(seat(i))
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim g As Graphics = Me.CreateGraphics
        Angs = Angs + 1
        '以迴路方式重覆24個車廂位置設定及連接線設定
        For i = 1 To 24
            Dim x1, y1 As Integer
            Ang(i) = Angs + 15 * (i - 1)
            Dim AngPi = Ang(i) * 3.14 / 180
            x1 = centerX + radX * Math.Cos(AngPi)
            y1 = centerY + radY * Math.Sin(AngPi)
            With seat(i)
                .Location = New Point(x1, y1)
            End With
            g.DrawLine(Pens.White, centerX, centerY, x1b(i), y1b(i))
            g.DrawLine(Pens.Black, centerX, centerY, x1, y1)
            x1b(i) = x1
            y1b(i) = y1
        Next
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        Dim Pen1 As New System.Drawing.Pen(Color.Black, 5)
        g.DrawLine(Pen1, centerX, centerY, centerX - 30, centerY + 250)
        g.DrawLine(Pen1, centerX, centerY, centerX + 30, centerY + 250)
        g.DrawLine(Pen1, centerX - 27, centerY + 225, centerX + 27, centerY + 225)
    End Sub
End Class
