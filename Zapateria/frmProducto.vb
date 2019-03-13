Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class frmProducto
    Private MySql As New Utilidades_MySQL
    Private Producto As New clsProducto
    Private Producto2 As New clsProducto
    Private idProducto As Integer
    Private idTipoProducto As Integer
    Private idProveedor As Integer
    Private NombreProducto As String
    Private sqlComando As String



    Private Sub frmProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardgProducto()
        dgvProducto.Columns("activo").Visible = False
        dgvProducto.Columns("IdProducto").Visible = False
        dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        btnEliminar.Visible = False

    End Sub

    Private Function isNumberFloat(ByVal e)
        Return (Asc(e.KeyChar) <> 8 And (Asc(e.KeyChar) < 44 Or (Asc(e.KeyChar) > 44 And Asc(e.KeyChar) < 46) Or (Asc(e.KeyChar) > 46 And Asc(e.KeyChar) < 48) Or Asc(e.KeyChar) > 57))
    End Function

    Private Function isNumberInteger(ByVal e)
        Return (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57)
    End Function

    Private Sub txtTipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipo.GotFocus
        llenardgCategoria()
    End Sub

    Private Sub txtProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedor.GotFocus
        llenardgProveedor()
    End Sub

    Private Sub llenardgProducto()
        panelCategoria.Hide()
        panelProveedor.Hide()
        Dim tablaProducto As New DataTable
        MySql.MiComandoSQL("SELECT p.IdProducto, p.CodigoProducto as Codigo, p.GeneroProducto as Genero, NombreProducto as Producto, p.TalleProducto as Talle, tp.TipoProducto as tipo, NombreProveedor as Proveedor, p.PrecioCompra, p.PrecioVenta, p.Stock, p.Activo FROM producto p LEFT JOIN proveedor prov ON p.Proveedor=prov.IdProveedor LEFT JOIN tipoproducto tp ON p.TipoProducto=tp.IdTipoProducto WHERE p.activo=1", tablaProducto)
        'MySql.MiComandoSQL("SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta, Stock, Activo FROM producto WHERE activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto

        'Dim string As String = "(SELECT NombreProveedor FROM proveedor WHERE idProveedor=" & Proveedor & ";)"
        dgvProducto.DataSource = bsProductos.DataSource

    End Sub

    Private Sub llenardgCategoria()
        Dim tablaCategoria As New DataTable
        panelCategoria.Show()
        panelProveedor.Hide()
        panelProducto.Hide()

        MySql.MiComandoSQL("SELECT IdTipoProducto, TipoProducto as Nombre FROM tipoproducto WHERE activo=1", tablaCategoria)
        bsCategoria.DataSource = tablaCategoria
        dgvTipo.DataSource = bsCategoria.DataSource
        dgvTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTipo.Columns("IdTipoProducto").Visible = False
    End Sub

    Private Sub llenardgProveedor()
        Dim tablaProveedor As New DataTable
        panelProveedor.Show()
        panelCategoria.Hide()
        panelProducto.Hide()

        MySql.MiComandoSQL("SELECT IdProveedor, CUIT, NombreProveedor as Nombre, DireccionProveedor as Direccion, TelefonoProveedor as Telefono, PaginaWebProveedor as 'Pagina Web', Activo FROM proveedor WHERE activo=1", tablaProveedor)
        bsProveedor.DataSource = tablaProveedor
        dgvProveedor.DataSource = bsProveedor.DataSource
        dgvProveedor.Columns("idproveedor").Visible = False
        dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProveedor.Columns("activo").Visible = False
    End Sub


    Private Sub dgvTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        Dim Tipo As New clsTipo

        txtTipo.Text = dgvTipo.SelectedCells.Item(1).Value
        idTipoProducto = dgvTipo.SelectedCells.Item(0).Value
        'idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        sqlComando = "SELECT * FROM tipoproducto WHERE IdTipoProducto=" & idTipoProducto.ToString & ";"
        MySql.MiComandoSQL(sqlComando, Tipo)
    End Sub


    Private Sub dgvProveedor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedor.CellClick
        Dim Proveedor As New clsProveedor

        txtProveedor.Text = dgvProveedor.SelectedCells.Item(2).Value
        idProveedor = dgvProveedor.SelectedCells.Item(0).Value
        sqlComando = "SELECT * FROM proveedor WHERE IdProveedor=" & idProveedor.ToString & ";"
        MySql.MiComandoSQL(sqlComando, Proveedor)

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim consulta As String

        'If txtCodigo.Text = "" Then
        '    MsgBox("Ingrese un código para el producto", MsgBoxStyle.Information, "Guardar Producto")
        '    txtCodigo.Focus()
        '    Exit Sub
        'ElseIf cboGenero.Text.Length = 0 Then
        '    MsgBox("Seleccione el Género del calzado ", MsgBoxStyle.Information, "Guardar Producto")
        '    cboGenero.Focus()
        '    Exit Sub
        'ElseIf txtNombre.Text = "" Then
        '    MsgBox("Ingrese la Marca del calzado", MsgBoxStyle.Information, "Guardar Producto")
        '    txtNombre.Focus()
        '    Exit Sub
        'ElseIf txtTalle.Text = "" Then
        '    MsgBox("Ingrese la Talla del calzado", MsgBoxStyle.Information, "Guardar Producto")
        '    txtTalle.Focus()
        '    Exit Sub
        'ElseIf txtTipo.Text = "" Then
        '    MsgBox("Seleccione el Tipo de calzado", MsgBoxStyle.Information, "Guardar Producto")
        '    txtTipo.Focus()
        '    Exit Sub
        'ElseIf txtProveedor.Text = "" Then
        '    MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information, "Guardar Producto")
        '    txtTipo.Focus()
        '    Exit Sub
        'ElseIf txtPreCompra.Text = "" Then
        '    MsgBox("Ingrese el Precio de Compra", MsgBoxStyle.Information, "Guardar Producto")
        '    txtTipo.Focus()
        '    Exit Sub
        'ElseIf txtPreVenta.Text = "" Then
        '    MsgBox("Ingrese el Precio de Venta", MsgBoxStyle.Information, "Guardar Producto")
        '    txtTipo.Focus()
        '    Exit Sub
        'ElseIf txtStockInicial.Text = "" Then
        '    MsgBox("Ingrese la cantidad de pares que compro", MsgBoxStyle.Information, "Guardar Producto")
        '    txtTipo.Focus()
        '    Exit Sub
        'Else

        sqlComando = "SELECT * FROM producto WHERE CodigoProducto='" & txtCodigo.Text & "';"
        MySql.MiComandoSQL(sqlComando, Producto)
        consulta = Producto.CodigoProducto
        Dim active As Integer = Producto.Activo

        Try
            If consulta = "" Then
                sqlComando = "INSERT into `zapateria`.`producto`( `CodigoProducto` , `GeneroProducto` , `NombreProducto` , `TalleProducto` , `TipoProducto` , `Proveedor`, `PrecioCompra`, `PrecioVenta`,`Stock`, `Activo`) VALUES ('" & txtCodigo.Text & "','" & cboGenero.Text & "','" & txtNombre.Text & "','" & txtTalle.Text & "'," & idTipoProducto.ToString & "," & idProveedor.ToString & ",'" & txtPreCompra.Text & "','" & txtPreVenta.Text & "','" & txtStockInicial.Text & "',1);"
                MySql.MiComandoSQL(sqlComando)
                MsgBox("El Producto " & txtNombre.Text & " ha sido dado de alta ", MessageBoxIcon.Information)
                llenardgProducto()
                limpiar()
                dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                If active = 1 Then
                    MsgBox("Esta Codigo ya existe en la base de datos")
                    txtCodigo.Focus()
                Else
                    Dim result As Integer = MessageBox.Show("¿El código contiene información asociada. Desea recuperarla?", "Registro de Productos", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then
                        'sqlComando = "UPDATE `zapateria`.`cliente` SET Activo=1 WHERE DocumentoCliente=" & consulta & ";"
                        If MySql.MiComandoSQL("`zapateria`.`producto`", "Activo=1", "CodigoProducto='" & consulta & "'") Then
                            MsgBox("El Producto de marca " & txtNombre.Text & " ha sido recuperado!")
                            llenardgProducto()
                            limpiar()
                        Else
                            MsgBox("Hubo un error recuperando la información del Producto de marca " & txtNombre.Text & "!")
                        End If
                    Else
                        txtCodigo.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'End If
    End Sub

    Private Sub limpiar()
        panelProducto.Show()
        txtNombre.Text = ""
        txtCodigo.Text = ""
        txtPreCompra.Text = ""
        txtPreVenta.Text = ""
        txtProveedor.Text = ""
        txtStockInicial.Text = ""
        txtTalle.Text = ""
        txtTipo.Text = ""
        dgvProducto.Columns("activo").Visible = False
        dgvProducto.Columns("IdProducto").Visible = False
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        panelCategoria.Hide()
        panelProveedor.Hide()
    End Sub

    Private Sub dgvProducto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellClick

        txtCodigo.Text = dgvProducto.SelectedCells.Item(1).Value
        cboGenero.Text = dgvProducto.SelectedCells.Item(2).Value
        txtNombre.Text = dgvProducto.SelectedCells.Item(3).Value
        txtTalle.Text = dgvProducto.SelectedCells.Item(4).Value
        txtTipo.Text = dgvProducto.SelectedCells.Item(5).Value
        txtProveedor.Text = dgvProducto.SelectedCells.Item(6).Value
        txtPreCompra.Text = dgvProducto.SelectedCells.Item(7).Value
        txtPreVenta.Text = dgvProducto.SelectedCells.Item(8).Value
        txtStockInicial.Text = dgvProducto.SelectedCells.Item(9).Value

        btnGuardar.Visible = False
        btnActualizar.Visible = True
        txtStockInicial.Enabled = False
        btnEliminar.Visible = True
        idProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(0).Value
        Producto.idProducto = idProducto
        sqlComando = "SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta, Stock, Activo FROM producto WHERE IdProducto='" & Producto.idProducto & "';"
        MySql.MiComandoSQL(sqlComando, Producto)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Resultado As Short
        idProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(0).Value
        NombreProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(3).Value

        Resultado = MsgBox("Desea borrar el producto : " & NombreProducto, MsgBoxStyle.YesNo)
        Try
            If (Resultado = DialogResult.Yes) Then

                sqlComando = "Update producto set activo=0 where IdProducto='" & idProducto & "';"
                MySql.MiComandoSQL(sqlComando)
                MsgBox("El Producto " & NombreProducto & " ha sido dado de baja", MsgBoxStyle.Exclamation)
            Else
                MsgBox("El Producto " & NombreProducto & " no ha sido dado de baja", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        llenardgProducto()
        btnActualizar.Visible = False
        btnGuardar.Visible = True
        btnEliminar.Visible = False
        limpiar()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Producto2.idProducto = Producto.idProducto
        Producto2.CodigoProducto = txtCodigo.Text
        Producto2.GeneroProducto = cboGenero.Text
        Producto2.NombreProducto = txtNombre.Text
        Producto2.TalleProducto = txtTalle.Text
        Producto2.TipoProducto = txtTipo.Text
        Producto2.Proveedor = txtProveedor.Text
        Producto2.PrecCompra = txtPreCompra.Text
        Producto2.PrecVenta = txtPreVenta.Text
        Producto2.Stock = txtStockInicial.Text
        Producto2.Activo = Producto.Activo

        sqlComando = MySql.MiComandoSQL("producto", Producto2, Producto)

        If MySql.MiComandoSQL(sqlComando) Then
            MsgBox("El Producto ha sido actualizado")
        Else
            MsgBox("No Se registraron modificaciones")
        End If
        btnEliminar.Visible = False
        llenardgProducto()
        limpiar()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
        btnEliminar.Visible = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cboGenero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGenero.SelectedIndexChanged

    End Sub

    Private Sub txtTipo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipo.TextChanged

    End Sub

    Private Sub txtPreCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreCompra.KeyPress
        e.Handled = isNumberFloat(e)
    End Sub



    Private Sub txtPreCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPreCompra.TextChanged

    End Sub

    Private Sub txtPreVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreVenta.KeyPress
        e.Handled = isNumberFloat(e)
    End Sub


    Private Sub txtStockInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStockInicial.KeyPress
        e.Handled = isNumberInteger(e)
    End Sub
End Class