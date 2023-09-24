Public Class SettingsKeyboardForm
    Dim letters(45) As String
    Dim count As Integer

    'визуализация бегущего текста (для запуска)
    Private Sub Launch_Tick(sender As Object, e As EventArgs) Handles Launch.Tick
        Randomize()
        PrevText.Text = ""
        NewText.Text = ""
        For i = 0 To UBound(letters)
            If LanguageLabel.Text = "English" Then
                If 0 + Int((1 - 0 + 1) * Rnd()) = 0 Then
                    letters(i) = Chr(65 + Int((90 - 65 + 1) * Rnd()))
                Else
                    letters(i) = Chr(97 + Int((122 - 97 + 1) * Rnd()))
                End If
            Else
                letters(i) = Chr(192 + Int((255 - 192 + 1) * Rnd()))
            End If
            If i > 23 And i <> UBound(letters) Then NewText.Text = NewText.Text & letters(i)
        Next
        PrevText.Text = letters(23)
        Launch.Enabled = False
    End Sub

    '(для последующей работы)
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Randomize()
        NewText.Text = ""
        If LanguageLabel.Text = "English" Then
            If 0 + Int((1 - 0 + 1) * Rnd()) = 0 Then
                letters(UBound(letters)) = Chr(65 + Int((90 - 65 + 1) * Rnd()))
            Else
                letters(UBound(letters)) = Chr(97 + Int((122 - 97 + 1) * Rnd()))
            End If
        Else
            letters(UBound(letters)) = Chr(192 + Int((255 - 192 + 1) * Rnd()))
        End If
        For i = 0 To UBound(letters) - 1
            letters(i) = letters(i + 1)
        Next
        If count < 23 Then
            PrevText.Text = PrevText.Text & letters(23)
            count += 1
        Else
            PrevText.Text = ""
            For i = 0 To 23
                PrevText.Text = PrevText.Text & letters(i)
            Next
        End If
        For i = 24 To UBound(letters) - 1
            NewText.Text = NewText.Text & letters(i)
        Next
    End Sub
End Class