<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStringManipulator
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
        Me.components = New System.ComponentModel.Container()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnToUpper = New System.Windows.Forms.Button()
        Me.btnToLower = New System.Windows.Forms.Button()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.btnPadLeft = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.btnPadRight = New System.Windows.Forms.Button()
        Me.btnSpaceIndex = New System.Windows.Forms.Button()
        Me.btnSubstring = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpButtons = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Location = New System.Drawing.Point(19, 16)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(52, 13)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Enter text"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(22, 32)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(267, 20)
        Me.txtInput.TabIndex = 1
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(22, 58)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(267, 20)
        Me.txtOutput.TabIndex = 2
        '
        'btnToUpper
        '
        Me.btnToUpper.Location = New System.Drawing.Point(22, 84)
        Me.btnToUpper.Name = "btnToUpper"
        Me.btnToUpper.Size = New System.Drawing.Size(85, 23)
        Me.btnToUpper.TabIndex = 3
        Me.btnToUpper.Text = "&Uppercase"
        Me.btnToUpper.UseVisualStyleBackColor = True
        '
        'btnToLower
        '
        Me.btnToLower.Location = New System.Drawing.Point(113, 84)
        Me.btnToLower.Name = "btnToLower"
        Me.btnToLower.Size = New System.Drawing.Size(85, 23)
        Me.btnToLower.TabIndex = 4
        Me.btnToLower.Text = "&Lowercase"
        Me.btnToLower.UseVisualStyleBackColor = True
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(204, 84)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(85, 23)
        Me.btnLength.TabIndex = 5
        Me.btnLength.Text = "L&ength"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'btnPadLeft
        '
        Me.btnPadLeft.Location = New System.Drawing.Point(22, 113)
        Me.btnPadLeft.Name = "btnPadLeft"
        Me.btnPadLeft.Size = New System.Drawing.Size(85, 23)
        Me.btnPadLeft.TabIndex = 6
        Me.btnPadLeft.Text = "&Pad Left 20"
        Me.ttpButtons.SetToolTip(Me.btnPadLeft, "Pad to 20 with spaces and @")
        Me.btnPadLeft.UseVisualStyleBackColor = True
        '
        'btnTrim
        '
        Me.btnTrim.Location = New System.Drawing.Point(113, 113)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(85, 23)
        Me.btnTrim.TabIndex = 7
        Me.btnTrim.Text = "&Trim"
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'btnPadRight
        '
        Me.btnPadRight.Location = New System.Drawing.Point(204, 113)
        Me.btnPadRight.Name = "btnPadRight"
        Me.btnPadRight.Size = New System.Drawing.Size(85, 23)
        Me.btnPadRight.TabIndex = 8
        Me.btnPadRight.Text = "P&ad Right *20"
        Me.ttpButtons.SetToolTip(Me.btnPadRight, "Pad to 20 with * and @")
        Me.btnPadRight.UseVisualStyleBackColor = True
        '
        'btnSpaceIndex
        '
        Me.btnSpaceIndex.Location = New System.Drawing.Point(22, 142)
        Me.btnSpaceIndex.Name = "btnSpaceIndex"
        Me.btnSpaceIndex.Size = New System.Drawing.Size(85, 23)
        Me.btnSpaceIndex.TabIndex = 9
        Me.btnSpaceIndex.Text = "&Index Space"
        Me.ttpButtons.SetToolTip(Me.btnSpaceIndex, "Remove data before first space")
        Me.btnSpaceIndex.UseVisualStyleBackColor = True
        '
        'btnSubstring
        '
        Me.btnSubstring.Location = New System.Drawing.Point(113, 142)
        Me.btnSubstring.Name = "btnSubstring"
        Me.btnSubstring.Size = New System.Drawing.Size(85, 23)
        Me.btnSubstring.TabIndex = 10
        Me.btnSubstring.Text = "&Substring 5"
        Me.ttpButtons.SetToolTip(Me.btnSubstring, "Display substring of 5 characters from the 5th position of string")
        Me.btnSubstring.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(204, 142)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(85, 23)
        Me.btnReverse.TabIndex = 11
        Me.btnReverse.Text = "&Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(113, 171)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStringManipulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 211)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnSubstring)
        Me.Controls.Add(Me.btnSpaceIndex)
        Me.Controls.Add(Me.btnPadRight)
        Me.Controls.Add(Me.btnTrim)
        Me.Controls.Add(Me.btnPadLeft)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.btnToLower)
        Me.Controls.Add(Me.btnToUpper)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInstruction)
        Me.Name = "frmStringManipulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Manipulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnToUpper As Button
    Friend WithEvents btnToLower As Button
    Friend WithEvents btnLength As Button
    Friend WithEvents btnPadLeft As Button
    Friend WithEvents btnTrim As Button
    Friend WithEvents btnPadRight As Button
    Friend WithEvents btnSpaceIndex As Button
    Friend WithEvents btnSubstring As Button
    Friend WithEvents btnReverse As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttpButtons As ToolTip
End Class
