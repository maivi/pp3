Imports MySql.Data.MySqlClient

Public Class frmCliente
    Dim MySql As New Utilidades_MySQL
    Public Cliente As New clsContactos
    Dim Cliente2 As New clsContactos
    Dim IdCliente As Integer
    Dim NombreCliente As String
    Dim sqlComando As String
    Dim Resultado As Short

    Private Sub frmContactos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ObtenerDatos()
        dgvContactos.Columns("activo").Visible = False
        dgvContactos.Columns("idCliente").Visible = False
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub ObtenerDatos()
        Dim tablaContactos As New DataTable

        MySql.MiComandoSQL("SELECT IdCliente, TipoDocumento, DocumentoCliente as Documento, NombreCliente  as Nombre, DireccionCliente as Direccion, TelefonoCliente as Telefono, Activo FROM cliente WHERE activo=1", tablaContactos)

        bsContactos.DataSource = tablaContactos
        dgvContactos.DataSource = bsContactos.DataSource

    End Sub

    Private Sub dgvContactos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvContactos.CellClick

        cmbDocCliente.Text = dgvContactos.SelectedCells.Item(1).Value
        txtDniCliente.Text = dgvContactos.SelectedCells.Item(2).Value
        txtNombreCliente.Text = dgvContactos.SelectedCells.Item(3).Value
        txtDireccionCliente.Text = dgvContactos.SelectedCells.Item(4).Value
        txtTelefonoCliente.Text = dgvContactos.SelectedCells.Item(5).Value
        btnGuardar.Visible = False
        btnActualizar.Visible = True
        btnEliminar.Visible = True
        IdCliente = dgvContactos.Rows(dgvContactos.CurrentRow.Index).Cells(0).Value
        Cliente.IdCliente = IdCliente
        'sqlComando = "SELECT * FROM cliente WHERE IdCliente='" & Cliente.IdCliente & "';"
        'MySql.MiComandoSQL(sqlComando, Cliente)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        If txtNombreCliente.Text <> String.Empty And txtDniCliente.Text <> String.Empty And txtDireccionCliente.Text <> String.Empty Then
            Resultado = MsgBox("Si sale se perdera cualquier cambio realizado", MsgBoxStyle.YesNo)
            If (Resultado = DialogResult.Yes) Then
                Me.Close()
            Else
                MsgBox("Continue Buen Hombre", MsgBoxStyle.Information)
            End If
        Else
            Me.Close()
        End If


    End Sub

    Private Sub limpiar()
        txtDireccionCliente.Text = ""
        txtDniCliente.Text = ""
        txtNombreCliente.Text = ""
        txtTelefonoCliente.Text = ""
        cmbDocCliente.Text = ""
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        IdCliente = dgvContactos.Rows(dgvContactos.CurrentRow.Index).Cells(0).Value
        NombreCliente = dgvContactos.Rows(dgvContactos.CurrentRow.Index).Cells(3).Value

        Resultado = MsgBox("Desea borrar el cliente : " & NombreCliente, MsgBoxStyle.YesNo)
        Try
            If (Resultado = DialogResult.Yes) Then

                sqlComando = "UPDATE cliente SET activo=0 WHERE IdCliente='" & IdCliente & "';"
                MySql.MiComandoSQL(sqlComando)
                MsgBox("El Cliente " & NombreCliente & " ha sido dado de baja", MsgBoxStyle.Exclamation)
            Else
                MsgBox("El Cliente " & NombreCliente & " no ha sido dado de baja", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        ObtenerDatos()
        btnActualizar.Visible = False
        btnGuardar.Visible = True
        limpiar()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Cliente2.IdCliente = Cliente.IdCliente
        Cliente2.TipoDocumento = cmbDocCliente.Text
        Cliente2.DocumentoCliente = txtDniCliente.Text
        Cliente2.NombreCliente = txtNombreCliente.Text
        Cliente2.DireccionCliente = txtDireccionCliente.Text
        Cliente2.TelefonoCliente = txtTelefonoCliente.Text
        Cliente2.Activo = Cliente.Activo

        sqlComando = MySql.MiComandoSQL("cliente", Cliente2, Cliente)

        If MySql.MiComandoSQL(sqlComando) Then
            MsgBox("El Cliente ha sido actualizado")
        Else
            MsgBox("No Se registraron modificaciones")
        End If
        ObtenerDatos()
        btnEliminar.Visible = False
        btnActualizar.Visible = False

        limpiar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim consulta As String

        If cmbDocCliente.Text = "" Then
            MsgBox("Seleccione tipo de Documento", MsgBoxStyle.Information, "Guardar artículo")
            cmbDocCliente.Focus()
            Exit Sub
        ElseIf txtDniCliente.Text.Length = 0 Then
            MsgBox("Falta DNI ", MsgBoxStyle.Information, "Guardar artículo")
            txtDniCliente.Focus()
            Exit Sub
        ElseIf txtNombreCliente.Text = "" Then
            MsgBox("Falta Nombre del Cliente", MsgBoxStyle.Information, "Guardar artículo")
            txtNombreCliente.Focus()
            Exit Sub
        ElseIf txtDireccionCliente.Text = "" Then
            MsgBox("Falta Dirección del Cliente", MsgBoxStyle.Information, "Guardar artículo")
            txtDireccionCliente.Focus()
            Exit Sub
        ElseIf txtTelefonoCliente.Text = "(   )   -" Then
            MsgBox("Falta Teléfono del Cliente", MsgBoxStyle.Information, "Guardar artículo")
            txtTelefonoCliente.Focus()
            Exit Sub
        Else
            Cliente = New clsContactos
            sqlComando = "SELECT * FROM cliente WHERE DocumentoCliente='" & txtDniCliente.Text & "';"
            MySql.MiComandoSQL(sqlComando, Cliente)
            consulta = Cliente.DocumentoCliente
            Dim active As Integer = Cliente.Activo
            Try
                If consulta = "" Then

                    If Me.ValidateChildren And cmbDocCliente.Text <> String.Empty And txtNombreCliente.Text <> String.Empty And txtDniCliente.Text <> String.Empty And txtDireccionCliente.Text <> String.Empty Then

                        sqlComando = "INSERT into `zapateria`.`cliente`(`TipoDocumento`,`DocumentoCliente`,`NombreCliente`,`DireccionCliente`,`TelefonoCliente`,`Activo`) VALUES ('" & cmbDocCliente.Text & "','" & txtDniCliente.Text & "','" & txtNombreCliente.Text & "','" & txtDireccionCliente.Text & "','" & txtTelefonoCliente.Text & "',1);"
                        MySql.MiComandoSQL(sqlComando)
                        MsgBox("El Cliente " & txtNombreCliente.Text & " ha sido dado de alta ")
                        ObtenerDatos()
                        limpiar()

                    Else
                        MessageBox.Show("Ingrese correctamente algunos Datos remarcados", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    If active = 1 Then
                        MsgBox("Este DNI ya existe en la base de datos")
                        txtDniCliente.Focus()
                    Else
                        Dim result As Integer = MessageBox.Show("¿El DNI contiene información asociada. Desea recuperarla?", "Registro de Usuarios", MessageBoxButtons.YesNoCancel)
                        If result = DialogResult.Yes Then
                            'sqlComando = "UPDATE `zapateria`.`cliente` SET Activo=1 WHERE DocumentoCliente=" & consulta & ";"
                            MySql.MiComandoSQL("`zapateria`.`cliente`", "Activo=1", "DocumentoCliente=" & consulta)
                            MsgBox("El Cliente " & txtNombreCliente.Text & " ha sido dado de alta ")
                            ObtenerDatos()
                            limpiar()
                        Else
                            txtDniCliente.Focus()
                        End If
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtDniCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDniCliente.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese el Documento del Cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtNombreCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreCliente.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese el Nombre del Cliente, este dato es obligatorio")
        End If
    End Sub

    'Private Sub cmbDocCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbDocCliente.Validating
    '    If DirectCast(sender, ComboBox).Text.Length > 0 Then
    '        Me.ErrorProvider1.SetError(sender, "")
    '    Else
    '        Me.ErrorProvider1.SetError(sender, "Ingrese Tipo de Documento, este dato es obligatorio")
    '    End If
    'End Sub

    Private Sub txtDireccionCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccionCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese Domicilio del Cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtTelefonoCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefonoCliente.Validated
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese Numero de Telefono, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDNICliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDniCliente.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefonoCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoCliente.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltroCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltroCliente.TextChanged

        If txtFiltroCliente.Text = "" Then
            txtFiltroCliente.Select()
            ObtenerDatos()
        Else
            Dim tablaProductos As New DataTable

            MySql.MiComandoSQL("SELECT * FROM cliente where NombreCliente Like'%" & txtFiltroCliente.Text & "%' and activo=1 || DocumentoCliente Like'%" & txtFiltroCliente.Text & "%' and activo=1", tablaProductos)
            bsContactos.DataSource = tablaProductos
            dgvContactos.DataSource = bsContactos.DataSource

        End If
    End Sub

End Class