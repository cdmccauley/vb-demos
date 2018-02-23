<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRollUntil
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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.lblRollTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(12, 16)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(115, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Roll until result is (1 - 6)"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(133, 13)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(70, 20)
        Me.txtNumber.TabIndex = 1
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(70, 49)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "&Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(20, 91)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(175, 205)
        Me.rtbOutput.TabIndex = 3
        Me.rtbOutput.Text = ""
        '
        'lblRollTotal
        '
        Me.lblRollTotal.Location = New System.Drawing.Point(20, 312)
        Me.lblRollTotal.Name = "lblRollTotal"
        Me.lblRollTotal.Size = New System.Drawing.Size(175, 23)
        Me.lblRollTotal.TabIndex = 4
        Me.lblRollTotal.Text = "It took X rolls to roll an Y"
        Me.lblRollTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(70, 347)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRollUntil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 381)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblRollTotal)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "frmRollUntil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roll Until x"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents lblRollTotal As Label
    Friend WithEvents btnExit As Button
End Class
