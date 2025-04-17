Imports System.Data.SQLite
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
End Class
