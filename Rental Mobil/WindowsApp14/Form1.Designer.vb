<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.cmbjenismobil = New System.Windows.Forms.ComboBox()
        Me.cmbtipelayanan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlamasewa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Hp"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(332, 79)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(121, 22)
        Me.txtnama.TabIndex = 2
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(332, 124)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(121, 22)
        Me.txtnohp.TabIndex = 3
        '
        'cmbjenismobil
        '
        Me.cmbjenismobil.FormattingEnabled = True
        Me.cmbjenismobil.Items.AddRange(New Object() {"Avanza", "Calya", "Inova", "Xenia", "Sigra", "Brio", "Mobilio", "Xpander"})
        Me.cmbjenismobil.Location = New System.Drawing.Point(332, 182)
        Me.cmbjenismobil.Name = "cmbjenismobil"
        Me.cmbjenismobil.Size = New System.Drawing.Size(121, 24)
        Me.cmbjenismobil.TabIndex = 4
        '
        'cmbtipelayanan
        '
        Me.cmbtipelayanan.FormattingEnabled = True
        Me.cmbtipelayanan.Items.AddRange(New Object() {"Dengan Sopir", "Lepas Kunci"})
        Me.cmbtipelayanan.Location = New System.Drawing.Point(332, 233)
        Me.cmbtipelayanan.Name = "cmbtipelayanan"
        Me.cmbtipelayanan.Size = New System.Drawing.Size(121, 24)
        Me.cmbtipelayanan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jenis Mobil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipe Layanan"
        '
        'txtlamasewa
        '
        Me.txtlamasewa.Location = New System.Drawing.Point(332, 290)
        Me.txtlamasewa.Name = "txtlamasewa"
        Me.txtlamasewa.Size = New System.Drawing.Size(121, 22)
        Me.txtlamasewa.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lama Sewa"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(254, 347)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Proses"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlamasewa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbtipelayanan)
        Me.Controls.Add(Me.cmbjenismobil)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents cmbjenismobil As ComboBox
    Friend WithEvents cmbtipelayanan As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlamasewa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
End Class
