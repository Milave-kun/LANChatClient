Imports System.Net.Sockets
Imports System.IO
Imports System.Threading
Imports System.Data.SQLite
Imports System.Drawing.Drawing2D

Public Class frmChat
    Private client As TcpClient
    Private reader As StreamReader
    Private writer As StreamWriter
    Private receiveThread As Threading.Thread

    Public LoggedInUserID As Integer
    Public LoggedInUsername As String

    Private DB_PATH As String = Application.StartupPath & "\Database\chatapp.db"

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyFormRadius(30) ' Adjust 30 to your desired corner radius
        RoundButton(btnSendMessage, 35, Color.White, 2)
        RoundButton(btnChangeAvatar, 35, Color.White, 2)
        RoundButton(btnLogout, 35, Color.Red, 2)

        lblWelcome.Text = $"Welcome, {LoggedInUsername}"
        LoadMyAvatar()

        ' Set user status to online when they log in
        SetUserStatus(LoggedInUsername, "Online")

        Try
            client = New TcpClient("127.0.0.1", 5000)
            Dim netStream = client.GetStream()
            reader = New StreamReader(netStream)
            writer = New StreamWriter(netStream)
            writer.AutoFlush = True

            writer.WriteLine($"[CONNECT]:{LoggedInUserID}:{LoggedInUsername}")

            receiveThread = New Threading.Thread(AddressOf ReceiveMessages)
            receiveThread.IsBackground = True
            receiveThread.Start()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to server.")
            Me.Close()
        End Try
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

    Private Sub frmChat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Set user status to offline when they log out or close the form
        SetUserStatus(LoggedInUsername, "Offline")
    End Sub

    Private Sub LoadMyAvatar()
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()
                Using pragmaCmd As New SQLiteCommand("PRAGMA journal_mode = WAL;", conn)
                    pragmaCmd.ExecuteNonQuery()
                End Using

                Dim cmd As New SQLiteCommand("SELECT Avatar FROM Users WHERE UserID = @id", conn)
                cmd.Parameters.AddWithValue("@id", LoggedInUserID)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso File.Exists(result.ToString()) Then
                    Using fs As New FileStream(result.ToString(), FileMode.Open, FileAccess.Read)
                        picMyAvatar.Image = Image.FromStream(fs)
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading your avatar: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveMessageToDatabase(senderId As Integer, receiverUsername As String, message As String)
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()

                Dim queryReceiverId = "SELECT UserID FROM Users WHERE Username = @Username"
                Using cmdReceiver As New SQLiteCommand(queryReceiverId, conn)
                    cmdReceiver.Parameters.AddWithValue("@Username", receiverUsername)
                    Dim receiverId = Convert.ToInt32(cmdReceiver.ExecuteScalar())

                    Dim insertQuery = "INSERT INTO ChatLogs (SenderID, ReceiverID, MessageText, Timestamp) 
                                       VALUES (@SenderID, @ReceiverID, @MessageText, datetime('now'))"
                    Using cmdInsert As New SQLiteCommand(insertQuery, conn)
                        cmdInsert.Parameters.AddWithValue("@SenderID", senderId)
                        cmdInsert.Parameters.AddWithValue("@ReceiverID", receiverId)
                        cmdInsert.Parameters.AddWithValue("@MessageText", message)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving message to database: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadChatHistory(senderID As Integer, receiverID As Integer)
        Try
            rtbChatBox.Clear()

            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()

                Dim query As String = "
                    SELECT CL.MessageText, CL.Timestamp, U.Username AS SenderUsername
                    FROM ChatLogs CL
                    JOIN Users U ON CL.SenderID = U.UserID
                    WHERE (CL.SenderID = @senderID AND CL.ReceiverID = @receiverID)
                    OR (CL.SenderID = @receiverID AND CL.ReceiverID = @senderID)
                    ORDER BY CL.Timestamp ASC;"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@senderID", senderID)
                    cmd.Parameters.AddWithValue("@receiverID", receiverID)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim messageText As String = If(reader("MessageText") Is DBNull.Value, String.Empty, reader("MessageText").ToString())
                            Dim timestamp As String = If(reader("Timestamp") Is DBNull.Value, String.Empty, reader("Timestamp").ToString())
                            Dim senderUsername As String = If(reader("SenderUsername") Is DBNull.Value, "Unknown", reader("SenderUsername").ToString())

                            If senderUsername = LoggedInUsername Then
                                rtbChatBox.AppendText($"[{timestamp}] Me: {messageText}{vbCrLf}")
                            Else
                                rtbChatBox.AppendText($"[{timestamp}] {senderUsername}: {messageText}{vbCrLf}")
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading chat history: " & ex.Message)
        End Try
    End Sub

    Private Sub ReceiveMessages()
        Try
            While True
                Dim incoming As String = reader.ReadLine()
                If incoming IsNot Nothing Then
                    If incoming.StartsWith("[USERS]:") Then
                        ' Handle user list update
                        Dim usersRaw = incoming.Substring(8)
                        Dim users = usersRaw.Split(","c)

                        Me.Invoke(Sub()
                                      lstUsersOnline.Items.Clear()
                                      For Each user In users
                                          If user <> LoggedInUsername Then
                                              lstUsersOnline.Items.Add(user)
                                          End If
                                      Next
                                  End Sub)
                    ElseIf incoming.StartsWith("[MSG]|") Then
                        ' Format: [MSG]|senderID|receiverUsername|timestamp|message
                        Dim parts = incoming.Substring(6).Split("|"c)
                        If parts.Length >= 4 Then
                            Dim senderID = parts(0)
                            Dim receiverUsername = parts(1)
                            Dim timestamp = parts(2)
                            ' Combine the rest as the full message (in case the message has ':' characters)
                            Dim message = parts(3)

                            Dim senderUsername As String = GetUsernameFromUserID(CInt(senderID))

                            Me.Invoke(Sub()
                                          Dim currentChatUser = If(lstUsersOnline.SelectedItem?.ToString(), "")

                                          If receiverUsername = currentChatUser OrElse senderUsername = currentChatUser Then
                                              ' Parse timestamp and format it
                                              Dim formattedTime As String
                                              Try
                                                  formattedTime = DateTime.ParseExact(timestamp, "hh:mm:ss tt", Nothing).ToString("yyyy-MM-dd HH:mm:ss")
                                              Catch ex As Exception
                                                  formattedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                              End Try

                                              If senderUsername = LoggedInUsername Then
                                                  If Not rtbChatBox.Text.Contains($"[{formattedTime}] Me: {message}") Then
                                                      rtbChatBox.AppendText($"[{formattedTime}] Me: {message}{vbCrLf}")
                                                  End If
                                              Else
                                                  rtbChatBox.AppendText($"[{formattedTime}] {senderUsername}: {message}{vbCrLf}")
                                              End If
                                          End If
                                      End Sub)
                        End If
                    Else
                        Me.Invoke(Sub()
                                      rtbChatBox.AppendText(incoming & vbCrLf)
                                  End Sub)
                    End If
                End If
            End While
        Catch ex As Exception
            Me.Invoke(Sub()
                          MessageBox.Show("Disconnected from server.")
                          Me.Close()
                      End Sub)
        End Try
    End Sub

    Private Function GetUsernameFromUserID(userID As Integer) As String
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()
                Dim query As String = "SELECT Username FROM Users WHERE UserID = @id"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", userID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then Return result.ToString()
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return "Unknown"
    End Function

    Private Sub lstUsersOnline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsersOnline.SelectedIndexChanged
        Dim selectedUsername = lstUsersOnline.SelectedItem?.ToString()
        If Not String.IsNullOrEmpty(selectedUsername) Then
            Dim selectedUserID As Integer = GetUserIDFromUsername(selectedUsername)
            If selectedUserID > 0 Then
                LoadChatHistory(LoggedInUserID, selectedUserID)
                LoadSelectedUserAvatar(selectedUsername)
                ShowUserDetails(selectedUsername)
            End If
        End If
    End Sub

    Private Function GetUserIDFromUsername(username As String) As Integer
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()

                Dim query As String = "SELECT UserID FROM Users WHERE Username = @username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving user ID: " & ex.Message)
        End Try
        Return -1
    End Function

    Private Sub LoadSelectedUserAvatar(username As String)
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()
                Using pragmaCmd As New SQLiteCommand("PRAGMA journal_mode = WAL;", conn)
                    pragmaCmd.ExecuteNonQuery()
                End Using

                Dim cmd As New SQLiteCommand("SELECT Avatar FROM Users WHERE Username = @uname", conn)
                cmd.Parameters.AddWithValue("@uname", username)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso File.Exists(result.ToString()) Then
                    Using fs As New FileStream(result.ToString(), FileMode.Open, FileAccess.Read)
                        picSelectedAvatar.Image = Image.FromStream(fs)
                    End Using
                Else
                    picSelectedAvatar.Image = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading selected user's avatar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnChangeAvatar_Click(sender As Object, e As EventArgs) Handles btnChangeAvatar.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim selectedPath As String = ofd.FileName

            ' Optional: Copy the image to a local "Avatars" directory for consistency
            Dim avatarDir As String = Path.Combine(Application.StartupPath, "Avatars")
            If Not Directory.Exists(avatarDir) Then
                Directory.CreateDirectory(avatarDir)
            End If

            Dim newAvatarPath As String = Path.Combine(avatarDir, Path.GetFileName(selectedPath))
            File.Copy(selectedPath, newAvatarPath, True)

            ' Save new avatar path to the database
            Try
                Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                    conn.Open()
                    Dim updateQuery As String = "UPDATE Users SET Avatar = @Avatar WHERE UserID = @UserID"
                    Using cmd As New SQLiteCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@Avatar", newAvatarPath)
                        cmd.Parameters.AddWithValue("@UserID", LoggedInUserID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Update avatar in UI
                Using fs As New FileStream(newAvatarPath, FileMode.Open, FileAccess.Read)
                    picMyAvatar.Image = Image.FromStream(fs)
                End Using

                MessageBox.Show("Avatar updated successfully.")
            Catch ex As Exception
                MessageBox.Show("Failed to update avatar: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirmResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            SetUserStatus(LoggedInUsername, "Offline")
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ShowUserDetails(username As String)
        Try
            Using conn As New SQLiteConnection($"Data Source={DB_PATH};Version=3;BusyTimeout=5000;")
                conn.Open()
                Dim query As String = "SELECT Role, Status, Blocked, FirstName, LastName, Birthday, Address, PhoneNumber FROM Users WHERE Username = @Username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Display details in your respective labels
                            lblStatus.Text = If(reader("Blocked") = 1, "Blocked", reader("Status").ToString())
                            lblFirstName.Text = reader("FirstName").ToString()
                            lblLastName.Text = reader("LastName").ToString()
                            lblBirthday.Text = reader("Birthday").ToString()
                            lblAddress.Text = reader("Address").ToString()
                            lblPhoneNumber.Text = reader("PhoneNumber").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click
        If lstUsersOnline.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a user to send the message to.")
            Return
        End If

        Dim msg As String = txtMessage.Text.Trim()
        If msg = "" Then Return

        Dim selectedUser As String = lstUsersOnline.SelectedItem.ToString()
        Dim currentTimestamp As String = DateTime.Now.ToString("HH:mm:ss tt")

        ' Send message to server/client
        writer.WriteLine($"[MSG]|{LoggedInUserID}|{selectedUser}|{currentTimestamp}|{msg}")

        ' Save message to database (this was missing)
        SaveMessageToDatabase(LoggedInUserID, selectedUser, msg)

        txtMessage.Clear()
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
End Class
