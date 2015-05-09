<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.CheckPaid = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextRental = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboRoom = New System.Windows.Forms.ComboBox()
        Me.ComboFloor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextWater = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextElectric = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboMonth = New System.Windows.Forms.ComboBox()
        Me.ComboYear = New System.Windows.Forms.ComboBox()
        Me.Dormitoryname = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(102, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Back"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonPreview
        '
        Me.ButtonPreview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonPreview.Location = New System.Drawing.Point(533, 126)
        Me.ButtonPreview.Name = "ButtonPreview"
        Me.ButtonPreview.Size = New System.Drawing.Size(177, 28)
        Me.ButtonPreview.TabIndex = 56
        Me.ButtonPreview.Text = "ตัวอย่างก่อนพิมพ์"
        Me.ButtonPreview.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonPrint.Location = New System.Drawing.Point(533, 96)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(177, 28)
        Me.ButtonPrint.TabIndex = 55
        Me.ButtonPrint.Text = "พิมพ์ใบเสร็จ"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(533, 58)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(177, 28)
        Me.ButtonDelete.TabIndex = 65
        Me.ButtonDelete.Text = "ลบข้อมูล"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'TextTotal
        '
        Me.TextTotal.Enabled = False
        Me.TextTotal.ForeColor = System.Drawing.Color.Navy
        Me.TextTotal.Location = New System.Drawing.Point(134, 244)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.ReadOnly = True
        Me.TextTotal.Size = New System.Drawing.Size(139, 22)
        Me.TextTotal.TabIndex = 64
        Me.TextTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckPaid
        '
        Me.CheckPaid.AutoSize = True
        Me.CheckPaid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckPaid.Location = New System.Drawing.Point(297, 243)
        Me.CheckPaid.Name = "CheckPaid"
        Me.CheckPaid.Size = New System.Drawing.Size(75, 18)
        Me.CheckPaid.TabIndex = 63
        Me.CheckPaid.Text = "ชำระแล้ว"
        Me.CheckPaid.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 14)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "รวม :"
        '
        'TextRental
        '
        Me.TextRental.Enabled = False
        Me.TextRental.ForeColor = System.Drawing.Color.Navy
        Me.TextRental.Location = New System.Drawing.Point(134, 121)
        Me.TextRental.Name = "TextRental"
        Me.TextRental.ReadOnly = True
        Me.TextRental.Size = New System.Drawing.Size(139, 22)
        Me.TextRental.TabIndex = 61
        Me.TextRental.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "ค่าเช่าห้อง :"
        '
        'ComboRoom
        '
        Me.ComboRoom.ForeColor = System.Drawing.Color.Navy
        Me.ComboRoom.FormattingEnabled = True
        Me.ComboRoom.Location = New System.Drawing.Point(199, 83)
        Me.ComboRoom.Name = "ComboRoom"
        Me.ComboRoom.Size = New System.Drawing.Size(74, 22)
        Me.ComboRoom.TabIndex = 59
        '
        'ComboFloor
        '
        Me.ComboFloor.ForeColor = System.Drawing.Color.Navy
        Me.ComboFloor.FormattingEnabled = True
        Me.ComboFloor.Location = New System.Drawing.Point(133, 83)
        Me.ComboFloor.Name = "ComboFloor"
        Me.ComboFloor.Size = New System.Drawing.Size(55, 22)
        Me.ComboFloor.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 14)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "ชั้น/ห้อง :"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(86, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(550, 2)
        Me.Label10.TabIndex = 68
        '
        'TextWater
        '
        Me.TextWater.ForeColor = System.Drawing.Color.Navy
        Me.TextWater.Location = New System.Drawing.Point(134, 163)
        Me.TextWater.Name = "TextWater"
        Me.TextWater.Size = New System.Drawing.Size(139, 22)
        Me.TextWater.TabIndex = 70
        Me.TextWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "ค่าน้ำ :"
        '
        'TextElectric
        '
        Me.TextElectric.ForeColor = System.Drawing.Color.Navy
        Me.TextElectric.Location = New System.Drawing.Point(134, 203)
        Me.TextElectric.Name = "TextElectric"
        Me.TextElectric.Size = New System.Drawing.Size(139, 22)
        Me.TextElectric.TabIndex = 72
        Me.TextElectric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 14)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "ค่าไฟ :"
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(533, 20)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(177, 28)
        Me.ButtonSave.TabIndex = 65
        Me.ButtonSave.Text = "บันทึกข้อมูล"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "ประจำเดือน/ปี :"
        '
        'ComboMonth
        '
        Me.ComboMonth.ForeColor = System.Drawing.Color.Navy
        Me.ComboMonth.FormattingEnabled = True
        Me.ComboMonth.Location = New System.Drawing.Point(133, 44)
        Me.ComboMonth.Name = "ComboMonth"
        Me.ComboMonth.Size = New System.Drawing.Size(55, 22)
        Me.ComboMonth.TabIndex = 58
        '
        'ComboYear
        '
        Me.ComboYear.ForeColor = System.Drawing.Color.Navy
        Me.ComboYear.FormattingEnabled = True
        Me.ComboYear.Location = New System.Drawing.Point(199, 44)
        Me.ComboYear.Name = "ComboYear"
        Me.ComboYear.Size = New System.Drawing.Size(74, 22)
        Me.ComboYear.TabIndex = 59
        '
        'Dormitoryname
        '
        Me.Dormitoryname.AutoSize = True
        Me.Dormitoryname.Location = New System.Drawing.Point(255, 336)
        Me.Dormitoryname.Name = "Dormitoryname"
        Me.Dormitoryname.Size = New System.Drawing.Size(11, 14)
        Me.Dormitoryname.TabIndex = 73
        Me.Dormitoryname.Text = "."
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(255, 354)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(11, 14)
        Me.Address.TabIndex = 73
        Me.Address.Text = "."
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 388)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Dormitoryname)
        Me.Controls.Add(Me.TextElectric)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextWater)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.CheckPaid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextRental)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboYear)
        Me.Controls.Add(Me.ComboMonth)
        Me.Controls.Add(Me.ComboRoom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboFloor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonPreview)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonPreview As System.Windows.Forms.Button
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents CheckPaid As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextRental As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboRoom As System.Windows.Forms.ComboBox
    Friend WithEvents ComboFloor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextWater As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextElectric As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents ComboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Dormitoryname As System.Windows.Forms.Label
    Friend WithEvents Address As System.Windows.Forms.Label
End Class
