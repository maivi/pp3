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


    Private Sub dgvUsuario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuario.CellContentClick
        cmbRoll.Text = dgvUsuario.SelectedCells.Item(3).Value
        txtNombre.Text = dgvUsuario.SelectedCells.Item(1).Value
        txtUsuario.Text = dgvUsuario.SelectedCells.Item(2).Value
        
        btnGuardar.Visible = False
        btnActualizar.Visible = True
        btnEliminar.Visible = True
        lblContraseña.Visible = False
        lblRepetContraseña.Visible = False
        txtPass1.Visible = False
        txtPass2.Visible = False
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
        lblContraseña.Visible = True
        lblRepetContraseña.Visible = True
        txtPass1.Visible = True
        txtPass2.Visible = True
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

        If txtPass1.Text <> String.Empty And txtPass2.Text <> String.Empty Then


            If txtPass1.Text = txtPass2.Text Then
                MsgBox("Son iguales gil")
            Else
                MsgBox("NO Son iguales gil")
            End If
        Else
            MsgBox("LLena todo gil")
        End If


    End Sub

End Class