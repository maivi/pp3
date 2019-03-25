Public Class clsMovimientoCC
    Private _IdMovimientosCC As Integer
    Public Property IdMovimientosCC As Integer
        Get
            Return _IdMovimientosCC
        End Get
        Set(ByVal value As Integer)
            _IdMovimientosCC = value
        End Set
    End Property

    Private _IdCC As Integer
    Public Property IdCC As Integer
        Get
            Return _IdCC
        End Get
        Set(ByVal value As Integer)
            _IdCC = value
        End Set
    End Property

    Private _SaldoPrevio As Double
    Public Property SaldoPrevio As Double
        Get
            Return _SaldoPrevio
        End Get
        Set(ByVal value As Double)
            _SaldoPrevio = value
        End Set
    End Property

    Private _SaldoCalculado As Double
    Public Property SaldoCalculado As Double
        Get
            Return _SaldoCalculado
        End Get
        Set(ByVal value As Double)
            _SaldoCalculado = value
        End Set
    End Property

    Private _Movimiento As Double
    Public Property Movimiento As Double
        Get
            Return _Movimiento
        End Get
        Set(ByVal value As Double)
            _Movimiento = value
        End Set
    End Property

    Private _FechaActualizacion As String
    Public Property FechaActualizacion As String
        Get
            Return _FechaActualizacion
        End Get
        Set(ByVal value As String)
            _FechaActualizacion = value
        End Set
    End Property
End Class
