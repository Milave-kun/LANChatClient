Imports System.Data.SQLite
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmLogin
    ' User Login Handling (frmLogin)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter username and password.")
            Return
        End If

        Dim hashedPassword As String = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password))

        Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
            conn.Open()
            Dim query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password AND Blocked = 0 AND Role = 'User'"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                Dim reader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim userId = Convert.ToInt32(reader("UserID"))
                    Client.Connect()

                    Dim chatForm As New frmChat()
                    chatForm.LoggedInUserID = userId
                    chatForm.LoggedInUsername = username
                    chatForm.Show()

                    ' ✅ Clear fields before hiding
                    txtUsername.Clear()
                    txtPassword.Clear()

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid login or account blocked, or you're trying to log in with an Admin account.")
                End If
            End Using
        End Using
    End Sub

    ' Admin Login Redirection (frmLogin)
    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        ' Redirect to admin login form
        Dim AdminloginForm As New frmAdminLogin()
        AdminloginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnToRegister_Click(sender As Object, e As EventArgs) Handles btnToRegister.Click
        Dim frmRegister As New frmRegister()
        frmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdateSchema_Click(sender As Object, e As EventArgs)
        InitializeDatabase()
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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyFormRadius(30) ' Adjust 30 to your desired corner radius
        RoundButton(btnLogin, 35, Color.White, 2)
        RoundButton(btnToRegister, 35, Color.White, 2)
        RoundButton(btnAdminLogin, 35, Color.White, 2)
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

    End Sub

End Class
