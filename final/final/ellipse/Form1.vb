Public Class Form1
    Dim g As Graphics
    Dim r1 = 173 : Dim r2 = 23
    Dim i = 0

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mypen As New Pen(Color.FromArgb(255, 0, 0, 0), 2)
        Timer1.Interval = 1
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        g = Me.CreateGraphics
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim cx = 200 : Dim cy = 200
        Dim ma, mb As Double
        Dim x, y As Integer
        Dim pi = 3.14159

        Dim mypen As New Pen(Color.FromArgb(tb_alpha.Value, tb_red.Value _
                                            , tb_green.Value, tb_blue.Value), 2)
        i = i + 5
        ma = i * pi / 180
        mb = ma * r2 / r1
        x = cx + r1 * Math.Cos(mb) + r2 * Math.Cos(ma)
        y = cy + r1 * Math.Sin(mb) + r2 * Math.Sin(ma)
        g.DrawEllipse(mypen, x, y, 1, 1)
    End Sub

    Private Sub btn_start_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_start.Click
        Timer1.Enabled = True
        r1 = nud_r1.Value
        r2 = nud_r2.Value
    End Sub

    Private Sub btn_end_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_stop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub btn_cont_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cont.Click
        Timer1.Enabled = True
        r1 = nud_r1.Value
        r2 = nud_r2.Value
    End Sub


End Class
