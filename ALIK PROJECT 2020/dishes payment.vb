Public Class dishes_payment

    Private Sub dishes_payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine
        Label1.Text = " PAYMENT OPTIONS "
        Label2.Text = " Payment in cash "
        Label3.Text = " This not necessary but ensure you get a receipt "
        Label4.Text = " M-Pesa "
        Label5.Text = " Lipa na M-Pesa "
        Label6.Text = " Till number will be provided by the staff "
        Label7.Text = " Confirm and keep message for reference "
        Label8.Text = " >>>>>>>>>>>>>>>>>>>>>> "
        Label9.Text = " >>>>>>>>>>>>>>>>>>>>>> "
        Label10.Text = " >>>>>>>>>>>>>>>>>>>>>> "
        Label11.Text = " ...................... "
        Label12.Text = " ...................... "


        Button1.Text = " NEXT "
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Omega.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class