Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim nama As String = txtNama.Text
        Dim noHp As String = txtNoHp.Text
        Dim jenisKamar As String = ""
        Dim hargaKamar As Integer = 0
        Dim tipeLayanan As String = cmbTipeLayanan.SelectedItem.ToString()
        Dim lamaMenginap As Integer = CInt(txtlamamenginap.Text)
        Dim totalHarga As Integer = 0

        ' Menentukan harga berdasarkan jenis kamar yang dipilih
        Select Case cmbTipeJenisKamar.SelectedItem.ToString()
            Case "Standar Room"
                hargaKamar = 200000
            Case "Superior"
                hargaKamar = 300000
            Case "Deluxe"
                hargaKamar = 350000
        End Select

        ' Menambahkan harga layanan tambahan (jika ada)
        If tipeLayanan = "Breakfast" Then
            totalHarga = (hargaKamar + 25000) * lamaMenginap 'Harga breakfast 25.000 per hari
        Else
            totalHarga = hargaKamar * lamaMenginap
        End If

        ' Menampilkan informasi pemesanan
        Dim info As String = "Nama: " & nama & vbCrLf &
                             "No HP: " & noHp & vbCrLf &
                             "Jenis Kamar: " & jenisKamar & vbCrLf &
                             "Tipe Layanan: " & tipeLayanan & vbCrLf &
                             "Lama Menginap: " & lamaMenginap.ToString() & " hari" & vbCrLf &
                             "Total Harga: Rp. " & totalHarga.ToString("N0")
        MessageBox.Show(info, "Informasi Pemesanan Hotel")
    End Sub
End Class
