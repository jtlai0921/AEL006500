Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SGhostPBox.Location = New Point(SGhostPBox.Location.X + 20, SGhostPBox.Location.Y)
        If SGhostPBox.Location.X > 400 Then Timer1.Enabled = False
    End Sub
End Class
