Imports System.ComponentModel

Public Class Form5
    Private Sub ButEsconder_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButMostrar_Click(sender As Object, e As EventArgs) Handles ButMostrar.Click, ButMostrar.VisibleChanged
        TextBox1.Show()
    End Sub

    Private Sub ButMudCorFundLeg_Click(sender As Object, e As EventArgs) Handles ButMudCorFundLeg.Click
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.IndianRed
    End Sub

    Private Sub ButMudCorFunForm_Click(sender As Object, e As EventArgs) Handles ButMudCorFunForm.Click
        TextBox1.BackColor = Color.White
        TextBox1.BackColor = Color.Black
    End Sub

    Private Sub TextBox1_Text(sender As Object, e As EventArgs) Handles TextBox1.Click, ButMudCorFundLeg.ForeColorChanged

    End Sub

    Private Sub ButEsconder_Click_1(sender As Object, e As EventArgs) Handles ButEsconder.Click
        TextBox1.Hide()
    End Sub

    Private Sub ButNumAle_Click(sender As Object, e As EventArgs) Handles ButNumAle.Click
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
        Randomize()
        TextBox1.Text = Int((100 - 0 + 1) * Rnd() + 0)
    End Sub
End Class