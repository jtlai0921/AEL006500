Public Class Form1

    Dim dx, dy As Integer
    Dim openFlag As Boolean

    Dim apple(10) As PictureBox
    Dim appleEat(10) As Boolean
    Dim visibleCount As Integer
    Dim accSec As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        openFlag = True
        visibleCount = 0
        Timer1.Interval = 1000
        Timer1.Enabled = True
        accSec = 0

        Dim generator As New Random
        For i = 1 To 10
            appleEat(i) = False
            apple(i) = New PictureBox

            Dim x1, y1 As Integer
            x1 = generator.Next(1, 400)
            y1 = generator.Next(1, 300)

            With apple(i)
                .Image = My.Resources.apple1
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Size = New Size(30, 30)
                .Visible = True
                .Location = New Point(x1, y1)
            End With

            Me.Controls.Add(apple(i))
        Next
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
        SGhostPBox.Location = New Point(SGhostPBox.Location.X + 10 * dx, SGhostPBox.Location.Y + 10 * dy)
        checkEat()
        openFlag = Not openFlag
    End Sub

    Sub checkEat()
        For i = 1 To 10
            If apple(i).Left > SGhostPBox.Left - 20 And apple(i).Left < SGhostPBox.Left + 55 And apple(i).Top > SGhostPBox.Top - 20 And apple(i).Top < SGhostPBox.Top + 55 Then
                If appleEat(i) = False Then
                    apple(i).Visible = False
                    visibleCount = visibleCount + 1
                    appleEat(i) = True
                End If
            End If
        Next
        If visibleCount = 10 Then
            Timer1.Enabled = False
            MsgBox("遊戲結束，成績：" & accSec & "秒")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        accSec = accSec + 1
        Label1.Text = "累計時間：" & accSec & "秒"
    End Sub
End Class
