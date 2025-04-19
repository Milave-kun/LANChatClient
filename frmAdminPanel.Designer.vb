<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPanel
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
        components = New ComponentModel.Container()
        lstUsers = New ListBox()
        btnRefresh = New Button()
        lblUsername = New Label()
        lblRole = New Label()
        lblStatus = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnBlock = New Button()
        btnUnblock = New Button()
        txtLogs = New TextBox()
        Label4 = New Label()
        lblPhoneNumber = New Label()
        LAbea = New Label()
        lblBirthday = New Label()
        Label8 = New Label()
        lblLastName = New Label()
        Label10 = New Label()
        lblFirstName = New Label()
        Label5 = New Label()
        lblAddress = New Label()
        picAvatar = New PictureBox()
        timerRefreshUsers = New Timer(components)
        btnLogout = New Button()
        btnMinimize = New FontAwesome.Sharp.IconButton()
        btnExit = New FontAwesome.Sharp.IconButton()
        CType(picAvatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstUsers
        ' 
        lstUsers.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        lstUsers.BorderStyle = BorderStyle.FixedSingle
        lstUsers.ForeColor = Color.White
        lstUsers.FormattingEnabled = True
        lstUsers.ItemHeight = 15
        lstUsers.Location = New Point(12, 12)
        lstUsers.Name = "lstUsers"
        lstUsers.Size = New Size(170, 377)
        lstUsers.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Location = New Point(12, 400)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(170, 38)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 11.25F)
        lblUsername.Location = New Point(341, 57)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(0, 20)
        lblUsername.TabIndex = 2
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 11.25F)
        lblRole.Location = New Point(341, 91)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(0, 20)
        lblRole.TabIndex = 3
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 11.25F)
        lblStatus.Location = New Point(341, 307)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 20)
        lblStatus.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.Location = New Point(211, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 5
        Label1.Text = "Username :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.Location = New Point(211, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 6
        Label2.Text = "Role :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.Location = New Point(212, 307)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 7
        Label3.Text = "Status :"
        ' 
        ' btnBlock
        ' 
        btnBlock.FlatAppearance.BorderSize = 0
        btnBlock.FlatStyle = FlatStyle.Flat
        btnBlock.Location = New Point(550, 263)
        btnBlock.Name = "btnBlock"
        btnBlock.Size = New Size(93, 38)
        btnBlock.TabIndex = 8
        btnBlock.Text = "Block"
        btnBlock.UseVisualStyleBackColor = True
        ' 
        ' btnUnblock
        ' 
        btnUnblock.FlatAppearance.BorderSize = 0
        btnUnblock.FlatStyle = FlatStyle.Flat
        btnUnblock.Location = New Point(649, 263)
        btnUnblock.Name = "btnUnblock"
        btnUnblock.Size = New Size(93, 38)
        btnUnblock.TabIndex = 9
        btnUnblock.Text = "Unblock"
        btnUnblock.UseVisualStyleBackColor = True
        ' 
        ' txtLogs
        ' 
        txtLogs.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtLogs.BorderStyle = BorderStyle.FixedSingle
        txtLogs.ForeColor = Color.White
        txtLogs.Location = New Point(202, 356)
        txtLogs.Multiline = True
        txtLogs.Name = "txtLogs"
        txtLogs.Size = New Size(586, 82)
        txtLogs.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F)
        Label4.Location = New Point(212, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 13
        Label4.Text = "Phone No. :"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Font = New Font("Segoe UI", 11.25F)
        lblPhoneNumber.Location = New Point(341, 271)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(0, 20)
        lblPhoneNumber.TabIndex = 12
        ' 
        ' LAbea
        ' 
        LAbea.AutoSize = True
        LAbea.Font = New Font("Segoe UI", 11.25F)
        LAbea.Location = New Point(212, 203)
        LAbea.Name = "LAbea"
        LAbea.Size = New Size(71, 20)
        LAbea.TabIndex = 15
        LAbea.Text = "Birthday :"
        ' 
        ' lblBirthday
        ' 
        lblBirthday.AutoSize = True
        lblBirthday.Font = New Font("Segoe UI", 11.25F)
        lblBirthday.Location = New Point(341, 205)
        lblBirthday.Name = "lblBirthday"
        lblBirthday.Size = New Size(0, 20)
        lblBirthday.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F)
        Label8.Location = New Point(212, 165)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 20)
        Label8.TabIndex = 17
        Label8.Text = "Last Name :"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 11.25F)
        lblLastName.Location = New Point(341, 165)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(0, 20)
        lblLastName.TabIndex = 16
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F)
        Label10.Location = New Point(211, 125)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 20)
        Label10.TabIndex = 19
        Label10.Text = "First Name :"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 11.25F)
        lblFirstName.Location = New Point(341, 125)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(0, 20)
        lblFirstName.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F)
        Label5.Location = New Point(214, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 21
        Label5.Text = "Address :"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 11.25F)
        lblAddress.Location = New Point(341, 240)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(0, 20)
        lblAddress.TabIndex = 20
        ' 
        ' picAvatar
        ' 
        picAvatar.Location = New Point(550, 57)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(192, 192)
        picAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picAvatar.TabIndex = 22
        picAvatar.TabStop = False
        ' 
        ' timerRefreshUsers
        ' 
        timerRefreshUsers.Interval = 3000
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.Red
        btnLogout.Location = New Point(636, 14)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(60, 25)
        btnLogout.TabIndex = 23
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnMinimize
        ' 
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Subtract
        btnMinimize.IconColor = Color.White
        btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMinimize.IconSize = 38
        btnMinimize.Location = New Point(702, 13)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(40, 40)
        btnMinimize.TabIndex = 25
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.IconChar = FontAwesome.Sharp.IconChar.Close
        btnExit.IconColor = Color.White
        btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExit.IconSize = 38
        btnExit.Location = New Point(748, 13)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 24
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmAdminPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        ClientSize = New Size(800, 450)
        Controls.Add(btnMinimize)
        Controls.Add(btnExit)
        Controls.Add(btnLogout)
        Controls.Add(picAvatar)
        Controls.Add(Label5)
        Controls.Add(lblAddress)
        Controls.Add(Label10)
        Controls.Add(lblFirstName)
        Controls.Add(Label8)
        Controls.Add(lblLastName)
        Controls.Add(LAbea)
        Controls.Add(lblBirthday)
        Controls.Add(Label4)
        Controls.Add(lblPhoneNumber)
        Controls.Add(txtLogs)
        Controls.Add(btnUnblock)
        Controls.Add(btnBlock)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblStatus)
        Controls.Add(lblRole)
        Controls.Add(lblUsername)
        Controls.Add(btnRefresh)
        Controls.Add(lstUsers)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAdminPanel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Panel"
        CType(picAvatar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstUsers As ListBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBlock As Button
    Friend WithEvents btnUnblock As Button
    Friend WithEvents btnViewChat As Button
    Friend WithEvents txtLogs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents LAbea As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents timerRefreshUsers As Timer
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
End Class
