Imports MySql.Data.MySqlClient
Imports System.Windows.Forms


Public Class frmVenta

    Dim MySql As New Utilidades_MySQL
    Dim idProducto As Integer
    Dim NombreProducto As String
    Dim sqlComando As String
    Dim Producto As New clsProducto
    Dim ventas As New clsVantas
    Dim Contacto As New clsContactos


    Private Sub frmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet1.tipopago' Puede moverla o quitarla según sea necesario.
        Me.TipopagoTableAdapter.Fill(Me.ZapateriaDataSet1.tipopago)

        llenarProducto()
        dgvProducto.Columns("IdProducto").Visible = False
        dgvProducto.Columns("PrecioCompra").Visible = False
        dgvProducto.Columns("Activo").Visible = False
        txtTotalVenta.Text = "0"
        txtArticulos.Text = "0"
        lblFecha.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        lblFecha.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        Dim Usuario As String
        sqlComando = "SELECT * FROM cliente WHERE DocumentoCliente='" & txtDocumentoCliente.Text & "';"
        MySql.MiComandoSQL(sqlComando, Contacto)

        If txtDocumentoCliente.Text = Contacto.DocumentoCliente Then
            Usuario = Contacto.IdCliente
            txtDocumentoCliente.Text = Contacto.DocumentoCliente
            txtNombreCliente.Text = Contacto.NombreCliente
            txtDireccionCliente.Text = Contacto.DireccionCliente
            txtTelefonoCliente.Text = Contacto.TelefonoCliente

        Else

            txtNombreCliente.Text = ""
            txtDireccionCliente.Text = ""
            txtTelefonoCliente.Text = ""
        End If
    End Sub



    Private Sub llenarProducto()
        Dim tablaProducto As New DataTable
        MySql.MiComandoSQL("SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta as Precio, Stock, Activo FROM producto WHERE activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto
        dgvProducto.DataSource = bsProductos.DataSource
    End Sub


    Private Sub dgvProducto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.CellClick
        lblIdProducto.Text = dgvProducto.SelectedCells.Item(0).Value
        txtCodigoProducto.Text = dgvProducto.SelectedCells.Item(1).Value
        txtNombreProducto.Text = dgvProducto.SelectedCells.Item(3).Value
        txtTalleProducto.Text = dgvProducto.SelectedCells.Item(4).Value
        txtPrecioProducto.Text = dgvProducto.SelectedCells.Item(8).Value
        txtStock.Text = dgvProducto.SelectedCells.Item(9).Value
        txtCantidad.Text = ""
        txtCantidad.Focus()

        idProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(0).Value
        Producto.idProducto = idProducto
        sqlComando = "SELECT * FROM producto WHERE idProducto='" & Producto.idProducto & "';"
        MySql.MiComandoSQL(sqlComando, Producto)

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If CInt(AscW(e.KeyChar)) = CInt(Keys.Enter) Then

            If txtCantidad.Text = "" Then
                txtCantidad.Text = 0
            End If

            If txtCantidad.Text < 1 Then
                MsgBox("Debe seleccionar minimo un producto", vbInformation, "Atención")
                txtCantidad.Focus()
            Else
                Dim Valor, cantidad, articulos As Integer
                Dim resultado, resultadoTotal As Integer

                If txtCantidad.Text = "" Then
                    txtTotalProducto.Text = 0
                Else
                    Valor = txtPrecioProducto.Text
                    cantidad = txtCantidad.Text

                    If cantidad > 0 Then
                        resultado = Valor * cantidad
                        articulos = txtArticulos.Text
                        txtTotalProducto.Text = resultado
                        resultadoTotal = txtTotalVenta.Text
                        txtTotalVenta.Text = resultado + resultadoTotal
                        txtCambioPago.Text = txtTotalVenta.Text
                        txtArticulos.Text = articulos + cantidad
                    Else
                        txtTotalProducto.Text = ""

                    End If
                End If
                dgvVenta.Rows.Add(lblIdProducto.Text, txtCodigoProducto.Text, txtNombreProducto.Text, txtTalleProducto.Text, txtPrecioProducto.Text, txtCantidad.Text, txtTotalProducto.Text)
                txtCantidad.Text = 0
                txtCantidad.Select()
                limpiarProducto()

            End If
        End If
    End Sub



    Private Sub txtCantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text = "" Or txtPrecioProducto.Text = "" Then

            txtTotalProducto.Text = 0
            Exit Sub

        End If

        Dim total As Integer = CInt(txtCantidad.Text) * CInt(txtPrecioProducto.Text)

        txtTotalProducto.Text = total
    End Sub

    Private Sub btnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click
        If txtCantidad.Text = "" Then
            txtCantidad.Text = 0
        End If

        If txtCantidad.Text < 1 Then
            MsgBox("Debe seleccionar minimo un producto", vbInformation, "Atención")
            txtCantidad.Focus()
        Else
            Dim Valor, cantidad, articulos As Integer
            Dim resultado, resultadoTotal As Integer

            If txtCantidad.Text = "" Then
                txtTotalProducto.Text = 0
            Else
                Valor = txtPrecioProducto.Text
                cantidad = txtCantidad.Text

                If cantidad > 0 Then
                    resultado = Valor * cantidad
                    articulos = txtArticulos.Text
                    txtTotalProducto.Text = resultado
                    resultadoTotal = txtTotalVenta.Text
                    txtTotalVenta.Text = resultado + resultadoTotal
                    txtCambioPago.Text = txtTotalVenta.Text
                    txtArticulos.Text = articulos + cantidad
                Else
                    txtTotalProducto.Text = ""

                End If
            End If
            dgvVenta.Rows.Add(lblIdProducto.Text, txtCodigoProducto.Text, txtNombreProducto.Text, txtTalleProducto.Text, txtPrecioProducto.Text, txtCantidad.Text, txtTotalProducto.Text)
            txtCantidad.Text = 0
            txtCantidad.Select()
            limpiarProducto()

        End If
    End Sub






    Private Sub limpiarProducto()
        txtCantidad.Text = ""
        txtCodigoProducto.Text = ""
        txtTalleProducto.Text = ""
        txtNombreProducto.Text = ""
        txtTotalProducto.Text = ""
        txtPrecioProducto.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub txtDescuento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuento.TextChanged
        If txtDescuento.Text = "" Or txtTotalVenta.Text = "" Then
            txtTotalVenta.Text = 0
            Exit Sub

        End If
        Dim totalDescuento As Integer
        Dim TotalVenta As Integer
        totalDescuento = CInt(txtDescuento.Text) * CInt(txtTotalVenta.Text) / (100)
        TotalVenta = txtTotalVenta.Text
        txtTotalVenta.Text = TotalVenta - totalDescuento

    End Sub

    Private Sub chBoxDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chBoxDescuento.CheckedChanged

        If chBoxDescuento.CheckState = CheckState.Checked Then
            txtDescuento.Enabled = True
        Else
            txtDescuento.Enabled = False
        End If

    End Sub



    Private Sub txtPago_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPago.TextChanged

        If txtPago.Text = "" Or txtTotalVenta.Text = "" Then

            txtPago.Text = "0"
            Exit Sub

        End If

        Dim total As Integer = CInt(txtTotalVenta.Text) - CInt(txtPago.Text)

        txtCambioPago.Text = total

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiarProducto()
        dgvVenta.Rows.Clear()
    End Sub


    Private Sub btnBorrarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarProducto.Click
        Dim valor1, valor2, articulo1, articulo2 As New Integer

        For Each r As DataGridViewRow In dgvVenta.SelectedRows
            articulo1 = dgvVenta.Rows(dgvVenta.CurrentRow.Index).Cells(4).Value
            articulo2 = txtArticulos.Text
            valor1 = dgvVenta.Rows(dgvVenta.CurrentRow.Index).Cells(5).Value
            valor2 = txtTotalVenta.Text
            dgvVenta.Rows.Remove(r)

        Next
        txtCambioPago.Text = valor2 - valor1
        txtArticulos.Text = articulo2 - articulo1

        txtTotalVenta.Text = valor2 - valor1

    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim id As Integer
        sqlComando = "SELECT MAX(IdVenta) FROM venta"
        MySql.MiComandoSQL(sqlComando, ventas)
        id = ventas.IdVentas + 1
        MsgBox(id)
        'If txtTotalVenta.Text = "" Then
        Dim idventa As String = ""
        Dim cliente As String = ""
        Dim usuario As String = ""
        Dim articulos As String = ""
        Dim total As String = ""
        Dim TipoPago As String = ""
        Dim fecha As String = ""

        idventa = id
        cliente = txtDocumentoCliente.Text
        usuario = lblCajero.Text
        articulos = txtArticulos.Text
        total = txtTotalVenta.Text
        TipoPago = cbxFormaPago.Text
        fecha = DateTime.Now.ToString("yyyy/MM/dd")


        sqlComando = "INSERT into `zapateria`. `venta` VALUES ('" & idventa & "','" & cliente & "','" & usuario & "','" & articulos & "','" & total & "','" & TipoPago & "','" & fecha & "')"
        MySql.MiComandoSQL(sqlComando, Producto)
        MsgBox(sqlComando)

        For Each Row As DataGridViewRow In dgvVenta.Rows

            Dim Venta As String = idventa
            Dim producto As String = Row.Cells(0).Value
            Dim cantidad As String = Row.Cells(5).Value
            Dim Valor As Double = Row.Cells(4).Value
            Dim ValorFinal As Double = Row.Cells(6).Value

            fecha = DateTime.Now.ToString("yyyy/MM/dd")

            sqlComando = "Insert into `zapateria`. `detalleventa` (Venta,Producto,CantidadProducto,ValorProducto,TotalProducto,Fecha) values ('" & Venta & "', '" & producto & "', '" & cantidad & "', '" & Valor & "', '" & ValorFinal & "','" & fecha & "')"
            MySql.MiComandoSQL(sqlComando, producto)
            MsgBox(sqlComando)


            sqlComando = "UPDATE producto SET Stock = Stock - '" & cantidad & "'  WHERE IdProducto = '" & producto & "';"
            MySql.MiComandoSQL(sqlComando, producto)
            MsgBox(sqlComando)
        Next
        dgvVenta.Rows.Clear()





        'End If
        'MsgBox("No Existen Articulos para cargar")

    End Sub

    'Public Sub GuardarDetalleVenta()

    '    Dim id As Integer
    '    sqlComando = "SELECT MAX(IdVenta) FROM venta"
    '    MySql.MiComandoSQL(sqlComando, ventas)
    '    id = ventas.IdVentas + 1
    '    MsgBox(id)

    '    For Each Row As DataGridViewRow In dgvVenta.Rows

    '        Dim Venta As String = id
    '        Dim producto As String = Row.Cells(0).Value
    '        Dim cantidad As String = Row.Cells(2).Value
    '        Dim Valor As Double = Row.Cells(3).Value
    '        Dim total As Double = Row.Cells(4).Value
    '        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")

    '        sqlComando = "Insert into detalleventa (Venta,Producto,CantidadProducto,ValorProducto,TotalProducto,Fecha) values ('" & Venta & "', '" & producto & "', '" & cantidad & "', '" & Valor & "', '" & total & "','" & fecha & "')"
    '        MySql.MiComandoSQL(sqlComando, producto)



    '        sqlComando = "UPDATE productos SET stock = stock - '" & cantidad & "'  WHERE id_productos = '" & producto & "';"
    '        MySql.MiComandoSQL(sqlComando, producto)

    '    Next
    '    dgvVenta.Rows.Clear()


    'End Sub

    'Public Sub GuardarVenta()
    'Dim cantidad As Double
    'If txtCantidadProductos.Text = "" Then
    '    txtCantidadProductos.Text = 0
    'Else
    '    cantidad = Convert.ToDouble(txtCantidadProductos.Text)
    'End If

    'If cantidad < 1 Then
    '    MsgBox("Debe haber minimo un producto para poder realizar la venta", vbInformation, "Atención")
    '    txtCantidad1.Select()
    'Else

    '    Dim ID As String = ""
    '    Dim articulos As String = ""
    '    Dim total As String = ""
    '    Dim fecha As String = ""

    '    ID = lblIdUsuario.Text
    '    articulos = txtArticulos.Text
    '    total = txtTotal2.Text
    '    fecha = DateTime.Now.ToString("yyyy/MM/dd")


    '    cadena = "INSERT INTO VENTAS VALUES (0,'" & ID & "','" & articulos & "','" & total & "','" & fecha & "')"
    '    comando.MiComandoSQL(cadena)


    'End If

    'End Sub




End Class