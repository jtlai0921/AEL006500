Public Class Form1
    Dim dx, dy As Integer
    Dim openFlag As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        openFlag = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If SGhostPBox.Location.X < 400 And SGhostPBox.Location.Y < 20 Then
            dx = 1
            dy = 0
            If openFlag = True Then
                SGhostPBox.Image = My.Resources.openR
            Else
                SGhostPBox.Image = My.Resources.closeR
            End If
        End If

        If SGhostPBox.Location.X > 400 And SGhostPBox.Location.Y < 350 Then
            dx = 0
            dy = 1
            If openFlag = True Then
                SGhostPBox.Image = My.Resources.openD
            Else
                SGhostPBox.Image = My.Resources.closeD
            End If
        End If

        If SGhostPBox.Location.X > 400 And SGhostPBox.Location.Y >= 350 Then
            dx = -1
            dy = 0
            If openFlag = False Then
                SGhostPBox.Image = My.Resources.openL
            Else
                SGhostPBox.Image = My.Resources.closeL
            End If
        End If

        If SGhostPBox.Location.X < 20 And SGhostPBox.Location.Y >= 350 Then
            dx = 0
            dy = -1
            If openFlag = False Then
                SGhostPBox.Image = My.Resources.openU
            Else
                SGhostPBox.Image = My.Resources.closeU
            End If
        End If

        SGhostPBox.Location = New Point(SGhostPBox.Location.X + 20 * dx, SGhostPBox.Location.Y + 20 * dy)
        openFlag = Not openFlag
    End Sub
End Class
