Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim nama As String = txtnama.Text
        Dim noHp As String = txtnohp.Text
        Dim jenisMobil As String = cmbjenismobil.SelectedItem.ToString()
        Dim tipeLayanan As String = cmbtipelayanan.SelectedItem.ToString()
        Dim lamaSewa As Integer = CInt(txtlamasewa.Text)
        Dim totalBiayaSewa As Integer = 0

        ' Menentukan harga berdasarkan jenis mobil yang dipilih
        Select Case jenisMobil
            Case "Avanza"
                totalBiayaSewa = 240000
            Case "Calya"
                totalBiayaSewa = 210000
            Case "Inova"
                totalBiayaSewa = 340000
            Case "Xenia"
                totalBiayaSewa = 230000
            Case "Sigra"
                totalBiayaSewa = 200000
            Case "Brio"
                totalBiayaSewa = 230000
            Case "Mobilio"
                totalBiayaSewa = 240000
            Case "Xpander"
                totalBiayaSewa = 300000
        End Select

        ' Menambahkan biaya tambahan jika memilih layanan dengan sopir
        If tipeLayanan = "Dengan Sopir" Then
            totalBiayaSewa += 150000 * lamaSewa ' Biaya tambahan dengan sopir 150.000 per hari
        End If

        ' Menghitung total biaya sewa
        totalBiayaSewa *= lamaSewa

        ' Menampilkan informasi pemesanan
        Dim info As String = "Nama: " & nama & vbCrLf &
                             "No HP: " & noHp & vbCrLf &
                             "Jenis Mobil: " & jenisMobil & vbCrLf &
                             "Tipe Layanan: " & tipeLayanan & vbCrLf &
                             "Lama Sewa: " & lamaSewa.ToString() & " hari" & vbCrLf &
                             "Total Biaya Sewa: Rp. " & totalBiayaSewa.ToString("N0")
        MessageBox.Show(info, "Informasi Pemesanan Mobil")
    End Sub
End Class
