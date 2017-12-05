<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDistanceModulus
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBigM = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDistanceUnit = New System.Windows.Forms.Label()
        Me.combBigM = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBigM = New System.Windows.Forms.TextBox()
        Me.lblmUnit = New System.Windows.Forms.Label()
        Me.lblBigMUnit = New System.Windows.Forms.Label()
        Me.combM = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.combD = New System.Windows.Forms.ComboBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(258, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 36)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(343, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 37)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "5"
        '
        'lblD
        '
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblD.ForeColor = System.Drawing.Color.Green
        Me.lblD.Location = New System.Drawing.Point(432, 74)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(33, 36)
        Me.lblD.TabIndex = 49
        Me.lblD.Text = "D"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label5.Location = New System.Drawing.Point(315, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 37)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "="
        '
        'lblBigM
        '
        Me.lblBigM.AutoSize = True
        Me.lblBigM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblBigM.ForeColor = System.Drawing.Color.Red
        Me.lblBigM.Location = New System.Drawing.Point(275, 74)
        Me.lblBigM.Name = "lblBigM"
        Me.lblBigM.Size = New System.Drawing.Size(43, 37)
        Me.lblBigM.TabIndex = 47
        Me.lblBigM.Text = "M"
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblM.ForeColor = System.Drawing.Color.Red
        Me.lblM.Location = New System.Drawing.Point(225, 71)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(44, 37)
        Me.lblM.TabIndex = 46
        Me.lblM.Text = "m"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(370, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 37)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "log("
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(461, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 37)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "/10)"
        '
        'lblDistanceUnit
        '
        Me.lblDistanceUnit.AutoSize = True
        Me.lblDistanceUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistanceUnit.Location = New System.Drawing.Point(476, 324)
        Me.lblDistanceUnit.Name = "lblDistanceUnit"
        Me.lblDistanceUnit.Size = New System.Drawing.Size(73, 20)
        Me.lblDistanceUnit.TabIndex = 87
        Me.lblDistanceUnit.Text = "NO UNIT"
        '
        'combBigM
        '
        Me.combBigM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combBigM.FormattingEnabled = True
        Me.combBigM.Items.AddRange(New Object() {"N.A."})
        Me.combBigM.Location = New System.Drawing.Point(368, 217)
        Me.combBigM.Name = "combBigM"
        Me.combBigM.Size = New System.Drawing.Size(70, 21)
        Me.combBigM.TabIndex = 86
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 20)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Absolute Magnitude (M)"
        '
        'txtBigM
        '
        Me.txtBigM.Location = New System.Drawing.Point(196, 219)
        Me.txtBigM.Name = "txtBigM"
        Me.txtBigM.Size = New System.Drawing.Size(166, 20)
        Me.txtBigM.TabIndex = 84
        '
        'lblmUnit
        '
        Me.lblmUnit.AutoSize = True
        Me.lblmUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmUnit.Location = New System.Drawing.Point(91, 324)
        Me.lblmUnit.Name = "lblmUnit"
        Me.lblmUnit.Size = New System.Drawing.Size(73, 20)
        Me.lblmUnit.TabIndex = 83
        Me.lblmUnit.Text = "NO UNIT"
        '
        'lblBigMUnit
        '
        Me.lblBigMUnit.AutoSize = True
        Me.lblBigMUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBigMUnit.Location = New System.Drawing.Point(91, 373)
        Me.lblBigMUnit.Name = "lblBigMUnit"
        Me.lblBigMUnit.Size = New System.Drawing.Size(73, 20)
        Me.lblBigMUnit.TabIndex = 82
        Me.lblBigMUnit.Text = "NO UNIT"
        '
        'combM
        '
        Me.combM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combM.FormattingEnabled = True
        Me.combM.Items.AddRange(New Object() {"N.A."})
        Me.combM.Location = New System.Drawing.Point(368, 177)
        Me.combM.Name = "combM"
        Me.combM.Size = New System.Drawing.Size(70, 21)
        Me.combM.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(464, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Distance (D)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(0, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Apparent Magnitude (m)"
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(566, 175)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(181, 20)
        Me.txtD.TabIndex = 78
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(196, 179)
        Me.txtM.Name = "txtM"
        Me.txtM.ReadOnly = True
        Me.txtM.Size = New System.Drawing.Size(166, 20)
        Me.txtM.TabIndex = 77
        '
        'combD
        '
        Me.combD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combD.FormattingEnabled = True
        Me.combD.Items.AddRange(New Object() {"pc", "ly", "AU", "km", "m"})
        Me.combD.Location = New System.Drawing.Point(753, 174)
        Me.combD.Name = "combD"
        Me.combD.Size = New System.Drawing.Size(70, 21)
        Me.combD.TabIndex = 88
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(12, 33)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(44, 20)
        Me.lblError.TabIndex = 89
        Me.lblError.Text = "Error"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(748, 463)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 90
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmDistanceModulus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 498)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.combD)
        Me.Controls.Add(Me.lblDistanceUnit)
        Me.Controls.Add(Me.combBigM)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBigM)
        Me.Controls.Add(Me.lblmUnit)
        Me.Controls.Add(Me.lblBigMUnit)
        Me.Controls.Add(Me.combM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBigM)
        Me.Controls.Add(Me.lblM)
        Me.Name = "FrmDistanceModulus"
        Me.Text = "FrmDistanceModulus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBigM As System.Windows.Forms.Label
    Friend WithEvents lblM As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDistanceUnit As System.Windows.Forms.Label
    Friend WithEvents combBigM As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBigM As System.Windows.Forms.TextBox
    Friend WithEvents lblmUnit As System.Windows.Forms.Label
    Friend WithEvents lblBigMUnit As System.Windows.Forms.Label
    Friend WithEvents combM As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtM As System.Windows.Forms.TextBox
    Friend WithEvents combD As System.Windows.Forms.ComboBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
