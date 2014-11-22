<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransferTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransferTime))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPerSecond = New System.Windows.Forms.Label()
        Me.mskTxtBandwidth = New System.Windows.Forms.MaskedTextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.cmbBandwidthUnits = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Panel1.Controls.Add(Me.lblPerSecond)
        Me.Panel1.Controls.Add(Me.mskTxtBandwidth)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.cmbBandwidthUnits)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 84)
        Me.Panel1.TabIndex = 127
        '
        'lblPerSecond
        '
        Me.lblPerSecond.AutoSize = True
        Me.lblPerSecond.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerSecond.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPerSecond.Location = New System.Drawing.Point(343, 9)
        Me.lblPerSecond.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPerSecond.Name = "lblPerSecond"
        Me.lblPerSecond.Size = New System.Drawing.Size(78, 16)
        Me.lblPerSecond.TabIndex = 136
        Me.lblPerSecond.Text = "per second"
        '
        'mskTxtBandwidth
        '
        Me.mskTxtBandwidth.AllowPromptAsInput = False
        Me.mskTxtBandwidth.AsciiOnly = True
        Me.mskTxtBandwidth.BeepOnError = True
        Me.mskTxtBandwidth.HidePromptOnLeave = True
        Me.mskTxtBandwidth.Location = New System.Drawing.Point(218, 8)
        Me.mskTxtBandwidth.Mask = "00000"
        Me.mskTxtBandwidth.Name = "mskTxtBandwidth"
        Me.mskTxtBandwidth.Size = New System.Drawing.Size(55, 20)
        Me.mskTxtBandwidth.TabIndex = 135
        Me.mskTxtBandwidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskTxtBandwidth.ValidatingType = GetType(Integer)
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(7, 35)
        Me.txtTime.Multiline = True
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(463, 41)
        Me.txtTime.TabIndex = 134
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbBandwidthUnits
        '
        Me.cmbBandwidthUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBandwidthUnits.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBandwidthUnits.FormattingEnabled = True
        Me.cmbBandwidthUnits.Location = New System.Drawing.Point(279, 6)
        Me.cmbBandwidthUnits.Name = "cmbBandwidthUnits"
        Me.cmbBandwidthUnits.Size = New System.Drawing.Size(64, 23)
        Me.cmbBandwidthUnits.TabIndex = 132
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(47, 9)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(175, 16)
        Me.lblTime.TabIndex = 131
        Me.lblTime.Text = "Estimated transfer time @ "
        '
        'FormTransferTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(478, 84)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransferTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Time"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents cmbBandwidthUnits As System.Windows.Forms.ComboBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents mskTxtBandwidth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblPerSecond As System.Windows.Forms.Label
End Class
