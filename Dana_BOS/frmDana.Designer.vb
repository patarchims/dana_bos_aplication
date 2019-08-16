<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDana))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboTriwulan = New System.Windows.Forms.ComboBox()
        Me.CboTahun = New System.Windows.Forms.ComboBox()
        Me.cboBulan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GrdDana = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdDana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(604, 34)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(196, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Dana BOS Masuk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cboTriwulan)
        Me.Panel4.Controls.Add(Me.CboTahun)
        Me.Panel4.Controls.Add(Me.cboBulan)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtjumlah)
        Me.Panel4.Controls.Add(Me.txtkode)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(11, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(580, 84)
        Me.Panel4.TabIndex = 23
        '
        'cboTriwulan
        '
        Me.cboTriwulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTriwulan.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cboTriwulan.FormattingEnabled = True
        Me.cboTriwulan.Location = New System.Drawing.Point(468, 46)
        Me.cboTriwulan.Name = "cboTriwulan"
        Me.cboTriwulan.Size = New System.Drawing.Size(105, 27)
        Me.cboTriwulan.TabIndex = 26
        '
        'CboTahun
        '
        Me.CboTahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboTahun.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CboTahun.FormattingEnabled = True
        Me.CboTahun.Location = New System.Drawing.Point(468, 10)
        Me.CboTahun.Name = "CboTahun"
        Me.CboTahun.Size = New System.Drawing.Size(105, 27)
        Me.CboTahun.TabIndex = 25
        '
        'cboBulan
        '
        Me.cboBulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboBulan.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cboBulan.FormattingEnabled = True
        Me.cboBulan.Location = New System.Drawing.Point(246, 11)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(142, 27)
        Me.cboBulan.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tahun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(391, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Triwulan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Bulan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Jumlah"
        '
        'txtjumlah
        '
        Me.txtjumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlah.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.ForeColor = System.Drawing.Color.Black
        Me.txtjumlah.Location = New System.Drawing.Point(67, 44)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(321, 26)
        Me.txtjumlah.TabIndex = 10
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.Color.Khaki
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.ForeColor = System.Drawing.Color.White
        Me.txtkode.Location = New System.Drawing.Point(67, 8)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(120, 26)
        Me.txtkode.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Kode"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.GrdDana)
        Me.Panel3.Controls.Add(Me.txtcari)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(12, 193)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(579, 210)
        Me.Panel3.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Cari"
        '
        'GrdDana
        '
        Me.GrdDana.AllowUserToAddRows = False
        Me.GrdDana.BackgroundColor = System.Drawing.Color.DarkKhaki
        Me.GrdDana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdDana.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdDana.Location = New System.Drawing.Point(8, 36)
        Me.GrdDana.Name = "GrdDana"
        Me.GrdDana.RowHeadersVisible = False
        Me.GrdDana.Size = New System.Drawing.Size(557, 165)
        Me.GrdDana.TabIndex = 17
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcari.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Black
        Me.txtcari.Location = New System.Drawing.Point(355, 4)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(212, 26)
        Me.txtcari.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.BtnSimpan)
        Me.Panel2.Controls.Add(Me.BtnBatal)
        Me.Panel2.Controls.Add(Me.BtnTutup)
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(579, 58)
        Me.Panel2.TabIndex = 26
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Khaki
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(87, 6)
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
        Me.BtnSimpan.Location = New System.Drawing.Point(192, 7)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(96, 43)
        Me.BtnSimpan.TabIndex = 22
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Khaki
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(294, 7)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(90, 44)
        Me.BtnBatal.TabIndex = 21
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Khaki
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnTutup.Location = New System.Drawing.Point(484, 7)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(81, 44)
        Me.BtnTutup.TabIndex = 12
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Khaki
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.Enabled = False
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(390, 7)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(91, 44)
        Me.BtnHapus.TabIndex = 9
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'frmDana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(604, 415)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDana"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GrdDana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cboTriwulan As System.Windows.Forms.ComboBox
    Friend WithEvents CboTahun As System.Windows.Forms.ComboBox
    Friend WithEvents cboBulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrdDana As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
End Class
