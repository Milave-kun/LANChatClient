<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        lblWelcome = New Label()
        lstUsersOnline = New ListBox()
        rtbChatBox = New RichTextBox()
        txtMessage = New TextBox()
        picMyAvatar = New PictureBox()
        picSelectedAvatar = New PictureBox()
        btnChangeAvatar = New Button()
        btnLogout = New Button()
        Label5 = New Label()
        lblAddress = New Label()
        Label10 = New Label()
        lblFirstName = New Label()
        Label8 = New Label()
        lblLastName = New Label()
        LAbea = New Label()
        lblBirthday = New Label()
        Label4 = New Label()
        lblPhoneNumber = New Label()
        Label3 = New Label()
        lblStatus = New Label()
        btnMinimize = New FontAwesome.Sharp.IconButton()
        btnExit = New FontAwesome.Sharp.IconButton()
        PictureBox1 = New PictureBox()
        btnSendMessage = New FontAwesome.Sharp.IconButton()
        CType(picMyAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSelectedAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(47, 7)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(179, 21)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome, [Username]"
        ' 
        ' lstUsersOnline
        ' 
        lstUsersOnline.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        lstUsersOnline.BorderStyle = BorderStyle.FixedSingle
        lstUsersOnline.ForeColor = Color.White
        lstUsersOnline.FormattingEnabled = True
        lstUsersOnline.ItemHeight = 15
        lstUsersOnline.Location = New Point(12, 59)
        lstUsersOnline.Name = "lstUsersOnline"
        lstUsersOnline.Size = New Size(131, 377)
        lstUsersOnline.TabIndex = 1
        ' 
        ' rtbChatBox
        ' 
        rtbChatBox.BackColor = Color.White
        rtbChatBox.BorderStyle = BorderStyle.FixedSingle
        rtbChatBox.Enabled = False
        rtbChatBox.ForeColor = Color.Black
        rtbChatBox.Location = New Point(149, 164)
        rtbChatBox.Name = "rtbChatBox"
        rtbChatBox.Size = New Size(637, 229)
        rtbChatBox.TabIndex = 2
        rtbChatBox.Text = ""
        ' 
        ' txtMessage
        ' 
        txtMessage.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtMessage.BorderStyle = BorderStyle.FixedSingle
        txtMessage.ForeColor = Color.White
        txtMessage.Location = New Point(149, 399)
        txtMessage.Multiline = True
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(520, 39)
        txtMessage.TabIndex = 3
        ' 
        ' picMyAvatar
        ' 
        picMyAvatar.Location = New Point(527, 5)
        picMyAvatar.Name = "picMyAvatar"
        picMyAvatar.Size = New Size(37, 37)
        picMyAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picMyAvatar.TabIndex = 5
        picMyAvatar.TabStop = False
        ' 
        ' picSelectedAvatar
        ' 
        picSelectedAvatar.Location = New Point(149, 58)
        picSelectedAvatar.Name = "picSelectedAvatar"
        picSelectedAvatar.Size = New Size(100, 100)
        picSelectedAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picSelectedAvatar.TabIndex = 6
        picSelectedAvatar.TabStop = False
        ' 
        ' btnChangeAvatar
        ' 
        btnChangeAvatar.FlatAppearance.BorderSize = 0
        btnChangeAvatar.FlatStyle = FlatStyle.Flat
        btnChangeAvatar.ForeColor = Color.White
        btnChangeAvatar.Location = New Point(570, 14)
        btnChangeAvatar.Name = "btnChangeAvatar"
        btnChangeAvatar.Size = New Size(60, 25)
        btnChangeAvatar.TabIndex = 7
        btnChangeAvatar.Text = "Edit"
        btnChangeAvatar.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(636, 14)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(60, 25)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(255, 110)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 33
        Label5.Text = "Address :"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.ForeColor = Color.White
        lblAddress.Location = New Point(349, 110)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(0, 15)
        lblAddress.TabIndex = 32
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(255, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 15)
        Label10.TabIndex = 31
        Label10.Text = "First Name :"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.ForeColor = Color.White
        lblFirstName.Location = New Point(349, 63)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(0, 15)
        lblFirstName.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(255, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 15)
        Label8.TabIndex = 29
        Label8.Text = "Last Name :"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.ForeColor = Color.White
        lblLastName.Location = New Point(349, 78)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(0, 15)
        lblLastName.TabIndex = 28
        ' 
        ' LAbea
        ' 
        LAbea.AutoSize = True
        LAbea.ForeColor = Color.White
        LAbea.Location = New Point(255, 95)
        LAbea.Name = "LAbea"
        LAbea.Size = New Size(57, 15)
        LAbea.TabIndex = 27
        LAbea.Text = "Birthday :"
        ' 
        ' lblBirthday
        ' 
        lblBirthday.AutoSize = True
        lblBirthday.ForeColor = Color.White
        lblBirthday.Location = New Point(349, 95)
        lblBirthday.Name = "lblBirthday"
        lblBirthday.Size = New Size(0, 15)
        lblBirthday.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(255, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 25
        Label4.Text = "Phone No. :"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.ForeColor = Color.White
        lblPhoneNumber.Location = New Point(349, 125)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(0, 15)
        lblPhoneNumber.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(255, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 23
        Label3.Text = "Status :"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.ForeColor = Color.White
        lblStatus.Location = New Point(349, 140)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 15)
        lblStatus.TabIndex = 22
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
        btnMinimize.TabIndex = 35
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
        btnExit.Location = New Point(748, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 34
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.LogoKoTOoooo
        PictureBox1.Location = New Point(12, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' btnSendMessage
        ' 
        btnSendMessage.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        btnSendMessage.FlatAppearance.BorderSize = 0
        btnSendMessage.FlatStyle = FlatStyle.Flat
        btnSendMessage.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        btnSendMessage.IconColor = Color.White
        btnSendMessage.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSendMessage.IconSize = 32
        btnSendMessage.Location = New Point(675, 399)
        btnSendMessage.Name = "btnSendMessage"
        btnSendMessage.Size = New Size(111, 37)
        btnSendMessage.TabIndex = 37
        btnSendMessage.UseVisualStyleBackColor = False
        ' 
        ' frmChat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        ClientSize = New Size(800, 450)
        Controls.Add(btnSendMessage)
        Controls.Add(PictureBox1)
        Controls.Add(btnMinimize)
        Controls.Add(btnExit)
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
        Controls.Add(Label3)
        Controls.Add(lblStatus)
        Controls.Add(btnLogout)
        Controls.Add(btnChangeAvatar)
        Controls.Add(picSelectedAvatar)
        Controls.Add(picMyAvatar)
        Controls.Add(txtMessage)
        Controls.Add(rtbChatBox)
        Controls.Add(lstUsersOnline)
        Controls.Add(lblWelcome)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmChat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chat"
        CType(picMyAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(picSelectedAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lstUsersOnline As ListBox
    Friend WithEvents rtbChatBox As RichTextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents picMyAvatar As PictureBox
    Friend WithEvents picSelectedAvatar As PictureBox
    Friend WithEvents btnChangeAvatar As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents LAbea As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSendMessage As FontAwesome.Sharp.IconButton
End Class
