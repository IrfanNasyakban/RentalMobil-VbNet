Imports System.Data.Odbc

Public Class daftarsewa

    Sub tampil_sewamobil()
        DA = New OdbcDataAdapter("SELECT * FROM tbl_sewa", konek)
        DS = New DataSet
        DA.Fill(DS)
        tabelsewamobil.DataSource = DS.Tables(0)
        tabelsewamobil.ReadOnly = True
    End Sub

    Private Sub daftarsewa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call tampil_sewamobil()
    End Sub
End Class