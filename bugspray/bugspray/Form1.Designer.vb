<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBugSpray
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtCans = New System.Windows.Forms.TextBox()
        Me.lblCans = New System.Windows.Forms.Label()
        Me.lblPricetag = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Bug Spray"
        '
        'txtCans
        '
        Me.txtCans.Location = New System.Drawing.Point(17, 53)
        Me.txtCans.Name = "txtCans"
        Me.txtCans.Size = New System.Drawing.Size(100, 20)
        Me.txtCans.TabIndex = 1
        Me.txtCans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCans
        '
        Me.lblCans.AutoSize = True
        Me.lblCans.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCans.ForeColor = System.Drawing.Color.White
        Me.lblCans.Location = New System.Drawing.Point(123, 56)
        Me.lblCans.Name = "lblCans"
        Me.lblCans.Size = New System.Drawing.Size(94, 15)
        Me.lblCans.TabIndex = 2
        Me.lblCans.Text = "Number of Cans"
        '
        'lblPricetag
        '
        Me.lblPricetag.AutoSize = True
        Me.lblPricetag.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricetag.ForeColor = System.Drawing.Color.White
        Me.lblPricetag.Location = New System.Drawing.Point(123, 88)
        Me.lblPricetag.Name = "lblPricetag"
        Me.lblPricetag.Size = New System.Drawing.Size(78, 15)
        Me.lblPricetag.TabIndex = 3
        Me.lblPricetag.Text = "x $3.25 / can"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(17, 117)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(123, 123)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(35, 15)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Price"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(42, 186)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 41)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate Cost"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(126, 238)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBugSpray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(237, 282)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblPricetag)
        Me.Controls.Add(Me.lblCans)
        Me.Controls.Add(Me.txtCans)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmBugSpray"
        Me.Text = "Bug Spray"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtCans As TextBox
    Friend WithEvents lblCans As Label
    Friend WithEvents lblPricetag As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
