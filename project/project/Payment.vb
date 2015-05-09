Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Payment
    Private numFloors, numRooms As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Main.ToolStripCheckin.Enabled = True
        Main.ToolStripRoom.Enabled = True
        Main.ToolStripCheckout.Enabled = True
        Main.ToolStripGuest.Enabled = True
        Main.ToolStripHistory.Enabled = True
        Main.ToolStripSetting.Enabled = True
        Main.ToolStripExit.Enabled = True
    End Sub

    Private Sub Checkout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New SqlConnection(constr)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        sql = "SELECT * FROM Roomset"

        command = New SqlCommand(sql, connection)
        reader = command.ExecuteReader()


       

        While reader.Read()
            numFloors = reader("NumFloors")
            numRooms = reader("RoomsPerFloor")
           
        End While

        If reader.HasRows Then
            For f = 1 To numFloors
                ComboFloor.Items.Add(f)
            Next
            reader.Close()
            ComboFloor.SelectedIndex = 0
        End If

        For i = 1 To 12
            ComboMonth.Items.Add(MonthName(i))
        Next

        ComboMonth.SelectedIndex = _
            ComboMonth.FindStringExact(MonthName(DateTime.Now.Month))


        Dim y As Integer = DateTime.Now.Year
        ComboYear.Items.Add(y + 543)
        ComboYear.Items.Add((y - 1) + 543)
        ComboYear.SelectedIndex = 0
    End Sub
    Private Sub TextChange(ByVal sender As Object, ByVal e As EventArgs) _
    Handles TextRental.TextChanged, TextWater.TextChanged, TextElectric.TextChanged


        Dim tbx As TextBox = CType(sender, TextBox)
        If Not IsNumeric(tbx.Text) Then
            tbx.Text = ""
        End If
        CalTotal()
    End Sub
    Private Sub CalTotal()
        Dim t As Double = 0
        t += CheckNumber(TextRental.Text)
        t += CheckNumber(TextWater.Text)
        t += CheckNumber(TextElectric.Text)
     

        TextTotal.Text = t
    End Sub
    Private Function CheckNumber(ByVal strNum As String) As Double
        If IsNumeric(strNum) Then
            Return strNum
        Else
            Return 0
        End If
    End Function
    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click
        connection = New SqlConnection(constr)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        sql = "SELECT * FROM Dormitoryset"
        command = New SqlCommand(sql, connection)
        reader = command.ExecuteReader()

        While reader.Read()
            Dormitoryname.Text = reader("Dormitoryname")
            Address.Text = reader("Address")

        End While
        reader.Close()

        PrintDocument1.Print()
    End Sub

    Private Sub ButtonPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPreview.Click
        connection = New SqlConnection(constr)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        sql = "SELECT * FROM Dormitoryset"
        command = New SqlCommand(sql, connection)
        reader = command.ExecuteReader()

        While reader.Read()
            Dormitoryname.Text = reader("Dormitoryname")
            Address.Text = reader("Address")

        End While
        reader.Close()

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Width = 850
        PrintPreviewDialog1.Height = 600

        PrintPreviewDialog1.ShowDialog()
    End Sub



    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fnt As Font
        Dim txt As String
        Dim black As New SolidBrush(Color.Black)
        Dim blue As New SolidBrush(Color.Blue)

        fnt = New Font("CordiaUPC", 20, FontStyle.Bold)
        txt = Dormitoryname.Text
        e.Graphics.DrawString(txt, fnt, black, 350, 50)

        fnt = New Font("CordiaUPC", 14, FontStyle.Regular)
        txt = Address.Text
        e.Graphics.DrawString(txt, fnt, black, 170, 80)

        txt = "วันที่"
        e.Graphics.DrawString(txt, fnt, black, 500, 120)
        txt = DateTime.Now.ToShortDateString()
        e.Graphics.DrawString(txt, fnt, blue, 540, 120)

        txt = "ห้อง"
        e.Graphics.DrawString(txt, fnt, black, 500, 140)
        txt = ComboRoom.SelectedItem
        e.Graphics.DrawString(txt, fnt, blue, 540, 140)

        txt = "รายการค่าเช่าห้องพักและสาธารณูปโภคประจำเดือน"
        e.Graphics.DrawString(txt, fnt, black, 200, 170)
        txt = ComboMonth.SelectedItem & "  " & ComboYear.SelectedItem
        e.Graphics.DrawString(txt, fnt, blue, 500, 170)

        txt = "1. ค่าเช่าห้อง"
        e.Graphics.DrawString(txt, fnt, black, 250, 200)
        txt = TextRental.Text
        e.Graphics.DrawString(txt, fnt, blue, 400, 200)

        txt = "2. ค่าน้ำ"
        e.Graphics.DrawString(txt, fnt, black, 250, 220)
        txt = TextWater.Text
        e.Graphics.DrawString(txt, fnt, blue, 400, 220)

        txt = "3. ค่าไฟ"
        e.Graphics.DrawString(txt, fnt, black, 250, 240)
        txt = TextElectric.Text
        e.Graphics.DrawString(txt, fnt, blue, 400, 240)


        fnt = New Font("CordiaUPC", 14, FontStyle.Underline)
        txt = "รวมทั้งสิ้น"
        e.Graphics.DrawString(txt, fnt, black, 250, 310)
        txt = TextTotal.Text
        e.Graphics.DrawString(txt, fnt, blue, 400, 310)

        fnt = New Font("CordiaUPC", 14, FontStyle.Regular)

        txt = "ลงชื่อ......................................" & _
              "...................................(ผู้รับเงิน)"
        e.Graphics.DrawString(txt, fnt, black, 400, 360)
        txt = "(........................................" & _
              "...............................)"
        e.Graphics.DrawString(txt, fnt, black, 430, 390)
    End Sub

  

    Private Sub ComboFloor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboFloor.SelectedIndexChanged
        Dim f As Integer = ComboFloor.SelectedItem
        Dim roomNo As String
        ComboRoom.Items.Clear()
        For r = 1 To numRooms
            roomNo = f & r.ToString("0#")
            ComboRoom.Items.Add(roomNo)
        Next
        ComboRoom.SelectedIndex = 0
    End Sub
    Private Sub Combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ComboRoom.SelectedIndexChanged, ComboMonth.SelectedIndexChanged, ComboYear.SelectedIndexChanged

        If ComboRoom.SelectedIndex <> -1 And ComboMonth.SelectedIndex <> -1 And ComboYear.SelectedIndex <> -1 Then
            ReadData()
        End If

    End Sub
    Private Sub ReadData()
        For Each ctrl As Control In Me.Controls
            ctrl.DataBindings.Clear()
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        CheckPaid.Checked = False

        sql = "SELECT * FROM Payment WHERE " & _
              "(RoomNo = @r) AND (Month = @m) AND (Year = @y)"

        AddParameters(sql)

        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet()
        adapter.Fill(dataSt, "pay")

        bindingSrc = New BindingSource()
        bindingSrc.DataSource = dataSt.Tables("pay")
        TextRental.DataBindings.Add("Text", bindingSrc, "Rental")
        TextWater.DataBindings.Add("Text", bindingSrc, "WaterSupply")
        TextElectric.DataBindings.Add("Text", bindingSrc, "Electricity")
       
        CheckPaid.DataBindings.Add("Checked", bindingSrc, "Paid")

        CalTotal()

        If TextRental.Text = "" Then
            sql = "SELECT Rental FROM Roomset"
            command.Parameters.Clear()
            command.CommandText = sql
            TextRental.Text = command.ExecuteScalar()
        End If
    End Sub
    Private Sub AddParameters(ByVal sql As String)
        command.Parameters.Clear()
        command.CommandText = sql
        command.Parameters.AddWithValue("r", ComboRoom.SelectedItem)
        command.Parameters.AddWithValue("m", ComboMonth.SelectedItem)
        command.Parameters.AddWithValue("y", ComboYear.SelectedItem)
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click

        sql = "SELECT COUNT(*) FROM Payment WHERE " & _
               "(RoomNo = @r) AND (Month = @m) AND (Year = @y)"
        AddParameters(sql)
        Dim count As Integer = command.ExecuteScalar()
        If count = 0 Then
            sql = "INSERT INTO Payment(" & _
                  "RoomNo, Month, Year, Rental, WaterSupply, Electricity, Paid) " & _
                  "VALUES(@room, @month, @year, @rent, @water, @electric,  @paid)"
        Else
            sql = "UPDATE Payment SET " & _
                  "RoomNo = @room, Month = @month, Year = @year, Rental = @rent, " & _
                  "WaterSupply = @water, Electricity = @electric,  Paid = @paid " & _
                  "WHERE (RoomNo = @r) AND (Month = @m) AND (Year = @y)"
        End If

        command.Parameters.Clear()
        command.CommandText = sql
        command.Parameters.AddWithValue("room", ComboRoom.SelectedItem)
        command.Parameters.AddWithValue("month", ComboMonth.SelectedItem)
        command.Parameters.AddWithValue("year", ComboYear.SelectedItem)
        command.Parameters.AddWithValue("rent", TextRental.Text)
        command.Parameters.AddWithValue("water", TextWater.Text)
        command.Parameters.AddWithValue("electric", TextElectric.Text)
   
        Dim chk As Byte = CheckPaid.Checked.GetHashCode()
        command.Parameters.AddWithValue("paid", chk)

        If count > 0 Then
            command.Parameters.AddWithValue("r", ComboRoom.SelectedItem)
            command.Parameters.AddWithValue("m", ComboMonth.SelectedItem)
            command.Parameters.AddWithValue("y", ComboYear.SelectedItem)
        End If

        Dim r As Integer = command.ExecuteNonQuery()
        If r > 0 Then
            MessageBox.Show("บันทึกข้อมูลแล้ว")
        Else
            MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล")
        End If
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim msgResult As DialogResult
        msgResult = MessageBox.Show("ท่านต้องการข้อมูลของผู้เช่ารายนี้จริงหรือไม่", _
                                    "ยืนยันการลบ", MessageBoxButtons.OKCancel)

        If msgResult = DialogResult.Cancel Then
            Exit Sub
        End If

        sql = "DELETE FROM Payment WHERE " & _
              "(RoomNo = @r) AND (Month = @m) AND (Year = @y)"
        AddParameters(sql)
        Dim r As Integer = command.ExecuteNonQuery()
        If r > 0 Then
            MessageBox.Show("ลบข้อมูลแล้ว")
            ReadData()
        Else
            MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล")
        End If
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class