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
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EtchyContextMenuStrip.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.DrawingPictureBox.Location = New System.Drawing.Point(64, 66)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(768, 381)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'EtchyContextMenuStrip
        '
        Me.EtchyContextMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.EtchyContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem1})
        Me.EtchyContextMenuStrip.Name = "EtchyContextMenuStrip"
        Me.EtchyContextMenuStrip.Size = New System.Drawing.Size(301, 124)
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
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem1, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(300, 38)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'SelectColorToolStripMenuItem1
        '
        Me.SelectColorToolStripMenuItem1.Name = "SelectColorToolStripMenuItem1"
        Me.SelectColorToolStripMenuItem1.Size = New System.Drawing.Size(327, 44)
        Me.SelectColorToolStripMenuItem1.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
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
        Me.ControlsGroupBox.Location = New System.Drawing.Point(271, 482)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(599, 135)
        Me.ControlsGroupBox.TabIndex = 5
        Me.ControlsGroupBox.TabStop = False
        Me.ControlsGroupBox.Text = "Controls"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 40)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(71, 38)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem1, Me.ClearToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(74, 38)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        '
        'DrawWaveformsToolStripMenuItem1
        '
        Me.DrawWaveformsToolStripMenuItem1.Name = "DrawWaveformsToolStripMenuItem1"
        Me.DrawWaveformsToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.DrawWaveformsToolStripMenuItem1.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(84, 38)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EtchOSketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 629)
        Me.ContextMenuStrip = Me.EtchyContextMenuStrip
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EtchOSketchForm"
        Me.Text = "Etch O Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EtchyContextMenuStrip.ResumeLayout(False)
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents EtchyContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
