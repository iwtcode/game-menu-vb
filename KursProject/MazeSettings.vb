Public Class SettingsMazeForm

    'выравнивание элементов по центру
    Private Sub Launch_Tick(sender As Object, e As EventArgs) Handles Launch.Tick
        DemonstrationSizeLabel.Size = New Point(WidthLabel.Text, HeightLabel.Text)
        DemonstrationSizeLabel.Location = New Point(SettingsLabel.Width / 2 - DemonstrationSizeLabel.Width / 2, ((Me.Height - 50) + SettingsLabel.Height) / 2 - DemonstrationSizeLabel.Height / 2)

        WidthLabel.Location = New Point(DemonstrationSizeLabel.Location.X + DemonstrationSizeLabel.Width / 2 - WidthLabel.Width / 2, DemonstrationSizeLabel.Location.Y + DemonstrationSizeLabel.Height + 10)
        HeightLabel.Location = New Point(DemonstrationSizeLabel.Location.X - HeightLabel.Width - 10, DemonstrationSizeLabel.Location.Y + DemonstrationSizeLabel.Height / 2 - HeightLabel.Height / 2)

        Launch.Enabled = False
    End Sub

    'увеличение размера окна чтобы вместить элементы
    Private Sub HeightLabel_TextChanged(sender As Object, e As EventArgs) Handles HeightLabel.TextChanged
        If HeightLabel.Text > 125 Then StartForm.MinimumSize = New Point(StartForm.Width, StartForm.Height + 2)
    End Sub
End Class