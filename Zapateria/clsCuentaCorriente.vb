Public Class clsCuentaCorriente
    Private _IdCuentaCorriente As Integer
    Public Property IdCuentaCorriente As Integer
        Get
            Return _IdCuentaCorriente
        End Get
        Set(ByVal value As Integer)
            _IdCuentaCorriente = value
        End Set
    End Property

    Private _Activo As Integer
    Public Property Activo As Integer
        Get
            Return _Activo
        End Get
        Set(ByVal value As Integer)
            _Activo = value
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

    Private _Deuda As Double
    Public Property Deuda As Double
        Get
            Return _Deuda
        End Get
        Set(ByVal value As Double)
            _Deuda = value
        End Set
    End Property
End Class


