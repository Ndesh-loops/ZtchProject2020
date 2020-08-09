Public Class test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, sum As Integer
        x = TextBox1.Text
        y = TextBox2.Text
        sum = x + y
        Label2.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x, y, subtract As Integer
        x = TextBox1.Text
        y = TextBox2.Text
        subtract = x - y
        Label2.Text = subtract
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x, y, divide As Integer
        x = TextBox1.Text
        y = TextBox2.Text
        divide = x / y
        Label2.Text = divide
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x, y, multiply As Integer
        x = TextBox1.Text
        y = TextBox2.Text
        multiply = x * y
        Label2.Text = multiply
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class