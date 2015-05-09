Imports System.Data
Imports System.Data.SqlClient
Public Class Edit
    Private numFloors, RoomsPerFloor As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Main.ToolStripCheckin.Enabled = True
        Main.ToolStripRoom.Enabled = True
        Main.ToolStripCheckout.Enabled = True
        Main.ToolStripGuest.Enabled = True
        Main.ToolStripHistory.Enabled = True

        Main.ToolStripSetting.Enabled = True
        Main.ToolStripExit.Enabled = True
    End Sub
    Private Sub Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New SqlConnection(constr)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        sql = "SELECT * FROM Roomset"
        command = New SqlCommand(sql, connection)
        reader = command.ExecuteReader()
        While reader.Read()
            numFloors = reader("NumFloors")
            RoomsPerFloor = reader("RoomsPerFloor")
        End While


        For f = 1 To numFloors
            ComboFloor.Items.Add(f)
        Next

        ComboTitle.Items.AddRange(New String() {"นาย", "นาง", "นางสาว"})

        dataSt = New DataSet()
        bindingSrc = New BindingSource()



        If reader.HasRows Then
            reader.Close()
            ComboFloor.SelectedIndex = 0
        End If
    End Sub
    Private Sub UpdateBinding()

        For Each ctrl As Control In Me.Controls
            ctrl.DataBindings.Clear()
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        PictureBox1.Image = Nothing

       
        Dim room As Integer = ComboRoom.SelectedItem
        sql = "SELECT *, DATEDIFF(YEAR, BirthDate, GETDATE()) AS Age " & _
              "FROM Roomer WHERE RoomNo = " & room

        command = New SqlCommand(sql, connection)
        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet()
        adapter.Fill(dataSt, "roomer")

        ListBox1.DataSource = dataSt.Tables("roomer")
        ListBox1.DisplayMember = "Name"

        adapter = New SqlDataAdapter(command)
        adapter.Fill(dataSt, "rent")
        bindingSrc.DataSource = dataSt.Tables("rent")

        TextID.DataBindings.Add("Text", bindingSrc, "ID")

        ComboTitle.DataBindings.Add("Text", bindingSrc, "Title")
        TextName.DataBindings.Add("Text", bindingSrc, "Name")
        TextIDCardNo.DataBindings.Add("Text", bindingSrc, "IDCardNo")
        DateTimeBirth.DataBindings.Add("Value", bindingSrc, "BirthDate")
        TextAge.DataBindings.Add("Text", bindingSrc, "Age")
        TextAddress.DataBindings.Add("Text", bindingSrc, "Address")
        TextPhone.DataBindings.Add("Text", bindingSrc, "Phone")
        PictureBox1.DataBindings.Add("Image", bindingSrc, "Picture", True)
    End Sub

    Private Sub ComboFloor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboFloor.SelectedIndexChanged
        Dim f As Integer = ComboFloor.SelectedItem
        Dim roomNo As String

        ComboRoom.Items.Clear()
        For r = 1 To RoomsPerFloor
            roomNo = f & r.ToString("0#")
            ComboRoom.Items.Add(roomNo)
        Next

        ComboRoom.SelectedIndex = 0
    End Sub

    Private Sub ComboRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboRoom.SelectedIndexChanged
        UpdateBinding()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.Filter = _
           "Image Files(*.jpg, *.png, *.gif, *.bmp)|*.jpg;*.png;*.gif;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If (Not IsDataCompete()) Or TextID.Text = "" Then
            Exit Sub
        End If

        If Not (PictureBox1.Image Is Nothing) Then
            sql = "UPDATE Roomer " & _
                   "SET RoomNo = @room, Title = @title, Name = @name, " & _
                   "IDCardNo = @idcard, BirthDate = @birth, " & _
                   "Address = @address, Phone = @phone, Picture = @pic "
        Else
            sql = "UPDATE Roomer " & _
                   "SET RoomNo = @room, Title = @title, Name = @name, " & _
                   "IDCardNo = @idcard, BirthDate = @birth, " & _
                   "Address = @address, Phone = @phone "
        End If
        sql &= "WHERE ID = @id"
        AddParameters(sql)
        command.Parameters.AddWithValue("id", TextID.Text)

        Dim r As Integer = command.ExecuteNonQuery()
        If r > 0 Then
            MessageBox.Show("บันทึกการเปลี่ยนแปลงแล้ว")
            UpdateBinding()
        Else
            MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไข")
        End If
    End Sub
    Private Sub AddParameters(ByVal sql As String)
        command.Parameters.Clear()
        command.CommandText = sql
        command.Parameters.AddWithValue("room", ComboRoom.SelectedItem)
        command.Parameters.AddWithValue("title", ComboTitle.Text)
        command.Parameters.AddWithValue("name", TextName.Text)
        command.Parameters.AddWithValue("idcard", TextIDCardNo.Text)

        Dim dateStr As String = DateTimeBirth.Value.Year
        dateStr &= "/" & DateTimeBirth.Value.Month
        dateStr &= "/" & DateTimeBirth.Value.Day

        command.Parameters.AddWithValue("birth", dateStr)
        command.Parameters.AddWithValue("address", TextAddress.Text)
        command.Parameters.AddWithValue("phone", TextPhone.Text)
        command.Parameters.AddWithValue("status", "ไม่ว่าง")
        If Not (PictureBox1.Image Is Nothing) Then
            Dim memStream As New IO.MemoryStream()
            PictureBox1.Image.Save(memStream, Drawing.Imaging.ImageFormat.Bmp)
            Dim pic() As Byte = memStream.ToArray()
            command.Parameters.AddWithValue("pic", pic)
        End If
    End Sub
    Private Function IsDataCompete() As Boolean
        TextName.Text.Trim()
        TextIDCardNo.Text.Trim()
        TextAddress.Text.Trim()
        TextPhone.Text.Trim()

        Dim errMsg As String = ""
        If ComboRoom.SelectedIndex = -1 Then
            errMsg = "ท่านยังไม่ได้เลือกห้อง"
        ElseIf ComboTitle.Text = "" Then
            errMsg = "กรุณาเลือกคำนำหน้าชื่อ"
        ElseIf TextName.Text = "" Then
            errMsg = "ยังไม่ได้กำหนดชื่อ"
        ElseIf TextIDCardNo.Text = "" OrElse _
            Not IsNumeric(TextIDCardNo.Text) OrElse _
            TextIDCardNo.Text.Length <> 13 Then

            errMsg = "กรุณากำหนดหมายเลขบัตรทั้ง 13 หลัก"
        ElseIf TextAddress.Text = "" Then
            errMsg = "ยังไม่ได้กำหนดที่อยู่"
        End If

        If errMsg <> "" Then
            MessageBox.Show(errMsg)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextID.Text = "" Then
            Exit Sub
        End If

        Dim msgResult As DialogResult
        msgResult = MessageBox.Show("ท่านต้องลบการข้อมูลของผู้เช่ารายนี้จริงหรือไม่", _
                                    "ยืนยันการลบ", MessageBoxButtons.OKCancel)

        If msgResult = DialogResult.Cancel Then
            Exit Sub
        End If

        sql = "DELETE FROM Roomer WHERE ID = " & TextID.Text
        command.Parameters.Clear()
        command.CommandText = sql
        Dim r As Integer = command.ExecuteNonQuery()
        If r > 0 Then
            MessageBox.Show("ลบข้อมูลแล้ว")
            UpdateBinding()
        Else
            MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล")
        End If
    End Sub
End Class