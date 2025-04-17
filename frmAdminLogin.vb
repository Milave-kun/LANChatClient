Imports System.Data.SQLite

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
End Class
