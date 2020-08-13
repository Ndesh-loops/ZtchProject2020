Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Pay
    Dim mpesacode As String
    Dim accountnumber As String
    Dim sql As String
    Dim cmd As MySqlCommand
    Dim subtotal As Double
    Dim VAT As Double
    Dim grandtotal As Double
    Dim payment As String
    Dim authorizationcode As String

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click

        If PaymentOptionsComboBox.Text = "MPesa" Then
            accountnumber = InputBox("Enter your phone number")
            MessageBox.Show("Enter your pin number to confirm payment")

            subtotal = SubTotalTextBox.Text
            VAT = VATTextBox.Text
            grandtotal = GrandTotalTextBox.Text
            payment = PaymentOptionsComboBox.Text
            Call MpesaCodeGenerator()
            authorizationcode = mpesacode

            sql = "INSERT INTO receipts(Customer_id, subtotal, VAT, grand_total, payment_mode, ccno, Authorization_code, order_id) VALUES (" & customer & "," & subtotal & "," & VAT & "," & grandtotal & ",'" & payment & "','" & accountnumber & "','" & authorizationcode & "'," & orderid & ")"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            sql = "UPDATE orders SET status='pending delivery' where id=" & orderid
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Payment request received. Proceed to table number: ")
            grandtotal = 0
            Me.Close()
        Else
            MessageBox.Show("Proceed to cashier with order number " & orderid)
            Me.Close()
        End If

    End Sub

    Private Sub Pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubTotalTextBox.Text = currentOrderTotal
        VATTextBox.Text = 0.16 * currentOrderTotal
        GrandTotalTextBox.Text = 1.16 * currentOrderTotal
    End Sub

    Private Sub MpesaCodeGenerator()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        mpesacode = sb.ToString()
    End Sub

    Private Sub PayButton_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PayButton_Click_2(sender As Object, e As EventArgs) Handles PayButton.Click

    End Sub
End Class