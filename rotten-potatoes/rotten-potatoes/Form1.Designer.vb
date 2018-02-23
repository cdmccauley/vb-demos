<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRottenPotatoes
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
        Me.lblRating = New System.Windows.Forms.Label()
        Me.nudRating = New System.Windows.Forms.NumericUpDown()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnRate = New System.Windows.Forms.Button()
        Me.lblReview = New System.Windows.Forms.Label()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        CType(Me.nudRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(14, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(448, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome to Rotten Potatoes! Leave your review below!"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(117, 42)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(176, 13)
        Me.lblRating.TabIndex = 1
        Me.lblRating.Text = "Rate the movie on a scale of 0 to 5:"
        '
        'nudRating
        '
        Me.nudRating.Location = New System.Drawing.Point(299, 40)
        Me.nudRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRating.Name = "nudRating"
        Me.nudRating.ReadOnly = True
        Me.nudRating.Size = New System.Drawing.Size(60, 20)
        Me.nudRating.TabIndex = 2
        Me.nudRating.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(107, 77)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(262, 13)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "What one word would you use to describe this movie?"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(148, 110)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(181, 20)
        Me.txtDescription.TabIndex = 4
        '
        'btnRate
        '
        Me.btnRate.Location = New System.Drawing.Point(185, 152)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.Size = New System.Drawing.Size(106, 23)
        Me.btnRate.TabIndex = 5
        Me.btnRate.Text = "Leave your rating!"
        Me.btnRate.UseVisualStyleBackColor = True
        '
        'lblReview
        '
        Me.lblReview.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblReview.Location = New System.Drawing.Point(12, 197)
        Me.lblReview.Name = "lblReview"
        Me.lblReview.Size = New System.Drawing.Size(450, 50)
        Me.lblReview.TabIndex = 6
        Me.lblReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(185, 268)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(106, 23)
        Me.btnAverage.TabIndex = 7
        Me.btnAverage.Text = "Average Rating"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAverage.Location = New System.Drawing.Point(15, 313)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(450, 50)
        Me.lblAverage.TabIndex = 8
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRottenPotatoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 377)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.lblReview)
        Me.Controls.Add(Me.btnRate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.nudRating)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmRottenPotatoes"
        Me.Text = "Rotten Potatoes Movie Reviews"
        CType(Me.nudRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents nudRating As NumericUpDown
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnRate As Button
    Friend WithEvents lblReview As Label
    Friend WithEvents btnAverage As Button
    Friend WithEvents lblAverage As Label
End Class
