Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmLogin

    Sub FormKosong()
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Sub Login()
        If txtusername.Text = "" Then
            MsgBox("Username Tidak Boleh Kosong", MsgBoxStyle.Critical)
            txtusername.Focus()
        ElseIf txtpassword.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong", MsgBoxStyle.Critical)
            txtpassword.Focus()
        Else
            cekkoneksi()
            sqlcommand = New MySql.Data.MySqlClient.MySqlCommand("Select * from tbuser Where id_user='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", conn)

            Dr = sqlcommand.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("Maaf Username atau Password Anda Salah", vbOKOnly, "Konfirmasi")
                Dr.Close()
                tutupkoneksi()
                bersih()
                txtusername.Focus()
                Exit Sub
            Else
                'IndexMenu.Show()
                frmSplash.Show()
                'MessageBox.Show("Selamat Datang " & TxtUsername.Text & " di Apllikasi Penggajian Rumah Sakit Vita Insani Pematangsiantar", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
            End If

        End If
        Call formkosonglogin()
        txtusername.Focus()
    End Sub
    Sub bersih()
        txtpassword.Text = ""
        txtusername.Text = ""
    End Sub
    Sub formkosonglogin()
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Login()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cekkoneksi()
    End Sub
End Class
