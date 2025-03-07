<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtNombre = New TextBox()
        TxtApellido = New TextBox()
        nuId = New NumericUpDown()
        PcFoto = New PictureBox()
        LnkFoto = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BtnNuevo = New Button()
        BtnEliminar = New Button()
        BtnGuardar = New Button()
        OpenFoto = New OpenFileDialog()
        CType(nuId, ComponentModel.ISupportInitialize).BeginInit()
        CType(PcFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(253, 67)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(274, 23)
        TxtNombre.TabIndex = 0
        TxtNombre.Text = " Escriba su nombre"
        ' 
        ' TxtApellido
        ' 
        TxtApellido.Location = New Point(253, 121)
        TxtApellido.Name = "TxtApellido"
        TxtApellido.Size = New Size(274, 23)
        TxtApellido.TabIndex = 1
        TxtApellido.Text = "Escriba su apellido"
        ' 
        ' nuId
        ' 
        nuId.Location = New Point(253, 12)
        nuId.Name = "nuId"
        nuId.Size = New Size(120, 23)
        nuId.TabIndex = 2
        ' 
        ' PcFoto
        ' 
        PcFoto.BackColor = SystemColors.Highlight
        PcFoto.Location = New Point(253, 170)
        PcFoto.Name = "PcFoto"
        PcFoto.Size = New Size(226, 153)
        PcFoto.SizeMode = PictureBoxSizeMode.StretchImage
        PcFoto.TabIndex = 3
        PcFoto.TabStop = False
        ' 
        ' LnkFoto
        ' 
        LnkFoto.AutoSize = True
        LnkFoto.Location = New Point(342, 340)
        LnkFoto.Name = "LnkFoto"
        LnkFoto.Size = New Size(48, 15)
        LnkFoto.TabIndex = 4
        LnkFoto.TabStop = True
        LnkFoto.Text = "Ir a foto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(173, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 5
        Label1.Text = "Empleado Id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(173, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(173, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 7
        Label3.Text = "Apellido"
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.Location = New Point(149, 379)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(75, 23)
        BtnNuevo.TabIndex = 8
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(342, 379)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 9
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(541, 379)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(75, 23)
        BtnGuardar.TabIndex = 10
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' OpenFoto
        ' 
        OpenFoto.FileName = "OpenFileDialog1"
        ' 
        ' FrEmpleado
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnGuardar)
        Controls.Add(BtnEliminar)
        Controls.Add(BtnNuevo)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LnkFoto)
        Controls.Add(PcFoto)
        Controls.Add(nuId)
        Controls.Add(TxtApellido)
        Controls.Add(TxtNombre)
        Name = "FrEmpleado"
        Text = "Form1"
        CType(nuId, ComponentModel.ISupportInitialize).EndInit()
        CType(PcFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents nuId As NumericUpDown
    Friend WithEvents PcFoto As PictureBox
    Friend WithEvents LnkFoto As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents OpenFoto As OpenFileDialog

End Class
