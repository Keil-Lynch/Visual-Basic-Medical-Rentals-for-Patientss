﻿Public Class frmRentalCost
    Private Sub btnDisplayRates_Click(sender As Object, e As EventArgs) Handles btnDisplayRates.Click
        lstRentalRates.Items.Clear()
        lstRentalRates.Items.Add("Price of Equipment" & "                                 Half-day" & "   Full-day")
        lstRentalRates.Items.Add("1. Blood pressure monitor: " & vbTab & vbTab & "$16.00" & vbTab & "$24.00")
        lstRentalRates.Items.Add("2. Heart rate monitor: " & vbTab & vbTab & "$12.00" & vbTab & "$18.00")
        lstRentalRates.Items.Add("3. Daily activity monitor: " & vbTab & vbTab & "$20.00" & vbTab & "$30.00")

    End Sub

    Private Sub btnDisplayBill_Click(sender As Object, e As EventArgs) Handles btnDisplayBill.Click

        lstBill.Items.Clear()
        If (txtItem.Text = "1" Or txtItem.Text = "2" Or txtItem.Text = "3") And (txtDuration.Text.ToUpper() = "H" Or txtDuration.Text.ToUpper() = "F") Then

        End If
        Const deposit = 30
        Dim item, duration As String
        Dim itemsCost As Double

        item = txtItem.Text
        duration = txtDuration.Text.ToUpper()

        Select Case item
            Case "1"
                item = "Blood pressure monitor"
                itemsCost = 16
            Case "2"
                item = "Heart rate monitor"
                itemsCost = 12
            Case "3"
                item = "Daily activity monitor"
                itemsCost = 20
        End Select

        If duration = "F" Then
            itemsCost = itemsCost + (itemsCost * 0.5)
            duration = "Full day"
        Else
            duration = "Half day"
        End If

        lstBill.Items.Add("Receipt from Nutritional Associates of New Jersey Device Rentals")
        lstBill.Items.Add("")
        lstBill.Items.Add(item & ":  " & itemsCost.ToString("C2") & " " & duration)
        lstBill.Items.Add("Deposit: " & deposit.ToString("C2"))
        lstBill.Items.Add("")
        lstBill.Items.Add("Total: " & (itemsCost + deposit).ToString("C2"))

    End Sub
End Class
