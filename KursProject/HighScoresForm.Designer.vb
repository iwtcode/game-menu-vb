<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HighScoresForm
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
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.KeyboardScores = New System.Windows.Forms.ListBox()
        Me.MazeScores = New System.Windows.Forms.ListBox()
        Me.SnakeScores = New System.Windows.Forms.ListBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RefreshBtn.FlatAppearance.BorderSize = 0
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RefreshBtn.Location = New System.Drawing.Point(472, 12)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(112, 40)
        Me.RefreshBtn.TabIndex = 13
        Me.RefreshBtn.Text = "Обновить"
        Me.RefreshBtn.UseVisualStyleBackColor = False
        '
        'KeyboardScores
        '
        Me.KeyboardScores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.KeyboardScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.KeyboardScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.KeyboardScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.KeyboardScores.FormattingEnabled = True
        Me.KeyboardScores.ItemHeight = 16
        Me.KeyboardScores.Location = New System.Drawing.Point(398, 76)
        Me.KeyboardScores.Name = "KeyboardScores"
        Me.KeyboardScores.Size = New System.Drawing.Size(156, 224)
        Me.KeyboardScores.TabIndex = 12
        '
        'MazeScores
        '
        Me.MazeScores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MazeScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MazeScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MazeScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.MazeScores.FormattingEnabled = True
        Me.MazeScores.ItemHeight = 16
        Me.MazeScores.Location = New System.Drawing.Point(222, 76)
        Me.MazeScores.Name = "MazeScores"
        Me.MazeScores.Size = New System.Drawing.Size(156, 224)
        Me.MazeScores.TabIndex = 11
        '
        'SnakeScores
        '
        Me.SnakeScores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SnakeScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SnakeScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SnakeScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SnakeScores.FormattingEnabled = True
        Me.SnakeScores.ItemHeight = 16
        Me.SnakeScores.Location = New System.Drawing.Point(46, 76)
        Me.SnakeScores.Name = "SnakeScores"
        Me.SnakeScores.Size = New System.Drawing.Size(156, 224)
        Me.SnakeScores.TabIndex = 10
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLabel.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.ScoreLabel.Location = New System.Drawing.Point(194, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(208, 45)
        Me.ScoreLabel.TabIndex = 9
        Me.ScoreLabel.Text = "High Scores"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.KeyboardScores)
        Me.Controls.Add(Me.MazeScores)
        Me.Controls.Add(Me.SnakeScores)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Name = "HighScoresForm"
        Me.Text = "HighScoresForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RefreshBtn As Button
    Friend WithEvents KeyboardScores As ListBox
    Friend WithEvents MazeScores As ListBox
    Friend WithEvents SnakeScores As ListBox
    Friend WithEvents ScoreLabel As Label
End Class
