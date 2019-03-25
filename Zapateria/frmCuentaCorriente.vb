Imports MySql.Data.MySqlClient

Public Class frmCuentaCorriente

    Dim MySql As New Utilidades_MySQL
    Dim cuentasCorrientes As New clsCuentaCorriente
    Dim IdCC As New Integer
    Dim Cliente As New clsContactos

    Private Sub frmCuentaCorriente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCC()
    End Sub

    Private Sub llenarCC()
        Dim tablaCuentas As New DataTable
        MySql.MiComandoSQL("SELECT IdCuentaCorriente, cc.Activo, c.NombreCliente AS Nombre, Deuda FROM cuentacorriente cc LEFT JOIN cliente c ON c.IdCliente=cc.IdCliente", tablaCuentas)
        bsCuentaCorriente.DataSource = tablaCuentas
        dgvCuentaCorriente.DataSource = bsCuentaCorriente.DataSource
        dgvCuentaCorriente.Columns("Activo").Visible = False
        dgvCuentaCorriente.Columns("IdCuentaCorriente").Visible = False
        dgvCuentaCorriente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub limpiarCampos()
        txtNombreCli.Text = ""
        txtRutCli.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    
    Private Sub dgvCuentaCorriente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentaCorriente.CellClick
        IdCC = dgvCuentaCorriente.SelectedCells.Item(0).Value

        MySql.MiComandoSQL("SELECT * FROM cuentacorriente WHERE IdCuentaCorriente='" & IdCC & "';", cuentasCorrientes)
        MySql.MiComandoSQL("SELECT * FROM cliente WHERE IdCliente='" & cuentasCorrientes.IdCliente & "';", Cliente)

        txtNombreCli.Text = Cliente.NombreCliente
        txtRutCli.Text = Cliente.DocumentoCliente
        TextBox4.Text = Cliente.TelefonoCliente
        TextBox5.Text = cuentasCorrientes.Deuda
        'txtPrecioProducto.Text = dgvCuentaCorriente.SelectedCells.Item(8).Value
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        e.Handled = Utils.isNumberFloat(e)
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        btnGuardar.Enabled = TextBox6.Text <> ""
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim SaldoPendiente As Double = Double.Parse(TextBox5.Text)
        Dim Entrega As Double = Double.Parse(TextBox6.Text)
        If (SaldoPendiente < Entrega) Then
            MsgBox("No puede entregar más de lo que debe")
        Else
            Dim nuevoSaldo As Double = SaldoPendiente - Entrega
            If MySql.MiComandoSQL("cuentacorriente", "Deuda=" & nuevoSaldo, "IdCliente=" & Cliente.IdCliente) Then
                Dim sqlComando As String
                Dim Fecha As String

                sqlComando = "SELECT * FROM `zapateria`.`cuentacorriente` WHERE IdCliente='" & Cliente.IdCliente & "';"
                MySql.MiComandoSQL(sqlComando, cuentasCorrientes)
                Fecha = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
                sqlComando = "INSERT INTO `zapateria`.`movimientos_cc`(`idCC`,`SaldoPrevio`,`SaldoCalculado`,`Movimiento`,`FechaActualizacion`) VALUES ('" & cuentasCorrientes.IdCuentaCorriente & "','" & SaldoPendiente & "','" & nuevoSaldo & "', '" & Entrega & "', '" & Fecha & "');"
                MySql.MiComandoSQL(sqlComando)
                llenarCC()
                MsgBox("Entrega aceptada")
                limpiarCampos()
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Select()
            llenarCC()
        Else
            Dim tablaCuentas As New DataTable

            MySql.MiComandoSQL("SELECT IdCuentaCorriente, cc.Activo, c.NombreCliente AS Nombre, Deuda FROM cuentacorriente cc LEFT JOIN cliente c ON c.IdCliente=cc.IdCliente where c.NombreCliente Like'%" & TextBox1.Text & "%'", tablaCuentas)
            bsCuentaCorriente.DataSource = tablaCuentas
            dgvCuentaCorriente.DataSource = bsCuentaCorriente.DataSource

        End If
    End Sub
End Class