<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentScores
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
        Me.lblLRtb = New System.Windows.Forms.Label()
        Me.rtbStudents = New System.Windows.Forms.RichTextBox()
        Me.lblRRtb = New System.Windows.Forms.Label()
        Me.rtbScores = New System.Windows.Forms.RichTextBox()
        Me.btnStudentAsc = New System.Windows.Forms.Button()
        Me.btnScoreAsc = New System.Windows.Forms.Button()
        Me.btnStudentDes = New System.Windows.Forms.Button()
        Me.btnScoreDes = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLRtb
        '
        Me.lblLRtb.AutoSize = True
        Me.lblLRtb.Location = New System.Drawing.Point(38, 19)
        Me.lblLRtb.Name = "lblLRtb"
        Me.lblLRtb.Size = New System.Drawing.Size(49, 13)
        Me.lblLRtb.TabIndex = 0
        Me.lblLRtb.Text = "Students"
        '
        'rtbStudents
        '
        Me.rtbStudents.Location = New System.Drawing.Point(41, 35)
        Me.rtbStudents.Name = "rtbStudents"
        Me.rtbStudents.Size = New System.Drawing.Size(100, 100)
        Me.rtbStudents.TabIndex = 1
        Me.rtbStudents.Text = ""
        '
        'lblRRtb
        '
        Me.lblRRtb.AutoSize = True
        Me.lblRRtb.Location = New System.Drawing.Point(144, 19)
        Me.lblRRtb.Name = "lblRRtb"
        Me.lblRRtb.Size = New System.Drawing.Size(40, 13)
        Me.lblRRtb.TabIndex = 2
        Me.lblRRtb.Text = "Scores"
        '
        'rtbScores
        '
        Me.rtbScores.Location = New System.Drawing.Point(147, 35)
        Me.rtbScores.Name = "rtbScores"
        Me.rtbScores.Size = New System.Drawing.Size(100, 100)
        Me.rtbScores.TabIndex = 3
        Me.rtbScores.Text = ""
        '
        'btnStudentAsc
        '
        Me.btnStudentAsc.Location = New System.Drawing.Point(41, 141)
        Me.btnStudentAsc.Name = "btnStudentAsc"
        Me.btnStudentAsc.Size = New System.Drawing.Size(206, 23)
        Me.btnStudentAsc.TabIndex = 4
        Me.btnStudentAsc.Text = "Sort Students Ascending"
        Me.btnStudentAsc.UseVisualStyleBackColor = True
        '
        'btnScoreAsc
        '
        Me.btnScoreAsc.Location = New System.Drawing.Point(41, 170)
        Me.btnScoreAsc.Name = "btnScoreAsc"
        Me.btnScoreAsc.Size = New System.Drawing.Size(206, 23)
        Me.btnScoreAsc.TabIndex = 5
        Me.btnScoreAsc.Text = "Sort Scores Ascending"
        Me.btnScoreAsc.UseVisualStyleBackColor = True
        '
        'btnStudentDes
        '
        Me.btnStudentDes.Location = New System.Drawing.Point(41, 199)
        Me.btnStudentDes.Name = "btnStudentDes"
        Me.btnStudentDes.Size = New System.Drawing.Size(206, 23)
        Me.btnStudentDes.TabIndex = 6
        Me.btnStudentDes.Text = "Sort Students Descending"
        Me.btnStudentDes.UseVisualStyleBackColor = True
        '
        'btnScoreDes
        '
        Me.btnScoreDes.Location = New System.Drawing.Point(41, 228)
        Me.btnScoreDes.Name = "btnScoreDes"
        Me.btnScoreDes.Size = New System.Drawing.Size(206, 23)
        Me.btnScoreDes.TabIndex = 7
        Me.btnScoreDes.Text = "Sort Score Descending"
        Me.btnScoreDes.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(108, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStudentScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnScoreDes)
        Me.Controls.Add(Me.btnStudentDes)
        Me.Controls.Add(Me.btnScoreAsc)
        Me.Controls.Add(Me.btnStudentAsc)
        Me.Controls.Add(Me.rtbScores)
        Me.Controls.Add(Me.lblRRtb)
        Me.Controls.Add(Me.rtbStudents)
        Me.Controls.Add(Me.lblLRtb)
        Me.Name = "frmStudentScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLRtb As Label
    Friend WithEvents rtbStudents As RichTextBox
    Friend WithEvents lblRRtb As Label
    Friend WithEvents rtbScores As RichTextBox
    Friend WithEvents btnStudentAsc As Button
    Friend WithEvents btnScoreAsc As Button
    Friend WithEvents btnStudentDes As Button
    Friend WithEvents btnScoreDes As Button
    Friend WithEvents btnExit As Button
End Class
