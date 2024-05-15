Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization
Public Class UserControl1
    'Dim todayDate As DateTime = DateTime.Today
    'Dim dateString As String = todayDate.ToString("MM/dd/yyyy")

    Dim Documentation As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Carl\Documents\Documentation.accdb"

    Dim todayDate = Today
    Dim nowDateTime = TimeOfDay
    Dim paymentMethod As String = ""
    Dim amount As String = ""
    Public Property User As String
    '--------------------- Transaction Details
    Dim tags As String = ""

    Dim itemsTransaction As String = ""
    Dim QtyTransaction As String = ""
    Private Sub QtyPileUP()
        Form1.SalesReceiptDetails_datagrid.Rows.Clear()
        QtyTransaction = ""
        For Each row As DataGridViewRow In BillDataGrid.Rows
            If row.Cells(1).Value IsNot Nothing Then
                QtyTransaction &= row.Cells(1).Value.ToString & ","
            End If
        Next
        Dim QtySeperate() As String = QtyTransaction.Split(","c)

    End Sub
    Private Sub ItemPileUp()
        itemsTransaction = ""
        For Each row As DataGridViewRow In BillDataGrid.Rows
            If row.Cells(0).Value IsNot Nothing Then
                itemsTransaction &= row.Cells(0).Value.ToString & ","
            End If
        Next
        Dim ItemSeperate() As String = itemsTransaction.Split(","c)

    End Sub

    Private Sub setTransactionIDdetials()
        Dim tagNumber(tags.Length)
        For x As Integer = 1 To tags.Length / 2
            Dim i = 1
            tagNumber(i - 1) = tags.Chars(i - 1)
            tagNumber(i) = tags.Chars(i)
            i += 2
        Next x
        For y As Integer = 0 To ((tags.Length / 2) - 1)

        Next
        tags = ""
    End Sub


    Dim mycon As New OleDbConnection(Documentation)


    '--------------------------------ALL ITEMS CLICK
    Private Sub btnClickedall(sender As Object, e As EventArgs) Handles Button1.Click, Button61.Click, Button62.Click, Button55.Click, Button56.Click, Button57.Click, Button58.Click, Button59.Click, Button60.Click, Button49.Click, Button50.Click, Button51.Click, Button52.Click, Button53.Click, Button54.Click, Button43.Click, Button44.Click, Button45.Click, Button46.Click, Button47.Click, Button48.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, Button41.Click, Button42.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button63.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button5.Click, Button6.Click, Button3.Click, Button4.Click, Button2.Click
        If TabControl1.Size = New Size(345, 367) Then
            ResetbtnotReceipt()

            txtReceipt.Clear()
            TabControl1.SelectedIndex = 0
            TabControl1.Size = New Size(345, 217)
        End If
    End Sub
    Private Sub datagridVariety_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridVariety.CellContentClick

    End Sub
    Private Sub itemClick(sender As Object, e As EventArgs) Handles datagridVariety.CellContentClick
        updatereduceStock()

        Dim mycon2 As New OleDbConnection(Documentation)
        Dim workplease = datagridVariety.SelectedRows(0).Cells(0).Value.ToString()
        TabControl1.SelectedIndex = 0
        tags &= sender.tag
        mycon2.Open()
        Dim mycmd As New OleDbCommand("Select * from listofitems where Item = '" & workplease & "'", mycon2)
        Dim myread = mycmd.ExecuteReader
        Dim PricePerItem As Integer
        Try
            If myread.Read Then
                Dim pesoSign As Char = ChrW(&H20B1)

                If myread("Price").ToString.Contains(pesoSign) Then
                    PricePerItem = Val(myread("Price").ToString.Replace(pesoSign, "").Replace(",", ""))
                End If
                btnCostandRowAdd(workplease, PricePerItem)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If mycon2.State = ConnectionState.Open Then
                mycon2.Close()
            End If
        End Try
    End Sub


    Private Sub updatereduceStock()
        Dim StocksVal = Val(datagridVariety.SelectedRows(0).Cells(1).Value.ToString)
        If StocksVal > 0 Then
            StocksVal -= 1
            datagridVariety.SelectedRows(0).Cells(1).Value = StocksVal
        Else
            MsgBox("Out of Stock")
        End If
    End Sub
    Private Sub btnCostandRowAdd(sender, price)
        Dim itemName As String = sender
        Dim existingRow As DataGridViewRow = Nothing


        For Each row As DataGridViewRow In BillDataGrid.Rows
            If row.Cells(0).Value = itemName Then
                existingRow = row
                Exit For
            End If
        Next

        If existingRow IsNot Nothing Then

            Dim quantity As Integer = CInt(existingRow.Cells(1).Value) + 1
            existingRow.Cells(1).Value = quantity
            Dim amount As Integer = quantity * price
            existingRow.Cells(2).Value = amount
        Else

            BillDataGrid.Rows.Add(itemName, 1, price)
        End If

        addCost()
        lblChange.Text = ""
    End Sub

    '---------------------------- PAY PAYYYYYYYYYYYYYYYYYYY ----------------
    Private Sub updatereduceStockv2()

        Dim mycon3 As New OleDbConnection(Documentation)
        mycon3.Open()
        Dim mycmd As New OleDbCommand("Select * from listofitems", mycon3)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        While myread.Read
            For y = 0 To (BillDataGrid.RowCount - 1)
                If Not IsDBNull(myread("Item")) AndAlso BillDataGrid.Rows(y).Cells(0).Value IsNot Nothing AndAlso BillDataGrid.Rows(y).Cells(0).Value.ToString() = myread("Item").ToString() Then
                    'System.InvalidCastException: 'Operator '=' is not defined for string "Cat Eye Cyclocomputer CC-GPS100 " and type 'DBNull'.'
                    Dim stocksDataBase = Val(myread("Quantity"))
                    stocksDataBase = stocksDataBase - Val(BillDataGrid.Rows(y).Cells(1).Value)

                    Dim updateCmd As New OleDbCommand("UPDATE listofitems SET Quantity = '" & stocksDataBase.ToString & "' WHERE Item = '" & myread("Item").ToString() & "'", mycon3)
                    updateCmd.ExecuteNonQuery()
                End If
            Next
        End While
        mycon3.Close()

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        'MsgBox(tags)
        'MsgBox(QtyTransaction)
        'MsgBox(itemsTransaction)


        If cbPayment.Text = "" Then
            MsgBox("Please select Payment Method")
        ElseIf cbPayment.Text = "Cash" Then
            '------------------- SUCCESSFUL payment -------------------------------------------
            updatereduceStockv2()
            LoadDataToListOfItemsDataGridView()

            txtReceipt.Clear()
            QtyPileUP()
            ItemPileUp()
            Dim bool As Boolean = Change()

            If bool Then
                TabControl1.SelectedIndex = 1
                btnC.Enabled = False
                receiptTab()
                insertDatatoDocumentation()

                TabControl1.Size = New Size(345, 367)
                TabControl1.BringToFront()
                MsgBox("Succesful Payment")
                ResetbtnotReceipt()
            End If

        Else
            '--------------------- SUCCEES
            updatereduceStockv2()
            LoadDataToListOfItemsDataGridView
            TabControl1.SelectedIndex = 1
            txtReceipt.Clear()
            receiptTab()
            QtyPileUP()
            ItemPileUp()
            insertDatatoDocumentation()

            TabControl1.Size = New Size(345, 367)
            TabControl1.BringToFront()
            MsgBox("Succesful Payment")
            ResetbtnotReceipt()
            TabControl1.Size = New Size(345, 367)
            TabControl1.BringToFront()
        End If

    End Sub
    '=------------------------------------ ALL CHANGES TO DOCUMENTATION
    Private Sub insertDatatoDocumentation()
        amount = lblTotal.Text
        paymentMethod = cbPayment.Text

        Try
            mycon.Open()
            ' Execute commands here
            Dim mycmd As New OleDbCommand("Insert into tblSales([Dates], [Time], [PaymentMethod], [Amount], [User]) values ('" & todayDate & "','" & nowDateTime & "','" & paymentMethod & "','" & amount & "','" & User & "')", mycon)
            mycmd.ExecuteNonQuery()

            Dim cmdValueOfID As New OleDbCommand("Select TOP 1 * from tblSales ORDER BY TRANSACTIONID DESC", mycon)
            Dim readValueLastRow As OleDbDataReader = cmdValueOfID.ExecuteReader
            Dim TransactionID As Integer
            If readValueLastRow.Read Then
                TransactionID = readValueLastRow("TransactionID")
            End If

            Dim cmdTransactionDetail As New OleDbCommand("Insert into TransactionDetails([TransactionID], [Item], [QTY]) values ('" & TransactionID & "','" & itemsTransaction & "','" & QtyTransaction & "')", mycon)
            cmdTransactionDetail.ExecuteNonQuery()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex)
            'System.ArgumentException: 'Argument 'Prompt' cannot be converted to type 'String'.'
            Exit Sub
        End Try



    End Sub
    Dim ItemName(10) As String
    Dim ItemNumber(10) As String


    Dim vbnewline As String = vbCrLf
    Private Sub receiptTab()
        'Receipt Print        

        txtReceipt.AppendText("" + vbnewline)
        txtReceipt.AppendText("SHOPPING SYSTEM" + vbnewline)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)
        txtReceipt.AppendText("Welcome to Mon's Bikeshop: Offering professional plumbing services." + vbnewline)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)
        txtReceipt.AppendText("" + vbnewline)


        For Each row As DataGridViewRow In BillDataGrid.Rows
            Dim paddedText As String = ""
            If row.Cells(0).Value IsNot Nothing Then
                paddedText = "  " & row.Cells(1).Value & " " & row.Cells(0).Value & vbTab & vbTab & vbTab & row.Cells(2).Value & vbTab & vbnewline
            End If

            txtReceipt.AppendText(paddedText)


        Next
        'Print
        txtReceipt.AppendText("" + vbnewline)
        txtReceipt.AppendText(vbTab & "Total Amount: " & vbTab & lblTotal.Text + vbnewline)
        If cbPayment.Text = "Cash" Then
            txtReceipt.AppendText(vbTab & "Change: " & vbTab & vbTab & lblChange.Text + vbnewline)
        Else
            txtReceipt.AppendText(vbTab & "Payment Method: " & vbTab & cbPayment.Text + vbnewline)
        End If


        txtReceipt.AppendText(" " & vbnewline)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)

        'txtReceipt.AppendText (txtNotes.Text + vbNewLine)

        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)
        txtReceipt.AppendText("" + vbnewline)
        txtReceipt.AppendText(vbTab & todayDate & vbTab & nowDateTime + vbnewline + vbnewline)
        txtReceipt.AppendText("= = = = = = = ")
        txtReceipt.AppendText("THANKS FOR SHOPPING")
        txtReceipt.AppendText(" = = = = = =" + vbnewline)
    End Sub


    Private Function cost_of_item()
        Dim sum As Double = 0
        Dim i As Integer = 0

        For i = 0 To BillDataGrid.Rows.Count - 1
            sum += CDbl(BillDataGrid.Rows(i).Cells(2).Value)
        Next i
        Return sum
    End Function
    Private Sub resetCash_input()
        lblCost.Text = "0"
        lblChange.Text = ""
    End Sub
    Private Sub addCost()
        If BillDataGrid.Rows.Count > 0 Then
            lblTotal.Text = FormatCurrency(cost_of_item)
            lblBarcode.Text = cost_of_item() * 968213412
        End If
    End Sub
    Private Function Change() As Boolean
        Dim cash_payment As Double
        Dim pesoSign As Char = ChrW(&H20B1)

        If lblCost.Text.Contains(pesoSign) Then
            lblCost.Text = Val(lblCost.Text.Replace(pesoSign, "").Replace(",", ""))
        End If
        cash_payment = Val(lblCost.Text)
        If (cash_payment < cost_of_item()) Then
            MsgBox("Please enter a sufficient amount of money")
            Return False
            Exit Function
        Else
            If BillDataGrid.Rows.Count > 1 Then
                lblChange.Text = FormatCurrency(cash_payment - cost_of_item())
                lblCost.Text = FormatCurrency(Val(lblCost.Text))
                Return True
            Else
                Return False
                Exit Function
            End If
        End If

    End Function

    Private Sub ResetbtnotReceipt()
        btnC.Enabled = True
        lblChange.Text = ""
        lblCost.Text = "0"
        lblTotal.Text = ""
        lblBarcode.Text = ""
        cbPayment.Text = ""
        BillDataGrid.Rows.Clear()
        BillDataGrid.Refresh()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnC.Enabled = True
        lblChange.Text = ""
        lblCost.Text = "0"
        lblTotal.Text = ""
        lblBarcode.Text = ""
        cbPayment.Text = ""
        BillDataGrid.Rows.Clear()
        BillDataGrid.Refresh()
        txtReceipt.Clear()
        TabControl1.Size = New Size(345, 217)
        TabControl1.BringToFront()
    End Sub

    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn4.Click, btn7.Click, btn3.Click, btn2.Click, btn6.Click, btn5.Click, btn9.Click, btn8.Click, btnDot.Click
        Dim b As Button = sender

        If lblCost.Text = "0" Then
            If b.Name = btnDot.Name Then
                lblCost.Text += b.Text
                btnDot.Enabled = False
                btnDot.BackColor = Color.Gainsboro
            Else
                lblCost.Text = b.Text
            End If
        ElseIf b.Text = "." Then
            lblCost.Text += b.Text
            btnDot.Enabled = False
            btnDot.BackColor = Color.Gainsboro
        Else
            lblCost.Text += b.Text
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lblCost.Text = "0"
        btnDot.Enabled = True
        btnDot.BackColor = Color.White
        lblChange.Text = ""
    End Sub
    Private Sub HOverrrr(sender As Object, e As EventArgs) Handles btn0.MouseEnter, btn1.MouseEnter, btn4.MouseEnter, btn7.MouseEnter, btnDot.MouseEnter, btn3.MouseEnter, btn2.MouseEnter, btn6.MouseEnter, btn5.MouseEnter, btn9.MouseEnter, btn8.MouseEnter, btnC.MouseEnter
        Dim b As Button = sender
        b.Cursor = Cursors.Hand
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each row As DataGridViewRow In BillDataGrid.SelectedRows
            BillDataGrid.Rows.Remove(row)
        Next
        addCost()
        If cbPayment.Text = "Cash" Then
            Change()
        End If

    End Sub







    Private bitmap As Bitmap

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 10, 10)
    End Sub

    Private Sub cbPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayment.SelectedIndexChanged
        If Not (cbPayment.Text = "Cash") Then
            resetCash_input()
            Label2.Visible = False
            Label3.Visible = False
            lblChange.Visible = False
            lblCost.Visible = False
            lblScanSwipe.Visible = True
            lblScanSwipe.ForeColor = Color.Blue
        Else
            Label2.Visible = True
            Label3.Visible = True
            lblChange.Visible = True
            lblCost.Visible = True
            lblScanSwipe.Visible = False
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim height As Integer = BillDataGrid.Height
        BillDataGrid.Height = (BillDataGrid.RowCount + 1) * BillDataGrid.RowTemplate.Height
        bitmap = New Bitmap(Me.BillDataGrid.Width, Me.BillDataGrid.Height)
        BillDataGrid.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.BillDataGrid.Width, Me.BillDataGrid.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        BillDataGrid.Height = height
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------



    Dim itemsDictionary As New Dictionary(Of String, List(Of String))()
    Dim keywords As New List(Of String) From {"chain", "chainring", "dabomb", "footpump", "maxzone", "mountainpeak", "racework"}

    ' Fetch data from the database and process it
    ' Fetch data from the database and process it
    Private Sub FetchAndProcessData()
        Using connection As New OleDbConnection(Documentation)
            connection.Open()
            Dim command As New OleDbCommand("SELECT Item, Quantity FROM ListofItems", connection) ' Include Quantity field
            Dim reader As OleDbDataReader = command.ExecuteReader()

            While reader.Read()
                Dim itemName As String = reader("Item").ToString()
                Dim quantity As Integer = If(reader("Quantity") IsNot DBNull.Value, Convert.ToInt32(reader("Quantity")), 0) ' Get quantity from database and handle DBNull
                Dim baseName As String = GetBaseName(itemName)

                If Not itemsDictionary.ContainsKey(baseName) Then
                    itemsDictionary(baseName) = New List(Of String)()
                End If
                itemsDictionary(baseName).Add(itemName & "|" & quantity) ' Combine item name and quantity
            End While
        End Using
    End Sub


    ' Extract the base name from the item name, handling exceptions
    Private Function GetBaseName(itemName As String) As String
        For Each keyword In keywords
            If itemName.ToLower().Contains(keyword) Then
                Return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(keyword)
            End If
        Next

        Dim words = itemName.Split(" "c)
        If words.Length >= 2 Then
            Return words(0) & " " & words(1)
        Else
            Return itemName
        End If
    End Function

    ' Populate the manually placed buttons with the base names
    Private Sub PopulateButtons()
        ' Generate button references dynamically
        Dim buttons(63) As Button
        For i As Integer = 0 To 63
            buttons(i) = CType(Me.Panel2.Controls("Button" & (i + 1)), Button)
        Next

        Dim j As Integer = 0

        For Each baseName In itemsDictionary.Keys.OrderBy(Function(k) k)
            If j < buttons.Length Then
                buttons(j).Text = baseName
                AddHandler buttons(j).Click, AddressOf Button_Click
                j += 1
            End If
        Next
    End Sub

    ' Handle button click to populate the ComboBox with variant items
    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Dim baseName As String = button.Text

        If itemsDictionary.ContainsKey(baseName) Then
            datagridVariety.Rows.Clear() ' Clear existing rows in DataGridView
            For Each variantItem As String In itemsDictionary(baseName)
                Dim data As String() = variantItem.Split("|"c)
                datagridVariety.Rows.Add(data(0), data(1)) ' Add item name and quantity to DataGridView
            Next
        End If
    End Sub

    ' Load event to fetch data and populate buttons when the form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchAndProcessData()
        PopulateButtons()
    End Sub
    Private Sub LoadDataToListOfItemsDataGridView()
        ' Create a connection to the database
        Using connection As New OleDbConnection(Documentation)
            ' Open the connection
            connection.Open()

            ' Create a SELECT query to retrieve data from the listofitems table
            Dim selectQuery As String = "SELECT * FROM listofitems ORDER BY ID"


            ' Create a data adapter and a data table to hold the retrieved data
            Dim adapter As New OleDbDataAdapter(selectQuery, connection)
            Dim dataTable As New DataTable()

            ' Fill the data table with data from the database
            adapter.Fill(dataTable)

            ' Assign the data table as the data source for the DataGridView
            Form1.datagridInventory.DataSource = dataTable
        End Using
    End Sub


End Class

