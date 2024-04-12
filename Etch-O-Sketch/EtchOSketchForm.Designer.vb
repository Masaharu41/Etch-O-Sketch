<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchOSketchForm
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.EtchyContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursorColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawingPadColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EtchyContextMenuStrip.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.DrawingPictureBox.ContextMenuStrip = Me.EtchyContextMenuStrip
        Me.DrawingPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawingPictureBox.Location = New System.Drawing.Point(59, 33)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(768, 381)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'EtchyContextMenuStrip
        '
        Me.EtchyContextMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.EtchyContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ColorsToolStripMenuItem})
        Me.EtchyContextMenuStrip.Name = "EtchyContextMenuStrip"
        Me.EtchyContextMenuStrip.Size = New System.Drawing.Size(129, 80)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(128, 38)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(128, 38)
        Me.ColorsToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursorColorToolStripMenuItem, Me.DrawingPadColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem})
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(327, 44)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'CursorColorToolStripMenuItem
        '
        Me.CursorColorToolStripMenuItem.Name = "CursorColorToolStripMenuItem"
        Me.CursorColorToolStripMenuItem.Size = New System.Drawing.Size(344, 44)
        Me.CursorColorToolStripMenuItem.Text = "Cursor Color"
        '
        'DrawingPadColorToolStripMenuItem
        '
        Me.DrawingPadColorToolStripMenuItem.Name = "DrawingPadColorToolStripMenuItem"
        Me.DrawingPadColorToolStripMenuItem.Size = New System.Drawing.Size(344, 44)
        Me.DrawingPadColorToolStripMenuItem.Text = "Drawing Pad Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(344, 44)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(327, 44)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(327, 44)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(408, 30)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(167, 75)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(15, 30)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(104, 75)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(125, 30)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(104, 75)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(235, 30)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(167, 75)
        Me.DrawWaveformsButton.TabIndex = 4
        Me.DrawWaveformsButton.Text = "Draw Waveforms"
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlsGroupBox.AutoSize = True
        Me.ControlsGroupBox.BackColor = System.Drawing.Color.DarkGray
        Me.ControlsGroupBox.Controls.Add(Me.SelectColorButton)
        Me.ControlsGroupBox.Controls.Add(Me.DrawWaveformsButton)
        Me.ControlsGroupBox.Controls.Add(Me.ClearButton)
        Me.ControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(228, 449)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(599, 135)
        Me.ControlsGroupBox.TabIndex = 5
        Me.ControlsGroupBox.TabStop = False
        Me.ControlsGroupBox.Text = "Controls"
        '
        'EtchOSketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 629)
        Me.ContextMenuStrip = Me.EtchyContextMenuStrip
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Name = "EtchOSketchForm"
        Me.Text = "Etch O Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EtchyContextMenuStrip.ResumeLayout(False)
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents EtchyContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursorColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPadColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ControlsGroupBox As GroupBox
End Class
