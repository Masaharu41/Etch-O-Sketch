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
        Me.EtchOSketchToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.XTrackBar = New System.Windows.Forms.TrackBar()
        Me.YTrackBar = New System.Windows.Forms.TrackBar()
        Me.EtchSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ComComboBox = New System.Windows.Forms.ComboBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.AutoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ComGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EtchyContextMenuStrip.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.XTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComGroupBox.SuspendLayout()
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
        Me.DrawingPictureBox.Location = New System.Drawing.Point(32, 60)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(1246, 434)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'EtchyContextMenuStrip
        '
        Me.EtchyContextMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.EtchyContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem1})
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
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem1, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(128, 38)
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
        Me.SelectColorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SelectColorButton.Location = New System.Drawing.Point(408, 30)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(167, 75)
        Me.SelectColorButton.TabIndex = 4
        Me.SelectColorButton.Text = "&Select Color"
        Me.EtchOSketchToolTip.SetToolTip(Me.SelectColorButton, "Opens Color Selection Dialog")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(15, 30)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(104, 75)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.EtchOSketchToolTip.SetToolTip(Me.ClearButton, "Clears the contents of the drawing pad")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(125, 30)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(104, 75)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "&Exit"
        Me.EtchOSketchToolTip.SetToolTip(Me.ExitButton, "Exits the form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(235, 30)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(167, 75)
        Me.DrawWaveformsButton.TabIndex = 3
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.EtchOSketchToolTip.SetToolTip(Me.DrawWaveformsButton, "Draws a one cycle Sine, Cos, and Tan waveform ")
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
        Me.ControlsGroupBox.Location = New System.Drawing.Point(685, 520)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(593, 135)
        Me.ControlsGroupBox.TabIndex = 1
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1442, 40)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(71, 44)
        Me.FileToolStripMenuItem1.Text = "File"
        Me.FileToolStripMenuItem1.ToolTipText = "File functions"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        Me.ExitToolStripMenuItem1.ToolTipText = "Exits form"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem1, Me.ClearToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(74, 44)
        Me.EditToolStripMenuItem.Text = "Edit"
        Me.EditToolStripMenuItem.ToolTipText = "Edit the form"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        Me.ChangeColorToolStripMenuItem.ToolTipText = "Opens Color Selection Dialog"
        '
        'DrawWaveformsToolStripMenuItem1
        '
        Me.DrawWaveformsToolStripMenuItem1.Name = "DrawWaveformsToolStripMenuItem1"
        Me.DrawWaveformsToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.DrawWaveformsToolStripMenuItem1.Text = "Draw Waveforms"
        Me.DrawWaveformsToolStripMenuItem1.ToolTipText = "Draws a one cycle Sine, Cos, and Tan waveform "
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        Me.ClearToolStripMenuItem1.ToolTipText = "Clears the contents of the drawing pad"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(84, 44)
        Me.HelpToolStripMenuItem.Text = "Help"
        Me.HelpToolStripMenuItem.ToolTipText = "More information"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.ToolTipText = "About the form"
        '
        'XTrackBar
        '
        Me.XTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.XTrackBar.LargeChange = 1
        Me.XTrackBar.Location = New System.Drawing.Point(24, 500)
        Me.XTrackBar.Maximum = 1021
        Me.XTrackBar.Name = "XTrackBar"
        Me.XTrackBar.Size = New System.Drawing.Size(230, 90)
        Me.XTrackBar.TabIndex = 7
        '
        'YTrackBar
        '
        Me.YTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.YTrackBar.LargeChange = 1
        Me.YTrackBar.Location = New System.Drawing.Point(24, 565)
        Me.YTrackBar.Maximum = 1021
        Me.YTrackBar.Name = "YTrackBar"
        Me.YTrackBar.Size = New System.Drawing.Size(230, 90)
        Me.YTrackBar.TabIndex = 8
        '
        'EtchSerialPort
        '
        '
        'ComComboBox
        '
        Me.ComComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComComboBox.FormattingEnabled = True
        Me.ComComboBox.Items.AddRange(New Object() {"COM0", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.ComComboBox.Location = New System.Drawing.Point(193, 28)
        Me.ComComboBox.Name = "ComComboBox"
        Me.ComComboBox.Size = New System.Drawing.Size(177, 33)
        Me.ComComboBox.TabIndex = 9
        Me.EtchOSketchToolTip.SetToolTip(Me.ComComboBox, "Displays Com Port if active" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or allows manual selection " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for which port to use")
        '
        'ConnectButton
        '
        Me.ConnectButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ConnectButton.Location = New System.Drawing.Point(17, 65)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(117, 52)
        Me.ConnectButton.TabIndex = 10
        Me.ConnectButton.Text = "C&onnect"
        Me.EtchOSketchToolTip.SetToolTip(Me.ConnectButton, "Connect to Serial Device")
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.BackColor = System.Drawing.Color.White
        Me.PortLabel.Location = New System.Drawing.Point(188, 77)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(112, 25)
        Me.PortLabel.TabIndex = 11
        Me.PortLabel.Text = "Serial Port"
        Me.EtchOSketchToolTip.SetToolTip(Me.PortLabel, "Serial Port State")
        '
        'AutoCheckBox
        '
        Me.AutoCheckBox.AutoSize = True
        Me.AutoCheckBox.Location = New System.Drawing.Point(17, 30)
        Me.AutoCheckBox.Name = "AutoCheckBox"
        Me.AutoCheckBox.Size = New System.Drawing.Size(88, 29)
        Me.AutoCheckBox.TabIndex = 12
        Me.AutoCheckBox.Text = "Auto"
        Me.EtchOSketchToolTip.SetToolTip(Me.AutoCheckBox, "Attempt to Auto Connect to Serial Port")
        Me.AutoCheckBox.UseVisualStyleBackColor = True
        '
        'ComGroupBox
        '
        Me.ComGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComGroupBox.BackColor = System.Drawing.Color.DarkGray
        Me.ComGroupBox.Controls.Add(Me.AutoCheckBox)
        Me.ComGroupBox.Controls.Add(Me.PortLabel)
        Me.ComGroupBox.Controls.Add(Me.ConnectButton)
        Me.ComGroupBox.Controls.Add(Me.ComComboBox)
        Me.ComGroupBox.Location = New System.Drawing.Point(272, 520)
        Me.ComGroupBox.Name = "ComGroupBox"
        Me.ComGroupBox.Size = New System.Drawing.Size(386, 135)
        Me.ComGroupBox.TabIndex = 13
        Me.ComGroupBox.TabStop = False
        Me.ComGroupBox.Text = "Serial Port"
        '
        'EtchOSketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1442, 667)
        Me.ContextMenuStrip = Me.EtchyContextMenuStrip
        Me.Controls.Add(Me.ComGroupBox)
        Me.Controls.Add(Me.YTrackBar)
        Me.Controls.Add(Me.XTrackBar)
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
        CType(Me.XTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComGroupBox.ResumeLayout(False)
        Me.ComGroupBox.PerformLayout()
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
    Friend WithEvents EtchOSketchToolTip As ToolTip
    Friend WithEvents XTrackBar As TrackBar
    Friend WithEvents YTrackBar As TrackBar
    Friend WithEvents EtchSerialPort As IO.Ports.SerialPort
    Friend WithEvents ComComboBox As ComboBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents PortLabel As Label
    Friend WithEvents AutoCheckBox As CheckBox
    Friend WithEvents ComGroupBox As GroupBox
End Class
