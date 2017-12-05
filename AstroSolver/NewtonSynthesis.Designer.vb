<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewtonSynthesis
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
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combT = New System.Windows.Forms.ComboBox()
        Me.combR = New System.Windows.Forms.ComboBox()
        Me.combM = New System.Windows.Forms.ComboBox()
        Me.lblMassUnit = New System.Windows.Forms.Label()
        Me.lblPeriodUnit = New System.Windows.Forms.Label()
        Me.lblRadiusUnit = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Underline)
        Me.lblT.ForeColor = System.Drawing.Color.Green
        Me.lblT.Location = New System.Drawing.Point(304, 39)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(37, 37)
        Me.lblT.TabIndex = 0
        Me.lblT.Text = "T"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblR.ForeColor = System.Drawing.Color.Red
        Me.lblR.Location = New System.Drawing.Point(304, 81)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(39, 37)
        Me.lblR.TabIndex = 1
        Me.lblR.Text = "R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Underline)
        Me.Label3.Location = New System.Drawing.Point(366, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "4(Pi)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(365, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "G"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label5.Location = New System.Drawing.Point(336, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 37)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "="
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(154, 164)
        Me.txtT.Name = "txtT"
        Me.txtT.ReadOnly = True
        Me.txtT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtT.Size = New System.Drawing.Size(166, 20)
        Me.txtT.TabIndex = 5
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(154, 234)
        Me.txtR.Name = "txtR"
        Me.txtR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtR.Size = New System.Drawing.Size(166, 20)
        Me.txtR.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(53, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "T (Seconds)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(64, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "R (Meters)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(451, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "M (kilogram)"
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(552, 164)
        Me.txtM.Name = "txtM"
        Me.txtM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtM.Size = New System.Drawing.Size(180, 20)
        Me.txtM.TabIndex = 9
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(12, 9)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(44, 20)
        Me.lblError.TabIndex = 12
        Me.lblError.Text = "Error"
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblM.ForeColor = System.Drawing.Color.Red
        Me.lblM.Location = New System.Drawing.Point(396, 76)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(43, 37)
        Me.lblM.TabIndex = 13
        Me.lblM.Text = "M"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(331, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(331, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "3"
        '
        'combT
        '
        Me.combT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combT.FormattingEnabled = True
        Me.combT.Items.AddRange(New Object() {"sec", "hr", "day", "yr"})
        Me.combT.Location = New System.Drawing.Point(326, 162)
        Me.combT.Name = "combT"
        Me.combT.Size = New System.Drawing.Size(70, 21)
        Me.combT.TabIndex = 16
        '
        'combR
        '
        Me.combR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combR.FormattingEnabled = True
        Me.combR.Items.AddRange(New Object() {"m", "km", "AU", "ly", "pc"})
        Me.combR.Location = New System.Drawing.Point(326, 232)
        Me.combR.Name = "combR"
        Me.combR.Size = New System.Drawing.Size(70, 21)
        Me.combR.TabIndex = 17
        '
        'combM
        '
        Me.combM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combM.FormattingEnabled = True
        Me.combM.Items.AddRange(New Object() {"kg", "Me", "Mj", "Ms"})
        Me.combM.Location = New System.Drawing.Point(738, 163)
        Me.combM.Name = "combM"
        Me.combM.Size = New System.Drawing.Size(70, 21)
        Me.combM.TabIndex = 18
        '
        'lblMassUnit
        '
        Me.lblMassUnit.AutoSize = True
        Me.lblMassUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMassUnit.Location = New System.Drawing.Point(451, 401)
        Me.lblMassUnit.Name = "lblMassUnit"
        Me.lblMassUnit.Size = New System.Drawing.Size(57, 20)
        Me.lblMassUnit.TabIndex = 19
        Me.lblMassUnit.Text = "Label1"
        '
        'lblPeriodUnit
        '
        Me.lblPeriodUnit.AutoSize = True
        Me.lblPeriodUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodUnit.Location = New System.Drawing.Point(64, 367)
        Me.lblPeriodUnit.Name = "lblPeriodUnit"
        Me.lblPeriodUnit.Size = New System.Drawing.Size(61, 20)
        Me.lblPeriodUnit.TabIndex = 20
        Me.lblPeriodUnit.Text = "Label 2"
        '
        'lblRadiusUnit
        '
        Me.lblRadiusUnit.AutoSize = True
        Me.lblRadiusUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadiusUnit.Location = New System.Drawing.Point(64, 400)
        Me.lblRadiusUnit.Name = "lblRadiusUnit"
        Me.lblRadiusUnit.Size = New System.Drawing.Size(57, 20)
        Me.lblRadiusUnit.TabIndex = 21
        Me.lblRadiusUnit.Text = "Label8"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(730, 395)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 91
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmNewtonSynthesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 430)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblRadiusUnit)
        Me.Controls.Add(Me.lblPeriodUnit)
        Me.Controls.Add(Me.lblMassUnit)
        Me.Controls.Add(Me.combM)
        Me.Controls.Add(Me.combR)
        Me.Controls.Add(Me.combT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.lblT)
        Me.Name = "frmNewtonSynthesis"
        Me.Text = "NewtonSynthesis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtT As System.Windows.Forms.TextBox
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtM As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblM As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents combT As System.Windows.Forms.ComboBox
    Friend WithEvents combR As System.Windows.Forms.ComboBox
    Friend WithEvents combM As System.Windows.Forms.ComboBox
    Friend WithEvents lblMassUnit As System.Windows.Forms.Label
    Friend WithEvents lblPeriodUnit As System.Windows.Forms.Label
    Friend WithEvents lblRadiusUnit As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
