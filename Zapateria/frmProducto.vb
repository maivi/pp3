Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class frmProducto
    Dim MySql As New Utilidades_MySQL
    Dim Producto As New clsProducto
    Dim Producto2 As New clsProducto
    Dim idProducto As Integer
    Dim NombreProducto As String
    Dim sqlComando As String

    Private Sub frmProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardgProducto()
        dgvProducto.Columns("activo").Visible = False
        dgvProducto.Columns("IdProducto").Visible = False
        btnGuardar.Visible = True
        btnActualizar.Visible = False
    End Sub

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
        MySql.MiComandoSQL("SELECT IdProducto, CodigoProducto as Codigo, GeneroProducto as Genero, NombreProducto as Producto, TalleProducto as Talle, TipoProducto as tipo, Proveedor, PrecioCompra, PrecioVenta, Stock, Activo FROM producto WHERE activo=1", tablaProducto)
        bsProductos.DataSource = tablaProducto
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
        dgvTipo.Columns("IdTipoProducto").Visible = False
    End Sub

    Private Sub llenardgProveedor()
        Dim tablaProveedor As New DataTable
        panelProveedor.Show()
        panelCategoria.Hide()
        panelProducto.Hide()

        MySql.MiComandoSQL("SELECT * FROM proveedor WHERE activo=1", tablaProveedor)
        bsProveedor.DataSource = tablaProveedor
        dgvProveedor.DataSource = bsProveedor.DataSource
        dgvProveedor.Columns("idproveedor").Visible = False
        dgvProveedor.Columns("activo").Visible = False
    End Sub


    Private Sub dgvTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        Dim idTipo As String
        Dim Tipo As New clsTipo

        txtTipo.Text = dgvTipo.SelectedCells.Item(1).Value
        idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        Tipo.idTipo = idTipo
        sqlComando = "SELECT * FROM tipoproducto WHERE IdTipoProducto='" & Tipo.idTipo & "';"
        MySql.MiComandoSQL(sqlComando, Tipo)
    End Sub


    Private Sub dgvProveedor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedor.CellClick
        Dim idProveedor As String
        Dim Proveedor As New clsProveedor

        txtProveedor.Text = dgvProveedor.SelectedCells.Item(2).Value
        idProveedor = dgvProveedor.Rows(dgvProveedor.CurrentRow.Index).Cells(0).Value
        Proveedor.idProveedor = idProveedor
        sqlComando = "SELECT * FROM proveedor WHERE IdProveedor='" & Proveedor.idProveedor & "';"
        MySql.MiComandoSQL(sqlComando, Proveedor)

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren And txtCodigo.Text <> String.Empty And txtNombre.Text <> String.Empty And txtPreCompra.Text <> String.Empty And txtPreVenta.Text <> String.Empty And txtProveedor.Text <> String.Empty And txtStockInicial.Text <> String.Empty And txtTalle.Text <> String.Empty And txtTipo.Text <> String.Empty Then
            sqlComando = "INSERT into `zapateria`.`producto`( `CodigoProducto` , `GeneroProducto` , `NombreProducto` , `TalleProducto` , `TipoProducto` , `Proveedor`, `PrecioCompra`, `PrecioVenta`,`Stock`, `Activo`) VALUES ('" & txtCodigo.Text & "','" & cboGenero.Text & "','" & txtNombre.Text & "','" & txtTalle.Text & "','" & txtTipo.Text & "','" & txtProveedor.Text & "','" & txtPreCompra.Text & "','" & txtPreVenta.Text & "','" & txtStockInicial.Text & "',1);"
            MySql.MiComandoSQL(sqlComando)
            MsgBox(sqlComando)
            MsgBox("El Producto " & txtNombre.Text & " ha sido dado de alta ", MessageBoxIcon.Error)
            llenardgProducto()
            limpiar()
        End If
        MessageBox.Show("Debe llenar todos los campos requeridos")



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

        idProducto = dgvProducto.Rows(dgvProducto.CurrentRow.Index).Cells(0).Value
        Producto.idProducto = idProducto
        sqlComando = "SELECT * FROM producto WHERE IdProducto='" & Producto.idProducto & "';"
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
        Producto2.activo = Producto.activo

        sqlComando = MySql.MiComandoSQL("producto", Producto2, Producto)
        MsgBox(sqlComando)
        If MySql.MiComandoSQL(sqlComando) Then
            MsgBox("El Producto ha sido actualizado")
        Else
            MsgBox("No Se registraron modificaciones")
        End If
        llenardgProducto()
        limpiar()
    End Sub
    Private Sub ControlLlenado()
        If txtCodigo.Text.Length = 0 Then
            ErrorProvider1.SetError(txtCodigo, "Debe llenar el campo Codigo")
        End If
    End Sub

    Private Sub txtCodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub txtPreCompra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPreCompra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub txtPreVenta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPreVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub txtProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtProveedor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub txtStockInicial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStockInicial.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub txtTalle_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTalle.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub txtTipo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub

    Private Sub cboGenero_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboGenero.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
        Me.ErrorProvider1.SetError(sender, "Este dato es Obligatorio")
    End Sub
End Class