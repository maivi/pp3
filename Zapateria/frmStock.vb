Public Class frmStock
    Dim MySql As New Utilidades_MySQL
    Dim sqlComando As String

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llenardgvAlertaStock()
        'llenardgvStock()
    End Sub

    Private Sub llenardgvAlertaStock()
        Dim tablaProducto As New DataTable

        MySql.MiComandoSQL("SELECT idProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecCompra, PrecVenta, Stock, Activo FROM producto WHERE stock < 10 and activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto
        dgvAlertaStock.DataSource = bsProductos.DataSource
        dgvAlertaStock.Columns("activo").Visible = False
        dgvAlertaStock.Columns("idProducto").Visible = False


    End Sub

    Private Sub llenardgvStock()

        Dim tablaProducto As New DataTable
        MySql.MiComandoSQL("SELECT idProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecCompra, PrecVenta, Stock, Activo FROM producto WHERE stock > 10 and activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto
        dgvStock.DataSource = bsProductos.DataSource
        dgvStock.Columns("activo").Visible = False
        dgvStock.Columns("idProducto").Visible = False
    End Sub


End Class