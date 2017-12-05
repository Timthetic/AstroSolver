<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStefanBoltzmann
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
        Me.lblRadiusUnit = New System.Windows.Forms.Label()
        Me.lblLuminocityUnit = New System.Windows.Forms.Label()
        Me.lblTemperatureUnit = New System.Windows.Forms.Label()
        Me.combT = New System.Windows.Forms.ComboBox()
        Me.combR = New System.Windows.Forms.ComboBox()
        Me.combL = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRadiusUnit
        '
        Me.lblRadiusUnit.AutoSize = True
        Me.lblRadiusUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadiusUnit.Location = New System.Drawing.Point(448, 389)
        Me.lblRadiusUnit.Name = "lblRadiusUnit"
        Me.lblRadiusUnit.Size = New System.Drawing.Size(57, 20)
        Me.lblRadiusUnit.TabIndex = 42
        Me.lblRadiusUnit.Text = "Label8"
        '
        'lblLuminocityUnit
        '
        Me.lblLuminocityUnit.AutoSize = True
        Me.lblLuminocityUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuminocityUnit.Location = New System.Drawing.Point(61, 389)
        Me.lblLuminocityUnit.Name = "lblLuminocityUnit"
        Me.lblLuminocityUnit.Size = New System.Drawing.Size(61, 20)
        Me.lblLuminocityUnit.TabIndex = 41
        Me.lblLuminocityUnit.Text = "Label 2"
        '
        'lblTemperatureUnit
        '
        Me.lblTemperatureUnit.AutoSize = True
        Me.lblTemperatureUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatureUnit.Location = New System.Drawing.Point(448, 423)
        Me.lblTemperatureUnit.Name = "lblTemperatureUnit"
        Me.lblTemperatureUnit.Size = New System.Drawing.Size(57, 20)
        Me.lblTemperatureUnit.TabIndex = 40
        Me.lblTemperatureUnit.Text = "Label1"
        '
        'combT
        '
        Me.combT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combT.FormattingEnabled = True
        Me.combT.Items.AddRange(New Object() {"kelvin", "celsius", "fahrenheit", "t of sun"})
        Me.combT.Location = New System.Drawing.Point(725, 252)
        Me.combT.Name = "combT"
        Me.combT.Size = New System.Drawing.Size(70, 21)
        Me.combT.TabIndex = 39
        '
        'combR
        '
        Me.combR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combR.FormattingEnabled = True
        Me.combR.Items.AddRange(New Object() {"meter", "kilometer", "feet", "mile", "solar radius"})
        Me.combR.Location = New System.Drawing.Point(725, 186)
        Me.combR.Name = "combR"
        Me.combR.Size = New System.Drawing.Size(70, 21)
        Me.combR.TabIndex = 38
        '
        'combL
        '
        Me.combL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combL.FormattingEnabled = True
        Me.combL.Items.AddRange(New Object() {"Watt", "Ls"})
        Me.combL.Location = New System.Drawing.Point(323, 184)
        Me.combL.Name = "combL"
        Me.combL.Size = New System.Drawing.Size(70, 21)
        Me.combL.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(492, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 20)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(427, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "2"
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblT.ForeColor = System.Drawing.Color.Red
        Me.lblT.Location = New System.Drawing.Point(465, 77)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(37, 37)
        Me.lblT.TabIndex = 34
        Me.lblT.Text = "T"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(9, 31)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(44, 20)
        Me.lblError.TabIndex = 33
        Me.lblError.Text = "Error"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(410, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "(T) Temperature"
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(539, 253)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(180, 20)
        Me.txtT.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(448, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "(R) Radius"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(38, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "(L) Luminocity"
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(538, 188)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(181, 20)
        Me.txtR.TabIndex = 28
        '
        'txtL
        '
        Me.txtL.Location = New System.Drawing.Point(151, 186)
        Me.txtL.Name = "txtL"
        Me.txtL.ReadOnly = True
        Me.txtL.Size = New System.Drawing.Size(166, 20)
        Me.txtL.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label5.Location = New System.Drawing.Point(333, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 37)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "="
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblR.ForeColor = System.Drawing.Color.Red
        Me.lblR.Location = New System.Drawing.Point(400, 77)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(39, 37)
        Me.lblR.TabIndex = 25
        Me.lblR.Text = "R"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblL.ForeColor = System.Drawing.Color.Green
        Me.lblL.Location = New System.Drawing.Point(301, 77)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(35, 37)
        Me.lblL.TabIndex = 23
        Me.lblL.Text = "L"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Symbol", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(359, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 39)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "4p"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Symbol", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(439, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 37)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "s"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(727, 439)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 91
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmStefanBoltzmann
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 474)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRadiusUnit)
        Me.Controls.Add(Me.lblLuminocityUnit)
        Me.Controls.Add(Me.lblTemperatureUnit)
        Me.Controls.Add(Me.combT)
        Me.Controls.Add(Me.combR)
        Me.Controls.Add(Me.combL)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.lblL)
        Me.Name = "frmStefanBoltzmann"
        Me.Text = "StefanBoltzmann"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRadiusUnit As System.Windows.Forms.Label
    Friend WithEvents lblLuminocityUnit As System.Windows.Forms.Label
    Friend WithEvents lblTemperatureUnit As System.Windows.Forms.Label
    Friend WithEvents combT As System.Windows.Forms.ComboBox
    Friend WithEvents combR As System.Windows.Forms.ComboBox
    Friend WithEvents combL As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents txtL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents lblL As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
