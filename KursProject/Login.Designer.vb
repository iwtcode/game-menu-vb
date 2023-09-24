<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.TestBtn = New System.Windows.Forms.Button()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.EnterBtn = New System.Windows.Forms.Button()
        Me.RegBtn = New System.Windows.Forms.Button()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.LoginBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.UserLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.UserLabel.Location = New System.Drawing.Point(3, 87)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(58, 20)
        Me.UserLabel.TabIndex = 15
        Me.UserLabel.Text = "Гость"
        '
        'TestBtn
        '
        Me.TestBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TestBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TestBtn.Location = New System.Drawing.Point(194, 356)
        Me.TestBtn.Name = "TestBtn"
        Me.TestBtn.Size = New System.Drawing.Size(99, 31)
        Me.TestBtn.TabIndex = 13
        Me.TestBtn.Text = "Проверка"
        Me.TestBtn.UseVisualStyleBackColor = False
        Me.TestBtn.Visible = False
        '
        'TextLabel
        '
        Me.TextLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextLabel.AutoSize = True
        Me.TextLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TextLabel.Location = New System.Drawing.Point(38, 318)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(0, 17)
        Me.TextLabel.TabIndex = 14
        '
        'EnterBtn
        '
        Me.EnterBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EnterBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnterBtn.Location = New System.Drawing.Point(170, 260)
        Me.EnterBtn.Name = "EnterBtn"
        Me.EnterBtn.Size = New System.Drawing.Size(123, 34)
        Me.EnterBtn.TabIndex = 12
        Me.EnterBtn.Text = "Вход"
        Me.EnterBtn.UseVisualStyleBackColor = False
        '
        'RegBtn
        '
        Me.RegBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RegBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegBtn.Location = New System.Drawing.Point(38, 260)
        Me.RegBtn.Name = "RegBtn"
        Me.RegBtn.Size = New System.Drawing.Size(123, 34)
        Me.RegBtn.TabIndex = 9
        Me.RegBtn.Text = "Регистрация"
        Me.RegBtn.UseVisualStyleBackColor = False
        '
        'PassBox
        '
        Me.PassBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PassBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PassBox.ForeColor = System.Drawing.Color.Gray
        Me.PassBox.Location = New System.Drawing.Point(38, 195)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(255, 22)
        Me.PassBox.TabIndex = 11
        Me.PassBox.Text = "Pass"
        Me.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginBox
        '
        Me.LoginBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LoginBox.ForeColor = System.Drawing.Color.Gray
        Me.LoginBox.Location = New System.Drawing.Point(38, 142)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(255, 22)
        Me.LoginBox.TabIndex = 10
        Me.LoginBox.Text = "Login"
        Me.LoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 78)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(100, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Авторизация"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(342, 393)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.TestBtn)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.EnterBtn)
        Me.Controls.Add(Me.RegBtn)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.LoginBox)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(360, 440)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserLabel As Label
    Friend WithEvents TestBtn As Button
    Friend WithEvents TextLabel As Label
    Friend WithEvents EnterBtn As Button
    Friend WithEvents RegBtn As Button
    Friend WithEvents PassBox As TextBox
    Friend WithEvents LoginBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
