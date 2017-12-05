Public Class frmMain

    Private Sub btnNewtonSynth_Click(sender As Object, e As EventArgs) Handles btnNewtonSynth.Click
        frmNewtonSynthesis.Show()
        Me.Close()
    End Sub

    Private Sub btnStefanBoltzmann_Click(sender As Object, e As EventArgs) Handles btnStefanBoltzmann.Click
        frmStefanBoltzmann.Show()
        Me.Close()
    End Sub

    Private Sub btnDopShift_Click(sender As Object, e As EventArgs) Handles btnDopShift.Click
        frmHubblesLaw.Show()
        Me.Close()
    End Sub

    Private Sub btnDistMod_Click(sender As Object, e As EventArgs) Handles btnDistMod.Click
        FrmDistanceModulus.Show()
        Me.Close()
    End Sub
End Class
