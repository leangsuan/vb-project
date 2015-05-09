Imports System.Data
Imports System.Data.SqlClient
Public Class Dormitoryset
    Private hasRows As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    
    Private Function IsDataComplete()
        TextBox1.Text.Trim()
        TextBox2.Text.Trim()
        TextBox3.Text.Trim()
        

        Dim errMsg As String = ""
        If TextBox1.Text = "" Then
            errMsg = "กรุณากำหนดชื่อกิจการ / หอพัก"
        ElseIf TextBox2.Text = "" Then
            errMsg = "กรุณากำหนดที่อยู่"
        ElseIf TextBox3.Text = "" Then
            errMsg = "กรุณากำหนดหมายเลขโทรศัพท์"
        
        End If

        If errMsg <> "" Then
            MessageBox.Show(errMsg)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        If IsDataComplete() = False Then
            Exit Sub
        End If

        If hasRows Then
            sql = "UPDATE Dormitoryset SET " & _
                  "Dormitoryname = @name, " & _
                  "Address = @address, " & _
                  "Phone = @phone"
        Else
            sql = "INSERT INTO Dormitoryset(Dormitoryname, Address, Phone) " & _
                  "VALUES(@name, @address, @phone)"
        End If

        command = New SqlCommand(sql, connection)
        command.Parameters.Clear()
        command.Parameters.AddWithValue("name", TextBox1.Text)
        command.Parameters.AddWithValue("address", TextBox2.Text)
        command.Parameters.AddWithValue("phone", TextBox3.Text)

        Dim r As Integer = command.ExecuteNonQuery()
        If r = 1 Then
            MessageBox.Show("ปรับปรุงข้อมูลแล้ว")
            connection.Close()
            Dormitoryset_Load(sender, e)
        Else
            MessageBox.Show("เกิดข้อผิดพลาด")
        End If

    End Sub

    

   
    Private Sub Dormitoryset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New SqlConnection(constr)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        sql = "SELECT * FROM Dormitoryset"
        command = New SqlCommand(sql, connection)
        reader = command.ExecuteReader()



        hasRows = reader.HasRows

        While reader.Read()
            TextBox1.Text = reader("Dormitoryname")
            TextBox2.Text = reader("Address")
            TextBox3.Text = reader("Phone")
        End While
        reader.Close()
    End Sub
End Class