<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmD6
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
        Me.lblInputLabel = New System.Windows.Forms.Label()
        Me.txtRoll = New System.Windows.Forms.TextBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.rtbRoll = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInputLabel
        '
        Me.lblInputLabel.AutoSize = True
        Me.lblInputLabel.Location = New System.Drawing.Point(31, 9)
        Me.lblInputLabel.Name = "lblInputLabel"
        Me.lblInputLabel.Size = New System.Drawing.Size(223, 13)
        Me.lblInputLabel.TabIndex = 0
        Me.lblInputLabel.Text = "How many times would you like to roll the die?"
        '
        'txtRoll
        '
        Me.txtRoll.Location = New System.Drawing.Point(92, 32)
        Me.txtRoll.Name = "txtRoll"
        Me.txtRoll.Size = New System.Drawing.Size(100, 20)
        Me.txtRoll.TabIndex = 1
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(105, 66)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "&Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'rtbRoll
        '
        Me.rtbRoll.Location = New System.Drawing.Point(17, 109)
        Me.rtbRoll.Name = "rtbRoll"
        Me.rtbRoll.Size = New System.Drawing.Size(250, 200)
        Me.rtbRoll.TabIndex = 3
        Me.rtbRoll.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(105, 327)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmD6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 370)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rtbRoll)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.txtRoll)
        Me.Controls.Add(Me.lblInputLabel)
        Me.Name = "frmD6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Six-sided Die"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInputLabel As Label
    Friend WithEvents txtRoll As TextBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents rtbRoll As RichTextBox
    Friend WithEvents btnExit As Button
End Class
