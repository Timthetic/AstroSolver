Public Class FrmDistanceModulus
    Private apparentMagnitude As Decimal = 1
    Private absoluteMagnitude As Decimal = 1
    Private distance As Decimal = 1
    Private solveFor As String = "D"

    'Units  (Note that magnitude does not have a unit)
    Private DMult As Double = 1

    Private Sub FrmDistanceModulus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combM.SelectedIndex = 0
        combBigM.SelectedIndex = 0
        combD.SelectedIndex = 0
    End Sub

    Private Sub Solve()
        lblError.Visible = False

        Try
            If (solveFor <> "M") Then
                Double.TryParse(txtM.Text, apparentMagnitude)
                ''No Magnitude Unit
            End If
            If (solveFor <> "BigM") Then
                Double.TryParse(txtBigM.Text, absoluteMagnitude)
                ''No Magnitude Unit
            End If
            If (solveFor <> "D") Then
                Double.TryParse(txtD.Text, distance)
                distance *= DMult
            End If

            lblmUnit.Text = "m Unit: " & combM.Text & " --> N.A." & apparentMagnitude
            lblBigMUnit.Text = "M Unit: " & combBigM.Text & " --> N.A." & absoluteMagnitude
            lblDistanceUnit.Text = "D Unit: " & combD.Text & " --> " & DMult

            If (solveFor = "M") Then
                apparentMagnitude = 5 * Math.Log10(distance / 10.0) + absoluteMagnitude
                txtM.Text = Format(apparentMagnitude, "0.000")
            End If
            If (solveFor = "BigM") Then
                absoluteMagnitude = -5 * Math.Log10(distance / 10.0) + apparentMagnitude
                txtBigM.Text = Format(absoluteMagnitude, "0.000")

            End If
            If (solveFor = "D") Then
                distance = (10 * Math.Pow(10, ((apparentMagnitude - absoluteMagnitude) / 5))) / DMult
                txtD.Text = Format(distance, "0.000E+0")
            End If




        Catch ex As Exception
            lblError.Visible = True
        End Try
    End Sub


    Private Sub combD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combD.SelectedIndexChanged
        Select (combD.Text)
            Case "m"
                DMult = (1 / 3.0857E+16)  'meters
            Case "km"
                DMult = (1000 / 3.0857E+16) 'kilometers
            Case "AU"
                DMult = (149600000000.0 / 3.0857E+16)  'AU
            Case "ly"
                DMult = (9.4607E+15 / 3.0857E+16)  'ly 
            Case "pc"
                DMult = 1 '(3.0857E+16 / 3.0857E+16) 'pc
        End Select
        Solve()
    End Sub

    Private Sub inputChanged(sender As Object, e As EventArgs) Handles txtM.TextChanged, txtBigM.TextChanged, txtD.TextChanged
        Solve()
    End Sub


    Private Sub lblM_Click(sender As Object, e As EventArgs) Handles lblM.Click
        lblM.ForeColor = Color.Green
        lblBigM.ForeColor = Color.Red
        lblD.ForeColor = Color.Red

        txtM.Text = ""

        txtM.ReadOnly = True
        txtBigM.ReadOnly = False
        txtD.ReadOnly = False

        solveFor = "M"
    End Sub

    Private Sub lblBigM_Click(sender As Object, e As EventArgs) Handles lblBigM.Click
        lblM.ForeColor = Color.Red
        lblBigM.ForeColor = Color.Green
        lblD.ForeColor = Color.Red

        txtBigM.Text = ""

        txtM.ReadOnly = False
        txtBigM.ReadOnly = True
        txtD.ReadOnly = False
        solveFor = "BigM"
    End Sub

    Private Sub lblD_Click(sender As Object, e As EventArgs) Handles lblD.Click
        lblM.ForeColor = Color.Red
        lblBigM.ForeColor = Color.Red
        lblD.ForeColor = Color.Green

        txtD.Text = ""

        txtM.ReadOnly = False
        txtBigM.ReadOnly = False
        txtD.ReadOnly = True
        solveFor = "D"
    End Sub

    Private Sub txtM_Click(sender As Object, e As EventArgs) Handles txtM.Click, txtD.Click, txtBigM.Click
        Dim txtSelected As TextBox = CType(sender, TextBox)
        txtSelected.SelectAll()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class