Imports System.Net.Sockets
Imports System.IO

Public Class Client
    Private Shared clientSocket As TcpClient
    Private Shared writer As StreamWriter
    Private Shared reader As StreamReader
    Private Shared serverIP As String = "127.0.0.1"  ' Replace with actual server IP
    Private Shared serverPort As Integer = 5000

    ' Connect to the server
    Public Shared Sub Connect()
        Try
            clientSocket = New TcpClient(serverIP, serverPort)
            Dim networkStream As NetworkStream = clientSocket.GetStream()
            writer = New StreamWriter(networkStream) With {.AutoFlush = True}
            reader = New StreamReader(networkStream)
        Catch ex As Exception
            MessageBox.Show("Error connecting to the server: " & ex.Message)
        End Try
    End Sub

    ' Send data to the server
    Public Shared Sub SendData(data As String)
        If clientSocket IsNot Nothing AndAlso clientSocket.Connected Then
            writer.WriteLine(data)
        Else
            MessageBox.Show("Not connected to the server.")
        End If
    End Sub

    ' Receive data from the server
    Public Shared Function ReceiveData() As String
        If clientSocket IsNot Nothing AndAlso clientSocket.Connected Then
            Return reader.ReadLine()
        Else
            MessageBox.Show("Not connected to the server.")
            Return String.Empty
        End If
    End Function

    ' Close the connection
    Public Shared Sub CloseConnection()
        If clientSocket IsNot Nothing Then
            reader?.Close()
            writer?.Close()
            clientSocket?.Close()
        End If
    End Sub
End Class
