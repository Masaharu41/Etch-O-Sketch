<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorForm
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
        Me.CursorColorButton = New System.Windows.Forms.Button()
        Me.DrawingColorButton = New System.Windows.Forms.Button()
        Me.BackgroundColorButton = New System.Windows.Forms.Button()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.ColorChangeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DefaultButton = New System.Windows.Forms.Button()
        Me.ColorsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorChangeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CursorColorButton
        '
        Me.CursorColorButton.Location = New System.Drawing.Point(61, 104)
        Me.CursorColorButton.Name = "CursorColorButton"
        Me.CursorColorButton.Size = New System.Drawing.Size(219, 61)
        Me.CursorColorButton.TabIndex = 0
        Me.CursorColorButton.Text = "Cursor"
        Me.ColorsToolTip.SetToolTip(Me.CursorColorButton, "Change the Cursor Color")
        Me.CursorColorButton.UseVisualStyleBackColor = True
        '
        'DrawingColorButton
        '
        Me.DrawingColorButton.Location = New System.Drawing.Point(286, 104)
        Me.DrawingColorButton.Name = "DrawingColorButton"
        Me.DrawingColorButton.Size = New System.Drawing.Size(193, 61)
        Me.DrawingColorButton.TabIndex = 1
        Me.DrawingColorButton.Text = "Drawing Pad"
        Me.ColorsToolTip.SetToolTip(Me.DrawingColorButton, "Changes the background of the drawing pad")
        Me.DrawingColorButton.UseVisualStyleBackColor = True
        '
        'BackgroundColorButton
        '
        Me.BackgroundColorButton.Location = New System.Drawing.Point(485, 104)
        Me.BackgroundColorButton.Name = "BackgroundColorButton"
        Me.BackgroundColorButton.Size = New System.Drawing.Size(209, 61)
        Me.BackgroundColorButton.TabIndex = 2
        Me.BackgroundColorButton.Text = "Background"
        Me.ColorsToolTip.SetToolTip(Me.BackgroundColorButton, "Changes the background color of the form")
        Me.BackgroundColorButton.UseVisualStyleBackColor = True
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Font = New System.Drawing.Font("Liberation Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorLabel.Location = New System.Drawing.Point(50, 41)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(644, 37)
        Me.ColorLabel.TabIndex = 3
        Me.ColorLabel.Text = "What color do you want to change?"
        '
        'ColorChangeGroupBox
        '
        Me.ColorChangeGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColorChangeGroupBox.AutoSize = True
        Me.ColorChangeGroupBox.BackColor = System.Drawing.Color.DarkGray
        Me.ColorChangeGroupBox.Controls.Add(Me.DefaultButton)
        Me.ColorChangeGroupBox.Controls.Add(Me.BackgroundColorButton)
        Me.ColorChangeGroupBox.Controls.Add(Me.ColorLabel)
        Me.ColorChangeGroupBox.Controls.Add(Me.CursorColorButton)
        Me.ColorChangeGroupBox.Controls.Add(Me.DrawingColorButton)
        Me.ColorChangeGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ColorChangeGroupBox.Name = "ColorChangeGroupBox"
        Me.ColorChangeGroupBox.Size = New System.Drawing.Size(742, 285)
        Me.ColorChangeGroupBox.TabIndex = 4
        Me.ColorChangeGroupBox.TabStop = False
        '
        'DefaultButton
        '
        Me.DefaultButton.Location = New System.Drawing.Point(286, 171)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(193, 61)
        Me.DefaultButton.TabIndex = 4
        Me.DefaultButton.Text = "Default"
        Me.ColorsToolTip.SetToolTip(Me.DefaultButton, "Restores all colors to default")
        Me.DefaultButton.UseVisualStyleBackColor = True
        '
        'ColorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 318)
        Me.Controls.Add(Me.ColorChangeGroupBox)
        Me.Name = "ColorForm"
        Me.Text = "Form1"
        Me.ColorChangeGroupBox.ResumeLayout(False)
        Me.ColorChangeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CursorColorButton As Button
    Friend WithEvents DrawingColorButton As Button
    Friend WithEvents BackgroundColorButton As Button
    Friend WithEvents ColorLabel As Label
    Friend WithEvents ColorChangeGroupBox As GroupBox
    Friend WithEvents DefaultButton As Button
    Friend WithEvents ColorsToolTip As ToolTip
End Class
