<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWageProp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblSalaryOffer = New System.Windows.Forms.Label()
        Me.txtSalaryOffer = New System.Windows.Forms.TextBox()
        Me.lblPennyOffer = New System.Windows.Forms.Label()
        Me.lblPennyTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblRecommend = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSalaryOffer
        '
        Me.lblSalaryOffer.AutoSize = True
        Me.lblSalaryOffer.Location = New System.Drawing.Point(12, 14)
        Me.lblSalaryOffer.Name = "lblSalaryOffer"
        Me.lblSalaryOffer.Size = New System.Drawing.Size(62, 13)
        Me.lblSalaryOffer.TabIndex = 0
        Me.lblSalaryOffer.Text = "Salary Offer"
        '
        'txtSalaryOffer
        '
        Me.txtSalaryOffer.Location = New System.Drawing.Point(80, 11)
        Me.txtSalaryOffer.Name = "txtSalaryOffer"
        Me.txtSalaryOffer.Size = New System.Drawing.Size(150, 20)
        Me.txtSalaryOffer.TabIndex = 1
        Me.txtSalaryOffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPennyOffer
        '
        Me.lblPennyOffer.AutoSize = True
        Me.lblPennyOffer.Location = New System.Drawing.Point(11, 71)
        Me.lblPennyOffer.Name = "lblPennyOffer"
        Me.lblPennyOffer.Size = New System.Drawing.Size(63, 13)
        Me.lblPennyOffer.TabIndex = 2
        Me.lblPennyOffer.Text = "Penny Offer"
        '
        'lblPennyTotal
        '
        Me.lblPennyTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPennyTotal.Location = New System.Drawing.Point(80, 67)
        Me.lblPennyTotal.Name = "lblPennyTotal"
        Me.lblPennyTotal.Size = New System.Drawing.Size(150, 20)
        Me.lblPennyTotal.TabIndex = 3
        Me.lblPennyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(105, 37)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Compare"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblRecommend
        '
        Me.lblRecommend.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRecommend.Location = New System.Drawing.Point(14, 544)
        Me.lblRecommend.Name = "lblRecommend"
        Me.lblRecommend.Size = New System.Drawing.Size(500, 50)
        Me.lblRecommend.TabIndex = 5
        Me.lblRecommend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(14, 101)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(500, 430)
        Me.rtbOutput.TabIndex = 6
        Me.rtbOutput.Text = "Day:" & Global.Microsoft.VisualBasic.ChrW(9) & "Growth:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(227, 618)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "$"
        '
        'frmWageProp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 660)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.lblRecommend)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPennyTotal)
        Me.Controls.Add(Me.lblPennyOffer)
        Me.Controls.Add(Me.txtSalaryOffer)
        Me.Controls.Add(Me.lblSalaryOffer)
        Me.Name = "frmWageProp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wage Propositon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalaryOffer As Label
    Friend WithEvents txtSalaryOffer As TextBox
    Friend WithEvents lblPennyOffer As Label
    Friend WithEvents lblPennyTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblRecommend As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
