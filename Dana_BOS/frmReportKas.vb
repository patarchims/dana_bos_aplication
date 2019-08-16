Public Class frmReportKas

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmReportKas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CRV.ReportSource = Nothing
        cboTriwulan.Items.Add("1")
        cboTriwulan.Items.Add("2")
        cboTriwulan.Items.Add("3")
        cboTriwulan.Items.Add("4")
        Tahun()
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
    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        ' CRV.SelectionFormula = "{Command_2.tahun}=" & Val(CboTahun.Text) & " and {Command_2.Triwulan}=" & Val(cboTriwulan.Text)
        CRV.SelectionFormula = "Year({Command.tanggal})=" & Val(CboTahun.Text) & " and {Command.triwulan}=" & Val(cboTriwulan.Text)
        'CRV.SelectionFormula = ""
        RptKas1.Load("RptKas.rpt")
        CRV.ReportSource = RptKas1
        CRV.RefreshReport()
    End Sub
End Class