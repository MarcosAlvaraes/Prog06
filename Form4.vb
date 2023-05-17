Public Class Form4
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Somar_Click(sender As Object, e As EventArgs) Handles Somar.Click

        Dim soma, v1, v2 As Single

        v1 = Val(TextBoxV1.Text)
        v2 = Val(TextBoxV2.Text)

        soma = v1 + v2
        TextBoxResult.Text = soma

    End Sub

    Private Sub Subtrair_Click(sender As Object, e As EventArgs) Handles Subtrair.Click
        Dim subtrair, v1, v2 As Single

        v1 = Val(TextBoxV1.Text)
        v2 = Val(TextBoxV2.Text)

        subtrair = v1 - v2
        TextBoxResult.Text = subtrair

    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        Dim multiplicar, v1, v2 As Single

        v1 = Val(TextBoxV1.Text)
        v2 = Val(TextBoxV2.Text)

        multiplicar = v1 * v2
        TextBoxResult.Text = multiplicar
    End Sub

    Private Sub Dividir_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim dividir, v1, v2 As Single

        v1 = Val(TextBoxV1.Text)
        v2 = Val(TextBoxV2.Text)

        dividir = v1 / v2
        TextBoxResult.Text = dividir
    End Sub
End Class