Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Reflection
Public Class Utilidades_MySQL

    Private CadenaConexion As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("cn")
    Private MySQLConexion As MySqlConnection


    Private Sub Conectar()
        MySQLConexion = New MySqlConnection(CadenaConexion.ConnectionString)
    End Sub


    Private Comando As MySqlCommand
    Public Function MiComandoSQL(ByVal InsertSQL As String) As Boolean
        Conectar()
        Dim CantRegIns As Integer
        Try
            Using MySQLConexion
                MySQLConexion.Open()
                Comando = New MySqlCommand(InsertSQL, MySQLConexion)
                CantRegIns = Comando.ExecuteNonQuery()
            End Using
        Catch e As MySqlException
            'MsgBox("Mensaje de Error:" & Chr(13) & e.Message, MsgBoxStyle.Critical, "Error en la operación MySQL")
        Catch ex As Exception
            MsgBox("Mensaje de Error:" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en la operaciónL")
        Finally
            'If MySQLConexion.State = ConnectionState.Open Then
            MySQLConexion.Close()
            'End If
        End Try

        If CantRegIns > 0 Then
            Return True
        Else
            Return False
        End If
    End Function



    Public Function MiComandoSQL(ByVal Tabla As String, ByVal Condicion As String) As Boolean
        Conectar()
        Dim CantRegIns As Integer
        Try
            Using MySQLConexion
                MySQLConexion.Open()
                Dim sql As String = "DELETE FROM " & Tabla & " WHERE " & Condicion
                Comando = New MySqlCommand(sql, MySQLConexion)
                CantRegIns = Comando.ExecuteNonQuery()
            End Using
        Catch e As MySqlException
            MsgBox("Mensaje de Error:" & Chr(13) & e.Message, MsgBoxStyle.Critical, "Error en la operación MySQL")
        Catch ex As Exception
            MsgBox("Mensaje de Error:" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en la operación")
        Finally
            'If MySQLConexion.State = ConnectionState.Open Then
            MySQLConexion.Close()
            'End If
        End Try

        If CantRegIns > 0 Then
            Return True
        Else
            Return False
        End If

    End Function



    Public Function MiComandoSQL(ByVal Tabla As String, ByVal Campos As String, ByVal Condicion As String) As Boolean
        Conectar()
        Dim CantRegIns As Integer
        Try
            Using MySQLConexion
                MySQLConexion.Open()
                Dim sql As String = "UPDATE " & Tabla & " SET " & Campos & " WHERE " & Condicion
                Comando = New MySqlCommand(sql, MySQLConexion)
                CantRegIns = Comando.ExecuteNonQuery()
            End Using
        Catch e As MySqlException
            MsgBox("Mensaje de Error:" & Chr(13) & e.Message, MsgBoxStyle.Critical, "Error en la operación MySQL")
        Catch ex As Exception
            MsgBox("Mensaje de Error:" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en la operación")
        Finally
            'If MySQLConexion.State = ConnectionState.Open Then
            MySQLConexion.Close()
            'End If
        End Try

        If CantRegIns > 0 Then
            Return True
        Else
            Return False
        End If

    End Function




    Private _MiDataAdapter As New MySqlDataAdapter
    Public Function MiComandoSQL(ByVal SelectSQL As String, ByRef Tabla As DataTable)

        Dim comando As New MySqlCommand

        Conectar()

        With comando
            .CommandText = SelectSQL
            .Connection = MySQLConexion
            .CommandType = CommandType.Text
        End With
        Try
            Using MySQLConexion
                MySQLConexion.Open()
                _MiDataAdapter.SelectCommand = comando
                _MiDataAdapter.Fill(Tabla)
                MySQLConexion.Close()
            End Using
        Catch e As MySqlException
            MsgBox("Mensaje de Error:" & Chr(13) & e.Message, MsgBoxStyle.Critical, "Error en la operación MySQL")
        Catch ex As Exception
            MsgBox("Mensaje de Error:" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en la operación")
        Finally
            'If MySQLConexion.State = ConnectionState.Open Then
            MySQLConexion.Close()
            'End If
        End Try
        Return True
    End Function


    Public Function MiComandoSQL(ByVal SelectSQL As String, ByRef Registro As Object)

        Dim comando As New MySqlCommand
        Dim DataReader As MySqlDataReader
        Dim CantReg As Integer = 0
        Conectar()

        With comando
            .CommandText = SelectSQL
            .Connection = MySQLConexion
            .CommandType = CommandType.Text
        End With
        Try
            Using MySQLConexion

                MySQLConexion.Open()
                DataReader = comando.ExecuteReader
                If DataReader.Read Then
                    Dim Propiedad As PropertyInfo
                    For Each Propiedad In Registro.GetType.GetProperties()
                        Propiedad.SetValue(Registro, DataReader.GetValue(CantReg), Nothing)
                        CantReg += 1
                    Next

                End If

            End Using
        Catch e As MySqlException
            MsgBox("Mensaje de Error:" & Chr(13) & e.Message, MsgBoxStyle.Critical, "Error en la operación MySQL")
        Catch ex As Exception
            MsgBox("Mensaje de Error:" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en la operación")
        Finally
            'If MySQLConexion.State = ConnectionState.Open Then
            MySQLConexion.Close()
            'End If

        End Try
        Return True
    End Function


    '-------------------------------------------------------------------------------------------------------------------------------------------

    Public Function MiComandoSQL(ByVal nombretabla As String, ByVal datoNuevo As Object, ByVal datoOriginal As Object)

        Dim tipodatooriginal As Type = datoOriginal.GetType
        Dim tipodatonuevo As Type = datoNuevo.GetType
        Dim nombrecolumna As String
        Dim sqlcomando As String = "update " & nombretabla & " set "
        Dim propiedadesdatooriginal As System.Reflection.PropertyInfo() = tipodatooriginal.GetProperties
        Dim propiedadesdatonuevo As System.Reflection.PropertyInfo() = tipodatonuevo.GetProperties
        Dim valordatooriginal, valordatonuevo As Object

        Dim cadenasql As New Collection
        For columna As Integer = 0 To propiedadesdatonuevo.Count - 1

            nombrecolumna = propiedadesdatonuevo.ElementAt(columna).Name
            valordatooriginal = propiedadesdatooriginal.ElementAt(columna).GetValue(datoOriginal, Nothing)
            valordatonuevo = propiedadesdatonuevo.ElementAt(columna).GetValue(datoNuevo, Nothing)
            If nombrecolumna.Contains("id") And valordatonuevo <> valordatooriginal Then
                MsgBox("Los registros comparados son distintos")
                'Exit Function
            Else
                If valordatonuevo <> valordatooriginal Then
                    If valordatonuevo.GetType.ToString = "System.DateTime" Then
                        cadenasql.Add(nombrecolumna & "= '" & String.Format("{0:yyyy-MM-dd}", valordatonuevo) & "' ")
                    Else
                        cadenasql.Add(nombrecolumna & "= '" & valordatonuevo & "'")
                    End If
                End If
            End If

        Next

        For cantidaddatos As Integer = 1 To cadenasql.Count
            If cantidaddatos < cadenasql.Count Then
                sqlcomando = sqlcomando & cadenasql.Item(cantidaddatos) & ", "

            ElseIf cantidaddatos = cadenasql.Count Then
                sqlcomando = sqlcomando & cadenasql.Item(cantidaddatos)
            End If
        Next
        sqlcomando = sqlcomando & " where " & propiedadesdatonuevo.ElementAt(0).Name & " = " & propiedadesdatonuevo.ElementAt(0).GetValue(datoNuevo, Nothing)
        Return sqlcomando

    End Function

    '------------------------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------------------------

    Public Function cantReg(ByVal selectSQL As String)
        Dim comando As New MySqlCommand
        Conectar()
        Dim cantRegIns As Integer = 0

        With comando
            .CommandText = selectSQL
            .Connection = MySQLConexion
            .CommandType = CommandType.Text
        End With

        Try
            Using MySQLConexion
                MySQLConexion.Open()
                cantRegIns = comando.ExecuteScalar()
                If (cantRegIns <> Nothing) Then
                    cantRegIns = Convert.ToInt32(cantRegIns)
                End If
            End Using
        Catch e As MySqlException
            MsgBox("Mensaje de Error:" & Chr(13) & e.Message, MsgBoxStyle.Critical, "Error en la operación MySQL")
        Catch ex As Exception
            MsgBox("Mensaje de Error:" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en la operación")
        Finally
            'If MySQLConexion.State = ConnectionState.Open Then
            MySQLConexion.Close()
            'End If
        End Try

        Return cantRegIns
    End Function

    Public Function obtenerTipoUsuarios(ByVal selectSQL As String)
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader

        Dim fila As New ArrayList
        Dim tipoUsuarios As New List(Of ArrayList)
        'foo.Add("Bar")

        Conectar()
        Dim cantRegIns As Integer = 0

        With comando
            .CommandText = selectSQL
            .Connection = MySQLConexion
            .CommandType = CommandType.Text
        End With

        Try
            Using MySQLConexion
                MySQLConexion.Open()
                dr = comando.ExecuteReader()
                If dr.Read Then
                    fila.Add(dr(0).ToString)
                    fila.Add(dr(1).ToString)
                    tipoUsuarios.Add(fila)
                End If
            End Using

        Catch e As MySqlException
            MsgBox("Mensaje de Error:" & Chr(13) & e.Message, MsgBoxStyle.Critical, "Error en la operación MySQL")
        Catch ex As Exception
            MsgBox("Mensaje de Error:" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error en la operación")
        Finally
            MySQLConexion.Close()
        End Try

        Return tipoUsuarios
    End Function

End Class
