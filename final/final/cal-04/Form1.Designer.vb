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
        Me.lbl_ctype = New System.Windows.Forms.Label
        Me.btn_new = New System.Windows.Forms.Button
        Me.btn_check = New System.Windows.Forms.Button
        Me.pb_ans = New System.Windows.Forms.PictureBox
        Me.gb_ctype = New System.Windows.Forms.GroupBox
        Me.rb_plus = New System.Windows.Forms.RadioButton
        Me.rb_minus = New System.Windows.Forms.RadioButton
        Me.rb_prod = New System.Windows.Forms.RadioButton
        Me.rb_div = New System.Windows.Forms.RadioButton
        CType(Me.pb_ans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_ctype.SuspendLayout()
        Me.SuspendLayout()
        '
        'A
        '
        Me.A.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A.Location = New System.Drawing.Point(40, 92)
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
        Me.B.Location = New System.Drawing.Point(40, 132)
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
        Me.C.Location = New System.Drawing.Point(40, 193)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(100, 27)
        Me.C.TabIndex = 2
        Me.C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "-------------------------------"
        '
        'lbl_ctype
        '
        Me.lbl_ctype.AutoSize = True
        Me.lbl_ctype.Location = New System.Drawing.Point(17, 141)
        Me.lbl_ctype.Name = "lbl_ctype"
        Me.lbl_ctype.Size = New System.Drawing.Size(11, 12)
        Me.lbl_ctype.TabIndex = 4
        Me.lbl_ctype.Text = "+"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(163, 96)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 6
        Me.btn_new.Text = "出題"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(65, 229)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(75, 23)
        Me.btn_check.TabIndex = 5
        Me.btn_check.Text = "檢查答案"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'pb_ans
        '
        Me.pb_ans.Image = Global.cal.My.Resources.Resources.blank
        Me.pb_ans.Location = New System.Drawing.Point(153, 152)
        Me.pb_ans.Name = "pb_ans"
        Me.pb_ans.Size = New System.Drawing.Size(100, 100)
        Me.pb_ans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ans.TabIndex = 7
        Me.pb_ans.TabStop = False
        '
        'gb_ctype
        '
        Me.gb_ctype.Controls.Add(Me.rb_div)
        Me.gb_ctype.Controls.Add(Me.rb_prod)
        Me.gb_ctype.Controls.Add(Me.rb_minus)
        Me.gb_ctype.Controls.Add(Me.rb_plus)
        Me.gb_ctype.Location = New System.Drawing.Point(19, 13)
        Me.gb_ctype.Name = "gb_ctype"
        Me.gb_ctype.Size = New System.Drawing.Size(234, 57)
        Me.gb_ctype.TabIndex = 8
        Me.gb_ctype.TabStop = False
        Me.gb_ctype.Text = "運算選項"
        '
        'rb_plus
        '
        Me.rb_plus.AutoSize = True
        Me.rb_plus.Location = New System.Drawing.Point(31, 21)
        Me.rb_plus.Name = "rb_plus"
        Me.rb_plus.Size = New System.Drawing.Size(29, 16)
        Me.rb_plus.TabIndex = 0
        Me.rb_plus.TabStop = True
        Me.rb_plus.Text = "+"
        Me.rb_plus.UseVisualStyleBackColor = True
        '
        'rb_minus
        '
        Me.rb_minus.AutoSize = True
        Me.rb_minus.Location = New System.Drawing.Point(94, 21)
        Me.rb_minus.Name = "rb_minus"
        Me.rb_minus.Size = New System.Drawing.Size(27, 16)
        Me.rb_minus.TabIndex = 1
        Me.rb_minus.TabStop = True
        Me.rb_minus.Text = "-"
        Me.rb_minus.UseVisualStyleBackColor = True
        '
        'rb_prod
        '
        Me.rb_prod.AutoSize = True
        Me.rb_prod.Location = New System.Drawing.Point(144, 21)
        Me.rb_prod.Name = "rb_prod"
        Me.rb_prod.Size = New System.Drawing.Size(29, 16)
        Me.rb_prod.TabIndex = 2
        Me.rb_prod.TabStop = True
        Me.rb_prod.Text = "x"
        Me.rb_prod.UseVisualStyleBackColor = True
        '
        'rb_div
        '
        Me.rb_div.AutoSize = True
        Me.rb_div.Location = New System.Drawing.Point(202, 21)
        Me.rb_div.Name = "rb_div"
        Me.rb_div.Size = New System.Drawing.Size(26, 16)
        Me.rb_div.TabIndex = 3
        Me.rb_div.TabStop = True
        Me.rb_div.Text = "/"
        Me.rb_div.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.gb_ctype)
        Me.Controls.Add(Me.pb_ans)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.lbl_ctype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb_ans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_ctype.ResumeLayout(False)
        Me.gb_ctype.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents A As System.Windows.Forms.TextBox
    Friend WithEvents B As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_ctype As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents pb_ans As System.Windows.Forms.PictureBox
    Friend WithEvents gb_ctype As System.Windows.Forms.GroupBox
    Friend WithEvents rb_div As System.Windows.Forms.RadioButton
    Friend WithEvents rb_prod As System.Windows.Forms.RadioButton
    Friend WithEvents rb_minus As System.Windows.Forms.RadioButton
    Friend WithEvents rb_plus As System.Windows.Forms.RadioButton

End Class
