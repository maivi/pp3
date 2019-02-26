Public Class frmPresentacion
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        frmLogin.Show()
        Timer1.Enabled = False
    End Sub
End Class