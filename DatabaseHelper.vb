Imports System.Data.SQLite
Imports System.IO

Module DatabaseHelper

    Public DB_PATH As String = Application.StartupPath & "\Database\chatapp.db"

    Public Sub InitializeDatabase()
        ' Ensure the database folder exists
        Dim dbFolder As String = Application.StartupPath & "\Database"
        If Not Directory.Exists(dbFolder) Then
            Directory.CreateDirectory(dbFolder)
        End If

        ' Only create database and tables if the DB file doesn't already exist
        If Not File.Exists(DB_PATH) Then
            SQLiteConnection.CreateFile(DB_PATH)

            Using conn As New SQLiteConnection("Data Source=" & DB_PATH)
                conn.Open()

                Dim cmd As New SQLiteCommand(conn)

                ' Create Users table
                cmd.CommandText = "
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT UNIQUE NOT NULL,
                    Password TEXT NOT NULL,
                    FirstName TEXT,
                    LastName TEXT,
                    Birthday TEXT,
                    Address TEXT,
                    PhoneNumber TEXT,
                    Status TEXT DEFAULT 'Offline',
                    Avatar TEXT,
                    Blocked INTEGER DEFAULT 0,
                    Role TEXT DEFAULT 'User'
                );"
                cmd.ExecuteNonQuery()

                ' Create ChatLogs table
                cmd.CommandText = "
                CREATE TABLE IF NOT EXISTS ChatLogs (
                    LogID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SenderID INTEGER,
                    ReceiverID INTEGER,
                    MessageText TEXT,
                    Timestamp TEXT,
                    FOREIGN KEY(SenderID) REFERENCES Users(UserID),
                    FOREIGN KEY(ReceiverID) REFERENCES Users(UserID)
                );"
                cmd.ExecuteNonQuery()

                conn.Close()
            End Using

            MessageBox.Show("New database created successfully!", "Success")
        Else
            ' Optional: Notify that the database already exists
            Console.WriteLine("Database already exists. Initialization skipped.")
        End If
    End Sub

End Module
