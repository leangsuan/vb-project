<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripCheckin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripCheckout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripGuest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripRoom = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripHistory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSetting = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripExit = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLogin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripCheckin, Me.ToolStripSeparator3, Me.ToolStripCheckout, Me.ToolStripSeparator2, Me.ToolStripGuest, Me.ToolStripRoom, Me.ToolStripSeparator1, Me.ToolStripHistory, Me.ToolStripSeparator5, Me.ToolStripSetting, Me.ToolStripSeparator7, Me.ToolStripExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(863, 23)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripCheckin
        '
        Me.ToolStripCheckin.Image = CType(resources.GetObject("ToolStripCheckin.Image"), System.Drawing.Image)
        Me.ToolStripCheckin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCheckin.Name = "ToolStripCheckin"
        Me.ToolStripCheckin.Size = New System.Drawing.Size(73, 20)
        Me.ToolStripCheckin.Text = "Check in"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripCheckout
        '
        Me.ToolStripCheckout.Image = CType(resources.GetObject("ToolStripCheckout.Image"), System.Drawing.Image)
        Me.ToolStripCheckout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCheckout.Name = "ToolStripCheckout"
        Me.ToolStripCheckout.Size = New System.Drawing.Size(68, 20)
        Me.ToolStripCheckout.Text = "ชำระเงิน"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripGuest
        '
        Me.ToolStripGuest.Image = CType(resources.GetObject("ToolStripGuest.Image"), System.Drawing.Image)
        Me.ToolStripGuest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripGuest.Name = "ToolStripGuest"
        Me.ToolStripGuest.Size = New System.Drawing.Size(120, 20)
        Me.ToolStripGuest.Text = "แก้ไขข้อมูลผู้เข้าพัก"
        '
        'ToolStripRoom
        '
        Me.ToolStripRoom.Image = CType(resources.GetObject("ToolStripRoom.Image"), System.Drawing.Image)
        Me.ToolStripRoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripRoom.Name = "ToolStripRoom"
        Me.ToolStripRoom.Size = New System.Drawing.Size(114, 20)
        Me.ToolStripRoom.Text = "รายละเอียดห้องพัก"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripHistory
        '
        Me.ToolStripHistory.Image = CType(resources.GetObject("ToolStripHistory.Image"), System.Drawing.Image)
        Me.ToolStripHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripHistory.Name = "ToolStripHistory"
        Me.ToolStripHistory.Size = New System.Drawing.Size(74, 20)
        Me.ToolStripHistory.Text = "ผู้ค้างชำระ"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripSetting
        '
        Me.ToolStripSetting.Image = CType(resources.GetObject("ToolStripSetting.Image"), System.Drawing.Image)
        Me.ToolStripSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSetting.Name = "ToolStripSetting"
        Me.ToolStripSetting.Size = New System.Drawing.Size(76, 20)
        Me.ToolStripSetting.Text = "ตั้งค่าระบบ"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripExit
        '
        Me.ToolStripExit.Image = CType(resources.GetObject("ToolStripExit.Image"), System.Drawing.Image)
        Me.ToolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripExit.Name = "ToolStripExit"
        Me.ToolStripExit.Size = New System.Drawing.Size(45, 20)
        Me.ToolStripExit.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(863, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLogin})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 23)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(47, 401)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLogin
        '
        Me.ToolStripLogin.Image = CType(resources.GetObject("ToolStripLogin.Image"), System.Drawing.Image)
        Me.ToolStripLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLogin.Name = "ToolStripLogin"
        Me.ToolStripLogin.Size = New System.Drawing.Size(46, 51)
        Me.ToolStripLogin.Text = "LOGIN"
        Me.ToolStripLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 446)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Dormitory Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripRoom As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCheckin As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripCheckout As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripGuest As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLogin As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSetting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator

End Class
