Imports System.Data
Imports System.Data.SqlClient


Public Class Setting

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




    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dormitoryset.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Roomset.Show()
    End Sub

    
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class