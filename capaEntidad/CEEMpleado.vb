Public Class CEEMpleado

    Private _idEmpleado As Integer
    Private _nombre As String
    Private _apellido As String
    Private foto As String

    Public Sub New()
    End Sub

    Public Property IdEmpleado As Integer
        Get
            Return _idEmpleado
        End Get
        Set(value As Integer)
            _idEmpleado = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Foto1 As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
        End Set
    End Property
End Class
