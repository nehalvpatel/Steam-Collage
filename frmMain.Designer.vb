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
        Me.lblSteamID = New System.Windows.Forms.Label()
        Me.txtSteamID = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.lstSizes = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.sfdCollage = New System.Windows.Forms.SaveFileDialog()
        Me.sspCredits = New System.Windows.Forms.StatusStrip()
        Me.lblCredits = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSpringLeft = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSpringRight = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sspCredits.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSteamID
        '
        Me.lblSteamID.AutoSize = True
        Me.lblSteamID.Location = New System.Drawing.Point(12, 9)
        Me.lblSteamID.Name = "lblSteamID"
        Me.lblSteamID.Size = New System.Drawing.Size(55, 13)
        Me.lblSteamID.TabIndex = 0
        Me.lblSteamID.Text = "Steam ID:"
        '
        'txtSteamID
        '
        Me.txtSteamID.Location = New System.Drawing.Point(73, 6)
        Me.txtSteamID.Name = "txtSteamID"
        Me.txtSteamID.Size = New System.Drawing.Size(144, 22)
        Me.txtSteamID.TabIndex = 1
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(37, 35)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "Size:"
        '
        'btnFetch
        '
        Me.btnFetch.Enabled = False
        Me.btnFetch.Location = New System.Drawing.Point(223, 5)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(56, 23)
        Me.btnFetch.TabIndex = 3
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'lstSizes
        '
        Me.lstSizes.Enabled = False
        Me.lstSizes.FormattingEnabled = True
        Me.lstSizes.Location = New System.Drawing.Point(73, 34)
        Me.lstSizes.Name = "lstSizes"
        Me.lstSizes.Size = New System.Drawing.Size(144, 199)
        Me.lstSizes.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(223, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'sfdCollage
        '
        Me.sfdCollage.RestoreDirectory = True
        Me.sfdCollage.Title = "Save Collage"
        '
        'sspCredits
        '
        Me.sspCredits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sspCredits.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSpringLeft, Me.lblCredits, Me.lblSpringRight})
        Me.sspCredits.Location = New System.Drawing.Point(0, 239)
        Me.sspCredits.Name = "sspCredits"
        Me.sspCredits.Size = New System.Drawing.Size(284, 22)
        Me.sspCredits.SizingGrip = False
        Me.sspCredits.TabIndex = 6
        Me.sspCredits.Text = "StatusStrip1"
        '
        'lblCredits
        '
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(112, 17)
        Me.lblCredits.Text = "Made by Nehal Patel"
        '
        'lblSpringLeft
        '
        Me.lblSpringLeft.Name = "lblSpringLeft"
        Me.lblSpringLeft.Size = New System.Drawing.Size(63, 17)
        Me.lblSpringLeft.Spring = True
        '
        'lblSpringRight
        '
        Me.lblSpringRight.Name = "lblSpringRight"
        Me.lblSpringRight.Size = New System.Drawing.Size(63, 17)
        Me.lblSpringRight.Spring = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.sspCredits)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.txtSteamID)
        Me.Controls.Add(Me.lblSteamID)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Steam Collage"
        Me.sspCredits.ResumeLayout(False)
        Me.sspCredits.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSteamID As System.Windows.Forms.Label
    Friend WithEvents txtSteamID As System.Windows.Forms.TextBox
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents btnFetch As System.Windows.Forms.Button
    Friend WithEvents lstSizes As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents sfdCollage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents sspCredits As System.Windows.Forms.StatusStrip
    Friend WithEvents lblCredits As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSpringLeft As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSpringRight As System.Windows.Forms.ToolStripStatusLabel

End Class
