Public Class Login
    'перевод из десятичного числа в двоичное
    Function ToBin(num As Integer) As String
        Dim n As Integer = num
        Dim res As String = ""
        Do While n <> 0
            n = num \ 2
            res = (num Mod 2) & res
            num \= 2
        Loop
        Do While Len(res) < 8
            res = "0" & res
        Loop
        Return res
    End Function

    'перевод из двоичного числа в десятичное
    Function ToInt(num As String) As Integer
        Dim res As Integer
        Dim n As String
        For i = 0 To Len(num) - 1
            n = num(Len(num) - 1 - i)
            res += Int(n) * 2 ^ i
        Next
        Return res
    End Function

    'замена 0 на 1 или 1 на 0 в двоичном числе
    Function ReplaceBit(num As String, index As Integer) As String
        If num(index) = "0" Then
            num = Mid(num, 1, index) & "1" & Mid(num, index + 2, Len(num))
        Else
            num = Mid(num, 1, index) & "0" & Mid(num, index + 2, Len(num))
        End If
        Return num
    End Function

    Dim test As Boolean = True

    'полупрозрачный текст для красивого оформления
    Private Sub LoginBox_MouseDown(sender As Object, e As EventArgs) Handles LoginBox.MouseDown
        If test = True Then
            LoginBox.Enabled = True
            PassBox.Enabled = True
            LoginBox.ForeColor = Color.FromArgb(0, 0, 0)
            PassBox.ForeColor = Color.FromArgb(0, 0, 0)
            LoginBox.Text = ""
            PassBox.Text = ""
            test = False
        End If
    End Sub
    Private Sub PassBox_MouseDown(sender As Object, e As MouseEventArgs) Handles PassBox.MouseDown
        If test = True Then
            LoginBox.Enabled = True
            PassBox.Enabled = True
            LoginBox.ForeColor = Color.FromArgb(0, 0, 0)
            PassBox.ForeColor = Color.FromArgb(0, 0, 0)
            LoginBox.Text = ""
            PassBox.Text = ""
            test = False
        End If
    End Sub

    'функция регистрации
    Private Sub RegBtn_Click(sender As Object, e As EventArgs) Handles RegBtn.Click
        If Crypt(LoginBox.Text, PassBox.Text, "code", 25, 1) = 1 Then
            TextLabel.Text = "Регистрация прошла успешно"
            UserLabel.Text = LoginBox.Text
            StartForm.LoginBtn.Text = LoginBox.Text
            Me.Close()
        ElseIf Crypt(LoginBox.Text, PassBox.Text, "code", 25, 1) = 0 Then
            TextLabel.Text = "Логин уже занят"
        ElseIf Crypt(LoginBox.Text, PassBox.Text, "code", 25, 1) = 2 Then
            TextLabel.Text = "Недопустимые символы"
        End If
    End Sub

    'функция входа
    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        If UserLabel.Text <> LoginBox.Text Then
            If Crypt(LoginBox.Text, PassBox.Text, "code", 25, 2) = 3 Then
                TextLabel.Text = "Успешная авторизация"
                UserLabel.Text = LoginBox.Text
                StartForm.LoginBtn.Text = LoginBox.Text
                Me.Close()
            ElseIf Crypt(LoginBox.Text, PassBox.Text, "code", 25, 2) = 4 Then
                TextLabel.Text = "Неверный логин или пароль"
            End If
        Else
            TextLabel.Text = "Вы уже авторизованы"
        End If
    End Sub

    'шифрование и дешифрование файла
    Function Crypt(login As String, pass As String, filename As String, key As String, Optional mode As Integer = 1) As Integer
        filename += ".bin"
        Dim test As Boolean = True
        Dim b As Byte
        Dim str As String = LoginBox.Text & "#" & PassBox.Text & "/"
        Dim count, index As Integer
        Dim s As String
        index = 0
        If mode = 1 Then
            For i = 0 To Len(login) - 1
                If Asc(login(i)) >= 48 And Asc(login(i)) <= 57 _
                    Or Asc(login(i)) >= 65 And Asc(login(i)) <= 90 _
                    Or Asc(login(i)) >= 97 And Asc(login(i)) <= 122 _
                    Or Asc(login(i)) >= 192 And Asc(login(i)) <= 255 Then
                Else
                    test = False
                End If
            Next
            For i = 0 To Len(pass) - 1
                If Asc(pass(i)) >= 48 And Asc(pass(i)) <= 57 _
                    Or Asc(pass(i)) >= 65 And Asc(pass(i)) <= 90 _
                    Or Asc(pass(i)) >= 97 And Asc(pass(i)) <= 122 Then
                Else
                    test = False
                End If
            Next


            If test = True Then
                If IO.File.Exists(filename) Then
                    FileOpen(1, filename, OpenMode.Binary)
                    Do
                        FileGet(1, b)
                        s = ToBin(b)
                        For i = 0 To Len(key) - 1
                            Dim ind As String = key(i)
                            s = ReplaceBit(s, Int(ind))
                        Next
                        b = ToInt(s)
                        If b = Asc("/") Then count += 1
                    Loop While Not EOF(1)
                    Dim logins(count) As String
                    FileClose(1)

                    FileOpen(1, filename, OpenMode.Binary)
                    Do
                        FileGet(1, b)
                        s = ToBin(b)
                        For i = 0 To Len(key) - 1
                            Dim ind As String = key(i)
                            s = ReplaceBit(s, Int(ind))
                        Next
                        b = ToInt(s)
                        If b = Asc("#") Then
                            index += 1
                            Do
                                FileGet(1, b)
                                s = ToBin(b)
                                For i = 0 To Len(key) - 1
                                    Dim ind As String = key(i)
                                    s = ReplaceBit(s, Int(ind))
                                Next
                                b = ToInt(s)
                            Loop While b <> Asc("/")
                        Else
                            logins(index) += Chr(b)
                        End If
                    Loop While Not EOF(1)
                    FileClose(1)

                    test = True
                    For i = 0 To UBound(logins)
                        If logins(i) = login Then test = False
                        logins(i) = 0
                    Next
                End If
                If test = True Then

                    FileOpen(1, "asdfghjkl.txt", OpenMode.Output) 'сохранение логина и пароля в txt файл всместе с другими
                    FileOpen(2, filename, OpenMode.Binary)
                    Do While Not EOF(2)
                        FileGet(2, b)
                        PrintLine(1, b)
                    Loop
                    For i = 0 To Len(str) - 1
                        s = ToBin(Asc(str(i)))
                        For k = 0 To Len(key) - 1
                            Dim ind As String = key(k)
                            s = ReplaceBit(s, Int(ind))
                        Next
                        b = ToInt(s)
                        PrintLine(1, b)
                    Next
                    FileClose(1)
                    FileClose(2)

                    FileOpen(1, "asdfghjkl.txt", OpenMode.Input) 'перезапись всех логинов и паролей в bin фийл
                    FileOpen(2, filename, OpenMode.Binary)
                    Do
                        FilePut(2, CByte(LineInput(1)))
                    Loop While Not EOF(1)
                    FileClose(1)
                    My.Computer.FileSystem.DeleteFile("asdfghjkl.txt")
                    FileClose(2)
                    Return 1
                Else
                    Return 0
                End If
            Else
                Return 2
            End If
        Else
            If IO.File.Exists(filename) Then
                FileOpen(1, filename, OpenMode.Binary)
                Do
                    FileGet(1, b)
                    s = ToBin(b)
                    For i = 0 To Len(key) - 1
                        Dim ind As String = key(i)
                        s = ReplaceBit(s, Int(ind))
                    Next
                    b = ToInt(s)
                    If b = Asc("/") Then count += 1
                Loop While Not EOF(1)
                Dim logins(count) As String
                FileClose(1)

                FileOpen(1, filename, OpenMode.Binary)
                Do
                    FileGet(1, b)
                    s = ToBin(b)
                    For i = 0 To Len(key) - 1
                        Dim ind As String = key(i)
                        s = ReplaceBit(s, Int(ind))
                    Next
                    b = ToInt(s)
                    logins(index) += Chr(b)
                    If b = Asc("/") Then
                        index += 1
                    End If
                Loop While Not EOF(1)
                FileClose(1)
                test = False
                For i = 0 To UBound(logins)
                    If logins(i) = str Then test = True
                    logins(i) = 0
                Next
                If test = True Then
                    Return 3
                Else
                    Return 4
                End If
            Else
                Return 4
            End If
        End If
    End Function

    'тестовая кнопка для проверки работоспособности
    Private Sub TestBtn_Click(sender As Object, e As EventArgs) Handles TestBtn.Click
        Dim b As Byte
        Dim s As String

        'ЭТО ПРОВЕРКА ЧТОБЫ ПОНИМАТЬ ПРАВИЛЬНО ЛИ ЗАПИСЫВАЮТСЯ ДАННЫЕ (Надо включить Visible на Button1)
        'ЕСЛИ НУЖНО СБРОСИТЬ ПАРОЛИ - ПОМЕНЯТЬ МЕСТАМИ 1 И 2 АБЗАЦ (ЗАКОММЕНТИРОВАПТЬ ОДНО ИЛИ ДРУГОЕ)

        'FileOpen(1, "code.bin", OpenMode.Output)
        'FileClose(1)
        'FileOpen(1, "code.txt", OpenMode.Output)
        'Dim str As String = "asdf#fdsa/"
        'For i = 0 To Len(str) - 1
        '    s = ToBin(Asc(str(i)))
        '    s = ReplaceBit(s, 2)
        '    s = ReplaceBit(s, 5)
        '    b = ToInt(s)
        '    PrintLine(1, b)
        'Next

        'str = "nikita#pass1/"
        'For i = 0 To Len(str) - 1
        '    s = ToBin(Asc(str(i)))
        '    s = ReplaceBit(s, 2)
        '    s = ReplaceBit(s, 5)
        '    b = ToInt(s)
        '    PrintLine(1, b)
        'Next

        'str = "Login#Pass12321/"
        'For i = 0 To Len(str) - 1
        '    s = ToBin(Asc(str(i)))
        '    s = ReplaceBit(s, 2)
        '    s = ReplaceBit(s, 5)
        '    b = ToInt(s)
        '    PrintLine(1, b)
        'Next
        'FileClose(1)

        FileOpen(1, "code.txt", OpenMode.Output) 'сохранение логинов и паролей в txt файл
        FileOpen(2, "code.bin", OpenMode.Binary)
        Do While Not EOF(2)
            FileGet(2, b)
            PrintLine(1, b)
        Loop
        FileClose(1)
        FileClose(2)

        'КОНЕЦ 2 АБЗАЦА

        Dim key As String = "25"
        FileOpen(1, "code.txt", OpenMode.Input) 'перезапись всех логинов и паролей в bin фийл
        FileOpen(2, "code.bin", OpenMode.Binary)
        Do
            b = CByte(LineInput(1))
            FilePut(2, b)
        Loop While Not EOF(1)
        FileClose(1)
        My.Computer.FileSystem.DeleteFile("code.txt")
        FileClose(2)

        FileOpen(1, "code.bin", OpenMode.Binary)
        TextLabel.Text = ""
        Do
            FileGet(1, b)
            s = ToBin(b)
            For i = 0 To Len(key) - 1
                Dim ind As String = key(i)
                s = ReplaceBit(s, Int(ind))
            Next
            b = ToInt(s)
            If b = Asc("/") Then
                TextLabel.Text += vbCrLf
            Else
                TextLabel.Text += Chr(b)
            End If
        Loop While Not EOF(1)
        FileClose(1)
    End Sub
End Class