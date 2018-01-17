<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.OKButton = New System.Windows.Forms.Button()
        Me.btnUpdates = New System.Windows.Forms.Button()
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.btnLicense = New System.Windows.Forms.Button()
        Me.btnReadme = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(280, 166)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(122, 32)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "&Close"
        '
        'btnUpdates
        '
        Me.btnUpdates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdates.Location = New System.Drawing.Point(280, 52)
        Me.btnUpdates.Name = "btnUpdates"
        Me.btnUpdates.Size = New System.Drawing.Size(122, 32)
        Me.btnUpdates.TabIndex = 2
        Me.btnUpdates.Text = "Check for &Updates"
        '
        'btnWebsite
        '
        Me.btnWebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWebsite.Location = New System.Drawing.Point(280, 14)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(122, 32)
        Me.btnWebsite.TabIndex = 3
        Me.btnWebsite.Text = "Visit &Website"
        '
        'btnLicense
        '
        Me.btnLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLicense.Location = New System.Drawing.Point(280, 128)
        Me.btnLicense.Name = "btnLicense"
        Me.btnLicense.Size = New System.Drawing.Size(122, 32)
        Me.btnLicense.TabIndex = 4
        Me.btnLicense.Text = "Read &License"
        '
        'btnReadme
        '
        Me.btnReadme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReadme.Location = New System.Drawing.Point(280, 90)
        Me.btnReadme.Name = "btnReadme"
        Me.btnReadme.Size = New System.Drawing.Size(122, 32)
        Me.btnReadme.TabIndex = 5
        Me.btnReadme.Tag = ""
        Me.btnReadme.Text = "Open &Readme"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(82, 13)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Application Title"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(12, 33)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(72, 13)
        Me.lblVersion.TabIndex = 7
        Me.lblVersion.Text = "Version X.X.X"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(12, 62)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(262, 51)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Application Description"
        '
        'lblCopyright
        '
        Me.lblCopyright.Location = New System.Drawing.Point(12, 113)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(262, 85)
        Me.lblCopyright.TabIndex = 9
        Me.lblCopyright.Text = "Application Copyright"
        '
        'frmAbout
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(414, 210)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReadme)
        Me.Controls.Add(Me.btnLicense)
        Me.Controls.Add(Me.btnWebsite)
        Me.Controls.Add(Me.btnUpdates)
        Me.Controls.Add(Me.OKButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAbout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents btnUpdates As System.Windows.Forms.Button
    Friend WithEvents btnWebsite As System.Windows.Forms.Button
    Friend WithEvents btnLicense As System.Windows.Forms.Button
    Friend WithEvents btnReadme As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label

End Class
