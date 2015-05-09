Public NotInheritable Class SplashScreen1

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SendMessage(ProgressBar1.Handle, 1040, 2, 0)
        ProgressBar1.Increment(10)


        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Main.Show()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub SplashScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    
End Class
