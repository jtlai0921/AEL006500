﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbl_drop = New System.Windows.Forms.Label
        Me.txt_keyin = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbl_drop
        '
        Me.lbl_drop.AutoSize = True
        Me.lbl_drop.Location = New System.Drawing.Point(133, 9)
        Me.lbl_drop.Name = "lbl_drop"
        Me.lbl_drop.Size = New System.Drawing.Size(17, 12)
        Me.lbl_drop.TabIndex = 0
        Me.lbl_drop.Text = "明"
        '
        'txt_keyin
        '
        Me.txt_keyin.Location = New System.Drawing.Point(96, 242)
        Me.txt_keyin.Name = "txt_keyin"
        Me.txt_keyin.Size = New System.Drawing.Size(100, 22)
        Me.txt_keyin.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.txt_keyin)
        Me.Controls.Add(Me.lbl_drop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_drop As System.Windows.Forms.Label
    Friend WithEvents txt_keyin As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
