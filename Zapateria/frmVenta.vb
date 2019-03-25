Imports MySql.Data.MySqlClient

Public Class frmVenta
    Dim MySql As New Utilidades_MySQL
    Dim idProducto As Integer
    Dim NombreProducto As String
    Dim sqlComando As String

    Dim Producto As New clsProducto
    Dim Cliente As New clsContactos
    Dim Venta As New clsVentas
    Dim DetalleVenta As New clsDetalleVentas
    Dim CuentaCorriente As New clsCuentaCorriente

    Dim Productos As New List(Of clsProducto)
    Dim cantStockArray As New List(Of Integer)
    Dim productsId As New List(Of Integer)

    Dim cantStockSelected As New Integer
    Dim cantStock As New Integer
    Dim idCliente As New Integer
    Dim TipoPago As New Integer
    Dim TotalCompra As New Double

    Dim isAdded As Boolean = False
    Dim isClientSelected As Boolean = False
    Dim isProductSelected As Boolean = False
    Dim isInfoCashStablished As Boolean = False

    Dim StatusSQL As Integer = 0

    Private Sub frmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cantStock = -1
        cantStockSelected = -1
        TotalCompra = 0.0
        llenarProducto()
        dgvProducto.Columns("IdProducto").Visible = False
        dgvProducto.Columns("PrecioCompra").Visible = False
        dgvProducto.Columns("Activo").Visible = False
        dgvProducto.Columns("Stock").Visible = False
        txtTotalVenta.Text = "0"
    End Sub

    Private Function controlTrueValue()
        Return (isAdded And isClientSelected And isProductSelected And isInfoCashStablished)
    End Function

    Private Sub resetControls()
        isAdded = False
        isClientSelected = False
        isProductSelected = False
        isInfoCashStablished = False
    End Sub

    Private Sub llenarProducto()
        Dim tablaProducto As New DataTable
        MySql.MiComandoSQL("SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta as Precio, Stock, Activo FROM producto WHERE activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto
        dgvProducto.DataSource = bsProductos.DataSource
    End Sub


    Private Sub dgvProducto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellClick
        txtCodigoProducto.Text = dgvProducto.SelectedCells.Item(1).Value
        txtNombreProducto.Text = dgvProducto.SelectedCells.Item(3).Value
        txtTalleProducto.Text = dgvProducto.SelectedCells.Item(4).Value
        txtPrecioProducto.Text = dgvProducto.SelectedCells.Item(8).Value

        If Me.cantStock = -1 Then
            Me.cantStock = Integer.Parse(dgvProducto.SelectedCells.Item(9).Value)
        End If

        txtCantidad.Text = ""

        idProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(0).Value
        Producto.IdProducto = idProducto
        sqlComando = "SELECT * FROM producto WHERE IdProducto='" & Producto.IdProducto & "';"
        MySql.MiComandoSQL(sqlComando, Producto)
        txtCantidad.Enabled = True
        btnGuardar.Enabled = controlTrueValue()
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = Utils.isNumberInteger(e)
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text = "" Or txtPrecioProducto.Text = "" Then
            btnAgregarProducto.Enabled = False
            txtTotalProducto.Text = 0
            Exit Sub
        End If
        If (Integer.Parse(txtCantidad.Text) > cantStock) Then
            txtCantidad.Text = cantStock
        End If
        btnAgregarProducto.Enabled = True
        Dim total As Integer = CInt(txtCantidad.Text) * CInt(txtPrecioProducto.Text)
        isProductSelected = True
        txtTotalProducto.Text = total
        btnGuardar.Enabled = controlTrueValue()
    End Sub

    Private Sub btnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click
        If txtCantidad.Text = "" Then
            txtCantidad.Text = 0
        End If

        If txtCantidad.Text < 1 Then
            MsgBox("Debe seleccionar minimo un producto", vbInformation, "Atención")
            txtCantidad.Focus()
        Else
            Dim Valor, cantidad As Integer
            Dim resultado, resultadoTotal As Integer

            If txtCantidad.Text = "" Then
                txtTotalProducto.Text = 0
            Else
                Valor = txtPrecioProducto.Text
                cantidad = txtCantidad.Text

                If cantidad > 0 Then
                    resultado = Valor * cantidad
                    txtTotalProducto.Text = resultado
                    resultadoTotal = txtTotalVenta.Text
                    txtTotalVenta.Text = resultado + resultadoTotal
                Else
                    txtTotalProducto.Text = ""
                End If
            End If
            dgvVenta.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtTalleProducto.Text, txtPrecioProducto.Text, txtCantidad.Text, txtTotalProducto.Text)
            cantStockSelected = Integer.Parse(txtCantidad.Text)
            cantStockArray.Add(cantStockSelected)
            Productos.Add(Producto)
            Producto = New clsProducto
            TotalCompra = TotalCompra + Double.Parse(txtTotalProducto.Text)
            If (txtPago.Text <> "") Then
                If TotalCompra < Double.Parse(txtPago.Text) Then
                    txtCambioPago.Text = Math.Abs(TotalCompra - Double.Parse(txtPago.Text))
                Else
                    txtCambioPago.Text = 0
                End If
            End If
            

            txtCantidad.Text = ""
            txtCantidad.Enabled = False
            limpiarProducto()
            isAdded = True
            btnGuardar.Enabled = controlTrueValue()



        End If
    End Sub

    Private Sub limpiarProducto()
        txtCantidad.Text = ""
        txtCodigoProducto.Text = ""
        txtTalleProducto.Text = ""
        txtNombreProducto.Text = ""
        txtTotalProducto.Text = ""
        txtPrecioProducto.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Dim tablaContactos As New DataTable

        MySql.MiComandoSQL("SELECT IdCliente, TipoDocumento, DocumentoCliente as Documento, NombreCliente  as Nombre, DireccionCliente as Direccion, TelefonoCliente as Telefono, Activo FROM cliente WHERE activo=1", tablaContactos)

        bsCliente.DataSource = tablaContactos
        dgvCliente.DataSource = bsCliente.DataSource
        dgvCliente.Columns("IdCliente").Visible = False
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNombreCliente.Text = "" Then
            txtNombreCliente.Select()
            ObtenerDatos()
        Else
            Dim tablaClientes As New DataTable

            MySql.MiComandoSQL("SELECT * FROM cliente WHERE NombreCliente Like'%" & txtNombreCliente.Text & "%' and activo=1 || DocumentoCliente Like'%" & txtNombreCliente.Text & "%' and activo=1", tablaClientes)
            bsCliente.DataSource = tablaClientes
            dgvCliente.DataSource = bsCliente.DataSource

        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub txtNombreCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreCliente.Click
        dgvCliente.Visible = True
        dgvProducto.Visible = False
        Label13.Text = "Clientes"
        Nombre.Visible = False
        TextBox5.Visible = False
        ObtenerDatos()
    End Sub

    Private Sub dgvCliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellClick
        'Dim Clientes As New clsContactos

        txtNombreCliente.Text = dgvCliente.SelectedCells.Item(3).Value
        txtDocumentoCliente.Text = dgvCliente.SelectedCells.Item(2).Value
        idCliente = dgvCliente.SelectedCells.Item(0).Value
        txtDireccionCliente.Text = dgvCliente.SelectedCells.Item(4).Value
        txtTelefonoCliente.Text = dgvCliente.SelectedCells.Item(5).Value
        'idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        sqlComando = "SELECT * FROM cliente WHERE IdCliente=" & idCliente.ToString & ";"
        MySql.MiComandoSQL(sqlComando, Cliente)

        dgvCliente.Visible = False
        dgvProducto.Visible = True
        Label13.Text = "Productos"
        Nombre.Visible = True
        TextBox5.Visible = True
        isClientSelected = True
        btnGuardar.Enabled = controlTrueValue()
        Venta.IdCliente = Cliente.IdCliente
    End Sub

    Private Sub txtNombreCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreCliente.LostFocus

    End Sub

    Private Sub txtNombreCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreCliente.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim tablaProductos As New DataTable
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM producto WHERE NombreProducto Like'%" & TextBox5.Text & "%' and activo=1 || TalleProducto Like'%" & TextBox5.Text & "%' and activo=1"
        MySql.MiComandoSQL(consultaSQL, tablaProductos)
        bsProductos.DataSource = tablaProductos
        dgvProducto.DataSource = bsProductos.DataSource
    End Sub

    Private Sub cbxFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFormaPago.SelectedIndexChanged
        If ((txtPago.Text <> "") And (txtCajaAhorro.Text <> "") And (txtCambioPago.Text <> "")) Then
            isInfoCashStablished = True
            btnGuardar.Enabled = controlTrueValue()
        End If

        If (cbxFormaPago.SelectedItem.Equals("Contado")) Then
            txtCambioPago.Text = 0
            txtCajaAhorro.Text = 0
            txtCajaAhorro.Enabled = False
            TipoPago = 0
        Else
            TipoPago = 1
            txtCambioPago.Text = 0
        End If
        Venta.IdTipoPago = TipoPago
    End Sub

    Private Sub txtPago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPago.TextChanged
        If (cbxFormaPago.SelectedIndex = 0) Then
            If (TotalCompra <> 0.0) Then
                If txtPago.Text <> "" Then
                    If TotalCompra < Double.Parse(txtPago.Text) Then
                        txtCambioPago.Text = Math.Abs(TotalCompra - Double.Parse(txtPago.Text))
                    Else
                        txtCambioPago.Text = 0
                    End If
                Else
                    txtCambioPago.Text = 0
                End If
                
            End If
        Else
            If (TotalCompra <> 0.0) Then
                If txtPago.Text <> "" Then
                    If TotalCompra > Double.Parse(txtPago.Text) Then
                        txtCajaAhorro.Text = Math.Abs(TotalCompra - Double.Parse(txtPago.Text))
                    Else
                        txtCajaAhorro.Text = TotalCompra
                    End If
                Else
                    txtCajaAhorro.Text = TotalCompra
                End If
            End If
        End If
        If ((txtPago.Text <> "") And (txtCajaAhorro.Text <> "") And (txtCambioPago.Text <> "")) Then
            isInfoCashStablished = True
            btnGuardar.Enabled = controlTrueValue()
        End If
    End Sub

    Private Sub txtCajaAhorro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCajaAhorro.TextChanged
        If ((txtPago.Text <> "") And (txtCajaAhorro.Text <> "") And (txtCambioPago.Text <> "")) Then
            isInfoCashStablished = True
            btnGuardar.Enabled = controlTrueValue()
        End If
    End Sub

    Private Sub txtCambioPago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCambioPago.TextChanged
        If ((txtPago.Text <> "") And (txtCajaAhorro.Text <> "") And (txtCambioPago.Text <> "")) Then
            isInfoCashStablished = True
            btnGuardar.Enabled = controlTrueValue()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Venta.Total = Double.Parse(txtTotalVenta.Text)
        Venta.CantidadCuentaCorriente = Double.Parse(txtCajaAhorro.Text)
        Venta.CantidadEfectivo = Double.Parse(txtPago.Text)
        Venta.IdUsuario = Integer.Parse(lblID.Text)
        Dim Hora As String = Date.Now.Hour
        Dim Minutos As String = Date.Now.Minute
        Dim Segundos As String = Date.Now.Second

        Dim Dia As String = Date.Now.Day
        Dim Mes As String = Date.Now.Month

        If (Dia < 10) Then
            If Not Dia.Contains(0) Then
                Dia = "0" & Dia
            End If
        End If

        If (Mes < 10) Then
            If Not Mes.Contains(0) Then
                Mes = "0" & Mes
            End If
        End If

        If (Hora < 10) Then
            If Not Hora.Contains(0) Then
                Hora = "0" & Hora
            End If
        End If

        If (Minutos < 10) Then
            If Not Minutos.Contains(0) Then
                Minutos = "0" & Minutos
            End If
        End If

        If (Segundos < 10) Then
            If Not Segundos.Contains(0) Then
                Segundos = "0" & Segundos
            End If
        End If

        Venta.Fecha = Date.Now.Year & "/" & Mes & "/" & Dia & " " & Hora & ":" & Minutos & ":" & Segundos
        sqlComando = "INSERT INTO `zapateria`.`venta`(`Cliente`,`Usuario`,`TipoPago`,`CantidadEfectivo`,`CantidadCuentaCorriente`,`Total`,`Fecha`) VALUES ('" & Venta.IdCliente & "','" & Venta.IdUsuario & "','" & (Venta.IdTipoPago + 1) & "','" & Venta.CantidadEfectivo & "','" & Venta.CantidadCuentaCorriente & "','" & Venta.Total & "','" & Venta.Fecha & "' );"
        If MySql.MiComandoSQL(sqlComando) Then
            sqlComando = "SELECT * FROM `zapateria`.`venta` ORDER BY IdVenta DESC LIMIT 1"
            Dim ventas2 As New clsVentas
            Dim detalleVenta As New clsDetalleVentas
            MySql.MiComandoSQL(sqlComando, ventas2)

            For index As Integer = 0 To Productos.Count - 1
                detalleVenta.IdVentaAsociada = ventas2.IdVentas
                detalleVenta.IdProducto = Productos.Item(index).IdProducto
                detalleVenta.CantProducto = cantStockArray.Item(index)
                detalleVenta.TotalProducto = Double.Parse(Productos.Item(index).PrecVenta) * detalleVenta.CantProducto

                sqlComando = "INSERT INTO `zapateria`.`detalleventa`(`VentaAsociada`,`Producto`,`CantidadProducto`,`TotalProducto`) VALUES ('" & detalleVenta.IdVentaAsociada & "','" & detalleVenta.IdProducto & "','" & detalleVenta.CantProducto & "','" & detalleVenta.TotalProducto & "' );"
                StatusSQL = MySql.MiComandoSQL(sqlComando)

                sqlComando = "SELECT * FROM `zapateria`.`producto` WHERE IdProducto = '" & detalleVenta.IdProducto & "';"
                MySql.MiComandoSQL(sqlComando, Producto)
                Dim restaStock = Integer.Parse(Producto.Stock) - Integer.Parse(detalleVenta.CantProducto)

                If MySql.MiComandoSQL("producto", "Stock=" & restaStock, "IdProducto=" & detalleVenta.IdProducto) Then

                End If

            Next

            If (StatusSQL) Then
                If (TipoPago = 1) Then
                    'txtCajaAhorro.Text
                    'sqlComando = "INSERT INTO `zapateria`.`cuentacorriente`(Activo)"
                    sqlComando = "SELECT * FROM `zapateria`.`cuentacorriente` WHERE IdCliente='" & Venta.IdCliente & "';"
                    MySql.cantReg(sqlComando)
                    If MySql.cantReg(sqlComando) > 0 Then
                        'Si existe ya la cuenta corriente solo le actualizamos el valor
                        sqlComando = "SELECT * FROM `zapateria`.`cuentacorriente` WHERE IdCliente='" & Venta.IdCliente & "';"
                        MySql.MiComandoSQL(sqlComando, CuentaCorriente)
                        Dim deuda As Double = Double.Parse(CuentaCorriente.Deuda)
                        Dim saldoPrevio As Double = deuda
                        Dim movimiento As Double = Venta.CantidadCuentaCorriente
                        deuda = deuda + Venta.CantidadCuentaCorriente
                        If MySql.MiComandoSQL("cuentacorriente", "Deuda=" & deuda, "IdCliente=" & Venta.IdCliente) Then
                            'Aca ingresamos los datos del movimiento de la cuenta corriente
                            sqlComando = "INSERT INTO `zapateria`.`movimientos_cc`(`idCC`,`SaldoPrevio`,`SaldoCalculado`,`Movimiento`,`FechaActualizacion`) VALUES ('" & CuentaCorriente.IdCuentaCorriente & "','" & saldoPrevio & "','" & deuda & "', '" & movimiento & "', '" & Venta.Fecha & "');"
                            StatusSQL = MySql.MiComandoSQL(sqlComando)
                        End If
                    Else
                        'Si la cuenta no existe la creamos
                        sqlComando = "INSERT INTO `zapateria`.`cuentacorriente`(`Activo`,`IdCliente`,`Deuda`) VALUES ('1','" & Venta.IdCliente & "','" & Venta.CantidadCuentaCorriente & "');"
                        If MySql.MiComandoSQL(sqlComando) Then
                            'Aca ingresamos los datos del movimiento de la cuenta corriente

                            'hacer el select 1 para sacar el ID
                            sqlComando = "SELECT * FROM `zapateria`.`cuentacorriente` ORDER BY IdCuentaCorriente DESC LIMIT 1"
                            CuentaCorriente = New clsCuentaCorriente
                            MySql.MiComandoSQL(sqlComando, CuentaCorriente)

                            sqlComando = "INSERT INTO `zapateria`.`movimientos_cc`(`idCC`,`SaldoPrevio`,`SaldoCalculado`,`Movimiento`,`FechaActualizacion`) VALUES ('" & CuentaCorriente.IdCuentaCorriente & "','0','" & Venta.CantidadCuentaCorriente & "', '" & Venta.CantidadCuentaCorriente & "', '" & Venta.Fecha & "');"
                            StatusSQL = MySql.MiComandoSQL(sqlComando)
                        End If
                    End If
                End If
                MsgBox("La venta fue almacenada satisfactoriamente")
                Me.Dispose()
            Else
                MsgBox("La venta fallo al almacenarse")
            End If


        End If

    End Sub
End Class