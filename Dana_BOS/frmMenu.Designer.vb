<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKasDanaBOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.btnEmployee = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JenisBukuToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.BukuToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'JenisBukuToolStripMenuItem
        '
        Me.JenisBukuToolStripMenuItem.Image = CType(resources.GetObject("JenisBukuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JenisBukuToolStripMenuItem.Name = "JenisBukuToolStripMenuItem"
        Me.JenisBukuToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.JenisBukuToolStripMenuItem.Text = "Pemasok"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Image = CType(resources.GetObject("SupplierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SupplierToolStripMenuItem.Text = "Komponen"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Image = CType(resources.GetObject("BukuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.BukuToolStripMenuItem.Text = "Dana"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Image = CType(resources.GetObject("PembelianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PembelianToolStripMenuItem.Text = "Pengeluaran"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Image = CType(resources.GetObject("PenjualanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PenjualanToolStripMenuItem.Text = "Pembelian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPembelianToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem1, Me.LaporanKasDanaBOSToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Image = CType(resources.GetObject("LaporanPembelianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pengeluaran"
        '
        'LaporanPembelianToolStripMenuItem1
        '
        Me.LaporanPembelianToolStripMenuItem1.Image = CType(resources.GetObject("LaporanPembelianToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LaporanPembelianToolStripMenuItem1.Name = "LaporanPembelianToolStripMenuItem1"
        Me.LaporanPembelianToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.LaporanPembelianToolStripMenuItem1.Text = "Laporan Pembelian"
        '
        'LaporanKasDanaBOSToolStripMenuItem
        '
        Me.LaporanKasDanaBOSToolStripMenuItem.Image = CType(resources.GetObject("LaporanKasDanaBOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanKasDanaBOSToolStripMenuItem.Name = "LaporanKasDanaBOSToolStripMenuItem"
        Me.LaporanKasDanaBOSToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LaporanKasDanaBOSToolStripMenuItem.Text = "Laporan Kas Dana BOS"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 72)
        Me.ToolStripButton3.Text = "Komponen"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton3.ToolTipText = "Product Category"
        '
        'btnEmployee
        '
        Me.btnEmployee.AutoSize = False
        Me.btnEmployee.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.Image = CType(resources.GetObject("btnEmployee.Image"), System.Drawing.Image)
        Me.btnEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(80, 72)
        Me.btnEmployee.Text = "Pemasok"
        Me.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEmployee.ToolTipText = "Staff"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(70, 72)
        Me.ToolStripButton2.Text = "Dana"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(70, 72)
        Me.ToolStripButton6.Text = "Pembelian"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(70, 72)
        Me.ToolStripButton5.Text = "Keluaran"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.AutoSize = False
        Me.ToolStripButton7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(80, 72)
        Me.ToolStripButton7.Text = "Lap. Beli"
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 72)
        Me.ToolStripButton1.Text = "Exit"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrchid
        Me.ToolStrip1.BackgroundImage = CType(resources.GetObject("ToolStrip1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEmployee, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton8, Me.ToolStripButton7, Me.ToolStripButton4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(750, 75)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(80, 72)
        Me.ToolStripButton8.Text = "Lap. Keluar"
        Me.ToolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(80, 72)
        Me.ToolStripButton4.Text = "Lap. KAS"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(750, 519)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Sistem Pencatatan Dana BOS Pada SMA Yayasan Perguruan Keluarga Pematangs" & _
            "iantar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JenisBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEmployee As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LaporanKasDanaBOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
End Class
