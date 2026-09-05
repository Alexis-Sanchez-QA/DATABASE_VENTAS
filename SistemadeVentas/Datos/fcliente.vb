Imports System.Data.SqlClient

Public Class fcliente
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("mostrar_cliente", cnn)
            cmd.CommandType = CommandType.StoredProcedure



            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)


            Return dt

        Catch ex As Exception
            MsgBox("Error al cargar clientes: " & ex.Message)
            Return New DataTable()
        Finally
            Desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("insertar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@rfc", dts.grfc)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error al insertar cliente: " & ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function


    Public Function editar(ByVal dts As vcliente) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("editar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@rfc", dts.grfc)

            ' Usamos <> 0 para capturar correctamente la respuesta de SQL
            If cmd.ExecuteNonQuery() <> 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error en SQL: " & ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idcliente", SqlDbType.NVarChar, 50).Value = dts.gidcliente
            If cmd.ExecuteNonQuery() <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar cliente: " & ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function


End Class
