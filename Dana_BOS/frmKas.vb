Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
'Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class frmKas

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmKas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CRV.ReportSource = Nothing
        Triwulan()
        CboTahun.Enabled = False
        'Tahun()

    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub


    Sub Triwulan()
        cboTriwulan.Items.Add(1)
        cboTriwulan.Items.Add(2)
        cboTriwulan.Items.Add(3)
        cboTriwulan.Items.Add(4)
    End Sub
    Sub Tahun()
        CboTahun.Items.Clear()
        CboTahun.Items.Add("")
        CboTahun.Items.Add("2010")
        CboTahun.Items.Add("2011")
        CboTahun.Items.Add("2012")
        CboTahun.Items.Add("2013")
        CboTahun.Items.Add("2014")
        CboTahun.Items.Add("2015")
        CboTahun.Items.Add("2016")
        CboTahun.Items.Add("2017")
        CboTahun.Items.Add("2018")
        CboTahun.Items.Add("2019")
        CboTahun.Items.Add("2020")
        CboTahun.Items.Add("2021")
    End Sub
    Sub TampilDana()
        cekkoneksi()
        sql = "SELECT * FROM tbdana  where triwulan='" & cboTriwulan.Text & "' and tahun='" & CboTahun.Text & "'"
        sqlcommand = New MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            txtsisa.Text = Dr.Item("sisa")
            txtdana.Text = Dr.Item("jumlah")
            txttriwulan.Text = Dr.Item("triwulan")
            txttahun.Text = Dr.Item("tahun")
            txtsisa.Text = FormatNumber(txtsisa.Text, 0)
            txtdana.Text = FormatNumber(txtdana.Text, 0)
        End If
    End Sub

    Private Sub cboTriwulan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTriwulan.Click
        CboTahun.Enabled = True
        Tahun()
    End Sub

    Private Sub cboTriwulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTriwulan.SelectedIndexChanged
        CboTahun.Enabled = True
        Tahun()
        'TampilGridkeluar()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        TampilDana()
        TampilGridkeluar()
        TampilGridBeli()
        jumlahKeluaran()
        jumlahbeli()
        CariJUmlahKeluaran()
        tampilReport()
    End Sub
    Sub tampilReport()
        RptKas1.Load("RptKas.rpt")
        On Error Resume Next
        'lblSaldo.Text = Val(Microsoft.VisualBasic.Str(lblPendapatan.Text)) - Val(Microsoft.VisualBasic.Str(lblPengeluaran.Text))
        'lblSaldo.Text = FormatNumber(lblSaldo.Text, 0)
        RptKas1.SetParameterValue("terima", txtjumlahkeluar.Text)
        RptKas1.SetParameterValue("beli", txtjumlahbeli.Text)
        RptKas1.SetParameterValue("dana", txtdana.Text)
        RptKas1.SetParameterValue("tahun", txttahun.Text)
        RptKas1.SetParameterValue("triwulan", txttriwulan.Text)
        RptKas1.SetParameterValue("jumlah_keluar", Label17.Text)
        RptKas1.SetParameterValue("kas", Label18.Text)
        'CRV.Refresh()
        'CRV.Refresh()
        CRV.ReportSource = RptKas1
        CRV.Zoom(75)
    End Sub

    Sub TampilGridkeluar()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("select tbkeluaran.tanggal, tbkomponen.nm_komponen, tbkeluaran_detail.triwulan, tbkeluaran_detail.keterangan, tbkeluaran_detail.jumlah from tbkeluaran_detail inner join tbkomponen on tbkeluaran_detail.kd_komponen=tbkomponen.kd_komponen inner join tbkeluaran on tbkeluaran.no=tbkeluaran_detail.no where " & _
      "tbkeluaran_detail.triwulan ='" & Trim(cboTriwulan.Text) & "' and year(tbkeluaran.tanggal) =" & Trim(CboTahun.Text) & "", conn)

  
        Adapter.Fill(table)
        GrdKeluaran.DataSource = table
        GrdKeluaran.Refresh()
        tutupkoneksi()
        Me.GrdKeluaran.Columns(0).HeaderText = "Tanggal"
        Me.GrdKeluaran.Columns(1).HeaderText = "Komponen"
        Me.GrdKeluaran.Columns(2).HeaderText = "Triwulan"
        Me.GrdKeluaran.Columns(3).HeaderText = "Keterangan"
        Me.GrdKeluaran.Columns(4).HeaderText = "Jumlah"
    End Sub
    Sub TampilGridBeli()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("select tbpembelian_detail.triwulan, tbpembelian.tanggal, tbpembelian_detail.nm_barang, tbpembelian_detail.hrg_beli, tbpembelian_detail.jml_masuk,tbpembelian_detail.sub_total from tbpembelian_detail inner join tbpembelian on tbpembelian.nota=tbpembelian_detail.nota  where " & _
      "tbpembelian_detail.triwulan ='" & Trim(cboTriwulan.Text) & "' and year(tbpembelian.tanggal) =" & Trim(CboTahun.Text) & "", conn)

        Adapter.Fill(table)
        GrdPembelian.DataSource = table
        GrdPembelian.Refresh()
        tutupkoneksi()
        Me.GrdPembelian.Columns(0).HeaderText = "Triwulan"
        Me.GrdPembelian.Columns(1).HeaderText = "Tanggal"
        Me.GrdPembelian.Columns(2).HeaderText = "Barang"
        Me.GrdPembelian.Columns(3).HeaderText = "Harga"
        Me.GrdPembelian.Columns(4).HeaderText = "Jumlah"
        Me.GrdPembelian.Columns(5).HeaderText = "Sub Total"
    End Sub
    Private Sub CboTahun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTahun.SelectedIndexChanged

    End Sub

    Private Sub GrdKeluaran_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Sub jumlahKeluaran()
        Try
            Dim hitung As Integer = 0
            For baris As Integer = 0 To GrdKeluaran.RowCount - 1
                hitung = hitung + GrdKeluaran.Rows(baris).Cells(4).Value
                txtjumlahkeluar.Text = FormatNumber(hitung, 0)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub jumlahbeli()
        Try
            Dim hitung As Integer = 0
            For baris As Integer = 0 To GrdPembelian.RowCount - 1
                hitung = hitung + GrdPembelian.Rows(baris).Cells(5).Value
                txtjumlahbeli.Text = FormatNumber(hitung, 0)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Sub CariJUmlahKeluaran()
        On Error Resume Next
        Label17.Text = Val(Microsoft.VisualBasic.Str(txtjumlahkeluar.Text)) + Val(Microsoft.VisualBasic.Str(txtjumlahbeli.Text))
        Label17.Text = FormatNumber(Label17.Text, 0)
        Label18.Text = Val(Microsoft.VisualBasic.Str(txtdana.Text)) - Val(Microsoft.VisualBasic.Str(Label17.Text))
        Label18.Text = FormatNumber(Label18.Text, 0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PrintPreviewDialog1.Show()
    End Sub

   
End Class