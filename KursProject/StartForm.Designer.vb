<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ApplyBtn = New System.Windows.Forms.Button()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.KeySubPanel = New System.Windows.Forms.Panel()
        Me.LettersPanel = New System.Windows.Forms.Panel()
        Me.KeyLettersBtn = New System.Windows.Forms.Button()
        Me.KeyUpLettersBtn10 = New System.Windows.Forms.Button()
        Me.KeyDownLettersBtn9 = New System.Windows.Forms.Button()
        Me.LanguagePanel = New System.Windows.Forms.Panel()
        Me.LanguageBtn = New System.Windows.Forms.Button()
        Me.KeyBtn = New System.Windows.Forms.Button()
        Me.MazeSubPanel = New System.Windows.Forms.Panel()
        Me.HeightPanel = New System.Windows.Forms.Panel()
        Me.MazeHeightBtn = New System.Windows.Forms.Button()
        Me.MazeUpHeightBtn8 = New System.Windows.Forms.Button()
        Me.MazeDownHeightBtn7 = New System.Windows.Forms.Button()
        Me.WidthPanel = New System.Windows.Forms.Panel()
        Me.MazeWidthBtn = New System.Windows.Forms.Button()
        Me.MazeUpWidthBtn6 = New System.Windows.Forms.Button()
        Me.MazeDownWidthBtn5 = New System.Windows.Forms.Button()
        Me.MazeBtn = New System.Windows.Forms.Button()
        Me.SnakeSubPanel = New System.Windows.Forms.Panel()
        Me.SpeedPanel = New System.Windows.Forms.Panel()
        Me.SnakeSpeedBtn = New System.Windows.Forms.Button()
        Me.SnakeUpSpeedBtn4 = New System.Windows.Forms.Button()
        Me.SnakeDownSpeedBtn3 = New System.Windows.Forms.Button()
        Me.SnakeSizePanel = New System.Windows.Forms.Panel()
        Me.SnakeSizeBtn = New System.Windows.Forms.Button()
        Me.SnakeUpSizeBtn2 = New System.Windows.Forms.Button()
        Me.SnakeDownSizeBtn1 = New System.Windows.Forms.Button()
        Me.SnakeBtn = New System.Windows.Forms.Button()
        Me.ArcadesPanel = New System.Windows.Forms.Panel()
        Me.ArcadesBtn = New System.Windows.Forms.Button()
        Me.FormPanel = New System.Windows.Forms.Panel()
        Me.ArcadesTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BtnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.KeySubPanel.SuspendLayout()
        Me.LettersPanel.SuspendLayout()
        Me.LanguagePanel.SuspendLayout()
        Me.MazeSubPanel.SuspendLayout()
        Me.HeightPanel.SuspendLayout()
        Me.WidthPanel.SuspendLayout()
        Me.SnakeSubPanel.SuspendLayout()
        Me.SpeedPanel.SuspendLayout()
        Me.SnakeSizePanel.SuspendLayout()
        Me.ArcadesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LoginBtn)
        Me.Panel1.Controls.Add(Me.ExitBtn)
        Me.Panel1.Controls.Add(Me.ApplyBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(200, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 80)
        Me.Panel1.TabIndex = 4
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Location = New System.Drawing.Point(6, 17)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(149, 40)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "Авторизация"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Location = New System.Drawing.Point(414, 17)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ExitBtn.Size = New System.Drawing.Size(180, 40)
        Me.ExitBtn.TabIndex = 7
        Me.ExitBtn.Text = "Выход"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'ApplyBtn
        '
        Me.ApplyBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplyBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ApplyBtn.FlatAppearance.BorderSize = 0
        Me.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ApplyBtn.Location = New System.Drawing.Point(228, 17)
        Me.ApplyBtn.Name = "ApplyBtn"
        Me.ApplyBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ApplyBtn.Size = New System.Drawing.Size(180, 40)
        Me.ApplyBtn.TabIndex = 6
        Me.ApplyBtn.Text = "Применить"
        Me.ApplyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ApplyBtn.UseVisualStyleBackColor = False
        '
        'MenuPanel
        '
        Me.MenuPanel.AutoScroll = True
        Me.MenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.KeySubPanel)
        Me.MenuPanel.Controls.Add(Me.KeyBtn)
        Me.MenuPanel.Controls.Add(Me.MazeSubPanel)
        Me.MenuPanel.Controls.Add(Me.MazeBtn)
        Me.MenuPanel.Controls.Add(Me.SnakeSubPanel)
        Me.MenuPanel.Controls.Add(Me.SnakeBtn)
        Me.MenuPanel.Controls.Add(Me.ArcadesPanel)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(200, 380)
        Me.MenuPanel.TabIndex = 3
        '
        'KeySubPanel
        '
        Me.KeySubPanel.Controls.Add(Me.LettersPanel)
        Me.KeySubPanel.Controls.Add(Me.LanguagePanel)
        Me.KeySubPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.KeySubPanel.Location = New System.Drawing.Point(0, 370)
        Me.KeySubPanel.Name = "KeySubPanel"
        Me.KeySubPanel.Size = New System.Drawing.Size(179, 80)
        Me.KeySubPanel.TabIndex = 10
        Me.KeySubPanel.Visible = False
        '
        'LettersPanel
        '
        Me.LettersPanel.Controls.Add(Me.KeyLettersBtn)
        Me.LettersPanel.Controls.Add(Me.KeyUpLettersBtn10)
        Me.LettersPanel.Controls.Add(Me.KeyDownLettersBtn9)
        Me.LettersPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LettersPanel.Location = New System.Drawing.Point(0, 40)
        Me.LettersPanel.Name = "LettersPanel"
        Me.LettersPanel.Size = New System.Drawing.Size(179, 40)
        Me.LettersPanel.TabIndex = 6
        '
        'KeyLettersBtn
        '
        Me.KeyLettersBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.KeyLettersBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KeyLettersBtn.FlatAppearance.BorderSize = 0
        Me.KeyLettersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyLettersBtn.Location = New System.Drawing.Point(40, 0)
        Me.KeyLettersBtn.Name = "KeyLettersBtn"
        Me.KeyLettersBtn.Size = New System.Drawing.Size(99, 40)
        Me.KeyLettersBtn.TabIndex = 3
        Me.KeyLettersBtn.Text = "Letters"
        Me.KeyLettersBtn.UseVisualStyleBackColor = False
        '
        'KeyUpLettersBtn10
        '
        Me.KeyUpLettersBtn10.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.KeyUpLettersBtn10.Dock = System.Windows.Forms.DockStyle.Right
        Me.KeyUpLettersBtn10.FlatAppearance.BorderSize = 0
        Me.KeyUpLettersBtn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyUpLettersBtn10.Location = New System.Drawing.Point(139, 0)
        Me.KeyUpLettersBtn10.Name = "KeyUpLettersBtn10"
        Me.KeyUpLettersBtn10.Size = New System.Drawing.Size(40, 40)
        Me.KeyUpLettersBtn10.TabIndex = 5
        Me.KeyUpLettersBtn10.Text = ">"
        Me.KeyUpLettersBtn10.UseVisualStyleBackColor = False
        '
        'KeyDownLettersBtn9
        '
        Me.KeyDownLettersBtn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.KeyDownLettersBtn9.Dock = System.Windows.Forms.DockStyle.Left
        Me.KeyDownLettersBtn9.FlatAppearance.BorderSize = 0
        Me.KeyDownLettersBtn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyDownLettersBtn9.Location = New System.Drawing.Point(0, 0)
        Me.KeyDownLettersBtn9.Name = "KeyDownLettersBtn9"
        Me.KeyDownLettersBtn9.Size = New System.Drawing.Size(40, 40)
        Me.KeyDownLettersBtn9.TabIndex = 4
        Me.KeyDownLettersBtn9.Text = "<"
        Me.KeyDownLettersBtn9.UseVisualStyleBackColor = False
        '
        'LanguagePanel
        '
        Me.LanguagePanel.Controls.Add(Me.LanguageBtn)
        Me.LanguagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LanguagePanel.Location = New System.Drawing.Point(0, 0)
        Me.LanguagePanel.Name = "LanguagePanel"
        Me.LanguagePanel.Size = New System.Drawing.Size(179, 40)
        Me.LanguagePanel.TabIndex = 0
        '
        'LanguageBtn
        '
        Me.LanguageBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LanguageBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LanguageBtn.FlatAppearance.BorderSize = 0
        Me.LanguageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LanguageBtn.Location = New System.Drawing.Point(0, 0)
        Me.LanguageBtn.Name = "LanguageBtn"
        Me.LanguageBtn.Size = New System.Drawing.Size(179, 40)
        Me.LanguageBtn.TabIndex = 3
        Me.LanguageBtn.Text = "Russian"
        Me.LanguageBtn.UseVisualStyleBackColor = False
        '
        'KeyBtn
        '
        Me.KeyBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.KeyBtn.FlatAppearance.BorderSize = 0
        Me.KeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyBtn.Image = CType(resources.GetObject("KeyBtn.Image"), System.Drawing.Image)
        Me.KeyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KeyBtn.Location = New System.Drawing.Point(0, 330)
        Me.KeyBtn.Name = "KeyBtn"
        Me.KeyBtn.Size = New System.Drawing.Size(179, 40)
        Me.KeyBtn.TabIndex = 9
        Me.KeyBtn.Text = "        KeyBoard"
        Me.KeyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KeyBtn.UseVisualStyleBackColor = True
        '
        'MazeSubPanel
        '
        Me.MazeSubPanel.Controls.Add(Me.HeightPanel)
        Me.MazeSubPanel.Controls.Add(Me.WidthPanel)
        Me.MazeSubPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MazeSubPanel.Location = New System.Drawing.Point(0, 250)
        Me.MazeSubPanel.Name = "MazeSubPanel"
        Me.MazeSubPanel.Size = New System.Drawing.Size(179, 80)
        Me.MazeSubPanel.TabIndex = 8
        Me.MazeSubPanel.Visible = False
        '
        'HeightPanel
        '
        Me.HeightPanel.Controls.Add(Me.MazeHeightBtn)
        Me.HeightPanel.Controls.Add(Me.MazeUpHeightBtn8)
        Me.HeightPanel.Controls.Add(Me.MazeDownHeightBtn7)
        Me.HeightPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeightPanel.Location = New System.Drawing.Point(0, 40)
        Me.HeightPanel.Name = "HeightPanel"
        Me.HeightPanel.Size = New System.Drawing.Size(179, 40)
        Me.HeightPanel.TabIndex = 6
        '
        'MazeHeightBtn
        '
        Me.MazeHeightBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MazeHeightBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MazeHeightBtn.FlatAppearance.BorderSize = 0
        Me.MazeHeightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeHeightBtn.Location = New System.Drawing.Point(40, 0)
        Me.MazeHeightBtn.Name = "MazeHeightBtn"
        Me.MazeHeightBtn.Size = New System.Drawing.Size(99, 40)
        Me.MazeHeightBtn.TabIndex = 3
        Me.MazeHeightBtn.Text = "Height"
        Me.MazeHeightBtn.UseVisualStyleBackColor = False
        '
        'MazeUpHeightBtn8
        '
        Me.MazeUpHeightBtn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MazeUpHeightBtn8.Dock = System.Windows.Forms.DockStyle.Right
        Me.MazeUpHeightBtn8.FlatAppearance.BorderSize = 0
        Me.MazeUpHeightBtn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeUpHeightBtn8.Location = New System.Drawing.Point(139, 0)
        Me.MazeUpHeightBtn8.Name = "MazeUpHeightBtn8"
        Me.MazeUpHeightBtn8.Size = New System.Drawing.Size(40, 40)
        Me.MazeUpHeightBtn8.TabIndex = 5
        Me.MazeUpHeightBtn8.Text = ">"
        Me.MazeUpHeightBtn8.UseVisualStyleBackColor = False
        '
        'MazeDownHeightBtn7
        '
        Me.MazeDownHeightBtn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MazeDownHeightBtn7.Dock = System.Windows.Forms.DockStyle.Left
        Me.MazeDownHeightBtn7.FlatAppearance.BorderSize = 0
        Me.MazeDownHeightBtn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeDownHeightBtn7.Location = New System.Drawing.Point(0, 0)
        Me.MazeDownHeightBtn7.Name = "MazeDownHeightBtn7"
        Me.MazeDownHeightBtn7.Size = New System.Drawing.Size(40, 40)
        Me.MazeDownHeightBtn7.TabIndex = 4
        Me.MazeDownHeightBtn7.Text = "<"
        Me.MazeDownHeightBtn7.UseVisualStyleBackColor = False
        '
        'WidthPanel
        '
        Me.WidthPanel.Controls.Add(Me.MazeWidthBtn)
        Me.WidthPanel.Controls.Add(Me.MazeUpWidthBtn6)
        Me.WidthPanel.Controls.Add(Me.MazeDownWidthBtn5)
        Me.WidthPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.WidthPanel.Location = New System.Drawing.Point(0, 0)
        Me.WidthPanel.Name = "WidthPanel"
        Me.WidthPanel.Size = New System.Drawing.Size(179, 40)
        Me.WidthPanel.TabIndex = 0
        '
        'MazeWidthBtn
        '
        Me.MazeWidthBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MazeWidthBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MazeWidthBtn.FlatAppearance.BorderSize = 0
        Me.MazeWidthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeWidthBtn.Location = New System.Drawing.Point(40, 0)
        Me.MazeWidthBtn.Name = "MazeWidthBtn"
        Me.MazeWidthBtn.Size = New System.Drawing.Size(99, 40)
        Me.MazeWidthBtn.TabIndex = 3
        Me.MazeWidthBtn.Text = "Width"
        Me.MazeWidthBtn.UseVisualStyleBackColor = False
        '
        'MazeUpWidthBtn6
        '
        Me.MazeUpWidthBtn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MazeUpWidthBtn6.Dock = System.Windows.Forms.DockStyle.Right
        Me.MazeUpWidthBtn6.FlatAppearance.BorderSize = 0
        Me.MazeUpWidthBtn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeUpWidthBtn6.Location = New System.Drawing.Point(139, 0)
        Me.MazeUpWidthBtn6.Name = "MazeUpWidthBtn6"
        Me.MazeUpWidthBtn6.Size = New System.Drawing.Size(40, 40)
        Me.MazeUpWidthBtn6.TabIndex = 5
        Me.MazeUpWidthBtn6.Text = ">"
        Me.MazeUpWidthBtn6.UseVisualStyleBackColor = False
        '
        'MazeDownWidthBtn5
        '
        Me.MazeDownWidthBtn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MazeDownWidthBtn5.Dock = System.Windows.Forms.DockStyle.Left
        Me.MazeDownWidthBtn5.FlatAppearance.BorderSize = 0
        Me.MazeDownWidthBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeDownWidthBtn5.Location = New System.Drawing.Point(0, 0)
        Me.MazeDownWidthBtn5.Name = "MazeDownWidthBtn5"
        Me.MazeDownWidthBtn5.Size = New System.Drawing.Size(40, 40)
        Me.MazeDownWidthBtn5.TabIndex = 4
        Me.MazeDownWidthBtn5.Text = "<"
        Me.MazeDownWidthBtn5.UseVisualStyleBackColor = False
        '
        'MazeBtn
        '
        Me.MazeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MazeBtn.FlatAppearance.BorderSize = 0
        Me.MazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeBtn.Image = CType(resources.GetObject("MazeBtn.Image"), System.Drawing.Image)
        Me.MazeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MazeBtn.Location = New System.Drawing.Point(0, 210)
        Me.MazeBtn.Name = "MazeBtn"
        Me.MazeBtn.Size = New System.Drawing.Size(179, 40)
        Me.MazeBtn.TabIndex = 7
        Me.MazeBtn.Text = "        Maze"
        Me.MazeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MazeBtn.UseVisualStyleBackColor = True
        '
        'SnakeSubPanel
        '
        Me.SnakeSubPanel.Controls.Add(Me.SpeedPanel)
        Me.SnakeSubPanel.Controls.Add(Me.SnakeSizePanel)
        Me.SnakeSubPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SnakeSubPanel.Location = New System.Drawing.Point(0, 130)
        Me.SnakeSubPanel.Name = "SnakeSubPanel"
        Me.SnakeSubPanel.Size = New System.Drawing.Size(179, 80)
        Me.SnakeSubPanel.TabIndex = 2
        Me.SnakeSubPanel.Visible = False
        '
        'SpeedPanel
        '
        Me.SpeedPanel.Controls.Add(Me.SnakeSpeedBtn)
        Me.SpeedPanel.Controls.Add(Me.SnakeUpSpeedBtn4)
        Me.SpeedPanel.Controls.Add(Me.SnakeDownSpeedBtn3)
        Me.SpeedPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpeedPanel.Location = New System.Drawing.Point(0, 40)
        Me.SpeedPanel.Name = "SpeedPanel"
        Me.SpeedPanel.Size = New System.Drawing.Size(179, 40)
        Me.SpeedPanel.TabIndex = 6
        '
        'SnakeSpeedBtn
        '
        Me.SnakeSpeedBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SnakeSpeedBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SnakeSpeedBtn.FlatAppearance.BorderSize = 0
        Me.SnakeSpeedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SnakeSpeedBtn.Location = New System.Drawing.Point(40, 0)
        Me.SnakeSpeedBtn.Name = "SnakeSpeedBtn"
        Me.SnakeSpeedBtn.Size = New System.Drawing.Size(99, 40)
        Me.SnakeSpeedBtn.TabIndex = 3
        Me.SnakeSpeedBtn.Text = "Speed"
        Me.SnakeSpeedBtn.UseVisualStyleBackColor = False
        '
        'SnakeUpSpeedBtn4
        '
        Me.SnakeUpSpeedBtn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SnakeUpSpeedBtn4.Dock = System.Windows.Forms.DockStyle.Right
        Me.SnakeUpSpeedBtn4.FlatAppearance.BorderSize = 0
        Me.SnakeUpSpeedBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SnakeUpSpeedBtn4.Location = New System.Drawing.Point(139, 0)
        Me.SnakeUpSpeedBtn4.Name = "SnakeUpSpeedBtn4"
        Me.SnakeUpSpeedBtn4.Size = New System.Drawing.Size(40, 40)
        Me.SnakeUpSpeedBtn4.TabIndex = 5
        Me.SnakeUpSpeedBtn4.Text = ">"
        Me.SnakeUpSpeedBtn4.UseVisualStyleBackColor = False
        '
        'SnakeDownSpeedBtn3
        '
        Me.SnakeDownSpeedBtn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SnakeDownSpeedBtn3.Dock = System.Windows.Forms.DockStyle.Left
        Me.SnakeDownSpeedBtn3.FlatAppearance.BorderSize = 0
        Me.SnakeDownSpeedBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SnakeDownSpeedBtn3.Location = New System.Drawing.Point(0, 0)
        Me.SnakeDownSpeedBtn3.Name = "SnakeDownSpeedBtn3"
        Me.SnakeDownSpeedBtn3.Size = New System.Drawing.Size(40, 40)
        Me.SnakeDownSpeedBtn3.TabIndex = 4
        Me.SnakeDownSpeedBtn3.Text = "<"
        Me.SnakeDownSpeedBtn3.UseVisualStyleBackColor = False
        '
        'SnakeSizePanel
        '
        Me.SnakeSizePanel.Controls.Add(Me.SnakeSizeBtn)
        Me.SnakeSizePanel.Controls.Add(Me.SnakeUpSizeBtn2)
        Me.SnakeSizePanel.Controls.Add(Me.SnakeDownSizeBtn1)
        Me.SnakeSizePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SnakeSizePanel.Location = New System.Drawing.Point(0, 0)
        Me.SnakeSizePanel.Name = "SnakeSizePanel"
        Me.SnakeSizePanel.Size = New System.Drawing.Size(179, 40)
        Me.SnakeSizePanel.TabIndex = 0
        '
        'SnakeSizeBtn
        '
        Me.SnakeSizeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SnakeSizeBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SnakeSizeBtn.FlatAppearance.BorderSize = 0
        Me.SnakeSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SnakeSizeBtn.Location = New System.Drawing.Point(40, 0)
        Me.SnakeSizeBtn.Name = "SnakeSizeBtn"
        Me.SnakeSizeBtn.Size = New System.Drawing.Size(99, 40)
        Me.SnakeSizeBtn.TabIndex = 3
        Me.SnakeSizeBtn.Text = "Size"
        Me.SnakeSizeBtn.UseVisualStyleBackColor = False
        '
        'SnakeUpSizeBtn2
        '
        Me.SnakeUpSizeBtn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SnakeUpSizeBtn2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SnakeUpSizeBtn2.FlatAppearance.BorderSize = 0
        Me.SnakeUpSizeBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SnakeUpSizeBtn2.Location = New System.Drawing.Point(139, 0)
        Me.SnakeUpSizeBtn2.Name = "SnakeUpSizeBtn2"
        Me.SnakeUpSizeBtn2.Size = New System.Drawing.Size(40, 40)
        Me.SnakeUpSizeBtn2.TabIndex = 5
        Me.SnakeUpSizeBtn2.Text = ">"
        Me.SnakeUpSizeBtn2.UseVisualStyleBackColor = False
        '
        'SnakeDownSizeBtn1
        '
        Me.SnakeDownSizeBtn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SnakeDownSizeBtn1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SnakeDownSizeBtn1.FlatAppearance.BorderSize = 0
        Me.SnakeDownSizeBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SnakeDownSizeBtn1.Location = New System.Drawing.Point(0, 0)
        Me.SnakeDownSizeBtn1.Name = "SnakeDownSizeBtn1"
        Me.SnakeDownSizeBtn1.Size = New System.Drawing.Size(40, 40)
        Me.SnakeDownSizeBtn1.TabIndex = 4
        Me.SnakeDownSizeBtn1.Text = "<"
        Me.SnakeDownSizeBtn1.UseVisualStyleBackColor = False
        '
        'SnakeBtn
        '
        Me.SnakeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SnakeBtn.FlatAppearance.BorderSize = 0
        Me.SnakeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SnakeBtn.Image = CType(resources.GetObject("SnakeBtn.Image"), System.Drawing.Image)
        Me.SnakeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SnakeBtn.Location = New System.Drawing.Point(0, 90)
        Me.SnakeBtn.Name = "SnakeBtn"
        Me.SnakeBtn.Size = New System.Drawing.Size(179, 40)
        Me.SnakeBtn.TabIndex = 1
        Me.SnakeBtn.Text = "        Snake"
        Me.SnakeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SnakeBtn.UseVisualStyleBackColor = True
        '
        'ArcadesPanel
        '
        Me.ArcadesPanel.Controls.Add(Me.ArcadesBtn)
        Me.ArcadesPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArcadesPanel.Location = New System.Drawing.Point(0, 0)
        Me.ArcadesPanel.Name = "ArcadesPanel"
        Me.ArcadesPanel.Size = New System.Drawing.Size(179, 90)
        Me.ArcadesPanel.TabIndex = 0
        '
        'ArcadesBtn
        '
        Me.ArcadesBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArcadesBtn.FlatAppearance.BorderSize = 0
        Me.ArcadesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArcadesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ArcadesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ArcadesBtn.Location = New System.Drawing.Point(0, 0)
        Me.ArcadesBtn.Name = "ArcadesBtn"
        Me.ArcadesBtn.Size = New System.Drawing.Size(179, 90)
        Me.ArcadesBtn.TabIndex = 11
        Me.ArcadesBtn.Text = "Arcades"
        Me.ArcadesBtn.UseVisualStyleBackColor = True
        '
        'FormPanel
        '
        Me.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormPanel.Location = New System.Drawing.Point(200, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(600, 300)
        Me.FormPanel.TabIndex = 5
        '
        'ArcadesTimer
        '
        Me.ArcadesTimer.Enabled = True
        Me.ArcadesTimer.Interval = 20
        '
        'BtnTimer
        '
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 380)
        Me.Controls.Add(Me.FormPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuPanel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(818, 427)
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Игрульки"
        Me.Panel1.ResumeLayout(False)
        Me.MenuPanel.ResumeLayout(False)
        Me.KeySubPanel.ResumeLayout(False)
        Me.LettersPanel.ResumeLayout(False)
        Me.LanguagePanel.ResumeLayout(False)
        Me.MazeSubPanel.ResumeLayout(False)
        Me.HeightPanel.ResumeLayout(False)
        Me.WidthPanel.ResumeLayout(False)
        Me.SnakeSubPanel.ResumeLayout(False)
        Me.SpeedPanel.ResumeLayout(False)
        Me.SnakeSizePanel.ResumeLayout(False)
        Me.ArcadesPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents KeySubPanel As Panel
    Friend WithEvents LettersPanel As Panel
    Friend WithEvents KeyLettersBtn As Button
    Friend WithEvents KeyUpLettersBtn10 As Button
    Friend WithEvents KeyDownLettersBtn9 As Button
    Friend WithEvents LanguagePanel As Panel
    Friend WithEvents LanguageBtn As Button
    Friend WithEvents KeyBtn As Button
    Friend WithEvents MazeSubPanel As Panel
    Friend WithEvents HeightPanel As Panel
    Friend WithEvents MazeHeightBtn As Button
    Friend WithEvents MazeUpHeightBtn8 As Button
    Friend WithEvents MazeDownHeightBtn7 As Button
    Friend WithEvents WidthPanel As Panel
    Friend WithEvents MazeWidthBtn As Button
    Friend WithEvents MazeUpWidthBtn6 As Button
    Friend WithEvents MazeDownWidthBtn5 As Button
    Friend WithEvents MazeBtn As Button
    Friend WithEvents SnakeSubPanel As Panel
    Friend WithEvents SpeedPanel As Panel
    Friend WithEvents SnakeSpeedBtn As Button
    Friend WithEvents SnakeUpSpeedBtn4 As Button
    Friend WithEvents SnakeDownSpeedBtn3 As Button
    Friend WithEvents SnakeSizePanel As Panel
    Friend WithEvents SnakeSizeBtn As Button
    Friend WithEvents SnakeUpSizeBtn2 As Button
    Friend WithEvents SnakeDownSizeBtn1 As Button
    Friend WithEvents SnakeBtn As Button
    Friend WithEvents ArcadesPanel As Panel
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ApplyBtn As Button
    Friend WithEvents FormPanel As Panel
    Friend WithEvents ArcadesBtn As Button
    Friend WithEvents ArcadesTimer As Timer
    Friend WithEvents BtnTimer As Timer
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Panel1 As Panel
End Class
