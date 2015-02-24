
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
' Date          :- February 2015
' Email         :- akma.mansoor@gmail.com 

' Description   :- Byte Converter is a simple utility to convert numeric units of digital information from one form to another. 
'                  The supported units are,
'                  Decimal - Bits, Bytes, KiloBytes (KB), MegaBytes (MB), GigaBytes (GB), TeraBytes (TB), PetaBytes (TB), ExaBytes (EB), ZettaBytes (ZB), YottaBytes (YB)
'                  Binary  - Bits, Bytes, KiloBytes (KiB), MegaBytes (MiB), GigaBytes (GiB), TeraBytes (TiB), PetaBytes (TiB), ExaBytes (EiB), ZettaBytes (ZiB), YottaBytes (YiB)

' Note          :- If you have any suggestions\corrections in this application, please do e-mail me at the address above.

#End Region

#Region "Source Code"

Option Explicit On

Public Class FormTransferTime

#Region "All Declarations"
    Dim arrBandwidthUnits As String() = {"Kbits", "Mbits", "Gbits", "Tbits", "Pbits", "KBytes", "MBytes", "GBytes", "TBytes", "PBytes"}
    Dim success As Boolean = False
#End Region

#Region "All Events"
    Private Sub FormTransferTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBandwidthUnits.DataSource = arrBandwidthUnits
        'Minimum speed for broadband is 256Kbps
        mskTxtBandwidth.Text = "256"
        cmbDataUnit.SelectedIndex = FormMain.cmbInputUnit.SelectedIndex
        cmbBandwidthUnits.SelectedIndex = 0 'Kbits
    End Sub

    Private Sub FormTransferTime_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMain.Enabled = True
        FormMain.Focus()
    End Sub

    Private Sub mskTxtBandwidth_cmbBandwidthUnits_Changed(sender As Object, e As EventArgs) _
    Handles mskTxtBandwidth.TextChanged, cmbBandwidthUnits.SelectedIndexChanged
        calculateTime()
    End Sub

    Private Sub txtDataSize_TextChanged(sender As Object, e As EventArgs) Handles txtDataSize.TextChanged
        FormMain.txtInputValue.Text = txtDataSize.Text
        calculateTime()
    End Sub

    Private Sub cmbDataUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDataUnit.SelectedIndexChanged
        FormMain.cmbInputUnit.SelectedIndex = cmbDataUnit.SelectedIndex
        calculateTime()
    End Sub
#End Region

#Region "All Methods"

    Private Function getBandwidthInBits() As ULong
        Dim bandwidthInBits As ULong
        Try
            Dim userBandwidth As Integer = Integer.Parse(mskTxtBandwidth.Text)
            Dim convStandard As Short = FormMain.convType
            Select Case cmbBandwidthUnits.SelectedIndex
                Case 0 'KBits
                    bandwidthInBits = userBandwidth * (convStandard ^ 1)
                Case 1 'Mbits
                    bandwidthInBits = userBandwidth * (convStandard ^ 2)
                Case 2 'Gbits
                    bandwidthInBits = userBandwidth * (convStandard ^ 3)
                Case 3 'Tbits
                    bandwidthInBits = userBandwidth * (convStandard ^ 4)
                Case 4 'Pbits
                    bandwidthInBits = userBandwidth * (convStandard ^ 5)
                Case 5 'KBytes
                    bandwidthInBits = userBandwidth * (8 * (convStandard ^ 1))
                Case 6 'MBytes
                    bandwidthInBits = userBandwidth * (8 * (convStandard ^ 2))
                Case 7 'GBytes
                    bandwidthInBits = userBandwidth * (8 * (convStandard ^ 3))
                Case 8 'TBytes
                    bandwidthInBits = userBandwidth * (8 * (convStandard ^ 4))
                Case 9 'PBytes
                    bandwidthInBits = userBandwidth * (8 * (convStandard ^ 5))
            End Select
            success = True
        Catch
            txtTime.Text = "Bandwidth too large to handle..."
        End Try
        Return bandwidthInBits
    End Function

    Private Sub calculateTime()
        txtTime.Clear()
        success = False
        Dim timeInSeconds As ULong
        Dim bandwidthInBits As ULong
        Try
            bandwidthInBits = getBandwidthInBits()
            If (success = True) Then
                success = False
                timeInSeconds = getTransferTimeInSeconds(bandwidthInBits)
                If (success = True) Then
                    success = False
                    displayTime(timeInSeconds)
                End If
            End If
        Catch ex As OverflowException
            txtTime.Text = "Input is too large to handle..."
        End Try
    End Sub

    Private Function getTransferTimeInSeconds(bandwidthInBits As ULong) As ULong
        Dim timeInSeconds As ULong
        Dim inputValue As ULong = FormMain.input
        Try
            If (inputValue <= 0) Then
                timeInSeconds = 0
            Else
                Dim inputInBits As ULong = ULong.Parse(inputValue.ToString("#"))
                timeInSeconds = inputInBits \ bandwidthInBits
            End If
            success = True
        Catch ex As Exception
            txtTime.Text = "Time too large to handle..."
        End Try
        Return timeInSeconds
    End Function

    Private Sub displayTime(timeInSeconds As ULong)
        Try
            If (timeInSeconds < 60) Then
                txtTime.Text &= timeInSeconds.ToString & " " & "second(s)"
                Exit Sub
            ElseIf (timeInSeconds < 3600) Then 'less than an Hour (60 * 60 = 3600) 
                txtTime.Text &= (timeInSeconds \ 60).ToString & " " & "minute(s)," & vbNewLine & vbNewLine
                timeInSeconds = timeInSeconds Mod 60
            ElseIf (timeInSeconds < 86400) Then 'less than a Day (60 * 60 * 24 = 86400)
                txtTime.Text &= (timeInSeconds \ 3600).ToString & " " & "hour(s)," & vbNewLine & vbNewLine
                timeInSeconds = timeInSeconds Mod 3600
            ElseIf (timeInSeconds < 604800) Then 'less than a Week (60 * 60 * 24 * 7 = 604800)
                txtTime.Text &= (timeInSeconds \ 86400).ToString & " " & "day(s)," & vbNewLine & vbNewLine
                timeInSeconds = timeInSeconds Mod 86400
            ElseIf (timeInSeconds < 2592000) Then 'less than a Month (60 * 60 * 24 * 30 = 2592000)
                txtTime.Text &= (timeInSeconds \ 604800).ToString & " " & "week(s)," & vbNewLine & vbNewLine
                timeInSeconds = timeInSeconds Mod 604800
            ElseIf (timeInSeconds < 31536000) Then 'less than a Year (60 * 60 * 24 * 365 = 31536000)
                txtTime.Text &= (timeInSeconds \ 2592000).ToString & " " & "month(s)," & vbNewLine & vbNewLine
                timeInSeconds = timeInSeconds Mod 2592000
            Else 'more than a Year
                txtTime.Text &= (timeInSeconds \ 31536000).ToString & " " & "year(s)," & vbNewLine & vbNewLine
                timeInSeconds = timeInSeconds Mod 31536000
            End If
            If (timeInSeconds > 0) Then displayTime(timeInSeconds)
        Catch
            txtTime.Text = "DISPLAY-TIME ERROR"
        End Try
    End Sub

    Public Sub setDataUnits(convType As Boolean)
        Dim tempSelIndex = FormMain.cmbInputUnit.SelectedIndex
        If convType = 0 Then
            cmbDataUnit.DataSource = FormMain.decimalArray
        Else
            cmbDataUnit.DataSource = FormMain.binaryArray
        End If
        cmbDataUnit.SelectedIndex = tempSelIndex
    End Sub

    Public Sub setDataSize(inputValue As String)
        txtDataSize.Text = inputValue
    End Sub
#End Region

End Class

#End Region