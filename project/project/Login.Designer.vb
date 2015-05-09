<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Textuser = New System.Windows.Forms.TextBox()
        Me.Textpass = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Textuser
        '
        Me.Textuser.Location = New System.Drawing.Point(142, 35)
        Me.Textuser.Name = "Textuser"
        Me.Textuser.Size = New System.Drawing.Size(100, 22)
        Me.Textuser.TabIndex = 1
        '
        'Textpass
        '
        Me.Textpass.Location = New System.Drawing.Point(142, 85)
        Me.Textpass.Name = "Textpass"
        Me.Textpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Textpass.Size = New System.Drawing.Size(100, 22)
        Me.Textpass.TabIndex = 2
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonLogin.Image = CType(resources.GetObject("ButtonLogin.Image"), System.Drawing.Image)
        Me.ButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogin.Location = New System.Drawing.Point(55, 169)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(87, 53)
        Me.ButtonLogin.TabIndex = 3
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(64, 35)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(74, 14)
        Me.LabelUsername.TabIndex = 4
        Me.LabelUsername.Text = "Username :"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(64, 88)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(74, 14)
        Me.LabelPassword.TabIndex = 5
        Me.LabelPassword.Text = "Password :"
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonExit.Image = CType(resources.GetObject("ButtonExit.Image"), System.Drawing.Image)
        Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExit.Location = New System.Drawing.Point(181, 169)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(86, 53)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExit.UseCompatibleTextRendering = True
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Textuser)
        Me.GroupBox1.Controls.Add(Me.LabelPassword)
        Me.GroupBox1.Controls.Add(Me.Textpass)
        Me.GroupBox1.Controls.Add(Me.LabelUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 141)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(340, 244)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonLogin)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Textuser As System.Windows.Forms.TextBox
    Friend WithEvents Textpass As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents LabelUsername As System.Windows.Forms.Label
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
