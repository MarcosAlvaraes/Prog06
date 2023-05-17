Public Class Form5
    Private Sub ButEsconder_Click(sender As Object, e As EventArgs) Handles ButEsconder.Click, ButEsconder.VisibleChanged
        Label1.Hide()
    End Sub

    Private Sub ButMostrar_Click(sender As Object, e As EventArgs) Handles ButMostrar.Click, ButMostrar.VisibleChanged
        Label1.Show()
    End Sub

    Private Sub ButMudCorFundLeg_Click(sender As Object, e As EventArgs) Handles ButMudCorFundLeg.Click, ButMudCorFundLeg.BackColorChanged

    End Sub

    Private Sub ButMudCorFunForm_Click(sender As Object, e As EventArgs) Handles ButMudCorFunForm.Click, ButMudCorFunForm.BackgroundImageChanged

    End Sub
End Class