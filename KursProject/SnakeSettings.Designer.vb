<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsSnakeForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowSize2 = New System.Windows.Forms.Label()
        Me.LineLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowSize1 = New System.Windows.Forms.Label()
        Me.DemonstrationSizeLabel = New System.Windows.Forms.Button()
        Me.launch = New System.Windows.Forms.Timer(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SnakePanel = New System.Windows.Forms.Panel()
        Me.SizeLabel = New System.Windows.Forms.Button()
        Me.SpeedLabel = New System.Windows.Forms.Button()
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
        Me.SettingsLabel.TabIndex = 45
        Me.SettingsLabel.Text = "Snake Settings"
        Me.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(100, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(147, 29)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Размер комнаты"
        '
        'ShowSize2
        '
        Me.ShowSize2.AutoSize = True
        Me.ShowSize2.Location = New System.Drawing.Point(135, 184)
        Me.ShowSize2.Name = "ShowSize2"
        Me.ShowSize2.Size = New System.Drawing.Size(24, 17)
        Me.ShowSize2.TabIndex = 53
        Me.ShowSize2.Text = "15"
        '
        'LineLabel
        '
        Me.LineLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LineLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LineLabel.Location = New System.Drawing.Point(300, 50)
        Me.LineLabel.Name = "LineLabel"
        Me.LineLabel.Size = New System.Drawing.Size(2, 250)
        Me.LineLabel.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(403, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(152, 29)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Скорость змейки"
        '
        'ShowSize1
        '
        Me.ShowSize1.AutoSize = True
        Me.ShowSize1.Location = New System.Drawing.Point(100, 151)
        Me.ShowSize1.Name = "ShowSize1"
        Me.ShowSize1.Size = New System.Drawing.Size(24, 17)
        Me.ShowSize1.TabIndex = 55
        Me.ShowSize1.Text = "15"
        '
        'DemonstrationSizeLabel
        '
        Me.DemonstrationSizeLabel.AutoSize = True
        Me.DemonstrationSizeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DemonstrationSizeLabel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DemonstrationSizeLabel.FlatAppearance.BorderSize = 0
        Me.DemonstrationSizeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DemonstrationSizeLabel.Location = New System.Drawing.Point(123, 135)
        Me.DemonstrationSizeLabel.Name = "DemonstrationSizeLabel"
        Me.DemonstrationSizeLabel.Size = New System.Drawing.Size(45, 45)
        Me.DemonstrationSizeLabel.TabIndex = 56
        Me.DemonstrationSizeLabel.UseVisualStyleBackColor = False
        '
        'launch
        '
        Me.launch.Interval = 1
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 150
        '
        'SnakePanel
        '
        Me.SnakePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SnakePanel.Location = New System.Drawing.Point(312, 82)
        Me.SnakePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.SnakePanel.Name = "SnakePanel"
        Me.SnakePanel.Size = New System.Drawing.Size(275, 218)
        Me.SnakePanel.TabIndex = 59
        '
        'SizeLabel
        '
        Me.SizeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SizeLabel.FlatAppearance.BorderSize = 0
        Me.SizeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SizeLabel.Location = New System.Drawing.Point(0, 50)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(100, 30)
        Me.SizeLabel.TabIndex = 60
        Me.SizeLabel.Text = "15"
        Me.SizeLabel.UseVisualStyleBackColor = False
        '
        'SpeedLabel
        '
        Me.SpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SpeedLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SpeedLabel.FlatAppearance.BorderSize = 0
        Me.SpeedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpeedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SpeedLabel.Location = New System.Drawing.Point(302, 49)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(100, 30)
        Me.SpeedLabel.TabIndex = 61
        Me.SpeedLabel.Text = "150"
        Me.SpeedLabel.UseVisualStyleBackColor = False
        '
        'SettingsSnakeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.SpeedLabel)
        Me.Controls.Add(Me.SizeLabel)
        Me.Controls.Add(Me.SnakePanel)
        Me.Controls.Add(Me.DemonstrationSizeLabel)
        Me.Controls.Add(Me.ShowSize1)
        Me.Controls.Add(Me.LineLabel)
        Me.Controls.Add(Me.ShowSize2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SettingsSnakeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SettingsLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowSize2 As Label
    Friend WithEvents LineLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowSize1 As Label
    Friend WithEvents DemonstrationSizeLabel As Button
    Friend WithEvents launch As Timer
    Friend WithEvents Timer As Timer
    Friend WithEvents SnakePanel As Panel
    Friend WithEvents SizeLabel As Button
    Friend WithEvents SpeedLabel As Button
End Class
