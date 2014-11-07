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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInputValue = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbInputUnit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbConvType = New System.Windows.Forms.ComboBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtResult10 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtResult9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResult8 = New System.Windows.Forms.TextBox()
        Me.txtResult7 = New System.Windows.Forms.TextBox()
        Me.txtResult6 = New System.Windows.Forms.TextBox()
        Me.txtResult5 = New System.Windows.Forms.TextBox()
        Me.txtResult4 = New System.Windows.Forms.TextBox()
        Me.txtResult3 = New System.Windows.Forms.TextBox()
        Me.txtResult2 = New System.Windows.Forms.TextBox()
        Me.txtResult1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnFolder = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Input value to convert"
        '
        'txtInputValue
        '
        Me.txtInputValue.AllowDrop = True
        Me.txtInputValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInputValue.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputValue.Location = New System.Drawing.Point(12, 78)
        Me.txtInputValue.Name = "txtInputValue"
        Me.txtInputValue.Size = New System.Drawing.Size(214, 22)
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
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
        Me.cmbInputUnit.Location = New System.Drawing.Point(232, 78)
        Me.cmbInputUnit.Name = "cmbInputUnit"
        Me.cmbInputUnit.Size = New System.Drawing.Size(115, 23)
        Me.cmbInputUnit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(229, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Input Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Conversion Type"
        '
        'cmbConvType
        '
        Me.cmbConvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConvType.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvType.FormattingEnabled = True
        Me.cmbConvType.Items.AddRange(New Object() {"1000 - Decimal", "1024 - Binary"})
        Me.cmbConvType.Location = New System.Drawing.Point(9, 26)
        Me.cmbConvType.Name = "cmbConvType"
        Me.cmbConvType.Size = New System.Drawing.Size(113, 23)
        Me.cmbConvType.TabIndex = 1
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblError.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(7, 392)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(340, 40)
        Me.lblError.TabIndex = 114
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtResult10)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtResult9)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtResult8)
        Me.Panel1.Controls.Add(Me.txtResult7)
        Me.Panel1.Controls.Add(Me.txtResult6)
        Me.Panel1.Controls.Add(Me.txtResult5)
        Me.Panel1.Controls.Add(Me.txtResult4)
        Me.Panel1.Controls.Add(Me.txtResult3)
        Me.Panel1.Controls.Add(Me.txtResult2)
        Me.Panel1.Controls.Add(Me.txtResult1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(7, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 282)
        Me.Panel1.TabIndex = 115
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(222, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 16)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Yotta Bytes (YB)"
        '
        'txtResult10
        '
        Me.txtResult10.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult10.Location = New System.Drawing.Point(5, 259)
        Me.txtResult10.Name = "txtResult10"
        Me.txtResult10.ReadOnly = True
        Me.txtResult10.Size = New System.Drawing.Size(211, 22)
        Me.txtResult10.TabIndex = 123
        Me.txtResult10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(222, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 16)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Zetta Bytes (ZB)"
        '
        'txtResult9
        '
        Me.txtResult9.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult9.Location = New System.Drawing.Point(5, 233)
        Me.txtResult9.Name = "txtResult9"
        Me.txtResult9.ReadOnly = True
        Me.txtResult9.Size = New System.Drawing.Size(211, 22)
        Me.txtResult9.TabIndex = 122
        Me.txtResult9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(222, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Exa Bytes (EB)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(222, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Peta Bytes (PB)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(222, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Tera Bytes (TB)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(222, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Giga Bytes (GB)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 16)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Mega Bytes (MB)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Kilo Bytes (KB)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(222, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Byte(s)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(222, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Bit(s)"
        '
        'txtResult8
        '
        Me.txtResult8.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult8.Location = New System.Drawing.Point(5, 207)
        Me.txtResult8.Name = "txtResult8"
        Me.txtResult8.ReadOnly = True
        Me.txtResult8.Size = New System.Drawing.Size(211, 22)
        Me.txtResult8.TabIndex = 121
        Me.txtResult8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult7
        '
        Me.txtResult7.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult7.Location = New System.Drawing.Point(5, 181)
        Me.txtResult7.Name = "txtResult7"
        Me.txtResult7.ReadOnly = True
        Me.txtResult7.Size = New System.Drawing.Size(211, 22)
        Me.txtResult7.TabIndex = 120
        Me.txtResult7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult6
        '
        Me.txtResult6.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult6.Location = New System.Drawing.Point(5, 155)
        Me.txtResult6.Name = "txtResult6"
        Me.txtResult6.ReadOnly = True
        Me.txtResult6.Size = New System.Drawing.Size(211, 22)
        Me.txtResult6.TabIndex = 119
        Me.txtResult6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult5
        '
        Me.txtResult5.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult5.Location = New System.Drawing.Point(5, 129)
        Me.txtResult5.Name = "txtResult5"
        Me.txtResult5.ReadOnly = True
        Me.txtResult5.Size = New System.Drawing.Size(211, 22)
        Me.txtResult5.TabIndex = 118
        Me.txtResult5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult4
        '
        Me.txtResult4.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult4.Location = New System.Drawing.Point(5, 103)
        Me.txtResult4.Name = "txtResult4"
        Me.txtResult4.ReadOnly = True
        Me.txtResult4.Size = New System.Drawing.Size(211, 22)
        Me.txtResult4.TabIndex = 117
        Me.txtResult4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult3
        '
        Me.txtResult3.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult3.Location = New System.Drawing.Point(5, 77)
        Me.txtResult3.Name = "txtResult3"
        Me.txtResult3.ReadOnly = True
        Me.txtResult3.Size = New System.Drawing.Size(211, 22)
        Me.txtResult3.TabIndex = 116
        Me.txtResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult2
        '
        Me.txtResult2.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult2.Location = New System.Drawing.Point(5, 51)
        Me.txtResult2.Name = "txtResult2"
        Me.txtResult2.ReadOnly = True
        Me.txtResult2.Size = New System.Drawing.Size(211, 22)
        Me.txtResult2.TabIndex = 115
        Me.txtResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult1
        '
        Me.txtResult1.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult1.Location = New System.Drawing.Point(5, 25)
        Me.txtResult1.Name = "txtResult1"
        Me.txtResult1.ReadOnly = True
        Me.txtResult1.Size = New System.Drawing.Size(211, 22)
        Me.txtResult1.TabIndex = 114
        Me.txtResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(66, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 19)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Results"
        '
        'btnCalculator
        '
        Me.btnCalculator.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculator.ForeColor = System.Drawing.Color.Black
        Me.btnCalculator.Location = New System.Drawing.Point(260, 24)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(87, 26)
        Me.btnCalculator.TabIndex = 116
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'btnFile
        '
        Me.btnFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.ForeColor = System.Drawing.Color.Black
        Me.btnFile.Location = New System.Drawing.Point(137, 24)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(52, 26)
        Me.btnFile.TabIndex = 117
        Me.btnFile.Text = "File"
        Me.btnFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Choose files whose size is to be converted"
        '
        'btnFolder
        '
        Me.btnFolder.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFolder.ForeColor = System.Drawing.Color.Black
        Me.btnFolder.Location = New System.Drawing.Point(193, 24)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Size = New System.Drawing.Size(52, 26)
        Me.btnFolder.TabIndex = 118
        Me.btnFolder.Text = "Folder"
        Me.btnFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFolder.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(166, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 119
        Me.Label15.Text = "Browse"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(275, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 16)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Open"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Choose a folder whose size is to be converted"
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(354, 437)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnFolder)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.cmbConvType)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInputValue)
        Me.Controls.Add(Me.cmbInputUnit)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(370, 476)
        Me.MinimumSize = New System.Drawing.Size(370, 430)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Byte Converter"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInputValue As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmbInputUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbConvType As System.Windows.Forms.ComboBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtResult10 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtResult9 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResult8 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult7 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult6 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult5 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult4 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculator As System.Windows.Forms.Button
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFolder As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
