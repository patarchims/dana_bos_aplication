Public Class frmSplash
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        frmMenu.Show()
        Me.Close()
    End Sub
    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub
End Class