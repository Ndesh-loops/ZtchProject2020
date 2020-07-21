Public Class Breakfast_menu

    Private Sub Breakfast_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine
        Label1.Text = " Break fast Delicacies "
        Label2.Text = " VIBIBI PANCAKES "
        Label3.Text = " MUKIMO "
        Label4.Text = " UGALI "
        Label5.Text = " CHAPATI "
        Label6.Text = " MAHAMRI "
        Label7.Text = " Kshs.100 "
        Label8.Text = " Kshs.150 "
        Label9.Text = " Kshs.150"
        Label10.Text = "Kshs.100 "
        Label11.Text = "Kshs.100 "
        Button1.Text = " ORDER "
        Button2.Text = " ORDER "
        Button3.Text = " ORDER "
        Button4.Text = " ORDER "
        Button5.Text = " ORDER "

        Label13.Text = " ............................ "
        Label18.Text = " >>>>>>>>>>>>>>>>>>>>>>>>> "
        Label14.Text = " ............................ "
        Label15.Text = " ............................ "
        Label16.Text = " ............................ "
        Label17.Text = " ............................ "
        Label19.Text = " >>>>>>>>>>>>>>>>>>>>>>>>> "
        Label20.Text = " >>>>>>>>>>>>>>>>>>>>>>>>> "
        Label21.Text = " >>>>>>>>>>>>>>>>>>>>>>>>> "
        Label22.Text = " >>>>>>>>>>>>>>>>>>>>>>>>> "


        'This is a menu of Kenyan breakfast according to https://food.jumia.co.ke/blog/must-have-kenyan-breakfasts-tourists-2164
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()
        Payment.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Payment.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Payment.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Payment.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        Payment.Show()
    End Sub
End Class