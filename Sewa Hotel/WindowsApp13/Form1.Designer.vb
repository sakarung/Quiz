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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.cmbTipeJenisKamar = New System.Windows.Forms.ComboBox()
        Me.cmbTipeLayanan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlamamenginap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Hp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kamar"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(267, 62)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(121, 22)
        Me.txtNama.TabIndex = 3
        '
        'txtNoHp
        '
        Me.txtNoHp.Location = New System.Drawing.Point(267, 114)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(121, 22)
        Me.txtNoHp.TabIndex = 4
        '
        'cmbTipeJenisKamar
        '
        Me.cmbTipeJenisKamar.FormattingEnabled = True
        Me.cmbTipeJenisKamar.Items.AddRange(New Object() {"Standar Room", "Superior", "Deluxe"})
        Me.cmbTipeJenisKamar.Location = New System.Drawing.Point(267, 161)
        Me.cmbTipeJenisKamar.Name = "cmbTipeJenisKamar"
        Me.cmbTipeJenisKamar.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipeJenisKamar.TabIndex = 5
        '
        'cmbTipeLayanan
        '
        Me.cmbTipeLayanan.FormattingEnabled = True
        Me.cmbTipeLayanan.Items.AddRange(New Object() {"Breakfast", "No Breakfast"})
        Me.cmbTipeLayanan.Location = New System.Drawing.Point(267, 213)
        Me.cmbTipeLayanan.Name = "cmbTipeLayanan"
        Me.cmbTipeLayanan.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipeLayanan.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipe Layanan"
        '
        'txtlamamenginap
        '
        Me.txtlamamenginap.Location = New System.Drawing.Point(267, 268)
        Me.txtlamamenginap.Name = "txtlamamenginap"
        Me.txtlamamenginap.Size = New System.Drawing.Size(121, 22)
        Me.txtlamamenginap.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lama Menginap"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(291, 334)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 40)
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
        Me.Controls.Add(Me.txtlamamenginap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTipeLayanan)
        Me.Controls.Add(Me.cmbTipeJenisKamar)
        Me.Controls.Add(Me.txtNoHp)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents cmbTipeJenisKamar As ComboBox
    Friend WithEvents cmbTipeLayanan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlamamenginap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
End Class
