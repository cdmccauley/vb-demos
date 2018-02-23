<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostCalculator
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
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblSinglePrice = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(139, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sally Brate's Fancy Balloons"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(12, 45)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(99, 13)
        Me.lblQty.TabIndex = 1
        Me.lblQty.Text = "Number of Balloons"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(117, 42)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 20)
        Me.txtQty.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 84)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblSinglePrice
        '
        Me.lblSinglePrice.AutoSize = True
        Me.lblSinglePrice.Location = New System.Drawing.Point(93, 89)
        Me.lblSinglePrice.Name = "lblSinglePrice"
        Me.lblSinglePrice.Size = New System.Drawing.Size(42, 13)
        Me.lblSinglePrice.TabIndex = 4
        Me.lblSinglePrice.Text = "x $3.50"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Location = New System.Drawing.Point(12, 131)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(83, 13)
        Me.lblTotalLabel.TabIndex = 5
        Me.lblTotalLabel.Text = "Cost of Balloons"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(117, 130)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 6
        '
        'frmCostCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 170)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblSinglePrice)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCostCalculator"
        Me.Text = "Cost Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblSinglePrice As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotal As Label
End Class
