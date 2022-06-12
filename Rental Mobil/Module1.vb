Imports System.Data.Odbc

Module Module1
    Public konek As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As DataSet
    Public CMD As OdbcCommand

    Sub KoneksiDatabase()
        Try
            konek = New OdbcConnection("DSN=DB_RENTAL_MOBIL;MultipleActiveResultSets=True")
            If konek.State = ConnectionState.Closed Then
                konek.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke Database Gagal", vbCritical, "Gagal")
        End Try
    End Sub
End Module
