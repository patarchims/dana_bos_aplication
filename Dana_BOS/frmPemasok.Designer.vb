<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPemasok))
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrdPemasok = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdPemasok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Khaki
        Me.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(8, 81)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(104, 50)
        Me.BtnBatal.TabIndex = 21
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcari.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Black
        Me.txtcari.Location = New System.Drawing.Point(375, 4)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(212, 26)
        Me.txtcari.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Telephone"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.BtnSimpan)
        Me.Panel2.Controls.Add(Me.BtnBatal)
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(366, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 168)
        Me.Panel2.TabIndex = 25
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Khaki
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(118, 22)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(106, 53)
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
        Me.BtnSimpan.Location = New System.Drawing.Point(8, 23)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(104, 52)
        Me.BtnSimpan.TabIndex = 22
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = False
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
        Me.BtnHapus.Location = New System.Drawing.Point(118, 81)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(106, 50)
        Me.BtnHapus.TabIndex = 9
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'txttelp
        '
        Me.txttelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelp.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelp.ForeColor = System.Drawing.Color.Black
        Me.txttelp.Location = New System.Drawing.Point(128, 121)
        Me.txttelp.MaxLength = 13
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(214, 26)
        Me.txttelp.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Alamat"
        '
        'txtalamat
        '
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamat.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.ForeColor = System.Drawing.Color.Black
        Me.txtalamat.Location = New System.Drawing.Point(128, 71)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(214, 44)
        Me.txtalamat.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama"
        '
        'GrdPemasok
        '
        Me.GrdPemasok.AllowUserToAddRows = False
        Me.GrdPemasok.BackgroundColor = System.Drawing.Color.DarkKhaki
        Me.GrdPemasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPemasok.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdPemasok.Location = New System.Drawing.Point(8, 36)
        Me.GrdPemasok.Name = "GrdPemasok"
        Me.GrdPemasok.RowHeadersVisible = False
        Me.GrdPemasok.Size = New System.Drawing.Size(579, 165)
        Me.GrdPemasok.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.GrdPemasok)
        Me.Panel3.Controls.Add(Me.txtcari)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(7, 220)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 210)
        Me.Panel3.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(330, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cari"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnTutup)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 34)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(230, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pemasok"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Transparent
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnTutup.Location = New System.Drawing.Point(558, -5)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(42, 42)
        Me.BtnTutup.TabIndex = 12
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.Color.Khaki
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.ForeColor = System.Drawing.Color.White
        Me.txtkode.Location = New System.Drawing.Point(128, 7)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(138, 26)
        Me.txtkode.TabIndex = 9
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.ForeColor = System.Drawing.Color.Black
        Me.txtnama.Location = New System.Drawing.Point(128, 39)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(214, 26)
        Me.txtnama.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Kode Pemasok"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txttelp)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtalamat)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtnama)
        Me.Panel4.Controls.Add(Me.txtkode)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(7, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(353, 168)
        Me.Panel4.TabIndex = 23
        '
        'frmPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(607, 439)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPemasok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pemasok"
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdPemasok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents txttelp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrdPemasok As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
