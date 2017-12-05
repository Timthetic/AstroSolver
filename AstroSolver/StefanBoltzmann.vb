Public Class frmStefanBoltzmann

    Public luminocity As Double = 1
    Public radius As Double = 1
    Public temperature As Double = 1
    Private solveFor = "L"
    Private Const PI = 3.1415926535897931
    Private Const SBConst = 0.0000000567

    'Units
    Private lMult As Double = 1
    Private rMult As Double = 1
    Private tMult As Double = 1

    Private Sub Solve()
        lblError.Visible = False

        Try
            If (solveFor <> "L") Then
                Double.TryParse(txtL.Text, luminocity)
                luminocity *= lMult
            End If

            If (solveFor <> "R") Then
                Double.TryParse(txtR.Text, radius)
                radius *= rMult
            End If

            If (solveFor <> "T") Then
                Double.TryParse(txtT.Text, temperature)
                'temperature *= tMult      SEE SUB
                temperature = toKelvin(temperature, combT.Text)
            End If


            lblLuminocityUnit.Text = "L Unit: " & combL.Text & " --> " & lMult
            lblRadiusUnit.Text = "R Unit: " & combR.Text & " --> " & rMult
            lblTemperatureUnit.Text = "T Unit: " & combT.Text & " --> X"

            If (True) Then
                If (solveFor = "L") Then
                    luminocity = (4 * PI * radius ^ 2 * SBConst * temperature ^ 4) / lMult
                    txtL.Text = Format(luminocity, "0.000E+0")
                End If
                If (solveFor = "R") Then
                    radius = (Math.Sqrt(luminocity / (4 * PI * SBConst * temperature ^ 4))) / rMult
                    txtR.Text = Format(radius, "0.000E+0")
                End If
                If (solveFor = "T") Then
                    temperature = fromKelvin(((luminocity / (4 * PI * radius ^ 2 * SBConst)) ^ (1 / 4)), combT.Text)
                    txtT.Text = Format(temperature, "0.000E+0")
                End If
            End If


        Catch
            lblError.Visible = True
        End Try

    End Sub


    Private Sub textBoxChanged(sender As Object, e As System.EventArgs) Handles txtL.TextChanged, txtR.TextChanged, txtT.TextChanged
        Solve()
    End Sub


    Private Sub lblL_Click(sender As Object, e As EventArgs) Handles lblL.Click
        lblL.ForeColor = Color.Green
        lblR.ForeColor = Color.Red
        lblT.ForeColor = Color.Red

        txtL.Text = ""

        txtL.ReadOnly = True
        txtR.ReadOnly = False
        txtT.ReadOnly = False

        solveFor = "L"
    End Sub

    Private Sub lblR_Click(sender As Object, e As EventArgs) Handles lblR.Click
        lblL.ForeColor = Color.Red
        lblR.ForeColor = Color.Green
        lblT.ForeColor = Color.Red

        txtR.Text = ""

        txtL.ReadOnly = False
        txtR.ReadOnly = True
        txtT.ReadOnly = False

        solveFor = "R"
    End Sub

    Private Sub lblT_Click(sender As Object, e As EventArgs) Handles lblT.Click
        lblL.ForeColor = Color.Red
        lblR.ForeColor = Color.Red
        lblT.ForeColor = Color.Green

        txtT.Text = ""

        txtL.ReadOnly = False
        txtR.ReadOnly = False
        txtT.ReadOnly = True

        solveFor = "T"
    End Sub

    Private Sub combL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combL.SelectedIndexChanged
        Select Case combL.Text.ToLower()
            Case "watt"
                lMult = 1  'watts
            Case "ls"
                lMult = 3.828E+26  'Solar Luminocity
        End Select
        Solve()
    End Sub

    Private Sub combR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combR.SelectedIndexChanged
        Select Case combR.Text
            Case "meter"
                rMult = 1  'meters
            Case "kilometer"
                rMult = 1000 'kilometers
            Case "feet"
                rMult = 0.3048  'feet
            Case "mile"
                rMult = 1609.344  'miles 
            Case "solar radius"
                rMult = 695842000  'solar radius
        End Select
        Solve()
    End Sub

    Private Sub combT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combT.SelectedIndexChanged
        Solve()
    End Sub

    Function fromKelvin(kelvinTemp As Double, newUnit As String) As Double
        Select Case newUnit.ToLower()
            Case "celsius"
                Return kelvinTemp + 273
            Case "fahrenheit"
                Return (1.8 * (kelvinTemp - 273) + 32)
            Case "t of sun"
                Return kelvinTemp / 5778
            Case Else
                lblError.Visible = True
                Return kelvinTemp
        End Select
    End Function

    Function toKelvin(temp As Double, oldUnit As String) As Double
        Select Case oldUnit.ToLower
            Case "celsius"
                Return temp - 273
            Case "fahrenheit"
                Return ((temp - 32) / 1.8 + 273)
            Case "t of sun"
                Return temp * 5778
            Case Else
                lblError.Visible = True
                Return temp
        End Select


    End Function

    Private Sub frmStefanBoltzmann_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combL.SelectedIndex = 0
        combR.SelectedIndex = 0
        combT.SelectedIndex = 0
    End Sub

    Private Sub txtM_Click(sender As Object, e As EventArgs) Handles txtT.Click, txtR.Click, txtL.Click
        Dim selected As TextBox = CType(sender, TextBox)

        selected.SelectAll()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class