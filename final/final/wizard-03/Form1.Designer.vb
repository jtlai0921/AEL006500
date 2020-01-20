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
        Me.pb_ghost = New System.Windows.Forms.PictureBox
        CType(Me.pb_ghost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_ghost
        '
        Me.pb_ghost.Image = Global.wizard.My.Resources.Resources.ghost_r_o
        Me.pb_ghost.Location = New System.Drawing.Point(247, 96)
        Me.pb_ghost.Name = "pb_ghost"
        Me.pb_ghost.Size = New System.Drawing.Size(50, 50)
        Me.pb_ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ghost.TabIndex = 0
        Me.pb_ghost.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 464)
        Me.Controls.Add(Me.pb_ghost)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb_ghost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pb_ghost As System.Windows.Forms.PictureBox

End Class
