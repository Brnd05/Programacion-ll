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


End Class

'Data Source = DESKTOP - 64VE70N;Initial Catalog=registroEmpleado;Integrated Security=True;Encrypt=False