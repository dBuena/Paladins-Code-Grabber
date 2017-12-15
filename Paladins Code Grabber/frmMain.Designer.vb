<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrHotkey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheckClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.lblClipboard = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrHotkey
        '
        Me.tmrHotkey.Enabled = True
        '
        'tmrCheckClipboard
        '
        Me.tmrCheckClipboard.Enabled = True
        Me.tmrCheckClipboard.Interval = 500
        '
        'lblClipboard
        '
        Me.lblClipboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClipboard.Location = New System.Drawing.Point(12, 9)
        Me.lblClipboard.Name = "lblClipboard"
        Me.lblClipboard.Size = New System.Drawing.Size(260, 47)
        Me.lblClipboard.TabIndex = 0
        Me.lblClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 65)
        Me.Controls.Add(Me.lblClipboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paladins Skin Code Grabber"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrHotkey As System.Windows.Forms.Timer
    Friend WithEvents tmrCheckClipboard As System.Windows.Forms.Timer
    Friend WithEvents lblClipboard As System.Windows.Forms.Label
End Class
