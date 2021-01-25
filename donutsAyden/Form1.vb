Public Class Form1
    Dim intTotal As Integer = 0

    Private Sub btnShip_Click(sender As Object, e As EventArgs) Handles btnShip.Click
        Dim intDonuts As Integer
        Dim intPacks As Integer
        Dim intLeft As Integer
        Const PACK As Integer = 12

        intDonuts = Val(txtAmount.Text)

        intPacks = intDonuts \ PACK
        intLeft = intDonuts Mod PACK
        intTotal = intLeft + intTotal

        lblPack.Text = "Packs: " & intPacks
        lblLeftovers.Text = "Leftovers: " & intLeft
        lblLeft.Text = "Total Leftovers: " & intTotal

    End Sub
End Class