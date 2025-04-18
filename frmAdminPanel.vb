Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Net.Sockets

Public Class frmAdminPanel
    Private DB_PATH As String = Application.StartupPath & "\Database\chatapp.db"
    Public Property LoggedInUsername As String


    Private Sub frmAdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        SetUserStatus(LoggedInUsername, "Online")
    End Sub

    Private Sub frmAdminPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SetUserStatus(LoggedInUsername, "Offline")
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        lstUsers.Items.Clear()

        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;")
                conn.Open()
                Dim query As String = "SELECT Username, Status FROM Users ORDER BY Username ASC"
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim username As String = reader("Username").ToString()
                            Dim status As String = reader("Status").ToString()
                            Dim displayText As String = $"{username} ({status})"
                            lstUsers.Items.Add(displayText)
                        End While
                    End Using
                End Using
            End Using
            txtLogs.AppendText("✅ User list refreshed with statuses." & Environment.NewLine)
        Catch ex As Exception
            txtLogs.AppendText("❌ Error loading users: " & ex.Message & Environment.NewLine)
        End Try
    End Sub


    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        If lstUsers.SelectedItem IsNot Nothing Then
            Dim selectedEntry As String = lstUsers.SelectedItem.ToString()
            Dim usernameOnly As String = selectedEntry.Split(" "c)(0)
            ShowUserDetails(usernameOnly)
        End If
    End Sub

    Private Sub ShowUserDetails(username As String)
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;")
                conn.Open()
                Dim query As String = "SELECT Role, Status, Blocked, FirstName, LastName, Avatar, Birthday, Address, PhoneNumber FROM Users WHERE Username = @Username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblUsername.Text = username
                            lblRole.Text = reader("Role").ToString()
                            lblStatus.Text = If(reader("Blocked") = 1, "Blocked", reader("Status").ToString())
                            lblFirstName.Text = reader("FirstName").ToString()
                            lblLastName.Text = reader("LastName").ToString()

                            ' ✅ New fields
                            lblBirthday.Text = reader("Birthday").ToString()
                            lblAddress.Text = reader("Address").ToString()
                            lblPhoneNumber.Text = reader("PhoneNumber").ToString()

                            ' Load avatar
                            Dim avatarPath = reader("Avatar").ToString()
                            If Not String.IsNullOrEmpty(avatarPath) AndAlso File.Exists(avatarPath) Then
                                Using fs As New FileStream(avatarPath, FileMode.Open, FileAccess.Read)
                                    picAvatar.Image = Image.FromStream(fs)
                                End Using
                            Else
                                picAvatar.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            End Using
            txtLogs.AppendText($"ℹ️ Loaded info for {username}" & Environment.NewLine)
        Catch ex As Exception
            txtLogs.AppendText("❌ Error loading user details: " & ex.Message & Environment.NewLine)
        End Try
    End Sub

    Private Sub btnBlock_Click(sender As Object, e As EventArgs) Handles btnBlock.Click
        UpdateUserBlockStatus(True)
    End Sub

    Private Sub btnUnblock_Click(sender As Object, e As EventArgs) Handles btnUnblock.Click
        UpdateUserBlockStatus(False)
    End Sub

    Private Sub UpdateUserBlockStatus(block As Boolean)
        If lstUsers.SelectedItem Is Nothing Then
            MessageBox.Show("Select a user first.")
            Return
        End If

        ' ✅ Extract just the username part
        Dim selectedEntry As String = lstUsers.SelectedItem.ToString()
        Dim username As String = selectedEntry.Split(" "c)(0)

        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;")
                conn.Open()
                Dim query As String = "UPDATE Users SET Blocked = @Blocked WHERE Username = @Username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Blocked", If(block, 1, 0))
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            txtLogs.AppendText($"🔒 User {username} {(If(block, "blocked", "unblocked"))}." & Environment.NewLine)
            ShowUserDetails(username)
        Catch ex As Exception
            txtLogs.AppendText("❌ Error updating block status: " & ex.Message & Environment.NewLine)
        End Try
    End Sub


    Private Sub timerRefreshUsers_Tick(sender As Object, e As EventArgs) Handles timerRefreshUsers.Tick
        LoadUsers()
    End Sub

    Private Sub SetUserStatus(username As String, status As String)
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()
                Dim query As String = "UPDATE Users SET Status = @Status WHERE Username = @Username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirmResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            SetUserStatus(LoggedInUsername, "Offline")
            frmAdminLogin.Show()
            Me.Close()
        End If
    End Sub

End Class
