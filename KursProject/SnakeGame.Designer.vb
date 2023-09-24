<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SnakeGame
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Launch = New System.Windows.Forms.Timer(Me.components)
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ScoreLabel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1099, 733)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Timer
        '
        Me.Timer.Interval = 150
        '
        'Launch
        '
        Me.Launch.Interval = 1
        '
        'ExitBtn
        '
        Me.ExitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Location = New System.Drawing.Point(9, 739)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ExitBtn.Size = New System.Drawing.Size(180, 40)
        Me.ExitBtn.TabIndex = 33
        Me.ExitBtn.Text = "Выход"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScoreLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ScoreLabel.FlatAppearance.BorderSize = 0
        Me.ScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScoreLabel.Location = New System.Drawing.Point(195, 739)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ScoreLabel.Size = New System.Drawing.Size(180, 40)
        Me.ScoreLabel.TabIndex = 34
        Me.ScoreLabel.Text = "Счёт: 0"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ScoreLabel.UseVisualStyleBackColor = False
        '
        'SnakeGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 802)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Name = "SnakeGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Змейка"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents Launch As Timer
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ScoreLabel As Button
End Class
