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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_start = New System.Windows.Forms.Button
        Me.btn_stop = New System.Windows.Forms.Button
        Me.btn_cont = New System.Windows.Forms.Button
        Me.btn_end = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nud_r1 = New System.Windows.Forms.NumericUpDown
        Me.nud_r2 = New System.Windows.Forms.NumericUpDown
        CType(Me.nud_r1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_r2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(12, 479)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(50, 23)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "開始"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(68, 479)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(50, 23)
        Me.btn_stop.TabIndex = 1
        Me.btn_stop.Text = "暫停"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_cont
        '
        Me.btn_cont.Location = New System.Drawing.Point(124, 479)
        Me.btn_cont.Name = "btn_cont"
        Me.btn_cont.Size = New System.Drawing.Size(50, 23)
        Me.btn_cont.TabIndex = 2
        Me.btn_cont.Text = "繼續"
        Me.btn_cont.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(180, 479)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(50, 23)
        Me.btn_end.TabIndex = 3
        Me.btn_end.Text = "結束"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "內圓半徑"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "外圓半徑"
        '
        'nud_r1
        '
        Me.nud_r1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_r1.Location = New System.Drawing.Point(296, 479)
        Me.nud_r1.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nud_r1.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.nud_r1.Name = "nud_r1"
        Me.nud_r1.Size = New System.Drawing.Size(60, 26)
        Me.nud_r1.TabIndex = 6
        Me.nud_r1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_r1.Value = New Decimal(New Integer() {113, 0, 0, 0})
        '
        'nud_r2
        '
        Me.nud_r2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_r2.Location = New System.Drawing.Point(427, 479)
        Me.nud_r2.Maximum = New Decimal(New Integer() {130, 0, 0, 0})
        Me.nud_r2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nud_r2.Name = "nud_r2"
        Me.nud_r2.Size = New System.Drawing.Size(60, 26)
        Me.nud_r2.TabIndex = 7
        Me.nud_r2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nud_r2.Value = New Decimal(New Integer() {53, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 514)
        Me.Controls.Add(Me.nud_r2)
        Me.Controls.Add(Me.nud_r1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_cont)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nud_r1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_r2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents btn_cont As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nud_r1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_r2 As System.Windows.Forms.NumericUpDown

End Class
