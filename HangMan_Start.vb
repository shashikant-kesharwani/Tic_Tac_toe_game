Public Class HangMan_Start
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnfruits_Click(sender As Object, e As EventArgs) Handles btnfruits.Click
        HangMan_Game.Show()
        Me.Hide()
    End Sub

    Private Sub btnanimal_Click(sender As Object, e As EventArgs) Handles btnanimal.Click
        Animal.Show()
        Me.Hide()
    End Sub

    Private Sub btnflowers_Click(sender As Object, e As EventArgs) Handles btnflowers.Click
        Flowers.Show()
        Me.Hide()
    End Sub

    Private Sub btncolor_Click(sender As Object, e As EventArgs) Handles btncolor.Click
        Colors.Show()
        Me.Hide()
    End Sub
End Class