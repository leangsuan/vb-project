Imports System.Data
Imports System.Data.SqlClient

Public Class Main

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "วันที่ " + Today
        ToolStripStatusLabel2.Text = "เวลา " + TimeOfDay


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = "เวลา " + TimeOfDay
    End Sub

    Private Sub ShowChildForm(ByVal f As Form)
        If f.Visible = True Then
            f.BringToFront()
        Else

            f.Show()
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Dim txt As String = e.ClickedItem.Text
        Select Case txt
            Case "Check in"
                Checkin.MdiParent = Me
                ShowChildForm(Checkin)
            Case "ชำระเงิน"
                Payment.MdiParent = Me
                ShowChildForm(Payment)
            Case "รายละเอียดห้องพัก"
                Room.MdiParent = Me
                ShowChildForm(Room)
            Case "แก้ไขข้อมูลผู้เข้าพัก"
                Checkin.MdiParent = Me
                ShowChildForm(Edit)
            Case "ผู้ค้างชำระ"
                Pending.MdiParent = Me
                ShowChildForm(Pending)
            Case "ตั้งค่าระบบ"
                Setting.MdiParent = Me
                ShowChildForm(Setting)
            Case "Exit"
                Application.Exit()
        End Select

        
    End Sub
    

    Private Sub ToolStripLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLogin.Click
        Login.Show()
        ToolStripLogin.Enabled = False
    End Sub


    Private Sub ToolStripCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCheckout.Click
        ToolStripCheckout.Enabled = False
        ToolStripRoom.Enabled = False
        ToolStripGuest.Enabled = False
        ToolStripHistory.Enabled = False
        ToolStripSetting.Enabled = False
        ToolStripCheckin.Enabled = False
        ToolStripExit.Enabled = False
    End Sub

    Private Sub ToolStripRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripRoom.Click
        ToolStripRoom.Enabled = False
        ToolStripCheckout.Enabled = False
        ToolStripGuest.Enabled = False
        ToolStripHistory.Enabled = False
        ToolStripSetting.Enabled = False
        ToolStripCheckin.Enabled = False
        ToolStripExit.Enabled = False
    End Sub

    Private Sub ToolStripGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripGuest.Click
        ToolStripGuest.Enabled = False
        ToolStripRoom.Enabled = False
        ToolStripCheckout.Enabled = False
        ToolStripHistory.Enabled = False
        ToolStripSetting.Enabled = False
        ToolStripCheckin.Enabled = False
        ToolStripExit.Enabled = False
    End Sub

    
    Private Sub ToolStripHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripHistory.Click
        ToolStripHistory.Enabled = False
        ToolStripRoom.Enabled = False
        ToolStripCheckout.Enabled = False
        ToolStripGuest.Enabled = False
        ToolStripSetting.Enabled = False
        ToolStripCheckin.Enabled = False
        ToolStripExit.Enabled = False
    End Sub

    Private Sub ToolStripService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToolStripRoom.Enabled = False
        ToolStripCheckout.Enabled = False
        ToolStripGuest.Enabled = False
        ToolStripHistory.Enabled = False
        ToolStripSetting.Enabled = False
        ToolStripCheckin.Enabled = False
        ToolStripExit.Enabled = False
    End Sub

    Private Sub ToolStripSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSetting.Click
        ToolStripSetting.Enabled = False
        ToolStripRoom.Enabled = False
        ToolStripCheckout.Enabled = False
        ToolStripGuest.Enabled = False
        ToolStripHistory.Enabled = False
        ToolStripCheckin.Enabled = False
        ToolStripExit.Enabled = False
    End Sub

    Private Sub ToolStripCheckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCheckin.Click
        ToolStripCheckin.Enabled = False
        ToolStripRoom.Enabled = False
        ToolStripCheckout.Enabled = False
        ToolStripGuest.Enabled = False
        ToolStripHistory.Enabled = False
        ToolStripSetting.Enabled = False
        ToolStripExit.Enabled = False
    End Sub

    Private Sub ToolStripExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripExit.Click

    End Sub
End Class
