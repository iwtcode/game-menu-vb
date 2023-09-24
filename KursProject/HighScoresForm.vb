Public Class HighScoresForm

    'обновление списка лидеров
    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        StartForm.PrintHighScores("SnakeScores.txt", SnakeScores, 2)
        StartForm.PrintHighScores("MazeScores.txt", MazeScores, 1)
        StartForm.PrintHighScores("KeyboardScores.txt", KeyboardScores, 2)
    End Sub
End Class