Public Class clsUsuario
    Private _IdUsuario As Integer
    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As Integer)
            _IdUsuario = value
        End Set
    End Property


    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Jerarquia As String
    Public Property Jerarquia() As String
        Get
            Return _Jerarquia
        End Get
        Set(ByVal value As String)
            _Jerarquia = value
        End Set
    End Property

    Private _Usuario As String
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Private _Pass1 As String
    Public Property Pass1() As String
        Get
            Return _Pass1
        End Get
        Set(ByVal value As String)
            _Pass1 = value
        End Set
    End Property

    Private _Pass2 As String
    Public Property Pass2() As String
        Get
            Return _Pass2
        End Get
        Set(ByVal value As String)
            _Pass2 = value
        End Set
    End Property

    Private _Activo As Integer
    Public Property Activo() As Integer
        Get
            Return _Activo
        End Get
        Set(ByVal value As Integer)
            _Activo = value
        End Set
    End Property
End Class
