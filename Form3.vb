Imports System.Runtime.Intrinsics.X86
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBoxComprim_TextChanged(sender As Object, e As EventArgs) Handles TextBoxComprim.TextChanged



    End Sub

    Private Sub TextBoxLargura_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLargura.TextChanged

    End Sub

    Private Sub Result_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged



    End Sub

    Private Sub CalcVolume_Click(sender As Object, e As EventArgs) Handles CalcVolume.Click
        Dim cumprimento, altura, largura, resultado As Single
        cumprimento = Val(TextBoxComprim.Text)
        altura = Val(TextBoxAltura.Text)
        largura = Val(TextBoxLargura.Text)
        resultado = cumprimento * altura * largura
        txtResultado.Text = "Resultado: " & resultado

    End Sub

    Private Sub TextBoxAltura_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAltura.TextChanged



    End Sub
End Class