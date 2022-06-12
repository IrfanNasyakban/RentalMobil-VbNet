Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class buatsewa
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Dim WithEvents PD2 As New PrintDocument
    Dim PPD2 As New PrintPreviewDialog

    Sub tampil_bayar()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_bayar", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelbayar.DataSource = DS.Tables(0)
        tabelbayar.ReadOnly = True
    End Sub

    Private Sub btntambah1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah1.Click
        txtkodebayar.Clear()
        txtkoderental.Clear()
        txttanggal.Clear()
        txtharga.Clear()
        txtstatus.Clear()
        txtkoderental.Focus()
    End Sub

    Private Sub btnsimpan1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan1.Click
        If txtkoderental.Text = "" Then
            MsgBox("Kode Rental Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttanggal.Text = "" Then
            MsgBox("Tanggal Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtharga.Text = "" Then
            MsgBox("harga Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            MsgBox("Status Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_BAYAR WHERE KODE_BAYAR = '" & "" & "" & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "insert into tbl_bayar (kode_rental, tanggal, harga, status) value ('" & txtkoderental.Text & "','" _
                                                                                                              & txttanggal.Text & "','" _
                                                                                                              & txtharga.Text & "','" _
                                                                                                              & txtstatus.Text & "')"
                CMD = New OdbcCommand(simpan, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", vbInformation, "Simpan")
                Call KoneksiDatabase()
                Call tampil_bayar()
            Else
                MsgBox("Data sudah ada")
            End If
        End If
    End Sub

    Private Sub btnedit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit1.Click
        If txtkoderental.Text = "" Then
            MsgBox("Kode Rental Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txttanggal.Text = "" Then
            MsgBox("Tanggal Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtharga.Text = "" Then
            MsgBox("Harga Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            MsgBox("Status Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_BAYAR WHERE KODE_BAYAR = '" & txtkodebayar.Text & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim edit As String = "update tbl_bayar set kode_rental ='" & txtkoderental.Text & _
                    "',tanggal='" & txttanggal.Text & _
                    "',harga='" & txtharga.Text & _
                    "',status='" & txtstatus.Text & _
                    "' where kode_bayar='" & txtkodebayar.Text & "'"

                CMD = New OdbcCommand(edit, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit", vbInformation, "Edit")
                Call KoneksiDatabase()
                Call tampil_bayar()
            Else
                MsgBox("Data belum di pilih")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnhapus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus1.Click
        If txtkodebayar.Text = "" Then
            MsgBox("Kode Bayar belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_bayar where kode_bayar = '" & txtkodebayar.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", vbInformation, "pesan")
            Call KoneksiDatabase()
            Call tampil_bayar()
        End If
    End Sub

    Private Sub buatsewa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call tampil_bayar()

    End Sub



    Private Sub tabelbayar_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabelbayar.CellMouseClick
        On Error Resume Next
        txtkodebayar.Text = tabelbayar.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_BAYAR WHERE KODE_BAYAR = '" & txtkodebayar.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkodebayar.Text = DR.Item("KODE_BAYAR")
            txtkoderental.Text = DR.Item("KODE_RENTAL")
            txttanggal.Text = DR.Item("TANGGAL")
            txtharga.Text = DR.Item("HARGA")
            txtstatus.Text = DR.Item("STATUS")
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        DA = New OdbcDataAdapter("select * from tbl_bayar where kode_rental like '" & txtcari.Text & "%'", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelbayar.DataSource = DS.Tables(0)
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Hide()
        Formadmin.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 430, 130)
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub PD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-----------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Kwitansi Rental Mobil", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("CV. SURYA RENTAL MOBIL", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("No: 0822-8899-0099", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Bayar", f10b, Brushes.Black, 40, 70, tengah)
        e.Graphics.DrawString("Kode Rental", f10b, Brushes.Black, 130, 70, tengah)
        e.Graphics.DrawString("Tanggal", f10b, Brushes.Black, 210, 70, tengah)
        e.Graphics.DrawString("Harga", f10b, Brushes.Black, 290, 70, tengah)
        e.Graphics.DrawString("Status", f10b, Brushes.Black, 360, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)

        e.Graphics.DrawString(txtkodebayar.Text, f10, Brushes.Black, 33, 100)
        e.Graphics.DrawString(txtkoderental.Text, f10, Brushes.Black, 123, 100)
        e.Graphics.DrawString(txttanggal.Text, f10, Brushes.Black, 180, 100)
        e.Graphics.DrawString(txtharga.Text, f10, Brushes.Black, 265, 100)
        e.Graphics.DrawString(txtstatus.Text, f10, Brushes.Black, 340, 100)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtkodebayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodebayar.TextChanged

    End Sub

    Private Sub txtkoderental_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkoderental.TextChanged

    End Sub

    Private Sub txttanggal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttanggal.TextChanged

    End Sub

    Private Sub txtharga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtharga.TextChanged

    End Sub

    Private Sub txtstatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstatus.TextChanged

    End Sub

    Private Sub tabelbayar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabelbayar.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PPD2.Document = PD2
        PPD2.ShowDialog()
    End Sub

    Private Sub PD2_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD2.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 430, 500)
        PD2.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD2.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD2.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD2.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD2.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-----------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Hasil Laporan Rental Mobil", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("CV. SURYA RENTAL MOBIL", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("No: 0822-8899-0099", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Bayar", f10b, Brushes.Black, 40, 70, tengah)
        e.Graphics.DrawString("Kode Rental", f10b, Brushes.Black, 130, 70, tengah)
        e.Graphics.DrawString("Tanggal", f10b, Brushes.Black, 210, 70, tengah)
        e.Graphics.DrawString("Harga", f10b, Brushes.Black, 290, 70, tengah)
        e.Graphics.DrawString("Status", f10b, Brushes.Black, 360, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)
        tabelbayar.AllowUserToAddRows = False

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To tabelbayar.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(tabelbayar.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 33, 80 + tinggi)
            e.Graphics.DrawString(tabelbayar.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 123, 80 + tinggi)
            e.Graphics.DrawString(tabelbayar.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 180, 80 + tinggi)
            e.Graphics.DrawString(tabelbayar.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 265, 80 + tinggi)
            e.Graphics.DrawString(tabelbayar.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 340, 80 + tinggi)
        Next
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        daftarsewa.Show()
    End Sub
End Class