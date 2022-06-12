Imports System.Data.Odbc

Public Class tambahmobil

    Sub tampil_tambahmobil()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_mobil", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabeltambahmobil.DataSource = DS.Tables(0)
        tabeltambahmobil.ReadOnly = True
    End Sub

    Private Sub btntambah1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah1.Click
        txtmerekmobil.Clear()
        txtnoplat.Clear()
        txttahun.Clear()
        txtmerekmobil.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtmerekmobil.Text = "" Then
            MsgBox("Merek Mobil Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtnoplat.Text = "" Then
            MsgBox("No Plat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttahun.Text = "" Then
            MsgBox("Kode Peminjam Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            Call KoneksiDatabase()
            Dim simpan As String = "insert into tbl_mobil values ('" & txtmerekmobil.Text & "','" _
                                                                      & txtnoplat.Text & "','" _
                                                                      & txttahun.Text & "')"
            CMD = New OdbcCommand(simpan, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Tambah Mobil Berhasil!", vbInformation, "Sukses")
            Call KoneksiDatabase()
            Call tampil_tambahmobil()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtmerekmobil.Text = "" Then
            MsgBox("Merek Mobil Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtnoplat.Text = "" Then
            MsgBox("No Plat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttahun.Text = "" Then
            MsgBox("Tahun Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_MOBIL WHERE MEREK_MOBIL = '" & txtmerekmobil.Text & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim edit As String = "update tbl_mobil set no_plat ='" & txtnoplat.Text & _
                    "',tahun='" & txttahun.Text & _
                    "' where merek_mobil='" & txtmerekmobil.Text & "'"

                CMD = New OdbcCommand(edit, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit", vbInformation, "Edit")
                Call KoneksiDatabase()
                Call tampil_tambahmobil()
            Else
                MsgBox("Data belum di pilih")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtmerekmobil.Text = "" Then
            MsgBox("Merek Mobil belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_mobil where merek_mobil = '" & txtmerekmobil.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", vbInformation, "pesan")
            Call KoneksiDatabase()
            Call tampil_tambahmobil()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Formadmin.Show()
    End Sub

    Private Sub tambahmobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call tampil_tambahmobil()
    End Sub

    Private Sub tabeltambahmobil_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabeltambahmobil.CellContentClick
        
    End Sub

    Private Sub tabeltambahmobil_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabeltambahmobil.CellMouseClick
        On Error Resume Next
        txtmerekmobil.Text = tabeltambahmobil.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_MOBIL WHERE MEREK_MOBIL = '" & txtmerekmobil.Text & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtmerekmobil.Text = DR.Item("MEREK_MOBIL")
            txtnoplat.Text = DR.Item("NO_PLAT")
            txttahun.Text = DR.Item("TAHUN")
        End If
    End Sub
End Class