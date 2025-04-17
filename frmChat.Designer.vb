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
        btnSend = New Button()
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
        CType(picMyAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSelectedAvatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(503, 9)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(179, 21)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome, [Username]"
        ' 
        ' lstUsersOnline
        ' 
        lstUsersOnline.BackColor = Color.Black
        lstUsersOnline.BorderStyle = BorderStyle.FixedSingle
        lstUsersOnline.ForeColor = Color.White
        lstUsersOnline.FormattingEnabled = True
        lstUsersOnline.ItemHeight = 15
        lstUsersOnline.Location = New Point(12, 14)
        lstUsersOnline.Name = "lstUsersOnline"
        lstUsersOnline.Size = New Size(120, 422)
        lstUsersOnline.TabIndex = 1
        ' 
        ' rtbChatBox
        ' 
        rtbChatBox.BackColor = Color.Black
        rtbChatBox.BorderStyle = BorderStyle.FixedSingle
        rtbChatBox.ForeColor = Color.White
        rtbChatBox.Location = New Point(136, 148)
        rtbChatBox.Name = "rtbChatBox"
        rtbChatBox.Size = New Size(650, 255)
        rtbChatBox.TabIndex = 2
        rtbChatBox.Text = ""
        ' 
        ' txtMessage
        ' 
        txtMessage.BackColor = Color.Black
        txtMessage.BorderStyle = BorderStyle.FixedSingle
        txtMessage.ForeColor = Color.White
        txtMessage.Location = New Point(138, 407)
        txtMessage.Multiline = True
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(517, 31)
        txtMessage.TabIndex = 3
        ' 
        ' btnSend
        ' 
        btnSend.FlatStyle = FlatStyle.Flat
        btnSend.ForeColor = Color.White
        btnSend.Location = New Point(661, 407)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(127, 31)
        btnSend.TabIndex = 4
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' picMyAvatar
        ' 
        picMyAvatar.Location = New Point(688, 9)
        picMyAvatar.Name = "picMyAvatar"
        picMyAvatar.Size = New Size(100, 100)
        picMyAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picMyAvatar.TabIndex = 5
        picMyAvatar.TabStop = False
        ' 
        ' picSelectedAvatar
        ' 
        picSelectedAvatar.Location = New Point(140, 18)
        picSelectedAvatar.Name = "picSelectedAvatar"
        picSelectedAvatar.Size = New Size(120, 120)
        picSelectedAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picSelectedAvatar.TabIndex = 6
        picSelectedAvatar.TabStop = False
        ' 
        ' btnChangeAvatar
        ' 
        btnChangeAvatar.FlatStyle = FlatStyle.Flat
        btnChangeAvatar.ForeColor = Color.White
        btnChangeAvatar.Location = New Point(688, 115)
        btnChangeAvatar.Name = "btnChangeAvatar"
        btnChangeAvatar.Size = New Size(100, 23)
        btnChangeAvatar.TabIndex = 7
        btnChangeAvatar.Text = "Change Avatar"
        btnChangeAvatar.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(538, 40)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(100, 36)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(266, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 33
        Label5.Text = "Address :"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.ForeColor = Color.White
        lblAddress.Location = New Point(371, 76)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(0, 15)
        lblAddress.TabIndex = 32
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(266, 29)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 15)
        Label10.TabIndex = 31
        Label10.Text = "First Name :"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.ForeColor = Color.White
        lblFirstName.Location = New Point(371, 29)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(0, 15)
        lblFirstName.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(266, 44)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 15)
        Label8.TabIndex = 29
        Label8.Text = "Last Name :"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.ForeColor = Color.White
        lblLastName.Location = New Point(371, 44)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(0, 15)
        lblLastName.TabIndex = 28
        ' 
        ' LAbea
        ' 
        LAbea.AutoSize = True
        LAbea.ForeColor = Color.White
        LAbea.Location = New Point(266, 61)
        LAbea.Name = "LAbea"
        LAbea.Size = New Size(57, 15)
        LAbea.TabIndex = 27
        LAbea.Text = "Birthday :"
        ' 
        ' lblBirthday
        ' 
        lblBirthday.AutoSize = True
        lblBirthday.ForeColor = Color.White
        lblBirthday.Location = New Point(371, 61)
        lblBirthday.Name = "lblBirthday"
        lblBirthday.Size = New Size(0, 15)
        lblBirthday.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(266, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 15)
        Label4.TabIndex = 25
        Label4.Text = "Phone Number :"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.ForeColor = Color.White
        lblPhoneNumber.Location = New Point(371, 91)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(0, 15)
        lblPhoneNumber.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(266, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 23
        Label3.Text = "Status :"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.ForeColor = Color.White
        lblStatus.Location = New Point(371, 106)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 15)
        lblStatus.TabIndex = 22
        ' 
        ' frmChat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuText
        ClientSize = New Size(800, 450)
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
        Controls.Add(btnSend)
        Controls.Add(txtMessage)
        Controls.Add(rtbChatBox)
        Controls.Add(lstUsersOnline)
        Controls.Add(lblWelcome)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        Name = "frmChat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chat"
        CType(picMyAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(picSelectedAvatar, ComponentModel.ISupportInitialize).EndInit()
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
End Class
