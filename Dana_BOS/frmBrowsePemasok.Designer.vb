<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowsePemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowsePemasok))
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.GrdSupplier = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Transparent
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnTutup.Location = New System.Drawing.Point(572, -6)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(42, 42)
        Me.BtnTutup.TabIndex = 13
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.BtnTutup)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 34)
        Me.Panel1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(203, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Data Pemasok"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(233, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcari.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Black
        Me.txtcari.Location = New System.Drawing.Point(281, 41)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(329, 26)
        Me.txtcari.TabIndex = 27
        '
        'GrdSupplier
        '
        Me.GrdSupplier.AllowUserToAddRows = False
        Me.GrdSupplier.BackgroundColor = System.Drawing.Color.DarkKhaki
        Me.GrdSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdSupplier.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdSupplier.Location = New System.Drawing.Point(0, 0)
        Me.GrdSupplier.Name = "GrdSupplier"
        Me.GrdSupplier.RowHeadersVisible = False
        Me.GrdSupplier.Size = New System.Drawing.Size(601, 194)
        Me.GrdSupplier.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GrdSupplier)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(8, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 196)
        Me.Panel3.TabIndex = 26
        '
        'frmBrowsePemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(619, 278)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBrowsePemasok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBrowsePemasok"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GrdSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents GrdSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
