﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEchoChamber
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
        Me.btnGreetings = New System.Windows.Forms.Button()
        Me.btnHobby = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnSeason = New System.Windows.Forms.Button()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnGreetings
        '
        Me.btnGreetings.Location = New System.Drawing.Point(224, 12)
        Me.btnGreetings.Name = "btnGreetings"
        Me.btnGreetings.Size = New System.Drawing.Size(75, 23)
        Me.btnGreetings.TabIndex = 0
        Me.btnGreetings.Text = "Greetings"
        Me.btnGreetings.UseVisualStyleBackColor = True
        '
        'btnHobby
        '
        Me.btnHobby.Location = New System.Drawing.Point(143, 41)
        Me.btnHobby.Name = "btnHobby"
        Me.btnHobby.Size = New System.Drawing.Size(75, 23)
        Me.btnHobby.TabIndex = 1
        Me.btnHobby.Text = "Hobby"
        Me.btnHobby.UseVisualStyleBackColor = True
        '
        'btnFood
        '
        Me.btnFood.Location = New System.Drawing.Point(224, 41)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(75, 23)
        Me.btnFood.TabIndex = 2
        Me.btnFood.Text = "Food"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'btnSeason
        '
        Me.btnSeason.Location = New System.Drawing.Point(305, 41)
        Me.btnSeason.Name = "btnSeason"
        Me.btnSeason.Size = New System.Drawing.Size(75, 23)
        Me.btnSeason.TabIndex = 3
        Me.btnSeason.Text = "Season"
        Me.btnSeason.UseVisualStyleBackColor = True
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(12, 73)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(499, 216)
        Me.rtbOutput.TabIndex = 4
        Me.rtbOutput.Text = ""
        '
        'frmEchoChamber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 304)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.btnSeason)
        Me.Controls.Add(Me.btnFood)
        Me.Controls.Add(Me.btnHobby)
        Me.Controls.Add(Me.btnGreetings)
        Me.Name = "frmEchoChamber"
        Me.Text = "Echo Chamber"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGreetings As Button
    Friend WithEvents btnHobby As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents btnSeason As Button
    Friend WithEvents rtbOutput As RichTextBox
End Class
