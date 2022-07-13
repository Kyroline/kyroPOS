Imports MySql.Data.MySqlClient
Public Class formMain
    Dim dbDetail As String = "server=localhost;userid=root;password=;database=cashier_app"
    Dim aUser As String = ""
    Dim aName As String = ""
    Dim aType As Integer = -1
    Dim totalCart As Integer = 0
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabMain.Appearance = TabAppearance.FlatButtons
        tabMain.ItemSize = New Size(0, 1)
        tabMain.SizeMode = TabSizeMode.Fixed
        changeType()
        ListView1.Items.Clear()
        RefreshReport()
        refreshProductList()
        RefreshTransaction()
    End Sub
    Private Sub PrintHistory(ByVal id As Integer)
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        formPrintTransaction.Visible = True
        formPrintTransaction.textPrint.Text = "TRANSAKSI PEMBELIAN"
        formPrintTransaction.textPrint.AppendText(Environment.NewLine)
        Try
            dbConn.Open()
            Dim sQuery As String = "SELECT * FROM purchase_history WHERE purchase_id = @pID"
            Dim history(6) As String
            Using sqlCommand = New MySqlCommand(sQuery, dbConn)
                sqlCommand.Parameters.AddWithValue("@pID", id)
                Using da = New MySqlDataAdapter(sqlCommand)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        Dim index As Integer = 0
                        For Each col As DataColumn In dt.Columns
                            history(index) = row(col)
                            index += 1
                        Next
                    Next
                End Using
                formPrintTransaction.textPrint.Text += "Transaction ID : " + history(0)
                formPrintTransaction.textPrint.AppendText(Environment.NewLine)
                formPrintTransaction.textPrint.Text += "Transaction Date : " + history(1)
                formPrintTransaction.textPrint.AppendText(Environment.NewLine)
                formPrintTransaction.textPrint.Text += "Customer Name : " + history(2)
                formPrintTransaction.textPrint.AppendText(Environment.NewLine)
                formPrintTransaction.textPrint.Text += "Cashier Name : " + history(3)
                formPrintTransaction.textPrint.AppendText(Environment.NewLine)
            End Using
            formPrintTransaction.textPrint.Text += "PRODUCT | PRICE | Q | TOTAL "
            formPrintTransaction.textPrint.AppendText(Environment.NewLine)
            Dim aQuery As String = "SELECT purchased_name, purchased_price, purchased_qty, purchased_total
                                    FROM purchased_product 
                                    WHERE purchase_id = @pID"
            Using sqlCommand = New MySqlCommand(aQuery, dbConn)
                sqlCommand.Parameters.AddWithValue("@pID", id)
                Using da = New MySqlDataAdapter(sqlCommand)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        Dim index As Integer = 0
                        Dim products(3) As String
                        For Each col As DataColumn In dt.Columns
                            products(index) = row(col)
                            index += 1
                        Next
                        formPrintTransaction.textPrint.Text += products(0) + " | "
                        formPrintTransaction.textPrint.Text += products(1) + " | "
                        formPrintTransaction.textPrint.Text += products(2) + " | "
                        formPrintTransaction.textPrint.Text += products(3) + " | "
                        formPrintTransaction.textPrint.AppendText(Environment.NewLine)
                    Next
                End Using
            End Using
            formPrintTransaction.textPrint.Text += "Total : Rp" + history(4)
            formPrintTransaction.textPrint.AppendText(Environment.NewLine)
            formPrintTransaction.textPrint.Text += "Paid : Rp" + history(5)
            formPrintTransaction.textPrint.AppendText(Environment.NewLine)
            formPrintTransaction.textPrint.Text += "Change : Rp" + history(6)
            formPrintTransaction.textPrint.AppendText(Environment.NewLine)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub
    Private Sub RefreshTransactionPrice()
        Dim allItems(listBuyProductCart.Items.Count - 1) As ListViewItem
        listBuyProductCart.Items.CopyTo(allItems, 0)
        Dim total As Double = 0
        ' To iterate
        For Each r In allItems
            ' Row is r.index
            total += Convert.ToDouble(r.SubItems(3).Text)
            'For Each c In r.SubItems
            ' Text in each column is c.Text
            'Next
        Next
        textBuyProductTotalPaid.Text = total
    End Sub
    Private Sub RefreshTransaction()
        textTransactionPurchaseID.Enabled = False
        textTransactionCashierName.Enabled = False
        textTransactionCashierName.Text = aName
        Dim dbConn As MySqlConnection = Nothing
        Dim query As String = "SELECT AUTO_INCREMENT
                               FROM information_schema.TABLES
                               WHERE TABLE_SCHEMA = 'cashier_app'
                               AND TABLE_NAME = 'purchase_history'"
        Try
            dbConn = New MySqlConnection(dbDetail)
            dbConn.Open()
            Dim myCmd As New MySqlCommand(query, dbConn)
            Dim da As New MySqlDataAdapter(myCmd)
            Dim ds As New DataSet()
            da.Fill(ds, "purchase_history")
            Dim dt As DataTable = ds.Tables("purchase_history")
            For Each row As DataRow In dt.Rows
                Dim item(0) As String
                Dim index As Integer = 0
                For Each col As DataColumn In dt.Columns
                    item(index) = row(col).ToString()
                Next
                textTransactionPurchaseID.Text = item(0)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    Public Sub changeType()
        If (aType = -1) Then 'hasn't logged on
            tabMain.TabPages.Remove(tabReport)
            tabMain.TabPages.Remove(tabTransaction)
            tabMain.TabPages.Remove(tabStock)
            tabMain.TabPages.Remove(tabStockAdd)
            tabMain.TabPages.Remove(tabStockModify)
            tabMain.TabPages.Remove(tabAccount)
            tabMain.TabPages.Remove(tabLogin)
            buttonReport.Enabled = False
            buttonTransaction.Enabled = False
            buttonStock.Enabled = False
            buttonStockAdd.Enabled = False
            buttonStockModify.Enabled = False
            buttonAccountMan.Enabled = False
            buttonAccount.Enabled = False
            tabMain.TabPages.Insert(0, tabLogin)
            tabMain.SelectedTab = tabLogin
            labelTitle.Text = "LOGIN"
        ElseIf (aType = 0) Then 'admin
            tabMain.TabPages.Remove(tabReport)
            tabMain.TabPages.Remove(tabTransaction)
            tabMain.TabPages.Remove(tabStock)
            tabMain.TabPages.Remove(tabStockAdd)
            tabMain.TabPages.Remove(tabStockModify)
            tabMain.TabPages.Remove(tabAccountMan)
            tabMain.TabPages.Remove(tabAccount)
            tabMain.TabPages.Remove(tabLogin)
            buttonReport.Enabled = True
            buttonTransaction.Enabled = True
            buttonStock.Enabled = True
            buttonStockAdd.Enabled = True
            buttonStockModify.Enabled = True
            buttonAccountMan.Enabled = True
            buttonAccount.Enabled = True
            tabMain.TabPages.Insert(0, tabReport)
            tabMain.TabPages.Insert(1, tabTransaction)
            tabMain.TabPages.Insert(2, tabStock)
            tabMain.TabPages.Insert(3, tabStockAdd)
            tabMain.TabPages.Insert(4, tabStockModify)
            tabMain.TabPages.Insert(5, tabAccountMan)
            tabMain.TabPages.Insert(6, tabAccount)
            tabMain.SelectedTab = tabReport
            labelTitle.Text = "Report"
        ElseIf (aType = 1) Then 'employee
            tabMain.TabPages.Remove(tabReport)
            tabMain.TabPages.Remove(tabTransaction)
            tabMain.TabPages.Remove(tabStock)
            tabMain.TabPages.Remove(tabStockAdd)
            tabMain.TabPages.Remove(tabStockModify)
            tabMain.TabPages.Remove(tabAccountMan)
            tabMain.TabPages.Remove(tabAccount)
            tabMain.TabPages.Remove(tabLogin)
            buttonReport.Enabled = False
            buttonTransaction.Enabled = True
            buttonStock.Enabled = False
            buttonStockAdd.Enabled = False
            buttonStockModify.Enabled = False
            buttonAccountMan.Enabled = False
            buttonAccount.Enabled = True
            tabMain.TabPages.Insert(0, tabTransaction)
            tabMain.TabPages.Insert(1, tabAccount)
            tabMain.SelectedTab = tabTransaction
            labelTitle.Text = "TRANSACTION"
        End If
    End Sub
    Private Sub InitTransaction()

    End Sub
    Public Sub refreshProductList()
        ListView1.Items.Clear()
        Dim dbConn As MySqlConnection = Nothing
        Dim total As Integer = 0
        Dim empty As Integer = 0
        Try
            dbConn = New MySqlConnection(dbDetail)
            dbConn.Open()

            Dim query As String = "SELECT * FROM product_stock"
            Dim da As New MySqlDataAdapter(query, dbConn)
            Dim ds As New DataSet()
            da.Fill(ds, "product_stock")
            Dim dt As DataTable = ds.Tables("product_stock")
            For Each row As DataRow In dt.Rows
                Dim item(4) As String
                Dim index As Integer = 0
                For Each col As DataColumn In dt.Columns
                    item(index) = row(col).ToString()
                    index += 1
                Next
                total += 1
                Dim otherItems As String() = {item(1), "Rp" + item(2) + ",-", item(3), item(4)}
                If item(4) = "0" Then
                    empty += 1
                End If
                Me.ListView1.Items.Add(item(0)).SubItems.AddRange(otherItems)
            Next
        Catch ex As Exception
        Finally
            buttonProductTotal.Text = "Total Product : " + total.ToString
            buttonProductEmpty.Text = "Empty Product : " + empty.ToString
            dbConn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        formEditProduct.Show()
    End Sub

    Private Sub textPassword_TextChanged(sender As Object, e As EventArgs) Handles textboxPassword.TextChanged

    End Sub
    Private Sub refresh2()
        ListView1.Items.Clear()
        Dim dbConn As MySqlConnection = Nothing
        Dim total As Integer = 0
        Dim empty As Integer = 0
        Dim query As String = "SELECT * FROM product_stock"
        Select Case comboStockOrderBy.SelectedIndex
            Case 0
                query += " ORDER BY product_id"
            Case 1
                query += " ORDER BY product_name"
            Case 2
                query += " ORDER BY product_price"
            Case 3
                query += " ORDER BY product_barcode"
            Case 4
                query += " ORDER BY product_stock"
        End Select
        Select Case comboStockDASC.SelectedIndex
            Case 0
                query += " ASC"
            Case 1
                query += " DESC"
        End Select
        Try
            dbConn = New MySqlConnection(dbDetail)
            dbConn.Open()
            Dim myCmd As New MySqlCommand(query, dbConn)
            Dim da As New MySqlDataAdapter(myCmd)
            Dim ds As New DataSet()
            da.Fill(ds, "product_stock")
            Dim dt As DataTable = ds.Tables("product_stock")
            For Each row As DataRow In dt.Rows
                Dim item(4) As String
                Dim index As Integer = 0
                For Each col As DataColumn In dt.Columns
                    item(index) = row(col).ToString()
                    index += 1
                Next
                total += 1
                Dim otherItems As String() = {item(1), "Rp" + item(2) + ",-", item(3), item(4)}
                If item(4) = "0" Then
                    empty += 1
                End If
                Me.ListView1.Items.Add(item(0)).SubItems.AddRange(otherItems)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            buttonProductTotal.Text = "Total Product : " + total.ToString
            buttonProductEmpty.Text = "Empty Product : " + empty.ToString
            dbConn.Close()
        End Try
    End Sub
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim dbConn As MySqlConnection = Nothing
        Try
            dbConn = New MySqlConnection(dbDetail)
            dbConn.Open()
            Dim query As String = "SELECT * FROM account WHERE user_id = '" + textboxUserID.Text + "'"
            Dim da As New MySqlDataAdapter(query, dbConn)
            Dim ds As New DataSet()
            da.Fill(ds, "account")
            Dim dt As DataTable = ds.Tables("account")
            For Each row As DataRow In dt.Rows
                Dim item(4) As String
                Dim index As Integer = 0
                For Each col As DataColumn In dt.Columns
                    item(index) = row(col).ToString()
                    index += 1
                Next
                If item(0) = "" Then
                    labelLoginError.Text = "User credentials doesn't match the existing ones"
                    labelLoginError.Visible = True
                Else
                    If (textboxPassword.Text = item(1)) Then
                        aUser = item(0)
                        aName = item(2)
                        aType = CType(item(3), Integer)
                        MsgBox("Login Successful!")
                        changeType()
                        labelLoginError.Visible = False
                    Else
                        labelLoginError.Text = "Incorrect password"
                        labelLoginError.Visible = True
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
            textboxUserID.Text = ""
            textboxPassword.Text = ""
            RefreshTransaction()
        End Try
        Try
            dbConn.Open()
            'INSERTING TO PURCHASE HISTORY
            Using sqlCommand As New MySqlCommand
                With sqlCommand
                    .CommandText = "UPDATE `account` SET `last_login` = @pDate WHERE `account`.`user_id` = @pName"
                    .Connection = dbConn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@pDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    .Parameters.AddWithValue("@pName", aUser)
                End With
                sqlCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tabAccount_Click(sender As Object, e As EventArgs) Handles tabAccount.Click

    End Sub

    Private Sub panelMain_Paint(sender As Object, e As PaintEventArgs) Handles panelMain.Paint

    End Sub

    Private Sub buttonReport_Click(sender As Object, e As EventArgs) Handles buttonReport.Click
        tabMain.SelectedTab = tabReport
        labelTitle.Text = "Report"
    End Sub

    Private Sub buttonTransaction_Click(sender As Object, e As EventArgs) Handles buttonTransaction.Click
        tabMain.SelectedTab = tabTransaction
        labelTitle.Text = "Transaction"
    End Sub

    Private Sub buttonStock_Click(sender As Object, e As EventArgs) Handles buttonStock.Click
        tabMain.SelectedTab = tabStock
        labelTitle.Text = "Stock"
    End Sub

    Private Sub buttonAccountMan_Click(sender As Object, e As EventArgs) Handles buttonAccountMan.Click
        tabMain.SelectedTab = tabAccountMan
        RefreshAccount()
        labelTitle.Text = "Account Management"
    End Sub

    Private Sub buttonAccount_Click(sender As Object, e As EventArgs) Handles buttonAccount.Click
        tabMain.SelectedTab = tabAccount
        labelName.Text = aName
        labelTitle.Text = "Account"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles tabStockAdd.Click

    End Sub

    Private Sub buttonAddStock_Click(sender As Object, e As EventArgs) Handles buttonStockAdd.Click
        tabMain.SelectedTab = tabStockAdd
        labelTitle.Text = "Add Stock"
    End Sub

    Private Sub buttonStockModify_Click(sender As Object, e As EventArgs) Handles buttonStockModify.Click
        tabMain.SelectedTab = tabStockModify
        labelTitle.Text = "Modify Stock"
    End Sub

    Private Sub buttonAddProductSubmit_Click(sender As Object, e As EventArgs) Handles buttonAddProductSubmit.Click
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Try
            dbConn.Open()
            With sqlCommand
                .CommandText = "INSERT INTO `product_stock` (`product_name`, `product_price`, `product_barcode`, `product_stock`) 
                                VALUES(@pName, @pPrice, @pBarcode, @pStock)"
                .Connection = dbConn
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@pName", textAddProductName.Text)
                .Parameters.AddWithValue("@pPrice", textAddProductPrice.Text)
                .Parameters.AddWithValue("@pBarcode", textAddProductBarcode.Text)
                .Parameters.AddWithValue("@pStock", textAddProductStock.Text)
            End With
            myAdapter.SelectCommand = sqlCommand
            sqlCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
        refreshProductList()
        textAddProductName.Text = ""
        textAddProductPrice.Text = ""
        textAddProductBarcode.Text = ""
        textAddProductStock.Text = ""
    End Sub

    Private Sub buttonModifyProductSubmit_Click(sender As Object, e As EventArgs) Handles buttonModifyProductSubmit.Click
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        If comboboxModifyProductSearch.SelectedIndex = 0 Then
            Try
                dbConn.Open()
                With sqlCommand
                    .CommandText = "UPDATE product_stock 
                                SET product_name = @pName, product_price = @pPrice, product_barcode = @pBarcode, product_stock = @pStock
                                WHERE product_id = @pID"
                    .Connection = dbConn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@pName", textModifyProductName.Text)
                    .Parameters.AddWithValue("@pPrice", textModifyProductPrice.Text)
                    .Parameters.AddWithValue("@pBarcode", textModifyProductBarcode.Text)
                    .Parameters.AddWithValue("@pStock", textModifyProductStock.Text)
                    .Parameters.AddWithValue("@pID", textModifyProductSearch.Text)
                End With
                myAdapter.SelectCommand = sqlCommand
                sqlCommand.ExecuteNonQuery()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                dbConn.Close()
            End Try
            refreshProductList()
        Else
            Try
                dbConn.Open()
                With sqlCommand
                    .CommandText = "UPDATE product_stock 
                                SET product_name = @pName, product_price = @pPrice, product_barcode = @pBarcode, product_stock = @pStock
                                WHERE product_barcode = @pBarcode"
                    .Connection = dbConn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@pName", textModifyProductName.Text)
                    .Parameters.AddWithValue("@pPrice", textModifyProductPrice.Text)
                    .Parameters.AddWithValue("@pBarcode", textModifyProductBarcode.Text)
                    .Parameters.AddWithValue("@pStock", textModifyProductStock.Text)
                    .Parameters.AddWithValue("@pBarcode", textModifyProductSearch.Text)
                End With
                myAdapter.SelectCommand = sqlCommand
                sqlCommand.ExecuteNonQuery()
            Catch ex As MySqlException
            Finally
                dbConn.Close()
            End Try
            refreshProductList()
        End If

    End Sub

    Private Sub textModifyProductSearch_TextChanged(sender As Object, e As EventArgs) Handles textModifyProductSearch.TextChanged
        Dim dbConn As MySqlConnection = Nothing
        textModifyProductName.Text = ""
        textModifyProductPrice.Text = ""
        textModifyProductBarcode.Text = ""
        textModifyProductStock.Text = ""
        Try
            dbConn = New MySqlConnection(dbDetail)
            dbConn.Open()
            Dim query As String
            If comboboxModifyProductSearch.SelectedIndex = 0 Then
                query = "SELECT * FROM product_stock WHERE product_id = " + textModifyProductSearch.Text
            Else
                query = "SELECT * FROM product_stock WHERE product_barcode = " + textModifyProductSearch.Text
            End If
            Dim da As New MySqlDataAdapter(query, dbConn)
            Dim ds As New DataSet()
            da.Fill(ds, "product_stock")
            Dim dt As DataTable = ds.Tables("product_stock")
            For Each row As DataRow In dt.Rows
                Dim item(4) As String
                Dim index As Integer = 0
                For Each col As DataColumn In dt.Columns
                    item(index) = row(col).ToString()
                    index += 1
                Next
                textModifyProductName.Text = item(1)
                textModifyProductPrice.Text = item(2)
                textModifyProductBarcode.Text = item(3)
                textModifyProductStock.Text = item(4)
            Next
        Catch ex As Exception
        Finally
            If (textModifyProductName.Text = "") Then
                labelModifyProductError.Visible = True
                labelModifyProductError.Text = "Product Not Found"
                buttonModifyProductSubmit.Enabled = False
                buttonModifyProductDelete.Enabled = False
            Else
                labelModifyProductError.Visible = False
                buttonModifyProductSubmit.Enabled = True
                buttonModifyProductDelete.Enabled = True
            End If
            dbConn.Close()
        End Try
    End Sub

    Private Sub buttonModifyProductDelete_Click(sender As Object, e As EventArgs) Handles buttonModifyProductDelete.Click
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        If comboboxModifyProductSearch.SelectedIndex = 0 Then
            Try
                dbConn.Open()
                With sqlCommand
                    .CommandText = "DELETE FROM `product_stock` 
                                WHERE product_id = @pID"
                    .Connection = dbConn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@pID", textModifyProductSearch.Text)
                End With
                myAdapter.SelectCommand = sqlCommand
                sqlCommand.ExecuteNonQuery()
            Catch ex As MySqlException
            Finally
                dbConn.Close()
            End Try
            refreshProductList()
        Else
            Try
                dbConn.Open()
                With sqlCommand
                    .CommandText = "DELETE FROM `product_stock` 
                                WHERE product_barcode = @pBarcode"
                    .Connection = dbConn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@pBarcode", textModifyProductSearch.Text)
                End With
                myAdapter.SelectCommand = sqlCommand
                sqlCommand.ExecuteNonQuery()
            Catch ex As MySqlException
            Finally
                dbConn.Close()
            End Try
            refreshProductList()
            textModifyProductName.Text = ""
            textModifyProductPrice.Text = ""
            textModifyProductBarcode.Text = ""
            textModifyProductStock.Text = ""
            textModifyProductSearch.Text = ""
        End If
    End Sub

    Private Sub tabStockModify_Click(sender As Object, e As EventArgs) Handles tabStockModify.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboAddProductSearch.SelectedIndexChanged

    End Sub

    Private Sub buttonBuyProductAdd_Click(sender As Object, e As EventArgs) Handles buttonBuyProductAdd.Click
        Dim sama As Boolean = False
        totalCart += 1
        'For i = 0 To totalCart - 1
        'If listBuyProductCart.Items(i) = listboxBuyProductName.SelectedItem Then
        'listBuyProductCart.Items(i).SubItems(1) += 1
        'sama = True
        'End If
        'Next
        If Not sama Then
            Dim otherItems As String() = {textBuyProductPrice.Text, textBuyProductQty.Text, textBuyProductTotal.Text}
            listBuyProductCart.Items.Add(listboxBuyProductName.SelectedItem).SubItems.AddRange(otherItems)
        End If
        textBuyProductQty.Text = ""
        textBuyProductPrice.Text = ""
        textBuyProductTotal.Text = ""
        RefreshTransactionPrice()
    End Sub

    Private Sub textBuyProductSearch_TextChanged(sender As Object, e As EventArgs) Handles textBuyProductSearch.TextChanged
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        textBuyProductQty.Text = ""
        textBuyProductPrice.Text = ""
        textBuyProductTotal.Text = ""
        listboxBuyProductName.Items.Clear()
        Try
            Dim query As String = "SELECT product_id, product_name, product_price, product_stock 
                                   FROM product_stock"
            Select Case comboAddProductSearch.SelectedIndex
                Case 0
                    query += " WHERE product_id = " + textBuyProductSearch.Text
                Case 1
                    query += " WHERE product_name LIKE '%" + textBuyProductSearch.Text + "%'"
                Case 2
                    query += " WHERE product_barcode = " + textBuyProductSearch.Text
            End Select
            dbConn.Open()
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
                Dim otherItems As String() = {item(1), "Rp" + item(2) + ",-", item(3)}
                listboxBuyProductName.Items.Add(item(1))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxBuyProductName.SelectedIndexChanged
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Try
            Dim query As String = "SELECT product_id, product_name, product_price, product_stock 
                                   FROM product_stock
                                   WHERE product_name LIKE '" + listboxBuyProductName.SelectedItem + "'"
            dbConn.Open()
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
                If ((item(3) = "0")) Then
                    buttonBuyProductAdd.Enabled = False
                Else
                    buttonBuyProductAdd.Enabled = True
                End If
                labelBuyProductStock.Text = item(3)
                textBuyProductPrice.Text = item(2)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub textBuyProductQty_TextChanged(sender As Object, e As EventArgs) Handles textBuyProductQty.TextChanged
        If Not textBuyProductQty.Text = "" Then
            If Convert.ToInt32(labelBuyProductStock.Text) < Convert.ToInt32(textBuyProductQty.Text) Then
                buttonBuyProductAdd.Enabled = False
            Else
                buttonBuyProductAdd.Enabled = True
            End If
            textBuyProductTotal.Text = Convert.ToDecimal(textBuyProductPrice.Text) * Convert.ToInt32(textBuyProductQty.Text)
        End If
    End Sub

    Private Sub listBuyProductCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBuyProductCart.SelectedIndexChanged

    End Sub

    Private Sub buttonBuyProductRemove_Click(sender As Object, e As EventArgs) Handles buttonBuyProductRemove.Click

        For Each i As ListViewItem In listBuyProductCart.SelectedItems
            listBuyProductCart.Items.Remove(i)
            RefreshTransactionPrice()
            GoTo Here
        Next
Here:
    End Sub

    Private Sub buttonProductEmpty_Click(sender As Object, e As EventArgs) Handles buttonProductEmpty.Click
        ListView1.Items.Clear()
        Dim dbConn As MySqlConnection = Nothing
        Dim total As Integer = 0
        Dim empty As Integer = 0
        Try
            dbConn = New MySqlConnection(dbDetail)
            dbConn.Open()

            Dim query As String = "SELECT * FROM product_stock WHERE product_stock = 0"
            Dim da As New MySqlDataAdapter(query, dbConn)
            Dim ds As New DataSet()
            da.Fill(ds, "product_stock")
            Dim dt As DataTable = ds.Tables("product_stock")
            For Each row As DataRow In dt.Rows
                Dim item(4) As String
                Dim index As Integer = 0
                For Each col As DataColumn In dt.Columns
                    item(index) = row(col).ToString()
                    index += 1
                Next
                total += 1
                Dim otherItems As String() = {item(1), "Rp" + item(2) + ",-", item(3), item(4)}
                If item(4) = "0" Then
                    empty += 1
                End If
                Me.ListView1.Items.Add(item(0)).SubItems.AddRange(otherItems)
            Next
        Catch ex As Exception
        Finally
            buttonProductTotal.Text = "Total Product : " + total.ToString
            buttonProductEmpty.Text = "Empty Product : " + empty.ToString
            dbConn.Close()
        End Try
    End Sub

    Private Sub buttonBuyProductConfirm_Click(sender As Object, e As EventArgs) Handles buttonBuyProductConfirm.Click
        Dim allItems(listBuyProductCart.Items.Count - 1) As ListViewItem
        listBuyProductCart.Items.CopyTo(allItems, 0)
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Try
            dbConn.Open()
            'INSERTING TO PURCHASE HISTORY
            Using sqlCommand As New MySqlCommand
                With sqlCommand
                    .CommandText = "INSERT INTO `purchase_history` (`purchase_date`, `customer_name`, `cashier_name`, `purchase_price`, `purchase_paid`, `purchase_change`) 
                                VALUES(@pDate, @pCuName, @pCaName, @pPrice, @pPaid, @pChange)"
                    .Connection = dbConn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@pDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    .Parameters.AddWithValue("@pCuName", textTransactionCustomerName.Text)
                    .Parameters.AddWithValue("@pCaName", textTransactionCashierName.Text)
                    .Parameters.AddWithValue("@pPrice", textBuyProductTotalPaid.Text)
                    .Parameters.AddWithValue("@pPaid", textBuyProductPaid.Text)
                    .Parameters.AddWithValue("@pChange", textBuyProductChange.Text)
                End With
                sqlCommand.ExecuteNonQuery()
            End Using

            'INSERTING TO PURCHASED PRODUCT
            ' To iterate
            For Each r In allItems
                Using sqlCommand As New MySqlCommand
                    With sqlCommand
                        .CommandText = "INSERT INTO `purchased_product` (`purchase_id`, `purchased_name`, `purchased_price`, `purchased_qty`, `purchased_total`) 
                                VALUES(@pID, @pName, @pPrice, @pQty, @pTotal)"
                        .Connection = dbConn
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@pID", textTransactionPurchaseID.Text)
                        .Parameters.AddWithValue("@pName", r.Text)
                        .Parameters.AddWithValue("@pPrice", r.SubItems(1).Text)
                        .Parameters.AddWithValue("@pQty", r.SubItems(2).Text)
                        .Parameters.AddWithValue("@pTotal", r.SubItems(3).Text)
                    End With
                    sqlCommand.ExecuteNonQuery()
                End Using
                'PRINT HISTORY
                Using sqlCommand As New MySqlCommand
                    With sqlCommand
                        .CommandText = "UPDATE product_stock 
                                        SET product_stock = product_stock - @pQty
                                        WHERE product_name LIKE @pName"
                        .Connection = dbConn
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@pName", r.Text)
                        .Parameters.AddWithValue("@pQty", r.SubItems(2).Text)
                    End With
                    sqlCommand.ExecuteNonQuery()
                End Using
            Next
            PrintHistory(Convert.ToInt32(textTransactionPurchaseID.Text))
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
        refreshProductList()
        refresh2()
        RefreshTransaction()
        RefreshReport()
        listBuyProductCart.Items.Clear()
        textBuyProductChange.Text = ""
        textBuyProductPaid.Text = ""
        textBuyProductTotalPaid.Text = ""
    End Sub

    Private Sub buttonAddAccountSubmit_Click(sender As Object, e As EventArgs) Handles buttonAddAccountSubmit.Click
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Try
            dbConn.Open()
            With sqlCommand
                .CommandText = "INSERT INTO `account` (`user_id`, `user_password`, `user_owner`, `user_type`) 
                                VALUES(@pID, @pPass, @pOwner, @pType)"
                .Connection = dbConn
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@pID", textAddAccountID.Text)
                .Parameters.AddWithValue("@pPass", textAddAccountPassword.Text)
                .Parameters.AddWithValue("@pOwner", textAddAccountName.Text)
                .Parameters.AddWithValue("@pType", comboAddAccountType.SelectedIndex)
            End With
            myAdapter.SelectCommand = sqlCommand
            sqlCommand.ExecuteNonQuery()
            textAddAccountName.Text = ""
            textAddAccountID.Text = ""
            textAddAccountPassword.Text = ""
            comboAddAccountType.SelectedIndex = -1
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            dbConn.Close()

        End Try
    End Sub

    Private Sub buttonAccountAdd_Click(sender As Object, e As EventArgs)
        tabMain.SelectedTab = tabAccountAdd
    End Sub

    Private Sub buttonAccountModify_Click(sender As Object, e As EventArgs) Handles buttonAccountModify.Click
        tabMain.SelectedTab = tabAccountModify
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        If ListView3.SelectedItems.Count > 0 Then
            Try
                Dim aQuery As String = "SELECT user_id, user_password, user_owner, user_type
                                    FROM account 
                                    WHERE user_id = @pID"
                Using sqlCommand = New MySqlCommand(aQuery, dbConn)
                    sqlCommand.Parameters.AddWithValue("@pID", ListView3.SelectedItems(0).Text)
                    Using da = New MySqlDataAdapter(sqlCommand)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        For Each row As DataRow In dt.Rows
                            Dim index As Integer = 0
                            Dim account(3) As String
                            For Each col As DataColumn In dt.Columns
                                account(index) = row(col)
                                index += 1
                            Next
                            textAccountModifyID.Text = account(0)
                            textAccountModifyPassword.Text = account(1)
                            textAccountModifyOwner.Text = account(2)
                            textAccountModifyType.SelectedIndex = Convert.ToInt32(account(3))
                        Next
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub buttonAccountLogout_Click(sender As Object, e As EventArgs) Handles buttonAccountLogout.Click
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Try
            dbConn.Open()
            'INSERTING TO PURCHASE HISTORY
            Using sqlCommand As New MySqlCommand
                With sqlCommand
                    .CommandText = "UPDATE `account` SET `last_login` = @pDate WHERE `account`.`user_id` = @pName"
                    .Connection = dbConn
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@pDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    .Parameters.AddWithValue("@pName", aUser)
                End With
                sqlCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
        aUser = ""
        aName = ""
        aType = -1
        changeType()
    End Sub

    Private Sub textBuyProductPaid_TextChanged(sender As Object, e As EventArgs) Handles textBuyProductPaid.TextChanged
        If (Not textBuyProductPaid.Text = "") Then
            Dim total As Double = Convert.ToDouble(textBuyProductTotalPaid.Text)
            Dim paid As Double = Convert.ToDouble(textBuyProductPaid.Text)
            textBuyProductChange.Text = paid - total
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles buttonReportView.Click
        ListView2.Items.Clear()
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Try
            dbConn.Open()
            Dim sQuery As String = "SELECT * FROM purchase_history"
            'WHERE Date(purchase_date) = @pDate 
            '     AND Month(purchase_date) = @pMonth 
            '     AND Year(purchase_date) = @pYear"
            Using sqlCommand = New MySqlCommand(sQuery, dbConn)
                'sqlCommand.Parameters.AddWithValue("@pDate", textReportDate.Text)
                'sqlCommand.Parameters.AddWithValue("@pMonth", comboReportMonth.SelectedIndex)
                'sqlCommand.Parameters.AddWithValue("@pYear", textReportYear.Text)
                Using da = New MySqlDataAdapter(sqlCommand)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        Dim item(6) As String
                        Dim index As Integer = 0
                        For Each col As DataColumn In dt.Columns
                            item(index) = row(col).ToString()
                            index += 1
                        Next
                        Dim otherItems As String() = {item(1), item(2), item(3)}
                        ListView2.Items.Add(item(0)).SubItems.AddRange(otherItems)
                    Next
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub buttonReportDetails_Click(sender As Object, e As EventArgs) Handles buttonReportDetails.Click
        PrintHistory(Convert.ToInt32(ListView2.SelectedItems(0).Text))
    End Sub

    Private Sub RefreshReport()
        Dim dbConn As MySqlConnection = Nothing
        Dim incomeToday As Double = 0
        Dim customerToday As Integer = 0
        Dim income As Double = 0
        Dim customer As Integer = 0
        dbConn = New MySqlConnection(dbDetail)
        Try
            dbConn.Open()
            Dim sQuery As String = "SELECT * FROM purchase_history WHERE purchase_date BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 10 DAY)" ' BETWEEN Date() And DATEADD('d', 1, DATE())"
            Using sqlCommand = New MySqlCommand(sQuery, dbConn)
                'sqlCommand.Parameters.AddWithValue("@pDT", DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss"))
                Using da = New MySqlDataAdapter(sqlCommand)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        Dim item(6) As String
                        Dim index As Integer = 0
                        For Each col As DataColumn In dt.Columns
                            item(index) = row(col).ToString()
                            index += 1
                        Next
                        incomeToday += Convert.ToDouble(item(4))
                        customerToday += 1
                    Next
                End Using
            End Using
            Dim aQuery As String = "SELECT * FROM purchase_history"
            Using sqlCommand = New MySqlCommand(aQuery, dbConn)
                Using da = New MySqlDataAdapter(sqlCommand)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        Dim item(6) As String
                        Dim index As Integer = 0
                        For Each col As DataColumn In dt.Columns
                            item(index) = row(col).ToString()
                            index += 1
                        Next
                        income += Convert.ToDouble(item(4))
                        customer += 1
                    Next
                End Using
            End Using
            Button2.Text = "Income Today : " + incomeToday.ToString
            Button3.Text = "Customer Today : " + customerToday.ToString
            Button4.Text = "Income : " + income.ToString
            Button5.Text = "Customer : " + customer.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub

    Private Sub buttonAccRefresh_Click(sender As Object, e As EventArgs) Handles buttonAccRefresh.Click
        RefreshAccount()
    End Sub

    Private Sub RefreshAccount()
        ListView3.Items.Clear()
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Try
            dbConn.Open()
            Dim sQuery As String = "SELECT * FROM account"
            'WHERE Date(purchase_date) = @pDate 
            '     AND Month(purchase_date) = @pMonth 
            '     AND Year(purchase_date) = @pYear"
            Using sqlCommand = New MySqlCommand(sQuery, dbConn)
                'sqlCommand.Parameters.AddWithValue("@pDate", textReportDate.Text)
                'sqlCommand.Parameters.AddWithValue("@pMonth", comboReportMonth.SelectedIndex)
                'sqlCommand.Parameters.AddWithValue("@pYear", textReportYear.Text)
                Using da = New MySqlDataAdapter(sqlCommand)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        Dim item(4) As String
                        Dim index As Integer = 0
                        For Each col As DataColumn In dt.Columns
                            item(index) = row(col).ToString()
                            index += 1
                        Next
                        Dim otherItems As String() = {item(2), IIf(Convert.ToInt32(item(3)), "Employee", "Admin"), item(4)}
                        ListView3.Items.Add(item(0)).SubItems.AddRange(otherItems)
                    Next
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dbConn As MySqlConnection = Nothing
        dbConn = New MySqlConnection(dbDetail)
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Try
            dbConn.Open()
            With sqlCommand
                .CommandText = "UPDATE `account` 
                                SET `user_password` = @pPass, `user_owner` = @pOwner, `user_type` = @pType
                                WHERE `account`.`user_id` = @pID"
                .Connection = dbConn
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@pPass", textAccountModifyPassword.Text)
                .Parameters.AddWithValue("@pOwner", textAccountModifyOwner.Text)
                .Parameters.AddWithValue("@pType", textAccountModifyType.SelectedIndex)
                .Parameters.AddWithValue("@pID", textAccountModifyID.Text)
            End With
            sqlCommand.ExecuteNonQuery()
            textAccountModifyID.Text = ""
            textAccountModifyOwner.Text = ""
            textAccountModifyPassword.Text = ""
            textAccountModifyType.SelectedIndex = -1
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
End Class
