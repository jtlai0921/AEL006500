<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_title = New System.Windows.Forms.TextBox
        Me.txt_cont = New System.Windows.Forms.TextBox
        Me.txt_marqee = New System.Windows.Forms.TextBox
        Me.btn_end = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(0, -1)
        Me.txt_title.Multiline = True
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(100, 22)
        Me.txt_title.TabIndex = 0
        '
        'txt_cont
        '
        Me.txt_cont.Location = New System.Drawing.Point(0, 27)
        Me.txt_cont.Multiline = True
        Me.txt_cont.Name = "txt_cont"
        Me.txt_cont.Size = New System.Drawing.Size(100, 22)
        Me.txt_cont.TabIndex = 1
        '
        'txt_marqee
        '
        Me.txt_marqee.Location = New System.Drawing.Point(0, 55)
        Me.txt_marqee.Multiline = True
        Me.txt_marqee.Name = "txt_marqee"
        Me.txt_marqee.Size = New System.Drawing.Size(100, 22)
        Me.txt_marqee.TabIndex = 2
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(206, 240)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 23)
        Me.btn_end.TabIndex = 3
        Me.btn_end.Text = "結束"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.txt_marqee)
        Me.Controls.Add(Me.txt_cont)
        Me.Controls.Add(Me.txt_title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_title As System.Windows.Forms.TextBox
    Friend WithEvents txt_cont As System.Windows.Forms.TextBox
    Friend WithEvents txt_marqee As System.Windows.Forms.TextBox
    Friend WithEvents btn_end As System.Windows.Forms.Button

End Class
