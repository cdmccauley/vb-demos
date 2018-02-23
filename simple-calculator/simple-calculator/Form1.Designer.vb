<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleCalculator
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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnIntDivide = New System.Windows.Forms.Button()
        Me.btnModDivide = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.lblOps = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(15, 29)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(121, 29)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(14, 77)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Addition"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(120, 77)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(100, 23)
        Me.btnSubtract.TabIndex = 3
        Me.btnSubtract.Text = "&Subtraction"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(14, 106)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(100, 23)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "&Multiplication"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(120, 106)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(100, 23)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "Long &Division"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnIntDivide
        '
        Me.btnIntDivide.Location = New System.Drawing.Point(14, 135)
        Me.btnIntDivide.Name = "btnIntDivide"
        Me.btnIntDivide.Size = New System.Drawing.Size(100, 23)
        Me.btnIntDivide.TabIndex = 6
        Me.btnIntDivide.Text = "&Integer Division"
        Me.btnIntDivide.UseVisualStyleBackColor = True
        '
        'btnModDivide
        '
        Me.btnModDivide.Location = New System.Drawing.Point(120, 135)
        Me.btnModDivide.Name = "btnModDivide"
        Me.btnModDivide.Size = New System.Drawing.Size(100, 23)
        Me.btnModDivide.TabIndex = 7
        Me.btnModDivide.Text = "M&odulus Division"
        Me.btnModDivide.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(14, 167)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(206, 23)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "The answer is..."
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(85, 11)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(69, 13)
        Me.lblVal.TabIndex = 9
        Me.lblVal.Text = "Input Values:"
        '
        'lblOps
        '
        Me.lblOps.AutoSize = True
        Me.lblOps.Location = New System.Drawing.Point(75, 57)
        Me.lblOps.Name = "lblOps"
        Me.lblOps.Size = New System.Drawing.Size(89, 13)
        Me.lblOps.TabIndex = 10
        Me.lblOps.Text = "Select Operation:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(79, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSimpleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 233)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOps)
        Me.Controls.Add(Me.lblVal)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnModDivide)
        Me.Controls.Add(Me.btnIntDivide)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "frmSimpleCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnIntDivide As Button
    Friend WithEvents btnModDivide As Button
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblVal As Label
    Friend WithEvents lblOps As Label
    Friend WithEvents btnExit As Button
End Class
