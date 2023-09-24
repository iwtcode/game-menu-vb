Public Class StartForm
    Dim MouseChecker As Boolean = True
    Dim UpDownChecker As Boolean = True
    Dim Counter As Integer
    Dim index As String

    'загрузка самого начального экрана
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(HighScoresForm)
        PrintHighScores("SnakeScores.txt", HighScoresForm.SnakeScores, 2)
        PrintHighScores("MazeScores.txt", HighScoresForm.MazeScores, 1)
        PrintHighScores("KeyboardScores.txt", HighScoresForm.KeyboardScores, 2)
    End Sub

    'функции для зажатия клавиши (вместо постоянного кликанья)
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles _
        SnakeDownSizeBtn1.MouseEnter, SnakeUpSizeBtn2.MouseEnter,
        SnakeDownSpeedBtn3.MouseEnter, SnakeUpSpeedBtn4.MouseEnter,
        MazeDownWidthBtn5.MouseEnter, MazeUpWidthBtn6.MouseEnter,
        MazeDownHeightBtn7.MouseEnter, MazeUpHeightBtn8.MouseEnter,
        KeyDownLettersBtn9.MouseEnter, KeyUpLettersBtn10.MouseEnter

        index = sender.Name
        index = index(Len(index) - 1)

        MouseChecker = True
        BtnTimer.Enabled = True
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles _
        SnakeDownSizeBtn1.MouseLeave, SnakeUpSizeBtn2.MouseLeave,
        SnakeDownSpeedBtn3.MouseLeave, SnakeUpSpeedBtn4.MouseLeave,
        MazeDownWidthBtn5.MouseLeave, MazeUpWidthBtn6.MouseLeave,
        MazeDownHeightBtn7.MouseLeave, MazeUpHeightBtn8.MouseLeave,
        KeyDownLettersBtn9.MouseLeave, KeyUpLettersBtn10.MouseLeave

        MouseChecker = False
        BtnTimer.Enabled = False
    End Sub
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        SnakeUpSizeBtn2.MouseDown, SnakeUpSpeedBtn4.MouseDown,
        MazeUpWidthBtn6.MouseDown, MazeUpHeightBtn8.MouseDown,
        KeyUpLettersBtn10.MouseDown

        UpDownChecker = True
    End Sub
    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        SnakeDownSizeBtn1.MouseDown, SnakeDownSpeedBtn3.MouseDown,
        MazeDownWidthBtn5.MouseDown, MazeDownHeightBtn7.MouseDown,
        KeyDownLettersBtn9.MouseDown

        UpDownChecker = False
    End Sub

    'функция увеличения/уменьшения каких-либо значений
    Private Sub BtnTimer_Tick(sender As Object, e As EventArgs) Handles BtnTimer.Tick
        If MouseButtons And MouseChecker Then
            If UpDownChecker = True Then
                If index = "2" Then
                    Counter = SettingsSnakeForm.SizeLabel.Text
                    If Counter < 30 Then
                        Counter += 1
                    End If
                    SettingsSnakeForm.SizeLabel.Text = Counter
                ElseIf index = "4" Then
                    Counter = SettingsSnakeForm.SpeedLabel.Text
                    If Counter < 300 Then
                        Counter += 10
                    End If
                    SettingsSnakeForm.SpeedLabel.Text = Counter
                ElseIf index = "6" Then
                    Counter = SettingsMazeForm.WidthLabel.Text
                    If Counter < 200 Then
                        Counter += 2
                    End If
                    SettingsMazeForm.WidthLabel.Text = Counter
                    SettingsMazeForm.Launch.Enabled = True
                ElseIf index = "8" Then
                    Counter = SettingsMazeForm.HeightLabel.Text
                    If Counter < 200 Then
                        Counter += 2
                    End If
                    SettingsMazeForm.HeightLabel.Text = Counter
                    SettingsMazeForm.Launch.Enabled = True
                ElseIf index = "0" Then
                    Counter = SettingsKeyboardForm.ValueLabel.Text
                    If Counter < 300 Then
                        Counter += 10
                    End If
                    SettingsKeyboardForm.ValueLabel.Text = Counter
                End If
            Else
                If index = "1" Then
                    Counter = SettingsSnakeForm.SizeLabel.Text
                    If Counter > 10 Then
                        Counter -= 1
                    End If
                    SettingsSnakeForm.SizeLabel.Text = Counter
                ElseIf index = "3" Then
                    Counter = SettingsSnakeForm.SpeedLabel.Text
                    If Counter > 30 Then
                        Counter -= 10
                    End If
                    SettingsSnakeForm.SpeedLabel.Text = Counter
                ElseIf index = "5" Then
                    Counter = SettingsMazeForm.WidthLabel.Text
                    If Counter > 10 Then
                        Counter -= 2
                    End If
                    SettingsMazeForm.WidthLabel.Text = Counter
                    SettingsMazeForm.Launch.Enabled = True
                ElseIf index = "7" Then
                    Counter = SettingsMazeForm.HeightLabel.Text
                    If Counter > 10 Then
                        Counter -= 2
                    End If
                    SettingsMazeForm.HeightLabel.Text = Counter
                    SettingsMazeForm.Launch.Enabled = True
                ElseIf index = "9" Then
                    Counter = SettingsKeyboardForm.ValueLabel.Text
                    If Counter > 10 Then
                        Counter -= 10
                    End If
                    SettingsKeyboardForm.ValueLabel.Text = Counter
                End If
            End If
        End If
    End Sub
    Private Sub LanguageBtn_Click(sender As Object, e As EventArgs) Handles LanguageBtn.Click
        If LanguageBtn.Text = "Russian" Then
            LanguageBtn.Text = "English"
            SettingsKeyboardForm.LanguageLabel.Text = "English"
        Else
            LanguageBtn.Text = "Russian"
            SettingsKeyboardForm.LanguageLabel.Text = "Russian"
        End If
    End Sub

    'смена формы внутри панели
    Sub SwitchPanel(panel As Form)
        FormPanel.Controls.Clear()
        panel.TopLevel = False
        FormPanel.Controls.Add(panel)
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub

    'функции для удобного показа/скрытия меню и переключения форм
    Sub HideSubMenu()
        If SnakeSubPanel.Visible = True Then SnakeSubPanel.Visible = False
        If MazeSubPanel.Visible = True Then MazeSubPanel.Visible = False
        If KeySubPanel.Visible = True Then KeySubPanel.Visible = False
    End Sub
    Private Sub SnakeBtn_Click(sender As Object, e As EventArgs) Handles SnakeBtn.Click
        If SnakeSubPanel.Visible = False Then
            HideSubMenu()
            SnakeSubPanel.Visible = True
            SwitchPanel(SettingsSnakeForm)
            SettingsSnakeForm.launch.Enabled = True
        Else
            SnakeSubPanel.Visible = False
            FormPanel.Controls.Clear()
            SwitchPanel(HighScoresForm)
        End If
    End Sub
    Private Sub MazeBtn_Click(sender As Object, e As EventArgs) Handles MazeBtn.Click
        If MazeSubPanel.Visible = False Then
            HideSubMenu()
            MazeSubPanel.Visible = True
            SwitchPanel(SettingsMazeForm)
            SettingsMazeForm.Launch.Enabled = True
        Else
            MazeSubPanel.Visible = False
            FormPanel.Controls.Clear()
            SwitchPanel(HighScoresForm)
        End If
    End Sub
    Private Sub KeyBoardBtn_Click(sender As Object, e As EventArgs) Handles KeyBtn.Click
        If KeySubPanel.Visible = False Then
            HideSubMenu()
            KeySubPanel.Visible = True
            SwitchPanel(SettingsKeyboardForm)
            SettingsKeyboardForm.Launch.Enabled = True
        Else
            KeySubPanel.Visible = False
            FormPanel.Controls.Clear()
            SwitchPanel(HighScoresForm)
        End If
    End Sub

    'расположение элементов настроек змейки по центру (сложнее потому что используется графика)
    Private Sub StartForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If SnakeSubPanel.Visible = True Then SettingsSnakeForm.launch.Enabled = True
    End Sub

    'запуск программ
    Private Sub ApplyBtn_Click(sender As Object, e As EventArgs) Handles ApplyBtn.Click
        If SnakeSubPanel.Visible = True Then
            SnakeGame.Show()
            SnakeGame.Launch.Enabled = True
            SnakeGame.Location = Me.Location
            Me.Hide()
        ElseIf MazeSubPanel.Visible = True Then
            MazeGame.Show()
            MazeGame.Launch.Enabled = True
            MazeGame.Location = Me.Location
            Me.Hide()
        ElseIf KeySubPanel.Visible = True Then
            KeyboardSimulator.Show()
            KeyboardSimulator.Launch.Enabled = True
            KeyboardSimulator.Location = Me.Location
            Me.Hide()
        End If
    End Sub

    'выход из программы
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    'переливание цвета
    Dim r As Integer = 255
    Dim g As Integer = 44
    Dim b As Integer = 44
    Private Sub ArcadesTimer_Tick(sender As Object, e As EventArgs) Handles ArcadesTimer.Tick
        If r = 255 And g = 44 And b < 255 Then
            b += 1
        ElseIf g = 44 And b = 255 And r > 44 Then
            r -= 1
        ElseIf r = 44 And b = 255 And g < 255 Then
            g += 1
        ElseIf r = 44 And g = 255 And b > 44 Then
            b -= 1
        ElseIf g = 255 And b = 44 And r < 255 Then
            r += 1
        ElseIf r = 255 And b = 44 And g > 44 Then
            g -= 1
        End If
        HighScoresForm.ScoreLabel.ForeColor = Color.FromArgb(r, g, b)
        ArcadesBtn.ForeColor = Color.FromArgb(r, g, b)
    End Sub

    'авторизация
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If LoginBtn.Text <> "Авторизация" Then Login.UserLabel.Text = LoginBtn.Text Else Login.UserLabel.Text = "Гость"
        Login.Show()
    End Sub

    'обновление списка лидеров
    Sub PrintHighScores(filename As String, tablename As ListBox, mode As Integer)
        Dim count As Integer
        Dim score As String
        Dim ind As Integer = 0
        FileOpen(1, filename, OpenMode.Input)
        Do
            LineInput(1)
            count += 1
        Loop While Not EOF(1)
        Dim logins(count - 1) As String
        Dim indArr(count - 1) As Integer
        Dim scores(count - 1) As Integer
        For i = 0 To UBound(indArr)
            indArr(i) = i
        Next
        FileClose(1)
        FileOpen(1, filename, OpenMode.Input)
        Do
            score = LineInput(1)
            scores(ind) = Int(Mid(score, InStr(score, "=") + 1, Len(score) - 1))
            score = Replace(score, "=", " ")
            logins(ind) = score
            ind += 1
        Loop While Not EOF(1)
        FileClose(1)
        tablename.Items.Clear()
        IndexArrSort(scores, indArr)

        If tablename.Name = "SnakeScores" Then
            tablename.Items.Add("Змейка (по max" & vbCrLf)
            tablename.Items.Add("длинe змейки):" & vbCrLf)
        ElseIf tablename.Name = "MazeScores" Then
            tablename.Items.Add("Лабиринт (min шагов;" & vbCrLf)
            tablename.Items.Add("только 30x30):" & vbCrLf)
        ElseIf tablename.Name = "KeyboardScores" Then
            tablename.Items.Add("Клавиатура" & vbCrLf)
            tablename.Items.Add("(симв в сек):" & vbCrLf)
        End If
        If mode = 1 Then
            For i = 0 To UBound(logins)
                tablename.Items.Add(logins(indArr(i)) & vbCrLf)
            Next
        Else
            For i = UBound(logins) To 0 Step -1
                tablename.Items.Add(logins(indArr(i)) & vbCrLf)
            Next
        End If
    End Sub

    'перепись файла с рекордами игроков
    Sub ReWrite(filename As String, login As String, score As Integer, mode As Integer)
        If LoginBtn.Text <> "Авторизация" Then
            Dim FindLogin As Boolean = False
            Dim strlogin As String
            Dim Index As Integer = 0
            Dim LoginIndex As Integer

            FileOpen(1, filename, OpenMode.Input)
            Do
                strlogin = LineInput(1)
                If login = Mid(strlogin, 1, InStr(strlogin, "=") - 1) Then FindLogin = True : LoginIndex = Index
                Index += 1
            Loop While Not EOF(1)
            Dim AllLogins(Index - 1) As String
            FileClose(1)
            FileOpen(1, filename, OpenMode.Input)
            Index = 0
            Do
                strlogin = LineInput(1)
                AllLogins(Index) = strlogin
                Index += 1
            Loop While Not EOF(1)
            FileClose(1)

            If FindLogin = True Then
                If mode = 1 And score > Int(Mid(AllLogins(LoginIndex), InStr(AllLogins(LoginIndex), "=") + 1, Len(strlogin) - 1)) Or mode = 2 And score < Int(Mid(AllLogins(LoginIndex), InStr(AllLogins(LoginIndex), "=") + 1, Len(strlogin) - 1)) Then
                    AllLogins(LoginIndex) = Mid(AllLogins(LoginIndex), 1, InStr(AllLogins(LoginIndex), "=")) & score
                    FileOpen(1, filename, OpenMode.Output)
                    Index = 0
                    For i = 0 To UBound(AllLogins)
                        PrintLine(1, AllLogins(Index))
                        Index += 1
                    Next
                    FileClose(1)
                End If
            Else
                FileOpen(1, filename, OpenMode.Output)
                Index = 0
                For i = 0 To UBound(AllLogins)
                    PrintLine(1, AllLogins(Index))
                    Index += 1
                Next
                PrintLine(1, login & "=" & score)
                FileClose(1)
            End If
        End If
    End Sub

    'сортировка вставкой индексного массива
    Sub IndexArrSort(arr() As Integer, indArr() As Integer)
        Dim bufer As Integer
        For i = 0 To UBound(indArr) - 1
            Dim j As Integer = i
            Do While arr(indArr(j)) > arr(indArr(j + 1))
                bufer = indArr(j)
                indArr(j) = indArr(j + 1)
                indArr(j + 1) = bufer
                j -= 1
                If j = -1 Then Exit Do
            Loop
        Next
    End Sub
End Class