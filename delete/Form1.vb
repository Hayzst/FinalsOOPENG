Imports System.Data.OleDb
Imports System.Diagnostics.CodeAnalysis
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class Form1

    Dim Documentation As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Carl\Documents\Documentation.accdb"


    Public Sub succesfulLogin(feature As Integer)
        Me.pnlPOC.BringToFront()


        Me.btnHomepage.Visible = False
        Me.btnLogIn.Visible = False
        Me.btnLogOut.Visible = True
        If feature = 1 Then
            Me.btnCreateNewUseracct.Visible = True
            Me.datagridInventory.ReadOnly = False
        Else
            Me.datagridInventory.ReadOnly = True
        End If
        Me.btnInventory.Visible = True
        Me.btnHistory.Visible = True
        Me.btnPOS.Visible = True

        Me.LoginPanel.Visible = False
        Me.pnlCover.Visible = True
        Me.pnlPOC.Visible = True
        Me.pnlSalesReport.Visible = True
        Me.MenuStripPOCpanel.Visible = False
        Me.MenuStripGrey.Visible = True

        Me.pnlCover.BackColor = Color.FromArgb(100, 255, 255, 255)
        Me.btnLogOut.BackColor = Color.FromArgb(90, Color.Black)

        Me.Location = New Point(100, 100)
        Me.Size = New Size(1730, 788)
        Me.UserControl11.Location = New Point(0, 0)

        '----------pnlbtn -- the line that follows menubtnsclick
        Me.pnlbtn.Location = New Point(146, Me.pnlbtn.Location.Y)
        Me.pnlbtn.Height = btnPOS.Height
        Me.pnlbtn.Top = btnPOS.Top
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        MsgBox("Succesfully Logged Out")
        Me.btnHomepage.Visible = True
        Me.btnLogIn.Visible = True
        Me.btnPOS.Visible = False
        Me.btnHistory.Visible = False
        Me.btnLogOut.Visible = False
        Me.btnCreateNewUseracct.Visible = False
        Me.btnInventory.Visible = False

        Me.MenuStripGrey.Visible = False
        '------------------------visibles -        
        Me.HomePanel.BringToFront()
        Me.HomePanel.Visible = True
        Me.LoginPanel.Visible = True
        Me.pnlSalesReport.Visible = False
        Me.pnlPOC.Visible = False
        Me.pnlCover.BackColor = Color.FromArgb(70, Color.Black)
        Me.pnlCover.Visible = False
        'Me.pnlbtn.Location = New Point(240, 388)
        Me.lblPleaseMaximize.Visible = False
        Me.coverpnlDOCKtop.Visible = False
        '-----------------------resetPOS
        UserControl11.btnReset.PerformClick()
        '-----------------------pnlbtnPosition
        Me.pnlbtn.Height = Me.btnHomepage.Height
        Me.pnlbtn.Top = Me.btnHomepage.Top

    End Sub
    Private Sub showHIDEMenu(element As Panel)
        If element.Visible = True Then
            element.Visible = False
        Else
            element.Visible = True
        End If
    End Sub

    Private Sub btnMenuStrip_Click(sender As Object, e As EventArgs) Handles btnMenuStripHOMEPAGE.Click, btnMenuStripLOGIN.Click
        showHIDEMenu(MenuPanel)
    End Sub

    '------------------------------- loginForm as Form 2

    Private Sub LoginClick(sender As Object, e As EventArgs) Handles btnUser.Click, btnAdmin.Click
        Dim loginForm As New Form2(Me)
        loginForm.SetTitle(sender.tag)
        pnlCover.Visible = True
        loginForm.ShowDialog()
    End Sub




    '----------------------------------------- YELLOW BUTTON (MAXIMIZE) -----------------------------------------
    Private Sub visibleandnot(fsize)
        If fsize = "small" Then
            If MenuPanel.Visible = True Then
                Size = New Size(1730, 788)
                Location = New Point(100, 100)
            Else
                Size = New Size(1498, 788)
                Me.CenterToScreen()
            End If
            UserControl11.Location = New Point(0, 0)
            If (pnlbtn.Top = btnPOS.Top) Then
                pnlPOC.BringToFront()
            End If
            lblPleaseMaximize.Visible = False

        ElseIf fsize = "big" Then
            If MenuPanel.Visible = True Then
                MenuStrippnlCOVER.Visible = False
            End If
            pnlCover.BringToFront()
            lblPleaseMaximize.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, btnYellow.Click, yellowbtnSALESREPORT.Click, yellowbtnInventory.Click
        If Size.Width <= 922 Then

            visibleandnot("small")

        ElseIf Size.Width = 1730 Then
            Size = New Size(922, 528)
            Location = New Point(450, 150)
            UserControl11.Location = New Point(-232, 0)
            If (pnlbtn.Top = btnPOS.Top) Then
                visibleandnot("big")
            End If

        ElseIf Me.Size.Width < 1550 And Me.Size.Width > 930 Then
            Size = New Size(690, 528)
            Me.CenterToScreen()
            UserControl11.Location = New Point(-232, 0)
            If (pnlbtn.Top = btnPOS.Top) Then
                visibleandnot("big")
            End If


        End If
    End Sub
    '--------------------------------------------- MENU STRIPSS ----------------------------------------------------------------------------------
    Private Sub MenuStripPOCpanel_Click(sender As Object, e As EventArgs) Handles MenuStripPOCpanel.Click, MenuStrippnlCOVER.Click, MenuStripSALESREPORT.Click, menuStrippnlInventory.Click

        If MenuPanel.Visible Then
            sender.visible = False
        End If
        'MenuStrippnlCOVER.Visible = False        
        MenuPanel.Visible = True
        If Size.Height = 788 Then
            Size = New Size(1730, Size.Height)
            Location = New Point(100, 100)
        End If

    End Sub
    Private Sub MenuStripGrey_Click(sender As Object, e As EventArgs) Handles MenuStripGrey.Click
        sender.Visible = True
        MenuStripPOCpanel.Visible = True
        MenuStrippnlCOVER.Visible = True
        MenuStripSALESREPORT.Visible = True
        menuStrippnlInventory.Visible = True
        MenuPanel.Visible = False
        If Me.Size.Height = 788 Then
            Me.Size = New Size(1498, Me.Size.Height)
            Me.Location = New Point(332, 100)
        End If
    End Sub
    '------------------------------------------ MENU PANEL CONFIG -


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToListOfItemsDataGridView()
        HomePanel.BringToFront()
        pnlSalesReport.VerticalScroll.Visible = True
        Me.pnlCover.BackColor = Color.FromArgb(70, Color.Black)
        pnlbtn.Visible = True
        'pnlbtn.Location = New Point(146, Me.pnlbtn.Location.Y)
        pnlbtn.Height = btnHomepage.Height
        pnlbtn.Top = btnHomepage.Top
        populateComboBox()

        For Each column As DataGridViewColumn In datagridInventory.Columns
            If column.Index <> 1 Then ' Assuming column 2 (index 1) is the one you want to make editable
                column.ReadOnly = True
            End If
        Next
    End Sub

    Private Sub YaaYaaya(sender As Object, e As EventArgs) Handles btnHistory.Click, btnPOS.Click, btnCreateNewUseracct.Click, btnHomepage.Click, btnLogIn.Click, btnInventory.Click
        pnlbtn.Height = sender.Height
        pnlbtn.Top = sender.Top
        '------------------------------------------- HISTORY BTN
        If sender.name = btnHistory.Name Then
            btnHistory.Text = "Transaction H."
            btnPOS.Text = "Point of Sale"
            pnlSalesReport.BringToFront()
            MenuStripSALESREPORT.Visible = False


            '------------------------------------------- POS BTN
        ElseIf sender.name = btnPOS.Name Then
            btnHistory.Text = "Transaction History"
            btnPOS.Text = "POS"
            If Me.Size.Width <= 922 Then
                pnlCover.BringToFront()
                lblPleaseMaximize.Visible = True
                MenuStrippnlCOVER.Visible = False
            Else
                pnlPOC.BringToFront()
            End If
            '------------------------------------------- CREATE NEW USER BTN
        ElseIf sender.name = btnCreateNewUseracct.Name Then

            btnHistory.Text = "Transaction History"
            btnPOS.Text = "Point of Sale"
            showPOSandTransactionBtn()
            Dim loginForm As New Form2(Me)
            loginForm.Show()
            loginForm.pnlRegister.BringToFront()
            loginForm.pnlRegister.Visible = True

            loginForm.lblBackButton.Visible = False
            loginForm.RegisterCloseButton.Visible = True
            MenuPanel.Visible = False
            showCoverPanel(0)

            '------------------------------------------- HOMEPAGE BTN
        ElseIf sender.name = btnHomepage.Name Then
            HomePanel.BringToFront()

            '------------------------------------------- LOGIN BTN
        ElseIf sender.name = btnLogIn.Name Then
            LoginPanel.BringToFront()


            '------------------------------------------- INVENTORY BTN
        ElseIf sender.name = btnInventory.Name Then
            btnHistory.Text = "Transaction History"
            btnPOS.Text = "Point of Sale"
            InventoryPanel.BringToFront()
        End If
    End Sub
    Private Sub showPOSandTransactionBtn()
        btnHistory.Text = "Transaction History"
        btnPOS.Text = "Point of Sale"
    End Sub
    Public Sub showCoverPanel(feature As Integer)
        If feature = 0 Then
            coverpnlDOCKtop.Visible = False
            lblPleaseMaximize.Visible = False
            pnlCover.BringToFront()
            pnlCover.BackColor = Color.FromArgb(70, Color.Black)
        ElseIf feature = 1 Then
            lblPleaseMaximize.Visible = True
            coverpnlDOCKtop.Visible = True
            Me.pnlCover.BackColor = Color.FromArgb(100, 255, 255, 255)
        ElseIf feature = 2 Then

        End If
    End Sub
    Private Sub populateComboBox()
        Dim mycon As New OleDbConnection(Documentation)
        mycon.Open()
        Dim mycmd As New OleDbCommand("Select username from UserAdmin", mycon)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        While myread.Read()
            ' Check if the username field is not null
            If Not myread.IsDBNull(0) Then
                ' Add the username to the ComboBox
                cbUser.Items.Add(myread.GetString(0))
            End If
        End While
        mycon.Close()
    End Sub

    '--------------------------------- MONTHCALENDAR AND cbUSER RELATIONSHIP ---------------------------------------------------------------------------------

    Dim yab As String = ""
    Dim bool As String = ""
    Dim updatingControls As Boolean = False

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim selectedDate = e.Start.ToShortDateString()
        yab = selectedDate
        datagridSales.Rows.Clear()

        Dim mycon As New OleDbConnection(Documentation)
        mycon.Open()
        Dim mycmd As OleDbCommand

        If bool <> "" Then
            mycmd = New OleDbCommand("SELECT * FROM tblSales WHERE Dates LIKE '%" & selectedDate & "%' AND user = '" & bool & "'", mycon)
        Else
            mycmd = New OleDbCommand("SELECT * FROM tblSales WHERE Dates LIKE '%" & selectedDate & "%'", mycon)
        End If

        Dim myread As OleDbDataReader = mycmd.ExecuteReader

        While myread.Read
            If Not myread.IsDBNull(0) Then
                Dim time As String = myread("Time").ToString()
                Dim correctectTimeFormat As String = time.Replace("30/12/1899", "")
                Dim index As Integer = datagridSales.Rows.Add()

                datagridSales.Rows(index).Cells(0).Value = myread("Dates").ToString()
                datagridSales.Rows(index).Cells(1).Value = correctectTimeFormat
                datagridSales.Rows(index).Cells(2).Value = myread("PaymentMethod").ToString()
                datagridSales.Rows(index).Cells(3).Value = myread("Amount").ToString()
                datagridSales.Rows(index).Cells(4).Value = myread("User").ToString()
                datagridSales.Rows(index).Cells(5).Value = myread("TransactionID").ToString()
            End If
        End While

        myread.Close()
        mycon.Close()
    End Sub


    Private Sub datagridFILL()
        bool = cbUser.Text

        Dim mycon As New OleDbConnection(Documentation)
        mycon.Open()

        Dim mycmd As OleDbCommand
        'changed !#
        If cbUser.Text = "All" Then
            If yab = "" Then
                mycmd = New OleDbCommand("SELECT * FROM tblSales", mycon)
            Else
                mycmd = New OleDbCommand("SELECT * FROM tblSales WHERE Dates LIKE '%" & yab & "%'", mycon)
            End If
        Else
            If yab = "" Then
                mycmd = New OleDbCommand("SELECT * FROM tblSales WHERE user = '" & cbUser.Text.ToString & "'", mycon)
            Else
                mycmd = New OleDbCommand("SELECT * FROM tblSales WHERE Dates LIKE '%" & yab & "%' AND user = '" & cbUser.Text.ToString & "'", mycon)
            End If
        End If


        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        While myread.Read
            If Not myread.IsDBNull(0) Then

                Dim time As String = myread("Time").ToString()
                Dim correctectTimeFormat As String = time.Replace("30/12/1899", "")
                Dim index As Integer = datagridSales.Rows.Add()

                datagridSales.Rows(index).Cells(0).Value = myread("Dates").ToString()
                datagridSales.Rows(index).Cells(1).Value = correctectTimeFormat
                datagridSales.Rows(index).Cells(2).Value = myread("PaymentMethod").ToString()
                datagridSales.Rows(index).Cells(3).Value = myread("Amount").ToString()
                datagridSales.Rows(index).Cells(4).Value = myread("User").ToString()
                datagridSales.Rows(index).Cells(5).Value = myread("TransactionID").ToString()
            End If

        End While
        myread.Close()
        mycon.Close()
    End Sub


    Private Sub cbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUser.SelectedIndexChanged
        If cbUser.Text = "All" Then
            bool = ""
        Else
            bool = cbUser.Text
        End If
        datagridSales.Rows.Clear()
        datagridFILL()
    End Sub


    '------------------------------------------------------------------------------------------------------------------
    Dim itemsTransactionPiled As String = ""
    Dim QtyTransactionPiled As String = ""

    Private Sub UnpileAndDisplaytoTable(items As String, qty As String)
        Dim TransactionPiled As String
        For x As Integer = 0 To 1
            If x = 0 Then
                TransactionPiled = qty
            Else
                TransactionPiled = items
            End If
            Dim SeperatedValues() As String = TransactionPiled.Split(","c)
            For y As Integer = 0 To (SeperatedValues.Length - 1)
                If x = 0 Then
                    SalesReceiptDetails_datagrid.Rows.Add()
                End If
                SalesReceiptDetails_datagrid.Rows(y).Cells(x).Value = SeperatedValues(y)
                'System.ArgumentOutOfRangeException: 'Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')'
            Next
            'System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
        Next
    End Sub

    '--------------------------------------------------------- RECEIPT THAT DAY

    Private Sub datagridSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridSales.CellContentClick
        Pickfromtable2(e)
        addAmounttoReceiptTable()
    End Sub
    Private Sub Pickfromtable2(e)
        SalesReceiptDetails_datagrid.Rows.Clear()
        Dim selectedRow As Object
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            selectedRow = datagridSales.Rows(e.RowIndex).Cells(5).Value
        End If

        Dim mycon As New OleDbConnection(Documentation)

        mycon.Open()
        Dim mycmd As New OleDbCommand("Select * from tblSales where TransactionID = " & selectedRow & "", mycon) 'LIKE '%" & selectedDate & "%'
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        While myread.Read
            Dim mycmd2 As New OleDbCommand("Select * from TransactionDetails", mycon)
            Dim myread2 As OleDbDataReader = mycmd2.ExecuteReader
            While myread2.Read()

                If myread2("TransactionID").ToString() = myread("TransactionID").ToString() Then
                    itemsTransactionPiled = myread2("Item")
                    QtyTransactionPiled = myread2("QTY")
                    UnpileAndDisplaytoTable(itemsTransactionPiled, QtyTransactionPiled)
                End If
            End While
        End While
        addAmounttoReceiptTable()


        myread.Close()
        mycon.Close()
    End Sub
    Private Sub addAmounttoReceiptTable()
        Dim mycon As OleDbConnection

        mycon = New OleDbConnection(Documentation)
        mycon.Open()
        Dim mycmd3 As New OleDbCommand("Select * from listofitems", mycon)
        Dim myread3 As OleDbDataReader = mycmd3.ExecuteReader
        While myread3.Read()
            For y As Integer = 0 To SalesReceiptDetails_datagrid.RowCount - 1
                Dim cellValue As Object = SalesReceiptDetails_datagrid.Rows(y).Cells(1).Value
                If cellValue IsNot Nothing AndAlso cellValue.ToString = myread3("Item").ToString Then
                    'System.NullReferenceException: 'Object reference not set to an instance of an object.'
                    'System.Windows.Forms.DataGridViewCell.Value.get returned Nothing.

                    Dim pesoSign As Char = ChrW(&H20B1)
                    Dim PricePerItem As Object = myread3("Price").ToString
                    Dim valPricePerItem = Val(PricePerItem.Replace(pesoSign, "").Replace(",", ""))




                    SalesReceiptDetails_datagrid.Rows(y).Cells(2).Value = valPricePerItem * Val(SalesReceiptDetails_datagrid.Rows(y).Cells(0).Value)
                    'System.IndexOutOfRangeException: '[PricePerItem]'

                End If
            Next


        End While




        mycon.Close()
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
            datagridInventory.DataSource = dataTable
        End Using
    End Sub
    Private Sub datagridInventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles datagridInventory.CellEndEdit
        Dim rowIndex As Integer = e.RowIndex
        Dim columnIndex As Integer = e.ColumnIndex

        ' Ensure the cell being edited is not the header row
        If rowIndex >= 0 AndAlso columnIndex >= 0 Then
            Dim editedValue As Object = datagridInventory.Rows(rowIndex).Cells(columnIndex).Value

            ' Assuming the ID is stored in the first column
            Dim itemID As Integer = Convert.ToInt32(datagridInventory.Rows(rowIndex).Cells(0).Value)

            ' Connect to the database
            Try

                Using connection As New OleDbConnection(Documentation)
                    connection.Open()

                    ' Update the corresponding row in the database
                    Dim updateQuery As String = $"UPDATE listofitems SET Quantity = '{editedValue}' WHERE ID = {itemID}"
                    Using command As New OleDbCommand(updateQuery, connection)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Editing only available for Quantity Field")
            End Try

        End If
    End Sub

End Class
