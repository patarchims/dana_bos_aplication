<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengeluaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPengeluaran))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboTriwulan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dptTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnpakai = New System.Windows.Forms.Button()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.txtkomponen = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrdBOS = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsisa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltersisa = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GrdKomponen = New System.Windows.Forms.DataGridView()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdBOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GrdKomponen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cboTriwulan)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.dptTanggal)
        Me.Panel4.Controls.Add(Me.txtno)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(847, 50)
        Me.Panel4.TabIndex = 30
        '
        'cboTriwulan
        '
        Me.cboTriwulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTriwulan.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cboTriwulan.FormattingEnabled = True
        Me.cboTriwulan.Location = New System.Drawing.Point(418, 10)
        Me.cboTriwulan.Name = "cboTriwulan"
        Me.cboTriwulan.Size = New System.Drawing.Size(105, 27)
        Me.cboTriwulan.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(341, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Triwulan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(555, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "TANGGAL"
        '
        'dptTanggal
        '
        Me.dptTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptTanggal.Location = New System.Drawing.Point(646, 13)
        Me.dptTanggal.Name = "dptTanggal"
        Me.dptTanggal.Size = New System.Drawing.Size(188, 24)
        Me.dptTanggal.TabIndex = 36
        '
        'txtno
        '
        Me.txtno.BackColor = System.Drawing.Color.Khaki
        Me.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtno.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.ForeColor = System.Drawing.Color.Black
        Me.txtno.Location = New System.Drawing.Point(105, 13)
        Me.txtno.MaxLength = 12
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(182, 26)
        Me.txtno.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "NO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 34)
        Me.Panel1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(319, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pemakaian Dana BOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtharga)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnpakai)
        Me.Panel2.Controls.Add(Me.txtketerangan)
        Me.Panel2.Controls.Add(Me.txtkomponen)
        Me.Panel2.Controls.Add(Me.txtkode)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(847, 83)
        Me.Panel2.TabIndex = 31
        '
        'txtharga
        '
        Me.txtharga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtharga.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.ForeColor = System.Drawing.Color.Black
        Me.txtharga.Location = New System.Drawing.Point(526, 6)
        Me.txtharga.MaxLength = 12
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(198, 26)
        Me.txtharga.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Keterangan"
        '
        'btnpakai
        '
        Me.btnpakai.BackColor = System.Drawing.Color.Khaki
        Me.btnpakai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpakai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpakai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpakai.Image = CType(resources.GetObject("btnpakai.Image"), System.Drawing.Image)
        Me.btnpakai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpakai.Location = New System.Drawing.Point(750, 6)
        Me.btnpakai.Name = "btnpakai"
        Me.btnpakai.Size = New System.Drawing.Size(84, 41)
        Me.btnpakai.TabIndex = 37
        Me.btnpakai.Text = "OK"
        Me.btnpakai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpakai.UseVisualStyleBackColor = False
        '
        'txtketerangan
        '
        Me.txtketerangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtketerangan.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtketerangan.ForeColor = System.Drawing.Color.Black
        Me.txtketerangan.Location = New System.Drawing.Point(108, 36)
        Me.txtketerangan.MaxLength = 50000
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(616, 43)
        Me.txtketerangan.TabIndex = 35
        '
        'txtkomponen
        '
        Me.txtkomponen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkomponen.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkomponen.ForeColor = System.Drawing.Color.Black
        Me.txtkomponen.Location = New System.Drawing.Point(210, 6)
        Me.txtkomponen.MaxLength = 12
        Me.txtkomponen.Name = "txtkomponen"
        Me.txtkomponen.Size = New System.Drawing.Size(310, 26)
        Me.txtkomponen.TabIndex = 33
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.Color.Khaki
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.ForeColor = System.Drawing.Color.Black
        Me.txtkode.Location = New System.Drawing.Point(108, 6)
        Me.txtkode.MaxLength = 12
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(96, 26)
        Me.txtkode.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Komponen"
        '
        'GrdBOS
        '
        Me.GrdBOS.AllowUserToAddRows = False
        Me.GrdBOS.BackgroundColor = System.Drawing.Color.DarkKhaki
        Me.GrdBOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdBOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdBOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdBOS.Location = New System.Drawing.Point(0, 167)
        Me.GrdBOS.Name = "GrdBOS"
        Me.GrdBOS.RowHeadersVisible = False
        Me.GrdBOS.Size = New System.Drawing.Size(847, 231)
        Me.GrdBOS.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.txtsisa)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.txtjumlah)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 398)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(847, 42)
        Me.Panel6.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "DANA"
        '
        'txtsisa
        '
        Me.txtsisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsisa.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsisa.ForeColor = System.Drawing.Color.Black
        Me.txtsisa.Location = New System.Drawing.Point(105, 0)
        Me.txtsisa.MaxLength = 102
        Me.txtsisa.Multiline = True
        Me.txtsisa.Name = "txtsisa"
        Me.txtsisa.Size = New System.Drawing.Size(215, 40)
        Me.txtsisa.TabIndex = 41
        Me.txtsisa.Text = "TOTAL SISA"
        Me.txtsisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(493, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "JUMLAH"
        '
        'txtjumlah
        '
        Me.txtjumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlah.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtjumlah.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.ForeColor = System.Drawing.Color.Black
        Me.txtjumlah.Location = New System.Drawing.Point(630, 0)
        Me.txtjumlah.MaxLength = 102
        Me.txtjumlah.Multiline = True
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(215, 40)
        Me.txtjumlah.TabIndex = 39
        Me.txtjumlah.Text = "TOTAL JUMLAH"
        Me.txtjumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.lbltersisa)
        Me.Panel5.Controls.Add(Me.BtnTambah)
        Me.Panel5.Controls.Add(Me.BtnSimpan)
        Me.Panel5.Controls.Add(Me.btnTutup)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 440)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(847, 64)
        Me.Panel5.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(449, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 18)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "DANA TERSISA"
        '
        'lbltersisa
        '
        Me.lbltersisa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lbltersisa.BackColor = System.Drawing.Color.Khaki
        Me.lbltersisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltersisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltersisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltersisa.Location = New System.Drawing.Point(630, 0)
        Me.lbltersisa.Name = "lbltersisa"
        Me.lbltersisa.Size = New System.Drawing.Size(215, 51)
        Me.lbltersisa.TabIndex = 24
        Me.lbltersisa.Text = "TOTAL SISA"
        Me.lbltersisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Khaki
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(14, 6)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(101, 44)
        Me.BtnTambah.TabIndex = 23
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Khaki
        Me.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(119, 7)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(96, 43)
        Me.BtnSimpan.TabIndex = 22
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.Khaki
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnTutup.Location = New System.Drawing.Point(221, 7)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(90, 44)
        Me.btnTutup.TabIndex = 12
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'GrdKomponen
        '
        Me.GrdKomponen.AllowUserToAddRows = False
        Me.GrdKomponen.BackgroundColor = System.Drawing.Color.DarkKhaki
        Me.GrdKomponen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdKomponen.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdKomponen.Location = New System.Drawing.Point(109, 121)
        Me.GrdKomponen.Name = "GrdKomponen"
        Me.GrdKomponen.RowHeadersVisible = False
        Me.GrdKomponen.Size = New System.Drawing.Size(415, 165)
        Me.GrdKomponen.TabIndex = 40
        '
        'frmPengeluaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(847, 504)
        Me.Controls.Add(Me.GrdKomponen)
        Me.Controls.Add(Me.GrdBOS)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPengeluaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPengeluaran"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GrdBOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.GrdKomponen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dptTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTriwulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnpakai As System.Windows.Forms.Button
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents txtkomponen As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrdBOS As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbltersisa As System.Windows.Forms.Label
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsisa As System.Windows.Forms.TextBox
    Friend WithEvents GrdKomponen As System.Windows.Forms.DataGridView
End Class
