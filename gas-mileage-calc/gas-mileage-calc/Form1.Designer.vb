<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGasMileCalc
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
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblGas = New System.Windows.Forms.Label()
        Me.txtGas = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Location = New System.Drawing.Point(12, 9)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(76, 13)
        Me.lblMiles.TabIndex = 0
        Me.lblMiles.Text = "Miles Traveled"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(15, 25)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 1
        Me.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGas
        '
        Me.lblGas.AutoSize = True
        Me.lblGas.Location = New System.Drawing.Point(12, 48)
        Me.lblGas.Name = "lblGas"
        Me.lblGas.Size = New System.Drawing.Size(98, 13)
        Me.lblGas.TabIndex = 2
        Me.lblGas.Text = "Gas Used (Gallons)"
        '
        'txtGas
        '
        Me.txtGas.Location = New System.Drawing.Point(15, 64)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(100, 20)
        Me.txtGas.TabIndex = 3
        Me.txtGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(121, 62)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Cal&culate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(12, 87)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(82, 13)
        Me.lblMPG.TabIndex = 5
        Me.lblMPG.Text = "Miles per Gallon"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(15, 100)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(202, 100)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGasMileCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 138)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtGas)
        Me.Controls.Add(Me.lblGas)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblMiles)
        Me.Name = "frmGasMileCalc"
        Me.Text = "Gas Mileage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMiles As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblGas As Label
    Friend WithEvents txtGas As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblMPG As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExit As Button
End Class
