Imports MySql.Data.MySqlClient

Public Class frmVenta
    Dim MySql As New Utilidades_MySQL
    Dim idProducto As Integer
    Dim NombreProducto As String
    Dim sqlComando As String
    Dim Producto As New clsProducto
    Dim cantStock As New Integer
    Dim idCliente As New Integer



    Private Sub frmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cantStock = -1
        llenarProducto()
        dgvProducto.Columns("IdProducto").Visible = False
        dgvProducto.Columns("PrecioCompra").Visible = False
        dgvProducto.Columns("Activo").Visible = False
        dgvProducto.Columns("Stock").Visible = False
        txtTotalVenta.Text = "0"
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
            txtStock.Text = dgvProducto.SelectedCells.Item(9).Value
        Else
            txtStock.Text = Me.cantStock
        End If

        txtCantidad.Text = ""


        idProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(0).Value
        Producto.idProducto = idProducto
        sqlComando = "SELECT * FROM producto WHERE IdProducto='" & Producto.idProducto & "';"
        MySql.MiComandoSQL(sqlComando, Producto)

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
            txtCantidad.Text = 0
            txtCantidad.Select()
            limpiarProducto()
            'ObtenerDatos()
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

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
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
        ObtenerDatos()
    End Sub

    Private Sub dgvCliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellClick
        Dim Cliente As New clsContactos

        txtNombreCliente.Text = dgvCliente.SelectedCells.Item(3).Value
        txtDocumentoCliente.Text = dgvCliente.SelectedCells.Item(2).Value
        idCliente = dgvCliente.SelectedCells.Item(0).Value
        txtDireccionCliente.Text = dgvCliente.SelectedCells.Item(4).Value
        txtTelefonoCliente.Text = dgvCliente.SelectedCells.Item(5).Value
        'idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        sqlComando = "SELECT * FROM cliente WHERE IdCliente=" & idCliente.ToString & ";"
        MySql.MiComandoSQL(sqlComando, Cliente)
    End Sub
End Class