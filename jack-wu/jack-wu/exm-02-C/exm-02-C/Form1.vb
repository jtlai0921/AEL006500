Public Class Form1
    Dim dx, dy As Integer
    Dim openFlag As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        dx = 1
        dy = 0
        openFlag = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If openFlag = True Then
            SGhostPBox.Image = My.Resources.openR
        Else
            SGhostPBox.Image = My.Resources.closeR
        End If

        If SGhostPBox.Location.X > 400 Then
            dx = 0
            dy = 1
            If openFlag = True Then
                SGhostPBox.Image = My.Resources.openD
            Else
                SGhostPBox.Image = My.Resources.closeD
            End If
        End If
        SGhostPBox.Location = New Point(SGhostPBox.Location.X + 20 * dx, SGhostPBox.Location.Y + 20 * dy)
        If SGhostPBox.Location.Y > 350 Then Timer1.Enabled = False
        openFlag = Not openFlag
    End Sub
End Class
