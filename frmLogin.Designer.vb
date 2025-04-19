<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitle = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnToRegister = New Button()
        btnAdminLogin = New Button()
        PictureBox1 = New PictureBox()
        btnExit = New FontAwesome.Sharp.IconButton()
        btnMinimize = New FontAwesome.Sharp.IconButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(439, 78)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(208, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "User Login"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(422, 176)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(290, 22)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(422, 246)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(290, 22)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(422, 309)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(290, 38)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnToRegister
        ' 
        btnToRegister.FlatAppearance.BorderSize = 0
        btnToRegister.FlatStyle = FlatStyle.Flat
        btnToRegister.Location = New Point(12, 405)
        btnToRegister.Name = "btnToRegister"
        btnToRegister.Size = New Size(119, 33)
        btnToRegister.TabIndex = 4
        btnToRegister.Text = "Register Account"
        btnToRegister.UseVisualStyleBackColor = True
        ' 
        ' btnAdminLogin
        ' 
        btnAdminLogin.FlatAppearance.BorderSize = 0
        btnAdminLogin.FlatStyle = FlatStyle.Flat
        btnAdminLogin.Location = New Point(669, 405)
        btnAdminLogin.Name = "btnAdminLogin"
        btnAdminLogin.Size = New Size(119, 33)
        btnAdminLogin.TabIndex = 8
        btnAdminLogin.Text = "Admin Login"
        btnAdminLogin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.LogoKoTOoooo
        PictureBox1.Location = New Point(59, 89)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(266, 247)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.IconChar = FontAwesome.Sharp.IconChar.Close
        btnExit.IconColor = Color.White
        btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExit.IconSize = 38
        btnExit.Location = New Point(748, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 10
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnMinimize
        ' 
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Subtract
        btnMinimize.IconColor = Color.White
        btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMinimize.IconSize = 38
        btnMinimize.Location = New Point(702, 12)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(40, 40)
        btnMinimize.TabIndex = 11
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        ClientSize = New Size(800, 450)
        Controls.Add(btnMinimize)
        Controls.Add(btnExit)
        Controls.Add(PictureBox1)
        Controls.Add(btnAdminLogin)
        Controls.Add(btnToRegister)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblTitle)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnToRegister As Button
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
End Class
