Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmPemasok
    Private Sub frmPemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bersih()
        TidakAktif()
        TampilGrid()
        AturGrid()
        txtkode.Enabled = False
        BtnTambah.Enabled = True
    End Sub
    Sub IDautomatis()
        tutupkoneksi()
        txtkode.Enabled = False
        cekkoneksi()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        sqlcommand = New MySqlCommand("select * from tbsupplier order by id_supplier desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("id_supplier"), 5, 6)
            strIsi = Val(strSementara) + 1
            txtkode.Text = "SP" + Mid("00000", 1, 6 - strIsi.Length) & strIsi
        Else
            txtkode.Text = "SP000001"
        End If
        txtnama.Focus()
    End Sub
    Sub bersih()
        txtkode.Text = ""
        txtnama.Text = ""
        txttelp.Text = ""
        txtalamat.Text = ""
        txtcari.Text = ""
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

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        bersih()
        IDautomatis()
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
    End Sub

    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT * from tbsupplier where " & _
        "nm_supplier like '" & Trim(txtcari.Text) & "%' order by id_supplier", conn)
        Adapter.Fill(table)
        GrdPemasok.DataSource = table
        GrdPemasok.Refresh()
        tutupkoneksi()
        Me.GrdPemasok.Columns(0).HeaderText = "Kode Supplier"
        Me.GrdPemasok.Columns(1).HeaderText = "Nama"
        Me.GrdPemasok.Columns(2).HeaderText = "Alamat"
        Me.GrdPemasok.Columns(3).HeaderText = "Telphone"
    End Sub
    Sub AturGrid()
        GrdPemasok.Columns(0).Width = 100
        GrdPemasok.Columns(1).Width = 220
        GrdPemasok.Columns(2).Width = 200
        GrdPemasok.Columns(3).Width = 220

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Then
            MsgBox("Data Isian Harus Lenkap", MsgBoxStyle.Critical)

        Else
            cekkoneksi()
            sql = "SELECT * FROM tbsupplier WHERE id_supplier='" & Trim(txtkode.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO tbsupplier values ('" & txtkode.Text & "','" & _
                     txtnama.Text & "','" & txtalamat.Text & "','" & txttelp.Text & "')"
            Else
                sql = "UPDATE tbsupplier set nm_supplier='" & txtnama.Text & "',almt_supplier='" & txtalamat.Text & "',tlp_supplier='" & txttelp.Text & "' WHERE id_supplier='" & Trim(txtkode.Text) & "'"
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

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        TampilGrid()
    End Sub


    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        bersih()
        TidakAktif()
        TampilGrid()
        BtnTambah.Enabled = True
    End Sub
    Sub KlikGrid()
        Aktif()
        txtkode.Enabled = False
        txtkode.Text = GrdPemasok.CurrentRow.Cells(0).Value
        txtnama.Text = GrdPemasok.CurrentRow.Cells(1).Value
        txtalamat.Text = GrdPemasok.CurrentRow.Cells(2).Value
        txttelp.Text = GrdPemasok.CurrentRow.Cells(3).Value
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        cekkoneksi()
        sql = "SELECT * FROM tbsupplier where id_supplier='" & txtkode.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        tutupkoneksi()
        sql = "Delete From tbsupplier where id_supplier ='" & txtkode.Text & "'"
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

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub




    Private Sub txttelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelp.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And txttelp.Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GrdPemasok_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPemasok.CellContentClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub

    Private Sub GrdPemasok_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPemasok.CellContentDoubleClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub
End Class