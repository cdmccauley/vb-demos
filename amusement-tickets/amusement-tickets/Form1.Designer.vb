<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmusementTickets
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
        Me.txtTotalChild = New System.Windows.Forms.TextBox()
        Me.txtTotalAdult = New System.Windows.Forms.TextBox()
        Me.txtTotalSenior = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblChildren = New System.Windows.Forms.Label()
        Me.lblAdults = New System.Windows.Forms.Label()
        Me.lblSeniors = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblChildPrice = New System.Windows.Forms.Label()
        Me.lblAdultPrice = New System.Windows.Forms.Label()
        Me.lblSeniorPrice = New System.Windows.Forms.Label()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblChildSubtotal = New System.Windows.Forms.Label()
        Me.lblAdultSubtotal = New System.Windows.Forms.Label()
        Me.lblSeniorSubtotal = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTicketTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotalChild
        '
        Me.txtTotalChild.Location = New System.Drawing.Point(113, 38)
        Me.txtTotalChild.Name = "txtTotalChild"
        Me.txtTotalChild.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalChild.TabIndex = 0
        Me.txtTotalChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAdult
        '
        Me.txtTotalAdult.Location = New System.Drawing.Point(113, 64)
        Me.txtTotalAdult.Name = "txtTotalAdult"
        Me.txtTotalAdult.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAdult.TabIndex = 1
        Me.txtTotalAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalSenior
        '
        Me.txtTotalSenior.Location = New System.Drawing.Point(113, 90)
        Me.txtTotalSenior.Name = "txtTotalSenior"
        Me.txtTotalSenior.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSenior.TabIndex = 2
        Me.txtTotalSenior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(244, 155)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(325, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblChildren
        '
        Me.lblChildren.AutoSize = True
        Me.lblChildren.Location = New System.Drawing.Point(12, 41)
        Me.lblChildren.Name = "lblChildren"
        Me.lblChildren.Size = New System.Drawing.Size(45, 13)
        Me.lblChildren.TabIndex = 5
        Me.lblChildren.Text = "Children"
        '
        'lblAdults
        '
        Me.lblAdults.AutoSize = True
        Me.lblAdults.Location = New System.Drawing.Point(21, 67)
        Me.lblAdults.Name = "lblAdults"
        Me.lblAdults.Size = New System.Drawing.Size(36, 13)
        Me.lblAdults.TabIndex = 6
        Me.lblAdults.Text = "Adults"
        '
        'lblSeniors
        '
        Me.lblSeniors.AutoSize = True
        Me.lblSeniors.Location = New System.Drawing.Point(15, 93)
        Me.lblSeniors.Name = "lblSeniors"
        Me.lblSeniors.Size = New System.Drawing.Size(42, 13)
        Me.lblSeniors.TabIndex = 7
        Me.lblSeniors.Text = "Seniors"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(72, 13)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price"
        '
        'lblChildPrice
        '
        Me.lblChildPrice.AutoSize = True
        Me.lblChildPrice.Location = New System.Drawing.Point(69, 41)
        Me.lblChildPrice.Name = "lblChildPrice"
        Me.lblChildPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblChildPrice.TabIndex = 9
        Me.lblChildPrice.Text = "$6.00"
        '
        'lblAdultPrice
        '
        Me.lblAdultPrice.AutoSize = True
        Me.lblAdultPrice.Location = New System.Drawing.Point(63, 67)
        Me.lblAdultPrice.Name = "lblAdultPrice"
        Me.lblAdultPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblAdultPrice.TabIndex = 10
        Me.lblAdultPrice.Text = "$12.00"
        '
        'lblSeniorPrice
        '
        Me.lblSeniorPrice.AutoSize = True
        Me.lblSeniorPrice.Location = New System.Drawing.Point(69, 93)
        Me.lblSeniorPrice.Name = "lblSeniorPrice"
        Me.lblSeniorPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblSeniorPrice.TabIndex = 11
        Me.lblSeniorPrice.Text = "$9.00"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Location = New System.Drawing.Point(141, 13)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(42, 13)
        Me.lblTickets.TabIndex = 12
        Me.lblTickets.Text = "Tickets"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(245, 13)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 13
        Me.lblAmount.Text = "Amount"
        '
        'lblChildSubtotal
        '
        Me.lblChildSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblChildSubtotal.Location = New System.Drawing.Point(219, 38)
        Me.lblChildSubtotal.Name = "lblChildSubtotal"
        Me.lblChildSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.lblChildSubtotal.TabIndex = 14
        Me.lblChildSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdultSubtotal
        '
        Me.lblAdultSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAdultSubtotal.Location = New System.Drawing.Point(219, 64)
        Me.lblAdultSubtotal.Name = "lblAdultSubtotal"
        Me.lblAdultSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.lblAdultSubtotal.TabIndex = 15
        Me.lblAdultSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSeniorSubtotal
        '
        Me.lblSeniorSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSeniorSubtotal.Location = New System.Drawing.Point(219, 90)
        Me.lblSeniorSubtotal.Name = "lblSeniorSubtotal"
        Me.lblSeniorSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.lblSeniorSubtotal.TabIndex = 16
        Me.lblSeniorSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Location = New System.Drawing.Point(72, 120)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.lblTotalLabel.TabIndex = 17
        Me.lblTotalLabel.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(219, 116)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTicketTotal
        '
        Me.lblTicketTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTicketTotal.Location = New System.Drawing.Point(113, 116)
        Me.lblTicketTotal.Name = "lblTicketTotal"
        Me.lblTicketTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblTicketTotal.TabIndex = 19
        Me.lblTicketTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAmusementTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 195)
        Me.Controls.Add(Me.lblTicketTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblSeniorSubtotal)
        Me.Controls.Add(Me.lblAdultSubtotal)
        Me.Controls.Add(Me.lblChildSubtotal)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.lblSeniorPrice)
        Me.Controls.Add(Me.lblAdultPrice)
        Me.Controls.Add(Me.lblChildPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblSeniors)
        Me.Controls.Add(Me.lblAdults)
        Me.Controls.Add(Me.lblChildren)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTotalSenior)
        Me.Controls.Add(Me.txtTotalAdult)
        Me.Controls.Add(Me.txtTotalChild)
        Me.Name = "frmAmusementTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amusement Park Tickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotalChild As TextBox
    Friend WithEvents txtTotalAdult As TextBox
    Friend WithEvents txtTotalSenior As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblChildren As Label
    Friend WithEvents lblAdults As Label
    Friend WithEvents lblSeniors As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblChildPrice As Label
    Friend WithEvents lblAdultPrice As Label
    Friend WithEvents lblSeniorPrice As Label
    Friend WithEvents lblTickets As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblChildSubtotal As Label
    Friend WithEvents lblAdultSubtotal As Label
    Friend WithEvents lblSeniorSubtotal As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTicketTotal As Label
End Class
