Public Class clsTipo
    Private _idTipo As Integer
    Public Property idTipo() As Integer
        Get
            Return _idTipo
        End Get
        Set(ByVal value As Integer)
            _idTipo = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _Activo As Integer
    Public Property activo() As Integer
        Get
            Return _Activo
        End Get
        Set(ByVal value As Integer)
            _Activo = value
        End Set
    End Property
End Class
