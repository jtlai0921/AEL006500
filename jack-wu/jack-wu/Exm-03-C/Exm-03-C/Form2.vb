Imports Microsoft.VisualBasic.FileIO

Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText("errLog.txt")

        '分列打散至陣列
        Dim lineArray As Array = Split(fileContents, vbNewLine)

        '氣泡排序
        Dim recAmount = UBound(lineArray)
        For k As Integer = 0 To recAmount - 1
            For j = 0 To recAmount - 1
                If lineArray(j) < lineArray(j + 1) Then
                    Dim tem = lineArray(j)
                    lineArray(j) = lineArray(j + 1)
                    lineArray(j + 1) = tem
                End If
            Next
        Next

        '匯總並加註筆數
        Dim i = 0
        While lineArray(i) <> ""
            Dim ctr = 1
            Dim j = i + 1
            While lineArray(j) = lineArray(i)
                ctr = ctr + 1
                lineArray(j) = ""
                j = j + 1
            End While
            lineArray(i) = lineArray(i) & "," & ctr
            i = j
        End While

        '氣泡排序 -- 把非空白資料集中
        For k As Integer = 0 To recAmount - 1
            For j = 0 To recAmount - 1
                If lineArray(j) < lineArray(j + 1) Then
                    Dim tem = lineArray(j)
                    lineArray(j) = lineArray(j + 1)
                    lineArray(j + 1) = tem
                End If
            Next
        Next

        '算出非空白筆數
        Dim ctr2 = 0
        Dim M = 0
        While lineArray(M) <> ""
            ctr2 = ctr2 + 1
            M = M + 1
        End While

        '氣泡排序-以日期欄位為鍵值
        For k As Integer = 0 To ctr2 - 1
            For j = 0 To ctr2 - 1 - 1
                Dim columnArray_j As Array = Split(lineArray(j), ",")
                Dim columnArray_jp As Array = Split(lineArray(j + 1), ",")
                If columnArray_j(2) < columnArray_jp(2) Then
                    Dim tem = lineArray(j)
                    lineArray(j) = lineArray(j + 1)
                    lineArray(j + 1) = tem
                End If
            Next
        Next

        '輸出至List
        For i = 0 To recAmount - 1
            If lineArray(i) <> "" Then
                Dim columnArray As Array = Split(lineArray(i), ",")
                Dim temStr = columnArray(0) & vbTab
                temStr &= columnArray(1) & vbTab
                temStr &= columnArray(2) & vbTab
                temStr &= columnArray(3)
                ListBox1.Items.Add(temStr)
            End If
        Next

        '輸出至Error.txt
        Dim temStr1 = ""
        i = 0
        While lineArray(i) <> ""
            temStr1 &= lineArray(i) & vbNewLine
            i = i + 1
        End While
        My.Computer.FileSystem.WriteAllText("Error.txt", temStr1, False)
    End Sub
End Class