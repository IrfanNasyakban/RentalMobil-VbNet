<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftarsewa
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
        Me.tabelsewamobil = New System.Windows.Forms.DataGridView()
        CType(Me.tabelsewamobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabelsewamobil
        '
        Me.tabelsewamobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelsewamobil.Location = New System.Drawing.Point(12, 11)
        Me.tabelsewamobil.Name = "tabelsewamobil"
        Me.tabelsewamobil.RowTemplate.Height = 24
        Me.tabelsewamobil.Size = New System.Drawing.Size(829, 337)
        Me.tabelsewamobil.TabIndex = 51
        '
        'daftarsewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 360)
        Me.Controls.Add(Me.tabelsewamobil)
        Me.Name = "daftarsewa"
        Me.Text = "daftarsewa"
        CType(Me.tabelsewamobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabelsewamobil As System.Windows.Forms.DataGridView
End Class
