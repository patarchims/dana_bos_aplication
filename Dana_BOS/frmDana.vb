Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmDana

    Private Sub frmDana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bersih()
        TidakAktif()
        TampilGrid()
        AturGrid()
        txtkode.Enabled = False
        BtnTambah.Enabled = True
    End Sub
    Sub Triwulan()
        cboTriwulan.Items.Clear()
        cboTriwulan.Items.Add("1")
        cboTriwulan.Items.Add("2")
        cboTriwulan.Items.Add("3")
        cboTriwulan.Items.Add("4")
    End Sub
    Sub Bulan()
        cboBulan.Items.Clear()
        cboBulan.Items.Add("")
        cboBulan.Items.Add("Januari")
        cboBulan.Items.Add("Februari")
        cboBulan.Items.Add("Maret")
        cboBulan.Items.Add("April")
        cboBulan.Items.Add("Mei")
        cboBulan.Items.Add("Juni")
        cboBulan.Items.Add("Juli")
        cboBulan.Items.Add("Agustus")
        cboBulan.Items.Add("September")
        cboBulan.Items.Add("Oktober")
        cboBulan.Items.Add("November")
        cboBulan.Items.Add("Desember")
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
    Sub IDautomatis()
        tutupkoneksi()
        txtkode.Enabled = False
        cekkoneksi()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        sqlcommand = New MySqlCommand("select * from tbdana order by kd_dana desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("kd_dana"), 5, 6)
            strIsi = Val(strSementara) + 1
            txtkode.Text = "DN" + Mid("00000", 1, 6 - strIsi.Length) & strIsi
        Else
            txtkode.Text = "DN000001"
        End If
        txtjumlah.Focus()
    End Sub
    Sub bersih()
        txtkode.Text = ""
        txtjumlah.Text = ""
        'CboTahun.Items.Clear()
        'cboBulan.Items.Clear()
        'cboTriwulan.Items.Clear()
        Bulan()
        Tahun()
        Triwulan()
    End Sub
    Sub Aktif()
        BtnBatal.Enabled = True
        BtnSimpan.Enabled = True
    End Sub
    Sub TidakAktif()
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
    End Sub
    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT tbdana.kd_dana, tbdana.jumlah, tbdana.triwulan, tbdana.bulan, tbdana.tahun from tbdana where " & _
        "triwulan like '" & Trim(txtcari.Text) & "%' order by kd_dana   ", conn)
        Adapter.Fill(table)
        GrdDana.DataSource = table
        GrdDana.Refresh()
        tutupkoneksi()
        Me.GrdDana.Columns(0).HeaderText = "Kode"
        Me.GrdDana.Columns(1).HeaderText = "Jumlah"
        Me.GrdDana.Columns(2).HeaderText = "Triwulan"
        Me.GrdDana.Columns(3).HeaderText = "Bulan"
        Me.GrdDana.Columns(4).HeaderText = "Tahun"
    End Sub
    Sub AturGrid()
        GrdDana.Columns(0).Width = 100
        GrdDana.Columns(1).Width = 220
        GrdDana.Columns(2).Width = 200
        GrdDana.Columns(3).Width = 100
        GrdDana.Columns(4).Width = 220
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        TampilGrid()
    End Sub

    Private Sub GrdDana_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdDana.CellContentClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub

    Sub KlikGrid()
        Aktif()
        txtkode.Enabled = False
        txtkode.Text = GrdDana.CurrentRow.Cells(0).Value
        txtjumlah.Text = GrdDana.CurrentRow.Cells(1).Value
        cboTriwulan.Text = GrdDana.CurrentRow.Cells(2).Value
        cboBulan.Text = GrdDana.CurrentRow.Cells(3).Value
        CboTahun.Text = GrdDana.CurrentRow.Cells(4).Value
    End Sub

    Private Sub GrdDana_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdDana.CellContentDoubleClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        cekkoneksi()
        sql = "SELECT * FROM tbdana where kd_dana='" & txtkode.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        tutupkoneksi()
        sql = "Delete From tbdana where kd_dana ='" & txtkode.Text & "'"
        cekkoneksi()
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        sqlcommand.ExecuteNonQuery()
        If MsgBox("Apakah Anda yakin menghapus Data ini ?", vbQuestion + vbYesNo, "Hapus") = vbNo Then tutupkoneksi() : Exit Sub
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        tutupkoneksi()
        cekkoneksi()
        sqlcommand.ExecuteNonQuery()
        TampilGrid()
        bersih()
        tutupkoneksi()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        bersih()
        TidakAktif()
        TampilGrid()
        BtnTambah.Enabled = True
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtkode.Text = "" Or txtjumlah.Text = "" Or cboBulan.Text = "" Or CboTahun.Text = "" Or cboTriwulan.Text = "" Then
            MsgBox("Data Isian Harus Lenkap", MsgBoxStyle.Critical)

        Else
            cekkoneksi()
            sql = "SELECT * FROM tbdana WHERE kd_dana='" & Trim(txtkode.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO tbdana values ('" & txtkode.Text & "','" & _
                     txtjumlah.Text & "','" & txtjumlah.Text & "','" & cboTriwulan.Text & "','" & cboBulan.Text & "','" & CboTahun.Text & "')"
            Else
                sql = "UPDATE tbdana set jumlah='" & txtjumlah.Text & "',sisa='" & txtjumlah.Text & "',triwulan='" & cboTriwulan.Text & "',bulan='" & cboBulan.Text & "',tahun='" & CboTahun.Text & "' WHERE kd_dana='" & Trim(txtkode.Text) & "'"
            End If
            If MsgBox("Apakah Anda yakin akan menyimpan data ini?", vbQuestion + vbYesNo, "Simpan") = vbNo Then tutupkoneksi() : Exit Sub
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            tutupkoneksi()
            cekkoneksi()
            sqlcommand.ExecuteNonQuery()
            bersih()
            tutupkoneksi()
            TampilGrid()
        End If
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        bersih()
        IDautomatis()
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class