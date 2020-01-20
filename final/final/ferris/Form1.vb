Public Class Form1
    Dim mxc, myc As Integer
    Dim pb_car(24) As PictureBox
    Dim mcnt As Integer
    Dim mrx, mry, mrz, ma As Integer
    Dim maa As Double
    Dim ax(24), ay(24) As Integer
    Dim mrot As Integer



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackColor = Color.White
        Me.Size = New Size(550, 550)
        mxc = 250 : myc = 250
        mrx = 60 : mry = 200 : mrz = 1 : mrot = 0
        Timer1.Enabled = True
        car()

    End Sub
    
    Private Sub car()
        mcnt = 0
        For i = 0 To 3
            For j = 1 To 6
                mcnt = i * 6 + j
                pb_car(mcnt) = New PictureBox
                With pb_car(mcnt)
                    Select Case j
                        Case 1
                            .Image = My.Resources.seatBlue
                        Case 2
                            .Image = My.Resources.seatGreen
                        Case 3
                            .Image = My.Resources.seatOrange
                        Case 4
                            .Image = My.Resources.seatPurple
                        Case 5
                            .Image = My.Resources.seatRed
                        Case 6
                            .Image = My.Resources.seatYellow
                    End Select
                    .Size = New Size(24, 36)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                End With
                Me.Controls.Add(pb_car(mcnt))
            Next
        Next
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        Dim pen1 As New System.Drawing.Pen(Color.Black, 5)
        g.DrawLine(pen1, mxc, myc, mxc - 30, myc + 250)
        g.DrawLine(pen1, mxc, myc, mxc + 30, myc + 250)
        g.DrawLine(pen1, mxc - 25, myc + 225, mxc + 25, myc + 225)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim g As Graphics = Me.CreateGraphics
        If mrx > 60 Then mrz = -1
        If mrx < 1 Then mrz = 1
        mrx = mrx + mrz
        mrot = mrot + 1
        For i = 1 To 24
            g.DrawLine(Pens.White, mxc, myc, ax(i), ay(i))
            ma = i * 15 + mrot
            maa = ma * 3.14158 / 180
            ax(i) = mxc + mrx * Math.Cos(maa)
            ay(i) = myc + mry * Math.Sin(maa)
            pb_car(i).Location = New Point(ax(i), ay(i))
            g.DrawLine(Pens.Black, mxc, myc, ax(i), ay(i))
        Next
    End Sub
End Class
