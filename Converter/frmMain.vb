
#Region "Copyright Notice"

' Copyright (C) 2009 - A.K. Mansoor Ahamed

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

' Application       :- Byte Converter
' Author            :- A.K. Mansoor Ahamed (a.k.a) A.K.M.A
' Company           :- AKMA Solutions
' Date              :- March 2009
' Mail Address      :- akma.mansoor@gmail.com 

' Description      :- This sofware can be used to convert a given numeric value from one unit to another, 
'                     among the following units,
'                     Decimal - Bits, Bytes, KB, MB, GB, TB, PB, EB, ZB, YB
'                     Binary  - Bits, Bytes, KiB, MiB, GiB, TiB, PiB, EiB, ZiB, YiB

' Note             :- If you have any suggestions\corrections in this application,
'                     please do e-mail me at the address above.

#End Region

'TO DO: 
'1) Improve text validation for "5.E", "5+-", "5-8", "5+8", and E,+,-,. in general during keypress and copy/paste
'2) Provide support for reading size of files/folders
'   2a) Create browse button to choose file
'   2b) Provide drag drop functionality for reading file size
'4) Estimate download times based on input size and specified bandwidth

#Region "Source Code"

Option Explicit On
'Imports System.Diagnostics

Public Class frmMain

#Region "All Declarations"

    Dim index As Integer
    Dim input As Double = 0.0
    Dim convFrom, temp As Byte
    Dim convType As Short
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
            frmAbout.Focus()
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        ResetFeilds()
        isProcessAlreadyOpen()
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
        Me.Enabled = False
        frmAbout.Show()
        frmAbout.Focus()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' Textbox validation, also triggers txtInputValue_Textchanged event. 
    Private Sub txtInputValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtInputValue.KeyPress
        ' 3 = Ctrl+C | 8 = Bkspc | 22 = Ctrl+V | 24 = Ctrl+X.
        If Not e.KeyChar = Convert.ToChar(3) And _
        Not e.KeyChar = Convert.ToChar(8) And _
        Not e.KeyChar = Convert.ToChar(22) And _
        Not e.KeyChar = Convert.ToChar(24) Then
            If Not IsNumeric(e.KeyChar) And _
               Not e.KeyChar.ToString.ToUpper = "E" And _
               Not (e.KeyChar = "+" Or e.KeyChar = "-") And _
               Not e.KeyChar = "." Then
                e.Handled = True
            ElseIf e.KeyChar = "." And txtInputValue.Text.Contains(".") Then
                e.Handled = True
            ElseIf e.KeyChar = "+" And (txtInputValue.Text.Contains("+") Or txtInputValue.Text.Contains("-")) Then
                e.Handled = True
            ElseIf e.KeyChar = "-" And (txtInputValue.Text.Contains("+") Or txtInputValue.Text.Contains("-")) Then
                e.Handled = True
            ElseIf e.KeyChar.ToString.ToUpper = "E" And txtInputValue.Text.Contains("E") Then
                e.Handled = True
            End If
        End If
    End Sub

#End Region

#Region "All Methods"

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
        cmbInputUnit.Items.Clear()

        If cmbConvType.SelectedIndex = 0 Then
            Label7.Text = decimalArray(2)
            Label8.Text = decimalArray(3)
            Label9.Text = decimalArray(4)
            Label10.Text = decimalArray(5)
            Label11.Text = decimalArray(6)
            Label12.Text = decimalArray(7)
            Label13.Text = decimalArray(8)
            Label14.Text = decimalArray(9)
            cmbInputUnit.Items.Add(decimalArray(0))
            cmbInputUnit.Items.Add(decimalArray(1))
            cmbInputUnit.Items.Add(decimalArray(2))
            cmbInputUnit.Items.Add(decimalArray(3))
            cmbInputUnit.Items.Add(decimalArray(4))
            cmbInputUnit.Items.Add(decimalArray(5))
            cmbInputUnit.Items.Add(decimalArray(6))
            cmbInputUnit.Items.Add(decimalArray(7))
            cmbInputUnit.Items.Add(decimalArray(8))
            cmbInputUnit.Items.Add(decimalArray(9))
        Else
            Label7.Text = binaryArray(2)
            Label8.Text = binaryArray(3)
            Label9.Text = binaryArray(4)
            Label10.Text = binaryArray(5)
            Label11.Text = binaryArray(6)
            Label12.Text = binaryArray(7)
            Label13.Text = binaryArray(8)
            Label14.Text = binaryArray(9)
            cmbInputUnit.Items.Add(binaryArray(0))
            cmbInputUnit.Items.Add(binaryArray(1))
            cmbInputUnit.Items.Add(binaryArray(2))
            cmbInputUnit.Items.Add(binaryArray(3))
            cmbInputUnit.Items.Add(binaryArray(4))
            cmbInputUnit.Items.Add(binaryArray(5))
            cmbInputUnit.Items.Add(binaryArray(6))
            cmbInputUnit.Items.Add(binaryArray(7))
            cmbInputUnit.Items.Add(binaryArray(8))
            cmbInputUnit.Items.Add(binaryArray(9))
        End If
        cmbInputUnit.SelectedIndex = temp
    End Sub

    'Methods for Validation and Conversions. 

    Private Function IsString(ByVal str As String) As Boolean

        ' Used to check if the input entered is a valid number or not,
        ' especially when the input is entered by copy-pasting.
        ' If return value is true, it means the input is not valid

        IsString = False
        For index = 0 To str.Length - 1
            If Not IsNumeric(str.Chars(index)) _
            And str.Chars(index).ToString.ToUpper <> "E" _
            And str.Chars(index) <> "+" _
            And str.Chars(index) <> "-" _
            And str.Chars(index) <> "." Then
                IsString = True
                Exit Function 'no need to validate anymore characters
            ElseIf str.Chars(index) = "." And str.Contains(".") And str.IndexOf(".") <> index Then
                IsString = True
            ElseIf str.Chars(index) = "+" _
            And (txtInputValue.Text.Contains("+") Or txtInputValue.Text.Contains("-")) _
            And str.IndexOf("+") <> index Then
                IsString = True
            ElseIf str.Chars(index) = "-" _
            And (txtInputValue.Text.Contains("+") Or txtInputValue.Text.Contains("-")) _
            And str.IndexOf("-") <> index Then
                IsString = True
            ElseIf str.Chars(index).ToString.ToUpper = "E" And str.Contains("E") And str.IndexOf("E") <> index Then
                IsString = True
                Exit Function
            End If
        Next
    End Function

    Private Sub ConvertToBit()
        Try
            input = 0

            If Trim(txtInputValue.Text) = "" Then
                lblError.Text = "Enter a valid number"
            ElseIf IsString(txtInputValue.Text) = True _
            Or txtInputValue.Text.IndexOf(".") = txtInputValue.Text.Length - 1 Then
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
                txtResult1.Text = "0"
                txtResult2.Text = "0"
                txtResult3.Text = "0"
                txtResult4.Text = "0"
                txtResult5.Text = "0"
                txtResult6.Text = "0"
                txtResult7.Text = "0"
                txtResult8.Text = "0"
                txtResult9.Text = "0"
                txtResult10.Text = "0"
            Else
                txtResult1.Text = input.ToString
                txtResult2.Text = (input / 8).ToString
                txtResult3.Text = (input / (8 * convType)).ToString
                txtResult4.Text = (input / (8 * (convType ^ 2))).ToString
                txtResult5.Text = (input / (8 * (convType ^ 3))).ToString
                txtResult6.Text = (input / (8 * (convType ^ 4))).ToString
                txtResult7.Text = (input / (8 * (convType ^ 5))).ToString
                txtResult8.Text = (input / (8 * (convType ^ 6))).ToString
                txtResult9.Text = (input / (8 * (convType ^ 7))).ToString
                txtResult10.Text = (input / (8 * (convType ^ 8))).ToString

                ' Clears the lblError.text, when the input is valid, thus, triggering the lblError.Textchanged event.

                If (txtInputValue.Text <> "" And txtResult1.Text <> "0") _
                Or (CDbl(txtInputValue.Text) = 0.0 And txtResult1.Text = "0" And Not txtInputValue.Text.EndsWith(".")) Then
                    lblError.Text = ""
                End If
            End If

        Catch ex As Exception
            lblError.Text = "Enter a valid number"
        End Try
    End Sub

    ' Checks if the process(calc.exe) is already running, if so then associate it with myProcess object
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

#End Region

End Class

#End Region
