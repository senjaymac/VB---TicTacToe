Public Class baseForm
    Dim Turn As Char = "X"
    Private Sub leftX_Click(sender As Object, e As EventArgs) Handles leftX.Click
        leftX.Text = Turn

    End Sub

    Private Sub midX_Click(sender As Object, e As EventArgs) Handles midX.Click
        midX.Text = Turn

    End Sub

    Private Sub rightX_Click(sender As Object, e As EventArgs) Handles rightX.Click
        rightX.Text = Turn

    End Sub


End Class
