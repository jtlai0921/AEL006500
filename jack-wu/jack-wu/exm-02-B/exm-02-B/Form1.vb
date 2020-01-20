Public Class Form1
    Dim dx, dy As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        dx = 1
        dy = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If SGhostPBox.Location.X > 400 Then
            dx = 0
            dy = 1
            SGhostPBox.Image = My.Resources.sghostD
        End If
        SGhostPBox.Location = New Point(SGhostPBox.Location.X + 20 * dx, SGhostPBox.Location.Y + 20 * dy)
        If SGhostPBox.Location.Y > 350 Then Timer1.Enabled = False
    End Sub
End Class
