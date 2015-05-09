Imports System.Data
Imports System.Data.SqlClient
Public Class Room


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

    Private Sub Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New SqlConnection(constr)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        sql = "SELECT RoomNo,Status FROM Roomer"
        command = New SqlCommand(sql, connection)
        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet()
        adapter.Fill(dataSt, "status")

        DataGridView1.DisplayedRowCount(True)
        DataGridView1.DataSource = dataSt.Tables("status")

        DataGridView1.Columns(0).HeaderText = "ห้อง"
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).HeaderText = "สถานะ"
        DataGridView1.Columns(1).Width = 150
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class