Imports MySql.Data.MySqlClient

Public Class frmTipo

    Dim MySql As New Utilidades_MySQL
    Dim sqlComando As String
    Dim idTipo As String
    Dim Nombre As String
    Dim Tipo As New clsTipo
    Dim Tipo2 As New clsTipo

    Private Sub frmCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObtenerDatos()
        'dgvTipo.Columns("Descripcion").Visible = False
        'dgvTipo.Columns("activo").Visible = False
        'dgvTipo.Columns("IdTipoProducto").Visible = False
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        btnEliminar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim consulta As String
        sqlComando = "SELECT * FROM tipoproducto WHERE TipoProducto='" & txtTipo.Text & "';"
        MySql.MiComandoSQL(sqlComando, Tipo)
        consulta = Tipo.TipoProducto

        Try
            If consulta = txtTipo.Text Then
                MsgBox("Este Tipo de calzado ya existe en la base de datos")

            Else
                sqlComando = "INSERT into `zapateria`.`tipoproducto`(`TipoProducto`,`Activo`) VALUES ('" & txtTipo.Text & "',1);"
                MySql.MiComandoSQL(sqlComando)
                MsgBox("El Tipo de calzado " & txtTipo.Text & " ha sido dado de alta ")
                ObtenerDatos()
            End If

            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ObtenerDatos()

        Dim tablaTipo As New DataTable
        MySql.MiComandoSQL("SELECT IdTipoProducto, TipoProducto as categoria, Activo FROM tipoproducto WHERE Activo=1", tablaTipo)
        bscategoria.DataSource = tablaTipo
        dgvTipo.DataSource = bscategoria.DataSource
        dgvTipo.Columns("IdTipoProducto").Visible = False
        dgvTipo.Columns("Activo").Visible = False
        dgvTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub dgvCategoria_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        txtTipo.Text = dgvTipo.SelectedCells.Item(1).Value

        btnGuardar.Visible = False
        btnActualizar.Visible = True
        btnEliminar.Visible = True
        idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        Tipo.idTipoProducto = idTipo
        sqlComando = "SELECT * FROM tipoproducto WHERE IdTipoProducto='" & Tipo.idTipoProducto & "';"
        MySql.MiComandoSQL(sqlComando, Tipo)

    End Sub

    Private Sub limpiar()
        txtTipo.Text = ""
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Resultado As Short
        
        idTipo = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(0).Value
        Nombre = dgvTipo.Rows(dgvTipo.CurrentRow.Index).Cells(1).Value

        Resultado = MsgBox("Desea borrar el Tipo de calzado: " & Nombre, MsgBoxStyle.YesNo)
        Try
            If (Resultado = DialogResult.Yes) Then

                sqlComando = "Update tipoproducto set activo=0 where IdTipoProducto='" & idTipo & "';"
                MySql.MiComandoSQL(sqlComando)
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

        Tipo2.idTipoProducto = Tipo.idTipoProducto
        Tipo2.TipoProducto = txtTipo.Text
        Tipo2.activo = Tipo.activo

        sqlComando = MySql.MiComandoSQL("tipoproducto", Tipo2, Tipo)

        If MySql.MiComandoSQL(sqlComando) Then
            MsgBox("El Tipo de calzado ha sido actualizado")
        Else
            MsgBox("No Se registraron modificaciones")
        End If
        ObtenerDatos()
        limpiar()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Select()
            ObtenerDatos()
        Else
            Dim tablaTipo As New DataTable

            MySql.MiComandoSQL("SELECT * FROM tipoproducto WHERE TipoProducto Like'%" & TextBox1.Text & "%' and activo=1", tablaTipo)
            bscategoria.DataSource = tablaTipo
            dgvTipo.DataSource = bscategoria.DataSource

        End If
    End Sub
End Class