Public Class Form1
    Dim ano(25), achi(25), aeng(25) As Label
    Dim aans(25) As TextBox
    Dim aeng_25(25), achi_25(25), ano_25(25), achi_25n(25)
    Dim aeng_10(10), achi_10(10), ano_10(10)
    WithEvents btn_score As Button = New Button
    WithEvents btn_end As Button = New Button
    WithEvents btn_review As Button = New Button


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        addcon()
        readdata()
        showdata()

        With btn_score
            .Location = New Point(100, 400)
            .Size = New Size(80, 30)
            .Text = "評分"
        End With
        Me.Controls.Add(btn_score)
        AddHandler btn_score.Click, AddressOf btn_score_Click

        With btn_end
            .Location = New Point(200, 400)
            .Size = New Size(80, 30)
            .Text = "結束"
        End With
        Me.Controls.Add(btn_end)
        AddHandler btn_end.Click, AddressOf btn_end_Click

        With btn_review
            .Location = New Point(300, 400)
            .Size = New Size(80, 30)
            .Text = "錯誤複習"
        End With
        Me.Controls.Add(btn_review)
        AddHandler btn_review.Click, AddressOf btn_review_Click

    End Sub
    Private Sub addcon()
        Me.Size = New Size(500, 500)

        Dim mx1 = 20 : Dim my1 = 20
        Dim mx2 = 20 : Dim my2 = 200

        Dim mdx1 = 20 : Dim mdx2 = 90 : Dim mdx3 = 30 : Dim mdx4 = 220
        Dim mdy1 = 30 : Dim mdy2 = 30

        Dim mh = 20 : Dim mwn = 20 : Dim mwc = 70 : Dim mwa = 20
        Dim mwe = 150


        Dim mno As Integer

        For i = 0 To 4
            For j = 1 To 5
                mno = i * 5 + j
                ano(mno) = New Label
                With ano(mno)
                    .Left = mx1 + (j - 1) * mdx2
                    .Top = my1 + i * mdy2
                    .Size = New Size(mwn, mh)
                    .Text = Chr(65 - 1 + mno)
                End With
                Me.Controls.Add(ano(mno))
            Next
        Next

        For i = 0 To 4
            For j = 1 To 5
                mno = i * 5 + j
                achi(mno) = New Label
                With achi(mno)
                    .Left = ano(mno).Left + mdx1
                    .Top = my1 + i * mdy2
                    .Size = New Size(mwc, mh)
                    .Text = "1234567890"
                End With
                Me.Controls.Add(achi(mno))
            Next
        Next

        For i = 0 To 4
            For j = 1 To 2
                mno = i * 2 + j
                aans(mno) = New TextBox
                With aans(mno)
                    .Left = mx2 + (j - 1) * mdx4
                    .Top = my2 + i * mdy2
                    .Size = New Size(mwa, mh)
                    .Text = "Z"
                End With
                Me.Controls.Add(aans(mno))
            Next
        Next

        For i = 0 To 4
            For j = 1 To 2
                mno = i * 2 + j
                aeng(mno) = New Label
                With aeng(mno)
                    .Left = aans(mno).Left + mdx3
                    .Top = my2 + i * mdy2
                    .Size = New Size(mwe, mh)
                    .Text = "1234567890"
                End With
                Me.Controls.Add(aeng(mno))
            Next
        Next
    End Sub
    Private Sub readdata()

        Dim mfile As String
        Dim aline As Array
        Dim gen As New Random
        Dim mrno As Integer
        mfile = My.Computer.FileSystem.ReadAllText("voca.txt")
        aline = Split(mfile, vbNewLine)

        For i = 0 To 24
            mrno = gen.Next(i, UBound(aline))
            Dim mtmp = aline(i)
            aline(i) = aline(mrno) : aline(mrno) = mtmp

            Dim atmp = Split(aline(i), ",")
            ano_25(i + 1) = Chr(65 + i)
            aeng_25(i + 1) = atmp(0)
            achi_25(i + 1) = atmp(1)
            achi_25n(i + 1) = atmp(1)
        Next
        For i = 1 To 10
            Dim mno = gen.Next(i, 25)
            Dim mtmp1 = ano_25(i)
            ano_25(i) = ano_25(mno) : ano_25(mno) = mtmp1

            Dim mtmp2 = aeng_25(i)
            aeng_25(i) = aeng_25(mno) : aeng_25(mno) = mtmp2

            Dim mtmp3 = achi_25(i)
            achi_25(i) = achi_25(mno) : achi_25(mno) = mtmp3

            ano_10(i) = ano_25(i) : aeng_10(i) = aeng_25(i) : achi_10(i) = achi_25(i)
        Next

    End Sub
    Private Sub showdata()
        For i = 1 To 25
            achi(i).text = achi_25n(i)
        Next
        For i = 1 To 10
            aeng(i).Text = aeng_10(i)
            aans(i).Text = ""
        Next
    End Sub

    Private Sub btn_score_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_score.Click
        Dim mfile = ""
        For i = 1 To 10
            If aans(i).Text <> ano_10(i) Then
                aans(i).BackColor = Color.Red
                mfile = mfile & aeng_10(i) & "," & achi_10(i) & vbNewLine
            End If
        Next
        My.Computer.FileSystem.WriteAllText("error.txt", mfile, False)
    End Sub

    Private Sub btn_end_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_end.Click

    End Sub

    Private Sub btn_review_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_review.Click

    End Sub
End Class
