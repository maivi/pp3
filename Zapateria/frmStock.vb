Public Class frmStock
    Dim MySql As New Utilidades_MySQL
    Dim sqlComando As String

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardgvAlertaStock()
        llenardgvStock()
    End Sub

    Private Sub llenardgvAlertaStock()
        Dim tablaProducto As New DataTable

        MySql.MiComandoSQL("SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta, Stock, Activo FROM producto WHERE stock < 10 and activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto
        dgvAlertaStock.DataSource = bsProductos.DataSource
        dgvAlertaStock.Columns("activo").Visible = False
        dgvAlertaStock.Columns("idProducto").Visible = False


    End Sub

    Private Sub llenardgvStock()

        Dim tablaProducto As New DataTable
        MySql.MiComandoSQL("SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta, Stock, Activo FROM producto WHERE stock > 10 and activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto
        dgvStock.DataSource = bsProductos.DataSource
        dgvStock.Columns("activo").Visible = False
        dgvStock.Columns("idProducto").Visible = False
    End Sub


    Private Sub dgvStock_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStock.CellClick
        txtCodigo.Text = dgvStock.SelectedCells.Item(1).Value
        txtProducto.Text = dgvStock.SelectedCells.Item(3).Value
        txtStock.Text = dgvStock.SelectedCells.Item(9).Value
        txtPrecCompra.Text = dgvStock.SelectedCells.Item(7).Value
        txtPrecVenta.Text = dgvStock.SelectedCells.Item(8).Value
    End Sub

    Private Sub dgvAlertaStock_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlertaStock.CellClick
        txtCodigo.Text = dgvAlertaStock.SelectedCells.Item(1).Value
        txtProducto.Text = dgvAlertaStock.SelectedCells.Item(3).Value
        txtStock.Text = dgvAlertaStock.SelectedCells.Item(9).Value
        txtPrecCompra.Text = dgvAlertaStock.SelectedCells.Item(7).Value
        txtPrecVenta.Text = dgvAlertaStock.SelectedCells.Item(8).Value
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtCodigo.Text = ""
        txtProducto.Text = ""
        txtStock.Text = ""
        txtPrecCompra.Text = ""
        txtPrecVenta.Text = ""
        txtStockNuevo.Text = ""
    End Sub
End Class