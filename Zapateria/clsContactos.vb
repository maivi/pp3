﻿Public Class clsContactos
    Private _IdCliente As Integer
    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As Integer)
            _IdCliente = value
        End Set
    End Property

    Private _TipoDocumento As String
    Public Property TipoDocumento() As String
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As String)
            _TipoDocumento = value
        End Set
    End Property

    Private _DocumentoCliente As String
    Public Property DocumentoCliente() As String
        Get
            Return _DocumentoCliente
        End Get
        Set(ByVal value As String)
            _DocumentoCliente = value
        End Set
    End Property

    Private _NombreCliente As String
    Public Property NombreCliente() As String
        Get
            Return _NombreCliente
        End Get
        Set(ByVal value As String)
            _NombreCliente = value
        End Set
    End Property

    Private _DireccionCliente As String
    Public Property DireccionCliente() As String
        Get
            Return _DireccionCliente
        End Get
        Set(ByVal value As String)
            _DireccionCliente = value
        End Set
    End Property

    Private _TelefonoCliente As String
    Public Property TelefonoCliente() As String
        Get
            Return _TelefonoCliente
        End Get
        Set(ByVal value As String)
            _TelefonoCliente = value
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
