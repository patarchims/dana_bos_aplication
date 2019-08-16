<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanBOSPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanBOSPembelian))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.CboTahun = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTriwulan = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rptPembelian1 = New Dana_BOS.RptPembelian()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.BtnCetak)
        Me.GroupBox1.Controls.Add(Me.CboTahun)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboTriwulan)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 93)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'BtnCetak
        '
        Me.BtnCetak.BackColor = System.Drawing.Color.Khaki
        Me.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCetak.Location = New System.Drawing.Point(324, 18)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(139, 30)
        Me.BtnCetak.TabIndex = 51
        Me.BtnCetak.Text = "CETAK"
        Me.BtnCetak.UseVisualStyleBackColor = False
        '
        'CboTahun
        '
        Me.CboTahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboTahun.FormattingEnabled = True
        Me.CboTahun.Location = New System.Drawing.Point(155, 63)
        Me.CboTahun.Name = "CboTahun"
        Me.CboTahun.Size = New System.Drawing.Size(139, 24)
        Me.CboTahun.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Tahun"
        '
        'cboTriwulan
        '
        Me.cboTriwulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTriwulan.FormattingEnabled = True
        Me.cboTriwulan.Location = New System.Drawing.Point(155, 22)
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
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 93)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Me.rptPembelian1
        Me.CRV.Size = New System.Drawing.Size(831, 381)
        Me.CRV.TabIndex = 4
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmLaporanBOSPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 474)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLaporanBOSPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAPORAN PEMBELIAN DENGAN MENGGUNAKAN DANA BOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptPembelian1 As Dana_BOS.RptPembelian
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents CboTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTriwulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
