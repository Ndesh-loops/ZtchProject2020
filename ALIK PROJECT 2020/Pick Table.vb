Public Class Pick_Table
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckedListBox1.CheckedItems.Count > 0 Then
            For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
                ListBox1.Items.Add(CheckedListBox1.CheckedItems(i))
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Sent... Kindly proceed to the Choice of Table and have a seat")
    End Sub
End Class