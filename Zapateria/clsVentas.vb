Public Class clsVentas
    Private _IdVentas As Integer
    Public Property IdVentas As Integer
        Get
            Return _IdVentas
        End Get
        Set(ByVal value As Integer)
            _IdVentas = value
        End Set
    End Property

    Private _IdCliente As Integer
    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As Integer)
            _IdCliente = value
        End Set
    End Property

    Private _IdUsuario As Integer
    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private _IdTipoPago As Integer
    Public Property IdTipoPago As Integer
        Get
            Return _IdTipoPago
        End Get
        Set(ByVal value As Integer)
            _IdTipoPago = value
        End Set
    End Property

    Private _CantidadEfectivo As Double
    Public Property CantidadEfectivo As Double
        Get
            Return _CantidadEfectivo
        End Get
        Set(ByVal value As Double)
            _CantidadEfectivo = value
        End Set
    End Property

    Private _CantidadCuentaCorriente As Double
    Public Property CantidadCuentaCorriente As Double
        Get
            Return _CantidadCuentaCorriente
        End Get
        Set(ByVal value As Double)
            _CantidadCuentaCorriente = value
        End Set
    End Property

    Private _Total As Double
    Public Property Total As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property

    Private _Fecha As String
    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property
End Class
