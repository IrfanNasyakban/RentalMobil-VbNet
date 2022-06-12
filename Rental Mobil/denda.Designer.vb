<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class denda
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
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtkoderental = New System.Windows.Forms.TextBox()
        Me.txtkodebayar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabelbayar = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnhapus1 = New System.Windows.Forms.Button()
        Me.btnedit1 = New System.Windows.Forms.Button()
        Me.btnsimpan1 = New System.Windows.Forms.Button()
        Me.btntambah1 = New System.Windows.Forms.Button()
        CType(Me.tabelbayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(145, 209)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(160, 34)
        Me.txtstatus.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 25)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Status"
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(145, 169)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(160, 34)
        Me.txtharga.TabIndex = 65
        '
        'txttanggal
        '
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Location = New System.Drawing.Point(145, 134)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(160, 34)
        Me.txttanggal.TabIndex = 64
        '
        'txtkoderental
        '
        Me.txtkoderental.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkoderental.Location = New System.Drawing.Point(145, 99)
        Me.txtkoderental.Name = "txtkoderental"
        Me.txtkoderental.Size = New System.Drawing.Size(160, 34)
        Me.txtkoderental.TabIndex = 63
        '
        'txtkodebayar
        '
        Me.txtkodebayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodebayar.Location = New System.Drawing.Point(145, 63)
        Me.txtkodebayar.Name = "txtkodebayar"
        Me.txtkodebayar.Size = New System.Drawing.Size(50, 34)
        Me.txtkodebayar.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 25)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "BIaya Denda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Kode Rental"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Kode Denda"
        '
        'tabelbayar
        '
        Me.tabelbayar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelbayar.Location = New System.Drawing.Point(320, 12)
        Me.tabelbayar.Name = "tabelbayar"
        Me.tabelbayar.RowTemplate.Height = 24
        Me.tabelbayar.Size = New System.Drawing.Size(685, 315)
        Me.tabelbayar.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(843, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 41)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Cetak Kwintasi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnkembali
        '
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.Location = New System.Drawing.Point(114, 307)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(93, 41)
        Me.btnkembali.TabIndex = 73
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnhapus1
        '
        Me.btnhapus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus1.Location = New System.Drawing.Point(8, 307)
        Me.btnhapus1.Name = "btnhapus1"
        Me.btnhapus1.Size = New System.Drawing.Size(100, 41)
        Me.btnhapus1.TabIndex = 72
        Me.btnhapus1.Text = "Hapus"
        Me.btnhapus1.UseVisualStyleBackColor = True
        '
        'btnedit1
        '
        Me.btnedit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit1.Location = New System.Drawing.Point(212, 260)
        Me.btnedit1.Name = "btnedit1"
        Me.btnedit1.Size = New System.Drawing.Size(102, 41)
        Me.btnedit1.TabIndex = 71
        Me.btnedit1.Text = "Update"
        Me.btnedit1.UseVisualStyleBackColor = True
        '
        'btnsimpan1
        '
        Me.btnsimpan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan1.Location = New System.Drawing.Point(114, 260)
        Me.btnsimpan1.Name = "btnsimpan1"
        Me.btnsimpan1.Size = New System.Drawing.Size(92, 41)
        Me.btnsimpan1.TabIndex = 70
        Me.btnsimpan1.Text = "Simpan"
        Me.btnsimpan1.UseVisualStyleBackColor = True
        '
        'btntambah1
        '
        Me.btntambah1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah1.Location = New System.Drawing.Point(8, 260)
        Me.btntambah1.Name = "btntambah1"
        Me.btntambah1.Size = New System.Drawing.Size(100, 41)
        Me.btntambah1.TabIndex = 69
        Me.btntambah1.Text = "Clear"
        Me.btntambah1.UseVisualStyleBackColor = True
        '
        'denda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 398)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnhapus1)
        Me.Controls.Add(Me.btnedit1)
        Me.Controls.Add(Me.btnsimpan1)
        Me.Controls.Add(Me.btntambah1)
        Me.Controls.Add(Me.tabelbayar)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txtkoderental)
        Me.Controls.Add(Me.txtkodebayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "denda"
        Me.Text = "denda"
        CType(Me.tabelbayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtkoderental As System.Windows.Forms.TextBox
    Friend WithEvents txtkodebayar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabelbayar As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents btnhapus1 As System.Windows.Forms.Button
    Friend WithEvents btnedit1 As System.Windows.Forms.Button
    Friend WithEvents btnsimpan1 As System.Windows.Forms.Button
    Friend WithEvents btntambah1 As System.Windows.Forms.Button
End Class
