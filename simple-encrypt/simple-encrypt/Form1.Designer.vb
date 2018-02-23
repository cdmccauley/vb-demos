<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleEncrypt
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
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.txtOriginal = New System.Windows.Forms.TextBox()
        Me.btnSubstitue = New System.Windows.Forms.Button()
        Me.btnTranspose = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.trbLevel = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lbl25 = New System.Windows.Forms.Label()
        Me.txtSubstitute = New System.Windows.Forms.TextBox()
        Me.txtTranspose = New System.Windows.Forms.TextBox()
        CType(Me.trbLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(12, 9)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(87, 13)
        Me.lblOriginal.TabIndex = 0
        Me.lblOriginal.Text = "Original message"
        '
        'txtOriginal
        '
        Me.txtOriginal.Location = New System.Drawing.Point(15, 25)
        Me.txtOriginal.Name = "txtOriginal"
        Me.txtOriginal.Size = New System.Drawing.Size(257, 20)
        Me.txtOriginal.TabIndex = 1
        '
        'btnSubstitue
        '
        Me.btnSubstitue.Location = New System.Drawing.Point(15, 115)
        Me.btnSubstitue.Name = "btnSubstitue"
        Me.btnSubstitue.Size = New System.Drawing.Size(75, 23)
        Me.btnSubstitue.TabIndex = 3
        Me.btnSubstitue.Text = "&Substitute"
        Me.btnSubstitue.UseVisualStyleBackColor = True
        '
        'btnTranspose
        '
        Me.btnTranspose.Location = New System.Drawing.Point(15, 170)
        Me.btnTranspose.Name = "btnTranspose"
        Me.btnTranspose.Size = New System.Drawing.Size(75, 23)
        Me.btnTranspose.TabIndex = 4
        Me.btnTranspose.Text = "&Transpose"
        Me.btnTranspose.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(105, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'trbLevel
        '
        Me.trbLevel.Location = New System.Drawing.Point(15, 64)
        Me.trbLevel.Maximum = 25
        Me.trbLevel.Name = "trbLevel"
        Me.trbLevel.Size = New System.Drawing.Size(257, 45)
        Me.trbLevel.TabIndex = 2
        Me.trbLevel.Value = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cipher Level"
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.Location = New System.Drawing.Point(12, 96)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(13, 13)
        Me.lbl0.TabIndex = 9
        Me.lbl0.Text = "0"
        '
        'lbl25
        '
        Me.lbl25.AutoSize = True
        Me.lbl25.Location = New System.Drawing.Point(253, 96)
        Me.lbl25.Name = "lbl25"
        Me.lbl25.Size = New System.Drawing.Size(19, 13)
        Me.lbl25.TabIndex = 10
        Me.lbl25.Text = "25"
        '
        'txtSubstitute
        '
        Me.txtSubstitute.Location = New System.Drawing.Point(15, 144)
        Me.txtSubstitute.Name = "txtSubstitute"
        Me.txtSubstitute.ReadOnly = True
        Me.txtSubstitute.Size = New System.Drawing.Size(257, 20)
        Me.txtSubstitute.TabIndex = 11
        '
        'txtTranspose
        '
        Me.txtTranspose.Location = New System.Drawing.Point(15, 199)
        Me.txtTranspose.Multiline = True
        Me.txtTranspose.Name = "txtTranspose"
        Me.txtTranspose.ReadOnly = True
        Me.txtTranspose.Size = New System.Drawing.Size(257, 42)
        Me.txtTranspose.TabIndex = 12
        '
        'frmSimpleEncrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 279)
        Me.Controls.Add(Me.txtTranspose)
        Me.Controls.Add(Me.txtSubstitute)
        Me.Controls.Add(Me.lbl25)
        Me.Controls.Add(Me.lbl0)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trbLevel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTranspose)
        Me.Controls.Add(Me.btnSubstitue)
        Me.Controls.Add(Me.txtOriginal)
        Me.Controls.Add(Me.lblOriginal)
        Me.Name = "frmSimpleEncrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Encrypt"
        CType(Me.trbLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOriginal As Label
    Friend WithEvents txtOriginal As TextBox
    Friend WithEvents btnSubstitue As Button
    Friend WithEvents btnTranspose As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents trbLevel As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl25 As Label
    Friend WithEvents txtSubstitute As TextBox
    Friend WithEvents txtTranspose As TextBox
End Class
