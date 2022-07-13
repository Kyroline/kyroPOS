<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.buttonStockModify = New System.Windows.Forms.Button()
        Me.buttonStockAdd = New System.Windows.Forms.Button()
        Me.buttonAccount = New System.Windows.Forms.Button()
        Me.buttonAccountMan = New System.Windows.Forms.Button()
        Me.buttonStock = New System.Windows.Forms.Button()
        Me.buttonTransaction = New System.Windows.Forms.Button()
        Me.buttonReport = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabReport = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buttonReportView = New System.Windows.Forms.Button()
        Me.buttonReportDetails = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.purchase_id = New System.Windows.Forms.ColumnHeader()
        Me.purchase_date = New System.Windows.Forms.ColumnHeader()
        Me.customer_name = New System.Windows.Forms.ColumnHeader()
        Me.cashier_name = New System.Windows.Forms.ColumnHeader()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listBuyProductCart = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.buttonBuyProductConfirm = New System.Windows.Forms.Button()
        Me.buttonBuyProductRemove = New System.Windows.Forms.Button()
        Me.textBuyProductChange = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.textBuyProductTotalPaid = New System.Windows.Forms.TextBox()
        Me.textBuyProductPaid = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.labelBuyProductStock = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.comboAddProductSearch = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textBuyProductSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textBuyProductPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textBuyProductQty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.listboxBuyProductName = New System.Windows.Forms.ListBox()
        Me.textBuyProductTotal = New System.Windows.Forms.TextBox()
        Me.buttonBuyProductAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.textTransactionCashierName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.textTransactionCustomerName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.textTransactionPurchaseID = New System.Windows.Forms.TextBox()
        Me.tabStock = New System.Windows.Forms.TabPage()
        Me.comboStockDASC = New System.Windows.Forms.ComboBox()
        Me.comboStockOrderBy = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.buttonProductEmpty = New System.Windows.Forms.Button()
        Me.buttonProductTotal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cID = New System.Windows.Forms.ColumnHeader()
        Me.cName = New System.Windows.Forms.ColumnHeader()
        Me.cPrice = New System.Windows.Forms.ColumnHeader()
        Me.cBarcode = New System.Windows.Forms.ColumnHeader()
        Me.cStock = New System.Windows.Forms.ColumnHeader()
        Me.tabStockAdd = New System.Windows.Forms.TabPage()
        Me.buttonAddProductSubmit = New System.Windows.Forms.Button()
        Me.textAddProductStock = New System.Windows.Forms.TextBox()
        Me.labelAddProductStock = New System.Windows.Forms.Label()
        Me.textAddProductBarcode = New System.Windows.Forms.TextBox()
        Me.labelAddProductBarcode = New System.Windows.Forms.Label()
        Me.textAddProductPrice = New System.Windows.Forms.TextBox()
        Me.labelAddProductPrice = New System.Windows.Forms.Label()
        Me.textAddProductName = New System.Windows.Forms.TextBox()
        Me.labelAddProductName = New System.Windows.Forms.Label()
        Me.tabStockModify = New System.Windows.Forms.TabPage()
        Me.buttonModifyProductDelete = New System.Windows.Forms.Button()
        Me.labelModifyProductError = New System.Windows.Forms.Label()
        Me.comboboxModifyProductSearch = New System.Windows.Forms.ComboBox()
        Me.textModifyProductSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buttonModifyProductSubmit = New System.Windows.Forms.Button()
        Me.textModifyProductStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textModifyProductBarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textModifyProductPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textModifyProductName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabAccountMan = New System.Windows.Forms.TabPage()
        Me.buttonAccRefresh = New System.Windows.Forms.Button()
        Me.buttonAddAccountSubmit = New System.Windows.Forms.Button()
        Me.comboAddAccountType = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.textAddAccountPassword = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.textAddAccountID = New System.Windows.Forms.TextBox()
        Me.textAddAccountName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.uID = New System.Windows.Forms.ColumnHeader()
        Me.uOwner = New System.Windows.Forms.ColumnHeader()
        Me.uType = New System.Windows.Forms.ColumnHeader()
        Me.uLast = New System.Windows.Forms.ColumnHeader()
        Me.buttonAccountModify = New System.Windows.Forms.Button()
        Me.tabAccount = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.buttonAccountLogout = New System.Windows.Forms.Button()
        Me.tabLogin = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.labelLoginError = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.textboxUserID = New System.Windows.Forms.TextBox()
        Me.imageLogin = New System.Windows.Forms.Panel()
        Me.tabAccountAdd = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabAccountModify = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.textAccountModifyType = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.textAccountModifyPassword = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.textAccountModifyID = New System.Windows.Forms.TextBox()
        Me.textAccountModifyOwner = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.panelTop.SuspendLayout()
        Me.panelLeft.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabReport.SuspendLayout()
        Me.tabTransaction.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabStock.SuspendLayout()
        Me.tabStockAdd.SuspendLayout()
        Me.tabStockModify.SuspendLayout()
        Me.tabAccountMan.SuspendLayout()
        Me.tabAccount.SuspendLayout()
        Me.tabLogin.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tabAccountAdd.SuspendLayout()
        Me.tabAccountModify.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.panelTop.Controls.Add(Me.labelTitle)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1270, 69)
        Me.panelTop.TabIndex = 1
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Bebas Neue", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.labelTitle.Location = New System.Drawing.Point(139, 18)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(92, 38)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Report"
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panelLeft.Controls.Add(Me.buttonStockModify)
        Me.panelLeft.Controls.Add(Me.buttonStockAdd)
        Me.panelLeft.Controls.Add(Me.buttonAccount)
        Me.panelLeft.Controls.Add(Me.buttonAccountMan)
        Me.panelLeft.Controls.Add(Me.buttonStock)
        Me.panelLeft.Controls.Add(Me.buttonTransaction)
        Me.panelLeft.Controls.Add(Me.buttonReport)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 69)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(139, 613)
        Me.panelLeft.TabIndex = 0
        '
        'buttonStockModify
        '
        Me.buttonStockModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.buttonStockModify.FlatAppearance.BorderSize = 0
        Me.buttonStockModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonStockModify.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonStockModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.buttonStockModify.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonStockModify.Location = New System.Drawing.Point(-20, 234)
        Me.buttonStockModify.Name = "buttonStockModify"
        Me.buttonStockModify.Size = New System.Drawing.Size(173, 18)
        Me.buttonStockModify.TabIndex = 6
        Me.buttonStockModify.Text = "Modify Stock"
        Me.buttonStockModify.UseVisualStyleBackColor = False
        '
        'buttonStockAdd
        '
        Me.buttonStockAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.buttonStockAdd.FlatAppearance.BorderSize = 0
        Me.buttonStockAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonStockAdd.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonStockAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.buttonStockAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonStockAdd.Location = New System.Drawing.Point(-20, 210)
        Me.buttonStockAdd.Name = "buttonStockAdd"
        Me.buttonStockAdd.Size = New System.Drawing.Size(173, 18)
        Me.buttonStockAdd.TabIndex = 5
        Me.buttonStockAdd.Text = "Add Stock"
        Me.buttonStockAdd.UseVisualStyleBackColor = False
        '
        'buttonAccount
        '
        Me.buttonAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.buttonAccount.FlatAppearance.BorderSize = 0
        Me.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAccount.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonAccount.Image = CType(resources.GetObject("buttonAccount.Image"), System.Drawing.Image)
        Me.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonAccount.Location = New System.Drawing.Point(-20, 337)
        Me.buttonAccount.Name = "buttonAccount"
        Me.buttonAccount.Size = New System.Drawing.Size(173, 64)
        Me.buttonAccount.TabIndex = 4
        Me.buttonAccount.UseVisualStyleBackColor = False
        '
        'buttonAccountMan
        '
        Me.buttonAccountMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.buttonAccountMan.FlatAppearance.BorderSize = 0
        Me.buttonAccountMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAccountMan.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonAccountMan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonAccountMan.Image = CType(resources.GetObject("buttonAccountMan.Image"), System.Drawing.Image)
        Me.buttonAccountMan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonAccountMan.Location = New System.Drawing.Point(-20, 267)
        Me.buttonAccountMan.Name = "buttonAccountMan"
        Me.buttonAccountMan.Size = New System.Drawing.Size(173, 64)
        Me.buttonAccountMan.TabIndex = 3
        Me.buttonAccountMan.UseVisualStyleBackColor = False
        '
        'buttonStock
        '
        Me.buttonStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.buttonStock.FlatAppearance.BorderSize = 0
        Me.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonStock.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonStock.Image = CType(resources.GetObject("buttonStock.Image"), System.Drawing.Image)
        Me.buttonStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonStock.Location = New System.Drawing.Point(-20, 140)
        Me.buttonStock.Name = "buttonStock"
        Me.buttonStock.Size = New System.Drawing.Size(173, 64)
        Me.buttonStock.TabIndex = 2
        Me.buttonStock.UseVisualStyleBackColor = False
        '
        'buttonTransaction
        '
        Me.buttonTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.buttonTransaction.FlatAppearance.BorderSize = 0
        Me.buttonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonTransaction.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonTransaction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonTransaction.Image = CType(resources.GetObject("buttonTransaction.Image"), System.Drawing.Image)
        Me.buttonTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonTransaction.Location = New System.Drawing.Point(-20, 0)
        Me.buttonTransaction.Name = "buttonTransaction"
        Me.buttonTransaction.Size = New System.Drawing.Size(173, 64)
        Me.buttonTransaction.TabIndex = 1
        Me.buttonTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonTransaction.UseVisualStyleBackColor = False
        '
        'buttonReport
        '
        Me.buttonReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.buttonReport.FlatAppearance.BorderSize = 0
        Me.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonReport.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonReport.Image = CType(resources.GetObject("buttonReport.Image"), System.Drawing.Image)
        Me.buttonReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonReport.Location = New System.Drawing.Point(-20, 70)
        Me.buttonReport.Name = "buttonReport"
        Me.buttonReport.Size = New System.Drawing.Size(173, 64)
        Me.buttonReport.TabIndex = 0
        Me.buttonReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonReport.UseVisualStyleBackColor = False
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabReport)
        Me.tabMain.Controls.Add(Me.tabTransaction)
        Me.tabMain.Controls.Add(Me.tabStock)
        Me.tabMain.Controls.Add(Me.tabStockAdd)
        Me.tabMain.Controls.Add(Me.tabStockModify)
        Me.tabMain.Controls.Add(Me.tabAccountMan)
        Me.tabMain.Controls.Add(Me.tabAccount)
        Me.tabMain.Controls.Add(Me.tabLogin)
        Me.tabMain.Controls.Add(Me.tabAccountAdd)
        Me.tabMain.Controls.Add(Me.tabAccountModify)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabMain.ItemSize = New System.Drawing.Size(48, 20)
        Me.tabMain.Location = New System.Drawing.Point(139, 69)
        Me.tabMain.Multiline = True
        Me.tabMain.Name = "tabMain"
        Me.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1131, 613)
        Me.tabMain.TabIndex = 0
        '
        'tabReport
        '
        Me.tabReport.BackColor = System.Drawing.Color.Transparent
        Me.tabReport.Controls.Add(Me.Button5)
        Me.tabReport.Controls.Add(Me.Button4)
        Me.tabReport.Controls.Add(Me.Button3)
        Me.tabReport.Controls.Add(Me.Button2)
        Me.tabReport.Controls.Add(Me.buttonReportView)
        Me.tabReport.Controls.Add(Me.buttonReportDetails)
        Me.tabReport.Controls.Add(Me.ListView2)
        Me.tabReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabReport.ImageKey = "cashier"
        Me.tabReport.Location = New System.Drawing.Point(4, 24)
        Me.tabReport.Name = "tabReport"
        Me.tabReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabReport.Size = New System.Drawing.Size(1123, 585)
        Me.tabReport.TabIndex = 3
        Me.tabReport.Text = "Report"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Blue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(16, 218)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(400, 45)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Customer :"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(16, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(400, 45)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Income :"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(16, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(400, 45)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Customer Today :"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(400, 45)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Income Today :"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'buttonReportView
        '
        Me.buttonReportView.BackColor = System.Drawing.Color.Gold
        Me.buttonReportView.FlatAppearance.BorderSize = 0
        Me.buttonReportView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonReportView.ForeColor = System.Drawing.Color.White
        Me.buttonReportView.Location = New System.Drawing.Point(1006, 10)
        Me.buttonReportView.Name = "buttonReportView"
        Me.buttonReportView.Size = New System.Drawing.Size(109, 30)
        Me.buttonReportView.TabIndex = 8
        Me.buttonReportView.Text = "View"
        Me.buttonReportView.UseVisualStyleBackColor = False
        '
        'buttonReportDetails
        '
        Me.buttonReportDetails.BackColor = System.Drawing.Color.Lime
        Me.buttonReportDetails.FlatAppearance.BorderSize = 0
        Me.buttonReportDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonReportDetails.ForeColor = System.Drawing.Color.White
        Me.buttonReportDetails.Location = New System.Drawing.Point(1006, 543)
        Me.buttonReportDetails.Name = "buttonReportDetails"
        Me.buttonReportDetails.Size = New System.Drawing.Size(109, 34)
        Me.buttonReportDetails.TabIndex = 1
        Me.buttonReportDetails.Text = "Details"
        Me.buttonReportDetails.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.purchase_id, Me.purchase_date, Me.customer_name, Me.cashier_name})
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(471, 46)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(644, 491)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'purchase_id
        '
        Me.purchase_id.Text = "ID"
        '
        'purchase_date
        '
        Me.purchase_date.Text = "Date"
        Me.purchase_date.Width = 120
        '
        'customer_name
        '
        Me.customer_name.Text = "Customer Name"
        Me.customer_name.Width = 180
        '
        'cashier_name
        '
        Me.cashier_name.Text = "Cashier Name"
        Me.cashier_name.Width = 180
        '
        'tabTransaction
        '
        Me.tabTransaction.BackColor = System.Drawing.Color.Transparent
        Me.tabTransaction.Controls.Add(Me.GroupBox3)
        Me.tabTransaction.Controls.Add(Me.GroupBox2)
        Me.tabTransaction.Controls.Add(Me.GroupBox1)
        Me.tabTransaction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabTransaction.Location = New System.Drawing.Point(4, 24)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabTransaction.Size = New System.Drawing.Size(1123, 585)
        Me.tabTransaction.TabIndex = 0
        Me.tabTransaction.Text = "Transaksi"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listBuyProductCart)
        Me.GroupBox3.Controls.Add(Me.buttonBuyProductConfirm)
        Me.GroupBox3.Controls.Add(Me.buttonBuyProductRemove)
        Me.GroupBox3.Controls.Add(Me.textBuyProductChange)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.textBuyProductTotalPaid)
        Me.GroupBox3.Controls.Add(Me.textBuyProductPaid)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 563)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Costumer's Cart"
        '
        'listBuyProductCart
        '
        Me.listBuyProductCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listBuyProductCart.HideSelection = False
        Me.listBuyProductCart.Location = New System.Drawing.Point(6, 26)
        Me.listBuyProductCart.Name = "listBuyProductCart"
        Me.listBuyProductCart.Size = New System.Drawing.Size(495, 364)
        Me.listBuyProductCart.TabIndex = 11
        Me.listBuyProductCart.UseCompatibleStateImageBehavior = False
        Me.listBuyProductCart.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "#"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 25
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        Me.ColumnHeader4.Width = 120
        '
        'buttonBuyProductConfirm
        '
        Me.buttonBuyProductConfirm.BackColor = System.Drawing.SystemColors.Highlight
        Me.buttonBuyProductConfirm.FlatAppearance.BorderSize = 0
        Me.buttonBuyProductConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBuyProductConfirm.ForeColor = System.Drawing.Color.White
        Me.buttonBuyProductConfirm.Location = New System.Drawing.Point(410, 526)
        Me.buttonBuyProductConfirm.Name = "buttonBuyProductConfirm"
        Me.buttonBuyProductConfirm.Size = New System.Drawing.Size(91, 28)
        Me.buttonBuyProductConfirm.TabIndex = 13
        Me.buttonBuyProductConfirm.Text = "Confirm"
        Me.buttonBuyProductConfirm.UseVisualStyleBackColor = False
        '
        'buttonBuyProductRemove
        '
        Me.buttonBuyProductRemove.BackColor = System.Drawing.Color.Red
        Me.buttonBuyProductRemove.FlatAppearance.BorderSize = 0
        Me.buttonBuyProductRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBuyProductRemove.ForeColor = System.Drawing.Color.White
        Me.buttonBuyProductRemove.Location = New System.Drawing.Point(6, 526)
        Me.buttonBuyProductRemove.Name = "buttonBuyProductRemove"
        Me.buttonBuyProductRemove.Size = New System.Drawing.Size(91, 28)
        Me.buttonBuyProductRemove.TabIndex = 14
        Me.buttonBuyProductRemove.Text = "Remove"
        Me.buttonBuyProductRemove.UseVisualStyleBackColor = False
        '
        'textBuyProductChange
        '
        Me.textBuyProductChange.Location = New System.Drawing.Point(319, 396)
        Me.textBuyProductChange.Name = "textBuyProductChange"
        Me.textBuyProductChange.Size = New System.Drawing.Size(182, 29)
        Me.textBuyProductChange.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 399)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 21)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Total"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(250, 399)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 21)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Change"
        '
        'textBuyProductTotalPaid
        '
        Me.textBuyProductTotalPaid.Location = New System.Drawing.Point(54, 396)
        Me.textBuyProductTotalPaid.Name = "textBuyProductTotalPaid"
        Me.textBuyProductTotalPaid.Size = New System.Drawing.Size(182, 29)
        Me.textBuyProductTotalPaid.TabIndex = 24
        '
        'textBuyProductPaid
        '
        Me.textBuyProductPaid.Location = New System.Drawing.Point(54, 431)
        Me.textBuyProductPaid.Name = "textBuyProductPaid"
        Me.textBuyProductPaid.Size = New System.Drawing.Size(182, 29)
        Me.textBuyProductPaid.TabIndex = 26
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 434)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 21)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Paid"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.labelBuyProductStock)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.comboAddProductSearch)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.textBuyProductSearch)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.textBuyProductPrice)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.textBuyProductQty)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.listboxBuyProductName)
        Me.GroupBox2.Controls.Add(Me.textBuyProductTotal)
        Me.GroupBox2.Controls.Add(Me.buttonBuyProductAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 345)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Details"
        '
        'labelBuyProductStock
        '
        Me.labelBuyProductStock.AutoSize = True
        Me.labelBuyProductStock.Location = New System.Drawing.Point(259, 122)
        Me.labelBuyProductStock.Name = "labelBuyProductStock"
        Me.labelBuyProductStock.Size = New System.Drawing.Size(16, 21)
        Me.labelBuyProductStock.TabIndex = 18
        Me.labelBuyProductStock.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(181, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 21)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Stock left : "
        '
        'comboAddProductSearch
        '
        Me.comboAddProductSearch.FormattingEnabled = True
        Me.comboAddProductSearch.Items.AddRange(New Object() {"ID", "Name", "Barcode"})
        Me.comboAddProductSearch.Location = New System.Drawing.Point(91, 49)
        Me.comboAddProductSearch.Name = "comboAddProductSearch"
        Me.comboAddProductSearch.Size = New System.Drawing.Size(121, 29)
        Me.comboAddProductSearch.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Search By"
        '
        'textBuyProductSearch
        '
        Me.textBuyProductSearch.Location = New System.Drawing.Point(218, 49)
        Me.textBuyProductSearch.Name = "textBuyProductSearch"
        Me.textBuyProductSearch.Size = New System.Drawing.Size(362, 29)
        Me.textBuyProductSearch.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 21)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Price"
        '
        'textBuyProductPrice
        '
        Me.textBuyProductPrice.Location = New System.Drawing.Point(91, 84)
        Me.textBuyProductPrice.Name = "textBuyProductPrice"
        Me.textBuyProductPrice.Size = New System.Drawing.Size(155, 29)
        Me.textBuyProductPrice.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 21)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Qty"
        '
        'textBuyProductQty
        '
        Me.textBuyProductQty.Location = New System.Drawing.Point(91, 119)
        Me.textBuyProductQty.Name = "textBuyProductQty"
        Me.textBuyProductQty.Size = New System.Drawing.Size(78, 29)
        Me.textBuyProductQty.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Total"
        '
        'listboxBuyProductName
        '
        Me.listboxBuyProductName.FormattingEnabled = True
        Me.listboxBuyProductName.ItemHeight = 21
        Me.listboxBuyProductName.Location = New System.Drawing.Point(6, 211)
        Me.listboxBuyProductName.Name = "listboxBuyProductName"
        Me.listboxBuyProductName.Size = New System.Drawing.Size(574, 67)
        Me.listboxBuyProductName.TabIndex = 16
        '
        'textBuyProductTotal
        '
        Me.textBuyProductTotal.Location = New System.Drawing.Point(91, 154)
        Me.textBuyProductTotal.Name = "textBuyProductTotal"
        Me.textBuyProductTotal.Size = New System.Drawing.Size(170, 29)
        Me.textBuyProductTotal.TabIndex = 10
        '
        'buttonBuyProductAdd
        '
        Me.buttonBuyProductAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.buttonBuyProductAdd.FlatAppearance.BorderSize = 0
        Me.buttonBuyProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBuyProductAdd.ForeColor = System.Drawing.Color.White
        Me.buttonBuyProductAdd.Location = New System.Drawing.Point(489, 311)
        Me.buttonBuyProductAdd.Name = "buttonBuyProductAdd"
        Me.buttonBuyProductAdd.Size = New System.Drawing.Size(91, 28)
        Me.buttonBuyProductAdd.TabIndex = 12
        Me.buttonBuyProductAdd.Text = "Add"
        Me.buttonBuyProductAdd.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.textTransactionCashierName)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.textTransactionCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.textTransactionPurchaseID)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 209)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Detail"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 21)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Purchase ID"
        '
        'textTransactionCashierName
        '
        Me.textTransactionCashierName.Location = New System.Drawing.Point(137, 83)
        Me.textTransactionCashierName.Name = "textTransactionCashierName"
        Me.textTransactionCashierName.Size = New System.Drawing.Size(278, 29)
        Me.textTransactionCashierName.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 21)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Cashier Name"
        '
        'textTransactionCustomerName
        '
        Me.textTransactionCustomerName.Location = New System.Drawing.Point(137, 118)
        Me.textTransactionCustomerName.Name = "textTransactionCustomerName"
        Me.textTransactionCustomerName.Size = New System.Drawing.Size(278, 29)
        Me.textTransactionCustomerName.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 121)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 21)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Customer Name"
        '
        'textTransactionPurchaseID
        '
        Me.textTransactionPurchaseID.Location = New System.Drawing.Point(137, 48)
        Me.textTransactionPurchaseID.Name = "textTransactionPurchaseID"
        Me.textTransactionPurchaseID.Size = New System.Drawing.Size(133, 29)
        Me.textTransactionPurchaseID.TabIndex = 21
        '
        'tabStock
        '
        Me.tabStock.BackColor = System.Drawing.Color.Transparent
        Me.tabStock.Controls.Add(Me.comboStockDASC)
        Me.tabStock.Controls.Add(Me.comboStockOrderBy)
        Me.tabStock.Controls.Add(Me.Label14)
        Me.tabStock.Controls.Add(Me.buttonProductEmpty)
        Me.tabStock.Controls.Add(Me.buttonProductTotal)
        Me.tabStock.Controls.Add(Me.Button1)
        Me.tabStock.Controls.Add(Me.ListView1)
        Me.tabStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabStock.Location = New System.Drawing.Point(4, 24)
        Me.tabStock.Name = "tabStock"
        Me.tabStock.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabStock.Size = New System.Drawing.Size(1123, 585)
        Me.tabStock.TabIndex = 1
        Me.tabStock.Text = "Stock"
        '
        'comboStockDASC
        '
        Me.comboStockDASC.FormattingEnabled = True
        Me.comboStockDASC.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.comboStockDASC.Location = New System.Drawing.Point(234, 55)
        Me.comboStockDASC.Name = "comboStockDASC"
        Me.comboStockDASC.Size = New System.Drawing.Size(134, 29)
        Me.comboStockDASC.TabIndex = 8
        '
        'comboStockOrderBy
        '
        Me.comboStockOrderBy.FormattingEnabled = True
        Me.comboStockOrderBy.Items.AddRange(New Object() {"ID", "Name", "Barcode", "Price", "Stock"})
        Me.comboStockOrderBy.Location = New System.Drawing.Point(94, 55)
        Me.comboStockOrderBy.Name = "comboStockOrderBy"
        Me.comboStockOrderBy.Size = New System.Drawing.Size(134, 29)
        Me.comboStockOrderBy.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 21)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Order by"
        '
        'buttonProductEmpty
        '
        Me.buttonProductEmpty.BackColor = System.Drawing.Color.Red
        Me.buttonProductEmpty.FlatAppearance.BorderSize = 0
        Me.buttonProductEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonProductEmpty.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonProductEmpty.ForeColor = System.Drawing.Color.White
        Me.buttonProductEmpty.Location = New System.Drawing.Point(183, 496)
        Me.buttonProductEmpty.Name = "buttonProductEmpty"
        Me.buttonProductEmpty.Size = New System.Drawing.Size(139, 31)
        Me.buttonProductEmpty.TabIndex = 5
        Me.buttonProductEmpty.Text = "Empty Product : 0"
        Me.buttonProductEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonProductEmpty.UseVisualStyleBackColor = False
        '
        'buttonProductTotal
        '
        Me.buttonProductTotal.BackColor = System.Drawing.Color.ForestGreen
        Me.buttonProductTotal.FlatAppearance.BorderSize = 0
        Me.buttonProductTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonProductTotal.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonProductTotal.ForeColor = System.Drawing.Color.White
        Me.buttonProductTotal.Location = New System.Drawing.Point(7, 496)
        Me.buttonProductTotal.Name = "buttonProductTotal"
        Me.buttonProductTotal.Size = New System.Drawing.Size(139, 31)
        Me.buttonProductTotal.TabIndex = 4
        Me.buttonProductTotal.Text = "Total Product : 0"
        Me.buttonProductTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonProductTotal.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(374, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cID, Me.cName, Me.cPrice, Me.cBarcode, Me.cStock})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(7, 93)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1102, 397)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'cID
        '
        Me.cID.Text = "ID"
        '
        'cName
        '
        Me.cName.Text = "Nama Produk"
        Me.cName.Width = 680
        '
        'cPrice
        '
        Me.cPrice.Text = "Harga"
        Me.cPrice.Width = 150
        '
        'cBarcode
        '
        Me.cBarcode.Text = "Barcode"
        Me.cBarcode.Width = 120
        '
        'cStock
        '
        Me.cStock.Text = "Stock"
        Me.cStock.Width = 65
        '
        'tabStockAdd
        '
        Me.tabStockAdd.Controls.Add(Me.buttonAddProductSubmit)
        Me.tabStockAdd.Controls.Add(Me.textAddProductStock)
        Me.tabStockAdd.Controls.Add(Me.labelAddProductStock)
        Me.tabStockAdd.Controls.Add(Me.textAddProductBarcode)
        Me.tabStockAdd.Controls.Add(Me.labelAddProductBarcode)
        Me.tabStockAdd.Controls.Add(Me.textAddProductPrice)
        Me.tabStockAdd.Controls.Add(Me.labelAddProductPrice)
        Me.tabStockAdd.Controls.Add(Me.textAddProductName)
        Me.tabStockAdd.Controls.Add(Me.labelAddProductName)
        Me.tabStockAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabStockAdd.Location = New System.Drawing.Point(4, 24)
        Me.tabStockAdd.Name = "tabStockAdd"
        Me.tabStockAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStockAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabStockAdd.Size = New System.Drawing.Size(1123, 585)
        Me.tabStockAdd.TabIndex = 5
        Me.tabStockAdd.Text = "Add"
        Me.tabStockAdd.UseVisualStyleBackColor = True
        '
        'buttonAddProductSubmit
        '
        Me.buttonAddProductSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.buttonAddProductSubmit.FlatAppearance.BorderSize = 0
        Me.buttonAddProductSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAddProductSubmit.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonAddProductSubmit.ForeColor = System.Drawing.Color.White
        Me.buttonAddProductSubmit.Location = New System.Drawing.Point(528, 391)
        Me.buttonAddProductSubmit.Name = "buttonAddProductSubmit"
        Me.buttonAddProductSubmit.Size = New System.Drawing.Size(119, 32)
        Me.buttonAddProductSubmit.TabIndex = 8
        Me.buttonAddProductSubmit.Text = "Add Product"
        Me.buttonAddProductSubmit.UseVisualStyleBackColor = False
        '
        'textAddProductStock
        '
        Me.textAddProductStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textAddProductStock.Location = New System.Drawing.Point(156, 258)
        Me.textAddProductStock.Name = "textAddProductStock"
        Me.textAddProductStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textAddProductStock.Size = New System.Drawing.Size(447, 29)
        Me.textAddProductStock.TabIndex = 7
        '
        'labelAddProductStock
        '
        Me.labelAddProductStock.AutoSize = True
        Me.labelAddProductStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddProductStock.Location = New System.Drawing.Point(59, 261)
        Me.labelAddProductStock.Name = "labelAddProductStock"
        Me.labelAddProductStock.Size = New System.Drawing.Size(47, 21)
        Me.labelAddProductStock.TabIndex = 6
        Me.labelAddProductStock.Text = "Stock"
        '
        'textAddProductBarcode
        '
        Me.textAddProductBarcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textAddProductBarcode.Location = New System.Drawing.Point(156, 202)
        Me.textAddProductBarcode.Name = "textAddProductBarcode"
        Me.textAddProductBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textAddProductBarcode.Size = New System.Drawing.Size(447, 29)
        Me.textAddProductBarcode.TabIndex = 5
        '
        'labelAddProductBarcode
        '
        Me.labelAddProductBarcode.AutoSize = True
        Me.labelAddProductBarcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddProductBarcode.Location = New System.Drawing.Point(59, 205)
        Me.labelAddProductBarcode.Name = "labelAddProductBarcode"
        Me.labelAddProductBarcode.Size = New System.Drawing.Size(66, 21)
        Me.labelAddProductBarcode.TabIndex = 4
        Me.labelAddProductBarcode.Text = "Barcode"
        '
        'textAddProductPrice
        '
        Me.textAddProductPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textAddProductPrice.Location = New System.Drawing.Point(156, 151)
        Me.textAddProductPrice.Name = "textAddProductPrice"
        Me.textAddProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textAddProductPrice.Size = New System.Drawing.Size(447, 29)
        Me.textAddProductPrice.TabIndex = 3
        '
        'labelAddProductPrice
        '
        Me.labelAddProductPrice.AutoSize = True
        Me.labelAddProductPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddProductPrice.Location = New System.Drawing.Point(59, 154)
        Me.labelAddProductPrice.Name = "labelAddProductPrice"
        Me.labelAddProductPrice.Size = New System.Drawing.Size(44, 21)
        Me.labelAddProductPrice.TabIndex = 2
        Me.labelAddProductPrice.Text = "Price"
        '
        'textAddProductName
        '
        Me.textAddProductName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textAddProductName.Location = New System.Drawing.Point(156, 96)
        Me.textAddProductName.Name = "textAddProductName"
        Me.textAddProductName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textAddProductName.Size = New System.Drawing.Size(491, 29)
        Me.textAddProductName.TabIndex = 1
        '
        'labelAddProductName
        '
        Me.labelAddProductName.AutoSize = True
        Me.labelAddProductName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddProductName.Location = New System.Drawing.Point(59, 99)
        Me.labelAddProductName.Name = "labelAddProductName"
        Me.labelAddProductName.Size = New System.Drawing.Size(52, 21)
        Me.labelAddProductName.TabIndex = 0
        Me.labelAddProductName.Text = "Name"
        '
        'tabStockModify
        '
        Me.tabStockModify.Controls.Add(Me.buttonModifyProductDelete)
        Me.tabStockModify.Controls.Add(Me.labelModifyProductError)
        Me.tabStockModify.Controls.Add(Me.comboboxModifyProductSearch)
        Me.tabStockModify.Controls.Add(Me.textModifyProductSearch)
        Me.tabStockModify.Controls.Add(Me.Label7)
        Me.tabStockModify.Controls.Add(Me.buttonModifyProductSubmit)
        Me.tabStockModify.Controls.Add(Me.textModifyProductStock)
        Me.tabStockModify.Controls.Add(Me.Label1)
        Me.tabStockModify.Controls.Add(Me.textModifyProductBarcode)
        Me.tabStockModify.Controls.Add(Me.Label4)
        Me.tabStockModify.Controls.Add(Me.textModifyProductPrice)
        Me.tabStockModify.Controls.Add(Me.Label5)
        Me.tabStockModify.Controls.Add(Me.textModifyProductName)
        Me.tabStockModify.Controls.Add(Me.Label6)
        Me.tabStockModify.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabStockModify.Location = New System.Drawing.Point(4, 24)
        Me.tabStockModify.Name = "tabStockModify"
        Me.tabStockModify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabStockModify.Size = New System.Drawing.Size(1123, 585)
        Me.tabStockModify.TabIndex = 6
        Me.tabStockModify.Text = "Modify"
        Me.tabStockModify.UseVisualStyleBackColor = True
        '
        'buttonModifyProductDelete
        '
        Me.buttonModifyProductDelete.BackColor = System.Drawing.Color.Red
        Me.buttonModifyProductDelete.FlatAppearance.BorderSize = 0
        Me.buttonModifyProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonModifyProductDelete.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonModifyProductDelete.ForeColor = System.Drawing.Color.White
        Me.buttonModifyProductDelete.Location = New System.Drawing.Point(516, 424)
        Me.buttonModifyProductDelete.Name = "buttonModifyProductDelete"
        Me.buttonModifyProductDelete.Size = New System.Drawing.Size(119, 32)
        Me.buttonModifyProductDelete.TabIndex = 22
        Me.buttonModifyProductDelete.Text = "Delete"
        Me.buttonModifyProductDelete.UseVisualStyleBackColor = False
        '
        'labelModifyProductError
        '
        Me.labelModifyProductError.AutoSize = True
        Me.labelModifyProductError.ForeColor = System.Drawing.Color.Red
        Me.labelModifyProductError.Location = New System.Drawing.Point(629, 83)
        Me.labelModifyProductError.Name = "labelModifyProductError"
        Me.labelModifyProductError.Size = New System.Drawing.Size(142, 21)
        Me.labelModifyProductError.TabIndex = 21
        Me.labelModifyProductError.Text = "Product Not Found"
        '
        'comboboxModifyProductSearch
        '
        Me.comboboxModifyProductSearch.FormattingEnabled = True
        Me.comboboxModifyProductSearch.Items.AddRange(New Object() {"ID", "Barcode"})
        Me.comboboxModifyProductSearch.Location = New System.Drawing.Point(269, 80)
        Me.comboboxModifyProductSearch.Name = "comboboxModifyProductSearch"
        Me.comboboxModifyProductSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.comboboxModifyProductSearch.Size = New System.Drawing.Size(121, 29)
        Me.comboboxModifyProductSearch.TabIndex = 20
        '
        'textModifyProductSearch
        '
        Me.textModifyProductSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textModifyProductSearch.Location = New System.Drawing.Point(396, 80)
        Me.textModifyProductSearch.Name = "textModifyProductSearch"
        Me.textModifyProductSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textModifyProductSearch.Size = New System.Drawing.Size(227, 29)
        Me.textModifyProductSearch.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(172, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Search By"
        '
        'buttonModifyProductSubmit
        '
        Me.buttonModifyProductSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.buttonModifyProductSubmit.FlatAppearance.BorderSize = 0
        Me.buttonModifyProductSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonModifyProductSubmit.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonModifyProductSubmit.ForeColor = System.Drawing.Color.White
        Me.buttonModifyProductSubmit.Location = New System.Drawing.Point(641, 424)
        Me.buttonModifyProductSubmit.Name = "buttonModifyProductSubmit"
        Me.buttonModifyProductSubmit.Size = New System.Drawing.Size(119, 32)
        Me.buttonModifyProductSubmit.TabIndex = 17
        Me.buttonModifyProductSubmit.Text = "Modify"
        Me.buttonModifyProductSubmit.UseVisualStyleBackColor = False
        '
        'textModifyProductStock
        '
        Me.textModifyProductStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textModifyProductStock.Location = New System.Drawing.Point(269, 291)
        Me.textModifyProductStock.Name = "textModifyProductStock"
        Me.textModifyProductStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textModifyProductStock.Size = New System.Drawing.Size(447, 29)
        Me.textModifyProductStock.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(172, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Stock"
        '
        'textModifyProductBarcode
        '
        Me.textModifyProductBarcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textModifyProductBarcode.Location = New System.Drawing.Point(269, 235)
        Me.textModifyProductBarcode.Name = "textModifyProductBarcode"
        Me.textModifyProductBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textModifyProductBarcode.Size = New System.Drawing.Size(447, 29)
        Me.textModifyProductBarcode.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(172, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Barcode"
        '
        'textModifyProductPrice
        '
        Me.textModifyProductPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textModifyProductPrice.Location = New System.Drawing.Point(269, 184)
        Me.textModifyProductPrice.Name = "textModifyProductPrice"
        Me.textModifyProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textModifyProductPrice.Size = New System.Drawing.Size(447, 29)
        Me.textModifyProductPrice.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(172, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Price"
        '
        'textModifyProductName
        '
        Me.textModifyProductName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textModifyProductName.Location = New System.Drawing.Point(269, 129)
        Me.textModifyProductName.Name = "textModifyProductName"
        Me.textModifyProductName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textModifyProductName.Size = New System.Drawing.Size(681, 29)
        Me.textModifyProductName.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(172, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Name"
        '
        'tabAccountMan
        '
        Me.tabAccountMan.Controls.Add(Me.buttonAccRefresh)
        Me.tabAccountMan.Controls.Add(Me.buttonAddAccountSubmit)
        Me.tabAccountMan.Controls.Add(Me.comboAddAccountType)
        Me.tabAccountMan.Controls.Add(Me.Label18)
        Me.tabAccountMan.Controls.Add(Me.textAddAccountPassword)
        Me.tabAccountMan.Controls.Add(Me.Label17)
        Me.tabAccountMan.Controls.Add(Me.textAddAccountID)
        Me.tabAccountMan.Controls.Add(Me.textAddAccountName)
        Me.tabAccountMan.Controls.Add(Me.Label16)
        Me.tabAccountMan.Controls.Add(Me.Label15)
        Me.tabAccountMan.Controls.Add(Me.ListView3)
        Me.tabAccountMan.Controls.Add(Me.buttonAccountModify)
        Me.tabAccountMan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabAccountMan.Location = New System.Drawing.Point(4, 24)
        Me.tabAccountMan.Name = "tabAccountMan"
        Me.tabAccountMan.Size = New System.Drawing.Size(1123, 585)
        Me.tabAccountMan.TabIndex = 7
        Me.tabAccountMan.Text = "Account Management"
        Me.tabAccountMan.UseVisualStyleBackColor = True
        '
        'buttonAccRefresh
        '
        Me.buttonAccRefresh.BackColor = System.Drawing.Color.Aqua
        Me.buttonAccRefresh.FlatAppearance.BorderSize = 0
        Me.buttonAccRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAccRefresh.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonAccRefresh.ForeColor = System.Drawing.Color.White
        Me.buttonAccRefresh.Location = New System.Drawing.Point(462, 521)
        Me.buttonAccRefresh.Name = "buttonAccRefresh"
        Me.buttonAccRefresh.Size = New System.Drawing.Size(119, 32)
        Me.buttonAccRefresh.TabIndex = 31
        Me.buttonAccRefresh.Text = "Refresh"
        Me.buttonAccRefresh.UseVisualStyleBackColor = False
        '
        'buttonAddAccountSubmit
        '
        Me.buttonAddAccountSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.buttonAddAccountSubmit.FlatAppearance.BorderSize = 0
        Me.buttonAddAccountSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAddAccountSubmit.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonAddAccountSubmit.ForeColor = System.Drawing.Color.White
        Me.buttonAddAccountSubmit.Location = New System.Drawing.Point(337, 235)
        Me.buttonAddAccountSubmit.Name = "buttonAddAccountSubmit"
        Me.buttonAddAccountSubmit.Size = New System.Drawing.Size(119, 32)
        Me.buttonAddAccountSubmit.TabIndex = 30
        Me.buttonAddAccountSubmit.Text = "Add"
        Me.buttonAddAccountSubmit.UseVisualStyleBackColor = False
        '
        'comboAddAccountType
        '
        Me.comboAddAccountType.FormattingEnabled = True
        Me.comboAddAccountType.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.comboAddAccountType.Location = New System.Drawing.Point(156, 151)
        Me.comboAddAccountType.Name = "comboAddAccountType"
        Me.comboAddAccountType.Size = New System.Drawing.Size(121, 29)
        Me.comboAddAccountType.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 154)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 21)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Account Type"
        '
        'textAddAccountPassword
        '
        Me.textAddAccountPassword.Location = New System.Drawing.Point(156, 116)
        Me.textAddAccountPassword.Name = "textAddAccountPassword"
        Me.textAddAccountPassword.Size = New System.Drawing.Size(300, 29)
        Me.textAddAccountPassword.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 21)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Account Password"
        '
        'textAddAccountID
        '
        Me.textAddAccountID.Location = New System.Drawing.Point(156, 81)
        Me.textAddAccountID.Name = "textAddAccountID"
        Me.textAddAccountID.Size = New System.Drawing.Size(300, 29)
        Me.textAddAccountID.TabIndex = 25
        '
        'textAddAccountName
        '
        Me.textAddAccountName.Location = New System.Drawing.Point(156, 46)
        Me.textAddAccountName.Name = "textAddAccountName"
        Me.textAddAccountName.Size = New System.Drawing.Size(300, 29)
        Me.textAddAccountName.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 21)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Account ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 21)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Account Owner"
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.uID, Me.uOwner, Me.uType, Me.uLast})
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(462, 13)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(653, 502)
        Me.ListView3.TabIndex = 21
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'uID
        '
        Me.uID.Text = "ID"
        Me.uID.Width = 120
        '
        'uOwner
        '
        Me.uOwner.Text = "Name"
        Me.uOwner.Width = 240
        '
        'uType
        '
        Me.uType.Text = "Type"
        Me.uType.Width = 120
        '
        'uLast
        '
        Me.uLast.Text = "Last Online"
        Me.uLast.Width = 150
        '
        'buttonAccountModify
        '
        Me.buttonAccountModify.BackColor = System.Drawing.Color.Gold
        Me.buttonAccountModify.FlatAppearance.BorderSize = 0
        Me.buttonAccountModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAccountModify.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonAccountModify.ForeColor = System.Drawing.Color.White
        Me.buttonAccountModify.Location = New System.Drawing.Point(996, 521)
        Me.buttonAccountModify.Name = "buttonAccountModify"
        Me.buttonAccountModify.Size = New System.Drawing.Size(119, 32)
        Me.buttonAccountModify.TabIndex = 20
        Me.buttonAccountModify.Text = "Modify"
        Me.buttonAccountModify.UseVisualStyleBackColor = False
        '
        'tabAccount
        '
        Me.tabAccount.BackColor = System.Drawing.Color.Transparent
        Me.tabAccount.Controls.Add(Me.Panel2)
        Me.tabAccount.Controls.Add(Me.labelName)
        Me.tabAccount.Controls.Add(Me.Label8)
        Me.tabAccount.Controls.Add(Me.buttonAccountLogout)
        Me.tabAccount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabAccount.Location = New System.Drawing.Point(4, 24)
        Me.tabAccount.Name = "tabAccount"
        Me.tabAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabAccount.Size = New System.Drawing.Size(1123, 585)
        Me.tabAccount.TabIndex = 2
        Me.tabAccount.Text = "Account"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Location = New System.Drawing.Point(628, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 566)
        Me.Panel2.TabIndex = 18
        '
        'labelName
        '
        Me.labelName.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelName.Location = New System.Drawing.Point(16, 65)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(597, 171)
        Me.labelName.TabIndex = 17
        Me.labelName.Text = "RandomUserNameHere"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(16, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(293, 46)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Hi, Welcome Back,"
        '
        'buttonAccountLogout
        '
        Me.buttonAccountLogout.BackColor = System.Drawing.Color.Red
        Me.buttonAccountLogout.FlatAppearance.BorderSize = 0
        Me.buttonAccountLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonAccountLogout.ForeColor = System.Drawing.Color.White
        Me.buttonAccountLogout.Location = New System.Drawing.Point(6, 543)
        Me.buttonAccountLogout.Name = "buttonAccountLogout"
        Me.buttonAccountLogout.Size = New System.Drawing.Size(106, 34)
        Me.buttonAccountLogout.TabIndex = 15
        Me.buttonAccountLogout.Text = "Log Out"
        Me.buttonAccountLogout.UseVisualStyleBackColor = False
        '
        'tabLogin
        '
        Me.tabLogin.BackColor = System.Drawing.Color.Transparent
        Me.tabLogin.Controls.Add(Me.SplitContainer1)
        Me.tabLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabLogin.Location = New System.Drawing.Point(4, 24)
        Me.tabLogin.Name = "tabLogin"
        Me.tabLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabLogin.Size = New System.Drawing.Size(1123, 585)
        Me.tabLogin.TabIndex = 4
        Me.tabLogin.Text = "Login"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.labelLoginError)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.textboxPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.buttonLogin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.textboxUserID)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.imageLogin)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(1110, 573)
        Me.SplitContainer1.SplitterDistance = 613
        Me.SplitContainer1.TabIndex = 5
        '
        'labelLoginError
        '
        Me.labelLoginError.AutoSize = True
        Me.labelLoginError.ForeColor = System.Drawing.Color.Red
        Me.labelLoginError.Location = New System.Drawing.Point(95, 296)
        Me.labelLoginError.Name = "labelLoginError"
        Me.labelLoginError.Size = New System.Drawing.Size(343, 21)
        Me.labelLoginError.TabIndex = 5
        Me.labelLoginError.Text = "User credentials doesn't match the existing ones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(95, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User ID"
        '
        'textboxPassword
        '
        Me.textboxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textboxPassword.Location = New System.Drawing.Point(200, 217)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textboxPassword.Size = New System.Drawing.Size(237, 29)
        Me.textboxPassword.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(95, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'buttonLogin
        '
        Me.buttonLogin.Location = New System.Drawing.Point(351, 252)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(86, 30)
        Me.buttonLogin.TabIndex = 4
        Me.buttonLogin.Text = "Login"
        Me.buttonLogin.UseVisualStyleBackColor = True
        '
        'textboxUserID
        '
        Me.textboxUserID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textboxUserID.Location = New System.Drawing.Point(200, 169)
        Me.textboxUserID.Name = "textboxUserID"
        Me.textboxUserID.Size = New System.Drawing.Size(237, 29)
        Me.textboxUserID.TabIndex = 2
        '
        'imageLogin
        '
        Me.imageLogin.BackgroundImage = CType(resources.GetObject("imageLogin.BackgroundImage"), System.Drawing.Image)
        Me.imageLogin.Location = New System.Drawing.Point(3, 4)
        Me.imageLogin.Name = "imageLogin"
        Me.imageLogin.Size = New System.Drawing.Size(487, 566)
        Me.imageLogin.TabIndex = 0
        '
        'tabAccountAdd
        '
        Me.tabAccountAdd.Controls.Add(Me.Panel1)
        Me.tabAccountAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabAccountAdd.Location = New System.Drawing.Point(4, 24)
        Me.tabAccountAdd.Name = "tabAccountAdd"
        Me.tabAccountAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabAccountAdd.Size = New System.Drawing.Size(1123, 585)
        Me.tabAccountAdd.TabIndex = 8
        Me.tabAccountAdd.Text = "Add Account"
        Me.tabAccountAdd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(628, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 566)
        Me.Panel1.TabIndex = 19
        '
        'tabAccountModify
        '
        Me.tabAccountModify.Controls.Add(Me.Button6)
        Me.tabAccountModify.Controls.Add(Me.textAccountModifyType)
        Me.tabAccountModify.Controls.Add(Me.Label25)
        Me.tabAccountModify.Controls.Add(Me.textAccountModifyPassword)
        Me.tabAccountModify.Controls.Add(Me.Label26)
        Me.tabAccountModify.Controls.Add(Me.textAccountModifyID)
        Me.tabAccountModify.Controls.Add(Me.textAccountModifyOwner)
        Me.tabAccountModify.Controls.Add(Me.Label27)
        Me.tabAccountModify.Controls.Add(Me.Label28)
        Me.tabAccountModify.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tabAccountModify.Location = New System.Drawing.Point(4, 24)
        Me.tabAccountModify.Name = "tabAccountModify"
        Me.tabAccountModify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabAccountModify.Size = New System.Drawing.Size(1123, 585)
        Me.tabAccountModify.TabIndex = 9
        Me.tabAccountModify.Text = "Modify Account"
        Me.tabAccountModify.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LimeGreen
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(342, 322)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 32)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Modify"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'textAccountModifyType
        '
        Me.textAccountModifyType.FormattingEnabled = True
        Me.textAccountModifyType.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.textAccountModifyType.Location = New System.Drawing.Point(161, 238)
        Me.textAccountModifyType.Name = "textAccountModifyType"
        Me.textAccountModifyType.Size = New System.Drawing.Size(121, 29)
        Me.textAccountModifyType.TabIndex = 38
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 241)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(102, 21)
        Me.Label25.TabIndex = 37
        Me.Label25.Text = "Account Type"
        '
        'textAccountModifyPassword
        '
        Me.textAccountModifyPassword.Location = New System.Drawing.Point(161, 203)
        Me.textAccountModifyPassword.Name = "textAccountModifyPassword"
        Me.textAccountModifyPassword.Size = New System.Drawing.Size(300, 29)
        Me.textAccountModifyPassword.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 206)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(136, 21)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Account Password"
        '
        'textAccountModifyID
        '
        Me.textAccountModifyID.Location = New System.Drawing.Point(161, 168)
        Me.textAccountModifyID.Name = "textAccountModifyID"
        Me.textAccountModifyID.Size = New System.Drawing.Size(300, 29)
        Me.textAccountModifyID.TabIndex = 34
        '
        'textAccountModifyOwner
        '
        Me.textAccountModifyOwner.Location = New System.Drawing.Point(161, 133)
        Me.textAccountModifyOwner.Name = "textAccountModifyOwner"
        Me.textAccountModifyOwner.Size = New System.Drawing.Size(300, 29)
        Me.textAccountModifyOwner.TabIndex = 33
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(15, 171)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 21)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Account ID"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(15, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(117, 21)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Account Owner"
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panelMain.Controls.Add(Me.tabMain)
        Me.panelMain.Controls.Add(Me.panelLeft)
        Me.panelMain.Controls.Add(Me.panelTop)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1270, 682)
        Me.panelMain.TabIndex = 1
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 682)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KyroPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.panelLeft.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabReport.ResumeLayout(False)
        Me.tabTransaction.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabStock.ResumeLayout(False)
        Me.tabStock.PerformLayout()
        Me.tabStockAdd.ResumeLayout(False)
        Me.tabStockAdd.PerformLayout()
        Me.tabStockModify.ResumeLayout(False)
        Me.tabStockModify.PerformLayout()
        Me.tabAccountMan.ResumeLayout(False)
        Me.tabAccountMan.PerformLayout()
        Me.tabAccount.ResumeLayout(False)
        Me.tabAccount.PerformLayout()
        Me.tabLogin.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tabAccountAdd.ResumeLayout(False)
        Me.tabAccountModify.ResumeLayout(False)
        Me.tabAccountModify.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents panelLeft As Panel
    Friend WithEvents buttonReport As Button
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabReport As TabPage
    Friend WithEvents tabTransaction As TabPage
    Friend WithEvents tabStock As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents cID As ColumnHeader
    Friend WithEvents cName As ColumnHeader
    Friend WithEvents cPrice As ColumnHeader
    Friend WithEvents cStock As ColumnHeader
    Friend WithEvents tabAccount As TabPage
    Friend WithEvents tabLogin As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents textboxPassword As TextBox
    Friend WithEvents buttonLogin As Button
    Friend WithEvents textboxUserID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents buttonAccountMan As Button
    Friend WithEvents buttonStock As Button
    Friend WithEvents buttonTransaction As Button
    Friend WithEvents buttonAccount As Button
    Friend WithEvents labelTitle As Label
    Friend WithEvents buttonStockAdd As Button
    Friend WithEvents buttonStockModify As Button
    Friend WithEvents buttonProductEmpty As Button
    Friend WithEvents buttonProductTotal As Button
    Friend WithEvents cBarcode As ColumnHeader
    Friend WithEvents tabStockAdd As TabPage
    Friend WithEvents labelAddProductName As Label
    Friend WithEvents textAddProductName As TextBox
    Friend WithEvents textAddProductBarcode As TextBox
    Friend WithEvents labelAddProductBarcode As Label
    Friend WithEvents textAddProductPrice As TextBox
    Friend WithEvents labelAddProductPrice As Label
    Friend WithEvents textAddProductStock As TextBox
    Friend WithEvents labelAddProductStock As Label
    Friend WithEvents tabStockModify As TabPage
    Friend WithEvents buttonAddProductSubmit As Button
    Friend WithEvents comboboxModifyProductSearch As ComboBox
    Friend WithEvents textModifyProductSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents buttonModifyProductSubmit As Button
    Friend WithEvents textModifyProductStock As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textModifyProductBarcode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textModifyProductPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textModifyProductName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents labelModifyProductError As Label
    Friend WithEvents buttonModifyProductDelete As Button
    Friend WithEvents comboAddProductSearch As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textBuyProductSearch As TextBox
    Friend WithEvents textBuyProductTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents textBuyProductQty As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents textBuyProductPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents buttonBuyProductRemove As Button
    Friend WithEvents buttonBuyProductConfirm As Button
    Friend WithEvents buttonBuyProductAdd As Button
    Friend WithEvents listBuyProductCart As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents listboxBuyProductName As ListBox
    Friend WithEvents comboStockDASC As ComboBox
    Friend WithEvents comboStockOrderBy As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tabAccountMan As TabPage
    Friend WithEvents labelLoginError As Label
    Friend WithEvents imageLogin As Panel
    Friend WithEvents tabAccountAdd As TabPage
    Friend WithEvents tabAccountModify As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents buttonAccountModify As Button
    Friend WithEvents buttonAccountLogout As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents textTransactionCashierName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents textTransactionPurchaseID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents textTransactionCustomerName As TextBox
    Friend WithEvents textBuyProductChange As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents textBuyProductPaid As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents textBuyProductTotalPaid As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents labelBuyProductStock As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents purchase_id As ColumnHeader
    Friend WithEvents purchase_date As ColumnHeader
    Friend WithEvents customer_name As ColumnHeader
    Friend WithEvents cashier_name As ColumnHeader
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents buttonReportDetails As Button
    Friend WithEvents buttonReportView As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelName As Label
    Friend WithEvents ListView3 As ListView
    Friend WithEvents uID As ColumnHeader
    Friend WithEvents uOwner As ColumnHeader
    Friend WithEvents uLast As ColumnHeader
    Friend WithEvents buttonAddAccountSubmit As Button
    Friend WithEvents comboAddAccountType As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents textAddAccountPassword As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents textAddAccountID As TextBox
    Friend WithEvents textAddAccountName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents buttonAccRefresh As Button
    Friend WithEvents uType As ColumnHeader
    Friend WithEvents Button6 As Button
    Friend WithEvents textAccountModifyType As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents textAccountModifyPassword As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents textAccountModifyID As TextBox
    Friend WithEvents textAccountModifyOwner As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
End Class
