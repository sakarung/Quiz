Public Class Form1





    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim nama As String = txtnama.Text
        Dim kelas As String = txtkelas.Text
        Dim nim As String = txtnim.Text
        Dim nilai As Double = Double.Parse(txtnilai.Text)
        Dim status As String = ""

        ' Hitung nilai akhir (rata-rata dari UTS, UAS, dan tugas)
        Dim nilaiAkhir As Double = (nilai + Double.Parse(txtUAS.Text) + Double.Parse(txtUTS.Text)) / 3

        ' Tentukan status kelulusan
        If nilaiAkhir >= 60 Then
            status = "LULUS"
        Else
            status = "TIDAK LULUS"
        End If

        ' Tampilkan hasil kelulusan
        lblHasil.Text = "Nama: " & nama & vbCrLf &
                       "Kelas: " & kelas & vbCrLf &
                       "NIM: " & nim & vbCrLf &
                       "Nilai Akhir: " & nilaiAkhir.ToString("N2") & vbCrLf &
                       "Status: " & status
    End Sub
End Class
