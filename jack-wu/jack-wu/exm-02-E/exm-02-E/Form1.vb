Public Class Form1

    Dim dx, dy As Integer
    Dim openFlag As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openFlag = True
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                dx = -1
                dy = 0
                If openFlag = False Then
                    SGhostPBox.Image = My.Resources.openL
                Else
                    SGhostPBox.Image = My.Resources.closeL
                End If
            Case Keys.Right
                dx = 1
                dy = 0
                If openFlag = True Then
                    SGhostPBox.Image = My.Resources.openR
                Else
                    SGhostPBox.Image = My.Resources.closeR
                End If
            Case Keys.Up
                dx = 0
                dy = -1
                If openFlag = False Then
                    SGhostPBox.Image = My.Resources.openU
                Else
                    SGhostPBox.Image = My.Resources.closeU
                End If
            Case Keys.Down
                dx = 0
                dy = 1
                If openFlag = True Then
                    SGhostPBox.Image = My.Resources.openD
                Else
                    SGhostPBox.Image = My.Resources.closeD
                End If
        End Select
        SGhostPBox.Location = New Point(SGhostPBox.Location.X + 20 * dx, SGhostPBox.Location.Y + 20 * dy)
        openFlag = Not openFlag
    End Sub

End Class
