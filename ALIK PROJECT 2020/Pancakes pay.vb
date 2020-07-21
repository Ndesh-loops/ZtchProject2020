Public Class Payment

    Private Sub Pancakes_pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine
        Label1.Text = " Payment options "
        Label2.Text = " Pay via cash "
        Label3.Text = " M-pesa "
        Label4.Text = " Lipa na M-Pesa "
        Label5.Text = "  Till number will be provided "
        Label6.Text = "  Confirm payment and keep message for reference "
        Button1.Text = " NEXT "
        Label7.Text = " Ensure you get a rceipt "
        Label8.Text = " >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> "
        Label9.Text = " >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> "
        Label10.Text = " >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> "
        Label11.Text = " ............ "
        Label12.Text = " ............ "

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Omega.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class