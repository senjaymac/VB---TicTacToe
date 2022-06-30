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

            If midX.Text = leftX.Text And midX.Text = rightX.Text Then
                MessageBox.Show(midX.Text + " is The winner!!", "Congratulations")
            ElseIf midX.Text = midY.Text And midY.Text = midZ.Text Then
                MessageBox.Show(midX.Text + " is The winner!!", "Congratulations")

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


            If rightX.Text = midX.Text And midX.Text = leftX.Text Then
                MessageBox.Show(rightX.Text + " is The winner!!", "Congratulations")
            ElseIf rightX.Text = midY.Text And midY.Text = leftZ.Text Then
                MessageBox.Show(rightX.Text + " is The winner!!", "Congratulations")
            ElseIf rightX.Text = rightY.Text And rightY.Text = rightZ.Text Then
                MessageBox.Show(rightX.Text + " is The winner!!", "Congratulations")
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

            If leftY.Text = midY.Text And midY.Text = rightY.Text Then
                MessageBox.Show(leftY.Text + " is The winner!!", "Congratulations")
            ElseIf leftX.Text = leftY.Text And leftY.Text = leftZ.Text Then
                MessageBox.Show(leftY.Text + " is The winner!!", "Congratulations")

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


            If midY.Text = midX.Text And midY.Text = midZ.Text Then
                MessageBox.Show(midY.Text + " is The winner!!", "Congratulations")
            ElseIf midY.Text = leftX.Text And midY.Text = rightZ.Text Then
                MessageBox.Show(midY.Text + " is The winner!!", "Congratulations")
            ElseIf midY.Text = rightX.Text And midY.Text = leftZ.Text Then
                MessageBox.Show(midY.Text + " is The winner!!", "Congratulations")
            ElseIf midY.Text = leftY.Text And midY.Text = rightY.Text Then
                MessageBox.Show(midY.Text + " is The winner!!", "Congratulations")
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

            If rightY.Text = midY.Text And midY.Text = leftY.Text Then
                MessageBox.Show(rightY.Text + " is The winner!!", "Congratulations")
            ElseIf rightY.Text = rightZ.Text And rightY.Text = rightZ.Text Then
                MessageBox.Show(rightY.Text + " is The winner!!", "Congratulations")
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


            If leftZ.Text = midZ.Text And midZ.Text = rightZ.Text Then
                MessageBox.Show(leftZ.Text + " is The winner!!", "Congratulations")
            ElseIf leftZ.Text = leftY.Text And leftY.Text = leftX.Text Then
                MessageBox.Show(leftZ.Text + " is The winner!!", "Congratulations")
            ElseIf leftZ.Text = midY.Text And midY.Text = rightX.Text Then
                MessageBox.Show(leftZ.Text + " is The winner!!", "Congratulations")
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

            If midZ.Text = leftZ.Text And midZ.Text = rightZ.Text Then
                MessageBox.Show(midZ.Text + " is The winner!!", "Congratulations")
            ElseIf midZ.Text = midY.Text And midY.Text = midX.Text Then
                MessageBox.Show(midZ.Text + " is The winner!!", "Congratulations")
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


            If rightZ.Text = rightY.Text And rightY.Text = rightX.Text Then
                MessageBox.Show(rightZ.Text + " is The winner!!", "Congratulations")
            ElseIf rightZ.Text = midZ.Text And midZ.Text = leftZ.Text Then
                MessageBox.Show(rightZ.Text + " is The winner!!", "Congratulations")
            ElseIf rightZ.Text = midY.Text And midY.Text = leftX.Text Then
                MessageBox.Show(rightZ.Text + " is The winner!!", "Congratulations")
            End If
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        leftX.Text = ""
        midX.Text = ""
        rightX.Text = ""

        leftY.Text = ""
        midY.Text = ""
        rightY.Text = ""

        leftZ.Text = ""
        midZ.Text = ""
        rightZ.Text = ""
    End Sub
End Class
