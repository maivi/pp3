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


                Dim Hora As String = Date.Now.Hour
                Dim Minutos As String = Date.Now.Minute
                Dim Segundos As String = Date.Now.Second

                Dim Dia As String = Date.Now.Day
                Dim Mes As String = Date.Now.Year

                If (Dia < 10) Then
                    If Not Dia.Contains(0) Then
                        Dia = "0" & Dia
                    End If
                End If

                If (Mes < 10) Then
                    If Not Mes.Contains(0) Then
                        Mes = "0" & Mes
                    End If
                End If

                If (Hora < 10) Then
                    If Not Hora.Contains(0) Then
                        Hora = "0" & Hora
                    End If
                End If

                If (Minutos < 10) Then
                    If Not Minutos.Contains(0) Then
                        Minutos = "0" & Minutos
                    End If
                End If

                If (Segundos < 10) Then
                    If Not Segundos.Contains(0) Then
                        Segundos = "0" & Segundos
                    End If
                End If

                Fecha = Date.Now.Year & "/" & Mes & "/" & Dia & " " & Hora & ":" & Minutos & ":" & Segundos
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