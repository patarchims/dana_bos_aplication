Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmKomponen

    Private Sub frmKomponen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        sqlcommand = New MySqlCommand("select * from tbkomponen order by kd_komponen desc", conn)
        Dr = sqlcommand.ExecuteReader
        If Dr.Read Then
            strSementara = Mid(Dr.Item("kd_komponen"), 5, 6)
            strIsi = Val(strSementara) + 1
            txtkode.Text = "KM" + Mid("00000", 1, 6 - strIsi.Length) & strIsi
        Else
            txtkode.Text = "KM000001"
        End If
        txtkomponen.Focus()
    End Sub
    Sub bersih()
        txtkode.Text = ""
        txtkomponen.Text = ""
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

 

    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT * from tbkomponen where " & _
        "nm_komponen like '" & Trim(txtcari.Text) & "%' order by kd_komponen", conn)
        Adapter.Fill(table)
        GrdKomponen.DataSource = table
        GrdKomponen.Refresh()
        tutupkoneksi()
        Me.GrdKomponen.Columns(0).HeaderText = "Kode"
        Me.GrdKomponen.Columns(1).HeaderText = "Komponen"
    End Sub
    Sub AturGrid()
        GrdKomponen.Columns(0).Width = 140
        GrdKomponen.Columns(1).Width = 220

    End Sub



    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TampilGrid()
    End Sub




    Sub KlikGrid()
        Aktif()
        txtkode.Enabled = False
        txtkode.Text = GrdKomponen.CurrentRow.Cells(0).Value
        txtkomponen.Text = GrdKomponen.CurrentRow.Cells(1).Value
    End Sub






    Private Sub GrdKomponen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdKomponen.CellContentClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub

    Private Sub GrdKomponen_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdKomponen.CellContentDoubleClick
        KlikGrid()
        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub


  
    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        cekkoneksi()
        sql = "SELECT * FROM tbkomponen where kd_komponen='" & txtkode.Text & "'"
        sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dr.Close()
        Dr = sqlcommand.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then tutupkoneksi() : Exit Sub
        tutupkoneksi()
        sql = "Delete From tbkomponen where kd_komponen ='" & txtkode.Text & "'"
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


    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtkode.Text = "" Or txtkomponen.Text = "" Then
            MsgBox("Data Isian Harus Lenkap", MsgBoxStyle.Critical)

        Else
            cekkoneksi()
            sql = "SELECT * FROM tbkomponen WHERE kd_komponen='" & Trim(txtkode.Text) & "'"
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dr.Close()
            Dr = sqlcommand.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                sql = "INSERT INTO tbkomponen values ('" & txtkode.Text & "','" & _
                     txtkomponen.Text & "')"
            Else
                sql = "UPDATE tbkomponen set nm_komponen='" & txtkomponen.Text & "' WHERE kd_komponen='" & Trim(txtkode.Text) & "'"
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


    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class