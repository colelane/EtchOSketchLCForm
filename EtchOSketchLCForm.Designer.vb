<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchOSketchLCForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DrawBox = New System.Windows.Forms.PictureBox()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EraserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorChoose = New System.Windows.Forms.ColorDialog()
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawBox
        '
        Me.DrawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrawBox.Location = New System.Drawing.Point(146, 85)
        Me.DrawBox.Name = "DrawBox"
        Me.DrawBox.Size = New System.Drawing.Size(849, 648)
        Me.DrawBox.TabIndex = 0
        Me.DrawBox.TabStop = False
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(146, 755)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(163, 92)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "&Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(375, 755)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(163, 92)
        Me.DrawWaveformsButton.TabIndex = 2
        Me.DrawWaveformsButton.Text = "Draw Waveforms"
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(603, 755)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(163, 92)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(832, 755)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(163, 92)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenToolStripMenuItem, Me.EraserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1149, 40)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenToolStripMenuItem
        '
        Me.PenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.PenToolStripMenuItem.Name = "PenToolStripMenuItem"
        Me.PenToolStripMenuItem.Size = New System.Drawing.Size(74, 36)
        Me.PenToolStripMenuItem.Text = "Pen"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(206, 44)
        Me.SizeToolStripMenuItem.Text = "Size"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(162, 44)
        Me.ToolStripMenuItem2.Text = "1"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(162, 44)
        Me.ToolStripMenuItem3.Text = "2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(162, 44)
        Me.ToolStripMenuItem4.Text = "3"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(162, 44)
        Me.ToolStripMenuItem5.Text = "4"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(162, 44)
        Me.ToolStripMenuItem6.Text = "5"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(206, 44)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'EraserToolStripMenuItem
        '
        Me.EraserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem1})
        Me.EraserToolStripMenuItem.Name = "EraserToolStripMenuItem"
        Me.EraserToolStripMenuItem.Size = New System.Drawing.Size(98, 36)
        Me.EraserToolStripMenuItem.Text = "Eraser"
        '
        'SizeToolStripMenuItem1
        '
        Me.SizeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12})
        Me.SizeToolStripMenuItem1.Name = "SizeToolStripMenuItem1"
        Me.SizeToolStripMenuItem1.Size = New System.Drawing.Size(192, 44)
        Me.SizeToolStripMenuItem1.Text = "Size"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(175, 44)
        Me.ToolStripMenuItem7.Text = "5"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(175, 44)
        Me.ToolStripMenuItem8.Text = "10"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(175, 44)
        Me.ToolStripMenuItem9.Text = "20"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(175, 44)
        Me.ToolStripMenuItem10.Text = "30"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(175, 44)
        Me.ToolStripMenuItem11.Text = "40"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(175, 44)
        Me.ToolStripMenuItem12.Text = "50"
        '
        'ColorChoose
        '
        Me.ColorChoose.FullOpen = True
        '
        'EtchOSketchLCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1149, 864)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DrawBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EtchOSketchLCForm"
        Me.Text = "Etch-O-Sketch"
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawBox As PictureBox
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Public WithEvents ColorChoose As ColorDialog
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EraserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
End Class
