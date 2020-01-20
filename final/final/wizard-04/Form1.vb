Public Class Form1
    Dim m_x, m_y, a_X, a_Y As Integer
    Dim mstp As Integer
    Dim mdir As String
    Dim mopen As Boolean
    Dim aapple(10) As PictureBox


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                mdir = "R"
            Case Keys.Down
                mdir = "D"
            Case Keys.Left
                mdir = "L"
            Case Keys.Up
                mdir = "U"
        End Select
        mopen = Not mopen
        pb_dir()
        pb_location()
        pb_image()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mopen = True
        mdir = "R"
        Timer1.Enabled = True
        mstp = 25
        r_apple()
        m_x = 0 : m_y = 0
        pb_ghost.Location = New Point(m_x, m_y)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
    Private Sub pb_dir()
        Select Case mdir
            Case "R"
                If m_x >= 400 Then m_x = 0
            Case "D"
                If m_y >= 400 Then m_y = 0
            Case "L"
                If m_x <= 0 Then m_x = 400
            Case "U"
                If m_y <= 0 Then m_y = 400
        End Select
    End Sub
    Private Sub pb_location()
        Select Case mdir
            Case "R"
                m_x = m_x + mstp : m_y = m_y + 0
            Case "D"
                m_x = m_x + 0 : m_y = m_y + mstp
            Case "L"
                m_x = m_x - mstp : m_y = m_y + 0
            Case "U"
                m_x = m_x + 0 : m_y = m_y - mstp
        End Select
        pb_ghost.Location = New Point(m_x, m_y)
    End Sub
    Private Sub pb_image()

        Select Case True
            Case mdir = "R" And mopen
                pb_ghost.Image = My.Resources.ghost_r_o
            Case mdir = "R" And Not mopen
                pb_ghost.Image = My.Resources.ghost_r_c
            Case mdir = "D" And mopen
                pb_ghost.Image = My.Resources.ghost_d_o
            Case mdir = "D" And Not mopen
                pb_ghost.Image = My.Resources.ghost_d_c
            Case mdir = "L" And mopen
                pb_ghost.Image = My.Resources.ghost_l_o
            Case mdir = "L" And Not mopen
                pb_ghost.Image = My.Resources.ghost_l_c
            Case mdir = "U" And mopen
                pb_ghost.Image = My.Resources.ghost_u_o
            Case mdir = "U" And Not mopen
                pb_ghost.Image = My.Resources.ghost_u_c

        End Select

    End Sub
    Private Sub r_apple()

        For i = 1 To 10
            apple_location()
            aapple(i) = New PictureBox
            With aapple(i)
                .Image = My.Resources.apple1
                .Size = New Size(50, 50)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Visible = True
                .Location = New Point(a_X, a_Y)
            End With
            Me.Controls.Add(aapple(i))
        Next

    End Sub
    Private Sub apple_location()
        Randomize()
        a_X = Int(Rnd() * 400 / mstp) * mstp
        a_Y = Int(Rnd() * 400 / mstp) * mstp
    End Sub
End Class
