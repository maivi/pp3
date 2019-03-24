Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private MySql As New Utilidades_MySQL
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand

    Private Sub btnAcceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceder.Click
        validar()
    End Sub
    Private Sub Login_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmPresentacion.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            validar()
        End If
    End Sub
    Private Sub btnSalir2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtContraseña.Clear()
        txtUsuario.Clear()
    End Sub

    Private Sub validar()
        If txtUsuario.Text = "" And txtContraseña.Text = "" Then
            MsgBox("Los Campos no pueden estar Vacios", vbInformation, "Sistema!")
            txtUsuario.Select()
        ElseIf (txtUsuario.Text = "" Or txtContraseña.Text = "") Then
            MsgBox("Debe Lenar todos los campos", vbInformation, "Sistema!")
        ElseIf (txtUsuario.Text <> "" And txtContraseña.Text <> "") <> (txtUsuario.Text = "" And txtContraseña.Text = "") Then

            Dim sql As String = "SELECT * FROM usuario WHERE Usuario='" & txtUsuario.Text & "' AND Contrasenia='" & txtContraseña.Text & "' AND Activo= 1 "
            Dim cantReg As Integer = MySql.cantReg(sql)
            If cantReg > 0 Then
                frmMenu.Show()
                Me.Hide()
            Else
                MsgBox("USUARIO NO REGISTRADO", vbCritical, "Invalid Login")
            End If
        End If
    End Sub
End Class