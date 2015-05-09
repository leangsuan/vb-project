Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Public pUser_id As String = ""
    Public pPassword As String = ""


    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Dim queryString As String = "SELECT * FROM login WHERE id = '" & Textuser.Text & "'"
        Using connection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\vb\project\project\Dormitory.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

            Dim command As New SqlCommand(queryString, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows = 0 Then
                MessageBox.Show("Invalid User", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Textuser.Focus()

            Else

                reader.Read()
                pUser_id = reader("id")
                pPassword = reader("password")
                If Textpass.Text.Trim = pPassword.Trim Then
                    Me.Hide()
                    ' Complete
                    Main.Show()
                    Main.ToolStrip1.Enabled = True
                    Main.ToolStripLogin.Enabled = False
                Else

                    MessageBox.Show("Password not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Textpass.Focus()
                    Main.ToolStrip1.Enabled = False
                End If
            End If
            reader.Close()
        End Using

    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
        Main.ToolStrip1.Enabled = False
        Main.ToolStripLogin.Enabled = True
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Textuser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Textuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Textuser.Text = "" Then
                Textuser.Focus()
            Else
                Textpass.Focus()
            End If
        End If
    End Sub

    Private Sub Textpass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Textpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Textpass.Text = "" Then
                Textpass.Focus()
            Else
                ButtonLogin_Click(sender, e)

            End If
        End If
    End Sub
End Class
