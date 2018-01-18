<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdSetInputFolder = New System.Windows.Forms.Button()
        Me.cmdSetOutputFolder = New System.Windows.Forms.Button()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblInputFolder = New System.Windows.Forms.Label()
        Me.lblOutputFolder = New System.Windows.Forms.Label()
        Me.cmbOutputFormat = New System.Windows.Forms.ComboBox()
        Me.lblOutputFormat = New System.Windows.Forms.Label()
        Me.lblOutputQuality = New System.Windows.Forms.Label()
        Me.cmbQuality = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.numWidth = New System.Windows.Forms.NumericUpDown()
        Me.chkUseInputFormat = New System.Windows.Forms.CheckBox()
        Me.chkSizeFilename = New System.Windows.Forms.CheckBox()
        Me.numHeight = New System.Windows.Forms.NumericUpDown()
        Me.chkAspectRatio = New System.Windows.Forms.CheckBox()
        Me.txtOutputFolder = New System.Windows.Forms.TextBox()
        Me.txtInputFolder = New System.Windows.Forms.TextBox()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSetInputFolder
        '
        Me.cmdSetInputFolder.Location = New System.Drawing.Point(337, 13)
        Me.cmdSetInputFolder.Name = "cmdSetInputFolder"
        Me.cmdSetInputFolder.Size = New System.Drawing.Size(45, 23)
        Me.cmdSetInputFolder.TabIndex = 2
        Me.cmdSetInputFolder.Text = "Set"
        Me.cmdSetInputFolder.UseVisualStyleBackColor = True
        '
        'cmdSetOutputFolder
        '
        Me.cmdSetOutputFolder.Location = New System.Drawing.Point(337, 39)
        Me.cmdSetOutputFolder.Name = "cmdSetOutputFolder"
        Me.cmdSetOutputFolder.Size = New System.Drawing.Size(45, 23)
        Me.cmdSetOutputFolder.TabIndex = 4
        Me.cmdSetOutputFolder.Text = "Set"
        Me.cmdSetOutputFolder.UseVisualStyleBackColor = True
        '
        'prgProgress
        '
        Me.prgProgress.Location = New System.Drawing.Point(12, 202)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(370, 23)
        Me.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgProgress.TabIndex = 0
        '
        'lblInformation
        '
        Me.lblInformation.Location = New System.Drawing.Point(12, 228)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(370, 101)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "Information"
        Me.lblInformation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdStart
        '
        Me.cmdStart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdStart.Location = New System.Drawing.Point(12, 173)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(151, 23)
        Me.cmdStart.TabIndex = 12
        Me.cmdStart.Text = "&Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdAbout
        '
        Me.cmdAbout.Location = New System.Drawing.Point(326, 173)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(56, 23)
        Me.cmdAbout.TabIndex = 14
        Me.cmdAbout.Text = "&About"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(20, 95)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(66, 13)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "New Height:"
        '
        'lblInputFolder
        '
        Me.lblInputFolder.AutoSize = True
        Me.lblInputFolder.Location = New System.Drawing.Point(20, 18)
        Me.lblInputFolder.Name = "lblInputFolder"
        Me.lblInputFolder.Size = New System.Drawing.Size(66, 13)
        Me.lblInputFolder.TabIndex = 0
        Me.lblInputFolder.Text = "Input Folder:"
        '
        'lblOutputFolder
        '
        Me.lblOutputFolder.AutoSize = True
        Me.lblOutputFolder.Location = New System.Drawing.Point(12, 44)
        Me.lblOutputFolder.Name = "lblOutputFolder"
        Me.lblOutputFolder.Size = New System.Drawing.Size(74, 13)
        Me.lblOutputFolder.TabIndex = 0
        Me.lblOutputFolder.Text = "Output Folder:"
        '
        'cmbOutputFormat
        '
        Me.cmbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOutputFormat.FormattingEnabled = True
        Me.cmbOutputFormat.Items.AddRange(New Object() {"PNG", "JPEG", "TIFF", "BMP", "GIF"})
        Me.cmbOutputFormat.Location = New System.Drawing.Point(92, 119)
        Me.cmbOutputFormat.Name = "cmbOutputFormat"
        Me.cmbOutputFormat.Size = New System.Drawing.Size(71, 21)
        Me.cmbOutputFormat.TabIndex = 7
        '
        'lblOutputFormat
        '
        Me.lblOutputFormat.AutoSize = True
        Me.lblOutputFormat.Location = New System.Drawing.Point(9, 123)
        Me.lblOutputFormat.Name = "lblOutputFormat"
        Me.lblOutputFormat.Size = New System.Drawing.Size(77, 13)
        Me.lblOutputFormat.TabIndex = 0
        Me.lblOutputFormat.Text = "Output Format:"
        '
        'lblOutputQuality
        '
        Me.lblOutputQuality.AutoSize = True
        Me.lblOutputQuality.Location = New System.Drawing.Point(9, 149)
        Me.lblOutputQuality.Name = "lblOutputQuality"
        Me.lblOutputQuality.Size = New System.Drawing.Size(77, 13)
        Me.lblOutputQuality.TabIndex = 0
        Me.lblOutputQuality.Text = "Output Quality:"
        '
        'cmbQuality
        '
        Me.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuality.FormattingEnabled = True
        Me.cmbQuality.Items.AddRange(New Object() {"Low", "Medium", "High", "Ultra"})
        Me.cmbQuality.Location = New System.Drawing.Point(92, 146)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Size = New System.Drawing.Size(71, 21)
        Me.cmbQuality.TabIndex = 8
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.Location = New System.Drawing.Point(169, 173)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(151, 23)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(23, 69)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(63, 13)
        Me.lblWidth.TabIndex = 15
        Me.lblWidth.Text = "New Width:"
        '
        'numWidth
        '
        Me.numWidth.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.ImageResizer.My.MySettings.Default, "DefaultWidth", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numWidth.Location = New System.Drawing.Point(92, 67)
        Me.numWidth.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.numWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(71, 20)
        Me.numWidth.TabIndex = 16
        Me.numWidth.Value = Global.ImageResizer.My.MySettings.Default.DefaultWidth
        '
        'chkUseInputFormat
        '
        Me.chkUseInputFormat.Checked = Global.ImageResizer.My.MySettings.Default.DefaultForceOutputFormat
        Me.chkUseInputFormat.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.ImageResizer.My.MySettings.Default, "DefaultForceOutputFormat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkUseInputFormat.Location = New System.Drawing.Point(211, 118)
        Me.chkUseInputFormat.Name = "chkUseInputFormat"
        Me.chkUseInputFormat.Size = New System.Drawing.Size(148, 24)
        Me.chkUseInputFormat.TabIndex = 11
        Me.chkUseInputFormat.Text = "Preserve Input Format"
        Me.chkUseInputFormat.UseVisualStyleBackColor = True
        '
        'chkSizeFilename
        '
        Me.chkSizeFilename.Checked = Global.ImageResizer.My.MySettings.Default.DefaultAppendSize
        Me.chkSizeFilename.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSizeFilename.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.ImageResizer.My.MySettings.Default, "DefaultAppendSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkSizeFilename.Location = New System.Drawing.Point(211, 90)
        Me.chkSizeFilename.Name = "chkSizeFilename"
        Me.chkSizeFilename.Size = New System.Drawing.Size(148, 24)
        Me.chkSizeFilename.TabIndex = 10
        Me.chkSizeFilename.Text = "Append Size to Filename"
        Me.chkSizeFilename.UseVisualStyleBackColor = True
        '
        'numHeight
        '
        Me.numHeight.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.ImageResizer.My.MySettings.Default, "DefaultHeight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numHeight.Location = New System.Drawing.Point(92, 93)
        Me.numHeight.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.numHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(71, 20)
        Me.numHeight.TabIndex = 5
        Me.numHeight.Value = Global.ImageResizer.My.MySettings.Default.DefaultHeight
        '
        'chkAspectRatio
        '
        Me.chkAspectRatio.Checked = Global.ImageResizer.My.MySettings.Default.DefaultMaintainAspect
        Me.chkAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAspectRatio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.ImageResizer.My.MySettings.Default, "DefaultMaintainAspect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkAspectRatio.Location = New System.Drawing.Point(211, 64)
        Me.chkAspectRatio.Name = "chkAspectRatio"
        Me.chkAspectRatio.Size = New System.Drawing.Size(148, 24)
        Me.chkAspectRatio.TabIndex = 9
        Me.chkAspectRatio.Text = "Maintain Aspect Ratio"
        Me.chkAspectRatio.UseVisualStyleBackColor = True
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.ImageResizer.My.MySettings.Default, "DefaultDestination", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtOutputFolder.Location = New System.Drawing.Point(92, 41)
        Me.txtOutputFolder.Name = "txtOutputFolder"
        Me.txtOutputFolder.Size = New System.Drawing.Size(239, 20)
        Me.txtOutputFolder.TabIndex = 3
        Me.txtOutputFolder.Text = Global.ImageResizer.My.MySettings.Default.DefaultDestination
        '
        'txtInputFolder
        '
        Me.txtInputFolder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.ImageResizer.My.MySettings.Default, "DefaultSource", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtInputFolder.Location = New System.Drawing.Point(92, 15)
        Me.txtInputFolder.Name = "txtInputFolder"
        Me.txtInputFolder.Size = New System.Drawing.Size(239, 20)
        Me.txtInputFolder.TabIndex = 1
        Me.txtInputFolder.Text = Global.ImageResizer.My.MySettings.Default.DefaultSource
        '
        'frmMain
        '
        Me.AcceptButton = Me.cmdStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(394, 339)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.numWidth)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblOutputQuality)
        Me.Controls.Add(Me.cmbQuality)
        Me.Controls.Add(Me.lblOutputFormat)
        Me.Controls.Add(Me.chkUseInputFormat)
        Me.Controls.Add(Me.cmbOutputFormat)
        Me.Controls.Add(Me.lblOutputFolder)
        Me.Controls.Add(Me.lblInputFolder)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.chkSizeFilename)
        Me.Controls.Add(Me.numHeight)
        Me.Controls.Add(Me.chkAspectRatio)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.prgProgress)
        Me.Controls.Add(Me.cmdSetOutputFolder)
        Me.Controls.Add(Me.txtOutputFolder)
        Me.Controls.Add(Me.cmdSetInputFolder)
        Me.Controls.Add(Me.txtInputFolder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImageResizer"
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtInputFolder As System.Windows.Forms.TextBox
    Friend WithEvents cmdSetInputFolder As System.Windows.Forms.Button
    Friend WithEvents txtOutputFolder As System.Windows.Forms.TextBox
    Friend WithEvents cmdSetOutputFolder As System.Windows.Forms.Button
    Friend WithEvents prgProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents chkSizeFilename As System.Windows.Forms.CheckBox
    Friend WithEvents numHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkAspectRatio As System.Windows.Forms.CheckBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblInputFolder As System.Windows.Forms.Label
    Friend WithEvents lblOutputFolder As System.Windows.Forms.Label
    Friend WithEvents cmbOutputFormat As System.Windows.Forms.ComboBox
    Friend WithEvents chkUseInputFormat As System.Windows.Forms.CheckBox
    Friend WithEvents lblOutputFormat As System.Windows.Forms.Label
    Friend WithEvents lblOutputQuality As System.Windows.Forms.Label
    Friend WithEvents cmbQuality As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents numWidth As System.Windows.Forms.NumericUpDown

End Class
