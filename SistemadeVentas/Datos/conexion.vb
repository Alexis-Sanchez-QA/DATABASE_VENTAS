Imports System.Data.SqlClient

Public Class conexion

    Protected cnn As New SqlConnection

    Public idusuario As Integer

    Protected Function Conectado()
        Try
            cnn = New SqlConnection("data source=DESKTOP-207BOT3\SQLEXPRESS; initial catalog=Ventas; integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Protected Function Desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function
End Class
