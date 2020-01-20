Public Class Form2

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mfile = My.Computer.FileSystem.ReadAllText("error.txt")
        Dim aline = Split(mfile, vbNewLine)

        For i = 0 To UBound(aline)
            lb_err.Items.Add(aline(i))
        Next

    End Sub
End Class