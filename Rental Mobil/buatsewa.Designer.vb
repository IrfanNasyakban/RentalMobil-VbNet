<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buatsewa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkodebayar = New System.Windows.Forms.TextBox()
        Me.txtkoderental = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.tabelbayar = New System.Windows.Forms.DataGridView()
        Me.btntambah1 = New System.Windows.Forms.Button()
        Me.btnsimpan1 = New System.Windows.Forms.Button()
        Me.btnedit1 = New System.Windows.Forms.Button()
        Me.btnhapus1 = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.tabelbayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Bayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Rental"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'txtkodebayar
        '
        Me.txtkodebayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodebayar.Location = New System.Drawing.Point(155, 69)
        Me.txtkodebayar.Name = "txtkodebayar"
        Me.txtkodebayar.Size = New System.Drawing.Size(50, 34)
        Me.txtkodebayar.TabIndex = 12
        '
        'txtkoderental
        '
        Me.txtkoderental.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkoderental.Location = New System.Drawing.Point(155, 105)
        Me.txtkoderental.Name = "txtkoderental"
        Me.txtkoderental.Size = New System.Drawing.Size(160, 34)
        Me.txtkoderental.TabIndex = 13
        '
        'txttanggal
        '
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Location = New System.Drawing.Point(155, 140)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(160, 34)
        Me.txttanggal.TabIndex = 14
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(155, 175)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(160, 34)
        Me.txtharga.TabIndex = 15
        '
        'tabelbayar
        '
        Me.tabelbayar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelbayar.Location = New System.Drawing.Point(332, 12)
        Me.tabelbayar.Name = "tabelbayar"
        Me.tabelbayar.RowTemplate.Height = 24
        Me.tabelbayar.Size = New System.Drawing.Size(685, 315)
        Me.tabelbayar.TabIndex = 50
        '
        'btntambah1
        '
        Me.btntambah1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah1.Location = New System.Drawing.Point(7, 286)
        Me.btntambah1.Name = "btntambah1"
        Me.btntambah1.Size = New System.Drawing.Size(100, 41)
        Me.btntambah1.TabIndex = 51
        Me.btntambah1.Text = "Clear"
        Me.btntambah1.UseVisualStyleBackColor = True
        '
        'btnsimpan1
        '
        Me.btnsimpan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan1.Location = New System.Drawing.Point(113, 286)
        Me.btnsimpan1.Name = "btnsimpan1"
        Me.btnsimpan1.Size = New System.Drawing.Size(92, 41)
        Me.btnsimpan1.TabIndex = 52
        Me.btnsimpan1.Text = "Simpan"
        Me.btnsimpan1.UseVisualStyleBackColor = True
        '
        'btnedit1
        '
        Me.btnedit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit1.Location = New System.Drawing.Point(211, 286)
        Me.btnedit1.Name = "btnedit1"
        Me.btnedit1.Size = New System.Drawing.Size(102, 41)
        Me.btnedit1.TabIndex = 53
        Me.btnedit1.Text = "Update"
        Me.btnedit1.UseVisualStyleBackColor = True
        '
        'btnhapus1
        '
        Me.btnhapus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus1.Location = New System.Drawing.Point(7, 333)
        Me.btnhapus1.Name = "btnhapus1"
        Me.btnhapus1.Size = New System.Drawing.Size(100, 41)
        Me.btnhapus1.TabIndex = 54
        Me.btnhapus1.Text = "Hapus"
        Me.btnhapus1.UseVisualStyleBackColor = True
        '
        'btnkembali
        '
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.Location = New System.Drawing.Point(113, 333)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(93, 41)
        Me.btnkembali.TabIndex = 55
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(155, 215)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(160, 34)
        Me.txtstatus.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 25)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Status"
        '
        'txtcari
        '
        Me.txtcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(389, 334)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(178, 34)
        Me.txtcari.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Cari:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(864, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 41)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Cetak Kwintasi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(74, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 29)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Form Kwitansi"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(705, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 41)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Buat Laporan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(213, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 56)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Daftar Sewa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'buatsewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 401)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnhapus1)
        Me.Controls.Add(Me.btnedit1)
        Me.Controls.Add(Me.btnsimpan1)
        Me.Controls.Add(Me.btntambah1)
        Me.Controls.Add(Me.tabelbayar)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txtkoderental)
        Me.Controls.Add(Me.txtkodebayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "buatsewa"
        Me.Text = "buatsewa"
        CType(Me.tabelbayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkodebayar As System.Windows.Forms.TextBox
    Friend WithEvents txtkoderental As System.Windows.Forms.TextBox
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents tabelbayar As System.Windows.Forms.DataGridView
    Friend WithEvents btntambah1 As System.Windows.Forms.Button
    Friend WithEvents btnsimpan1 As System.Windows.Forms.Button
    Friend WithEvents btnedit1 As System.Windows.Forms.Button
    Friend WithEvents btnhapus1 As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
