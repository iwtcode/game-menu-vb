<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsKeyboardForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ArcadesLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Launch = New System.Windows.Forms.Timer(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PrevText = New System.Windows.Forms.Label()
        Me.NewText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LanguageLabel = New System.Windows.Forms.Button()
        Me.ValueLabel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ArcadesLabel
        '
        Me.ArcadesLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ArcadesLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArcadesLabel.Font = New System.Drawing.Font("Calibri Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ArcadesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ArcadesLabel.Location = New System.Drawing.Point(0, 0)
        Me.ArcadesLabel.Name = "ArcadesLabel"
        Me.ArcadesLabel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ArcadesLabel.Size = New System.Drawing.Size(600, 50)
        Me.ArcadesLabel.TabIndex = 1
        Me.ArcadesLabel.Text = "Keyboard Simulator Settings"
        Me.ArcadesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(155, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Раскладка клавиатуры"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(155, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Количество слов"
        '
        'Launch
        '
        Me.Launch.Interval = 1
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 500
        '
        'PrevText
        '
        Me.PrevText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrevText.BackColor = System.Drawing.Color.Silver
        Me.PrevText.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PrevText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PrevText.Location = New System.Drawing.Point(12, 175)
        Me.PrevText.Name = "PrevText"
        Me.PrevText.Size = New System.Drawing.Size(308, 30)
        Me.PrevText.TabIndex = 41
        Me.PrevText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewText
        '
        Me.NewText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NewText.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.NewText.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NewText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NewText.Location = New System.Drawing.Point(320, 175)
        Me.NewText.Name = "NewText"
        Me.NewText.Size = New System.Drawing.Size(268, 30)
        Me.NewText.TabIndex = 42
        Me.NewText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(302, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 34)
        Me.Label2.TabIndex = 43
        '
        'LanguageLabel
        '
        Me.LanguageLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LanguageLabel.FlatAppearance.BorderSize = 0
        Me.LanguageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LanguageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LanguageLabel.Location = New System.Drawing.Point(0, 55)
        Me.LanguageLabel.Name = "LanguageLabel"
        Me.LanguageLabel.Size = New System.Drawing.Size(150, 35)
        Me.LanguageLabel.TabIndex = 62
        Me.LanguageLabel.Text = "Russian"
        Me.LanguageLabel.UseVisualStyleBackColor = False
        '
        'ValueLabel
        '
        Me.ValueLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ValueLabel.FlatAppearance.BorderSize = 0
        Me.ValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ValueLabel.Location = New System.Drawing.Point(0, 96)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(150, 35)
        Me.ValueLabel.TabIndex = 63
        Me.ValueLabel.Text = "100"
        Me.ValueLabel.UseVisualStyleBackColor = False
        '
        'SettingsKeyboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.ValueLabel)
        Me.Controls.Add(Me.LanguageLabel)
        Me.Controls.Add(Me.PrevText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NewText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ArcadesLabel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SettingsKeyboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройки клавиатурного тренажёра"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ArcadesLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Launch As Timer
    Friend WithEvents Timer As Timer
    Friend WithEvents PrevText As Label
    Friend WithEvents NewText As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LanguageLabel As Button
    Friend WithEvents ValueLabel As Button
End Class
