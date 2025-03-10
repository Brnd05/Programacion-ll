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


        If (empleados.IdEmpleado = 0) Then
            Negocio.Insertar(empleados)
        Else
            Negocio.actualizar(empleados)
        End If

        cargarDatos()
    End Sub


    Private Sub pcFoto_Click(sender As Object, e As EventArgs) Handles PcFoto.Click

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (nuId.Value = 0) Then Exit Sub
        Dim empleados As New CEEMpleado()
        empleados.IdEmpleado = nuId.Value
        Negocio.borrar(empleados.IdEmpleado)
        cargarDatos()
    End Sub


    Private Sub cargarDatos()
        Dim ds As New DataSet
        ds = Negocio.Lista()

        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
            dgvEmpleado.DataSource = ds.Tables("empleados")
        Else
            MessageBox.Show("No hay datos")
        End If
    End Sub

    'Private Sub dgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentClick

    'End Sub

    Private Sub dgvEmpleado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellDoubleClick
        TxtNombre.Text = dgvEmpleado.CurrentRow.Cells("nombre").Value
        TxtApellido.Text = dgvEmpleado.CurrentRow.Cells("npellido").Value
        nuId.Value = dgvEmpleado.CurrentRow.Cells("id").Value
        PcFoto.Image = Nothing

        If dgvEmpleado.CurrentRow.Cells("foto").Value <> "" Then
            If System.IO.File.Exists(dgvEmpleado.CurrentRow.Cells("foto").Value) Then
                PcFoto.Load(dgvEmpleado.CurrentRow.Cells("foto").Value)
            End If
        End If
    End Sub

    Private Sub nuId_ValueChanged(sender As Object, e As EventArgs) Handles nuId.ValueChanged

    End Sub
End Class
