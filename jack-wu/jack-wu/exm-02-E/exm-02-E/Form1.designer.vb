<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.SGhostPBox = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SGhostPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SGhostPBox
        '
        Me.SGhostPBox.Image = Global.exm_02_E.My.Resources.Resources.openR
        Me.SGhostPBox.Location = New System.Drawing.Point(230, 221)
        Me.SGhostPBox.Name = "SGhostPBox"
        Me.SGhostPBox.Size = New System.Drawing.Size(55, 55)
        Me.SGhostPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SGhostPBox.TabIndex = 0
        Me.SGhostPBox.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(482, 425)
        Me.Controls.Add(Me.SGhostPBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SGhostPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SGhostPBox As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
