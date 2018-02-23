<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighLow
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.lblSecret = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(184, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(105, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "High-Low!"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(86, 33)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(300, 50)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "You have been granted 1000 points!"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(153, 169)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(75, 23)
        Me.btnHigh.TabIndex = 2
        Me.btnHigh.Text = "&High"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(244, 169)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(75, 23)
        Me.btnLow.TabIndex = 3
        Me.btnLow.Text = "&Low"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.Location = New System.Drawing.Point(20, 83)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(433, 16)
        Me.lblRules.TabIndex = 4
        Me.lblRules.Text = "To win more points you must risk them. How many would you like to risk?"
        '
        'txtRisk
        '
        Me.txtRisk.Location = New System.Drawing.Point(174, 114)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(125, 20)
        Me.txtRisk.TabIndex = 1
        Me.txtRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice.Location = New System.Drawing.Point(60, 146)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(353, 20)
        Me.lblChoice.TabIndex = 6
        Me.lblChoice.Text = "Will the secret number be higher or lower than 7?"
        '
        'lblSecret
        '
        Me.lblSecret.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecret.Location = New System.Drawing.Point(86, 221)
        Me.lblSecret.Name = "lblSecret"
        Me.lblSecret.Size = New System.Drawing.Size(300, 50)
        Me.lblSecret.TabIndex = 7
        Me.lblSecret.Text = "The secret number is..."
        Me.lblSecret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmHighLow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 347)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSecret)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmHighLow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "High-Low"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnHigh As Button
    Friend WithEvents btnLow As Button
    Friend WithEvents lblRules As Label
    Friend WithEvents txtRisk As TextBox
    Friend WithEvents lblChoice As Label
    Friend WithEvents lblSecret As Label
    Friend WithEvents btnExit As Button
End Class
