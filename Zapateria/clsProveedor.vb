Public Class clsProveedor
    Private _idProveedor As Integer
    Public Property idProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property

    Private _CUIT As String
    Public Property CUIT() As String
        Get
            Return _CUIT
        End Get
        Set(ByVal value As String)
            _CUIT = value
        End Set
    End Property

    Private _NombreProveedor As String
    Public Property NombreProveedor() As String
        Get
            Return _NombreProveedor
        End Get
        Set(ByVal value As String)
            _NombreProveedor = value
        End Set
    End Property

    Private _DireccionProveedor As String
    Public Property DireccionProveedor() As String
        Get
            Return _DireccionProveedor
        End Get
        Set(ByVal value As String)
            _DireccionProveedor = value
        End Set
    End Property


    Private _TelefonoProveedor As String
    Public Property TelefonoProveedor() As String
        Get
            Return _TelefonoProveedor
        End Get
        Set(ByVal value As String)
            _TelefonoProveedor = value
        End Set
    End Property

    Private _PaginaWeb As String
    Public Property PaginaWeb() As String
        Get
            Return _PaginaWeb
        End Get
        Set(ByVal value As String)
            _PaginaWeb = value
        End Set
    End Property
    Private _ActivoProveedor As Integer
    Public Property activo() As Integer
        Get
            Return _ActivoProveedor
        End Get
        Set(ByVal value As Integer)
            _ActivoProveedor = value
        End Set
    End Property
End Class
