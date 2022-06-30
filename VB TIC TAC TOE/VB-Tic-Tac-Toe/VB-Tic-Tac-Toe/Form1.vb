Public Class baseForm
    Dim Turn As Char = "X"

    Private Sub leftX_Click(sender As Object, e As EventArgs) Handles leftX.Click
        leftX.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub midX_Click(sender As Object, e As EventArgs) Handles midX.Click
        midX.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub rightX_Click(sender As Object, e As EventArgs) Handles rightX.Click
        rightX.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub leftY_Click(sender As Object, e As EventArgs) Handles leftY.Click
        leftY.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub midY_Click(sender As Object, e As EventArgs) Handles midY.Click
        midY.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub rightY_Click(sender As Object, e As EventArgs) Handles rightY.Click
        rightY.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub leftZ_Click(sender As Object, e As EventArgs) Handles leftZ.Click
        leftZ.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub midZ_Click(sender As Object, e As EventArgs) Handles midZ.Click
        midZ.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub

    Private Sub rightZ_Click(sender As Object, e As EventArgs) Handles rightZ.Click
        rightZ.Text = Turn
        If Turn = "X" Then
            Turn = "O"
        Else
            Turn = "X"
        End If

    End Sub


End Class
