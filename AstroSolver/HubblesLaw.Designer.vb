<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHubblesLaw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNWLUnit = New System.Windows.Forms.Label()
        Me.lblWLUnit = New System.Windows.Forms.Label()
        Me.combV = New System.Windows.Forms.ComboBox()
        Me.combNWL = New System.Windows.Forms.ComboBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.txtNWL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblLambdaPrime = New System.Windows.Forms.Label()
        Me.lblLambdaTop = New System.Windows.Forms.Label()
        Me.lblLambdaBot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combWL = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOWL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblVelocityUnit = New System.Windows.Forms.Label()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNWLUnit
        '
        Me.lblNWLUnit.AutoSize = True
        Me.lblNWLUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNWLUnit.Location = New System.Drawing.Point(67, 336)
        Me.lblNWLUnit.Name = "lblNWLUnit"
        Me.lblNWLUnit.Size = New System.Drawing.Size(73, 20)
        Me.lblNWLUnit.TabIndex = 64
        Me.lblNWLUnit.Text = "NO UNIT"
        '
        'lblWLUnit
        '
        Me.lblWLUnit.AutoSize = True
        Me.lblWLUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWLUnit.Location = New System.Drawing.Point(67, 385)
        Me.lblWLUnit.Name = "lblWLUnit"
        Me.lblWLUnit.Size = New System.Drawing.Size(73, 20)
        Me.lblWLUnit.TabIndex = 63
        Me.lblWLUnit.Text = "NO UNIT"
        '
        'combV
        '
        Me.combV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combV.FormattingEnabled = True
        Me.combV.Items.AddRange(New Object() {"m/s", "km/s", "mph"})
        Me.combV.Location = New System.Drawing.Point(729, 191)
        Me.combV.Name = "combV"
        Me.combV.Size = New System.Drawing.Size(70, 21)
        Me.combV.TabIndex = 60
        '
        'combNWL
        '
        Me.combNWL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combNWL.FormattingEnabled = True
        Me.combNWL.Items.AddRange(New Object() {"kilometers", "meters", "millimeters", "micrometers", "nanometers", "picometers"})
        Me.combNWL.Location = New System.Drawing.Point(327, 189)
        Me.combNWL.Name = "combNWL"
        Me.combNWL.Size = New System.Drawing.Size(70, 21)
        Me.combNWL.TabIndex = 59
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblT.ForeColor = System.Drawing.Color.Black
        Me.lblT.Location = New System.Drawing.Point(397, 82)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(26, 37)
        Me.lblT.TabIndex = 56
        Me.lblT.Text = "/"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(13, 36)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(44, 20)
        Me.lblError.TabIndex = 55
        Me.lblError.Text = "Error"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(452, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Velocity (V)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(10, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "New WaveLength"
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(542, 193)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(181, 20)
        Me.txtV.TabIndex = 50
        '
        'txtNWL
        '
        Me.txtNWL.Location = New System.Drawing.Point(155, 191)
        Me.txtNWL.Name = "txtNWL"
        Me.txtNWL.ReadOnly = True
        Me.txtNWL.Size = New System.Drawing.Size(166, 20)
        Me.txtNWL.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label5.Location = New System.Drawing.Point(337, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 37)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "="
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblV.ForeColor = System.Drawing.Color.Red
        Me.lblV.Location = New System.Drawing.Point(369, 82)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(39, 37)
        Me.lblV.TabIndex = 47
        Me.lblV.Text = "V"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblL.ForeColor = System.Drawing.Color.Black
        Me.lblL.Location = New System.Drawing.Point(415, 82)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(40, 37)
        Me.lblL.TabIndex = 46
        Me.lblL.Text = "C"
        '
        'lblLambdaPrime
        '
        Me.lblLambdaPrime.Font = New System.Drawing.Font("Symbol", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblLambdaPrime.ForeColor = System.Drawing.Color.Green
        Me.lblLambdaPrime.Location = New System.Drawing.Point(263, 61)
        Me.lblLambdaPrime.Name = "lblLambdaPrime"
        Me.lblLambdaPrime.Size = New System.Drawing.Size(30, 37)
        Me.lblLambdaPrime.TabIndex = 67
        Me.lblLambdaPrime.Text = "l"
        '
        'lblLambdaTop
        '
        Me.lblLambdaTop.Font = New System.Drawing.Font("Symbol", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblLambdaTop.ForeColor = System.Drawing.Color.Red
        Me.lblLambdaTop.Location = New System.Drawing.Point(311, 61)
        Me.lblLambdaTop.Name = "lblLambdaTop"
        Me.lblLambdaTop.Size = New System.Drawing.Size(31, 37)
        Me.lblLambdaTop.TabIndex = 68
        Me.lblLambdaTop.Text = "l"
        '
        'lblLambdaBot
        '
        Me.lblLambdaBot.Font = New System.Drawing.Font("Symbol", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblLambdaBot.ForeColor = System.Drawing.Color.Red
        Me.lblLambdaBot.Location = New System.Drawing.Point(290, 98)
        Me.lblLambdaBot.Name = "lblLambdaBot"
        Me.lblLambdaBot.Size = New System.Drawing.Size(31, 37)
        Me.lblLambdaBot.TabIndex = 69
        Me.lblLambdaBot.Text = "l"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(280, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "'"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label8.Location = New System.Drawing.Point(294, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 32)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "-"
        '
        'combWL
        '
        Me.combWL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combWL.FormattingEnabled = True
        Me.combWL.Items.AddRange(New Object() {"kilometers", "meters", "millimeters", "micrometers", "nanometers", "picometers"})
        Me.combWL.Location = New System.Drawing.Point(327, 229)
        Me.combWL.Name = "combWL"
        Me.combWL.Size = New System.Drawing.Size(70, 21)
        Me.combWL.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(13, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Old WaveLength"
        '
        'txtOWL
        '
        Me.txtOWL.Location = New System.Drawing.Point(155, 231)
        Me.txtOWL.Name = "txtOWL"
        Me.txtOWL.Size = New System.Drawing.Size(166, 20)
        Me.txtOWL.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(272, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 3)
        Me.Label10.TabIndex = 75
        '
        'lblVelocityUnit
        '
        Me.lblVelocityUnit.AutoSize = True
        Me.lblVelocityUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityUnit.Location = New System.Drawing.Point(452, 336)
        Me.lblVelocityUnit.Name = "lblVelocityUnit"
        Me.lblVelocityUnit.Size = New System.Drawing.Size(73, 20)
        Me.lblVelocityUnit.TabIndex = 76
        Me.lblVelocityUnit.Text = "NO UNIT"
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.Location = New System.Drawing.Point(725, 215)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(47, 20)
        Me.lblDirection.TabIndex = 77
        Me.lblDirection.Text = "Away"
        Me.lblDirection.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(724, 450)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 91
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmHubblesLaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 485)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.lblVelocityUnit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.combWL)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtOWL)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLambdaBot)
        Me.Controls.Add(Me.lblLambdaTop)
        Me.Controls.Add(Me.lblLambdaPrime)
        Me.Controls.Add(Me.lblNWLUnit)
        Me.Controls.Add(Me.lblWLUnit)
        Me.Controls.Add(Me.combV)
        Me.Controls.Add(Me.combNWL)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtV)
        Me.Controls.Add(Me.txtNWL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblV)
        Me.Controls.Add(Me.lblL)
        Me.Name = "frmHubblesLaw"
        Me.Text = "HubblesLaw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNWLUnit As System.Windows.Forms.Label
    Friend WithEvents lblWLUnit As System.Windows.Forms.Label
    Friend WithEvents combV As System.Windows.Forms.ComboBox
    Friend WithEvents combNWL As System.Windows.Forms.ComboBox
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtV As System.Windows.Forms.TextBox
    Friend WithEvents txtNWL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents lblL As System.Windows.Forms.Label
    Friend WithEvents lblLambdaPrime As System.Windows.Forms.Label
    Friend WithEvents lblLambdaTop As System.Windows.Forms.Label
    Friend WithEvents lblLambdaBot As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents combWL As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOWL As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityUnit As System.Windows.Forms.Label
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
