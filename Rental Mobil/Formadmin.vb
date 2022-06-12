Public Class Formadmin

    Private Sub btnnasabah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnasabah.Click
        Me.Hide()
        tambahmobil.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        buatsewa.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Formdenda.Show()
    End Sub

    Private Sub Formadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class