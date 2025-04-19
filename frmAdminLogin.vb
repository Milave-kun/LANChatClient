Imports System.Data.SQLite
Imports System.Drawing.Drawing2D

Public Class frmAdminLogin
    Private DB_PATH As String = Application.StartupPath & "\Database\chatapp.db"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter admin username and password.")
            Return
        End If

        ' Hash password the same way it was stored
        Dim hashedPassword As String = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password))

        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()

                Dim query = "SELECT * FROM Users WHERE Username=@username AND Password=@password AND Role='Admin'"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            MessageBox.Show("✅ Admin login successful!")
                            frmAdminPanel.LoggedInUsername = username
                            frmAdminPanel.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("❌ Invalid admin credentials or not an admin account.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Login failed: " & ex.Message)
        End Try
    End Sub

    Private Sub btnToUserLogin_Click(sender As Object, e As EventArgs) Handles btnToUserLogin.Click
        frmLogin.Show()
        Me.Hide()
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

    Private Sub frmAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyFormRadius(30) ' Adjust 30 to your desired corner radius
        RoundButton(btnLogin, 35, Color.White, 2)
        RoundButton(btnToUserLogin, 35, Color.White, 2)
    End Sub
End Class
