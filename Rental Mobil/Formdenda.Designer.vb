<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formdenda
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtkoderental = New System.Windows.Forms.TextBox()
        Me.txtkodedenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabeldenda = New System.Windows.Forms.DataGridView()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnhapus1 = New System.Windows.Forms.Button()
        Me.btnedit1 = New System.Windows.Forms.Button()
        Me.btnsimpan1 = New System.Windows.Forms.Button()
        Me.btntambah1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txttelat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblbiaya = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        CType(Me.tabeldenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(59, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 29)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Form Denda"
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(140, 246)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(184, 34)
        Me.txtstatus.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 25)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Status"
        '
        'txttanggal
        '
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Location = New System.Drawing.Point(140, 137)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(184, 34)
        Me.txttanggal.TabIndex = 68
        '
        'txtkoderental
        '
        Me.txtkoderental.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkoderental.Location = New System.Drawing.Point(140, 102)
        Me.txtkoderental.Name = "txtkoderental"
        Me.txtkoderental.Size = New System.Drawing.Size(184, 34)
        Me.txtkoderental.TabIndex = 67
        '
        'txtkodedenda
        '
        Me.txtkodedenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodedenda.Location = New System.Drawing.Point(140, 66)
        Me.txtkodedenda.Name = "txtkodedenda"
        Me.txtkodedenda.Size = New System.Drawing.Size(50, 34)
        Me.txtkodedenda.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Biaya Denda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Kode Rental"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Kode Denda"
        '
        'tabeldenda
        '
        Me.tabeldenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabeldenda.Location = New System.Drawing.Point(340, 12)
        Me.tabeldenda.Name = "tabeldenda"
        Me.tabeldenda.RowTemplate.Height = 24
        Me.tabeldenda.Size = New System.Drawing.Size(685, 315)
        Me.tabeldenda.TabIndex = 73
        '
        'btnkembali
        '
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.Location = New System.Drawing.Point(118, 333)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(93, 41)
        Me.btnkembali.TabIndex = 78
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnhapus1
        '
        Me.btnhapus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus1.Location = New System.Drawing.Point(12, 333)
        Me.btnhapus1.Name = "btnhapus1"
        Me.btnhapus1.Size = New System.Drawing.Size(100, 41)
        Me.btnhapus1.TabIndex = 77
        Me.btnhapus1.Text = "Hapus"
        Me.btnhapus1.UseVisualStyleBackColor = True
        '
        'btnedit1
        '
        Me.btnedit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit1.Location = New System.Drawing.Point(216, 286)
        Me.btnedit1.Name = "btnedit1"
        Me.btnedit1.Size = New System.Drawing.Size(102, 41)
        Me.btnedit1.TabIndex = 76
        Me.btnedit1.Text = "Update"
        Me.btnedit1.UseVisualStyleBackColor = True
        '
        'btnsimpan1
        '
        Me.btnsimpan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan1.Location = New System.Drawing.Point(118, 286)
        Me.btnsimpan1.Name = "btnsimpan1"
        Me.btnsimpan1.Size = New System.Drawing.Size(92, 41)
        Me.btnsimpan1.TabIndex = 75
        Me.btnsimpan1.Text = "Simpan"
        Me.btnsimpan1.UseVisualStyleBackColor = True
        '
        'btntambah1
        '
        Me.btntambah1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah1.Location = New System.Drawing.Point(12, 286)
        Me.btntambah1.Name = "btntambah1"
        Me.btntambah1.Size = New System.Drawing.Size(100, 41)
        Me.btntambah1.TabIndex = 74
        Me.btntambah1.Text = "Clear"
        Me.btntambah1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(217, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 41)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Hitung Denda"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txttelat
        '
        Me.txttelat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelat.Location = New System.Drawing.Point(140, 171)
        Me.txttelat.Name = "txttelat"
        Me.txttelat.Size = New System.Drawing.Size(184, 34)
        Me.txttelat.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 25)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Telat /Day"
        '
        'lblbiaya
        '
        Me.lblbiaya.AutoSize = True
        Me.lblbiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbiaya.Location = New System.Drawing.Point(137, 212)
        Me.lblbiaya.Name = "lblbiaya"
        Me.lblbiaya.Size = New System.Drawing.Size(33, 25)
        Me.lblbiaya.TabIndex = 82
        Me.lblbiaya.Text = "---"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(883, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 41)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "Cetak Kwitansi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(735, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 41)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "Cetak Laporan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintDocument2
        '
        '
        'Formdenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 385)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblbiaya)
        Me.Controls.Add(Me.txttelat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnhapus1)
        Me.Controls.Add(Me.btnedit1)
        Me.Controls.Add(Me.btnsimpan1)
        Me.Controls.Add(Me.btntambah1)
        Me.Controls.Add(Me.tabeldenda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txtkoderental)
        Me.Controls.Add(Me.txtkodedenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formdenda"
        Me.Text = "Formdenda"
        CType(Me.tabeldenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtkoderental As System.Windows.Forms.TextBox
    Friend WithEvents txtkodedenda As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabeldenda As System.Windows.Forms.DataGridView
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents btnhapus1 As System.Windows.Forms.Button
    Friend WithEvents btnedit1 As System.Windows.Forms.Button
    Friend WithEvents btnsimpan1 As System.Windows.Forms.Button
    Friend WithEvents btntambah1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txttelat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblbiaya As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
End Class
