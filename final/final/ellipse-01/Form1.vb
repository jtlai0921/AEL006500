Public Class Form1

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g = Me.CreateGraphics
        Dim r1 = 173 : Dim r2 = 23
        Dim i = 0
        Dim cx = 200 : Dim cy = 200
        Dim ma, mb As Double
        Dim x, y As Integer
        Dim pi = 3.14159

        Do
            i = i + 5
            ma = i * pi / 180
            mb = ma * r2 / r1
            x = cx + r1 * Math.Cos(mb) + r2 * Math.Cos(ma)
            y = cy + r1 * Math.Sin(mb) + r2 * Math.Sin(ma)
            g.DrawEllipse(Pens.Black, x, y, 1, 1)
            For k = 1 To 1000000 : Next k
        Loop
    End Sub
End Class
