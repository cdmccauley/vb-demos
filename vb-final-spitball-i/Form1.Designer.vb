<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCurrentMinute = New System.Windows.Forms.TextBox()
        Me.txtCurrentHour = New System.Windows.Forms.TextBox()
        Me.txtCurrentDay = New System.Windows.Forms.TextBox()
        Me.txtCurrentMonth = New System.Windows.Forms.TextBox()
        Me.txtCurrentYear = New System.Windows.Forms.TextBox()
        Me.txtAddMinute = New System.Windows.Forms.TextBox()
        Me.txtAddHour = New System.Windows.Forms.TextBox()
        Me.txtAddDay = New System.Windows.Forms.TextBox()
        Me.txtAddMonth = New System.Windows.Forms.TextBox()
        Me.txtAddYear = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.rtbDebug = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCurrentMinute
        '
        Me.txtCurrentMinute.Location = New System.Drawing.Point(57, 6)
        Me.txtCurrentMinute.Name = "txtCurrentMinute"
        Me.txtCurrentMinute.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentMinute.TabIndex = 0
        '
        'txtCurrentHour
        '
        Me.txtCurrentHour.Location = New System.Drawing.Point(57, 32)
        Me.txtCurrentHour.Name = "txtCurrentHour"
        Me.txtCurrentHour.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentHour.TabIndex = 1
        '
        'txtCurrentDay
        '
        Me.txtCurrentDay.Location = New System.Drawing.Point(57, 58)
        Me.txtCurrentDay.Name = "txtCurrentDay"
        Me.txtCurrentDay.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentDay.TabIndex = 2
        '
        'txtCurrentMonth
        '
        Me.txtCurrentMonth.Location = New System.Drawing.Point(57, 84)
        Me.txtCurrentMonth.Name = "txtCurrentMonth"
        Me.txtCurrentMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentMonth.TabIndex = 3
        '
        'txtCurrentYear
        '
        Me.txtCurrentYear.Location = New System.Drawing.Point(57, 110)
        Me.txtCurrentYear.Name = "txtCurrentYear"
        Me.txtCurrentYear.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentYear.TabIndex = 4
        '
        'txtAddMinute
        '
        Me.txtAddMinute.Location = New System.Drawing.Point(163, 6)
        Me.txtAddMinute.Name = "txtAddMinute"
        Me.txtAddMinute.Size = New System.Drawing.Size(100, 20)
        Me.txtAddMinute.TabIndex = 5
        '
        'txtAddHour
        '
        Me.txtAddHour.Location = New System.Drawing.Point(163, 32)
        Me.txtAddHour.Name = "txtAddHour"
        Me.txtAddHour.Size = New System.Drawing.Size(100, 20)
        Me.txtAddHour.TabIndex = 6
        '
        'txtAddDay
        '
        Me.txtAddDay.Location = New System.Drawing.Point(163, 58)
        Me.txtAddDay.Name = "txtAddDay"
        Me.txtAddDay.Size = New System.Drawing.Size(100, 20)
        Me.txtAddDay.TabIndex = 7
        '
        'txtAddMonth
        '
        Me.txtAddMonth.Location = New System.Drawing.Point(163, 84)
        Me.txtAddMonth.Name = "txtAddMonth"
        Me.txtAddMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtAddMonth.TabIndex = 8
        '
        'txtAddYear
        '
        Me.txtAddYear.Location = New System.Drawing.Point(163, 110)
        Me.txtAddYear.Name = "txtAddYear"
        Me.txtAddYear.Size = New System.Drawing.Size(100, 20)
        Me.txtAddYear.TabIndex = 9
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(188, 136)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 10
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'rtbDebug
        '
        Me.rtbDebug.Location = New System.Drawing.Point(12, 165)
        Me.rtbDebug.Name = "rtbDebug"
        Me.rtbDebug.Size = New System.Drawing.Size(251, 372)
        Me.rtbDebug.TabIndex = 11
        Me.rtbDebug.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Minute"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Month"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Year"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 549)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbDebug)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtAddYear)
        Me.Controls.Add(Me.txtAddMonth)
        Me.Controls.Add(Me.txtAddDay)
        Me.Controls.Add(Me.txtAddHour)
        Me.Controls.Add(Me.txtAddMinute)
        Me.Controls.Add(Me.txtCurrentYear)
        Me.Controls.Add(Me.txtCurrentMonth)
        Me.Controls.Add(Me.txtCurrentDay)
        Me.Controls.Add(Me.txtCurrentHour)
        Me.Controls.Add(Me.txtCurrentMinute)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCurrentMinute As TextBox
    Friend WithEvents txtCurrentHour As TextBox
    Friend WithEvents txtCurrentDay As TextBox
    Friend WithEvents txtCurrentMonth As TextBox
    Friend WithEvents txtCurrentYear As TextBox
    Friend WithEvents txtAddMinute As TextBox
    Friend WithEvents txtAddHour As TextBox
    Friend WithEvents txtAddDay As TextBox
    Friend WithEvents txtAddMonth As TextBox
    Friend WithEvents txtAddYear As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents rtbDebug As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
