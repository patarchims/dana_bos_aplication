<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RptKas1 = New Dana_BOS.RptKas()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtjumlahbeli = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GrdPembelian = New System.Windows.Forms.DataGridView()
        Me.Pengeluaran = New System.Windows.Forms.GroupBox()
        Me.txtjumlahkeluar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GrdKeluaran = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txttahun = New System.Windows.Forms.TextBox()
        Me.txttriwulan = New System.Windows.Forms.TextBox()
        Me.txtsisa = New System.Windows.Forms.TextBox()
        Me.txtdana = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.CboTahun = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboTriwulan = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GrdPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pengeluaran.SuspendLayout()
        CType(Me.GrdKeluaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BtnTutup)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1113, 34)
        Me.Panel1.TabIndex = 22
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Transparent
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnTutup.Location = New System.Drawing.Point(1068, 0)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(43, 37)
        Me.BtnTutup.TabIndex = 52
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(418, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAPORAN KAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.CRV)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.Pengeluaran)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(5, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1101, 586)
        Me.Panel2.TabIndex = 23
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Right
        Me.CRV.Location = New System.Drawing.Point(534, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Me.RptKas1
        Me.CRV.Size = New System.Drawing.Size(567, 586)
        Me.CRV.TabIndex = 51
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtjumlahbeli)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.GrdPembelian)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 340)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(517, 209)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'txtjumlahbeli
        '
        Me.txtjumlahbeli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtjumlahbeli.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahbeli.ForeColor = System.Drawing.Color.Black
        Me.txtjumlahbeli.Location = New System.Drawing.Point(297, 173)
        Me.txtjumlahbeli.Name = "txtjumlahbeli"
        Me.txtjumlahbeli.Size = New System.Drawing.Size(214, 19)
        Me.txtjumlahbeli.TabIndex = 53
        Me.txtjumlahbeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 16)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "JUMLAH :"
        '
        'GrdPembelian
        '
        Me.GrdPembelian.AllowUserToAddRows = False
        Me.GrdPembelian.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.GrdPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPembelian.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdPembelian.Location = New System.Drawing.Point(6, 20)
        Me.GrdPembelian.Name = "GrdPembelian"
        Me.GrdPembelian.RowHeadersVisible = False
        Me.GrdPembelian.Size = New System.Drawing.Size(505, 147)
        Me.GrdPembelian.TabIndex = 51
        '
        'Pengeluaran
        '
        Me.Pengeluaran.Controls.Add(Me.txtjumlahkeluar)
        Me.Pengeluaran.Controls.Add(Me.Label14)
        Me.Pengeluaran.Controls.Add(Me.GrdKeluaran)
        Me.Pengeluaran.Location = New System.Drawing.Point(12, 134)
        Me.Pengeluaran.Name = "Pengeluaran"
        Me.Pengeluaran.Size = New System.Drawing.Size(517, 200)
        Me.Pengeluaran.TabIndex = 49
        Me.Pengeluaran.TabStop = False
        Me.Pengeluaran.Text = "Pengeluaran"
        '
        'txtjumlahkeluar
        '
        Me.txtjumlahkeluar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtjumlahkeluar.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahkeluar.ForeColor = System.Drawing.Color.Black
        Me.txtjumlahkeluar.Location = New System.Drawing.Point(322, 165)
        Me.txtjumlahkeluar.Name = "txtjumlahkeluar"
        Me.txtjumlahkeluar.Size = New System.Drawing.Size(177, 19)
        Me.txtjumlahkeluar.TabIndex = 47
        Me.txtjumlahkeluar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "JUMLAH :"
        '
        'GrdKeluaran
        '
        Me.GrdKeluaran.AllowUserToAddRows = False
        Me.GrdKeluaran.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.GrdKeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdKeluaran.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdKeluaran.Location = New System.Drawing.Point(6, 17)
        Me.GrdKeluaran.Name = "GrdKeluaran"
        Me.GrdKeluaran.RowHeadersVisible = False
        Me.GrdKeluaran.Size = New System.Drawing.Size(505, 142)
        Me.GrdKeluaran.TabIndex = 39
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttahun)
        Me.GroupBox2.Controls.Add(Me.txttriwulan)
        Me.GroupBox2.Controls.Add(Me.txtsisa)
        Me.GroupBox2.Controls.Add(Me.txtdana)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 124)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "KAS"
        '
        'txttahun
        '
        Me.txttahun.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttahun.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttahun.ForeColor = System.Drawing.Color.Black
        Me.txttahun.Location = New System.Drawing.Point(111, 76)
        Me.txttahun.Name = "txttahun"
        Me.txttahun.Size = New System.Drawing.Size(214, 19)
        Me.txttahun.TabIndex = 49
        '
        'txttriwulan
        '
        Me.txttriwulan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttriwulan.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttriwulan.ForeColor = System.Drawing.Color.Black
        Me.txttriwulan.Location = New System.Drawing.Point(111, 61)
        Me.txttriwulan.Name = "txttriwulan"
        Me.txttriwulan.Size = New System.Drawing.Size(214, 19)
        Me.txttriwulan.TabIndex = 47
        '
        'txtsisa
        '
        Me.txtsisa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsisa.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsisa.ForeColor = System.Drawing.Color.Black
        Me.txtsisa.Location = New System.Drawing.Point(111, 36)
        Me.txtsisa.Name = "txtsisa"
        Me.txtsisa.Size = New System.Drawing.Size(214, 19)
        Me.txtsisa.TabIndex = 48
        '
        'txtdana
        '
        Me.txtdana.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdana.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdana.ForeColor = System.Drawing.Color.Black
        Me.txtdana.Location = New System.Drawing.Point(111, 19)
        Me.txtdana.Name = "txtdana"
        Me.txtdana.Size = New System.Drawing.Size(214, 19)
        Me.txtdana.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(94, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 16)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(94, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(94, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(94, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "TAHUN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "TRIWULAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "KAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "DANA BOS"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(891, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 24)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Total Pengeluaran"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(891, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 24)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "KAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.BtnCetak)
        Me.GroupBox1.Controls.Add(Me.CboTahun)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cboTriwulan)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1113, 90)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LIHAT LAPORAN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(591, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 24)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Total Pengeluaran"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(593, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 24)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Total Pengeluaran"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnCetak
        '
        Me.BtnCetak.BackColor = System.Drawing.Color.Khaki
        Me.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCetak.Location = New System.Drawing.Point(334, 36)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(139, 30)
        Me.BtnCetak.TabIndex = 51
        Me.BtnCetak.Text = "Tampil"
        Me.BtnCetak.UseVisualStyleBackColor = False
        '
        'CboTahun
        '
        Me.CboTahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboTahun.FormattingEnabled = True
        Me.CboTahun.Location = New System.Drawing.Point(124, 56)
        Me.CboTahun.Name = "CboTahun"
        Me.CboTahun.Size = New System.Drawing.Size(139, 24)
        Me.CboTahun.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(44, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Tahun"
        '
        'cboTriwulan
        '
        Me.cboTriwulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTriwulan.FormattingEnabled = True
        Me.cboTriwulan.Location = New System.Drawing.Point(124, 26)
        Me.cboTriwulan.Name = "cboTriwulan"
        Me.cboTriwulan.Size = New System.Drawing.Size(139, 24)
        Me.cboTriwulan.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(44, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Triwulan"
        '
        'frmKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1113, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GrdPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pengeluaran.ResumeLayout(False)
        Me.Pengeluaran.PerformLayout()
        CType(Me.GrdKeluaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents CboTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboTriwulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtjumlahbeli As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GrdPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents Pengeluaran As System.Windows.Forms.GroupBox
    Friend WithEvents txtjumlahkeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GrdKeluaran As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txttahun As System.Windows.Forms.TextBox
    Friend WithEvents txttriwulan As System.Windows.Forms.TextBox
    Friend WithEvents txtsisa As System.Windows.Forms.TextBox
    Friend WithEvents txtdana As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RptKas1 As Dana_BOS.RptKas
End Class
