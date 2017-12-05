Public Class frmHubblesLaw

    Private newWaveLength As Decimal = 1
    Private oldWaveLength As Decimal = 1
    Private velocity As Decimal = 1
    Private solveFor As String = "N"
    Private Const SPEEDOFLIGHT = 299792458

    'Units
    Private nwlMult As Double = 1
    Private wlMult As Double = 1
    Private vMult As Double = 1

    Private Sub HubblesLaw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combNWL.SelectedIndex = 4
        combWL.SelectedIndex = 4
        combV.SelectedIndex = 0
    End Sub

    Private Sub Solve()
        lblError.Visible = False

        Try
            If (solveFor <> "N") Then
                Double.TryParse(txtNWL.Text, newWaveLength)
                newWaveLength *= nwlMult
            End If

            If (solveFor <> "O") Then
                Double.TryParse(txtOWL.Text, oldWaveLength)
                oldWaveLength *= wlMult
            End If

            If (solveFor <> "V") Then
                Double.TryParse(txtV.Text, velocity)
                velocity *= vMult
            End If

            lblNWLUnit.Text = "New Lambda Unit: " & combNWL.Text & " --> " & nwlMult
            lblWLUnit.Text = "Lambda Unit: " & combWL.Text & " --> " & wlMult
            lblVelocityUnit.Text = "Velocity Unit: " & combV.Text & " --> " & vMult

            If (True) Then
                If (solveFor = "N") Then
                    newWaveLength = (((velocity / SPEEDOFLIGHT) * (oldWaveLength)) + oldWaveLength) / nwlMult
                    txtNWL.Text = Format(newWaveLength, "0.000E+0")
                End If
                If (solveFor = "O") Then
                    oldWaveLength = ((newWaveLength * SPEEDOFLIGHT) / (SPEEDOFLIGHT + velocity)) / wlMult
                    txtOWL.Text = Format(oldWaveLength, "0.000E+0")
                End If
                If (solveFor = "V") Then
                    velocity = (((newWaveLength - oldWaveLength) * SPEEDOFLIGHT) / oldWaveLength) / vMult
                    txtV.Text = Format(velocity, "0.000E+0")
                End If
            End If

            If (velocity < 0) Then
                lblDirection.Text = "Towards"
            ElseIf (velocity > 0) Then
                lblDirection.Text = "Away"
            End If

        Catch
            lblError.Visible = True
        End Try
    End Sub

    Private Sub combNWL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combNWL.SelectedIndexChanged
        Select Case (combNWL.Text)
            Case ("picometers")
                nwlMult = 0.000000000001

            Case ("nanometers")
                nwlMult = 0.000000001

            Case ("micrometers")
                nwlMult = 0.000001

            Case ("millimeters")
                nwlMult = 0.001
            Case ("meters")
                nwlMult = 1
            Case ("kilometers")
                nwlMult = 1000

        End Select
        Solve()
    End Sub

    Private Sub combWL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combWL.SelectedIndexChanged
        Select Case (combWL.Text)
            Case ("picometers")
                wlMult = 0.000000000001

            Case ("nanometers")
                wlMult = 0.000000001

            Case ("micrometers")
                wlMult = 0.000001

            Case ("millimeters")
                wlMult = 0.001
            Case ("meters")
                wlMult = 1
            Case ("kilometers")
                wlMult = 1000

        End Select
        Solve()
    End Sub

    Private Sub combV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combV.SelectedIndexChanged
        Select Case (combV.Text)
            Case ("m/s")
                vMult = 1
            Case ("km/s")
                vMult = 1000
            Case ("mph")
                vMult = 0.44704
        End Select
        Solve()
    End Sub

    Private Sub inputChanged(sender As Object, e As EventArgs) Handles txtV.TextChanged, txtOWL.TextChanged, txtNWL.TextChanged
        Solve()
    End Sub

    Private Sub lblLambdaBOTH_Click(sender As Object, e As EventArgs) Handles lblLambdaTop.Click, lblLambdaBot.Click
        lblLambdaBot.ForeColor = Color.Green
        lblLambdaTop.ForeColor = Color.Green
        lblV.ForeColor = Color.Red
        lblLambdaPrime.ForeColor = Color.Red

        txtOWL.Text = ""

        txtOWL.ReadOnly = True
        txtNWL.ReadOnly = False
        txtV.ReadOnly = False

        solveFor = "O"
    End Sub

    Private Sub lblLambdaPrime_Click(sender As Object, e As EventArgs) Handles lblLambdaPrime.Click
        lblLambdaBot.ForeColor = Color.Red
        lblLambdaTop.ForeColor = Color.Red
        lblV.ForeColor = Color.Red
        lblLambdaPrime.ForeColor = Color.Green

        txtNWL.Text = ""

        txtOWL.ReadOnly = False
        txtNWL.ReadOnly = True
        txtV.ReadOnly = False

        solveFor = "N"
    End Sub

    Private Sub lblV_Click(sender As Object, e As EventArgs) Handles lblV.Click
        lblLambdaBot.ForeColor = Color.Red
        lblLambdaTop.ForeColor = Color.Red
        lblV.ForeColor = Color.Green
        lblLambdaPrime.ForeColor = Color.Red

        txtV.Text = ""

        txtOWL.ReadOnly = False
        txtNWL.ReadOnly = False
        txtV.ReadOnly = True

        solveFor = "V"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class