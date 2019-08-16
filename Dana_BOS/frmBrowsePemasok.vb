Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmBrowsePemasok

    Private Sub frmBrowsePemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilGrid()
        AturGrid()
    End Sub
    Sub TampilGrid()
        tutupkoneksi()
        cekkoneksi()
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter("SELECT * from tbsupplier where " & _
        "nm_supplier like '" & Trim(txtcari.Text) & "%' order by id_supplier", conn)
        Adapter.Fill(table)
        GrdSupplier.DataSource = table
        GrdSupplier.Refresh()
        tutupkoneksi()
        Me.GrdSupplier.Columns(0).HeaderText = "Kode Pemasok"
        Me.GrdSupplier.Columns(1).HeaderText = "Nama"
        Me.GrdSupplier.Columns(2).HeaderText = "Alamat"
        Me.GrdSupplier.Columns(3).HeaderText = "Telphone"
    End Sub
    Sub AturGrid()
        GrdSupplier.Columns(0).Width = 100
        GrdSupplier.Columns(1).Width = 220
        GrdSupplier.Columns(2).Width = 200
        GrdSupplier.Columns(3).Width = 220
    End Sub

    Private Sub GrdSupplier_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSupplier.CellContentClick
        GridKlik()
        frmPembelian.txtno.Focus()
        Me.Close()
    End Sub

    Private Sub GrdSupplier_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSupplier.CellContentDoubleClick
        GridKlik()
        frmPembelian.txtno.Focus()
        Me.Close()
    End Sub
    Sub GridKlik()
        With frmPembelian
            frmPembelian.txtkdsupplier.Text = GrdSupplier.CurrentRow.Cells(0).Value
            frmPembelian.txtsupplier.Text = GrdSupplier.CurrentRow.Cells(1).Value
            frmPembelian.txtno.Focus()
        End With
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class