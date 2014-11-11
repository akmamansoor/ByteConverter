<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblInputValue = New System.Windows.Forms.Label()
        Me.txtInputValue = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbInputUnit = New System.Windows.Forms.ComboBox()
        Me.lblInputUnit = New System.Windows.Forms.Label()
        Me.lblConvType = New System.Windows.Forms.Label()
        Me.cmbConvType = New System.Windows.Forms.ComboBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.panelResults = New System.Windows.Forms.Panel()
        Me.pBoxYB = New System.Windows.Forms.PictureBox()
        Me.pBoxZB = New System.Windows.Forms.PictureBox()
        Me.pBoxEB = New System.Windows.Forms.PictureBox()
        Me.pBoxPB = New System.Windows.Forms.PictureBox()
        Me.pBoxTB = New System.Windows.Forms.PictureBox()
        Me.pBoxGB = New System.Windows.Forms.PictureBox()
        Me.pBoxMB = New System.Windows.Forms.PictureBox()
        Me.pBoxKB = New System.Windows.Forms.PictureBox()
        Me.pBoxBytes = New System.Windows.Forms.PictureBox()
        Me.pBoxBits = New System.Windows.Forms.PictureBox()
        Me.lblYB = New System.Windows.Forms.Label()
        Me.txtYB = New System.Windows.Forms.TextBox()
        Me.lblZB = New System.Windows.Forms.Label()
        Me.txtZB = New System.Windows.Forms.TextBox()
        Me.lblEB = New System.Windows.Forms.Label()
        Me.lblPB = New System.Windows.Forms.Label()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.lblGB = New System.Windows.Forms.Label()
        Me.lblMB = New System.Windows.Forms.Label()
        Me.lblKB = New System.Windows.Forms.Label()
        Me.lblBytes = New System.Windows.Forms.Label()
        Me.lblBits = New System.Windows.Forms.Label()
        Me.txtEB = New System.Windows.Forms.TextBox()
        Me.txtPB = New System.Windows.Forms.TextBox()
        Me.txtTB = New System.Windows.Forms.TextBox()
        Me.txtGB = New System.Windows.Forms.TextBox()
        Me.txtMB = New System.Windows.Forms.TextBox()
        Me.txtKB = New System.Windows.Forms.TextBox()
        Me.txtBytes = New System.Windows.Forms.TextBox()
        Me.txtBits = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFolder = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.panelResults.SuspendLayout()
        CType(Me.pBoxYB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxZB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxEB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxGB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxMB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxKB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxBytes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxBits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInputValue
        '
        Me.lblInputValue.AutoSize = True
        Me.lblInputValue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInputValue.Location = New System.Drawing.Point(9, 63)
        Me.lblInputValue.Name = "lblInputValue"
        Me.lblInputValue.Size = New System.Drawing.Size(146, 16)
        Me.lblInputValue.TabIndex = 100
        Me.lblInputValue.Text = "Input value to convert"
        '
        'txtInputValue
        '
        Me.txtInputValue.AllowDrop = True
        Me.txtInputValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInputValue.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputValue.Location = New System.Drawing.Point(9, 79)
        Me.txtInputValue.Name = "txtInputValue"
        Me.txtInputValue.Size = New System.Drawing.Size(224, 22)
        Me.txtInputValue.TabIndex = 2
        Me.txtInputValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 48)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'cmbInputUnit
        '
        Me.cmbInputUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInputUnit.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInputUnit.FormattingEnabled = True
        Me.cmbInputUnit.Items.AddRange(New Object() {"Bit", "Byte", "Kilo Byte", "Mega Byte", "Giga Byte", "Tera Byte", "Peta byte", "Exa byte"})
        Me.cmbInputUnit.Location = New System.Drawing.Point(238, 79)
        Me.cmbInputUnit.Name = "cmbInputUnit"
        Me.cmbInputUnit.Size = New System.Drawing.Size(107, 23)
        Me.cmbInputUnit.TabIndex = 3
        '
        'lblInputUnit
        '
        Me.lblInputUnit.AutoSize = True
        Me.lblInputUnit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInputUnit.Location = New System.Drawing.Point(235, 63)
        Me.lblInputUnit.Name = "lblInputUnit"
        Me.lblInputUnit.Size = New System.Drawing.Size(69, 16)
        Me.lblInputUnit.TabIndex = 101
        Me.lblInputUnit.Text = "Input Unit"
        '
        'lblConvType
        '
        Me.lblConvType.AutoSize = True
        Me.lblConvType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblConvType.Location = New System.Drawing.Point(6, 11)
        Me.lblConvType.Name = "lblConvType"
        Me.lblConvType.Size = New System.Drawing.Size(113, 16)
        Me.lblConvType.TabIndex = 102
        Me.lblConvType.Text = "Conversion Type"
        '
        'cmbConvType
        '
        Me.cmbConvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConvType.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvType.FormattingEnabled = True
        Me.cmbConvType.Items.AddRange(New Object() {"1000 - Decimal", "1024 - Binary"})
        Me.cmbConvType.Location = New System.Drawing.Point(9, 27)
        Me.cmbConvType.Name = "cmbConvType"
        Me.cmbConvType.Size = New System.Drawing.Size(110, 23)
        Me.cmbConvType.TabIndex = 1
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblError.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(9, 392)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(341, 40)
        Me.lblError.TabIndex = 114
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelResults
        '
        Me.panelResults.Controls.Add(Me.pBoxYB)
        Me.panelResults.Controls.Add(Me.pBoxZB)
        Me.panelResults.Controls.Add(Me.pBoxEB)
        Me.panelResults.Controls.Add(Me.pBoxPB)
        Me.panelResults.Controls.Add(Me.pBoxTB)
        Me.panelResults.Controls.Add(Me.pBoxGB)
        Me.panelResults.Controls.Add(Me.pBoxMB)
        Me.panelResults.Controls.Add(Me.pBoxKB)
        Me.panelResults.Controls.Add(Me.pBoxBytes)
        Me.panelResults.Controls.Add(Me.pBoxBits)
        Me.panelResults.Controls.Add(Me.lblYB)
        Me.panelResults.Controls.Add(Me.txtYB)
        Me.panelResults.Controls.Add(Me.lblZB)
        Me.panelResults.Controls.Add(Me.txtZB)
        Me.panelResults.Controls.Add(Me.lblEB)
        Me.panelResults.Controls.Add(Me.lblPB)
        Me.panelResults.Controls.Add(Me.lblTB)
        Me.panelResults.Controls.Add(Me.lblGB)
        Me.panelResults.Controls.Add(Me.lblMB)
        Me.panelResults.Controls.Add(Me.lblKB)
        Me.panelResults.Controls.Add(Me.lblBytes)
        Me.panelResults.Controls.Add(Me.lblBits)
        Me.panelResults.Controls.Add(Me.txtEB)
        Me.panelResults.Controls.Add(Me.txtPB)
        Me.panelResults.Controls.Add(Me.txtTB)
        Me.panelResults.Controls.Add(Me.txtGB)
        Me.panelResults.Controls.Add(Me.txtMB)
        Me.panelResults.Controls.Add(Me.txtKB)
        Me.panelResults.Controls.Add(Me.txtBytes)
        Me.panelResults.Controls.Add(Me.txtBits)
        Me.panelResults.Controls.Add(Me.lblResults)
        Me.panelResults.Location = New System.Drawing.Point(4, 106)
        Me.panelResults.Name = "panelResults"
        Me.panelResults.Size = New System.Drawing.Size(346, 282)
        Me.panelResults.TabIndex = 115
        '
        'pBoxYB
        '
        Me.pBoxYB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxYB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxYB.Location = New System.Drawing.Point(207, 259)
        Me.pBoxYB.Name = "pBoxYB"
        Me.pBoxYB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxYB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxYB.TabIndex = 143
        Me.pBoxYB.TabStop = False
        '
        'pBoxZB
        '
        Me.pBoxZB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxZB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxZB.Location = New System.Drawing.Point(207, 233)
        Me.pBoxZB.Name = "pBoxZB"
        Me.pBoxZB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxZB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxZB.TabIndex = 142
        Me.pBoxZB.TabStop = False
        '
        'pBoxEB
        '
        Me.pBoxEB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxEB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxEB.Location = New System.Drawing.Point(207, 207)
        Me.pBoxEB.Name = "pBoxEB"
        Me.pBoxEB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxEB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxEB.TabIndex = 141
        Me.pBoxEB.TabStop = False
        '
        'pBoxPB
        '
        Me.pBoxPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxPB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxPB.Location = New System.Drawing.Point(207, 181)
        Me.pBoxPB.Name = "pBoxPB"
        Me.pBoxPB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxPB.TabIndex = 140
        Me.pBoxPB.TabStop = False
        '
        'pBoxTB
        '
        Me.pBoxTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxTB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxTB.Location = New System.Drawing.Point(207, 155)
        Me.pBoxTB.Name = "pBoxTB"
        Me.pBoxTB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxTB.TabIndex = 139
        Me.pBoxTB.TabStop = False
        '
        'pBoxGB
        '
        Me.pBoxGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxGB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxGB.Location = New System.Drawing.Point(207, 129)
        Me.pBoxGB.Name = "pBoxGB"
        Me.pBoxGB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxGB.TabIndex = 138
        Me.pBoxGB.TabStop = False
        '
        'pBoxMB
        '
        Me.pBoxMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxMB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxMB.Location = New System.Drawing.Point(207, 103)
        Me.pBoxMB.Name = "pBoxMB"
        Me.pBoxMB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxMB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxMB.TabIndex = 137
        Me.pBoxMB.TabStop = False
        '
        'pBoxKB
        '
        Me.pBoxKB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxKB.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxKB.Location = New System.Drawing.Point(207, 77)
        Me.pBoxKB.Name = "pBoxKB"
        Me.pBoxKB.Size = New System.Drawing.Size(22, 22)
        Me.pBoxKB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxKB.TabIndex = 136
        Me.pBoxKB.TabStop = False
        '
        'pBoxBytes
        '
        Me.pBoxBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxBytes.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxBytes.Location = New System.Drawing.Point(207, 51)
        Me.pBoxBytes.Name = "pBoxBytes"
        Me.pBoxBytes.Size = New System.Drawing.Size(22, 22)
        Me.pBoxBytes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxBytes.TabIndex = 135
        Me.pBoxBytes.TabStop = False
        '
        'pBoxBits
        '
        Me.pBoxBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBoxBits.Image = Global.Converter.My.Resources.Resources.clipboard_very_small
        Me.pBoxBits.Location = New System.Drawing.Point(207, 25)
        Me.pBoxBits.Name = "pBoxBits"
        Me.pBoxBits.Size = New System.Drawing.Size(22, 22)
        Me.pBoxBits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxBits.TabIndex = 124
        Me.pBoxBits.TabStop = False
        '
        'lblYB
        '
        Me.lblYB.AutoSize = True
        Me.lblYB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYB.Location = New System.Drawing.Point(231, 262)
        Me.lblYB.Name = "lblYB"
        Me.lblYB.Size = New System.Drawing.Size(106, 16)
        Me.lblYB.TabIndex = 134
        Me.lblYB.Text = "Yotta Bytes (YB)"
        '
        'txtYB
        '
        Me.txtYB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYB.Location = New System.Drawing.Point(5, 259)
        Me.txtYB.Name = "txtYB"
        Me.txtYB.ReadOnly = True
        Me.txtYB.Size = New System.Drawing.Size(200, 22)
        Me.txtYB.TabIndex = 123
        Me.txtYB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblZB
        '
        Me.lblZB.AutoSize = True
        Me.lblZB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZB.Location = New System.Drawing.Point(231, 236)
        Me.lblZB.Name = "lblZB"
        Me.lblZB.Size = New System.Drawing.Size(103, 16)
        Me.lblZB.TabIndex = 133
        Me.lblZB.Text = "Zetta Bytes (ZB)"
        '
        'txtZB
        '
        Me.txtZB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZB.Location = New System.Drawing.Point(5, 233)
        Me.txtZB.Name = "txtZB"
        Me.txtZB.ReadOnly = True
        Me.txtZB.Size = New System.Drawing.Size(200, 22)
        Me.txtZB.TabIndex = 122
        Me.txtZB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEB
        '
        Me.lblEB.AutoSize = True
        Me.lblEB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEB.Location = New System.Drawing.Point(231, 210)
        Me.lblEB.Name = "lblEB"
        Me.lblEB.Size = New System.Drawing.Size(99, 16)
        Me.lblEB.TabIndex = 132
        Me.lblEB.Text = "Exa Bytes (EB)"
        '
        'lblPB
        '
        Me.lblPB.AutoSize = True
        Me.lblPB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPB.Location = New System.Drawing.Point(231, 184)
        Me.lblPB.Name = "lblPB"
        Me.lblPB.Size = New System.Drawing.Size(103, 16)
        Me.lblPB.TabIndex = 131
        Me.lblPB.Text = "Peta Bytes (PB)"
        '
        'lblTB
        '
        Me.lblTB.AutoSize = True
        Me.lblTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTB.Location = New System.Drawing.Point(231, 158)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(98, 16)
        Me.lblTB.TabIndex = 130
        Me.lblTB.Text = "Tera Bytes (TB)"
        '
        'lblGB
        '
        Me.lblGB.AutoSize = True
        Me.lblGB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGB.Location = New System.Drawing.Point(231, 132)
        Me.lblGB.Name = "lblGB"
        Me.lblGB.Size = New System.Drawing.Size(104, 16)
        Me.lblGB.TabIndex = 129
        Me.lblGB.Text = "Giga Bytes (GB)"
        '
        'lblMB
        '
        Me.lblMB.AutoSize = True
        Me.lblMB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMB.Location = New System.Drawing.Point(231, 106)
        Me.lblMB.Name = "lblMB"
        Me.lblMB.Size = New System.Drawing.Size(110, 16)
        Me.lblMB.TabIndex = 128
        Me.lblMB.Text = "Mega Bytes (MB)"
        '
        'lblKB
        '
        Me.lblKB.AutoSize = True
        Me.lblKB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKB.Location = New System.Drawing.Point(231, 80)
        Me.lblKB.Name = "lblKB"
        Me.lblKB.Size = New System.Drawing.Size(98, 16)
        Me.lblKB.TabIndex = 127
        Me.lblKB.Text = "Kilo Bytes (KB)"
        '
        'lblBytes
        '
        Me.lblBytes.AutoSize = True
        Me.lblBytes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBytes.Location = New System.Drawing.Point(231, 54)
        Me.lblBytes.Name = "lblBytes"
        Me.lblBytes.Size = New System.Drawing.Size(50, 16)
        Me.lblBytes.TabIndex = 126
        Me.lblBytes.Text = "Byte(s)"
        '
        'lblBits
        '
        Me.lblBits.AutoSize = True
        Me.lblBits.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBits.Location = New System.Drawing.Point(231, 28)
        Me.lblBits.Name = "lblBits"
        Me.lblBits.Size = New System.Drawing.Size(39, 16)
        Me.lblBits.TabIndex = 125
        Me.lblBits.Text = "Bit(s)"
        '
        'txtEB
        '
        Me.txtEB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEB.Location = New System.Drawing.Point(5, 207)
        Me.txtEB.Name = "txtEB"
        Me.txtEB.ReadOnly = True
        Me.txtEB.Size = New System.Drawing.Size(200, 22)
        Me.txtEB.TabIndex = 121
        Me.txtEB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPB
        '
        Me.txtPB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPB.Location = New System.Drawing.Point(5, 181)
        Me.txtPB.Name = "txtPB"
        Me.txtPB.ReadOnly = True
        Me.txtPB.Size = New System.Drawing.Size(200, 22)
        Me.txtPB.TabIndex = 120
        Me.txtPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTB
        '
        Me.txtTB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTB.Location = New System.Drawing.Point(5, 155)
        Me.txtTB.Name = "txtTB"
        Me.txtTB.ReadOnly = True
        Me.txtTB.Size = New System.Drawing.Size(200, 22)
        Me.txtTB.TabIndex = 119
        Me.txtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGB
        '
        Me.txtGB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGB.Location = New System.Drawing.Point(5, 129)
        Me.txtGB.Name = "txtGB"
        Me.txtGB.ReadOnly = True
        Me.txtGB.Size = New System.Drawing.Size(200, 22)
        Me.txtGB.TabIndex = 118
        Me.txtGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMB
        '
        Me.txtMB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMB.Location = New System.Drawing.Point(5, 103)
        Me.txtMB.Name = "txtMB"
        Me.txtMB.ReadOnly = True
        Me.txtMB.Size = New System.Drawing.Size(200, 22)
        Me.txtMB.TabIndex = 117
        Me.txtMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKB
        '
        Me.txtKB.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKB.Location = New System.Drawing.Point(5, 77)
        Me.txtKB.Name = "txtKB"
        Me.txtKB.ReadOnly = True
        Me.txtKB.Size = New System.Drawing.Size(200, 22)
        Me.txtKB.TabIndex = 116
        Me.txtKB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBytes
        '
        Me.txtBytes.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBytes.Location = New System.Drawing.Point(5, 51)
        Me.txtBytes.Name = "txtBytes"
        Me.txtBytes.ReadOnly = True
        Me.txtBytes.Size = New System.Drawing.Size(200, 22)
        Me.txtBytes.TabIndex = 115
        Me.txtBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBits
        '
        Me.txtBits.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBits.Location = New System.Drawing.Point(5, 25)
        Me.txtBits.Name = "txtBits"
        Me.txtBits.ReadOnly = True
        Me.txtBits.Size = New System.Drawing.Size(200, 22)
        Me.txtBits.TabIndex = 114
        Me.txtBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.ForeColor = System.Drawing.Color.Green
        Me.lblResults.Location = New System.Drawing.Point(66, 3)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(67, 19)
        Me.lblResults.TabIndex = 124
        Me.lblResults.Text = "Results"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Choose files whose size is to be converted"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Choose a folder whose size is to be converted"
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'btnAbout
        '
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.Black
        Me.btnAbout.Image = Global.Converter.My.Resources.Resources.mail_small
        Me.btnAbout.Location = New System.Drawing.Point(313, 18)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(32, 32)
        Me.btnAbout.TabIndex = 122
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnAbout, "About Byte Converter")
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = Global.Converter.My.Resources.Resources.save_small
        Me.btnSave.Location = New System.Drawing.Point(276, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(32, 32)
        Me.btnSave.TabIndex = 121
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save Results to a File")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFolder
        '
        Me.btnFolder.FlatAppearance.BorderSize = 0
        Me.btnFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFolder.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFolder.ForeColor = System.Drawing.Color.Black
        Me.btnFolder.Image = Global.Converter.My.Resources.Resources.folder_small
        Me.btnFolder.Location = New System.Drawing.Point(239, 18)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Size = New System.Drawing.Size(32, 32)
        Me.btnFolder.TabIndex = 118
        Me.btnFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnFolder, "Convert Folder Sizes")
        Me.btnFolder.UseVisualStyleBackColor = True
        '
        'btnFile
        '
        Me.btnFile.FlatAppearance.BorderSize = 0
        Me.btnFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.ForeColor = System.Drawing.Color.Black
        Me.btnFile.Image = Global.Converter.My.Resources.Resources.file_small
        Me.btnFile.Location = New System.Drawing.Point(202, 18)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(32, 32)
        Me.btnFile.TabIndex = 117
        Me.btnFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnFile, "Convert File Sizes")
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.FlatAppearance.BorderSize = 0
        Me.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.ForeColor = System.Drawing.Color.Black
        Me.btnCalculator.Image = Global.Converter.My.Resources.Resources.calc_small
        Me.btnCalculator.Location = New System.Drawing.Point(165, 18)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(32, 32)
        Me.btnCalculator.TabIndex = 123
        Me.btnCalculator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnCalculator, "Open Calculator")
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(359, 440)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFolder)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.cmbConvType)
        Me.Controls.Add(Me.panelResults)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblConvType)
        Me.Controls.Add(Me.lblInputUnit)
        Me.Controls.Add(Me.cmbInputUnit)
        Me.Controls.Add(Me.lblInputValue)
        Me.Controls.Add(Me.txtInputValue)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 500)
        Me.MinimumSize = New System.Drawing.Size(375, 430)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Byte Converter"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.panelResults.ResumeLayout(False)
        Me.panelResults.PerformLayout()
        CType(Me.pBoxYB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxZB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxEB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxGB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxMB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxKB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxBytes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxBits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInputValue As System.Windows.Forms.Label
    Friend WithEvents txtInputValue As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmbInputUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblInputUnit As System.Windows.Forms.Label
    Friend WithEvents lblConvType As System.Windows.Forms.Label
    Friend WithEvents cmbConvType As System.Windows.Forms.ComboBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelResults As System.Windows.Forms.Panel
    Friend WithEvents lblYB As System.Windows.Forms.Label
    Friend WithEvents txtYB As System.Windows.Forms.TextBox
    Friend WithEvents lblZB As System.Windows.Forms.Label
    Friend WithEvents txtZB As System.Windows.Forms.TextBox
    Friend WithEvents lblEB As System.Windows.Forms.Label
    Friend WithEvents lblPB As System.Windows.Forms.Label
    Friend WithEvents lblTB As System.Windows.Forms.Label
    Friend WithEvents lblGB As System.Windows.Forms.Label
    Friend WithEvents lblMB As System.Windows.Forms.Label
    Friend WithEvents lblKB As System.Windows.Forms.Label
    Friend WithEvents lblBytes As System.Windows.Forms.Label
    Friend WithEvents lblBits As System.Windows.Forms.Label
    Friend WithEvents txtEB As System.Windows.Forms.TextBox
    Friend WithEvents txtPB As System.Windows.Forms.TextBox
    Friend WithEvents txtTB As System.Windows.Forms.TextBox
    Friend WithEvents txtGB As System.Windows.Forms.TextBox
    Friend WithEvents txtMB As System.Windows.Forms.TextBox
    Friend WithEvents txtKB As System.Windows.Forms.TextBox
    Friend WithEvents txtBytes As System.Windows.Forms.TextBox
    Friend WithEvents txtBits As System.Windows.Forms.TextBox
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFolder As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnCalculator As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pBoxBits As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxYB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxZB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxEB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxPB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxTB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxGB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxMB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxKB As System.Windows.Forms.PictureBox
    Friend WithEvents pBoxBytes As System.Windows.Forms.PictureBox

End Class
