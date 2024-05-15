<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Column1 = New DataGridViewTextBoxColumn()
        lblChange = New Label()
        lblCost = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Column3 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        Button1 = New Button()
        Button61 = New Button()
        Button62 = New Button()
        Button63 = New Button()
        Button55 = New Button()
        Button56 = New Button()
        Button57 = New Button()
        Button58 = New Button()
        Button59 = New Button()
        Button60 = New Button()
        Button49 = New Button()
        Button50 = New Button()
        Button51 = New Button()
        Button52 = New Button()
        Button53 = New Button()
        Button54 = New Button()
        Button43 = New Button()
        Button44 = New Button()
        Button45 = New Button()
        Button46 = New Button()
        Button47 = New Button()
        Button48 = New Button()
        Button37 = New Button()
        Button38 = New Button()
        Button39 = New Button()
        Button40 = New Button()
        Button41 = New Button()
        Button42 = New Button()
        Button31 = New Button()
        Button32 = New Button()
        Button33 = New Button()
        Button34 = New Button()
        Button35 = New Button()
        Button36 = New Button()
        Button25 = New Button()
        Button26 = New Button()
        Button27 = New Button()
        Button28 = New Button()
        Button29 = New Button()
        Button30 = New Button()
        Button19 = New Button()
        Button20 = New Button()
        Button21 = New Button()
        Button22 = New Button()
        Button23 = New Button()
        Button24 = New Button()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Button17 = New Button()
        Button18 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button6 = New Button()
        Column2 = New DataGridViewTextBoxColumn()
        lblBarcode = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Label1 = New Label()
        BillDataGrid = New DataGridView()
        btn0 = New Button()
        btn1 = New Button()
        btn4 = New Button()
        btn7 = New Button()
        btnC = New Button()
        btnDot = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        cbPayment = New ComboBox()
        Panel3 = New Panel()
        Panel6 = New Panel()
        lblTotal = New Label()
        Label8 = New Label()
        Panel5 = New Panel()
        btnRemove = New Button()
        btnReset = New Button()
        btnPrint = New Button()
        btnPay = New Button()
        Panel4 = New Panel()
        lblScanSwipe = New Label()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        Bill = New TabPage()
        receiptt = New TabPage()
        txtReceipt = New Guna.UI2.WinForms.Guna2TextBox()
        Stock = New DataGridViewTextBoxColumn()
        Items = New DataGridViewTextBoxColumn()
        datagridVariety = New Guna.UI2.WinForms.Guna2DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        Panel2.SuspendLayout()
        CType(BillDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        Bill.SuspendLayout()
        receiptt.SuspendLayout()
        CType(datagridVariety, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Item"
        Column1.Name = "Column1"
        ' 
        ' lblChange
        ' 
        lblChange.BackColor = SystemColors.ButtonHighlight
        lblChange.BorderStyle = BorderStyle.Fixed3D
        lblChange.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblChange.ForeColor = Color.IndianRed
        lblChange.Location = New Point(266, 124)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(227, 45)
        lblChange.TabIndex = 3
        ' 
        ' lblCost
        ' 
        lblCost.BackColor = SystemColors.ButtonHighlight
        lblCost.BorderStyle = BorderStyle.Fixed3D
        lblCost.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblCost.Location = New Point(266, 71)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(227, 45)
        lblCost.TabIndex = 2
        lblCost.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label3.Location = New Point(7, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 31)
        Label3.TabIndex = 1
        Label3.Text = "Change"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label2.Location = New Point(7, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 31)
        Label2.TabIndex = 1
        Label2.Text = "Amount"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Amount"
        Column3.Name = "Column3"
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = SystemColors.ButtonFace
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button61)
        Panel2.Controls.Add(Button62)
        Panel2.Controls.Add(Button63)
        Panel2.Controls.Add(Button55)
        Panel2.Controls.Add(Button56)
        Panel2.Controls.Add(Button57)
        Panel2.Controls.Add(Button58)
        Panel2.Controls.Add(Button59)
        Panel2.Controls.Add(Button60)
        Panel2.Controls.Add(Button49)
        Panel2.Controls.Add(Button50)
        Panel2.Controls.Add(Button51)
        Panel2.Controls.Add(Button52)
        Panel2.Controls.Add(Button53)
        Panel2.Controls.Add(Button54)
        Panel2.Controls.Add(Button43)
        Panel2.Controls.Add(Button44)
        Panel2.Controls.Add(Button45)
        Panel2.Controls.Add(Button46)
        Panel2.Controls.Add(Button47)
        Panel2.Controls.Add(Button48)
        Panel2.Controls.Add(Button37)
        Panel2.Controls.Add(Button38)
        Panel2.Controls.Add(Button39)
        Panel2.Controls.Add(Button40)
        Panel2.Controls.Add(Button41)
        Panel2.Controls.Add(Button42)
        Panel2.Controls.Add(Button31)
        Panel2.Controls.Add(Button32)
        Panel2.Controls.Add(Button33)
        Panel2.Controls.Add(Button34)
        Panel2.Controls.Add(Button35)
        Panel2.Controls.Add(Button36)
        Panel2.Controls.Add(Button25)
        Panel2.Controls.Add(Button26)
        Panel2.Controls.Add(Button27)
        Panel2.Controls.Add(Button28)
        Panel2.Controls.Add(Button29)
        Panel2.Controls.Add(Button30)
        Panel2.Controls.Add(Button19)
        Panel2.Controls.Add(Button20)
        Panel2.Controls.Add(Button21)
        Panel2.Controls.Add(Button22)
        Panel2.Controls.Add(Button23)
        Panel2.Controls.Add(Button24)
        Panel2.Controls.Add(Button13)
        Panel2.Controls.Add(Button14)
        Panel2.Controls.Add(Button15)
        Panel2.Controls.Add(Button16)
        Panel2.Controls.Add(Button17)
        Panel2.Controls.Add(Button18)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(Button10)
        Panel2.Controls.Add(Button11)
        Panel2.Controls.Add(Button12)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button6)
        Panel2.Location = New Point(755, 52)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(712, 452)
        Panel2.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button1.Location = New Point(241, 917)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 84)
        Button1.TabIndex = 153
        Button1.Tag = "20"
        Button1.UseVisualStyleBackColor = True
        Button1.Visible = False
        ' 
        ' Button61
        ' 
        Button61.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button61.Location = New Point(13, 917)
        Button61.Name = "Button61"
        Button61.Size = New Size(108, 84)
        Button61.TabIndex = 152
        Button61.Tag = "20"
        Button61.UseVisualStyleBackColor = True
        ' 
        ' Button62
        ' 
        Button62.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button62.Location = New Point(127, 917)
        Button62.Name = "Button62"
        Button62.Size = New Size(108, 84)
        Button62.TabIndex = 151
        Button62.Tag = "20"
        Button62.UseVisualStyleBackColor = True
        ' 
        ' Button63
        ' 
        Button63.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button63.Location = New Point(13, 17)
        Button63.Name = "Button63"
        Button63.Size = New Size(108, 84)
        Button63.TabIndex = 150
        Button63.Tag = "20"
        Button63.UseVisualStyleBackColor = True
        ' 
        ' Button55
        ' 
        Button55.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button55.Location = New Point(13, 827)
        Button55.Name = "Button55"
        Button55.Size = New Size(108, 84)
        Button55.TabIndex = 149
        Button55.Tag = "20"
        Button55.UseVisualStyleBackColor = True
        ' 
        ' Button56
        ' 
        Button56.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button56.Location = New Point(127, 827)
        Button56.Name = "Button56"
        Button56.Size = New Size(108, 84)
        Button56.TabIndex = 148
        Button56.Tag = "20"
        Button56.UseVisualStyleBackColor = True
        ' 
        ' Button57
        ' 
        Button57.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button57.Location = New Point(241, 827)
        Button57.Name = "Button57"
        Button57.Size = New Size(108, 84)
        Button57.TabIndex = 147
        Button57.Tag = "20"
        Button57.UseVisualStyleBackColor = True
        ' 
        ' Button58
        ' 
        Button58.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button58.Location = New Point(355, 827)
        Button58.Name = "Button58"
        Button58.Size = New Size(108, 84)
        Button58.TabIndex = 146
        Button58.Tag = "20"
        Button58.UseVisualStyleBackColor = True
        ' 
        ' Button59
        ' 
        Button59.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button59.Location = New Point(469, 827)
        Button59.Name = "Button59"
        Button59.Size = New Size(108, 84)
        Button59.TabIndex = 145
        Button59.Tag = "20"
        Button59.UseVisualStyleBackColor = True
        ' 
        ' Button60
        ' 
        Button60.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button60.Location = New Point(583, 827)
        Button60.Name = "Button60"
        Button60.Size = New Size(108, 84)
        Button60.TabIndex = 144
        Button60.Tag = "20"
        Button60.UseVisualStyleBackColor = True
        ' 
        ' Button49
        ' 
        Button49.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button49.Location = New Point(13, 737)
        Button49.Name = "Button49"
        Button49.Size = New Size(108, 84)
        Button49.TabIndex = 143
        Button49.Tag = "20"
        Button49.UseVisualStyleBackColor = True
        ' 
        ' Button50
        ' 
        Button50.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button50.Location = New Point(127, 737)
        Button50.Name = "Button50"
        Button50.Size = New Size(108, 84)
        Button50.TabIndex = 142
        Button50.Tag = "20"
        Button50.UseVisualStyleBackColor = True
        ' 
        ' Button51
        ' 
        Button51.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button51.Location = New Point(241, 737)
        Button51.Name = "Button51"
        Button51.Size = New Size(108, 84)
        Button51.TabIndex = 141
        Button51.Tag = "20"
        Button51.UseVisualStyleBackColor = True
        ' 
        ' Button52
        ' 
        Button52.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button52.Location = New Point(355, 737)
        Button52.Name = "Button52"
        Button52.Size = New Size(108, 84)
        Button52.TabIndex = 140
        Button52.Tag = "20"
        Button52.UseVisualStyleBackColor = True
        ' 
        ' Button53
        ' 
        Button53.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button53.Location = New Point(469, 737)
        Button53.Name = "Button53"
        Button53.Size = New Size(108, 84)
        Button53.TabIndex = 139
        Button53.Tag = "20"
        Button53.UseVisualStyleBackColor = True
        ' 
        ' Button54
        ' 
        Button54.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button54.Location = New Point(583, 737)
        Button54.Name = "Button54"
        Button54.Size = New Size(108, 84)
        Button54.TabIndex = 138
        Button54.Tag = "20"
        Button54.UseVisualStyleBackColor = True
        ' 
        ' Button43
        ' 
        Button43.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button43.Location = New Point(13, 647)
        Button43.Name = "Button43"
        Button43.Size = New Size(108, 84)
        Button43.TabIndex = 137
        Button43.Tag = "20"
        Button43.UseVisualStyleBackColor = True
        ' 
        ' Button44
        ' 
        Button44.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button44.Location = New Point(127, 647)
        Button44.Name = "Button44"
        Button44.Size = New Size(108, 84)
        Button44.TabIndex = 136
        Button44.Tag = "20"
        Button44.UseVisualStyleBackColor = True
        ' 
        ' Button45
        ' 
        Button45.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button45.Location = New Point(241, 647)
        Button45.Name = "Button45"
        Button45.Size = New Size(108, 84)
        Button45.TabIndex = 135
        Button45.Tag = "20"
        Button45.UseVisualStyleBackColor = True
        ' 
        ' Button46
        ' 
        Button46.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button46.Location = New Point(355, 647)
        Button46.Name = "Button46"
        Button46.Size = New Size(108, 84)
        Button46.TabIndex = 134
        Button46.Tag = "20"
        Button46.UseVisualStyleBackColor = True
        ' 
        ' Button47
        ' 
        Button47.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button47.Location = New Point(469, 647)
        Button47.Name = "Button47"
        Button47.Size = New Size(108, 84)
        Button47.TabIndex = 133
        Button47.Tag = "20"
        Button47.UseVisualStyleBackColor = True
        ' 
        ' Button48
        ' 
        Button48.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button48.Location = New Point(583, 647)
        Button48.Name = "Button48"
        Button48.Size = New Size(108, 84)
        Button48.TabIndex = 132
        Button48.Tag = "20"
        Button48.UseVisualStyleBackColor = True
        ' 
        ' Button37
        ' 
        Button37.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button37.Location = New Point(13, 557)
        Button37.Name = "Button37"
        Button37.Size = New Size(108, 84)
        Button37.TabIndex = 131
        Button37.Tag = "20"
        Button37.UseVisualStyleBackColor = True
        ' 
        ' Button38
        ' 
        Button38.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button38.Location = New Point(127, 557)
        Button38.Name = "Button38"
        Button38.Size = New Size(108, 84)
        Button38.TabIndex = 130
        Button38.Tag = "20"
        Button38.UseVisualStyleBackColor = True
        ' 
        ' Button39
        ' 
        Button39.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button39.Location = New Point(241, 557)
        Button39.Name = "Button39"
        Button39.Size = New Size(108, 84)
        Button39.TabIndex = 129
        Button39.Tag = "20"
        Button39.UseVisualStyleBackColor = True
        ' 
        ' Button40
        ' 
        Button40.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button40.Location = New Point(355, 557)
        Button40.Name = "Button40"
        Button40.Size = New Size(108, 84)
        Button40.TabIndex = 128
        Button40.Tag = "20"
        Button40.UseVisualStyleBackColor = True
        ' 
        ' Button41
        ' 
        Button41.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button41.Location = New Point(469, 557)
        Button41.Name = "Button41"
        Button41.Size = New Size(108, 84)
        Button41.TabIndex = 127
        Button41.Tag = "20"
        Button41.UseVisualStyleBackColor = True
        ' 
        ' Button42
        ' 
        Button42.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button42.Location = New Point(583, 557)
        Button42.Name = "Button42"
        Button42.Size = New Size(108, 84)
        Button42.TabIndex = 126
        Button42.Tag = "20"
        Button42.UseVisualStyleBackColor = True
        ' 
        ' Button31
        ' 
        Button31.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button31.Location = New Point(13, 467)
        Button31.Name = "Button31"
        Button31.Size = New Size(108, 84)
        Button31.TabIndex = 125
        Button31.Tag = "20"
        Button31.UseVisualStyleBackColor = True
        ' 
        ' Button32
        ' 
        Button32.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button32.Location = New Point(127, 467)
        Button32.Name = "Button32"
        Button32.Size = New Size(108, 84)
        Button32.TabIndex = 124
        Button32.Tag = "20"
        Button32.UseVisualStyleBackColor = True
        ' 
        ' Button33
        ' 
        Button33.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button33.Location = New Point(241, 467)
        Button33.Name = "Button33"
        Button33.Size = New Size(108, 84)
        Button33.TabIndex = 123
        Button33.Tag = "20"
        Button33.UseVisualStyleBackColor = True
        ' 
        ' Button34
        ' 
        Button34.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button34.Location = New Point(355, 467)
        Button34.Name = "Button34"
        Button34.Size = New Size(108, 84)
        Button34.TabIndex = 122
        Button34.Tag = "20"
        Button34.UseVisualStyleBackColor = True
        ' 
        ' Button35
        ' 
        Button35.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button35.Location = New Point(469, 467)
        Button35.Name = "Button35"
        Button35.Size = New Size(108, 84)
        Button35.TabIndex = 121
        Button35.Tag = "20"
        Button35.UseVisualStyleBackColor = True
        ' 
        ' Button36
        ' 
        Button36.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button36.Location = New Point(583, 467)
        Button36.Name = "Button36"
        Button36.Size = New Size(108, 84)
        Button36.TabIndex = 120
        Button36.Tag = "20"
        Button36.UseVisualStyleBackColor = True
        ' 
        ' Button25
        ' 
        Button25.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button25.Location = New Point(13, 377)
        Button25.Name = "Button25"
        Button25.Size = New Size(108, 84)
        Button25.TabIndex = 119
        Button25.Tag = "20"
        Button25.UseVisualStyleBackColor = True
        ' 
        ' Button26
        ' 
        Button26.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button26.Location = New Point(127, 377)
        Button26.Name = "Button26"
        Button26.Size = New Size(108, 84)
        Button26.TabIndex = 118
        Button26.Tag = "20"
        Button26.UseVisualStyleBackColor = True
        ' 
        ' Button27
        ' 
        Button27.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button27.Location = New Point(241, 377)
        Button27.Name = "Button27"
        Button27.Size = New Size(108, 84)
        Button27.TabIndex = 117
        Button27.Tag = "20"
        Button27.UseVisualStyleBackColor = True
        ' 
        ' Button28
        ' 
        Button28.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button28.Location = New Point(355, 377)
        Button28.Name = "Button28"
        Button28.Size = New Size(108, 84)
        Button28.TabIndex = 116
        Button28.Tag = "20"
        Button28.UseVisualStyleBackColor = True
        ' 
        ' Button29
        ' 
        Button29.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button29.Location = New Point(469, 377)
        Button29.Name = "Button29"
        Button29.Size = New Size(108, 84)
        Button29.TabIndex = 115
        Button29.Tag = "20"
        Button29.UseVisualStyleBackColor = True
        ' 
        ' Button30
        ' 
        Button30.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button30.Location = New Point(583, 377)
        Button30.Name = "Button30"
        Button30.Size = New Size(108, 84)
        Button30.TabIndex = 114
        Button30.Tag = "20"
        Button30.UseVisualStyleBackColor = True
        ' 
        ' Button19
        ' 
        Button19.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button19.Location = New Point(13, 287)
        Button19.Name = "Button19"
        Button19.Size = New Size(108, 84)
        Button19.TabIndex = 113
        Button19.Tag = "20"
        Button19.UseVisualStyleBackColor = True
        ' 
        ' Button20
        ' 
        Button20.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button20.Location = New Point(127, 287)
        Button20.Name = "Button20"
        Button20.Size = New Size(108, 84)
        Button20.TabIndex = 112
        Button20.Tag = "20"
        Button20.UseVisualStyleBackColor = True
        ' 
        ' Button21
        ' 
        Button21.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button21.Location = New Point(241, 287)
        Button21.Name = "Button21"
        Button21.Size = New Size(108, 84)
        Button21.TabIndex = 111
        Button21.Tag = "20"
        Button21.UseVisualStyleBackColor = True
        ' 
        ' Button22
        ' 
        Button22.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button22.Location = New Point(355, 287)
        Button22.Name = "Button22"
        Button22.Size = New Size(108, 84)
        Button22.TabIndex = 110
        Button22.Tag = "20"
        Button22.UseVisualStyleBackColor = True
        ' 
        ' Button23
        ' 
        Button23.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button23.Location = New Point(469, 287)
        Button23.Name = "Button23"
        Button23.Size = New Size(108, 84)
        Button23.TabIndex = 109
        Button23.Tag = "20"
        Button23.UseVisualStyleBackColor = True
        ' 
        ' Button24
        ' 
        Button24.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button24.Location = New Point(583, 287)
        Button24.Name = "Button24"
        Button24.Size = New Size(108, 84)
        Button24.TabIndex = 108
        Button24.Tag = "20"
        Button24.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button13.Location = New Point(13, 197)
        Button13.Name = "Button13"
        Button13.Size = New Size(108, 84)
        Button13.TabIndex = 107
        Button13.Tag = "20"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button14.Location = New Point(127, 197)
        Button14.Name = "Button14"
        Button14.Size = New Size(108, 84)
        Button14.TabIndex = 106
        Button14.Tag = "20"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button15.Location = New Point(241, 197)
        Button15.Name = "Button15"
        Button15.Size = New Size(108, 84)
        Button15.TabIndex = 105
        Button15.Tag = "20"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button16.Location = New Point(355, 197)
        Button16.Name = "Button16"
        Button16.Size = New Size(108, 84)
        Button16.TabIndex = 104
        Button16.Tag = "20"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button17.Location = New Point(469, 197)
        Button17.Name = "Button17"
        Button17.Size = New Size(108, 84)
        Button17.TabIndex = 103
        Button17.Tag = "20"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button18
        ' 
        Button18.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button18.Location = New Point(583, 197)
        Button18.Name = "Button18"
        Button18.Size = New Size(108, 84)
        Button18.TabIndex = 102
        Button18.Tag = "20"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button7.Location = New Point(13, 107)
        Button7.Name = "Button7"
        Button7.Size = New Size(108, 84)
        Button7.TabIndex = 101
        Button7.Tag = "20"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button8.Location = New Point(127, 107)
        Button8.Name = "Button8"
        Button8.Size = New Size(108, 84)
        Button8.TabIndex = 100
        Button8.Tag = "20"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button9.Location = New Point(241, 107)
        Button9.Name = "Button9"
        Button9.Size = New Size(108, 84)
        Button9.TabIndex = 99
        Button9.Tag = "20"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button10.Location = New Point(355, 107)
        Button10.Name = "Button10"
        Button10.Size = New Size(108, 84)
        Button10.TabIndex = 98
        Button10.Tag = "20"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button11.Location = New Point(469, 107)
        Button11.Name = "Button11"
        Button11.Size = New Size(108, 84)
        Button11.TabIndex = 97
        Button11.Tag = "20"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button12.Location = New Point(583, 107)
        Button12.Name = "Button12"
        Button12.Size = New Size(108, 84)
        Button12.TabIndex = 96
        Button12.Tag = "20"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button5.Location = New Point(469, 17)
        Button5.Name = "Button5"
        Button5.Size = New Size(108, 84)
        Button5.TabIndex = 95
        Button5.Tag = "20"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button3.Location = New Point(241, 17)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 84)
        Button3.TabIndex = 93
        Button3.Tag = "20"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button4.Location = New Point(355, 17)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 84)
        Button4.TabIndex = 92
        Button4.Tag = "20"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button2.Location = New Point(127, 17)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 84)
        Button2.TabIndex = 91
        Button2.Tag = "20"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button6.Location = New Point(583, 17)
        Button6.Name = "Button6"
        Button6.Size = New Size(108, 84)
        Button6.TabIndex = 94
        Button6.Tag = "20"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Qty"
        Column2.Name = "Column2"
        ' 
        ' lblBarcode
        ' 
        lblBarcode.AutoEllipsis = True
        lblBarcode.BackColor = SystemColors.ButtonHighlight
        lblBarcode.BorderStyle = BorderStyle.Fixed3D
        lblBarcode.Font = New Font("C39HrP24DhTt", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBarcode.Location = New Point(404, 423)
        lblBarcode.Name = "lblBarcode"
        lblBarcode.Size = New Size(345, 78)
        lblBarcode.TabIndex = 11
        lblBarcode.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label1.Location = New Point(7, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 31)
        Label1.TabIndex = 1
        Label1.Text = "Mode of Payment"
        ' 
        ' BillDataGrid
        ' 
        BillDataGrid.BackgroundColor = Color.White
        BillDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillDataGrid.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        BillDataGrid.Location = New Point(-1, 3)
        BillDataGrid.Name = "BillDataGrid"
        BillDataGrid.Size = New Size(338, 366)
        BillDataGrid.TabIndex = 9
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn0.Location = New Point(12, 300)
        btn0.Name = "btn0"
        btn0.Size = New Size(108, 84)
        btn0.TabIndex = 3
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn1.Location = New Point(12, 210)
        btn1.Name = "btn1"
        btn1.Size = New Size(108, 84)
        btn1.TabIndex = 3
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn4.Location = New Point(12, 120)
        btn4.Name = "btn4"
        btn4.Size = New Size(108, 84)
        btn4.TabIndex = 3
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn7.Location = New Point(12, 30)
        btn7.Name = "btn7"
        btn7.Size = New Size(108, 84)
        btn7.TabIndex = 3
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btnC
        ' 
        btnC.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnC.Location = New Point(242, 300)
        btnC.Name = "btnC"
        btnC.Size = New Size(108, 84)
        btnC.TabIndex = 2
        btnC.Text = "C"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' btnDot
        ' 
        btnDot.BackColor = Color.White
        btnDot.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnDot.Location = New Point(128, 300)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(108, 84)
        btnDot.TabIndex = 2
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn3.Location = New Point(242, 210)
        btn3.Name = "btn3"
        btn3.Size = New Size(108, 84)
        btn3.TabIndex = 2
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn2.Location = New Point(128, 210)
        btn2.Name = "btn2"
        btn2.Size = New Size(108, 84)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn6.Location = New Point(242, 120)
        btn6.Name = "btn6"
        btn6.Size = New Size(108, 84)
        btn6.TabIndex = 2
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn5.Location = New Point(128, 120)
        btn5.Name = "btn5"
        btn5.Size = New Size(108, 84)
        btn5.TabIndex = 2
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn9.Location = New Point(242, 30)
        btn9.Name = "btn9"
        btn9.Size = New Size(108, 84)
        btn9.TabIndex = 2
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn8.Location = New Point(128, 30)
        btn8.Name = "btn8"
        btn8.Size = New Size(108, 84)
        btn8.TabIndex = 2
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' cbPayment
        ' 
        cbPayment.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        cbPayment.FormattingEnabled = True
        cbPayment.Items.AddRange(New Object() {"Cash", "Direct Debit", "Visa Card", "MasterCard", "GCash"})
        cbPayment.Location = New Point(266, 10)
        cbPayment.Name = "cbPayment"
        cbPayment.Size = New Size(227, 53)
        cbPayment.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonFace
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(32, 510)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1435, 227)
        Panel3.TabIndex = 8
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ButtonFace
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(lblTotal)
        Panel6.Controls.Add(Label8)
        Panel6.Location = New Point(17, 19)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(408, 190)
        Panel6.TabIndex = 3
        ' 
        ' lblTotal
        ' 
        lblTotal.BackColor = SystemColors.ButtonHighlight
        lblTotal.BorderStyle = BorderStyle.Fixed3D
        lblTotal.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblTotal.Location = New Point(182, 68)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(204, 42)
        lblTotal.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label8.Location = New Point(32, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 45)
        Label8.TabIndex = 1
        Label8.Text = "Total"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ButtonFace
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(btnRemove)
        Panel5.Controls.Add(btnReset)
        Panel5.Controls.Add(btnPrint)
        Panel5.Controls.Add(btnPay)
        Panel5.Location = New Point(937, 16)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(483, 193)
        Panel5.TabIndex = 2
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.Location = New Point(246, 97)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(215, 88)
        btnRemove.TabIndex = 6
        btnRemove.Text = "Remove Item"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnReset.Location = New Point(246, 3)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(215, 88)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnPrint.Location = New Point(25, 97)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(215, 88)
        btnPrint.TabIndex = 4
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnPay.Location = New Point(25, 3)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(215, 88)
        btnPay.TabIndex = 3
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonFace
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lblChange)
        Panel4.Controls.Add(lblCost)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(lblScanSwipe)
        Panel4.Controls.Add(cbPayment)
        Panel4.Location = New Point(431, 18)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(500, 191)
        Panel4.TabIndex = 2
        ' 
        ' lblScanSwipe
        ' 
        lblScanSwipe.AutoSize = True
        lblScanSwipe.Font = New Font("Fira Code", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScanSwipe.ForeColor = SystemColors.ButtonFace
        lblScanSwipe.Location = New Point(7, 97)
        lblScanSwipe.Name = "lblScanSwipe"
        lblScanSwipe.Size = New Size(501, 72)
        lblScanSwipe.TabIndex = 4
        lblScanSwipe.Text = "Scan QR code or Swipe Card " & vbCrLf & "for Payment"
        lblScanSwipe.TextAlign = ContentAlignment.TopCenter
        lblScanSwipe.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btn0)
        Panel1.Controls.Add(btn1)
        Panel1.Controls.Add(btn4)
        Panel1.Controls.Add(btn7)
        Panel1.Controls.Add(btnC)
        Panel1.Controls.Add(btnDot)
        Panel1.Controls.Add(btn3)
        Panel1.Controls.Add(btn2)
        Panel1.Controls.Add(btn6)
        Panel1.Controls.Add(btn5)
        Panel1.Controls.Add(btn9)
        Panel1.Controls.Add(btn8)
        Panel1.Location = New Point(32, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(366, 452)
        Panel1.TabIndex = 7
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Bill)
        TabControl1.Controls.Add(receiptt)
        TabControl1.Location = New Point(404, 52)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(345, 217)
        TabControl1.TabIndex = 12
        ' 
        ' Bill
        ' 
        Bill.BackColor = SystemColors.ButtonHighlight
        Bill.Controls.Add(BillDataGrid)
        Bill.Location = New Point(4, 24)
        Bill.Name = "Bill"
        Bill.Padding = New Padding(3)
        Bill.Size = New Size(337, 189)
        Bill.TabIndex = 0
        Bill.Text = "Bill"
        ' 
        ' receiptt
        ' 
        receiptt.Controls.Add(txtReceipt)
        receiptt.Location = New Point(4, 24)
        receiptt.Name = "receiptt"
        receiptt.Padding = New Padding(3)
        receiptt.Size = New Size(337, 189)
        receiptt.TabIndex = 1
        receiptt.Text = "Receipt"
        receiptt.UseVisualStyleBackColor = True
        ' 
        ' txtReceipt
        ' 
        txtReceipt.CustomizableEdges = CustomizableEdges1
        txtReceipt.DefaultText = ""
        txtReceipt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtReceipt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtReceipt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtReceipt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtReceipt.Dock = DockStyle.Fill
        txtReceipt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtReceipt.Font = New Font("Segoe UI", 9F)
        txtReceipt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtReceipt.Location = New Point(3, 3)
        txtReceipt.Multiline = True
        txtReceipt.Name = "txtReceipt"
        txtReceipt.PasswordChar = ChrW(0)
        txtReceipt.PlaceholderText = ""
        txtReceipt.ScrollBars = ScrollBars.Vertical
        txtReceipt.SelectedText = ""
        txtReceipt.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtReceipt.Size = New Size(331, 183)
        txtReceipt.TabIndex = 0
        ' 
        ' Stock
        ' 
        Stock.HeaderText = "Stocks"
        Stock.Name = "Stock"
        ' 
        ' Items
        ' 
        Items.HeaderText = "Item"
        Items.Name = "Items"
        ' 
        ' datagridVariety
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        datagridVariety.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        datagridVariety.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        datagridVariety.ColumnHeadersHeight = 17
        datagridVariety.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        datagridVariety.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        datagridVariety.DefaultCellStyle = DataGridViewCellStyle5
        datagridVariety.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        datagridVariety.Location = New Point(404, 274)
        datagridVariety.Name = "datagridVariety"
        datagridVariety.ReadOnly = True
        datagridVariety.RowHeadersVisible = False
        datagridVariety.Size = New Size(345, 145)
        datagridVariety.TabIndex = 90
        datagridVariety.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        datagridVariety.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        datagridVariety.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        datagridVariety.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        datagridVariety.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        datagridVariety.ThemeStyle.BackColor = Color.White
        datagridVariety.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        datagridVariety.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        datagridVariety.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        datagridVariety.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        datagridVariety.ThemeStyle.HeaderStyle.ForeColor = Color.White
        datagridVariety.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        datagridVariety.ThemeStyle.HeaderStyle.Height = 17
        datagridVariety.ThemeStyle.ReadOnly = True
        datagridVariety.ThemeStyle.RowsStyle.BackColor = Color.White
        datagridVariety.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        datagridVariety.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        datagridVariety.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        datagridVariety.ThemeStyle.RowsStyle.Height = 25
        datagridVariety.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        datagridVariety.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridViewTextBoxColumn1.HeaderText = "Item Types"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        DataGridViewTextBoxColumn2.HeaderText = "Stocks"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ActiveBorder
        Controls.Add(datagridVariety)
        Controls.Add(Panel2)
        Controls.Add(lblBarcode)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Name = "UserControl1"
        Size = New Size(1498, 788)
        Panel2.ResumeLayout(False)
        CType(BillDataGrid, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        Bill.ResumeLayout(False)
        receiptt.ResumeLayout(False)
        CType(datagridVariety, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents lblChange As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents lblBarcode As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents BillDataGrid As DataGridView
    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents cbPayment As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblScanSwipe As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Bill As TabPage
    Friend WithEvents Receipt As TabPage
    Friend WithEvents receiptt As TabPage
    Friend WithEvents txtReceipt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button61 As Button
    Friend WithEvents Button62 As Button
    Friend WithEvents Button63 As Button
    Friend WithEvents Button55 As Button
    Friend WithEvents Button56 As Button
    Friend WithEvents Button57 As Button
    Friend WithEvents Button58 As Button
    Friend WithEvents Button59 As Button
    Friend WithEvents Button60 As Button
    Friend WithEvents Button49 As Button
    Friend WithEvents Button50 As Button
    Friend WithEvents Button51 As Button
    Friend WithEvents Button52 As Button
    Friend WithEvents Button53 As Button
    Friend WithEvents Button54 As Button
    Friend WithEvents Button43 As Button
    Friend WithEvents Button44 As Button
    Friend WithEvents Button45 As Button
    Friend WithEvents Button46 As Button
    Friend WithEvents Button47 As Button
    Friend WithEvents Button48 As Button
    Friend WithEvents Button37 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents Button39 As Button
    Friend WithEvents Button40 As Button
    Friend WithEvents Button41 As Button
    Friend WithEvents Button42 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Button36 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Items As DataGridViewTextBoxColumn
    Friend WithEvents datagridVariety As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn

End Class
