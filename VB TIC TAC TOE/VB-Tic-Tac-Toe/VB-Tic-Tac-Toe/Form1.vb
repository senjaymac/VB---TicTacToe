Public Class baseForm
    Dim Turn As Char = "X"

    Private Sub leftX_Click(sender As Object, e As EventArgs) Handles leftX.Click
        If leftX.Text = "" Then
            leftX.Text = Turn

            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If

            If leftX.Text = midX.Text And midX.Text = rightX.Text Then
                MessageBox.Show(leftX.Text + " is The winner!!", "Congratulations")
            ElseIf leftX.Text = leftY.Text And leftY.Text = leftZ.Text Then
                MessageBox.Show(leftX.Text + " is The winner!!", "Congratulations")
            ElseIf leftX.Text = midY.Text And midY.Text = rightZ.Text Then
                MessageBox.Show(leftX.Text + " is The winner!!", "Congratulations")
            End If
        End If

    End Sub

    Private Sub midX_Click(sender As Object, e As EventArgs) Handles midX.Click
        If midX.Text = "" Then
            midX.Text = Turn

            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub

    Private Sub rightX_Click(sender As Object, e As EventArgs) Handles rightX.Click
        If rightX.Text = "" Then
            rightX.Text = Turn

            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub

    Private Sub leftY_Click(sender As Object, e As EventArgs) Handles leftY.Click
        If leftY.Text = "" Then
            leftY.Text = Turn
            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub

    Private Sub midY_Click(sender As Object, e As EventArgs) Handles midY.Click
        If midY.Text = "" Then
            midY.Text = Turn
            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub

    Private Sub rightY_Click(sender As Object, e As EventArgs) Handles rightY.Click
        If rightY.Text = "" Then
            rightY.Text = Turn
            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub

    Private Sub leftZ_Click(sender As Object, e As EventArgs) Handles leftZ.Click
        If leftZ.Text = "" Then
            leftZ.Text = Turn
            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub

    Private Sub midZ_Click(sender As Object, e As EventArgs) Handles midZ.Click
        If midZ.Text = "" Then
            midZ.Text = Turn
            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub

    Private Sub rightZ_Click(sender As Object, e As EventArgs) Handles rightZ.Click
        If rightZ.Text = "" Then
            rightZ.Text = Turn
            If Turn = "X" Then
                Turn = "O"
            Else
                Turn = "X"
            End If
        End If

    End Sub


End Class
