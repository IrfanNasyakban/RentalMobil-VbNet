Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class Formdenda

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Dim WithEvents PD2 As New PrintDocument
    Dim PPD2 As New PrintPreviewDialog

    Sub tampil_denda()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_denda", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabeldenda.DataSource = DS.Tables(0)
        tabeldenda.ReadOnly = True
    End Sub

    Private Sub btntambah1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah1.Click
        txtkodedenda.Clear()
        txtkoderental.Clear()
        txttanggal.Clear()
        txttelat.Clear()
        lblbiaya.Text = "---"
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
        ElseIf txttelat.Text = "" Then
            MsgBox("Telat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            MsgBox("Status Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_DENDA WHERE KODE_DENDA = '" & "" & "" & "" & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "insert into tbl_denda (kode_rental, tanggal, telat_perhari, biaya_denda, status) value ('" & txtkoderental.Text & "','" _
                                                                                                                                & txttanggal.Text & "','" _
                                                                                                                                & txttelat.Text & "','" _
                                                                                                                                & lblbiaya.Text & "','" _
                                                                                                                                & txtstatus.Text & "')"
                CMD = New OdbcCommand(simpan, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", vbInformation, "Simpan")
                Call KoneksiDatabase()
                Call tampil_denda()
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
        ElseIf txttelat.Text = "" Then
            MsgBox("Telat Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtstatus.Text = "" Then
            MsgBox("Status Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_DENDA WHERE KODE_DENDA = '" & txtkodedenda.Text & "" & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim edit As String = "update tbl_denda set kode_rental ='" & txtkoderental.Text & _
                    "',tanggal='" & txttanggal.Text & _
                    "',telat_perhari='" & txttelat.Text & _
                    "',biaya_denda='" & lblbiaya.Text & _
                    "',status='" & txtstatus.Text & _
                    "' where kode_denda='" & txtkodedenda.Text & "'"

                CMD = New OdbcCommand(edit, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit", vbInformation, "Edit")
                Call KoneksiDatabase()
                Call tampil_denda()
            Else
                MsgBox("Data belum di pilih")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnhapus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus1.Click
        If txtkodedenda.Text = "" Then
            MsgBox("Kode Denda belum di pilih", vbInformation, "pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from tbl_denda where kode_denda = '" & txtkodedenda.Text & "'"
            CMD = New OdbcCommand(hapusdata, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", vbInformation, "pesan")
            Call KoneksiDatabase()
            Call tampil_denda()
        End If
    End Sub

    Private Sub Formdenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call tampil_denda()
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Hide()
        Formadmin.Show()
    End Sub

    Private Sub tabeldenda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabeldenda.CellContentClick

    End Sub

    Private Sub tabeldenda_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles tabeldenda.CellMouseClick
        On Error Resume Next
        txtkodedenda.Text = tabeldenda.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_DENDA WHERE KODE_DENDA = '" & txtkodedenda.Text & "" & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkodedenda.Text = DR.Item("KODE_DENDA")
            txtkoderental.Text = DR.Item("KODE_RENTAL")
            txttanggal.Text = DR.Item("TANGGAL")
            txttelat.Text = DR.Item("TELAT_PERHARI")
            lblbiaya.Text = DR.Item("BIAYA_DENDA")
            txtstatus.Text = DR.Item("STATUS")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txttelat.Text = "" Then
            MsgBox("Telat/Day Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf lblbiaya.Text = "" Then
            MsgBox("Biaya Tidak Boleh Kosong", vbExclamation, "Pesan")
            Exit Sub
        End If

        lblbiaya.Text = Val(txttelat.Text) * 100000
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 510, 130)
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

        e.Graphics.DrawString("Kwitansi Denda Rental Mobil", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("CV. SURYA RENTAL MOBIL", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("No: 0822-8899-0099", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Denda", f10b, Brushes.Black, 40, 70, tengah)
        e.Graphics.DrawString("Kode Rental", f10b, Brushes.Black, 130, 70, tengah)
        e.Graphics.DrawString("Tanggal", f10b, Brushes.Black, 210, 70, tengah)
        e.Graphics.DrawString("Telat/Hari", f10b, Brushes.Black, 290, 70, tengah)
        e.Graphics.DrawString("Biaya Denda", f10b, Brushes.Black, 380, 70, tengah)
        e.Graphics.DrawString("Status", f10b, Brushes.Black, 450, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)

        e.Graphics.DrawString(txtkodedenda.Text, f10, Brushes.Black, 33, 100)
        e.Graphics.DrawString(txtkoderental.Text, f10, Brushes.Black, 123, 100)
        e.Graphics.DrawString(txttanggal.Text, f10, Brushes.Black, 175, 100)
        e.Graphics.DrawString(txttelat.Text, f10, Brushes.Black, 285, 100)
        e.Graphics.DrawString(lblbiaya.Text, f10, Brushes.Black, 350, 100)
        e.Graphics.DrawString(txtstatus.Text, f10, Brushes.Black, 430, 100)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PPD2.Document = PD2
        PPD2.ShowDialog()
    End Sub

    Private Sub PD2_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD2.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 510, 560)
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

        e.Graphics.DrawString("Hasil Laporan Denda Rental Mobil", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("CV. SURYA RENTAL MOBIL", f10, Brushes.Black, centermargin, 30, tengah)
        e.Graphics.DrawString("No: 0822-8899-0099", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 55)

        e.Graphics.DrawString("Kode Denda", f10b, Brushes.Black, 40, 70, tengah)
        e.Graphics.DrawString("Kode Rental", f10b, Brushes.Black, 130, 70, tengah)
        e.Graphics.DrawString("Tanggal", f10b, Brushes.Black, 210, 70, tengah)
        e.Graphics.DrawString("Telat/Hari", f10b, Brushes.Black, 290, 70, tengah)
        e.Graphics.DrawString("Biaya Denda", f10b, Brushes.Black, 380, 70, tengah)
        e.Graphics.DrawString("Status", f10b, Brushes.Black, 450, 70, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 85)
        tabeldenda.AllowUserToAddRows = False

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To tabeldenda.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(tabeldenda.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 33, 80 + tinggi)
            e.Graphics.DrawString(tabeldenda.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 123, 80 + tinggi)
            e.Graphics.DrawString(tabeldenda.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 175, 80 + tinggi)
            e.Graphics.DrawString(tabeldenda.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 285, 80 + tinggi)
            e.Graphics.DrawString(tabeldenda.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 350, 80 + tinggi)
            e.Graphics.DrawString(tabeldenda.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 430, 80 + tinggi)
        Next
    End Sub
End Class