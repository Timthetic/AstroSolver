<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnNewtonSynth = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStefanBoltzmann = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDopShift = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDistMod = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewtonSynth
        '
        Me.btnNewtonSynth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnNewtonSynth.Location = New System.Drawing.Point(22, 99)
        Me.btnNewtonSynth.Name = "btnNewtonSynth"
        Me.btnNewtonSynth.Size = New System.Drawing.Size(149, 50)
        Me.btnNewtonSynth.TabIndex = 0
        Me.btnNewtonSynth.Text = "Newton Synthesis"
        Me.btnNewtonSynth.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a Formula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Orbital Motion: Relates (Period, Radius, Mass)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(576, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Star Properties: Relates (Luminosity, Radius, Temperature)"
        '
        'btnStefanBoltzmann
        '
        Me.btnStefanBoltzmann.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnStefanBoltzmann.Location = New System.Drawing.Point(22, 166)
        Me.btnStefanBoltzmann.Name = "btnStefanBoltzmann"
        Me.btnStefanBoltzmann.Size = New System.Drawing.Size(149, 50)
        Me.btnStefanBoltzmann.TabIndex = 3
        Me.btnStefanBoltzmann.Text = "Stefan-Boltzmann"
        Me.btnStefanBoltzmann.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(417, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Doppler Shift: Relates (Red Shift, Velocity)"
        '
        'btnDopShift
        '
        Me.btnDopShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDopShift.Location = New System.Drawing.Point(22, 235)
        Me.btnDopShift.Name = "btnDopShift"
        Me.btnDopShift.Size = New System.Drawing.Size(149, 50)
        Me.btnDopShift.TabIndex = 5
        Me.btnDopShift.Text = "Doppler Shift"
        Me.btnDopShift.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(674, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Distance Modulus: Relates (Ap Magnitude, Abs Magnitude, Distance)"
        '
        'btnDistMod
        '
        Me.btnDistMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDistMod.Location = New System.Drawing.Point(22, 307)
        Me.btnDistMod.Name = "btnDistMod"
        Me.btnDistMod.Size = New System.Drawing.Size(149, 50)
        Me.btnDistMod.TabIndex = 7
        Me.btnDistMod.Text = "Distance Modulus"
        Me.btnDistMod.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 525)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDistMod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDopShift)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStefanBoltzmann)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewtonSynth)
        Me.Name = "frmMain"
        Me.Text = "Hub"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewtonSynth As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStefanBoltzmann As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDopShift As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDistMod As System.Windows.Forms.Button

End Class
