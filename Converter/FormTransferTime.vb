Option Explicit On

Public Class FormTransferTime

    Dim arrBandwidthUnits As String() = {"Kbits", "Mbits", "Gbits", "Tbits", "Pbits", "KBytes", "MBytes", "GBytes", "TBytes", "PBytes"}
    Dim success As Boolean = False

    Private Sub FormTransferTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTime.Text = ""
        cmbBandwidthUnits.DataSource = arrBandwidthUnits
        'Minimum speed for broadband is 256Kbps
        mskTxtBandwidth.Text = "256"
        cmbBandwidthUnits.SelectedIndex = 0 'Kbits
    End Sub

    Private Sub FormTransferTime_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMain.Enabled = True
        FormMain.Focus()
    End Sub

    Private Sub mskTxtBandwidth_cmbBandwidthUnits_Changed(sender As Object, e As EventArgs) _
    Handles mskTxtBandwidth.TextChanged, cmbBandwidthUnits.SelectedIndexChanged
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
                txtTime.Text &= (timeInSeconds \ 60).ToString & " " & "minute(s)" & " "
                timeInSeconds = timeInSeconds Mod 60
            ElseIf (timeInSeconds < 86400) Then 'less than a Day (60 * 60 * 24 = 86400)
                txtTime.Text &= (timeInSeconds \ 3600).ToString & " " & "hour(s)" & " "
                timeInSeconds = timeInSeconds Mod 3600
            ElseIf (timeInSeconds < 604800) Then 'less than a Week (60 * 60 * 24 * 7 = 604800)
                txtTime.Text &= (timeInSeconds \ 86400).ToString & " " & "day(s)" & " "
                timeInSeconds = timeInSeconds Mod 86400
            ElseIf (timeInSeconds < 2592000) Then 'less than a Month (60 * 60 * 24 * 30 = 2592000)
                txtTime.Text &= (timeInSeconds \ 604800).ToString & " " & "week(s)" & " "
                timeInSeconds = timeInSeconds Mod 604800
            ElseIf (timeInSeconds < 31536000) Then 'less than a Year (60 * 60 * 24 * 365 = 31536000)
                txtTime.Text &= (timeInSeconds \ 2592000).ToString & " " & "month(s)" & " "
                timeInSeconds = timeInSeconds Mod 2592000
            Else 'more than a Year
                txtTime.Text &= (timeInSeconds \ 31536000).ToString & " " & "year(s)" & " "
                timeInSeconds = timeInSeconds Mod 31536000
            End If
            If (timeInSeconds > 0) Then displayTime(timeInSeconds)
        Catch
            txtTime.Text = "DISPLAY-TIME ERROR"
        End Try
    End Sub

End Class