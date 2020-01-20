Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText("voca.txt")

        With TextBox1
            .Font = New Font(Me.Font.Name, Me.Font.Size + 3, Me.Font.Style)
            .ScrollBars = ScrollBars.Vertical
            .Multiline = True
            .Height = 170
            .Text = fileContents
        End With
    End Sub
End Class
