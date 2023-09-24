<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsMazeForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.Launch = New System.Windows.Forms.Timer(Me.components)
        Me.DemonstrationSizeLabel = New System.Windows.Forms.Button()
        Me.HeightLabel = New System.Windows.Forms.Button()
        Me.WidthLabel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SettingsLabel
        '
        Me.SettingsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsLabel.Font = New System.Drawing.Font("Calibri Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SettingsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.SettingsLabel.Location = New System.Drawing.Point(0, 0)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SettingsLabel.Size = New System.Drawing.Size(600, 50)
        Me.SettingsLabel.TabIndex = 12
        Me.SettingsLabel.Text = "Maze Settings"
        Me.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Launch
        '
        Me.Launch.Interval = 1
        '
        'DemonstrationSizeLabel
        '
        Me.DemonstrationSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DemonstrationSizeLabel.AutoSize = True
        Me.DemonstrationSizeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DemonstrationSizeLabel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DemonstrationSizeLabel.FlatAppearance.BorderSize = 0
        Me.DemonstrationSizeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DemonstrationSizeLabel.Location = New System.Drawing.Point(285, 140)
        Me.DemonstrationSizeLabel.Name = "DemonstrationSizeLabel"
        Me.DemonstrationSizeLabel.Size = New System.Drawing.Size(30, 30)
        Me.DemonstrationSizeLabel.TabIndex = 57
        Me.DemonstrationSizeLabel.UseVisualStyleBackColor = False
        '
        'HeightLabel
        '
        Me.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HeightLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HeightLabel.FlatAppearance.BorderSize = 0
        Me.HeightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.HeightLabel.Location = New System.Drawing.Point(178, 140)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(100, 30)
        Me.HeightLabel.TabIndex = 61
        Me.HeightLabel.Text = "30"
        Me.HeightLabel.UseVisualStyleBackColor = False
        '
        'WidthLabel
        '
        Me.WidthLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WidthLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.WidthLabel.FlatAppearance.BorderSize = 0
        Me.WidthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WidthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.WidthLabel.Location = New System.Drawing.Point(252, 177)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(100, 30)
        Me.WidthLabel.TabIndex = 62
        Me.WidthLabel.Text = "30"
        Me.WidthLabel.UseVisualStyleBackColor = False
        '
        'SettingsMazeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.DemonstrationSizeLabel)
        Me.Controls.Add(Me.SettingsLabel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SettingsMazeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройки лабиринта"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents Launch As Timer
    Friend WithEvents DemonstrationSizeLabel As Button
    Friend WithEvents HeightLabel As Button
    Friend WithEvents WidthLabel As Button
End Class
