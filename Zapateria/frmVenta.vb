Imports MySql.Data.MySqlClient

Public Class frmVenta
    Dim MySql As New Utilidades_MySQL
    Dim idProducto As Integer
    Dim NombreProducto As String
    Dim sqlComando As String
    Dim Producto As New clsProducto

    Private Sub frmVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarProducto()
        dgvProducto.Columns("IdProducto").Visible = False
        dgvProducto.Columns("PrecioCompra").Visible = False
        dgvProducto.Columns("Activo").Visible = False
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
        txtStock.Text = dgvProducto.SelectedCells.Item(9).Value
        txtCantidad.Text = ""


        idProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(0).Value
        Producto.idProducto = idProducto
        sqlComando = "SELECT * FROM producto WHERE idProducto='" & Producto.idProducto & "';"
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

    Private Sub txtDescuento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
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

    Private Sub chBoxDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If chBoxDescuento.CheckState = CheckState.Checked Then
            txtDescuento.Enabled = True
        Else
            txtDescuento.Enabled = False
        End If

    End Sub


    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
End Class