Public Class SettingsSnakeForm
    Dim Graph1 As Graphics
    Dim Brush1 As New SolidBrush(Color.FromArgb(30, 30, 30))
    Dim x, y As Integer

    'выравнивание элементов по центру
    Private Sub launch_Tick(sender As Object, e As EventArgs) Handles launch.Tick
        DemonstrationSizeLabel.Size = New Point(SizeLabel.Text * 3, SizeLabel.Text * 3)
        DemonstrationSizeLabel.Location = New Point(LineLabel.Location.X / 2 - DemonstrationSizeLabel.Width / 2, StartForm.FormPanel.Height / 2)
        ShowSize1.Location = New Point(DemonstrationSizeLabel.Location.X + DemonstrationSizeLabel.Width / 2 - ShowSize1.Width / 2, DemonstrationSizeLabel.Location.Y + DemonstrationSizeLabel.Height)
        ShowSize2.Location = New Point(DemonstrationSizeLabel.Location.X - ShowSize2.Width, DemonstrationSizeLabel.Location.Y + DemonstrationSizeLabel.Height / 2 - ShowSize2.Height / 2)
        SnakePanel.Location = New Point(SettingsLabel.Width - LineLabel.Location.X / 2 - SnakePanel.Width / 2, StartForm.FormPanel.Height / 2 - SnakePanel.Height / 2 + 30)
        ShowSize1.Text = SizeLabel.Text
        ShowSize2.Text = SizeLabel.Text
        y = SnakePanel.Height / 2 - 10
        Graph1 = Me.SnakePanel.CreateGraphics()
        launch.Enabled = False
    End Sub

    'демонстрация скорости змейки
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Brush1.Color = Color.FromArgb(30, 30, 30)
        Graph1.FillRectangle(Brush1, 0, 0, 300, 300)
        Brush1.Color = Color.LimeGreen
        Graph1.FillRectangle(Brush1, x, y, 20, 20)
        Brush1.Color = Color.LimeGreen
        Graph1.FillRectangle(Brush1, x + 20, y, 20, 20)
        Brush1.Color = Color.Green
        Graph1.FillRectangle(Brush1, x + 40, y, 20, 20)
        If x <= SnakePanel.Width Then x += 20 Else x = -40
    End Sub
    Private Sub SpeedLabel_TextChanged(sender As Object, e As EventArgs) Handles SpeedLabel.TextChanged
        Timer.Interval = SpeedLabel.Text
    End Sub

    'демонстрация размера комнаты
    Private Sub SizeLabel_TextChanged(sender As Object, e As EventArgs) Handles SizeLabel.TextChanged
        DemonstrationSizeLabel.Size = New Point(SizeLabel.Text * 3, SizeLabel.Text * 3)
        DemonstrationSizeLabel.Location = New Point(LineLabel.Location.X / 2 - DemonstrationSizeLabel.Width / 2, StartForm.FormPanel.Height / 2)
        ShowSize1.Location = New Point(DemonstrationSizeLabel.Location.X + DemonstrationSizeLabel.Width / 2 - ShowSize1.Width / 2, DemonstrationSizeLabel.Location.Y + DemonstrationSizeLabel.Height)
        ShowSize2.Location = New Point(DemonstrationSizeLabel.Location.X - ShowSize2.Width, DemonstrationSizeLabel.Location.Y + DemonstrationSizeLabel.Height / 2 - ShowSize2.Height / 2)
        ShowSize1.Text = SizeLabel.Text
        ShowSize2.Text = SizeLabel.Text
    End Sub
End Class