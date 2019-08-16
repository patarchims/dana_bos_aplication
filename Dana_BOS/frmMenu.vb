Public Class frmMenu

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            If MessageBox.Show("Apakah Anda Yakin Untuk Keluar dari Aplikasi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                End
            Else
                Me.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            If MessageBox.Show("Apakah Anda Yakin Untuk Keluar dari Aplikasi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
               
                End
            Else
                Me.Show()
            End If
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub JenisBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisBukuToolStripMenuItem.Click
        frmPemasok.ShowDialog()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        frmKomponen.ShowDialog()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukuToolStripMenuItem.Click
        frmDana.ShowDialog()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        frmPengeluaran.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        frmPembelian.ShowDialog()
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        frmLaporan.ShowDialog()
    End Sub

    Private Sub frmMenu_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub


    Private Sub LaporanPembelianToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPembelianToolStripMenuItem1.Click
        frmLaporanBOSPembelian.ShowDialog()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        frmLaporan.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmLaporanBOSPembelian.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmPembelian.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmPengeluaran.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmDana.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmKomponen.ShowDialog()
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        frmPemasok.ShowDialog()
    End Sub

    Private Sub LaporanKasDanaBOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanKasDanaBOSToolStripMenuItem.Click
        frmKas.ShowDialog()
    End Sub

    Private Sub KASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmKas.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmKas.ShowDialog()
    End Sub
End Class