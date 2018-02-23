<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertTemp
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
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.btnFahToCel = New System.Windows.Forms.Button()
        Me.btnCelToFah = New System.Windows.Forms.Button()
        Me.lblResultLabel = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(12, 9)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(67, 13)
        Me.lblTemp.TabIndex = 0
        Me.lblTemp.Text = "Temperature"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(85, 6)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp.TabIndex = 1
        Me.txtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnFahToCel
        '
        Me.btnFahToCel.Location = New System.Drawing.Point(15, 32)
        Me.btnFahToCel.Name = "btnFahToCel"
        Me.btnFahToCel.Size = New System.Drawing.Size(170, 23)
        Me.btnFahToCel.TabIndex = 2
        Me.btnFahToCel.Text = "Convert &Fahrenheit to Celsius"
        Me.btnFahToCel.UseVisualStyleBackColor = True
        '
        'btnCelToFah
        '
        Me.btnCelToFah.Location = New System.Drawing.Point(15, 61)
        Me.btnCelToFah.Name = "btnCelToFah"
        Me.btnCelToFah.Size = New System.Drawing.Size(170, 23)
        Me.btnCelToFah.TabIndex = 3
        Me.btnCelToFah.Text = "Convert &Celsius to Fahrenheit"
        Me.btnCelToFah.UseVisualStyleBackColor = True
        '
        'lblResultLabel
        '
        Me.lblResultLabel.AutoSize = True
        Me.lblResultLabel.Location = New System.Drawing.Point(12, 97)
        Me.lblResultLabel.Name = "lblResultLabel"
        Me.lblResultLabel.Size = New System.Drawing.Size(37, 13)
        Me.lblResultLabel.TabIndex = 4
        Me.lblResultLabel.Text = "Result"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(85, 92)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 5
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(110, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmConvertTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 162)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblResultLabel)
        Me.Controls.Add(Me.btnCelToFah)
        Me.Controls.Add(Me.btnFahToCel)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.lblTemp)
        Me.Name = "frmConvertTemp"
        Me.Text = "Convert Temperatures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTemp As Label
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents btnFahToCel As Button
    Friend WithEvents btnCelToFah As Button
    Friend WithEvents lblResultLabel As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
End Class
