Public Class Drinks

    Private Sub Drinks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Aquamarine
        Label1.Text = " DRINKS "
        Label2.Text = " SODA  300Ml ( Warm / Cold ) "
        Label3.Text = " MINUTE MAID 300ML  ( Warm / Cold )"
        Label4.Text = " DELMONTE MANGO JUICE  ( Warm / Cold )"
        Label5.Text = " SMOTHEE ( Warm / Cold ) "
        Label6.Text = " Kshs.55 "
        Label7.Text = " Kshs.100 "
        Label8.Text = " Kshs.250 "
        Label9.Text = " Kshs.150 "
        Button1.Text = " ORDER "
        Button2.Text = " ORDER "
        Button3.Text = " ORDER "
        Button4.Text = " ORDER "
        Button5.Text = " BACK "
        Label10.Text = " ........................ "
        Label11.Text = " ........................ "
        Label12.Text = " ........................ "
        Label13.Text = " ........................ "
        Label14.Text = " >>>>>>>>>>>>>>>>>>>> "
        Label15.Text = " >>>>>>>>>>>>>>>>>>>> "
        Label16.Text = " >>>>>>>>>>>>>>>>>>>> "
        Label17.Text = " >>>>>>>>>>>>>>>>>>>> "



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Drinks_payment.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Drinks_payment.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Drinks_payment.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Drinks_payment.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub
End Class