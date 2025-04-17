Imports System.Data.SQLite
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
End Class
