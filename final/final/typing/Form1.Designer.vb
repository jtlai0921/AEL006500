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
        Me.components = New System.ComponentModel.Container
        Me.txt_keyin = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.com_level = New System.Windows.Forms.ComboBox
        Me.btn_new = New System.Windows.Forms.Button
        Me.btn_stop = New System.Windows.Forms.Button
        Me.btn_fsize = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_keyin
        '
        Me.txt_keyin.Location = New System.Drawing.Point(220, 440)
        Me.txt_keyin.Name = "txt_keyin"
        Me.txt_keyin.Size = New System.Drawing.Size(100, 22)
        Me.txt_keyin.TabIndex = 1
        '
        'Timer1
        '
        '
        'com_level
        '
        Me.com_level.FormattingEnabled = True
        Me.com_level.Items.AddRange(New Object() {"初級", "中級", "高級", "超級"})
        Me.com_level.Location = New System.Drawing.Point(2, 2)
        Me.com_level.Name = "com_level"
        Me.com_level.Size = New System.Drawing.Size(121, 20)
        Me.com_level.TabIndex = 2
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(2, 44)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 3
        Me.btn_new.Text = "重新開始"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(2, 73)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(75, 23)
        Me.btn_stop.TabIndex = 4
        Me.btn_stop.Text = "暫停"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_fsize
        '
        Me.btn_fsize.Location = New System.Drawing.Point(2, 102)
        Me.btn_fsize.Name = "btn_fsize"
        Me.btn_fsize.Size = New System.Drawing.Size(75, 23)
        Me.btn_fsize.TabIndex = 6
        Me.btn_fsize.Text = "字體加大"
        Me.btn_fsize.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 464)
        Me.Controls.Add(Me.btn_fsize)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.com_level)
        Me.Controls.Add(Me.txt_keyin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_keyin As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents com_level As System.Windows.Forms.ComboBox
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents btn_fsize As System.Windows.Forms.Button

End Class
