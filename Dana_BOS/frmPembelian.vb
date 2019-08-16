Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmPembelian

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        frmBrowsePemasok.ShowDialog()
    End Sub

    Private Sub frmPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GrdKomponen.Visible = False
        bersih()
        'bersihDana()
        TampilGridBOSKosong()
    End Sub
    Sub IDautomatis()
        Dim sekarang As Date = Today
        tutupkoneksi()
        txtno.Enabled = False
        cekkoneksi()
        Dim strSementara As String
        Dim strIsi As String
        sqlcommand = New MySqlCommand("select * from tbkeluaran order by no desc ", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("no"), 15, 16)
            strIsi = Val(strSementara) + 1
            txtno.Text = Format(sekarang, "yyyy") & Format(sekarang, "MM") & Format(sekarang, "dd") & Format(Now, "hh") & Format(Now, "mm") & Format(Now, "ss") + Mid("00", 1, 2 - strIsi.Length) & strIsi
        Else
            txtno.Text = Format(sekarang, "yyyy") & Format(sekarang, "MM") & Format(sekarang, "dd") & Format(Now, "hh") & Format(Now, "mm") & Format(Now, "ss") + "01"

        End If
        cboTriwulan.Focus()
    End Sub
    Sub Triwulan()
        cboTriwulan.Items.Clear()
        cboTriwulan.Items.Add("1")
        cboTriwulan.Items.Add("2")
        cboTriwulan.Items.Add("3")
        cboTriwulan.Items.Add("4")
    End Sub
    Sub bersih()
        txtno.Text = ""
        txtkode.Text = ""
        txtkomponen.Text = ""
        txtkdsupplier.Text = ""
        txtsupplier.Text = ""
        txthrgbarang.Text = ""
        txtsisa.Text = ""
        txtjumlah.Text = ""
        lbltersisa.Text = ""
        Triwulan()
    End Sub

    Private Sub txtkomponen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkomponen.TextChanged
        If txtkomponen.Text = "" Then
            GrdKomponen.Visible = False
        Else
            GrdKomponen.Visible = True
            TampilKomponen()
        End If
    End Sub
    Sub TampilKomponen()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT * from tbkomponen where " & _
        "nm_komponen like '" & Trim(txtkomponen.Text) & "%' order by kd_komponen", conn)
        Adapter.Fill(table)
        GrdKomponen.DataSource = table
        GrdKomponen.Refresh()
        tutupkoneksi()
        Me.GrdKomponen.Columns(0).HeaderText = "Kode"
        Me.GrdKomponen.Columns(1).HeaderText = "Komponen"
        GrdKomponen.Columns(0).Width = 100
        GrdKomponen.Columns(1).Width = 150
    End Sub
    Sub SisaSekarang()
        cekkoneksi()
        sql = "SELECT * FROM tbdana  where triwulan='" & cboTriwulan.Text & "' and tahun='" & Format(dptTanggal.Value, "yyyy") & "'"
        sqlcommand = New MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            txtsisa.Text = Dr.Item("sisa")
            txtsisa.Text = FormatNumber(txtsisa.Text, 0)
        End If
    End Sub

    Private Sub cboTriwulan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTriwulan.Click
        SisaSekarang()
    End Sub

    Private Sub cboTriwulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTriwulan.SelectedIndexChanged
        SisaSekarang()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Sub cariTotal()
        Try
            Dim hitung As Integer = 0
            For baris As Integer = 0 To GrdBOS.RowCount - 1
                hitung = hitung + GrdBOS.Rows(baris).Cells(5).Value
                txtjumlah.Text = FormatNumber(hitung, 0)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Sub TampilGridBOS()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT tbpembelian_detail.nomor, tbpembelian_detail.nota, tbpembelian_detail.nm_barang, tbpembelian_detail.jml_masuk, tbpembelian_detail.hrg_beli, tbpembelian_detail.sub_total from tbpembelian_detail  where " & _
        "nota like '" & Trim(txtno.Text) & "%' order by nomor", conn)
        Adapter.Fill(table)
        GrdBOS.DataSource = table
        GrdBOS.Refresh()
        tutupkoneksi()
        Me.GrdBOS.Columns(0).HeaderText = "Nomor"
        Me.GrdBOS.Columns(1).HeaderText = "NOTA"
        Me.GrdBOS.Columns(2).HeaderText = "Barang"
        Me.GrdBOS.Columns(3).HeaderText = "Jumlah"
        Me.GrdBOS.Columns(4).HeaderText = "Harga"
        Me.GrdBOS.Columns(5).HeaderText = "Sub Total"
        GrdBOS.Columns(0).Width = 15
        GrdBOS.Columns(1).Width = 100
        GrdBOS.Columns(2).Width = 150
        GrdBOS.Columns(3).Width = 200
        GrdBOS.Columns(4).Width = 150
        GrdBOS.Columns(5).Width = 150
    End Sub
    Sub TampilGridBOSKosong()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("select tbpembelian_detail.nomor, tbpembelian_detail.nota, tbpembelian_detail.nm_barang, tbpembelian_detail.jml_masuk, tbpembelian_detail.hrg_beli, tbpembelian_detail.sub_total from tbpembelian_detail  where " & _
        "nota = '" & Trim(txtno.Text) & "%' order by nomor", conn)
        Adapter.Fill(table)
        GrdBOS.DataSource = table
        GrdBOS.Refresh()
        tutupkoneksi()
        Me.GrdBOS.Columns(0).HeaderText = "Nomor"
        Me.GrdBOS.Columns(1).HeaderText = "NOTA"
        Me.GrdBOS.Columns(2).HeaderText = "Barang"
        Me.GrdBOS.Columns(3).HeaderText = "Jumlah"
        Me.GrdBOS.Columns(4).HeaderText = "Harga"
        Me.GrdBOS.Columns(5).HeaderText = "Sub Total"
        GrdBOS.Columns(0).Width = 15
        GrdBOS.Columns(1).Width = 100
        GrdBOS.Columns(2).Width = 150
        GrdBOS.Columns(3).Width = 200
        GrdBOS.Columns(4).Width = 150
        GrdBOS.Columns(5).Width = 150
    End Sub
    Sub DanaSisa()
        On Error Resume Next
        lbltersisa.Text = Val(Microsoft.VisualBasic.Str(txtsisa.Text)) - Val(Microsoft.VisualBasic.Str(txtjumlah.Text))
        lbltersisa.Text = FormatNumber(lbltersisa.Text, 0)
    End Sub

    Private Sub txtjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjumlah.TextChanged
        DanaSisa()
    End Sub

    Private Sub GrdKomponen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdKomponen.CellContentClick
        txtkode.Text = GrdKomponen.CurrentRow.Cells(0).Value
        txtkomponen.Text = GrdKomponen.CurrentRow.Cells(1).Value
        txtbarang.Focus()
        GrdKomponen.Visible = False
    End Sub

    Private Sub GrdKomponen_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdKomponen.CellContentDoubleClick
        txtkode.Text = GrdKomponen.CurrentRow.Cells(0).Value
        txtkomponen.Text = GrdKomponen.CurrentRow.Cells(1).Value
        txtbarang.Focus()
        GrdKomponen.Visible = False
    End Sub

    Private Sub txtjlhBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjlhBarang.TextChanged
        On Error Resume Next
        txttotalBarang.Text = Val(Microsoft.VisualBasic.Str(txthrgbarang.Text)) * Val(Microsoft.VisualBasic.Str(txtjlhBarang.Text))
        'txtjumlah.Text = FormatNumber(txtjumlah.Text, 0)
        txttotalBarang.Text = FormatNumber(txttotalBarang.Text, 0)
    End Sub

    Private Sub btnpakai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpakai.Click
        On Error Resume Next
        cekkoneksi()
        sql = "SELECT * FROM tbpembelian_detail"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader()
        Dr.Read()
        sql = "INSERT INTO tbpembelian_detail values (NULL,'" & txtno.Text & "','" & _
          cboTriwulan.Text & "','" & txtkode.Text & "','" & txtbarang.Text & "','" & txthrgbarang.Text & "','" & txtjlhBarang.Text & "','" & Val(Microsoft.VisualBasic.Str(txttotalBarang.Text)) & "')"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        tutupkoneksi()
        cekkoneksi()
        sqlcommand.ExecuteNonQuery()

        BersihBeli()
        TampilGridBOS()
        cariTotal()
    End Sub
    Sub BersihBeli()
        txthrgbarang.Text = ""
        txtbarang.Text = ""
        txtjlhBarang.Text = ""
        txttotalBarang.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        cekkoneksi()
        sql = "SELECT * FROM tbpembelian  "
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader()
        Dr.Read()
        sql = "INSERT INTO tbpembelian values ('" & txtno.Text & "','" & _
            cboTriwulan.Text & "','" & Format(dptTanggal.Value, "yyyy/MM/dd") & "','" & txtkdsupplier.Text & "','" & Val(Microsoft.VisualBasic.Str(txtjumlah.Text)) & "')"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        tutupkoneksi()
        cekkoneksi()
        sqlcommand.ExecuteNonQuery()
        KurangDana()
        bersih()
        tutupkoneksi()
        GrdBOS.Refresh()
        GrdBOS.ClearSelection()
        TampilGridBOSKosong()
    End Sub

    Sub KurangDana()
        On Error Resume Next
        cekkoneksi()
        sql = "SELECT * FROM tbdana  where triwulan='" & cboTriwulan.Text & "' and tahun='" & Format(dptTanggal.Value, "yyyy") & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader()
        Dr.Read()
        sql = "UPDATE tbdana set sisa='" & Val(Microsoft.VisualBasic.Str(lbltersisa.Text)) & "'"
        'sql = "Update tbdana set sisa= " & Val(Microsoft.VisualBasic.Str(lbltersisa.Text)) & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        tutupkoneksi()
        cekkoneksi()
        sqlcommand.ExecuteNonQuery()
        tutupkoneksi()
        'SisaSekarang()
        Exit Sub
ErrorHandler:
        MsgBox(Err.Description, vbCritical)
    End Sub
End Class