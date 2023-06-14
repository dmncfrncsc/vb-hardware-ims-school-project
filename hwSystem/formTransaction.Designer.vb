<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTransaction
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbInventorySysDataSet = New hwSystem.dbInventorySysDataSet()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERSTableAdapter = New hwSystem.dbInventorySysDataSetTableAdapters.USERSTableAdapter()
        Me.btnHndTools = New System.Windows.Forms.Button()
        Me.btnPaint = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAutoMotive = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btnHomeImprov = New System.Windows.Forms.Button()
        Me.btnPlumbing = New System.Windows.Forms.Button()
        Me.btnElectrical = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnConfirmVoid = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtAvailQty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.tableProducts = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblErroMessageQty = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblIDs = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblErrorQuantity = New System.Windows.Forms.Label()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbInventorySysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PRODUCTSBindingSource
        '
        Me.PRODUCTSBindingSource.DataMember = "PRODUCTS"
        Me.PRODUCTSBindingSource.DataSource = Me.DbInventorySysDataSet
        '
        'DbInventorySysDataSet
        '
        Me.DbInventorySysDataSet.DataSetName = "dbInventorySysDataSet"
        Me.DbInventorySysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.DbInventorySysDataSet
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'btnHndTools
        '
        Me.btnHndTools.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnHndTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHndTools.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHndTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHndTools.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHndTools.ForeColor = System.Drawing.Color.DimGray
        Me.btnHndTools.Location = New System.Drawing.Point(69, 264)
        Me.btnHndTools.Name = "btnHndTools"
        Me.btnHndTools.Size = New System.Drawing.Size(289, 50)
        Me.btnHndTools.TabIndex = 8
        Me.btnHndTools.Text = "HAND TOOLS AND POWER TOOLS"
        Me.btnHndTools.UseVisualStyleBackColor = False
        '
        'btnPaint
        '
        Me.btnPaint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaint.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaint.ForeColor = System.Drawing.Color.DimGray
        Me.btnPaint.Location = New System.Drawing.Point(69, 320)
        Me.btnPaint.Name = "btnPaint"
        Me.btnPaint.Size = New System.Drawing.Size(289, 50)
        Me.btnPaint.TabIndex = 7
        Me.btnPaint.Text = "PAINTS"
        Me.btnPaint.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.DimGray
        Me.btnHome.Location = New System.Drawing.Point(69, 376)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(289, 50)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "HOME AND LIVING"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnAutoMotive
        '
        Me.btnAutoMotive.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAutoMotive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAutoMotive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutoMotive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutoMotive.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoMotive.ForeColor = System.Drawing.Color.DimGray
        Me.btnAutoMotive.Location = New System.Drawing.Point(69, 432)
        Me.btnAutoMotive.Name = "btnAutoMotive"
        Me.btnAutoMotive.Size = New System.Drawing.Size(289, 50)
        Me.btnAutoMotive.TabIndex = 5
        Me.btnAutoMotive.Text = "AUTOMOTIVE"
        Me.btnAutoMotive.UseVisualStyleBackColor = False
        '
        'btnOut
        '
        Me.btnOut.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOut.ForeColor = System.Drawing.Color.DimGray
        Me.btnOut.Location = New System.Drawing.Point(69, 655)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(289, 50)
        Me.btnOut.TabIndex = 4
        Me.btnOut.Text = "OUTDOOR LIVING"
        Me.btnOut.UseVisualStyleBackColor = False
        '
        'btnHomeImprov
        '
        Me.btnHomeImprov.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnHomeImprov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHomeImprov.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHomeImprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomeImprov.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeImprov.ForeColor = System.Drawing.Color.DimGray
        Me.btnHomeImprov.Location = New System.Drawing.Point(69, 488)
        Me.btnHomeImprov.Name = "btnHomeImprov"
        Me.btnHomeImprov.Size = New System.Drawing.Size(289, 50)
        Me.btnHomeImprov.TabIndex = 3
        Me.btnHomeImprov.Text = "HOME IMPROVEMENT"
        Me.btnHomeImprov.UseVisualStyleBackColor = False
        '
        'btnPlumbing
        '
        Me.btnPlumbing.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnPlumbing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPlumbing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlumbing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlumbing.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlumbing.ForeColor = System.Drawing.Color.DimGray
        Me.btnPlumbing.Location = New System.Drawing.Point(69, 544)
        Me.btnPlumbing.Name = "btnPlumbing"
        Me.btnPlumbing.Size = New System.Drawing.Size(289, 50)
        Me.btnPlumbing.TabIndex = 2
        Me.btnPlumbing.Text = "PLUMBING"
        Me.btnPlumbing.UseVisualStyleBackColor = False
        '
        'btnElectrical
        '
        Me.btnElectrical.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnElectrical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnElectrical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElectrical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElectrical.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElectrical.ForeColor = System.Drawing.Color.DimGray
        Me.btnElectrical.Location = New System.Drawing.Point(69, 600)
        Me.btnElectrical.Name = "btnElectrical"
        Me.btnElectrical.Size = New System.Drawing.Size(289, 50)
        Me.btnElectrical.TabIndex = 1
        Me.btnElectrical.Text = "ELECTRICAL"
        Me.btnElectrical.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(14, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 25)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Search:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(107, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(238, 20)
        Me.txtSearch.TabIndex = 35
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.AllowUserToResizeColumns = False
        Me.dgvCart.AllowUserToResizeRows = False
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column4, Me.Column11, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCart.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCart.Enabled = False
        Me.dgvCart.EnableHeadersVisualStyles = False
        Me.dgvCart.Location = New System.Drawing.Point(957, 70)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.Size = New System.Drawing.Size(381, 432)
        Me.dgvCart.TabIndex = 14
        '
        'Column6
        '
        Me.Column6.HeaderText = "Receipt No."
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "Product Code"
        Me.Column4.Name = "Column4"
        Me.Column4.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "Category"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "NAME"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "PRICE"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "QTY"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "TOTAL"
        Me.Column10.Name = "Column10"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCheckOut.Location = New System.Drawing.Point(1167, 642)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(104, 34)
        Me.btnCheckOut.TabIndex = 15
        Me.btnCheckOut.Text = "CHECK OUT"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.LightCoral
        Me.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoid.FlatAppearance.BorderSize = 0
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.Location = New System.Drawing.Point(1057, 642)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(104, 34)
        Me.btnVoid.TabIndex = 15
        Me.btnVoid.Text = "VOID"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTotalAmount.Location = New System.Drawing.Point(1151, 572)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(191, 16)
        Me.lblTotalAmount.TabIndex = 17
        Me.lblTotalAmount.Text = "Total Amount will shown here"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(1023, 571)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 21)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Total Amount:"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(1154, 601)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(75, 20)
        Me.txtPayment.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(1026, 596)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 21)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Payment:"
        '
        'btnConfirmVoid
        '
        Me.btnConfirmVoid.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnConfirmVoid.FlatAppearance.BorderSize = 0
        Me.btnConfirmVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmVoid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmVoid.Location = New System.Drawing.Point(1167, 642)
        Me.btnConfirmVoid.Name = "btnConfirmVoid"
        Me.btnConfirmVoid.Size = New System.Drawing.Size(104, 34)
        Me.btnConfirmVoid.TabIndex = 20
        Me.btnConfirmVoid.Text = "CONFIRM"
        Me.btnConfirmVoid.UseVisualStyleBackColor = False
        Me.btnConfirmVoid.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(1142, 694)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(129, 13)
        Me.lblError.TabIndex = 21
        Me.lblError.Text = "Error Message Show here"
        Me.lblError.Visible = False
        '
        'txtAvailQty
        '
        Me.txtAvailQty.Enabled = False
        Me.txtAvailQty.Location = New System.Drawing.Point(871, 591)
        Me.txtAvailQty.Name = "txtAvailQty"
        Me.txtAvailQty.Size = New System.Drawing.Size(100, 20)
        Me.txtAvailQty.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(708, 591)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 21)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Available Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(710, 549)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 21)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Category:"
        '
        'txtCategory
        '
        Me.txtCategory.Enabled = False
        Me.txtCategory.Location = New System.Drawing.Point(871, 549)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(710, 628)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(431, 637)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(431, 598)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Product Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(431, 556)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Product Code:"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirm.Location = New System.Drawing.Point(831, 665)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(112, 40)
        Me.btnConfirm.TabIndex = 28
        Me.btnConfirm.Text = "Add to Cart"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(712, 665)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 40)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Location = New System.Drawing.Point(871, 628)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 25
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(560, 634)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 24
        '
        'txtProductName
        '
        Me.txtProductName.Enabled = False
        Me.txtProductName.Location = New System.Drawing.Point(560, 597)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(137, 20)
        Me.txtProductName.TabIndex = 23
        '
        'txtProduct
        '
        Me.txtProduct.Enabled = False
        Me.txtProduct.Location = New System.Drawing.Point(560, 555)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(137, 20)
        Me.txtProduct.TabIndex = 26
        '
        'tableProducts
        '
        Me.tableProducts.AllowUserToAddRows = False
        Me.tableProducts.AllowUserToDeleteRows = False
        Me.tableProducts.AllowUserToResizeColumns = False
        Me.tableProducts.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        Me.tableProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.tableProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableProducts.BackgroundColor = System.Drawing.Color.White
        Me.tableProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tableProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tableProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tableProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column12, Me.Column5})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableProducts.DefaultCellStyle = DataGridViewCellStyle6
        Me.tableProducts.EnableHeadersVisualStyles = False
        Me.tableProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tableProducts.Location = New System.Drawing.Point(445, 70)
        Me.tableProducts.MultiSelect = False
        Me.tableProducts.Name = "tableProducts"
        Me.tableProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.tableProducts.RowHeadersVisible = False
        Me.tableProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableProducts.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.tableProducts.ShowCellToolTips = False
        Me.tableProducts.ShowEditingIcon = False
        Me.tableProducts.Size = New System.Drawing.Size(498, 432)
        Me.tableProducts.TabIndex = 22
        '
        'Column1
        '
        Me.Column1.HeaderText = "ProductID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Product Quantity"
        Me.Column12.Name = "Column12"
        Me.Column12.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "Category"
        Me.Column5.Name = "Column5"
        '
        'lblErroMessageQty
        '
        Me.lblErroMessageQty.AutoSize = True
        Me.lblErroMessageQty.ForeColor = System.Drawing.Color.Red
        Me.lblErroMessageQty.Location = New System.Drawing.Point(906, 575)
        Me.lblErroMessageQty.Name = "lblErroMessageQty"
        Me.lblErroMessageQty.Size = New System.Drawing.Size(65, 13)
        Me.lblErroMessageQty.TabIndex = 39
        Me.lblErroMessageQty.Text = "SOLD OUT!"
        Me.lblErroMessageQty.Visible = False
        '
        'Timer1
        '
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUsername.Location = New System.Drawing.Point(449, 26)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(235, 25)
        Me.lblUsername.TabIndex = 10
        Me.lblUsername.Text = "Employee's username"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTime.Location = New System.Drawing.Point(857, 26)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(114, 25)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "DATE TIME"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(1232, 26)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(86, 28)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblIDs
        '
        Me.lblIDs.AutoSize = True
        Me.lblIDs.Location = New System.Drawing.Point(379, 707)
        Me.lblIDs.Name = "lblIDs"
        Me.lblIDs.Size = New System.Drawing.Size(0, 13)
        Me.lblIDs.TabIndex = 40
        Me.lblIDs.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(40, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(358, 39)
        Me.Panel1.TabIndex = 41
        '
        'lblErrorQuantity
        '
        Me.lblErrorQuantity.AutoSize = True
        Me.lblErrorQuantity.ForeColor = System.Drawing.Color.Red
        Me.lblErrorQuantity.Location = New System.Drawing.Point(852, 614)
        Me.lblErrorQuantity.Name = "lblErrorQuantity"
        Me.lblErrorQuantity.Size = New System.Drawing.Size(119, 13)
        Me.lblErrorQuantity.TabIndex = 42
        Me.lblErrorQuantity.Text = "INSUFFICIENT STOCK"
        Me.lblErrorQuantity.Visible = False
        '
        'formTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.BackgroundImage = Global.hwSystem.My.Resources.Resources.viewproduct
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.lblErrorQuantity)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblIDs)
        Me.Controls.Add(Me.btnHndTools)
        Me.Controls.Add(Me.btnElectrical)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnPaint)
        Me.Controls.Add(Me.lblErroMessageQty)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnPlumbing)
        Me.Controls.Add(Me.btnAutoMotive)
        Me.Controls.Add(Me.txtAvailQty)
        Me.Controls.Add(Me.btnHomeImprov)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.tableProducts)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnConfirmVoid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.dgvCart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formTransaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbInventorySysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbInventorySysDataSet As dbInventorySysDataSet
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As dbInventorySysDataSetTableAdapters.USERSTableAdapter
    Friend WithEvents btnHndTools As Button
    Friend WithEvents btnPaint As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAutoMotive As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents btnHomeImprov As Button
    Friend WithEvents btnPlumbing As Button
    Friend WithEvents btnElectrical As Button
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnConfirmVoid As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lblError As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtAvailQty As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents tableProducts As DataGridView
    Friend WithEvents lblErroMessageQty As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblIDs As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblErrorQuantity As Label
End Class
