Imports capaEntidad
Imports capaNegocio
Public Class FrEmpleado
    Dim Negocio As New CNEmpleado()
    Dim rutaImagen As String = String.Empty


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PcFoto.Click

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        TxtApellido.Text = ""
        TxtNombre.Text = ""
        nuId.Value = 0
        PcFoto.Image = Nothing
        rutaImagen = String.Empty



    End Sub

    Private Sub lnkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkFoto.LinkClicked
        OpenFoto.ShowDialog()

        If OpenFoto.FileName <> "" Then
            PcFoto.Image = Image.FromFile(OpenFoto.FileName)
            rutaImagen = OpenFoto.FileName
        End If

        OpenFoto.FileName = ""

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim empleados As New CEEMpleado()
        Dim validar As Boolean
        empleados.IdEmpleado = nuId.Value
        empleados.Nombre = TxtNombre.Text
        empleados.Apellido = TxtApellido.Text
        empleados.Foto1 = rutaImagen
        MessageBox.Show(rutaImagen)
        validar = Negocio.ValidadDatos(empleados)
        If validar = False Then
            Exit Sub
        ElseIf Negocio.ValidadDatos(empleados) = True Then
            Negocio.Insertar(empleados)
        End If
    End Sub


    Private Sub pcFoto_Click(sender As Object, e As EventArgs) Handles PcFoto.Click

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub
End Class
