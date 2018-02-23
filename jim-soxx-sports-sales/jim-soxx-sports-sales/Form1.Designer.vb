<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJimSoxxSports
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
        Me.txtFootBQty = New System.Windows.Forms.TextBox()
        Me.txtBasketBQty = New System.Windows.Forms.TextBox()
        Me.txtVolleyBQty = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFootBQty = New System.Windows.Forms.Label()
        Me.lblBasketBQty = New System.Windows.Forms.Label()
        Me.lblVolleyBQty = New System.Windows.Forms.Label()
        Me.lblItemTotal = New System.Windows.Forms.Label()
        Me.lblItemQty = New System.Windows.Forms.Label()
        Me.lblFootBPrice = New System.Windows.Forms.Label()
        Me.lblBasketBPrice = New System.Windows.Forms.Label()
        Me.lblVolleyBPrice = New System.Windows.Forms.Label()
        Me.lblSubtotalLabel = New System.Windows.Forms.Label()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblFootBTotal = New System.Windows.Forms.Label()
        Me.lblBasketBTotal = New System.Windows.Forms.Label()
        Me.lblVolleyBTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTaxTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFootBQty
        '
        Me.txtFootBQty.Location = New System.Drawing.Point(82, 13)
        Me.txtFootBQty.Name = "txtFootBQty"
        Me.txtFootBQty.Size = New System.Drawing.Size(100, 20)
        Me.txtFootBQty.TabIndex = 0
        Me.txtFootBQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBasketBQty
        '
        Me.txtBasketBQty.Location = New System.Drawing.Point(82, 39)
        Me.txtBasketBQty.Name = "txtBasketBQty"
        Me.txtBasketBQty.Size = New System.Drawing.Size(100, 20)
        Me.txtBasketBQty.TabIndex = 1
        Me.txtBasketBQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVolleyBQty
        '
        Me.txtVolleyBQty.Location = New System.Drawing.Point(82, 65)
        Me.txtVolleyBQty.Name = "txtVolleyBQty"
        Me.txtVolleyBQty.Size = New System.Drawing.Size(100, 20)
        Me.txtVolleyBQty.TabIndex = 2
        Me.txtVolleyBQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(315, 193)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Cal&culate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFootBQty
        '
        Me.lblFootBQty.AutoSize = True
        Me.lblFootBQty.Location = New System.Drawing.Point(17, 15)
        Me.lblFootBQty.Name = "lblFootBQty"
        Me.lblFootBQty.Size = New System.Drawing.Size(49, 13)
        Me.lblFootBQty.TabIndex = 5
        Me.lblFootBQty.Text = "Footballs"
        '
        'lblBasketBQty
        '
        Me.lblBasketBQty.AutoSize = True
        Me.lblBasketBQty.Location = New System.Drawing.Point(17, 41)
        Me.lblBasketBQty.Name = "lblBasketBQty"
        Me.lblBasketBQty.Size = New System.Drawing.Size(61, 13)
        Me.lblBasketBQty.TabIndex = 6
        Me.lblBasketBQty.Text = "Basketballs"
        '
        'lblVolleyBQty
        '
        Me.lblVolleyBQty.AutoSize = True
        Me.lblVolleyBQty.Location = New System.Drawing.Point(17, 67)
        Me.lblVolleyBQty.Name = "lblVolleyBQty"
        Me.lblVolleyBQty.Size = New System.Drawing.Size(56, 13)
        Me.lblVolleyBQty.TabIndex = 7
        Me.lblVolleyBQty.Text = "Volleyballs"
        '
        'lblItemTotal
        '
        Me.lblItemTotal.AutoSize = True
        Me.lblItemTotal.Location = New System.Drawing.Point(17, 96)
        Me.lblItemTotal.Name = "lblItemTotal"
        Me.lblItemTotal.Size = New System.Drawing.Size(59, 13)
        Me.lblItemTotal.TabIndex = 8
        Me.lblItemTotal.Text = "Total Items"
        '
        'lblItemQty
        '
        Me.lblItemQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblItemQty.Location = New System.Drawing.Point(82, 92)
        Me.lblItemQty.Name = "lblItemQty"
        Me.lblItemQty.Size = New System.Drawing.Size(100, 23)
        Me.lblItemQty.TabIndex = 9
        Me.lblItemQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFootBPrice
        '
        Me.lblFootBPrice.AutoSize = True
        Me.lblFootBPrice.Location = New System.Drawing.Point(244, 16)
        Me.lblFootBPrice.Name = "lblFootBPrice"
        Me.lblFootBPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblFootBPrice.TabIndex = 10
        Me.lblFootBPrice.Text = "$44.95"
        '
        'lblBasketBPrice
        '
        Me.lblBasketBPrice.AutoSize = True
        Me.lblBasketBPrice.Location = New System.Drawing.Point(244, 41)
        Me.lblBasketBPrice.Name = "lblBasketBPrice"
        Me.lblBasketBPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblBasketBPrice.TabIndex = 11
        Me.lblBasketBPrice.Text = "$49.95"
        '
        'lblVolleyBPrice
        '
        Me.lblVolleyBPrice.AutoSize = True
        Me.lblVolleyBPrice.Location = New System.Drawing.Point(244, 68)
        Me.lblVolleyBPrice.Name = "lblVolleyBPrice"
        Me.lblVolleyBPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblVolleyBPrice.TabIndex = 12
        Me.lblVolleyBPrice.Text = "$39.95"
        '
        'lblSubtotalLabel
        '
        Me.lblSubtotalLabel.AutoSize = True
        Me.lblSubtotalLabel.Location = New System.Drawing.Point(238, 97)
        Me.lblSubtotalLabel.Name = "lblSubtotalLabel"
        Me.lblSubtotalLabel.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotalLabel.TabIndex = 13
        Me.lblSubtotalLabel.Text = "Subtotal"
        '
        'lblTaxRate
        '
        Me.lblTaxRate.AutoSize = True
        Me.lblTaxRate.Location = New System.Drawing.Point(213, 125)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(71, 13)
        Me.lblTaxRate.TabIndex = 14
        Me.lblTaxRate.Text = "Tax @ 5.00%"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Location = New System.Drawing.Point(253, 155)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.lblTotalLabel.TabIndex = 15
        Me.lblTotalLabel.Text = "Total"
        '
        'lblFootBTotal
        '
        Me.lblFootBTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFootBTotal.Location = New System.Drawing.Point(290, 10)
        Me.lblFootBTotal.Name = "lblFootBTotal"
        Me.lblFootBTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblFootBTotal.TabIndex = 16
        Me.lblFootBTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBasketBTotal
        '
        Me.lblBasketBTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBasketBTotal.Location = New System.Drawing.Point(290, 36)
        Me.lblBasketBTotal.Name = "lblBasketBTotal"
        Me.lblBasketBTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblBasketBTotal.TabIndex = 17
        Me.lblBasketBTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVolleyBTotal
        '
        Me.lblVolleyBTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblVolleyBTotal.Location = New System.Drawing.Point(290, 62)
        Me.lblVolleyBTotal.Name = "lblVolleyBTotal"
        Me.lblVolleyBTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblVolleyBTotal.TabIndex = 18
        Me.lblVolleyBTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSubtotal.Location = New System.Drawing.Point(290, 92)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 19
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxTotal
        '
        Me.lblTaxTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTaxTotal.Location = New System.Drawing.Point(290, 120)
        Me.lblTaxTotal.Name = "lblTaxTotal"
        Me.lblTaxTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTaxTotal.TabIndex = 20
        Me.lblTaxTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(290, 148)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmJimSoxxSports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 254)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTaxTotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblVolleyBTotal)
        Me.Controls.Add(Me.lblBasketBTotal)
        Me.Controls.Add(Me.lblFootBTotal)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblTaxRate)
        Me.Controls.Add(Me.lblSubtotalLabel)
        Me.Controls.Add(Me.lblVolleyBPrice)
        Me.Controls.Add(Me.lblBasketBPrice)
        Me.Controls.Add(Me.lblFootBPrice)
        Me.Controls.Add(Me.lblItemQty)
        Me.Controls.Add(Me.lblItemTotal)
        Me.Controls.Add(Me.lblVolleyBQty)
        Me.Controls.Add(Me.lblBasketBQty)
        Me.Controls.Add(Me.lblFootBQty)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtVolleyBQty)
        Me.Controls.Add(Me.txtBasketBQty)
        Me.Controls.Add(Me.txtFootBQty)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJimSoxxSports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jim Soxx Sports Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFootBQty As TextBox
    Friend WithEvents txtBasketBQty As TextBox
    Friend WithEvents txtVolleyBQty As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFootBQty As Label
    Friend WithEvents lblBasketBQty As Label
    Friend WithEvents lblVolleyBQty As Label
    Friend WithEvents lblItemTotal As Label
    Friend WithEvents lblItemQty As Label
    Friend WithEvents lblFootBPrice As Label
    Friend WithEvents lblBasketBPrice As Label
    Friend WithEvents lblVolleyBPrice As Label
    Friend WithEvents lblSubtotalLabel As Label
    Friend WithEvents lblTaxRate As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblFootBTotal As Label
    Friend WithEvents lblBasketBTotal As Label
    Friend WithEvents lblVolleyBTotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTaxTotal As Label
    Friend WithEvents lblTotal As Label
End Class
