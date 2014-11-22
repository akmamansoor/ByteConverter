
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

#Region "Source Code"

Option Explicit On
Imports System.IO

Public Class FormAbout

#Region "All Events"

    Private Sub frmAbout_Activated(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Me.Activated
        FormMain.Focus()
    End Sub

    Private Sub frmAbout_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) _
    Handles Me.FormClosed
        FormMain.Enabled = True
        FormMain.Focus()
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        lblVersion.Text = ProductVersion
    End Sub

    Private Sub lnkContact_LinkClicked(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) _
    Handles lnkContact.LinkClicked
        If MsgBox("This will open your default e-mail client." + vbNewLine + "would you like to continue?", _
        MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("mailto:" & lnkContact.Text)
        End If
    End Sub

    Private Sub lnkLicense_LinkClicked(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) _
    Handles lnkLicense.LinkClicked
        If File.Exists(Application.StartupPath + "\LICENSE.txt") Then
            System.Diagnostics.Process.Start(Application.StartupPath + "\LICENSE.txt")
        Else
            If MsgBox("License file is missing." + vbNewLine + "Would you like to view it online?", _
            MsgBoxStyle.YesNo, "View License") = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start("http://www.gnu.org/licenses/gpl.html")
            End If
        End If
    End Sub

#End Region

End Class

#End Region