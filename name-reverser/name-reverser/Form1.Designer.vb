<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNameReverser
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
        Me.lblNameIn = New System.Windows.Forms.Label()
        Me.txtNameIn = New System.Windows.Forms.TextBox()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblNameOut = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNameIn
        '
        Me.lblNameIn.AutoSize = True
        Me.lblNameIn.Location = New System.Drawing.Point(12, 9)
        Me.lblNameIn.Name = "lblNameIn"
        Me.lblNameIn.Size = New System.Drawing.Size(129, 13)
        Me.lblNameIn.TabIndex = 0
        Me.lblNameIn.Text = "Enter a first and last name"
        '
        'txtNameIn
        '
        Me.txtNameIn.Location = New System.Drawing.Point(15, 25)
        Me.txtNameIn.Name = "txtNameIn"
        Me.txtNameIn.Size = New System.Drawing.Size(257, 20)
        Me.txtNameIn.TabIndex = 1
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(105, 63)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(75, 23)
        Me.btnReverse.TabIndex = 2
        Me.btnReverse.Text = "&Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(15, 98)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Result"
        '
        'lblNameOut
        '
        Me.lblNameOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNameOut.Location = New System.Drawing.Point(15, 111)
        Me.lblNameOut.Name = "lblNameOut"
        Me.lblNameOut.Size = New System.Drawing.Size(257, 20)
        Me.lblNameOut.TabIndex = 4
        Me.lblNameOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(105, 156)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmNameReverser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 205)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblNameOut)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.txtNameIn)
        Me.Controls.Add(Me.lblNameIn)
        Me.Name = "frmNameReverser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Name Reverser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameIn As Label
    Friend WithEvents txtNameIn As TextBox
    Friend WithEvents btnReverse As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lblNameOut As Label
    Friend WithEvents btnExit As Button
End Class
