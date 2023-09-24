Public Class MazeGame
    Dim Graph1 As Graphics
    Dim Brush1 As New SolidBrush(Color.White)
    Dim key As Char
    Dim maze(300, 300) As Integer
    Dim x, y, n1, n2 As Integer
    Dim score As Integer

    'сброс в исходное состояние
    Private Sub Launch_Tick(sender As Object, e As EventArgs) Handles Launch.Tick
        n1 = SettingsMazeForm.HeightLabel.Text
        n2 = SettingsMazeForm.WidthLabel.Text
        PictureBox1.Focus()
        key = ""
        GenerateMaze(maze)
        x = 1 : y = 1
        score = 0
        PlayMazeGame()
        Launch.Enabled = False
    End Sub

    'перехват нажатия клавиши
    Private Sub PictureBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PictureBox1.KeyDown
        If e.KeyCode = 87 Then
            key = "w"
        ElseIf e.KeyCode = 83 Then
            key = "s"
        ElseIf e.KeyCode = 65 Then
            key = "a"
        ElseIf e.KeyCode = 68 Then
            key = "d"
        End If
        PlayMazeGame()
    End Sub

    'выход из игры
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        StartForm.Show()
        StartForm.Location = Me.Location
        Me.Hide()
    End Sub

    'собственно игра
    Sub PlayMazeGame()
        Graph1 = Me.PictureBox1.CreateGraphics()
        Dim x1, y1, x2, y2 As Integer

        If key = "w" And maze(x - 1, y) <> 1 And maze(x - 1, y) <> 2 Then x -= 1 : score += 1
        If key = "a" And maze(x, y - 1) <> 1 And maze(x, y - 1) <> 2 Then y -= 1 : score += 1
        If key = "s" And maze(x + 1, y) <> 1 And maze(x + 1, y) <> 2 Then x += 1 : score += 1
        If key = "d" And maze(x, y + 1) <> 1 And maze(x, y + 1) <> 2 Then y += 1 : score += 1

        Dim paintx, painty As Integer
        If y - 9 <= 0 Then y1 = 0 Else y1 = y - 9
        If y + 9 >= n2 Then y2 = n2 Else y2 = y + 9
        If x - 9 <= 0 Then x1 = 0 Else x1 = x - 9
        If x + 9 >= n1 Then x2 = n1 Else x2 = x + 9
        paintx = 0
        painty = 0
        If x - 9 <= 0 Then
            For i = 1 To -(x - 9)
                Brush1.Color = Color.FromArgb(35, 35, 35)
                Graph1.FillRectangle(Brush1, paintx, painty, 400, 20)
                painty += 20
            Next
        End If
        For i = x1 To x2
            paintx = -20
            If y - 9 <= 0 Then
                For k = 1 To -(y - 9)
                    paintx += 20
                    Brush1.Color = Color.FromArgb(35, 35, 35)
                    Graph1.FillRectangle(Brush1, paintx, painty, 20, 20)
                Next
            End If
            For k = y1 To y2
                If i = x And k = y Or i = n1 - 1 And k = n2 Then
                    Brush1.Color = Color.FromArgb(200, 0, 0)
                Else
                    If maze(i, k) = 2 Or maze(i, k) = 1 Then
                        Brush1.Color = Color.FromArgb(10, 10, 10)
                    ElseIf maze(i, k) = 0 Then
                        Brush1.Color = Color.FromArgb(221, 221, 221)
                    End If
                End If
                paintx += 20
                Graph1.FillRectangle(Brush1, paintx, painty, 20, 20)
                Brush1.Color = Color.FromArgb(35, 35, 35)
            Next
            If y + 9 >= n2 Then
                For j = 1 To y + 9 - n2
                    paintx += 20
                    Graph1.FillRectangle(Brush1, paintx, painty, 20, 20)
                Next
            End If
            paintx = 0
            painty += 20
            Graph1.FillRectangle(Brush1, paintx, painty, 400, 20)
        Next
        If x = n1 - 1 And y = n2 Then
            MsgBox("Вы вышли из лабиринта")
            If n1 = 30 And n2 = 30 Then StartForm.ReWrite("MazeScores.txt", StartForm.LoginBtn.Text, score, 2)
            Launch.Enabled = True
        End If
    End Sub

    'перегенерация лабиринта
    Sub GenerateMaze(maze(,) As Integer)
        Randomize()
        For i = 0 To n1
            For k = 0 To n2
                If i = 0 Or k = 0 Or i = n1 Or k = n2 Then
                    maze(i, k) = 2
                Else
                    maze(i, k) = 1
                End If
            Next
        Next

        Dim x, y, rndnum As Integer
        Dim accept() As Integer = {1, 2, 3, 4, 5}
        Dim deadend As Boolean
        x = 1 : y = 1
        Dim repeat As Integer = 1
        Do While repeat <= 1000000 Or maze(n1 - 1, n2 - 1) = 1
            For k = 0 To 3
                accept(k) = k + 1
            Next

            If maze(x + 1, y) <> 2 And maze(x + 1, y) <> 0 Then
                If maze(x + 2, y) = 0 Then accept(0) = 0
            Else
                accept(0) = 0
            End If
            If maze(x - 1, y) <> 2 And maze(x - 1, y) <> 0 Then
                If maze(x - 2, y) = 0 Then accept(1) = 0
            Else
                accept(1) = 0
            End If
            If maze(x, y + 1) <> 2 And maze(x, y + 1) <> 0 Then
                If maze(x, y + 2) = 0 Then accept(2) = 0
            Else
                accept(2) = 0
            End If
            If maze(x, y - 1) <> 2 And maze(x, y - 1) <> 0 Then
                If maze(x, y - 2) = 0 Then accept(3) = 0
            Else
                accept(3) = 0
            End If

            deadend = True
            For k = 0 To 3
                If accept(k) <> 0 Then deadend = False
            Next

            If deadend = False Then
                Do While True
                    If x = 0 Or x = n1 Or y = 0 Or y = n2 Then rndnum = 5 : Exit Do
                    rndnum = 1 + Int((5 - 1 + 1) * Rnd())
                    If accept(rndnum - 1) <> 0 Then Exit Do
                Loop


                If rndnum = 1 Then x += 1 : maze(x, y) = 0 : x += 1 : maze(x, y) = 0
                If rndnum = 2 Then x -= 1 : maze(x, y) = 0 : x -= 1 : maze(x, y) = 0
                If rndnum = 3 Then y += 1 : maze(x, y) = 0 : y += 1 : maze(x, y) = 0
                If rndnum = 4 Then y -= 1 : maze(x, y) = 0 : y -= 1 : maze(x, y) = 0

                If rndnum = 5 Then
                    For k = 0 To 3
                        accept(k) = k + 1
                    Next

                    If maze(x + 1, y) = 2 Then accept(0) = 0
                    If maze(x - 1, y) = 2 Then accept(1) = 0
                    If maze(x, y + 1) = 3 Then accept(2) = 0
                    If maze(x, y - 1) = 4 Then accept(3) = 0

                    If 1 + Int((100 - 1 + 1) * Rnd()) <= 20 Then
                        Do While True
                            rndnum = 1 + Int((4 - 1 + 1) * Rnd())
                            If accept(rndnum - 1) <> 0 Then Exit Do
                        Loop

                        If rndnum = 1 And maze(x + 1, y) <> 2 Then
                            If maze(x + 2, y) = 0 Then x += 1 : maze(x, y) = 0 : x += 1 : maze(x, y) = 0
                        End If
                        If rndnum = 2 And maze(x - 1, y) <> 2 Then
                            If maze(x - 2, y) = 0 Then x -= 1 : maze(x, y) = 0 : x -= 1 : maze(x, y) = 0
                        End If
                        If rndnum = 3 And maze(x, y + 1) <> 2 Then
                            If maze(x, y + 2) = 0 Then y += 1 : maze(x, y) = 0 : y += 1 : maze(x, y) = 0
                        End If
                        If rndnum = 4 And maze(x, y - 1) <> 2 Then
                            If maze(x, y - 2) = 0 Then y -= 1 : maze(x, y) = 0 : y -= 1 : maze(x, y) = 0
                        End If
                    End If
                End If
            Else
                Do While True
                    rndnum = 1 + Int((4 - 1 + 1) * Rnd())
                    If rndnum = 1 And maze(x + 1, y) = 0 Then
                        If maze(x + 2, y) = 0 Then x += 2 : Exit Do
                    End If
                    If rndnum = 2 And maze(x - 1, y) = 0 Then
                        If maze(x - 2, y) = 0 Then x -= 2 : Exit Do
                    End If
                    If rndnum = 3 And maze(x, y + 1) = 0 Then
                        If maze(x, y + 2) = 0 Then y += 2 : Exit Do
                    End If
                    If rndnum = 4 And maze(x, y - 1) = 0 Then
                        If maze(x, y - 2) = 0 Then y -= 2 : Exit Do
                    End If
                Loop
            End If
            repeat += 1
        Loop
        maze(1, 1) = 0 : maze(n1 - 1, n2) = 0
    End Sub
End Class