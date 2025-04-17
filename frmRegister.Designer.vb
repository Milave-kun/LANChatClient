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
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(237, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(317, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Register Account"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(86, 99)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(267, 29)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(86, 170)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(267, 29)
        txtPassword.TabIndex = 2
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.Location = New Point(86, 314)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(267, 29)
        txtFirstName.TabIndex = 3
        ' 
        ' btnRegister
        ' 
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(521, 394)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(124, 44)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnToLogin
        ' 
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
        Label1.Location = New Point(86, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(86, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(86, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 25)
        Label3.TabIndex = 9
        Label3.Text = "First Name"
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FlatStyle = FlatStyle.Flat
        cmbRole.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"User", "Admin"})
        cmbRole.Location = New Point(86, 240)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(267, 29)
        cmbRole.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(86, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 25)
        Label4.TabIndex = 11
        Label4.Text = "Role"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(86, 354)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 25)
        Label5.TabIndex = 13
        Label5.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.Location = New Point(86, 382)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(267, 29)
        txtLastName.TabIndex = 12
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label.Location = New Point(437, 74)
        Label.Name = "Label"
        Label.Size = New Size(82, 25)
        Label.TabIndex = 15
        Label.Text = "Birthday"
        ' 
        ' txtBirthday
        ' 
        txtBirthday.BorderStyle = BorderStyle.FixedSingle
        txtBirthday.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBirthday.Location = New Point(437, 102)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(267, 29)
        txtBirthday.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(437, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 25)
        Label7.TabIndex = 17
        Label7.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(437, 170)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(267, 29)
        txtAddress.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(437, 212)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 25)
        Label8.TabIndex = 19
        Label8.Text = "Phone Number"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.Location = New Point(437, 240)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(267, 29)
        txtPhoneNumber.TabIndex = 18
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
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
        FormBorderStyle = FormBorderStyle.FixedToolWindow
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
End Class
