
Public Class frmNewtonSynthesis
    Private mass = 1
    Private period = 1
    Private radius = 1
    Private solveFor = "T"
    Private Const PI = 3.1415926535897931
    Private Const GravConst = 0.0000000000667

    'Units
    Private rMult As Double = 1
    Private tMult As Double = 1
    Private mMult As Double = 1

    Private Sub Solve()
        lblError.Visible = False

        Try
            If (solveFor <> "M") Then
                Double.TryParse(txtM.Text, mass)
                mass *= mMult
            End If

            If (solveFor <> "T") Then
                Double.TryParse(txtT.Text, period)
                period *= tMult
            End If

            If (solveFor <> "R") Then
                Double.TryParse(txtR.Text, radius)
                radius *= rMult
            End If

            lblMassUnit.Text = "M Unit: " & combM.Text & " --> " & mMult
            lblPeriodUnit.Text = "T Unit: " & combT.Text & " --> " & tMult
            lblRadiusUnit.Text = "R Unit: " & combR.Text & " --> " & rMult

            If (True) Then
                If (solveFor = "M") Then
                    mass = (((4 * PI ^ 2 * radius ^ 3) / (GravConst * period ^ 2))) / mMult
                    txtM.Text = Format(mass, "0.000E+0")
                End If
                If (solveFor = "T") Then
                    period = (Math.Sqrt(((4 * PI ^ 2 * radius ^ 3) / (GravConst * mass)))) / tMult
                    txtT.Text = Format(period, "0.000E+0")
                End If
                If (solveFor = "R") Then
                    radius = (((mass * GravConst * period ^ 2) / (4 * PI ^ 2)) ^ (1 / 3)) / rMult
                    txtR.Text = Format(radius, "0.000E+0")
                End If
            End If


        Catch
            lblError.Visible = True
        End Try
    End Sub

    Private Sub textBoxChanged(sender As Object, e As System.EventArgs) Handles txtT.TextChanged, txtR.TextChanged, txtM.TextChanged
        Solve()
    End Sub



    Private Sub lblT_Click(sender As Object, e As EventArgs) Handles lblT.Click
        lblT.ForeColor = Color.Green
        lblM.ForeColor = Color.Red
        lblR.ForeColor = Color.Red

        txtT.Text = ""

        txtT.ReadOnly = True
        txtM.ReadOnly = False
        txtR.ReadOnly = False

        solveFor = "T"
    End Sub

    Private Sub lblR_Click(sender As Object, e As EventArgs) Handles lblR.Click
        lblT.ForeColor = Color.Red
        lblM.ForeColor = Color.Red
        lblR.ForeColor = Color.Green

        txtR.Text = ""

        txtT.ReadOnly = False
        txtM.ReadOnly = False
        txtR.ReadOnly = True

        solveFor = "R"
    End Sub

    Private Sub lblM_Click(sender As Object, e As EventArgs) Handles lblM.Click
        lblT.ForeColor = Color.Red
        lblM.ForeColor = Color.Green
        lblR.ForeColor = Color.Red

        txtM.Text = ""

        txtT.ReadOnly = False
        txtM.ReadOnly = True
        txtR.ReadOnly = False

        solveFor = "M"
    End Sub


    Private Sub combT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combT.SelectedIndexChanged
        Select Case combT.Text
            Case "sec"
                tMult = 1  'seconds
            Case "hr"
                tMult = 3600  'hours
            Case "day"
                tMult = 86400  'days
            Case "yr"
                tMult = 31557600  'years
        End Select
        Solve()
    End Sub

    Private Sub combR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combR.SelectedIndexChanged
        Select Case combR.Text
            Case "m"
                rMult = 1  'meters
            Case "km"
                rMult = 1000 'kilometers
            Case "AU"
                rMult = 149600000000.0  'AU
            Case "ly"
                rMult = 9.4607E+15  'ly 
            Case "pc"
                rMult = 3.0857E+16  'pc
        End Select
        Solve()
    End Sub

    Private Sub combM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combM.SelectedIndexChanged
        Select Case combM.Text
            Case "kg"
                mMult = 1  'kg
            Case "Me"
                mMult = 5.9722E+24  'Earth Mass
            Case "Mj"
                mMult = 1.898E+27  'Jupiter Mass 
            Case "Ms"
                mMult = 1.989E+30  'Solar Mass
        End Select
        Solve()
    End Sub

    Private Sub frmNewtonSynthesis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combM.SelectedIndex = 0
        combT.SelectedIndex = 0
        combR.SelectedIndex = 0
    End Sub

    Private Sub txtM_Click(sender As Object, e As EventArgs) Handles txtT.Click, txtR.Click, txtM.Click
        Dim selected As TextBox = CType(sender, TextBox)

        selected.SelectAll()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class
