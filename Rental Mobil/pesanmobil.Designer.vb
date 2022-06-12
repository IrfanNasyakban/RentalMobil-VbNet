<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesanmobil
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtkoderental = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabelsewamobil = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btntambah1 = New System.Windows.Forms.Button()
        Me.btnedit1 = New System.Windows.Forms.Button()
        Me.btnhapus1 = New System.Windows.Forms.Button()
        Me.btnsimpan1 = New System.Windows.Forms.Button()
        Me.avanza = New System.Windows.Forms.RadioButton()
        Me.innova = New System.Windows.Forms.RadioButton()
        Me.kijang = New System.Windows.Forms.RadioButton()
        Me.yaris = New System.Windows.Forms.RadioButton()
        Me.lblpilihmobil = New System.Windows.Forms.Label()
        Me.txtlamasewa = New System.Windows.Forms.TextBox()
        CType(Me.tabelsewamobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(65, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Menyewa Mobil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Kode Rental"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Pilih Mobil"
        '
        'txtkoderental
        '
        Me.txtkoderental.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkoderental.Location = New System.Drawing.Point(152, 67)
        Me.txtkoderental.Name = "txtkoderental"
        Me.txtkoderental.Size = New System.Drawing.Size(69, 34)
        Me.txtkoderental.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sewa /day"
        '
        'tabelsewamobil
        '
        Me.tabelsewamobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelsewamobil.Location = New System.Drawing.Point(339, 21)
        Me.tabelsewamobil.Name = "tabelsewamobil"
        Me.tabelsewamobil.RowTemplate.Height = 24
        Me.tabelsewamobil.Size = New System.Drawing.Size(829, 337)
        Me.tabelsewamobil.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 24)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Nama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 24)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "No HP"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(152, 108)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(172, 34)
        Me.txtnama.TabIndex = 56
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(152, 148)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(172, 34)
        Me.txtalamat.TabIndex = 57
        '
        'txtnohp
        '
        Me.txtnohp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnohp.Location = New System.Drawing.Point(152, 185)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(172, 34)
        Me.txtnohp.TabIndex = 58
        '
        'btnkembali
        '
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.Location = New System.Drawing.Point(136, 423)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(92, 41)
        Me.btnkembali.TabIndex = 63
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btntambah1
        '
        Me.btntambah1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah1.Location = New System.Drawing.Point(12, 376)
        Me.btntambah1.Name = "btntambah1"
        Me.btntambah1.Size = New System.Drawing.Size(100, 41)
        Me.btntambah1.TabIndex = 61
        Me.btntambah1.Text = "Clear"
        Me.btntambah1.UseVisualStyleBackColor = True
        '
        'btnedit1
        '
        Me.btnedit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit1.Location = New System.Drawing.Point(203, 376)
        Me.btnedit1.Name = "btnedit1"
        Me.btnedit1.Size = New System.Drawing.Size(102, 41)
        Me.btnedit1.TabIndex = 62
        Me.btnedit1.Text = "Edit"
        Me.btnedit1.UseVisualStyleBackColor = True
        '
        'btnhapus1
        '
        Me.btnhapus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus1.Location = New System.Drawing.Point(12, 423)
        Me.btnhapus1.Name = "btnhapus1"
        Me.btnhapus1.Size = New System.Drawing.Size(119, 41)
        Me.btnhapus1.TabIndex = 59
        Me.btnhapus1.Text = "Batal Pesan"
        Me.btnhapus1.UseVisualStyleBackColor = True
        '
        'btnsimpan1
        '
        Me.btnsimpan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan1.Location = New System.Drawing.Point(112, 376)
        Me.btnsimpan1.Name = "btnsimpan1"
        Me.btnsimpan1.Size = New System.Drawing.Size(92, 41)
        Me.btnsimpan1.TabIndex = 60
        Me.btnsimpan1.Text = "Order"
        Me.btnsimpan1.UseVisualStyleBackColor = True
        '
        'avanza
        '
        Me.avanza.AutoSize = True
        Me.avanza.Location = New System.Drawing.Point(152, 237)
        Me.avanza.Name = "avanza"
        Me.avanza.Size = New System.Drawing.Size(76, 21)
        Me.avanza.TabIndex = 64
        Me.avanza.TabStop = True
        Me.avanza.Text = "Avanza"
        Me.avanza.UseVisualStyleBackColor = True
        '
        'innova
        '
        Me.innova.AutoSize = True
        Me.innova.Location = New System.Drawing.Point(248, 237)
        Me.innova.Name = "innova"
        Me.innova.Size = New System.Drawing.Size(71, 21)
        Me.innova.TabIndex = 65
        Me.innova.TabStop = True
        Me.innova.Text = "Innova"
        Me.innova.UseVisualStyleBackColor = True
        '
        'kijang
        '
        Me.kijang.AutoSize = True
        Me.kijang.Location = New System.Drawing.Point(152, 264)
        Me.kijang.Name = "kijang"
        Me.kijang.Size = New System.Drawing.Size(68, 21)
        Me.kijang.TabIndex = 66
        Me.kijang.TabStop = True
        Me.kijang.Text = "Kijang"
        Me.kijang.UseVisualStyleBackColor = True
        '
        'yaris
        '
        Me.yaris.AutoSize = True
        Me.yaris.Location = New System.Drawing.Point(248, 264)
        Me.yaris.Name = "yaris"
        Me.yaris.Size = New System.Drawing.Size(61, 21)
        Me.yaris.TabIndex = 67
        Me.yaris.TabStop = True
        Me.yaris.Text = "Yaris"
        Me.yaris.UseVisualStyleBackColor = True
        '
        'lblpilihmobil
        '
        Me.lblpilihmobil.AutoSize = True
        Me.lblpilihmobil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpilihmobil.Location = New System.Drawing.Point(148, 288)
        Me.lblpilihmobil.Name = "lblpilihmobil"
        Me.lblpilihmobil.Size = New System.Drawing.Size(28, 24)
        Me.lblpilihmobil.TabIndex = 68
        Me.lblpilihmobil.Text = "---"
        '
        'txtlamasewa
        '
        Me.txtlamasewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlamasewa.Location = New System.Drawing.Point(152, 316)
        Me.txtlamasewa.Name = "txtlamasewa"
        Me.txtlamasewa.Size = New System.Drawing.Size(172, 34)
        Me.txtlamasewa.TabIndex = 69
        '
        'pesanmobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 467)
        Me.Controls.Add(Me.txtlamasewa)
        Me.Controls.Add(Me.lblpilihmobil)
        Me.Controls.Add(Me.yaris)
        Me.Controls.Add(Me.kijang)
        Me.Controls.Add(Me.innova)
        Me.Controls.Add(Me.avanza)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btntambah1)
        Me.Controls.Add(Me.btnedit1)
        Me.Controls.Add(Me.btnhapus1)
        Me.Controls.Add(Me.btnsimpan1)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tabelsewamobil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtkoderental)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Name = "pesanmobil"
        Me.Text = "pesanmobil"
        CType(Me.tabelsewamobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkoderental As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabelsewamobil As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents btntambah1 As System.Windows.Forms.Button
    Friend WithEvents btnedit1 As System.Windows.Forms.Button
    Friend WithEvents btnhapus1 As System.Windows.Forms.Button
    Friend WithEvents btnsimpan1 As System.Windows.Forms.Button
    Friend WithEvents avanza As System.Windows.Forms.RadioButton
    Friend WithEvents innova As System.Windows.Forms.RadioButton
    Friend WithEvents kijang As System.Windows.Forms.RadioButton
    Friend WithEvents yaris As System.Windows.Forms.RadioButton
    Friend WithEvents lblpilihmobil As System.Windows.Forms.Label
    Friend WithEvents txtlamasewa As System.Windows.Forms.TextBox
End Class
