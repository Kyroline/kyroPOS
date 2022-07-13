Imports MySql.Data.MySqlClient

Public Class formEditProduct
    Dim dbDetail As String = "server=localhost;userid=root;password=;database=cashier_app"
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textboxID.TextChanged
        buttonCondition()
        textboxOldName.Clear()
        textboxOldPrice.Clear()
        textboxOldStock.Clear()
        If textboxID.Text = "" Then
            labelError.Text = "Product ID Cannot Be Empty"
            labelError.Visible = True
            buttonSubmit.Enabled = False
        Else
            labelError.Visible = False
        End If
        Dim dbConn As MySqlConnection = Nothing
        Try
            dbConn = New MySqlConnection(dbDetail)
            dbConn.Open()

            Dim query As String = "SELECT * FROM product_stock WHERE product_id =" + textboxID.Text
            Dim da As New MySqlDataAdapter(query, dbConn)
            Dim ds As New DataSet()
            da.Fill(ds, "product_stock")
            Dim dt As DataTable = ds.Tables("product_stock")
            For Each row As DataRow In dt.Rows
                Dim item(3) As String
                Dim index As Integer = 0
                For Each col As DataColumn In dt.Columns
                    item(index) = row(col).ToString()
                    index += 1
                Next
                textboxOldName.Text = item(1)
                textboxOldPrice.Text = item(2)
                textboxOldStock.Text = item(3)
            Next
            If textboxOldName.Text = "" Then
                labelError.Text = "Product Not Found"
                labelError.Visible = True
                buttonSubmit.Enabled = False
            Else
                labelError.Text = "Product Not Found"
                labelError.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        If textboxNewName.Text = "" Then
            textboxNewName.Text = textboxOldName.Text
        End If
        If textboxNewPrice.Text = "" Then
            textboxNewPrice.Text = textboxOldPrice.Text
        End If
        If textboxNewStock.Text = "" Then
            textboxNewStock.Text = textboxOldStock.Text
        End If
        Try
            dbConn.Open()
            With sqlCommand
                .CommandText = "UPDATE product_stock 
                                SET product_name = @pName, product_price = @pPrice, product_stock = @pStock
                                WHERE product_id = @pID"
                .Connection = dbConn
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@pName", textboxNewName.Text)
                .Parameters.AddWithValue("@pPrice", textboxNewPrice.Text)
                .Parameters.AddWithValue("@pStock", textboxNewStock.Text)
                .Parameters.AddWithValue("@pID", textboxID.Text)
            End With
            myAdapter.SelectCommand = sqlCommand
            sqlCommand.ExecuteNonQuery()
        Catch ex As MySqlException
        Finally
            dbConn.Close()
        End Try
        formMain.refreshProductList()
    End Sub

    Private Sub textboxNewStock_TextChanged(sender As Object, e As EventArgs) Handles textboxNewStock.TextChanged
        buttonCondition()
        If System.Text.RegularExpressions.Regex.IsMatch(textboxNewStock.Text, "^[a-zA-Z ]*$") Then
            labelErrorStock.Visible = True
            labelErrorStock.Text = "Numbers Only!"
            buttonSubmit.Enabled = False
        Else
            labelErrorStock.Visible = False
        End If
    End Sub

    Private Sub textboxNewPrice_TextChanged(sender As Object, e As EventArgs) Handles textboxNewPrice.TextChanged
        buttonCondition()
        If System.Text.RegularExpressions.Regex.IsMatch(textboxNewPrice.Text, "^[a-zA-Z ]*$") Then
            labelErrorPrice.Visible = True
            labelErrorPrice.Text = "Numbers Only!"
            buttonSubmit.Enabled = False
        Else
            labelErrorPrice.Visible = False
        End If
    End Sub

    Private Sub textboxNewName_TextChanged(sender As Object, e As EventArgs) Handles textboxNewName.TextChanged
        buttonCondition()
    End Sub

    Private Sub buttonCondition()
        If textboxID.Text = "" Or textboxNewName.Text = "" Or textboxNewPrice.Text = "" Or textboxNewStock.Text = "" Then
            buttonSubmit.Enabled = False
        Else
            buttonSubmit.Enabled = True
        End If
    End Sub

    Private Sub formEditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonSubmit.Enabled = False
    End Sub
End Class