﻿Imports MySql.Data.MySqlClient
Public Class frmProveedor
    Dim MySql As New Utilidades_MySQL
    Public Proveedor As New clsProveedor
    Dim Proveedor2 As New clsProveedor
    Dim idProveedor As Integer
    Dim NombreProveedor As String
    Dim sqlComando As String


    Private Sub frmProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ObtenerDatos()
        dgvProveedor.Columns("activo").Visible = False
        dgvProveedor.Columns("idProveedor").Visible = False
        btnGuardar.Visible = True
        btnActualizar.Visible = False
    End Sub

    Private Sub ObtenerDatos()
        Dim tablaProveedor As New DataTable

        MySql.MiComandoSQL("SELECT * FROM proveedor WHERE activo=1", tablaProveedor)

        bsProveedor.DataSource = tablaProveedor
        dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProveedor.DataSource = bsProveedor.DataSource

    End Sub

    Private Sub dgvProveedor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedor.CellClick

        txtCUIT.Text = dgvProveedor.SelectedCells.Item(1).Value
        txtNombreProveedor.Text = dgvProveedor.SelectedCells.Item(2).Value
        txtDireccionProveedor.Text = dgvProveedor.SelectedCells.Item(3).Value
        txtTelefonoProveedor.Text = dgvProveedor.SelectedCells.Item(4).Value
        txtPaginaWeb.Text = dgvProveedor.SelectedCells.Item(5).Value
        btnGuardar.Visible = False
        btnActualizar.Visible = True

        idProveedor = dgvProveedor.Rows(dgvProveedor.CurrentRow.Index).Cells(0).Value
        Proveedor.idProveedor = idProveedor
        sqlComando = "SELECT * FROM proveedor WHERE idProveedor='" & Proveedor.idProveedor & "';"
        MySql.MiComandoSQL(sqlComando, Proveedor)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub limpiar()
        txtCUIT.Text = ""
        txtNombreProveedor.Text = ""
        txtDireccionProveedor.Text = ""
        txtTelefonoProveedor.Text = ""
        txtPaginaWeb.Text = ""
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Resultado As Short
        idProveedor = dgvProveedor.Rows(dgvProveedor.CurrentRow.Index).Cells(0).Value
        NombreProveedor = dgvProveedor.Rows(dgvProveedor.CurrentRow.Index).Cells(2).Value

        Resultado = MsgBox("Desea borrar el cliente : " & NombreProveedor, MsgBoxStyle.YesNo)
        Try
            If (Resultado = DialogResult.Yes) Then

                sqlComando = "Update proveedor set activo=0 where idProveedor='" & idProveedor & "';"
                MySql.MiComandoSQL(sqlComando)
                MsgBox("El Contacto " & NombreProveedor & " ha sido dado de baja", MsgBoxStyle.Exclamation)
            Else
                MsgBox("El Contacto " & NombreProveedor & " no ha sido dado de baja", MsgBoxStyle.Exclamation)
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
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Proveedor2.idProveedor = Proveedor.idProveedor
        Proveedor2.CUIT = txtCUIT.Text
        Proveedor2.NombreProveedor = txtNombreProveedor.Text
        Proveedor2.DireccionProveedor = txtDireccionProveedor.Text
        Proveedor2.TelefonoProveedor = txtTelefonoProveedor.Text
        Proveedor2.PaginaWeb = txtPaginaWeb.Text
        Proveedor2.activo = Proveedor.activo

        sqlComando = MySql.MiComandoSQL("proveedor", Proveedor2, Proveedor)

        If MySql.MiComandoSQL(sqlComando) Then
            MsgBox("El Proveedor ha sido actualizado")
        Else
            MsgBox("No Se registraron modificaciones")
        End If
        ObtenerDatos()
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim consulta As String

        If txtCUIT.Text = "  -        -" Then
            MsgBox("Falta el ingreso de CUIL", MsgBoxStyle.Information, "Guardar Proveedor")
            txtCUIT.Focus()
            Exit Sub
        ElseIf txtNombreProveedor.Text.Length = 0 Then
            MsgBox("Falta Nombre del Proveedor ", MsgBoxStyle.Information, "Guardar Proveedor")
            txtNombreProveedor.Focus()
            Exit Sub
        ElseIf txtDireccionProveedor.Text = "" Then
            MsgBox("Falta Dirección del Proveedor", MsgBoxStyle.Information, "Guardar Proveedor")
            txtDireccionProveedor.Focus()
            Exit Sub
        ElseIf txtTelefonoProveedor.Text = "" Then
            MsgBox("Falta Telefono del Proveedor", MsgBoxStyle.Information, "Guardar Proveedor")
            txtTelefonoProveedor.Focus()
            Exit Sub
        Else
            Proveedor2 = New clsProveedor
            sqlComando = "SELECT * FROM proveedor WHERE TelefonoProveedor='" & txtTelefonoProveedor.Text & "';"
            MySql.MiComandoSQL(sqlComando, Proveedor2)
            consulta = Proveedor2.NombreProveedor
            Dim active As Integer = Proveedor2.activo
            Try
                If consulta = "" Then
                    sqlComando = "INSERT into `zapateria`.`proveedor`(`CUIT`,`NombreProveedor`,`DireccionProveedor`,`TelefonoProveedor`,`PaginaWebProveedor`,`activo`) VALUES ('" & txtCUIT.Text & "','" & txtNombreProveedor.Text & "','" & txtDireccionProveedor.Text & "','" & txtTelefonoProveedor.Text & "','" & txtPaginaWeb.Text & "',1);"
                    MySql.MiComandoSQL(sqlComando)
                    MsgBox("El Proveedor " & txtNombreProveedor.Text & " ha sido dado de alta ")
                    ObtenerDatos()
                    limpiar()
                Else
                    If active = 1 Then
                        MsgBox("Este teléfono ya existe en la base de datos")
                        txtCUIT.Focus()
                    Else
                        Dim result As Integer = MessageBox.Show("¿El teléfono contiene información asociada. Desea recuperarla?", "Registro de Proveedores", MessageBoxButtons.YesNoCancel)
                        If result = DialogResult.Yes Then

                            If (MySql.MiComandoSQL("`zapateria`.`proveedor`", "Activo=1", "(TelefonoProveedor='" & txtTelefonoProveedor.Text & "' AND IdProveedor <> 0);")) Then
                                MsgBox("El Proveedor " & txtNombreProveedor.Text & " ha sido recuperado!")
                                ObtenerDatos()
                                limpiar()
                            Else
                                MsgBox("Hubo un error recuperando los datos del Proveedor " & txtNombreProveedor.Text)
                                ObtenerDatos()
                                limpiar()
                            End If
                        Else
                            txtCUIT.Focus()
                        End If
                        End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            
        End If

    End Sub


    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        If txtFiltro.Text = "" Then
            txtFiltro.Select()
            ObtenerDatos()
        Else
            Dim tablaProveedor As New DataTable
            MySql.MiComandoSQL("SELECT * FROM proveedor where NombreProveedor Like'%" & txtFiltro.Text & "%' and activo=1", tablaProveedor)
            bsProveedor.DataSource = tablaProveedor
            dgvProveedor.DataSource = bsProveedor.DataSource

        End If
    End Sub
End Class