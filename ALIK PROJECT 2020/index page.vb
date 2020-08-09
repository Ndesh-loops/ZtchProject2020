Public Class index_page

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub index_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkSeaGreen





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckedListBox1.CheckedItems.Count > 0 Then
            For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
                ListBox1.Items.Add(CheckedListBox1.CheckedItems(i))
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        test.Show()
    End Sub

    Private Sub CalculateChargesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateChargesToolStripMenuItem.Click
        test.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("We have succesfully received your Order Please choose table number and wait")
        Pick_Table.Show()
    End Sub

    Private Sub FoodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FoodToolStripMenuItem.Click
        lunch_dishes.Show()
    End Sub

    Private Sub DrinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrinkToolStripMenuItem.Click
        Drinks.Show()
    End Sub

    Private Sub ViaEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViaEmailToolStripMenuItem.Click
        MessageBox.Show("Our email : alikprjct@gmail.com")
    End Sub

    Private Sub ViaPhoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViaPhoneToolStripMenuItem.Click
        MessageBox.Show("Contact us through +254 730 444 212")
    End Sub

    Private Sub FoodToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FoodToolStripMenuItem1.Click
        lunch_dishes.Close()
    End Sub

    Private Sub DrinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DrinkToolStripMenuItem1.Click
        Drinks.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub CashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashToolStripMenuItem.Click

        dishes_payment.Show()
    End Sub

    Private Sub MPesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MPesaToolStripMenuItem.Click

        Drinks_payment.Show()
    End Sub

    Private Sub HowToOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToOrderToolStripMenuItem.Click
        MessageBox.Show("Click on file then Open Menu and a list of food will appear. Simply check all the items you want and click Add to cart .Then Send")

    End Sub

    Private Sub HowToPayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToPayToolStripMenuItem.Click
        MessageBox.Show("At the top Click Payment and then choose what you are paying for.Pay via Cah or M-Pesa ")
    End Sub

    Private Sub HowToPickATableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToPickATableToolStripMenuItem.Click
        MessageBox.Show("After Ordering a dish, a window will appear with a list of available tables.Simply select one and Send")
    End Sub

    Private Sub OtherToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OtherToolStripMenuItem2.Click
        Other_Feedback.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MessageBox.Show("Here are the most Ordered Dishes")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        lunch_dishes.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Drinks.Show()
    End Sub

    Private Sub ComplaintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplaintToolStripMenuItem.Click
        Complaint.Show()
    End Sub

    Private Sub ComplementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplementToolStripMenuItem.Click
        Complement.Show()
    End Sub

    Private Sub OtherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OtherToolStripMenuItem1.Click
        Other_Feedback.Show()
    End Sub
End Class