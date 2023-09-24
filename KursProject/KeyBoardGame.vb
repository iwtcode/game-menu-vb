Public Class KeyboardSimulator
    Dim TextToInput(SettingsKeyboardForm.ValueLabel.Text - 1) As String
    Dim count, sec, min, ErrorCount As Integer
    Dim symbols As Single
    Dim LabelPressed As Label

    'сброс в исходное состояние
    Private Sub Launch_Tick(sender As Object, e As EventArgs) Handles Launch.Tick
        Randomize()
        TextBox1.Focus()
        ReDim Preserve TextToInput(SettingsKeyboardForm.ValueLabel.Text - 1)
        Timer.Enabled = False
        Delay.Enabled = False
        count = 0
        symbols = 0
        sec = 0
        min = 0
        ErrorCount = 0
        PrevText.Text = ""
        NewText.Text = ""
        NowText.Text = ""
        ErrorLabel.Text = "0 ошибок"
        SpeedLabel.Text = "0 симв/сек"
        TimerLabel.Text = "00 : 00"
        For i = 0 To UBound(TextToInput)
            If i Mod 6 = 0 And i <> 0 Then
                TextToInput(i) = " "
            Else
                If SettingsKeyboardForm.LanguageLabel.Text = "English" Then
                    If 0 + Int((1 - 0 + 1) * Rnd()) = 0 Then
                        TextToInput(i) = Chr(65 + Int((90 - 65 + 1) * Rnd()))
                    Else
                        TextToInput(i) = Chr(97 + Int((122 - 97 + 1) * Rnd()))
                    End If
                Else
                    TextToInput(i) = Chr(192 + Int((255 - 192 + 1) * Rnd()))
                End If
            End If
            If i <> 0 Then
                NewText.Text = NewText.Text & TextToInput(i)
            Else
                NowText.Text = NowText.Text & TextToInput(i)
            End If
        Next
        Launch.Enabled = False
    End Sub

    'обновление таймера
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TextBox1.Focus()
        SpeedLabel.Text = Math.Round(symbols / sec + min * 60, 3) & " симв/сек"
        sec += 1
        If sec = 60 Then
            sec = 0
            min += 1
        End If
        If min < 10 Then
            TimerLabel.Text = 0 & min
        Else
            TimerLabel.Text = min
        End If
        TimerLabel.Text = TimerLabel.Text & " : "
        If sec < 10 Then
            TimerLabel.Text = TimerLabel.Text & 0 & sec
        Else
            TimerLabel.Text = TimerLabel.Text & sec
        End If
    End Sub

    'собственно игра
    Private Sub Delay_Tick(sender As Object, e As EventArgs) Handles Delay.Tick
        Timer.Enabled = True
        If count <> UBound(TextToInput) Then
            If TextBox1.Text = NowText.Text Then
                NowText.BackColor = Color.FromArgb(0, 202, 47)
                symbols += 1
                count += 1
                If count <= 29 Then
                    PrevText.Text = PrevText.Text & NowText.Text
                Else
                    PrevText.Text = ""
                    For i = count - 29 To count - 1
                        PrevText.Text = PrevText.Text & TextToInput(i)
                    Next
                End If
                NowText.Text = TextToInput(count)
                NewText.Text = ""
                If count <= UBound(TextToInput) - 30 Then
                    For i = count + 1 To count + 30
                        NewText.Text = NewText.Text & TextToInput(i)
                    Next
                Else
                    For i = count + 1 To UBound(TextToInput)
                        NewText.Text = NewText.Text & TextToInput(i)
                    Next
                End If
            Else
                NowText.BackColor = Color.FromArgb(230, 0, 0)
                ErrorCount += 1
                ErrorLabel.Text = "ошибок: " & ErrorCount
            End If
        Else
            If TextBox1.Text = NowText.Text Then
                Timer.Enabled = False
                Delay.Enabled = False
                Dim score As Integer = symbols \ sec + min * 60
                StartForm.ReWrite("KeyboardScores.txt", StartForm.LoginBtn.Text, score, 1)
                MsgBox("Занятие закончено" & vbCrLf & SpeedLabel.Text & vbCrLf & ErrorLabel.Text)
                Launch.Enabled = True
            End If
        End If
        TextBox1.Text = ""
        Delay.Enabled = False
    End Sub

    'выход из игры
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        NewText.Text = ""
        NowText.Text = ""
        PrevText.Text = ""

        StartForm.Show()
        StartForm.Location = Me.Location
        Me.Hide()
    End Sub

    'демонстрация нажатий клавиш
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode <> 16 And e.KeyCode <> 17 And e.KeyCode <> 18 And e.KeyCode <> 20 Then
            Delay.Enabled = True
        End If
        LabelPressed = Controls.Item("k" & e.KeyCode)
        LabelPressed.BackColor = Color.FromArgb(70, 70, 70)
    End Sub
    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        LabelPressed = Controls.Item("k" & e.KeyCode)
        LabelPressed.BackColor = Color.FromArgb(40, 40, 40)
    End Sub
End Class