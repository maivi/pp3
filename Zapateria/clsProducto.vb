﻿Public Class clsProducto
    Private _idProducto As Integer
    Public Property idProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Private _CodigoProducto As String
    Public Property CodigoProducto() As String
        Get
            Return _CodigoProducto
        End Get
        Set(ByVal value As String)
            _CodigoProducto = value
        End Set
    End Property

    Private _GeneroProducto As String
    Public Property GeneroProducto() As String
        Get
            Return _GeneroProducto
        End Get
        Set(ByVal value As String)
            _GeneroProducto = value
        End Set
    End Property

    Private _NombreProducto As String
    Public Property NombreProducto() As String
        Get
            Return _NombreProducto
        End Get
        Set(ByVal value As String)
            _NombreProducto = value
        End Set
    End Property


    Private _TalleProducto As String
    Public Property TalleProducto() As String
        Get
            Return _TalleProducto
        End Get
        Set(ByVal value As String)
            _TalleProducto = value
        End Set
    End Property

    Private _TipoProducto As String
    Public Property TipoProducto() As String
        Get
            Return _TipoProducto
        End Get
        Set(ByVal value As String)
            _TipoProducto = value
        End Set
    End Property
    Private _Proveedor As String
    Public Property Proveedor() As String
        Get
            Return _Proveedor
        End Get
        Set(ByVal value As String)
            _Proveedor = value
        End Set
    End Property
    Private _PrecCompra As String
    Public Property PrecCompra() As String
        Get
            Return _PrecCompra
        End Get
        Set(ByVal value As String)
            _PrecCompra = value
        End Set
    End Property
    Private _PrecVenta As String
    Public Property PrecVenta() As String
        Get
            Return _PrecVenta
        End Get
        Set(ByVal value As String)
            _PrecVenta = value
        End Set
    End Property
    Private _Stock As String
    Public Property Stock() As String
        Get
            Return _Stock
        End Get
        Set(ByVal value As String)
            _Stock = value
        End Set
    End Property
    Private _ActivoProveedor As Integer
    Public Property Activo() As Integer
        Get
            Return _ActivoProveedor
        End Get
        Set(ByVal value As Integer)
            _ActivoProveedor = value
        End Set
    End Property
End Class
