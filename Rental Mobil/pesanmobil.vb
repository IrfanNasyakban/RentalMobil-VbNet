Imports System.Data.Odbc

Public Class pesanmobil
    Sub tampil_sewamobil()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_sewa", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelsewamobil.DataSource = DS.Tables(0)
        tabelsewamobil.ReadOnly = True
    End Sub
    Private Sub pesanmobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call tampil_sewamobil()
    End Sub

    Private Sub btntambah1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah1.Click
        txtkoderental.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txtnohp.Clear()
        txtlamasewa.Clear()
        txtnama.Focus()
    End Sub

    Private Sub btnsimpan1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan1.Click
        If txtnama.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtalamat.Text = "" Then
            MsgBox("Alamat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtnohp.Text = "" Then
            MsgBox("No HP Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtlamasewa.Text = "" Then
            MsgBox("Lama Sewa Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_SEWA WHERE KODE_RENTAL = '" & "" & "" & "" & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "insert into tbl_sewa (nama, alamat, no_hp, merek_mobil, lama_sewa) value ('" & txtnama.Text & "','" _
                                                                                                                     & txtalamat.Text & "','" _
                                                                                                                     & txtnohp.Text & "','" _
                                                                                                                     & lblpilihmobil.Text & "','" _
                                                                                                                     & txtlamasewa.Text & "')"
                CMD = New OdbcCommand(simpan, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", vbInformation, "Simpan")
                Call KoneksiDatabase()
                Call tampil_sewamobil()
            Else
                MsgBox("Data sudah ada")
            End If
        End If
    End Sub


    Private Sub avanza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avanza.CheckedChanged
        If avanza.Checked = True Then
            lblpilihmobil.Text = "Avanza"
        End If
    End Sub

    Private Sub innova_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles innova.CheckedChanged
        If innova.Checked = True Then
            lblpilihmobil.Text = "Innova"
        End If
    End Sub

    Private Sub kijang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kijang.CheckedChanged
        If kijang.Checked = True Then
            lblpilihmobil.Text = "Kijang"
        End If
    End Sub

    Private Sub yaris_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yaris.CheckedChanged
        If yaris.Checked = True Then
            lblpilihmobil.Text = "Yaris"
        End If
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Hide()
        Formutama.Show()
    End Sub

    Private Sub btnedit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit1.Click
        If txtnama.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtalamat.Text = "" Then
            MsgBox("Alamat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtnohp.Text = "" Then
            MsgBox("No HP Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtlamasewa.Text = "" Then
            MsgBox("Lama Sewa Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_SEWA WHERE KODE_RENTAL = '" & txtkoderental.Text & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim edit As String = "update tbl_sewa set nama ='" & txtnama.Text & _
                    "',alamat='" & txtalamat.Text & _
                    "',no_hp='" & txtnohp.Text & _
                    "',merek_mobil='" & lblpilihmobil.Text & _
                    "',lama_sewa='" & txtlamasewa.Text & _
                    "' where kode_rental='" & txtkoderental.Text & "'"

                CMD = New OdbcCommand(edit, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit", vbInformation, "Edit")
                Call KoneksiDatabase()
                Call tampil_sewamobil()
            Else
                MsgBox("Data belum di pilih")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnhapus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus1.Click
        If txtkoderental.Text = "" Then
            MsgBox("Kode belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_sewa where kode_rental = '" & txtkoderental.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", vbInformation, "pesan")
            Call KoneksiDatabase()
            Call tampil_sewamobil()
        End If
    End Sub

    Private Sub tabelsewamobil_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabelsewamobil.CellMouseClick
        On Error Resume Next
        txtkoderental.Text = tabelsewamobil.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_SEWA WHERE KODE_RENTAL = '" & txtkoderental.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkoderental.Text = DR.Item("KODE_RENTAL")
            txtnama.Text = DR.Item("NAMA")
            txtalamat.Text = DR.Item("ALAMAT")
            txtnohp.Text = DR.Item("NO_HP")
            lblpilihmobil.Text = DR.Item("MEREK_MOBIL")
            txtlamasewa.Text = DR.Item("LAMA_SEWA")
        End If
    End Sub

    Private Sub tabelsewamobil_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabelsewamobil.CellContentClick

    End Sub
End Class