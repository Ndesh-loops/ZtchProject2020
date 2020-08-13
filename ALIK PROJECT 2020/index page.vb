Imports MySql.Data.MySqlClient
Public Class index_page
    Dim sql As String
    Dim cmd As MySqlCommand
    Dim total As Double

    Private Sub index_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = Color.DarkSeaGreen
        Dim sql As String
        sql = "select * from dishes"
        Call Connect()
        Call PopulateListView(DishesListView, sql)
        Call Populate_Category()
        customer = 0

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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        test.Show()
    End Sub

    Private Sub CalculateChargesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateChargesToolStripMenuItem.Click
        test.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
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
    Public Sub MostOrdered()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CartItems As ListView.SelectedListViewItemCollection = Me.DishesListView.SelectedItems
        Dim item As ListViewItem
        For Each item In CartItems
            CartDataGridView.Rows.Add(item.SubItems(1).Text, item.SubItems(2).Text, item.SubItems(3).Text, 1, item.SubItems(3).Text)

        Next item
        MessageBox.Show("Succesfully added to cart.View my cart to confirm")
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged
        Dim sql As String
        If TypeComboBox.Text = "Food" Then
            sql = "select * from dishes WHERE type='food'"
            Call PopulateListView(DishesListView, sql)

        ElseIf TypeComboBox.Text = "Drink" Then
            sql = "select * from dishes WHERE type='Drink'"
            Call PopulateListView(DishesListView, sql)

        End If
    End Sub

    Private Sub PriceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged

    End Sub
    Public Sub Populate_Category()
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim item As String
        sql = "Select * from DishesCategories"
        cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader
        Do While reader.Read
            item = reader("id")
            CategoryComboBox.Items.Add(item)
        Loop
        reader.Close()
    End Sub

    Private Sub CartDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles CartDataGridView.RowsAdded
        Call CartCalculations()
    End Sub
    Private Function CartCalculations()
        total = 0
        For i As Integer = 0 To CartDataGridView.Rows.Count - 1
            CartDataGridView.Rows(i).Cells(4).Value = CartDataGridView.Rows(i).Cells(3).Value * CartDataGridView.Rows(i).Cells(4).Value
            total += CartDataGridView.Rows(i).Cells(4).Value
        Next
        SubTotalTextBox.Text = total
        VATTextBox.Text = total * 0.16
        GrandTextBox.Text = total * 1.16

    End Function

    Private Sub CartDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CartDataGridView.CellContentClick

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim custName As String
        Dim phoneno As String
        custName = InputBox("Enter your name")
        phoneno = InputBox("Enter you phone number (Optional)")
        sql = "INSERT INTO customers(id,customer_name,phone_no) values(NULL,@customer_name,@phone_no)"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@customer_name", custName)
        cmd.Parameters.AddWithValue("@phone_no", phoneno)
        Try
            cmd.ExecuteNonQuery()
            sql = "SELECT LAST_INSERT_ID()"
            cmd = New MySqlCommand(sql, con)
            customer = cmd.ExecuteScalar()
            sql = "INSERT INTO orders(customer_id) values(" & customer & ")"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            sql = "SELECT LAST_INSERT_ID()"
            cmd = New MySqlCommand(sql, con)
            orderid = cmd.ExecuteScalar()
            Call SaveorderItems()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SaveorderItems()
        sql = "INSERT INTO order_items(id,dish_id,quantity,order_id) values(NULL,@dish_id,@quantity,@order)"

        For i As Integer = 0 To CartDataGridView.Rows.Count - 1
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@dish_id", CartDataGridView.Rows(i).Cells(0).Value)
            cmd.Parameters.AddWithValue("@quantity", CartDataGridView.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("@order", orderid)
            cmd.ExecuteNonQuery()
        Next

        currentOrderTotal = total
        CartDataGridView.Rows.Clear()
        Dim choice As Integer
        choice = MsgBox("Order placed succesfully.Do you want to Proceed to Payment ?", vbYesNo)
        If choice = vbYes Then
            Pay.ShowDialog()
        Else
            MessageBox.Show("You have chosen to pay cash.Ensure you get a receipt for future reference")
        End If
    End Sub

    Private Sub CartDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CartDataGridView.CellEndEdit
        Call CartCalculations()
    End Sub

    Private Sub CartDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles CartDataGridView.RowsRemoved
        Call CartCalculations()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class
