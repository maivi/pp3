Imports MySql.Data.MySqlClient

Public Class frmVistaVentas
    Dim MySql As New Utilidades_MySQL
    Private ID As New Integer

    Private Sub frmVistaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tablaVenta As New DataTable
        'MySql.MiComandoSQL("SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta as Precio, Stock, Activo FROM producto WHERE activo=1", tablaProducto)
        MySql.MiComandoSQL("SELECT IdVenta,c.NombreCliente, u.Nombre as Usuario, tp.Nombre as TipoDePago, v.CantidadEfectivo, v.CantidadCuentaCorriente, v.Total, v.Fecha FROM venta v LEFT JOIN cliente c ON c.IdCliente=v.Cliente LEFT JOIN usuario u ON v.Usuario=u.IdUsuario LEFT JOIN tipopago tp ON v.TipoPago=tp.IdTipoPago", tablaVenta)
        bsVenta.DataSource = tablaVenta
        dgvVentas.DataSource = bsVenta.DataSource
        Me.WindowState = FormWindowState.Maximized
        dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetalleVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVentas.Columns("IdVenta").Visible = False
    End Sub

    Private Sub dgvVentas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        Dim tablaDetalleVenta As New DataTable
        ID = dgvVentas.SelectedCells.Item(0).Value

        MySql.MiComandoSQL("SELECT IdDetalleVenta, prod.CodigoProducto AS Codigo, prod.NombreProducto AS Nombre, CantidadProducto AS Cantidad, TotalProducto AS Total FROM detalleventa dv LEFT JOIN producto prod ON prod.IdProducto=dv.Producto WHERE VentaAsociada='" & ID & "';", tablaDetalleVenta)
        bsDetalleVenta.DataSource = tablaDetalleVenta
        dgvDetalleVentas.DataSource = bsDetalleVenta.DataSource
    End Sub

End Class