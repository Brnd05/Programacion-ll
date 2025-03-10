Imports Microsoft.Data.SqlClient
Imports CapaDatos
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports capaEntidad
Imports Microsoft.Identity.Client.Platforms.Shared

Public Class CDEmpleado

    Private ReadOnly cadena As String = "Data Source=DESKTOP-64VE70N;Initial Catalog=registroEmpleado;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"


    Public Sub conn()
        Dim conexion As New SqlConnection(cadena)
        Try
            conexion.Open()
            MessageBox.Show("Conexión exitosa")
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        End Try
        conexion.Close()
    End Sub

    Public Sub insertar(ByVal empleados As CEEMpleado)
        Try
            Dim conexion As New SqlConnection(cadena)
            conexion.Open()
            Dim consultaSql As String = "Insert  Into empleados (nombre,apellido,foto) 
            Values  (@nombre,@apellido,@foto) "

            Dim commando As New SqlCommand(consultaSql, conexion)
            commando.Parameters.AddWithValue("@nombre", empleados.Nombre)
            commando.Parameters.AddWithValue("@apellido", empleados.Apellido)
            commando.Parameters.AddWithValue("@foto", empleados.Foto1)
            commando.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Conexión finalizada")
        Catch ex As Exception
            MessageBox.Show("Error -->" + ex.Message)
        End Try
    End Sub
    Public Sub update(ByVal empleados As CEEMpleado)
        Try
            Dim conexion As New SqlConnection(cadena)
            conexion.Open()
            Dim consultaSql As String
            consultaSql = "UPDATE empleados " &
           "SET nombre = @nombre, apellido = @apellido, foto = @foto " &
           "WHERE id = @id"

            Dim commando As New SqlCommand(consultaSql, conexion)
            commando.Parameters.AddWithValue("@nombre", empleados.Nombre)
            commando.Parameters.AddWithValue("@apellido", empleados.Apellido)
            commando.Parameters.AddWithValue("@foto", empleados.Foto1)
            commando.Parameters.AddWithValue("@id", empleados.IdEmpleado)
            commando.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Conexión finalizada")
        Catch ex As Exception
            MessageBox.Show("Error -->" + ex.Message)
        End Try
    End Sub

    Public Sub delete(ByVal id As Integer)
        Try
            Dim conexion As New SqlConnection(cadena)
            conexion.Open()
            Dim consultaSql As String
            consultaSql = "DELETE FROM empleados
                           WHERE empleados.id = @id"

            Dim commando As New SqlCommand(consultaSql, conexion)
            commando.Parameters.AddWithValue("@id", id)
            commando.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Conexión finalizada")
        Catch ex As Exception
            MessageBox.Show("Error -->" + ex.Message)
        End Try
    End Sub

    Public Function Listar() As DataSet
        Dim dataset As New DataSet()
        Dim consultaSql As String = "SELECT * FROM empleados"

        Try
            '"Using" para garantizar el cierre adecuado de la conexión '
            Using conexion As New SqlConnection(cadena)
                conexion.Open()
                Using adapter As New SqlDataAdapter(consultaSql, conexion)
                    adapter.Fill(dataset, "empleados")
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al listar los datos -->" & ex.Message)

        End Try
        Return dataset
    End Function

End Class

'Data Source = DESKTOP - 64VE70N;Initial Catalog=registroEmpleado;Integrated Security=True;Encrypt=False