Imports MySql.Data.MySqlClient
Module CustomerModule
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public n As Integer
    Public con As New MySql.Data.MySqlClient.MySqlConnection
    Public currentOrderTotal As Double
    Public orderid As Integer
    Public customer As Integer

    Public Sub PopulateListView(Ls As ListView, sql As String)

        cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader


        Dim columns As Integer, i As Integer
        Ls.Clear()
        If reader.HasRows Then

            n = 0
            columns = reader.FieldCount
            Do While reader.Read()
                Ls.Items.Add(n + 1)
                For i = 0 To columns - 1
                    Ls.Items(n).SubItems.Add(reader(i))


                Next
                n += 1
            Loop

            ' We have set listview properties
            Ls.View = View.Details
            Ls.GridLines = True
            Ls.FullRowSelect = True
            Ls.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

            'setting column header

            Ls.Columns.Add("SN")
            For i = 0 To columns - 1
                Ls.Columns.Add(reader.GetName(i))
            Next
        Else
            MessageBox.Show("Nothing to show at this time")
        End If


        reader.Close()

    End Sub

    ' Sub procedure to open a connection to the database
    Public Sub Connect()
        Dim ConString As String
        ConString = "server=localhost;uid=root;pwd=;database=alik_db"

        Try
            con.ConnectionString = ConString
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Module


