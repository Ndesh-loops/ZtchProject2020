Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine
        Label1.Text = " Here is what we recommend for Breakfast"
        Label2.Text = " Our Dishes are as listed here "
        Label3.Text = " See our various Drinks here "
        Button1.Text = " Click "
        Button2.Text = " Click "
        Button3.Text = " Click "
        Label8.Text = " BREAKFAST "
        Label9.Text = " DISHES "
        Label10.Text = " DRINKS "
        Label11.Text = " ........ "
        Label12.Text = " ........ "
        Label13.Text = " ........ "
        Label5.Text = " >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> "
        Label6.Text = " >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> "
        Label7.Text = " >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> "

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Breakfast_menu.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        lunch_dishes.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Drinks.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
