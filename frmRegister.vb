Imports System.Data.SQLite
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmRegister
    Private ReadOnly DB_PATH As String = Application.StartupPath & "\Database\chatapp.db"

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim birthday As String = txtBirthday.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim role As String = cmbRole.SelectedItem.ToString() ' Role selected from ComboBox

        If username = "" OrElse password = "" Then
            MessageBox.Show("Username and password are required.")
            Return
        End If

        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()

                ' Enable WAL mode
                Using pragmaCmd As New SQLiteCommand("PRAGMA journal_mode = WAL;", conn)
                    pragmaCmd.ExecuteNonQuery()
                End Using

                ' Check for duplicate usernames
                Dim checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username"
                Using cmdCheck As New SQLiteCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@Username", username)
                    If Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Username already exists.")
                        Return
                    End If
                End Using

                ' Optional: Hash the password for security (simple hash example, not for production)
                Dim hashedPassword As String = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password))

                ' Insert new user
                Dim insertQuery = "
                INSERT INTO Users (Username, Password, FirstName, LastName, Birthday, Address, PhoneNumber, Status, Blocked, Role) 
                VALUES (@Username, @Password, @FirstName, @LastName, @Birthday, @Address, @PhoneNumber, 'Offline', 0, @Role)"

                Using cmdInsert As New SQLiteCommand(insertQuery, conn)
                    cmdInsert.Parameters.AddWithValue("@Username", username)
                    cmdInsert.Parameters.AddWithValue("@Password", hashedPassword)
                    cmdInsert.Parameters.AddWithValue("@FirstName", firstName)
                    cmdInsert.Parameters.AddWithValue("@LastName", lastName)
                    cmdInsert.Parameters.AddWithValue("@Birthday", birthday)
                    cmdInsert.Parameters.AddWithValue("@Address", address)
                    cmdInsert.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    cmdInsert.Parameters.AddWithValue("@Role", role) ' Insert the role
                    cmdInsert.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account created! You can now log in.")
            Dim login As New frmLogin()
            login.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error during registration: " & ex.Message)
        End Try
    End Sub

    Private Sub btnToLogin_Click(sender As Object, e As EventArgs) Handles btnToLogin.Click
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub RoundButton(btn As Button, radius As Integer, borderColor As Color, borderSize As Integer)
        ' Set rounded region
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)

        ' Draw border manually
        AddHandler btn.Paint, Sub(s, e)
                                  e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                                  Using pen As New Pen(borderColor, borderSize)
                                      pen.Alignment = Drawing2D.PenAlignment.Inset
                                      e.Graphics.DrawPath(pen, path)
                                  End Using
                              End Sub
    End Sub

    Private Sub ApplyFormRadius(radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(Me.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(Me.Width - radius, Me.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, Me.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim lineColor As Color = Color.White ' You can customize this

        ' Draw underline for txtUsername
        Using pen As New Pen(lineColor, 3)
            Dim lineY1 As Integer = txtUsername.Top + txtUsername.Height
            g.DrawLine(pen, txtUsername.Left, lineY1, txtUsername.Right, lineY1)
        End Using

        ' Draw underline for txtPassword
        Using pen As New Pen(lineColor, 3)
            Dim lineY2 As Integer = txtPassword.Top + txtPassword.Height
            g.DrawLine(pen, txtPassword.Left, lineY2, txtPassword.Right, lineY2)
        End Using

        ' Draw underline for txtFirstName
        Using pen As New Pen(lineColor, 3)
            Dim lineY3 As Integer = txtFirstName.Top + txtFirstName.Height
            g.DrawLine(pen, txtFirstName.Left, lineY3, txtFirstName.Right, lineY3)
        End Using

        ' Draw underline for txtLastName
        Using pen As New Pen(lineColor, 3)
            Dim lineY4 As Integer = txtLastName.Top + txtLastName.Height
            g.DrawLine(pen, txtLastName.Left, lineY4, txtLastName.Right, lineY4)
        End Using

        ' Draw underline for txtBirthday
        Using pen As New Pen(lineColor, 3)
            Dim lineY5 As Integer = txtBirthday.Top + txtBirthday.Height
            g.DrawLine(pen, txtBirthday.Left, lineY5, txtBirthday.Right, lineY5)
        End Using

        ' Draw underline for txtAddress
        Using pen As New Pen(lineColor, 3)
            Dim lineY6 As Integer = txtAddress.Top + txtAddress.Height
            g.DrawLine(pen, txtAddress.Left, lineY6, txtAddress.Right, lineY6)
        End Using

        ' Draw underline for txtPhoneNumber
        Using pen As New Pen(lineColor, 3)
            Dim lineY7 As Integer = txtPhoneNumber.Top + txtPhoneNumber.Height
            g.DrawLine(pen, txtPhoneNumber.Left, lineY7, txtPhoneNumber.Right, lineY7)
        End Using

        ' Draw underline for cmbRole
        Using pen As New Pen(lineColor, 3)
            Dim lineY8 As Integer = cmbRole.Top + cmbRole.Height
            g.DrawLine(pen, cmbRole.Left, lineY8, cmbRole.Right, lineY8)
        End Using

    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyFormRadius(30) ' Adjust 30 to your desired corner radius
        RoundButton(btnRegister, 35, Color.White, 2)
        RoundButton(btnToLogin, 35, Color.White, 2)
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
