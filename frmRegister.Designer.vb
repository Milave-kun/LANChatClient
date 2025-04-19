<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        txtFirstName = New TextBox()
        btnRegister = New Button()
        btnToLogin = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        cmbRole = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        txtLastName = New TextBox()
        Label = New Label()
        txtBirthday = New TextBox()
        Label7 = New Label()
        txtAddress = New TextBox()
        Label8 = New Label()
        txtPhoneNumber = New TextBox()
        btnMinimize = New FontAwesome.Sharp.IconButton()
        btnExit = New FontAwesome.Sharp.IconButton()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(251, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(317, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Register Account"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(83, 187)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(267, 22)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(440, 326)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(267, 22)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtFirstName.BorderStyle = BorderStyle.None
        txtFirstName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.ForeColor = Color.White
        txtFirstName.Location = New Point(83, 116)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(267, 22)
        txtFirstName.TabIndex = 3
        ' 
        ' btnRegister
        ' 
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(331, 376)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(124, 44)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnToLogin
        ' 
        btnToLogin.FlatAppearance.BorderSize = 0
        btnToLogin.FlatStyle = FlatStyle.Flat
        btnToLogin.Location = New Point(664, 394)
        btnToLogin.Name = "btnToLogin"
        btnToLogin.Size = New Size(124, 44)
        btnToLogin.TabIndex = 5
        btnToLogin.Text = "Back to Login"
        btnToLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(83, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(440, 298)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(83, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 25)
        Label3.TabIndex = 9
        Label3.Text = "First Name"
        ' 
        ' cmbRole
        ' 
        cmbRole.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FlatStyle = FlatStyle.Flat
        cmbRole.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRole.ForeColor = Color.White
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"User", "Admin"})
        cmbRole.Location = New Point(440, 187)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(267, 29)
        cmbRole.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(440, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 25)
        Label4.TabIndex = 11
        Label4.Text = "Role"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(440, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 25)
        Label5.TabIndex = 13
        Label5.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtLastName.BorderStyle = BorderStyle.None
        txtLastName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.ForeColor = Color.White
        txtLastName.Location = New Point(440, 116)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(267, 22)
        txtLastName.TabIndex = 12
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label.Location = New Point(83, 229)
        Label.Name = "Label"
        Label.Size = New Size(82, 25)
        Label.TabIndex = 15
        Label.Text = "Birthday"
        ' 
        ' txtBirthday
        ' 
        txtBirthday.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtBirthday.BorderStyle = BorderStyle.None
        txtBirthday.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBirthday.ForeColor = Color.White
        txtBirthday.Location = New Point(83, 257)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(267, 22)
        txtBirthday.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(440, 229)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 25)
        Label7.TabIndex = 17
        Label7.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtAddress.BorderStyle = BorderStyle.None
        txtAddress.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.ForeColor = Color.White
        txtAddress.Location = New Point(440, 257)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(267, 22)
        txtAddress.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(83, 298)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 25)
        Label8.TabIndex = 19
        Label8.Text = "Phone Number"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        txtPhoneNumber.BorderStyle = BorderStyle.None
        txtPhoneNumber.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.ForeColor = Color.White
        txtPhoneNumber.Location = New Point(83, 326)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(267, 22)
        txtPhoneNumber.TabIndex = 18
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
        btnMinimize.TabIndex = 21
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
        btnExit.TabIndex = 20
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        ClientSize = New Size(800, 450)
        Controls.Add(btnMinimize)
        Controls.Add(btnExit)
        Controls.Add(Label8)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label7)
        Controls.Add(txtAddress)
        Controls.Add(Label)
        Controls.Add(txtBirthday)
        Controls.Add(Label5)
        Controls.Add(txtLastName)
        Controls.Add(Label4)
        Controls.Add(cmbRole)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnToLogin)
        Controls.Add(btnRegister)
        Controls.Add(txtFirstName)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblTitle)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnToLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
End Class
