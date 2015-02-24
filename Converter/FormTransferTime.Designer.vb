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
        Me.cmbDataUnit = New System.Windows.Forms.ComboBox()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.txtDataSize = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Controls.Add(Me.cmbDataUnit)
        Me.Panel1.Controls.Add(Me.lblSpeed)
        Me.Panel1.Controls.Add(Me.txtDataSize)
        Me.Panel1.Controls.Add(Me.lblPerSecond)
        Me.Panel1.Controls.Add(Me.mskTxtBandwidth)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.cmbBandwidthUnits)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 371)
        Me.Panel1.TabIndex = 127
        '
        'cmbDataUnit
        '
        Me.cmbDataUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDataUnit.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDataUnit.FormattingEnabled = True
        Me.cmbDataUnit.Location = New System.Drawing.Point(186, 28)
        Me.cmbDataUnit.Name = "cmbDataUnit"
        Me.cmbDataUnit.Size = New System.Drawing.Size(142, 23)
        Me.cmbDataUnit.TabIndex = 139
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpeed.Location = New System.Drawing.Point(9, 63)
        Me.lblSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(110, 16)
        Me.lblSpeed.TabIndex = 138
        Me.lblSpeed.Text = "at the speed of: "
        '
        'txtDataSize
        '
        Me.txtDataSize.Location = New System.Drawing.Point(12, 31)
        Me.txtDataSize.Name = "txtDataSize"
        Me.txtDataSize.Size = New System.Drawing.Size(167, 20)
        Me.txtDataSize.TabIndex = 1
        Me.txtDataSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPerSecond
        '
        Me.lblPerSecond.AutoSize = True
        Me.lblPerSecond.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerSecond.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPerSecond.Location = New System.Drawing.Point(182, 83)
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
        Me.mskTxtBandwidth.Location = New System.Drawing.Point(12, 82)
        Me.mskTxtBandwidth.Mask = "00000"
        Me.mskTxtBandwidth.Name = "mskTxtBandwidth"
        Me.mskTxtBandwidth.Size = New System.Drawing.Size(55, 20)
        Me.mskTxtBandwidth.TabIndex = 2
        Me.mskTxtBandwidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskTxtBandwidth.ValidatingType = GetType(Integer)
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(7, 110)
        Me.txtTime.Multiline = True
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(321, 256)
        Me.txtTime.TabIndex = 4
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbBandwidthUnits
        '
        Me.cmbBandwidthUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBandwidthUnits.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBandwidthUnits.FormattingEnabled = True
        Me.cmbBandwidthUnits.Location = New System.Drawing.Point(73, 81)
        Me.cmbBandwidthUnits.Name = "cmbBandwidthUnits"
        Me.cmbBandwidthUnits.Size = New System.Drawing.Size(106, 23)
        Me.cmbBandwidthUnits.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(9, 12)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(183, 16)
        Me.lblTime.TabIndex = 131
        Me.lblTime.Text = "Estimated transfer time for: "
        '
        'FormTransferTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(333, 371)
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
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents txtDataSize As System.Windows.Forms.TextBox
    Friend WithEvents cmbDataUnit As System.Windows.Forms.ComboBox
End Class
