Imports capaDatos
Imports capaEntidad
Public Class CNEmpleado
    Dim conexion As New CDEmpleado
    Public Function ValidadDatos(ByVal empleados As CEEMpleado) As Boolean
        Dim Resultado As Boolean = True
        If empleados.Nombre = "" Then
            Resultado = False
            MessageBox.Show("El campo Nombre es obligatorio", "Mensaje")
        End If

        If empleados.Apellido = "" Then
            Resultado = False
            MessageBox.Show("El campo apellido es obligatorio pipipi", "Mensaje")
        End If

        Return Resultado
    End Function

    'Public Sub pruebaConexion()
    '    conexion.prueba()
    'End Sub

    Public Sub Insertar(ByVal empleados As CEEMpleado)
        conexion.insertar(empleados)
    End Sub

    Public Function Lista() As DataSet
        Return conexion.Listar()
    End Function

    Public Function actualizar(ByVal obj As CEEMpleado)
        conexion.update(obj)

    End Function

    Public Function borrar(ByVal obj As Integer)

        If (MessageBox.Show("estas seguro", "pregunta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            )) = DialogResult.Yes Then
            conexion.delete(obj)


        End If

    End Function

End Class
