
#Region "Copyright Notice"

' Copyright © 2009 A.K. Mansoor Ahamed (AKMA Solutions)

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.

' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

#End Region

#Region "About"

' Application   :- Byte Converter
' Developer     :- A.K. Mansoor Ahamed (alias) A.K.M.A
' Company       :- AKMA Solutions
' Date          :- November 2014
' Email         :- akma.mansoor@gmail.com 

' Description   :- Byte Converter is a simple utility to convert numeric units of digital information from one form to another. 
'                  The supported units are,
'                  Decimal - Bits, Bytes, KiloBytes (KB), MegaBytes (MB), GigaBytes (GB), TeraBytes (TB), PetaBytes (TB), ExaBytes (EB), ZettaBytes (ZB), YottaBytes (YB)
'                  Binary  - Bits, Bytes, KiloBytes (KiB), MegaBytes (MiB), GigaBytes (GiB), TeraBytes (TiB), PetaBytes (TiB), ExaBytes (EiB), ZettaBytes (ZiB), YottaBytes (YiB)

' Note          :- If you have any suggestions\corrections in this application, please do e-mail me at the address above.

#End Region

#Region "Source Code"

Option Explicit On
Imports System.Text.RegularExpressions
Imports System.IO

Public Class FormMain

#Region "All Declarations"

    Dim index As Integer
    Public input As Double = 0.0
    Dim convFrom, temp As Byte
    Public convType As Short
    Dim decimalArray() As String = {"Bits", "Bytes", "Kilo Bytes (KB)", "Mega Bytes (MB)", "Giga Bytes (GB)", _
      "Tera Bytes (TB)", "Peta Bytes (PB)", "Exa Bytes (EB)", "Zetta Bytes (ZB)", "Yotta Bytes (YB)"}
    Dim binaryArray() As String = {"Bits", "Bytes", "Kibi Bytes (KiB)", "Mebi Bytes (MiB)", "Gibi Bytes (GiB)", _
     "Tebi Bytes (TiB)", "Pebi Bytes (PiB)", "Exbi Bytes (EiB)", "Zebi Bytes (ZiB)", "Yobi Bytes (YiB)"}
    Dim WithEvents myProcess As New Process
    Dim InstanceArrayOfMyProcess As Process()
    Dim myProcessHandle As Long
    Public Event Exited As EventHandler
    Declare Function OpenIcon Lib "user32" (ByVal hwnd As Long) As Long
    Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As Long) As Long

#End Region

#Region "All Events"

    Private Sub frmMain_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Me.GotFocus
        If Me.Enabled = False Then
            FormAbout.Focus()
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        ResetFeilds()
        isProcessAlreadyOpen()
    End Sub

    Private Sub myProcess_ProcessExited(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles myProcess.Exited
        'MessageBox.Show("The process exited, raising the Exited event at: " & myProcess.ExitTime & "." _
        '& System.Environment.NewLine & "Exit Code: " & myProcess.ExitCode)
        myProcess.Close()
    End Sub

    Private Sub txtInputValue_cmbInputUnit_Changed(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtInputValue.TextChanged, cmbInputUnit.SelectedIndexChanged
        ConvertToBit()
    End Sub

    Private Sub cmbConvType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cmbConvType.SelectedIndexChanged
        ChangeUnitsDisplayedAsPerConversionType()
        ConvertToBit()
    End Sub

    Private Sub lblError_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles lblError.TextChanged
        ShowHideLblError()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles AboutToolStripMenuItem.Click
        showAboutForm()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Input validation during KeyPress Event, also triggers txtInputValue_Textchanged event (if available). 
    'Used to ignore keypress (via keyboard) of invalid characters. This functionality is OPTIONAL.
    Private Sub txtInputValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtInputValue.KeyPress
        ' Don't validate characters representing cut, copy, paste and backspace operations
        ' Keychars for Ctrl+A = 1 | Ctrl+C = 3 | Bkspc = 8 | Ctrl+V = 22 | Ctrl+X = 24.
        If Not e.KeyChar = Convert.ToChar(1) And _
        Not e.KeyChar = Convert.ToChar(3) And _
        Not e.KeyChar = Convert.ToChar(8) And _
        Not e.KeyChar = Convert.ToChar(22) And _
        Not e.KeyChar = Convert.ToChar(24) Then
            ' Allow user to press only the following keys --> any number (0 to 9), E, +, - and .
            If Not IsNumeric(e.KeyChar) And _
               Not e.KeyChar.ToString.ToUpper = "E" And _
               Not (e.KeyChar = "+" Or e.KeyChar = "-") And _
               Not e.KeyChar = "." Then
                e.Handled = True
                'Allow only one occurence for the following keys --> . and E
            ElseIf e.KeyChar = "." And txtInputValue.Text.Contains(".") Then
                e.Handled = True
            ElseIf e.KeyChar.ToString.ToUpper = "E" And txtInputValue.Text.Contains("E") Then
                e.Handled = True
            Else
                'Validate the modified input
                IsInputValid(txtInputValue.Text)
            End If

        End If
    End Sub

    Private Sub btnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnCalculator.Click
        Try
            If isProcessAlreadyOpen() = True Then
                myProcessHandle = myProcess.MainWindowHandle.ToInt64
                OpenIcon(myProcessHandle) 'Restores the program.
                SetForegroundWindow(myProcessHandle) 'Activates the program.
            Else
                If System.IO.File.Exists(System.Environment.SystemDirectory + "\calc.exe") = True Then
                    myProcess.StartInfo.FileName = "calc"
                    myProcess.StartInfo.ErrorDialog = True
                    myProcess = System.Diagnostics.Process.Start(myProcess.StartInfo)
                    myProcess.EnableRaisingEvents = True
                Else
                    MsgBox("Windows Calulator is not installed")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        txtInputValue.Text = 0
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim totalFileSize As Long = 0
            Dim selectedFileNames As String() = OpenFileDialog1.FileNames
            totalFileSize = getAllFileSizes(selectedFileNames)
            cmbConvType.SelectedIndex = 1
            cmbInputUnit.SelectedIndex = 1 'File Size is always read as Bytes
            txtInputValue.Text = totalFileSize
        End If
    End Sub

    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        txtInputValue.Text = 0
        If (FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim totalFolderSize As Long = 0
            Dim selectedDirPath As String = FolderBrowserDialog1.SelectedPath
            totalFolderSize = getAllFolderSizes(selectedDirPath)
            cmbConvType.SelectedIndex = 1
            cmbInputUnit.SelectedIndex = 1 'File Size is always read as Bytes
            txtInputValue.Text = totalFolderSize
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim outTypeArr As String()
        If (cmbConvType.SelectedIndex = 0) Then
            outTypeArr = decimalArray 'output units are in decimal format
        Else
            outTypeArr = binaryArray 'output units are in binary format
        End If

        Dim strResults As New System.Text.StringBuilder
        strResults.AppendLine("Conversion Type is (" & cmbConvType.Text & ")" & vbNewLine)
        strResults.AppendLine("Input: " & txtInputValue.Text & " " & cmbInputUnit.SelectedItem & vbNewLine)
        strResults.AppendLine("Output:")
        strResults.AppendLine(outTypeArr(0) & vbTab & vbTab & vbTab & " = " & txtBits.Text)
        strResults.AppendLine(outTypeArr(1) & vbTab & vbTab & vbTab & " = " & txtBytes.Text)
        strResults.AppendLine(outTypeArr(2) & " = " & txtKB.Text)
        strResults.AppendLine(outTypeArr(3) & " = " & txtMB.Text)
        strResults.AppendLine(outTypeArr(4) & " = " & txtGB.Text)
        strResults.AppendLine(outTypeArr(5) & " = " & txtTB.Text)
        strResults.AppendLine(outTypeArr(6) & " = " & txtPB.Text)
        strResults.AppendLine(outTypeArr(7) & " = " & txtEB.Text)
        strResults.AppendLine(outTypeArr(8) & " = " & txtZB.Text)
        strResults.AppendLine(outTypeArr(9) & " = " & txtYB.Text)

        Dim fPath As String = Environment.CurrentDirectory + "\ByteConverterResults.txt"
        If (SaveTextToFile(strResults.ToString, fPath) = True) Then
            System.Diagnostics.Process.Start(fPath)
        End If
    End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        showAboutForm()
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        Me.Enabled = False
        FormTransferTime.Show()
        FormTransferTime.Focus()
    End Sub

    Private Sub pbox_MouseEnter(sender As Object, e As EventArgs) _
    Handles pBoxZB.MouseEnter, pBoxYB.MouseEnter, pBoxTB.MouseEnter, pBoxPB.MouseEnter, _
    pBoxMB.MouseEnter, pBoxKB.MouseEnter, pBoxGB.MouseEnter, pBoxEB.MouseEnter, pBoxBytes.MouseEnter, pBoxBits.MouseEnter
        Dim pBox As PictureBox = DirectCast(sender, PictureBox)
        pBox.Size = New System.Drawing.Size(25, 22)
        ToolTip1.SetToolTip(pBox, "Copy To Clipboard")
    End Sub

    Private Sub pbox_MouseLeave(sender As Object, e As EventArgs) _
    Handles pBoxZB.MouseLeave, pBoxYB.MouseLeave, pBoxTB.MouseLeave, pBoxPB.MouseLeave, _
    pBoxMB.MouseLeave, pBoxKB.MouseLeave, pBoxGB.MouseLeave, pBoxEB.MouseLeave, pBoxBytes.MouseLeave, pBoxBits.MouseLeave
        Dim pBox As PictureBox = DirectCast(sender, PictureBox)
        pBox.Size = New System.Drawing.Size(22, 22)
    End Sub

    Private Sub pbBox_MouseDown(sender As Object, e As EventArgs) _
    Handles pBoxZB.MouseDown, pBoxYB.MouseDown, pBoxTB.MouseDown, pBoxPB.MouseDown, _
    pBoxMB.MouseDown, pBoxKB.MouseDown, pBoxGB.MouseDown, pBoxEB.MouseDown, pBoxBytes.MouseDown, pBoxBits.MouseDown

        'Copy individual results to clipboard
        Dim pBox As PictureBox = DirectCast(sender, PictureBox)
        pBox.BorderStyle = BorderStyle.Fixed3D
        Select Case pBox.Name
            Case pBoxBits.Name
                My.Computer.Clipboard.SetText(txtBits.Text)
            Case pBoxBytes.Name
                My.Computer.Clipboard.SetText(txtBytes.Text)
            Case pBoxKB.Name
                My.Computer.Clipboard.SetText(txtKB.Text)
            Case pBoxMB.Name
                My.Computer.Clipboard.SetText(txtMB.Text)
            Case pBoxGB.Name
                My.Computer.Clipboard.SetText(txtGB.Text)
            Case pBoxTB.Name
                My.Computer.Clipboard.SetText(txtTB.Text)
            Case pBoxPB.Name
                My.Computer.Clipboard.SetText(txtPB.Text)
            Case pBoxEB.Name
                My.Computer.Clipboard.SetText(txtEB.Text)
            Case pBoxZB.Name
                My.Computer.Clipboard.SetText(txtZB.Text)
            Case pBoxYB.Name
                My.Computer.Clipboard.SetText(txtYB.Text)
        End Select
    End Sub

    Private Sub pbBox_MouseUp(sender As Object, e As MouseEventArgs) Handles pBoxZB.MouseUp, pBoxYB.MouseUp, pBoxTB.MouseUp, pBoxPB.MouseUp, pBoxMB.MouseUp, pBoxKB.MouseUp, pBoxGB.MouseUp, pBoxEB.MouseUp, pBoxBytes.MouseUp, pBoxBits.MouseUp
        Dim pBox As PictureBox = DirectCast(sender, PictureBox)
        pBox.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnIcons_MouseEnter(sender As Object, e As EventArgs) _
    Handles btnSave.MouseEnter, btnFolder.MouseEnter, btnFile.MouseEnter, btnCalculator.MouseEnter, btnAbout.MouseEnter, btnTime.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        btn.Size = New System.Drawing.Size(36, 36)
    End Sub

    Private Sub btnIcons_MouseLeave(sender As Object, e As EventArgs) _
    Handles btnSave.MouseLeave, btnFolder.MouseLeave, btnFile.MouseLeave, btnCalculator.MouseLeave, btnAbout.MouseLeave, btnTime.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        btn.Size = New System.Drawing.Size(32, 32)
    End Sub

    Private Sub frmMain_DragOver(sender As Object, e As DragEventArgs) _
    Handles MyBase.DragOver, txtInputValue.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub frmMain_DragDrop(sender As Object, e As DragEventArgs) _
    Handles MyBase.DragDrop, txtInputValue.DragDrop
        Dim strDragFilesArr As String()
        Dim inputSize As Long = 0
        Try
            strDragFilesArr = e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop)
            If (strDragFilesArr Is Nothing) Then 'The drag-drop contents is of type "String/Text" or something else
                txtInputValue.Text = e.Data.GetData(System.Windows.Forms.DataFormats.Text)
            Else
                For Each strFilePath As String In strDragFilesArr 'To handle drag-drop of combination of files and directories
                    Dim t As Integer = New DirectoryInfo(strFilePath).Attributes
                    'Integers represent the sum/actual-value of System.IO.FileAttribute combinations
                    If (t = FileAttribute.Directory Or t = 48 Or t = 22) Then
                        inputSize += getAllFolderSizes(strFilePath)
                    Else
                        inputSize += getAllFileSizes({strFilePath}) 'Accepts only an array of files hence the {} brackets
                    End If
                Next
                txtInputValue.Text = inputSize.ToString
            End If
        Catch ex As Exception
            txtInputValue.Text = "DATA UNKNOWN"
        End Try
    End Sub

#End Region

#Region "All Methods"

    Private Function getAllFileSizes(ByVal fileNamesArr As String()) As Long
        For Each fileName As String In fileNamesArr
            Try
                getAllFileSizes += New FileInfo(fileName).Length.ToString()
            Catch ex As Exception
                'Do Nothing
            End Try
        Next
        Return getAllFileSizes
    End Function

    Private Function getAllFolderSizes(ByVal dirPath As String) As Long
        Try
            'First get the size of the files in this directory
            Dim fileNamesArr As String() = Directory.GetFiles(dirPath)
            getAllFolderSizes = getAllFileSizes(fileNamesArr)
            'Then recursively walk through its subdirectories
            'Check if sub-directories exist, if they do, then recursively read their file sizes as well
            For Each subDirPath As String In Directory.GetDirectories(dirPath)
                getAllFolderSizes += getAllFolderSizes(subDirPath)
            Next
        Catch ex As Exception
            'Do Nothing
        End Try
        Return getAllFolderSizes
    End Function

    Private Sub ResetFeilds()
        txtInputValue.Text = "0"
        lblError.Text = ""
        input = 0.0
        cmbConvType.SelectedIndex = 1
        cmbInputUnit.SelectedIndex = 1
        ShowHideLblError()
    End Sub

    Private Sub ShowHideLblError()
        ' Max and Min size of the form keeps the window size in check
        If Trim(lblError.Text) = "" Then
            lblError.Visible = False
            Me.Height = Me.Height - lblError.Height
        Else
            lblError.Visible = True
            Me.Height = Me.Height + lblError.Height
        End If
    End Sub

    Private Sub ChangeUnitsDisplayedAsPerConversionType()
        If cmbInputUnit.SelectedIndex = -1 Then
            temp = 1
        Else
            temp = CByte(cmbInputUnit.SelectedIndex)
        End If
        cmbInputUnit.DataSource = Nothing

        If cmbConvType.SelectedIndex = 0 Then
            lblKB.Text = decimalArray(2)
            lblMB.Text = decimalArray(3)
            lblGB.Text = decimalArray(4)
            lblTB.Text = decimalArray(5)
            lblPB.Text = decimalArray(6)
            lblEB.Text = decimalArray(7)
            lblZB.Text = decimalArray(8)
            lblYB.Text = decimalArray(9)
            cmbInputUnit.DataSource = decimalArray
        Else
            lblKB.Text = binaryArray(2)
            lblMB.Text = binaryArray(3)
            lblGB.Text = binaryArray(4)
            lblTB.Text = binaryArray(5)
            lblPB.Text = binaryArray(6)
            lblEB.Text = binaryArray(7)
            lblZB.Text = binaryArray(8)
            lblYB.Text = binaryArray(9)
            cmbInputUnit.DataSource = binaryArray
        End If
        cmbInputUnit.SelectedIndex = temp
    End Sub

    'Input validation using Regular Expression
    Private Function IsInputValid(ByVal input As String) As Boolean
        'Valid input should follow one of these patterns
        'sign(0 or 1 times)->number(0 or more times)->dot(0 or 1 times)->number(1 or more times)->E(exactly once)->sign(0 or 1 times)->number(1 or more times)
        'OR without exponent notation...
        'sign(0 or 1 times)->number(0 or more times)->dot(0 or 1 times)->number(1 or more times)
        Dim pattern_regex As String = "([+-]?[0-9]*[\.]?[0-9]+[E]{1}[+-]?[0-9]+)$|([+-]?[0-9]*[\.]?[0-9]+)$"
        If Regex.IsMatch(input, pattern_regex) = True Then
            lblError.Text = ""
            Return True
        Else
            lblError.Text = "Enter a valid number"
            Return False
        End If
    End Function

    Private Sub ConvertToBit()
        Try
            input = 0

            If IsInputValid(txtInputValue.Text) = False Then
                lblError.Text = "Enter a valid number"
            ElseIf cmbInputUnit.SelectedIndex = -1 Then
                lblError.Text = "Select Input unit"
            ElseIf cmbConvType.SelectedIndex = -1 Then
                lblError.Text = "Select Conversion Type"
            Else

                ' Gets the user's input value and its unit.
                input = txtInputValue.Text
                convFrom = CByte(cmbInputUnit.SelectedIndex)

                ' Decides if the conversion type is binary or decimal.
                If cmbConvType.SelectedIndex = 0 Then
                    convType = 1000
                Else
                    convType = 1024
                End If

                ' Converts the input value from the given unit (convFrom) to bits.
                ' Convert Bytes to bits by multiplying with "8"
                Select Case convFrom
                    Case 0 ' Bit
                        input = input
                    Case 1 ' Byte
                        input = input * 8
                    Case 2 ' Kilo/Kibi
                        input = input * (8 * (convType ^ 1))
                    Case 3 ' Mega/Mebi
                        input = input * (8 * (convType ^ 2))
                    Case 4 ' Giga/Gibi
                        input = input * (8 * (convType ^ 3))
                    Case 5 ' Tera/Tebi
                        input = input * (8 * (convType ^ 4))
                    Case 6 ' Peta/Pebi
                        input = input * (8 * (convType ^ 5))
                    Case 7 ' Exa/Exbi
                        input = input * (8 * (convType ^ 6))
                    Case 8 ' Zetta/Zebi
                        input = input * (8 * (convType ^ 7))
                    Case 9 ' Yotta/Yobi
                        input = input * (8 * (convType ^ 8))
                    Case Else
                        Exit Sub
                        ResetFeilds()
                End Select
            End If

            ' Converts the input from Bits into the desired unit and displays them in the results.
            CalcAndDispResults()

        Catch CastEx As InvalidCastException
            lblError.Text = "Enter a valid number"
        Catch FormatEx As FormatException
            lblError.Text = "Enter a valid number"
        Catch OverFlowEx As OverflowException
            lblError.Text = "Input value too large to be handled..."
        Catch ex As Exception
            MsgBox(ex.ToString)
            input = 0
            CalcAndDispResults()
        End Try
    End Sub

    Private Sub CalcAndDispResults()
        Try
            If (input = 0) Then
                txtBits.Text = "0"
                txtBytes.Text = "0"
                txtKB.Text = "0"
                txtMB.Text = "0"
                txtGB.Text = "0"
                txtTB.Text = "0"
                txtPB.Text = "0"
                txtEB.Text = "0"
                txtZB.Text = "0"
                txtYB.Text = "0"
            Else
                txtBits.Text = input.ToString
                txtBytes.Text = (input / 8).ToString
                txtKB.Text = (input / (8 * (convType ^ 1))).ToString
                txtMB.Text = (input / (8 * (convType ^ 2))).ToString
                txtGB.Text = (input / (8 * (convType ^ 3))).ToString
                txtTB.Text = (input / (8 * (convType ^ 4))).ToString
                txtPB.Text = (input / (8 * (convType ^ 5))).ToString
                txtEB.Text = (input / (8 * (convType ^ 6))).ToString
                txtZB.Text = (input / (8 * (convType ^ 7))).ToString
                txtYB.Text = (input / (8 * (convType ^ 8))).ToString

                ' Clears the lblError.text, when the input is valid, thus, triggering the lblError.Textchanged event.
                If (txtInputValue.Text <> "" And txtBits.Text <> "0") _
                Or (CDbl(txtInputValue.Text) = 0.0 And txtBits.Text = "0" And Not txtInputValue.Text.EndsWith(".")) Then
                    lblError.Text = ""
                End If
            End If

        Catch ex As Exception
            lblError.Text = "Enter a valid number"
        End Try
    End Sub

    ' Checks if the process(calc.exe) is already running, if so, then associate it with myProcess object
    Private Function isProcessAlreadyOpen() As Boolean
        InstanceArrayOfMyProcess = System.Diagnostics.Process.GetProcessesByName("calc")
        If InstanceArrayOfMyProcess.Length > 0 Then
            myProcess = InstanceArrayOfMyProcess(0)
            myProcess.EnableRaisingEvents = True
            Return True ' Instance of the process is already running
        Else
            Return False ' No instance of the process is running
        End If
    End Function

    Private Sub showAboutForm()
        Me.Enabled = False
        FormAbout.Show()
        FormAbout.Focus()
    End Sub

    Public Function SaveTextToFile(ByVal textToBeSaved As String, ByVal filePath As String) As Boolean
        Dim blnHasSaveSucceeded As Boolean = False
        Dim objStreamWriter As StreamWriter
        Try
            If File.Exists(filePath) = False Then File.Create(filePath).Close()
            objStreamWriter = New StreamWriter(filePath)
            objStreamWriter.Write(textToBeSaved)
            objStreamWriter.Close()
            blnHasSaveSucceeded = True
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        End Try
        Return blnHasSaveSucceeded
    End Function

#End Region

End Class

#End Region