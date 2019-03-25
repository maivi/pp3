Public Class clsDetalleVentas
    Private _IdVentaAsociada As Integer
    Public Property IdVentaAsociada As Integer
        Get
            Return _IdVentaAsociada
        End Get
        Set(ByVal value As Integer)
            _IdVentaAsociada = value
        End Set
    End Property

    Private _IdProducto As Integer
    Public Property IdProducto As Integer
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As Integer)
            _IdProducto = value
        End Set
    End Property

    Private _CantProducto As Integer
    Public Property CantProducto As Integer
        Get
            Return _CantProducto
        End Get
        Set(ByVal value As Integer)
            _CantProducto = value
        End Set
    End Property

    Private _TotalProducto As Double
    Public Property TotalProducto As Double
        Get
            Return _TotalProducto
        End Get
        Set(ByVal value As Double)
            _TotalProducto = value
        End Set
    End Property

    
End Class
