Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblResult.Click

    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click

        ' Ambil nilai dari teks box
        Dim bilangan As Integer = Integer.Parse(TxtInput.Text)

        ' Cek apakah bilangan tersebut ganjil atau genap
        If bilangan Mod 2 = 0 Then
            LblResult.Text = bilangan.ToString() & " adalah bilangan genap."
        Else
            LblResult.Text = bilangan.ToString() & " adalah bilangan ganjil."
        End If
    End Sub

End Class
