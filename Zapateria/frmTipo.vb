﻿Imports MySql.Data.MySqlClient

Public Class frmTipo

    Dim MySql As New Utilidades_MySQL
    Dim sqlComando As String
    Dim idTipo As String
    Dim Nombre As String
    Dim Tipo As New clsTipo
    Dim Tipo2 As New clsTipo

    Private Sub frmCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObtenerDatos()
        dgvTipo.Columns("descripcion").Visible = False
        dgvTipo.Columns("activo").Visible = False
        dgvTipo.Columns("idTipo").Visible = False
        btnGuardar.Visible = True
        btnActualizar.Visible = False
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        sqlComando = "INSERT into `agenda`.`tipo`(`nombre`,`descripcion`,`activo`) VALUES ('" & txtTipo.Text & "','" & txtDescripcionTipo.Text & "',1);"
        MySql.MiComandoSQL(sqlComando)
        MsgBox("El Tipo de calzado " & txtTipo.Text & " ha sido dado de alta ")
        ObtenerDatos()
        limpiar()
    End Sub

    Private Sub ObtenerDatos()

        Dim tablaTipo As New DataTable
        MySql.MiComandoSQL("SELECT idTipo, nombre as categoria, descripcion, activo FROM tipo WHERE activo=1", tablaTipo)
        bscategoria.DataSource = tablaTipo
        dgvTipo.DataSource = bscategoria.DataSource

    End Sub

    Private Sub dgvCategoria_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        txtTipo.Text = dgvTipo.SelectedCells.Item(1).Value
        txtDescripcionTipo.Text = dgvTipo.SelectedCells.Item(2).Value.ToString

        btnGuardar.Visible = False
        btnActualizar.Visible = True

        idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        Tipo.idTipo = idTipo
        sqlComando = "SELECT * FROM tipo WHERE idTipo='" & Tipo.idTipo & "';"
        MySql.MiComandoSQL(sqlComando, Tipo)

    End Sub

    Private Sub limpiar()
        txtTipo.Text = ""
        txtDescripcionTipo.Text = ""
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
        btnGuardar.Visible = True
        btnActualizar.Visible = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Resultado As Short
        
        idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        Nombre = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(1).Value

        Resultado = MsgBox("Desea borrar el Tipo de calzado: " & Nombre, MsgBoxStyle.YesNo)
        Try
            If (Resultado = DialogResult.Yes) Then

                sqlComando = "Update tipo set activo=0 where idtipo='" & idTipo & "';"
                MySql.MiComandoSQL(sqlComando)
                MsgBox(sqlComando)
                MsgBox("El Tipo " & Nombre & " ha sido dado de baja", MsgBoxStyle.Exclamation)
            Else
                MsgBox("El Tipo " & Nombre & " no ha sido dado de baja", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        ObtenerDatos()
        btnActualizar.Visible = False
        btnGuardar.Visible = True
        limpiar()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Tipo2.idTipo = Tipo.idTipo
        Tipo2.nombre = txtTipo.Text
        Tipo2.descripcion = txtDescripcionTipo.Text
        Tipo2.activo = Tipo.activo

        sqlComando = MySql.MiComandoSQL("tipo", Tipo2, Tipo)
        MsgBox(sqlComando)
        If MySql.MiComandoSQL(sqlComando) Then
            MsgBox("El Tipo de calzado ha sido actualizado")
        Else
            MsgBox("No Se registraron modificaciones")
        End If
        ObtenerDatos()
        limpiar()
    End Sub
End Class