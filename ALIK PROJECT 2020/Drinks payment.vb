Public Class Drinks_payment

    Private Sub Drinks_payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine
        Label1.Text = " PAYMENT OPTIONS "
        Label2.Text = " Pay via CASH "
        Label3.Text = " If you pay by this means ensure you get a receipt "
        Label4.Text = " Pay via M-PESA "
        Label5.Text = " Go to LIPA na M-PESA "
        Label6.Text = " Till number will be provided by the hotel staff "
        Label7.Text = " Confirm and keep message for refernce "
        Button1.Text = " NEXT "
        Label8.Text = " ............... "
        Label9.Text = " >>>>>>>>>>>>>>> "
        Label10.Text = " >>>>>>>>>>>>>> "
        Label11.Text = " >>>>>>>>>>>>>> "
        Label12.Text = " .............. "

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Omega.Show()
    End Sub
End Class