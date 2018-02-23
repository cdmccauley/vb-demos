<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriCalc
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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPeri = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(12, 12)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 0
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(129, 15)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(40, 13)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Text = "Length"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(12, 38)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 2
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(129, 41)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 3
        Me.lblWidth.Text = "Width"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(12, 66)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPeri
        '
        Me.lblPeri.AutoSize = True
        Me.lblPeri.Location = New System.Drawing.Point(118, 71)
        Me.lblPeri.Name = "lblPeri"
        Me.lblPeri.Size = New System.Drawing.Size(51, 13)
        Me.lblPeri.TabIndex = 5
        Me.lblPeri.Text = "Perimeter"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 98)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Cal&culate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 127)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPeriCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPeri)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.txtLength)
        Me.Name = "frmPeriCalc"
        Me.Text = "Perimeter Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblLength As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPeri As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
