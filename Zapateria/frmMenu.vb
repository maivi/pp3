Imports MySql.Data.MySqlClient
Public Class frmMenu
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        frmLogin.Hide()
        llenarTIPOSUARIO()
        RestriccionUSuario()
    End Sub
    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedores.Click

        frmProveedor.ShowDialog()
    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click
        frmUsuario.ShowDialog()
    End Sub

    Private Sub btnCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategorias.Click
        frmTipo.ShowDialog()
    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        frmProducto.ShowDialog()
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        frmLogin.Show()
        frmLogin.txtContraseña.Text = ""
        frmLogin.txtUsuario.Text = ""

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentas.Click
        frmVenta.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentaCorriente.Click
        frmCuentaCorriente.ShowDialog()
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------

    Public MysqlConexion As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=agenda")
    Public MysqlCommand As New MySqlCommand
    Public oDataAdapter As New MySqlDataAdapter
    Public oDataSet As New DataSet
    Public dr As MySqlDataReader
    Public sSql As String

    Public Sub Conectar()
        Try
            MysqlConexion.Open()
            ' MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub desconectar()
        MysqlConexion.Close()
    End Sub

    Public Sub llenarTIPOSUARIO()
        Try
            MysqlCommand.Connection = MysqlConexion
            MysqlCommand.CommandType = CommandType.Text
            sSql = "SELECT nombre,roll FROM usuarios WHERE usuario ='" & frmLogin.txtUsuario.Text & "' and pass='" & frmLogin.txtContraseña.Text & "' "
            MysqlCommand.CommandText = sSql
            Conectar()
            dr = MysqlCommand.ExecuteReader

            If dr.Read Then
                Me.lblUsuario.Text = dr(0).ToString
                Me.lblRoll.Text = dr(1).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dr.Close()
        desconectar()
    End Sub

    '*** Restringir TIPO DE USUARIOS***
    Public Sub RestriccionUSuario()
        If lblRoll.Text = "Administrador" Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False

        Else
            If Me.lblRoll.Text = "Cajero" Then
                PictureBox1.Visible = False
                PictureBox2.Visible = True

                Me.btnUsuarios.Enabled = False
                Me.btnReportes.Enabled = False
                btnCategorias.Visible = False
                btnProductos.Visible = False
                btnProveedores.Visible = False
                btnUsuarios.Visible = False
                btnReportes.Visible = False


            End If
        End If
        If (lblRoll.Text = "Cajero") Then

            btnUsuarios.Enabled = False

        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        LblHora.Text = Now.ToLongTimeString
        LblFecha.Text = Now.ToLongDateString
    End Sub
End Class
