Public Class SnakeGame
    Dim Graph1 As Graphics
    Dim Brush1 As New SolidBrush(Color.White)
    Dim Pen1 As New Pen(Color.Black, 3)
    Dim room(50, 50) As Integer
    Dim n1, n2, x, y, xapple, yapple, score As Integer
    Dim key As Char

    'фокус на picture box откуда берется код клавиши
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        PictureBox1.Focus()
        PlaySnakeGame()
    End Sub

    'выход из игры
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Timer.Enabled = False
        StartForm.Show()
        StartForm.Location = Me.Location
        Me.Hide()
    End Sub

    'изменение размера и расположения элементов в зависимости от размера комнаты (сброс всего в исходное состояние)
    Private Sub Launch_Tick(sender As Object, e As EventArgs) Handles Launch.Tick
        n1 = SettingsSnakeForm.SizeLabel.Text - 1
        n2 = SettingsSnakeForm.SizeLabel.Text - 1
        Me.MinimumSize = New Point(n1 * 20 + 36, n2 * 20 + 110)
        Me.Size = New Point(n1 * 20 + 36, n2 * 20 + 110)
        PictureBox1.Size = New Point(n1 * 20 + 20, n2 * 20 + 20)

        ExitBtn.Location = New Point(2, n2 * 20 + 22)
        ScoreLabel.Location = New Point(ExitBtn.Width + 4, n2 * 20 + 22)

        Graph1 = Me.PictureBox1.CreateGraphics()
        Timer.Interval = SettingsSnakeForm.SpeedLabel.Text

        Me.Refresh()
        Regenerate()
        PictureBox1.Focus()
        Launch.Enabled = False
    End Sub

    'перехват нажатой клавиши
    Private Sub PictureBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PictureBox1.KeyDown
        Timer.Enabled = True
        Dim buferkey As Char
        buferkey = key
        If e.KeyCode = 87 Then
            key = "w"
        ElseIf e.KeyCode = 83 Then
            key = "s"
        ElseIf e.KeyCode = 65 Then
            key = "a"
        ElseIf e.KeyCode = 68 Then
            key = "d"
        End If
        If key <> "w" And key <> "a" And key <> "s" And key <> "d" Then key = buferkey
        If key = "w" And buferkey = "s" Then key = buferkey
        If key = "s" And buferkey = "w" Then key = buferkey
        If key = "a" And buferkey = "d" Then key = buferkey
        If key = "d" And buferkey = "a" Then key = buferkey
        ScoreLabel.Focus()
    End Sub

    'перегенерация комнаты
    Sub Regenerate()
        Randomize()
        Dim rndXline, rndYline As Integer
        Do
            rndXline = 0 + Int((n1 - 0 + 1) * Rnd())
        Loop While rndXline >= 1 And rndXline <= 3
        Do
            rndYline = 0 + Int((n2 - 0 + 1) * Rnd())
        Loop While rndYline = 1
        Timer.Enabled = False
        key = "d"
        score = 0

        For i = 0 To n1
            For k = 0 To n2
                If k = rndXline Or i = rndYline Then
                    room(i, k) = -1
                Else
                    room(i, k) = 0
                End If
            Next
        Next
        room(1, 1) = 3
        room(1, 2) = 2
        room(1, 3) = 1

        x = 1 : y = 3
        Do While True
            xapple = 0 + Int((n1 - 0 + 1) * Rnd())
            yapple = 0 + Int((n2 - 0 + 1) * Rnd())
            If room(xapple, yapple) = 0 Then room(xapple, yapple) = -2 : Exit Do
        Loop

        Dim paintx, painty As Integer
        paintx = -19
        For i = 0 To n1
            painty = 1
            paintx += 20
            For k = 0 To n2
                If room(i, k) = 1 Then
                    Brush1.Color = Color.Green
                ElseIf room(i, k) > 1 Then
                    Brush1.Color = Color.LimeGreen
                ElseIf room(i, k) = -1 Then
                    Brush1.Color = Color.Black
                ElseIf room(i, k) = -2 Then
                    Brush1.Color = Color.FromArgb(35, 35, 35)
                ElseIf room(i, k) = 0 Then
                    Brush1.Color = Color.FromArgb(35, 35, 35)
                End If
                Graph1.FillRectangle(Brush1, painty, paintx, 20, 20)
                If room(i, k) = -2 Then Brush1.Color = Color.DarkRed : Graph1.FillEllipse(Brush1, painty, paintx, 18, 18)
                painty += 20
            Next
        Next
    End Sub

    'собственно игра
    Sub PlaySnakeGame()
        Randomize()
        Dim xhead, yhead As Integer
        Dim win, crash, appletest, lasttest As Boolean
        crash = False
        win = True
        For i = 0 To n1
            For k = 0 To n2
                If room(i, k) = 0 Then
                    win = False : Exit For
                ElseIf i = n1 And k = n2 Then
                    win = True
                End If
            Next
            If win = False Then Exit For
        Next

        If key = "w" Then
            If x <> 0 Then
                If room(x - 1, y) = -2 Then appletest = True
                If room(x - 1, y) > 1 Or room(x - 1, y) = -1 Then
                    crash = True
                Else
                    x -= 1 : room(x, y) = 1
                End If
            Else
                If room(n1, y) = -2 Then appletest = True
                If room(n1, y) > 1 Or room(n1, y) = -1 Then
                    crash = True
                Else
                    x = n1 : room(x, y) = 1
                End If
            End If
        End If
        If key = "a" Then
            If y <> 0 Then
                If room(x, y - 1) = -2 Then appletest = True
                If room(x, y - 1) > 1 Or room(x, y - 1) = -1 Then
                    crash = True
                Else
                    y -= 1 : room(x, y) = 1
                End If
            Else
                If room(x, n2) = -2 Then appletest = True
                If room(x, n2) > 1 Or room(x, n2) = -1 Then
                    crash = True
                Else
                    y = n2 : room(x, y) = 1
                End If
            End If
        End If
        If key = "s" Then
            If x <> n1 Then
                If room(x + 1, y) = -2 Then appletest = True
                If room(x + 1, y) > 1 Or room(x + 1, y) = -1 Then
                    crash = True
                Else
                    x += 1 : room(x, y) = 1
                End If
            Else
                If room(0, y) = -2 Then appletest = True
                If room(0, y) > 1 Or room(0, y) = -1 Then
                    crash = True
                Else
                    x = 0 : room(x, y) = 1
                End If
            End If
        End If
        If key = "d" Then
            If y <> n2 Then
                If room(x, y + 1) = -2 Then appletest = True
                If room(x, y + 1) > 1 Or room(x, y + 1) = -1 Then
                    crash = True
                Else
                    y += 1 : room(x, y) = 1
                End If
            Else
                If room(x, 0) = -2 Then appletest = True
                If room(x, 0) > 1 Or room(x, 0) = -1 Then
                    crash = True
                Else
                    y = 0 : room(x, y) = 1
                End If
            End If
        End If

        xhead = x
        yhead = y
        If crash = False Then
            Do While True
                lasttest = True
                If x <> 0 Then
                    If room(x, y) = room(x - 1, y) Then
                        room(x - 1, y) = room(x, y) + 1
                        x -= 1
                        lasttest = False
                    End If
                End If
                If x = 0 Then
                    If room(x, y) = room(n1, y) Then
                        room(n1, y) = room(x, y) + 1
                        x = n1
                        lasttest = False
                    End If
                End If
                If x <> n1 Then
                    If room(x, y) = room(x + 1, y) Then
                        room(x + 1, y) = room(x, y) + 1
                        x += 1
                        lasttest = False
                    End If
                End If
                If x = n2 Then
                    If room(x, y) = room(0, y) Then
                        room(0, y) = room(x, y) + 1
                        x = 0
                        lasttest = False
                    End If
                End If
                If y <> 0 Then
                    If room(x, y) = room(x, y - 1) Then
                        room(x, y - 1) = room(x, y) + 1
                        y -= 1
                        lasttest = False
                    End If
                End If
                If y = 0 Then
                    If room(x, y) = room(x, n2) Then
                        room(x, n2) = room(x, y) + 1
                        y = n2
                        lasttest = False
                    End If
                End If
                If y <> n2 Then
                    If room(x, y) = room(x, y + 1) Then
                        room(x, y + 1) = room(x, y) + 1
                        y += 1
                        lasttest = False
                    End If
                End If
                If y = n2 Then
                    If room(x, y) = room(x, 0) Then
                        room(x, 0) = room(x, y) + 1
                        y = 0
                        lasttest = False
                    End If
                End If
                If lasttest = True Then
                    If appletest = False Then
                        room(x, y) = 0
                    End If
                    Exit Do
                End If
            Loop
        End If
        x = xhead
        y = yhead

        If appletest = True Then
            Do While True
                xapple = 0 + Int((n1 - 0 + 1) * Rnd())
                yapple = 0 + Int((n2 - 0 + 1) * Rnd())
                If room(xapple, yapple) = 0 Then room(xapple, yapple) = -2 : appletest = False : score += 1 : Exit Do
            Loop
        End If


        Dim paintx, painty As Integer
        paintx = -19
        For i = 0 To n1
            painty = 1
            paintx += 20
            For k = 0 To n2
                If room(i, k) = 1 Then
                    Brush1.Color = Color.Green
                ElseIf room(i, k) > 1 Then
                    Brush1.Color = Color.LimeGreen
                ElseIf room(i, k) = -1 Then
                    Brush1.Color = Color.Black
                ElseIf room(i, k) = -2 Then
                    Brush1.Color = Color.FromArgb(35, 35, 35)
                ElseIf room(i, k) = 0 Then
                    Brush1.Color = Color.FromArgb(35, 35, 35)
                End If
                Graph1.FillRectangle(Brush1, painty, paintx, 20, 20)
                If room(i, k) = -2 Then Brush1.Color = Color.DarkRed : Graph1.FillEllipse(Brush1, painty, paintx, 18, 18)
                painty += 20
            Next
        Next
        ScoreLabel.Text = "Счёт: " & score
        If crash = True Then
            Timer.Enabled = False
            MsgBox("Вы врезались")
            StartForm.ReWrite("SnakeScores.txt", StartForm.LoginBtn.Text, score, 1)
            Regenerate()
        ElseIf win = True Then
            Timer.Enabled = False
            MsgBox("Вы выйграли")
            StartForm.ReWrite("SnakeScores.txt", StartForm.LoginBtn.Text, score, 1)
            Regenerate()
        End If
    End Sub
End Class