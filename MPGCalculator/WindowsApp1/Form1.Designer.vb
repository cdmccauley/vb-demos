<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPGCalculator
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtGal = New System.Windows.Forms.TextBox()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblGalInput = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.lblMPGOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(197, 197)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(12, 12)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 2
        '
        'txtGal
        '
        Me.txtGal.Location = New System.Drawing.Point(12, 38)
        Me.txtGal.Name = "txtGal"
        Me.txtGal.Size = New System.Drawing.Size(100, 20)
        Me.txtGal.TabIndex = 3
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Location = New System.Drawing.Point(118, 15)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(65, 13)
        Me.lblMiles.TabIndex = 4
        Me.lblMiles.Text = "Miles Driven"
        '
        'lblGalInput
        '
        Me.lblGalInput.AutoSize = True
        Me.lblGalInput.Location = New System.Drawing.Point(118, 41)
        Me.lblGalInput.Name = "lblGalInput"
        Me.lblGalInput.Size = New System.Drawing.Size(70, 13)
        Me.lblGalInput.TabIndex = 5
        Me.lblGalInput.Text = "Gallons Used"
        '
        'lblMPG
        '
        Me.lblMPG.Location = New System.Drawing.Point(12, 70)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(100, 23)
        Me.lblMPG.TabIndex = 6
        '
        'lblMPGOutput
        '
        Me.lblMPGOutput.AutoSize = True
        Me.lblMPGOutput.Location = New System.Drawing.Point(118, 70)
        Me.lblMPGOutput.Name = "lblMPGOutput"
        Me.lblMPGOutput.Size = New System.Drawing.Size(31, 13)
        Me.lblMPGOutput.TabIndex = 7
        Me.lblMPGOutput.Text = "MPG"
        '
        'frmMPGCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblMPGOutput)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.lblGalInput)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.txtGal)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMPGCalculator"
        Me.Text = "MPG Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtGal As TextBox
    Friend WithEvents lblMiles As Label
    Friend WithEvents lblGalInput As Label
    Friend WithEvents lblMPG As Label
    Friend WithEvents lblMPGOutput As Label
End Class
