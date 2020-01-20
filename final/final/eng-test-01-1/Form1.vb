Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        addcon()

    End Sub
    Private Sub addcon()
        Me.Size = New Size(500, 500)

        Dim mx1 = 20 : Dim my1 = 20
        Dim mx2 = 20 : Dim my2 = 200

        Dim mdx1 = 20 : Dim mdx2 = 90 : Dim mdx3 = 30 : Dim mdx4 = 220
        Dim mdy1 = 30 : Dim mdy2 = 30

        Dim mh = 20 : Dim mwn = 20 : Dim mwc = 70 : Dim mwa = 20
        Dim mwe = 150

        Dim ano(25), achi(25), aeng(25) As Label
        Dim aans(25) As TextBox

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
                mno = i * 5 + j
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
                mno = i * 5 + j
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
End Class
