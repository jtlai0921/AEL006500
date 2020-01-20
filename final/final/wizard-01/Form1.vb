Public Class Form1
    Dim m_x, m_y As Integer
    Dim mstp As Integer


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        mstp = 25
        m_x = 0 : m_y = 0
        pb_ghost.Location = New Point(m_x, m_y)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        m_x = m_x + mstp
        If m_x > 400 Then
            End
        Else
            pb_ghost.Location = New Point(m_x, m_y)
        End If

    End Sub
End Class
