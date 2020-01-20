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
        Me.A = New System.Windows.Forms.TextBox
        Me.B = New System.Windows.Forms.TextBox
        Me.C = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_new = New System.Windows.Forms.Button
        Me.btn_check = New System.Windows.Forms.Button
        Me.pb_ans = New System.Windows.Forms.PictureBox
        CType(Me.pb_ans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'A
        '
        Me.A.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A.Location = New System.Drawing.Point(40, 35)
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Size = New System.Drawing.Size(100, 27)
        Me.A.TabIndex = 0
        Me.A.TabStop = False
        Me.A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'B
        '
        Me.B.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B.Location = New System.Drawing.Point(40, 75)
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Size = New System.Drawing.Size(100, 27)
        Me.B.TabIndex = 1
        Me.B.TabStop = False
        Me.B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'C
        '
        Me.C.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.C.Location = New System.Drawing.Point(40, 136)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(100, 27)
        Me.C.TabIndex = 2
        Me.C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "-------------------------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "+"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(153, 200)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 6
        Me.btn_new.Text = "出題"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(65, 200)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(75, 23)
        Me.btn_check.TabIndex = 5
        Me.btn_check.Text = "檢查答案"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'pb_ans
        '
        Me.pb_ans.Image = Global.cal.My.Resources.Resources.blank
        Me.pb_ans.Location = New System.Drawing.Point(153, 35)
        Me.pb_ans.Name = "pb_ans"
        Me.pb_ans.Size = New System.Drawing.Size(100, 100)
        Me.pb_ans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ans.TabIndex = 7
        Me.pb_ans.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.pb_ans)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb_ans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents pb_ans As System.Windows.Forms.PictureBox

End Class
