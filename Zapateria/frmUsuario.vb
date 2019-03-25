Imports MySql.Data.MySqlClient
Public Class frmUsuario
    Dim MySql As New Utilidades_MySQL
    Public Usuario As New clsUsuario
    Dim Usuario2 As New clsUsuario
    Dim IdUsuario As Integer
    Dim Resultado As Short
    Dim Nombre As String
    Dim sqlComando As String


    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet2.tipo_usuario' Puede moverla o quitarla según sea necesario.
        Me.Tipo_usuarioTableAdapter.Fill(Me.ZapateriaDataSet2.tipo_usuario)
        ObtenerDatos()
        limpiar()
        dgvUsuario.Columns("idUsuario").Visible = False
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub ObtenerDatos()
        Dim tablaUsuario As New DataTable

        MySql.MiComandoSQL("SELECT idUsuario, Nombre, Usuario, tipo_usuario.NivelUsuario as Jerarquia FROM usuario,tipo_usuario WHERE idTipoUsuario=Nivel and activo=1", tablaUsuario)

        bsUsuarios.DataSource = tablaUsuario
        dgvUsuario.DataSource = bsUsuarios.DataSource

    End Sub


    Private Sub dgvUsuario_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuario.CellClick
        cmbRoll.Text = dgvUsuario.SelectedCells.Item(3).Value
        txtNombre.Text = dgvUsuario.SelectedCells.Item(1).Value
        txtUsuario.Text = dgvUsuario.SelectedCells.Item(2).Value

        btnGuardar.Visible = False
        btnActualizar.Visible = True
        btnEliminar.Visible = True
        IdUsuario = dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(0).Value
        Usuario.IdUsuario = IdUsuario
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        If txtNombre.Text <> String.Empty And txtUsuario.Text <> String.Empty And txtPass1.Text <> String.Empty Then
            Resultado = MsgBox("Si sale se perdera cualquier cambio realizado", MsgBoxStyle.YesNo)
            If (Resultado = DialogResult.Yes) Then
                Me.Close()
            Else
                MsgBox("Continue Buen Hombre", MsgBoxStyle.Information)
            End If
        Else
            'Me.Close()
        End If


    End Sub
    Private Sub limpiar()
        txtNombre.Text = ""
        txtUsuario.Text = ""
        txtPass1.Text = ""
        txtPass2.Text = ""
        cmbRoll.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
        btnGuardar.Visible = True
        btnActualizar.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        IdUsuario = dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(0).Value
        Nombre = dgvUsuario.Rows(dgvUsuario.CurrentRow.Index).Cells(1).Value
        If IdUsuario = 3 Then
            MsgBox("Este usuario no se puede Borrar pertenece al sistema")
        Else
            Resultado = MsgBox("Desea borrar el Usuario : " & Nombre, MsgBoxStyle.YesNo)
            Try
                If (Resultado = DialogResult.Yes) Then

                    sqlComando = "UPDATE usuario SET activo=0 WHERE IdUsuario='" & IdUsuario & "';"
                    MySql.MiComandoSQL(sqlComando)
                    MsgBox("El Usuario " & Nombre & " ha sido dado de baja", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("El Usuario " & Nombre & " no ha sido dado de baja", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

        ObtenerDatos()
        btnActualizar.Visible = False
        btnGuardar.Visible = True
        limpiar()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Usuario2.IdUsuario = Usuario.IdUsuario
        Usuario2.Nombre = txtNombre.Text
        Usuario2.Jerarquia = cmbRoll.Text
        Usuario2.Usuario = txtUsuario.Text
        Usuario2.Activo = Usuario.Activo

        sqlComando = MySql.MiComandoSQL("usuario", Usuario2, Usuario)
        MsgBox(sqlComando)
        If MySql.MiComandoSQL(sqlComando) Then
            MsgBox("El Usuario ha sido actualizado")
        Else
            MsgBox("No Se registraron modificaciones")
        End If
        ObtenerDatos()
        btnEliminar.Visible = False
        btnActualizar.Visible = False
        btnGuardar.Visible = True
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If txtPass1.Text <> String.Empty And txtPass2.Text <> String.Empty And txtUsuario.Text <> String.Empty And txtNombre.Text <> String.Empty Then
            If txtPass1.Text = txtPass2.Text Then
                sqlComando = "INSERT into `zapateria`.`usuario`(`Nombre`,`Nivel`,`Usuario`,`Contrasenia`,`Activo`) VALUES ('" & txtNombre.Text & "','" & cmbRoll.SelectedValue & "','" & txtUsuario.Text & "','" & txtPass1.Text & "',1);"
                MySql.MiComandoSQL(sqlComando)
                MsgBox("El usuario " & txtUsuario.Text & " fue dado de alta")
                ObtenerDatos()
                limpiar()
            Else
                MsgBox("No coinciden las contraseñas")
            End If
        Else
            MsgBox("Debe llenar todos los campos")
        End If


    End Sub

End Class