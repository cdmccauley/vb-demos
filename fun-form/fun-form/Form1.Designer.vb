<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFunForm
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
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnShrink = New System.Windows.Forms.Button()
        Me.btnGrow = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.FlatAppearance.BorderSize = 0
        Me.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRed.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRed.ForeColor = System.Drawing.Color.White
        Me.btnRed.Location = New System.Drawing.Point(12, 12)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(156, 23)
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.FlatAppearance.BorderSize = 0
        Me.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlue.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlue.ForeColor = System.Drawing.Color.Silver
        Me.btnBlue.Location = New System.Drawing.Point(174, 12)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(156, 23)
        Me.btnBlue.TabIndex = 1
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnShrink
        '
        Me.btnShrink.BackColor = System.Drawing.Color.Indigo
        Me.btnShrink.FlatAppearance.BorderSize = 0
        Me.btnShrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShrink.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShrink.ForeColor = System.Drawing.Color.White
        Me.btnShrink.Location = New System.Drawing.Point(174, 64)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(156, 23)
        Me.btnShrink.TabIndex = 2
        Me.btnShrink.Text = "shrink"
        Me.btnShrink.UseVisualStyleBackColor = False
        '
        'btnGrow
        '
        Me.btnGrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGrow.FlatAppearance.BorderSize = 0
        Me.btnGrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrow.Font = New System.Drawing.Font("Snap ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrow.Location = New System.Drawing.Point(12, 64)
        Me.btnGrow.Name = "btnGrow"
        Me.btnGrow.Size = New System.Drawing.Size(156, 23)
        Me.btnGrow.TabIndex = 3
        Me.btnGrow.Text = "GROW"
        Me.btnGrow.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Yellow
        Me.btnShow.FlatAppearance.BorderSize = 0
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(93, 116)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(156, 23)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        Me.btnShow.Visible = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Green
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Location = New System.Drawing.Point(93, 117)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(156, 23)
        Me.btnHide.TabIndex = 5
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Lime
        Me.btnExit.Location = New System.Drawing.Point(133, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "3x17"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmFunForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(342, 205)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnGrow)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "frmFunForm"
        Me.Text = "Fun Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRed As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnShrink As Button
    Friend WithEvents btnGrow As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnExit As Button
End Class
