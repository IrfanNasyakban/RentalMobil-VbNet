Imports System.Data.Odbc

Public Class loginadmin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Formutama.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub loginadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpassword.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Username atau password Tidak boleh kosong!")
        Else
            Call KoneksiDatabase()
            CMD = New OdbcCommand("select * from TBL_ADMIN where USERNAME='" & txtusername.Text & "' and PASSWORD='" & txtpassword.Text & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Berhasil")
                Me.Hide()
                Formadmin.Show()

            Else
                MsgBox("Username atau password salah", MsgBoxStyle.Exclamation, "Gagal")
            End If
        End If
    End Sub
End Class